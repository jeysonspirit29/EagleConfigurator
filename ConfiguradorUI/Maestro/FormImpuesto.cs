﻿using ConfigBusinessEntity;
using ConfigBusinessLogic;
using ConfigBusinessLogic.Utiles;
using ConfiguradorUI.FormUtil;
using ConfigUtilitarios;
using ConfigUtilitarios.HelperControl;
using ConfigUtilitarios.KeyValues;
using MetroFramework.Components;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfiguradorUI.Maestro
{
    public partial class FormImpuesto : MetroForm
    {
        #region Variables
        bool isSelected = false;
        bool isChangedRow = false;
        bool isPending = false;
        bool preguntar = true;
        public bool actualizar = false;
        private int TipoOperacion = TipoOperacionABM.No_Action;

        string codSelected = "";
        MetroToolTip tooltip;
        public ICollection<int> colaIdsActualizados;
        #endregion

        public FormImpuesto()
        {
            InitializeComponent();
        }

        #region Métodos de ventana

        private void AddHandlers()
        {
            //Form
            KeyPreview = true;
            KeyDown += ControlHelper.FormCloseShiftEsc_KeyDown;

            //Agregando Handlers que se disparan al cambiar el contenido, estado o selección
            var decimalsTxt = new[]{ txtPorcentaje01,
                                txtPorcentaje02,
                                txtPorcentaje03,
                                txtPorcentaje04,
                                txtPorcentaje05,
                                txtPorcentaje06,
                                txtPorcentaje07,
                                txtPorcentaje08 };


            var txts = new[] { txtNombre,
                                txtAbreviacion,
                                txtCodigo };
            foreach (var txt in txts)
            {
                txt.TextChanged += new EventHandler(OnContentChanged);
            }
            foreach (var txt in decimalsTxt)
            {
                txt.TextChanged += new EventHandler(OnContentChanged);
                txt.KeyPress += ValidarTxtDecimal;
            }

            var chks = new[] { chkActivo };

            foreach (var chk in chks)
            {
                chk.CheckedChanged += new EventHandler(OnContentChanged);
            }
        }

        protected void OnContentChanged(object sender, EventArgs e)
        {
            if (isSelected && isChangedRow == false && TipoOperacion != TipoOperacionABM.Cambio)
            {
                TipoOperacion = TipoOperacionABM.Cambio;
                ControlarEventosABM();
            }
        }

        private void CambioEnControl(object sender, EventArgs e)
        {
            //invocado con el IDE (por repetición).
            isChangedRow = false;
        }

        private void CambioEnControlYCalcularAcumulado(object sender, EventArgs e)
        {

            isChangedRow = false;

            var decimalsTxt = new[]{ txtPorcentaje01,
                                txtPorcentaje02,
                                txtPorcentaje03,
                                txtPorcentaje04,
                                txtPorcentaje05,
                                txtPorcentaje06,
                                txtPorcentaje07,
                                txtPorcentaje08 };

            try
            {
                decimal porcentajeAcumulado = 0;
                foreach (var txt in decimalsTxt)
                {
                    if (decimal.TryParse(txt.Text, out decimal porc))
                    {
                        porcentajeAcumulado += porc;
                    }
                }
                lblPorcentajeAcumulado.Text = porcentajeAcumulado + " %";
            }
            catch (Exception ex)
            {
                lblPorcentajeAcumulado.Text = "0 %";
                Msg.Ok_Err($"No se pudo calcular el porcentaje acumulado. ERROR: {ex.Message}");
            }
        }
        private void ValidarTxtDecimal(object sender, KeyPressEventArgs e)
        {
            MetroTextBox txt = (MetroTextBox)sender;
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (e.KeyChar == '.')
                {
                    e.Handled = txt.Text.Contains(".") || txt.Text.Equals("") ?
                           true : false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void Commit()
        {
            try
            {
                if (TipoOperacion == TipoOperacionABM.Insertar)
                {
                    if (EsValido())
                    {
                        var obj = new MSTt06_impuesto();
                        obj = GetObjeto();
                        int id = new ImpuestoBL().InsertarImpuesto(obj);
                        actualizar = true;
                        ControlarEventosABM(id);
                    }
                }
                else
                {
                    Actualizar();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción en el commit:" + e.Message, "MENSAJE");
            }

        }
        private void Eliminar()
        {
            if (TipoOperacion == TipoOperacionABM.Eliminar)
            {
                if (dgvImpuesto.RowCount > 0)
                {
                    if (dgvImpuesto.SelectedRows.Count > 0)
                    {
                        try
                        {
                            int id = 0;
                            if (int.TryParse(lblIdImpuesto.Text, out id) && id > 0)
                            {
                                DialogResult rp = MessageBox.Show("¿Seguro de eliminar el registro?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (rp == DialogResult.Yes)
                                {
                                    if (EsEliminacionValida(id))
                                    {
                                        new ImpuestoBL().EliminarImpuesto(id);
                                        actualizar = true;
                                        ControlarEventosABM();
                                    }
                                    else
                                    {
                                        TipoOperacion = TipoOperacionABM.No_Action;
                                        ControlarEventosABM();
                                        MessageBox.Show(this, "Este registro no se puede eliminar porque se usa en otro lado.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show(this, "El ID es incorrecto.", "MENSAJE");
                            }
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(this, "Ocurrió una excepción en el intento de eliminación: " + e.Message, "MENSAJE");
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "No se ha seleccinado ningún registro.", "MENNSAJE");
                    }
                }
                else
                {
                    MessageBox.Show(this, "No hay registros", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
        private bool Actualizar()
        {
            bool isValid = false;
            try
            {
                if (TipoOperacion == TipoOperacionABM.Modificar && isSelected && isPending)
                {
                    if (EsValido())
                    {
                        var obj = new MSTt06_impuesto();
                        obj = GetObjeto();
                        int id = 0;
                        if (int.TryParse(lblIdImpuesto.Text, out id))
                        {
                            obj.id_impuesto = id;
                            bool success = new ImpuestoBL().ActualizarImpuesto(obj);
                            actualizar = true;
                            colaIdsActualizados.Add(id);
                            ControlarEventosABM(obj.id_impuesto);
                            if (!success)
                            {
                                MessageBox.Show("No se pudo actualizar el impuesto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        isValid = true;
                    }
                    else { isValid = false; }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió una excepción en Actualizar el registro: " + e.Message);
            }
            return isValid;
        }
        private bool ActualizarEnCheck()
        {
            bool isValid = false;
            try
            {
                if (TipoOperacion == TipoOperacionABM.Modificar && isSelected && isPending)
                {
                    if (EsValido())
                    {
                        var obj = new MSTt06_impuesto();
                        obj = GetObjeto();
                        int id = 0;
                        if (int.TryParse(lblIdImpuesto.Text, out id))
                        {
                            obj.id_impuesto = id;
                            bool success = new ImpuestoBL().ActualizarImpuesto(obj);
                            actualizar = true;
                            colaIdsActualizados.Add(id);
                            if (!success)
                            {
                                MessageBox.Show("No se pudo actualizar el impuesto.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        isValid = true;
                    }
                    else { isValid = false; }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió una excepción en Actualizar en Check: " + e.Message);
            }
            return isValid;
        }

        private MSTt06_impuesto GetObjeto()
        {
            var obj = new MSTt06_impuesto();
            try
            {

                obj.id_estado = chkActivo.Checked ? Estado.IdActivo : Estado.IdInactivo;
                obj.txt_estado = chkActivo.Checked ? Estado.TxtActivo : Estado.TxtInactivo;

                obj.txt_desc = txtNombre.Text.Trim();
                obj.txt_abrv = txtAbreviacion.Text.Trim();
                obj.cod_impuesto = txtCodigo.Text.Trim();

                if (decimal.TryParse(txtPorcentaje01.Text, out decimal porc01))
                { obj.por_impto01 = porc01; }
                if (decimal.TryParse(txtPorcentaje02.Text, out decimal porc02))
                { obj.por_impto02 = porc02; }
                if (decimal.TryParse(txtPorcentaje03.Text, out decimal porc03))
                { obj.por_impto03 = porc03; }
                if (decimal.TryParse(txtPorcentaje04.Text, out decimal porc04))
                { obj.por_impto04 = porc04; }
                if (decimal.TryParse(txtPorcentaje05.Text, out decimal porc05))
                { obj.por_impto05 = porc05; }
                if (decimal.TryParse(txtPorcentaje06.Text, out decimal porc06))
                { obj.por_impto06 = porc06; }
                if (decimal.TryParse(txtPorcentaje07.Text, out decimal porc07))
                { obj.por_impto07 = porc07; }
                if (decimal.TryParse(txtPorcentaje08.Text, out decimal porc08))
                { obj.por_impto08 = porc08; }

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Excepción en el Get: " + e.Message);
            }

            return obj;
        }
        private void SetObjeto(MSTt06_impuesto obj)
        {
            try
            {
                // Variable de la lógica de cambio.
                // Indica que la asignación de los datos de un reg se está dando
                // porque se cambió de fila.
                isChangedRow = true;
                LimpiarForm();

                chkActivo.Checked = (obj.id_estado == Estado.IdActivo) ? true : false;

                lblIdImpuesto.Text = obj.id_impuesto.ToString();
                codSelected = obj.cod_impuesto;

                txtNombre.Text = obj.txt_desc;
                txtAbreviacion.Text = obj.txt_abrv;
                txtCodigo.Text = obj.cod_impuesto;

                txtPorcentaje01.Text = obj.por_impto01?.RemoveTrailingZeros();
                txtPorcentaje02.Text = obj.por_impto02?.RemoveTrailingZeros();
                txtPorcentaje03.Text = obj.por_impto03?.RemoveTrailingZeros();
                txtPorcentaje04.Text = obj.por_impto04?.RemoveTrailingZeros();
                txtPorcentaje05.Text = obj.por_impto05?.RemoveTrailingZeros();
                txtPorcentaje06.Text = obj.por_impto06?.RemoveTrailingZeros();
                txtPorcentaje07.Text = obj.por_impto07?.RemoveTrailingZeros();
                txtPorcentaje08.Text = obj.por_impto08?.RemoveTrailingZeros();
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Excepción en el Set: " + e.Message);
            }
        }

        private bool EsValido()
        {
            //Por ver - validar combos.
            bool no_error = true;
            //validando los controles para el tabPageGeneral
            //Foreach en caso se requiera validar más controles - por ver.
            errorProv.Clear();


            if (txtNombre.Text.Trim().Length == 0)
            {
                tabImpuesto.SelectedTab = tabPagGeneral;
                errorProv.SetError(txtNombre, "Este campo es requerido.");
                txtNombre.Focus();
                no_error = false;
            }


            #region 


            if (no_error)
            {
                string cod = txtCodigo.Text.Trim();
                if (cod.Length > 0)
                {
                    if (int.TryParse(cod, out int numCod) && numCod == Reserved.Code)
                    {
                        tabImpuesto.SelectedTab = tabPagGeneral;
                        string msg = $"El código '{Reserved.Code.ToString()}' es reservado para el sistema.";
                        MessageBox.Show(msg, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        errorProv.SetError(txtCodigo, msg);
                        txtCodigo.Focus();
                        no_error = false;
                    }
                    else
                    {
                        var obj = new ImpuestoBL().ImpuestoXCod(cod);
                        if (TipoOperacion == TipoOperacionABM.Insertar)
                        {
                            if (obj != null && obj.id_impuesto > 0)
                            {
                                tabImpuesto.SelectedTab = tabPagGeneral;
                                MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                errorProv.SetError(txtCodigo, "El código ya está en uso.");
                                txtCodigo.Focus();
                                no_error = false;
                            }
                        }
                        else if (TipoOperacion == TipoOperacionABM.Modificar)
                        {
                            if (cod != codSelected && obj != null && obj.id_impuesto > 0)
                            {
                                tabImpuesto.SelectedTab = tabPagGeneral;
                                MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                errorProv.SetError(txtCodigo, "El código ya está en uso.");
                                txtCodigo.Focus();
                                no_error = false;
                            }
                        }

                    }

                }
            }

            #endregion

            if (no_error && txtAbreviacion.Text.Trim().Length == 0)
            {
                tabImpuesto.SelectedTab = tabPagGeneral;
                errorProv.SetError(txtAbreviacion, "Este campo es requerido.");
                txtAbreviacion.Focus();
                no_error = false;
            }


            #region validación numérica

            if (no_error)
            {
                /*
                 Item1 : caja de texto del porcentaje
                 Item2: label del símbolo del porcentaje(%) del textbox
                 */
                var decimalsTxt = new List<Tuple<MetroTextBox, MetroLabel>>{
                               new Tuple<MetroTextBox, MetroLabel>(txtPorcentaje08,lblSimboloPorc08),
                               new Tuple<MetroTextBox, MetroLabel>(txtPorcentaje07,lblSimboloPorc07),
                               new Tuple<MetroTextBox, MetroLabel>(txtPorcentaje06,lblSimboloPorc06),
                               new Tuple<MetroTextBox, MetroLabel>(txtPorcentaje05,lblSimboloPorc05),
                               new Tuple<MetroTextBox, MetroLabel>(txtPorcentaje04,lblSimboloPorc04),
                               new Tuple<MetroTextBox, MetroLabel>(txtPorcentaje03,lblSimboloPorc03),
                               new Tuple<MetroTextBox, MetroLabel>(txtPorcentaje02,lblSimboloPorc02),
                               new Tuple<MetroTextBox, MetroLabel>(txtPorcentaje01,lblSimboloPorc01),
                                };

                var esVacio = true;
                foreach (var txt in decimalsTxt)
                {
                    if (txt.Item1.Text.Trim().Length > 0)
                    {
                        decimal num = 0;
                        esVacio = false;

                        if (!decimal.TryParse(txt.Item1.Text, out num))
                        {
                            tabImpuesto.SelectedTab = tabPagGeneral;
                            errorProv.SetError(txt.Item2, "Tiene que ingresar un número.");
                            txt.Item1.Focus();
                            no_error = false;
                        }
                        else
                        {
                            if (!(num > 0 && num <= KeyAmounts.MaxAmount))
                            {
                                tabImpuesto.SelectedTab = tabPagGeneral;
                                errorProv.SetError(txt.Item2, "El porcentaje tiene que ser mayor que 0 y menor que 10000000000.");
                                txt.Item1.Focus();
                                no_error = false;
                            }
                        }
                    }
                }

                if (esVacio)
                {
                    Msg.Ok_Wng("Por lo menos, debe ingresar un porcentaje de impuesto.", "Validación");
                    txtPorcentaje01.Focus();
                    no_error = false;
                }
            }

            #endregion

            #region validación delete

            if (no_error && !chkActivo.Checked && TipoOperacion == TipoOperacionABM.Modificar)
            {
                int id = 0;
                if (int.TryParse(lblIdImpuesto.Text, out id))
                {
                    if (!EsEliminacionValida(id))
                    {
                        MessageBox.Show(this, "Este registro no se puede desactivar porque se usa en otro lado.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabImpuesto.SelectedTab = tabPagGeneral;
                        errorProv.SetError(chkActivo, "No puede desactivarlo, está usándose en otro lado.");
                        chkActivo.Focus();
                        no_error = false;
                    }
                }
                else
                {
                    MessageBox.Show(this, "No se pudo obtener el id para verificar la validación.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    no_error = false;
                }
            }
            #endregion

            return no_error;
        }

        private bool EsEliminacionValida(int id)
        {
            bool validDelete = new UtilBL().ValidarDelete(id, CodValDelete.Impuesto_Producto);
            if (validDelete)
            {
                validDelete = new UtilBL().ValidarDelete(id, CodValDelete.Impuesto_ComboVariable);
            }
            if (validDelete)
            {
                validDelete = new UtilBL().ValidarDelete(id, CodValDelete.Impuesto_Combo);
            }
            return validDelete;
        }

        private void Filtrar(int criterio, string filtro)
        {
            int index = 0;
            try
            {
                //si no haya alguna fila con el id enviado, signfica que no está el id

                if (criterio == Filtro.Nombre)
                {
                    DataGridViewRow row = dgvImpuesto.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["NOMBRE"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvImpuesto.Rows.Count > 0)
                        {
                            dgvImpuesto.Rows[index].Selected = true;
                            dgvImpuesto.FirstDisplayedScrollingRowIndex = index;
                        }
                    }
                }
                else if (criterio == Filtro.Codigo)
                {
                    DataGridViewRow row = dgvImpuesto.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["CODIGO"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvImpuesto.Rows.Count > 0)
                        {
                            dgvImpuesto.Rows[index].Selected = true;
                            dgvImpuesto.FirstDisplayedScrollingRowIndex = index;
                        }
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al seleccionar el registro: " + e.Message, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SeleccionarPorId(int id)
        {
            int index = 0;
            try
            {
                //si no haya alguna fila con el id enviado, signfica que no está el id
                DataGridViewRow row = dgvImpuesto.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["id_impuesto"].Value.ToString().Equals(id.ToString()))
                .FirstOrDefault();
                if (row != null)
                {
                    index = row.Index;
                    if (dgvImpuesto.Rows.Count > 0)
                    {
                        dgvImpuesto.Rows[index].Selected = true;
                        dgvImpuesto.FirstDisplayedScrollingRowIndex = index;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al seleccionar el registro: " + e.Message, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void SeleccionarRegistro()
        {
            isPending = false;
            if (dgvImpuesto.RowCount > 0 && dgvImpuesto.SelectedRows.Count > 0 && dgvImpuesto.CurrentRow.Index != -1)
            {
                int id = 0;
                if (int.TryParse(GetIdSelected(), out id))
                {
                    if (id > 0)
                    {
                        var obj = new ImpuestoBL().ImpuestoXId(id);
                        if (obj != null)
                        {
                            isSelected = false;
                            SetObjeto(obj);
                            isChangedRow = true;
                            isSelected = true;
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this, "No se pudo capturar el id en la grilla", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        private string GetIdSelected()
        {
            string id = "-1";
            try
            {
                if (dgvImpuesto.SelectedRows.Count > 0 && dgvImpuesto.Rows.Count > 0)
                {
                    id = dgvImpuesto.SelectedRows[0].Cells[0].Value.ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Excepción al capturar el id seleccionado: " + e.Message);
            }
            return id;
        }

        //Métodos utilitarios de lógica del Form
        private void CargarComboFiltro()
        {
            try
            {
                var listFiltro = new ComboFiltro().ListarFiltros();
                cboFiltro.DisplayMember = "TxtCampo";
                cboFiltro.ValueMember = "IdCampo";
                cboFiltro.DataSource = listFiltro;

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al cargar el combo de Filtro: " + e.Message, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void LimpiarForm()
        {
            isSelected = false;

            if (TipoOperacion == TipoOperacionABM.Nuevo)
                chkActivo.Enabled = false;
            else
                chkActivo.Enabled = true;

            chkActivo.Checked = true;

            lblIdImpuesto.Text = 0 + "";
            codSelected = "";

            txtNombre.Clear();
            txtAbreviacion.Clear();
            txtCodigo.Clear();
            txtPorcentaje01.Clear();
            txtPorcentaje02.Clear();
            txtPorcentaje03.Clear();
            txtPorcentaje04.Clear();
            txtPorcentaje05.Clear();
            txtPorcentaje06.Clear();
            txtPorcentaje07.Clear();
            txtPorcentaje08.Clear();
        }
        private void ControlarBotones(bool eNuevo, bool eDelete, bool eCommit, bool eRollback, bool eSearch, bool eFilter)
        {
            btnNuevo.Enabled = eNuevo;
            btnDelete.Enabled = eDelete;
            btnCommit.Enabled = eCommit;
            btnRollback.Enabled = eRollback;
            btnSearch.Enabled = eSearch;
            btnFilter.Enabled = eFilter;
        }
        private void ControlarEventosABM(int? id = null)
        {

            if (TipoOperacion == TipoOperacionABM.No_Action)
            {
                isPending = false;
                ControlarBotones(true, true, false, false, true, true);
                errorProv.Clear();
                //tab
            }
            else
            {
                if (TipoOperacion == TipoOperacionABM.Nuevo)
                {
                    ControlarBotones(false, false, true, true, false, false);
                    errorProv.Clear();
                    LimpiarForm();
                    tabImpuesto.SelectedTab = tabPagGeneral;
                    txtNombre.Focus();
                }
                else
                {
                    //Después de hacer el commit-insertar
                    if (TipoOperacion == TipoOperacionABM.Insertar)
                    {
                        ControlarBotones(true, true, false, false, true, true);
                        LimpiarForm();

                        if (tglListarInactivos.Checked) { ActualizarGrilla(); } else { ActualizarGrilla(Estado.IdActivo); }

                        int idInsertado = (int)id;
                        SeleccionarPorId(idInsertado);
                        tabImpuesto.SelectedTab = tabPagGeneral;
                        btnNuevo.Focus();
                    }
                    else
                    {
                        //Después de hacer commit-eliminar
                        if (TipoOperacion == TipoOperacionABM.Eliminar)
                        {
                            errorProv.Clear();
                            ControlarBotones(true, true, false, false, true, true);
                            LimpiarForm();
                            if (tglListarInactivos.Checked) { ActualizarGrilla(); } else { ActualizarGrilla(Estado.IdActivo); }
                            tabImpuesto.SelectedTab = tabPagGeneral;
                            btnNuevo.Focus();
                        }
                        else
                        {
                            if (TipoOperacion == TipoOperacionABM.Rollback)
                            {
                                ControlarBotones(true, true, false, false, true, true);
                                isPending = false;
                                errorProv.Clear();
                                LimpiarForm();
                                SeleccionarRegistro();
                                tabImpuesto.SelectedTab = tabPagGeneral;
                                btnNuevo.Focus();
                            }
                            else
                            {
                                if (TipoOperacion == TipoOperacionABM.Cambio)
                                {
                                    ControlarBotones(false, false, true, true, false, false);
                                    isPending = true;
                                }
                                else
                                {
                                    if (TipoOperacion == TipoOperacionABM.Modificar)
                                    {
                                        errorProv.Clear();
                                        LimpiarForm();
                                        ControlarBotones(true, true, false, false, true, true);
                                        isSelected = false;
                                        isPending = false;
                                        isChangedRow = false;

                                        if (tglListarInactivos.Checked) { ActualizarGrilla(); } else { ActualizarGrilla(Estado.IdActivo); }

                                        tabImpuesto.SelectedTab = tabPagGeneral;

                                        if (id != null)
                                        {
                                            int idAct = (int)id;
                                            SeleccionarPorId(idAct);
                                        }
                                        btnNuevo.Focus();
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        private void CargarGrilla(int? id_estado = null)
        {
            try
            {
                var lista = new ImpuestoBL().ListaImpuesto(id_estado, true);
                var listaView = lista.Select(x => new { x.id_impuesto, CODIGO = x.cod_impuesto, NOMBRE = x.txt_abrv })
                    .OrderBy(x => string.IsNullOrEmpty(x.CODIGO)).ThenBy(x => x.CODIGO, new AlphaNumericComparer()).ThenBy(x => x.NOMBRE).ToList();

                if (lista != null)
                {
                    ContarEstados(lista);
                    dgvImpuesto.DataSource = listaView;
                    dgvImpuesto.Columns["id_impuesto"].Visible = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, $"Excepción en cargar la grilla: {e.Message}");
            }
        }
        private void ActualizarGrilla(int? id_estado = null)
        {
            CargarGrilla(id_estado);
        }
        private void ConfigurarGrilla()
        {
            dgvImpuesto.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ecf0f1");
            dgvImpuesto.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FAFAFA");

            //Cabecera
            dgvImpuesto.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#00B2EE");
            dgvImpuesto.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //Selección
            dgvImpuesto.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;

            //Para que no sobreescriba los estilos de cabecera
            dgvImpuesto.EnableHeadersVisualStyles = false;

            //Configurando columnas del grid
            dgvImpuesto.AllowUserToResizeColumns = true;
            dgvImpuesto.Columns["CODIGO"].HeaderText = "CÓDIGO";

            dgvImpuesto.Columns["CODIGO"].Width = 100;
            dgvImpuesto.Columns["NOMBRE"].Width = 300;
        }
        private void ConfigurarControles()
        {

            #region Set tooltip
            tooltip = new MetroToolTip();
            tooltip.SetToolTip(btnNuevo, "Nuevo");
            tooltip.SetToolTip(btnDelete, "Eliminar");
            tooltip.SetToolTip(btnCommit, "Confirmar");
            tooltip.SetToolTip(btnRollback, "Cancelar");
            tooltip.SetToolTip(btnSearch, "Mostrar/Ocultar búsqueda");
            tooltip.SetToolTip(btnFilter, "Buscar");
            #endregion


            #region txts

            txtCodigo.MaxLength = 10;
            txtNombre.MaxLength = 500;
            txtAbreviacion.MaxLength = 100;
            txtPorcentaje01.MaxLength = 19;
            txtPorcentaje02.MaxLength = 19;
            txtPorcentaje03.MaxLength = 19;
            txtPorcentaje04.MaxLength = 19;
            txtPorcentaje05.MaxLength = 19;
            txtPorcentaje06.MaxLength = 19;
            txtPorcentaje07.MaxLength = 19;
            txtPorcentaje08.MaxLength = 19;

            txtPorcentaje01.TextAlign = HorizontalAlignment.Right;
            txtPorcentaje02.TextAlign = HorizontalAlignment.Right;
            txtPorcentaje03.TextAlign = HorizontalAlignment.Right;
            txtPorcentaje04.TextAlign = HorizontalAlignment.Right;
            txtPorcentaje05.TextAlign = HorizontalAlignment.Right;
            txtPorcentaje06.TextAlign = HorizontalAlignment.Right;
            txtPorcentaje07.TextAlign = HorizontalAlignment.Right;
            txtPorcentaje08.TextAlign = HorizontalAlignment.Right;

            #endregion
        }
        private void ContarEstados(List<MSTt06_impuesto> lista)
        {
            try
            {
                int numReg = lista.Count;
                int numAct = lista.Where(x => x.id_estado == Estado.IdActivo).ToList().Count;
                int numInac = lista.Where(x => x.id_estado == Estado.IdInactivo).ToList().Count;

                lblNumReg.Text = "Total: " + numReg;
                lblNumActivo.Text = "Activos: " + numAct;
                lblNumInactivo.Text = "Inactivos: " + numInac;
            }
            catch (Exception e)
            {
                MessageBox.Show(this, $"Excepción el contar los estados: {e.Message}");
            }
        }


        private void SetInit()
        {
            colaIdsActualizados = new List<int>();
            lblIdImpuesto.Visible = false;
            ConfigurarControles();
            ControlarEventosABM();
            LimpiarForm();
            CargarGrilla(Estado.IdActivo);
            CargarComboFiltro();
            panelFiltro.Visible = false;
            AddHandlers();
            tglListarInactivos.AutoCheck = false;
            ConfigurarGrilla();
        }

        private void CerrarForm()
        {
            Dispose();
            Hide();
            Close();
        }

        #endregion

        #region Eventos de ventana

        private void FormImpuesto_Load(object sender, EventArgs e)
        {
            SetInit();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            TipoOperacion = TipoOperacionABM.Nuevo;
            ControlarEventosABM();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TipoOperacion = TipoOperacionABM.Eliminar;
            Eliminar();
        }

        private void btnCommit_Click(object sender, EventArgs e)
        {
            if (TipoOperacion == TipoOperacionABM.Nuevo)
            {
                TipoOperacion = TipoOperacionABM.Insertar;
            }
            else if (TipoOperacion == TipoOperacionABM.Cambio)
            {
                TipoOperacion = TipoOperacionABM.Modificar;
            }

            if (TipoOperacion == TipoOperacionABM.Modificar)
            {
                #region Preguntar en caso de modificación
                string msg = "Cuando cambia los porcentajes del impuesto, tenga en cuenta que los precios de los productos, " +
                                "combos electivos y combos que apliquen este impuesto también serán modificados.\n" +
                                "¿Está seguro de continuar?";
                var result = MessageBox.Show(msg, "Advertencia", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Commit();
                }
                else if (result == DialogResult.No)
                {
                    SeleccionarRegistro();
                    TipoOperacion = TipoOperacionABM.No_Action;
                    ControlarEventosABM();
                }
                else if (result == DialogResult.Cancel)
                {
                    btnRollback.Focus();
                }
                #endregion
            }
            else
            {
                Commit();
            }
        }

        private void btnRollback_Click(object sender, EventArgs e)
        {
            TipoOperacion = TipoOperacionABM.Rollback;
            ControlarEventosABM();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            panelFiltro.Visible = !panelFiltro.Visible;
            txtFiltro.Focus();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                string filtro = txtFiltro.Text.Trim();
                string criterio = "";
                if (cboFiltro.SelectedValue != null)
                {
                    criterio = cboFiltro.SelectedValue.ToString();

                    if (!string.IsNullOrEmpty(criterio) && !filtro.Equals(""))
                    {

                        int idCriterio = int.Parse(criterio);
                        if (idCriterio == Filtro.Nombre)
                        {
                            Filtrar(Filtro.Nombre, filtro);
                        }
                        else if (idCriterio == Filtro.Codigo)
                        {
                            Filtrar(Filtro.Codigo, filtro);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Ocurrió una excepción al filtrar: " + ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            txtFiltro.Focus();
        }

        private void dgvImpuesto_SelectionChanged(object sender, EventArgs e)
        {
            errorProv.Clear();
            if (isPending)
            {
                if (preguntar)
                {
                    var checkDialog = new CheckBoxDialog();
                    DialogResult rp = checkDialog.ShowDialog();
                    if (rp == DialogResult.Yes)
                    {
                        TipoOperacion = TipoOperacionABM.Modificar;
                        //al intentar cambiar la fila si no es válido
                        //la actualización, no pasará hasta que sea válido
                        //o se dea rollback.
                        bool isValid = false;
                        string idSelect = GetIdSelected();

                        //Indica que está seleccionado otro registro
                        //que el que se quiere modificar
                        if (idSelect != lblIdImpuesto.Text && idSelect != "-1")
                        {
                            isValid = Actualizar();
                            if (isValid)
                            {
                                //Sobreescribe el indice indicado
                                //por el indice que corresponde al seleccionado
                                //que es diferente respecto quién está en el proceso.
                                //manejar 
                                SeleccionarPorId(int.Parse(idSelect));
                            }
                        }
                        else
                        {
                            Actualizar();
                        }


                        preguntar = !checkDialog.check;
                    }
                    else if (rp == DialogResult.No)
                    {
                        SeleccionarRegistro();
                        TipoOperacion = TipoOperacionABM.No_Action;
                        ControlarEventosABM();
                    }

                }
                else if (preguntar == false)
                {
                    TipoOperacion = TipoOperacionABM.Modificar;
                    //al intentar cambiar la fila si no es válido
                    //la actualización, no pasará hasta que sea válido
                    //o se dea rollback.
                    bool isValid = false;
                    string idSelect = GetIdSelected();

                    //Indica que está seleccionado otro registro
                    //que el que se quiere modificar
                    if (idSelect != lblIdImpuesto.Text && idSelect != "-1")
                    {
                        isValid = Actualizar();
                        if (isValid)
                        {
                            SeleccionarPorId(int.Parse(idSelect));
                        }
                    }
                    else
                    {
                        Actualizar();
                    }
                }
            }
            else
            {
                SeleccionarRegistro();
                TipoOperacion = TipoOperacionABM.No_Action;
                ControlarEventosABM();
            }
        }

        private void tglListarInactivos_Click(object sender, EventArgs e)
        {
            if (isPending)
            {
                if (preguntar)
                {
                    var checkDialog = new CheckBoxDialog();
                    DialogResult rp = checkDialog.ShowDialog();

                    if (rp == DialogResult.Yes)
                    {
                        bool isValid = false;
                        TipoOperacion = TipoOperacionABM.Modificar;
                        isValid = ActualizarEnCheck();
                        //Ya se validó y actualizó pero aún no recarga la grilla
                        if (isValid)
                        {
                            if (tglListarInactivos.Checked)
                                tglListarInactivos.Checked = false;
                            else
                                tglListarInactivos.Checked = true;
                            ControlarEventosABM();
                        }
                        preguntar = !checkDialog.check;
                    }
                    else if (rp == DialogResult.No)
                    {
                        isPending = false;
                        LimpiarForm();
                        if (tglListarInactivos.Checked)
                        {
                            tglListarInactivos.Checked = false;
                            ActualizarGrilla(Estado.IdActivo);
                        }
                        else
                        {
                            tglListarInactivos.Checked = true;
                            ActualizarGrilla();
                        }
                    }

                }
                else if (preguntar == false)
                {
                    bool isValid = false;
                    TipoOperacion = TipoOperacionABM.Modificar;
                    isValid = ActualizarEnCheck();
                    //Ya se validó y actualizó pero aún no recarga la grilla
                    if (isValid)
                    {
                        if (tglListarInactivos.Checked)
                            tglListarInactivos.Checked = false;
                        else
                            tglListarInactivos.Checked = true;
                        ControlarEventosABM();
                    }
                }
            }

            else
            {
                LimpiarForm();
                if (tglListarInactivos.Checked)
                {
                    tglListarInactivos.Checked = false;
                    ActualizarGrilla(Estado.IdActivo);
                }
                else
                {
                    tglListarInactivos.Checked = true;
                    ActualizarGrilla();
                }

            }
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Convert.ToInt32(Keys.Enter))
            {
                btnFilter_Click(null, null);
            }
        }

        private void dgvBordered_Paint(object sender, PaintEventArgs e)
        {
            ControlHelper.DgvSetColorBorder(sender, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (isPending)
            {
                if (preguntar)
                {
                    var checkDialog = new CheckBoxDialog();
                    DialogResult rp = checkDialog.ShowDialog();
                    if (rp == DialogResult.Yes)
                    {
                        preguntar = !checkDialog.check;
                        bool isValid = false;
                        TipoOperacion = TipoOperacionABM.Modificar;
                        isValid = Actualizar();
                        if (isValid)
                        {
                            isPending = false;
                            CerrarForm();
                        }

                    }
                    else if (rp == DialogResult.No)
                    {
                        isPending = false;
                        CerrarForm();
                    }

                }
                else if (preguntar == false)
                {
                    bool isValid = false;
                    TipoOperacion = TipoOperacionABM.Modificar;
                    isValid = Actualizar();
                    if (isValid)
                    {
                        isPending = false;
                        CerrarForm();
                    }
                }
            }
            else
            {
                CerrarForm();
            }
        }

        #endregion
    }
}
