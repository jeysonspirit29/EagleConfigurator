﻿using ConfigBusinessEntity;
using ConfigBusinessLogic.Maestro;
using ConfigBusinessLogic.Utiles;
using ConfiguradorUI.FormUtil;
using ConfigUtilitarios;
using ConfigUtilitarios.KeyValues;
using MetroFramework.Components;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfiguradorUI.Maestro
{
    public partial class FormImpresora : MetroForm
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
        #endregion

        public FormImpresora()
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
            var txts = new[] { txtNombre, txtCodigo, txtInfo01, txtMarca, txtModelo, txtIp };
            foreach (var txt in txts)
            {
                txt.TextChanged += new EventHandler(OnContentChanged);
            }
            //.TextChanged += new EventHandler(OnContentChanged);

            cboTipoImpresora.SelectedIndexChanged += new EventHandler(OnContentChanged);
            cboTipoImpresora.IntegralHeight = false;
            cboTipoImpresora.MaxDropDownItems = ControlHelper.maxDropDownItems;
            cboTipoImpresora.DropDownWidth = ControlHelper.DropDownWidth(cboTipoImpresora);


            chkActivo.CheckedChanged += new EventHandler(OnContentChanged);
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

        private void Commit()
        {
            try
            {
                if (TipoOperacion == TipoOperacionABM.Insertar)
                {
                    if (esValido())
                    {
                        var obj = new MSTt10_impresora();
                        obj = GetObjeto();
                        int id = new ImpresoraBL().InsertarImpresora(obj);
                        if (id > 0)
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
                if (dgvImpresora.RowCount > 0)
                {
                    if (dgvImpresora.SelectedRows.Count > 0)
                    {
                        try
                        {
                            int id = 0;
                            if (int.TryParse(lblIdImpresora.Text, out id) && id > 0)
                            {
                                DialogResult rp = MessageBox.Show("¿Seguro de eliminar el registro?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (rp == DialogResult.Yes)
                                {
                                    bool validDelete = new UtilBL().ValidarDelete(id, CodValDelete.Impresora_Caja);
                                    if (validDelete)
                                    {
                                        new ImpresoraBL().EliminarImpresora(id);
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
                    if (esValido())
                    {

                        var obj = new MSTt10_impresora();
                        obj = GetObjeto();
                        int id = 0;
                        if (int.TryParse(lblIdImpresora.Text, out id))
                        {
                            obj.id_impresora = id;
                            new ImpresoraBL().ActualizarImpresora(obj);
                            actualizar = true;
                            ControlarEventosABM(obj.id_impresora);
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
                    if (esValido())
                    {
                        var obj = new MSTt10_impresora();
                        obj = GetObjeto();
                        int id = 0;
                        if (int.TryParse(lblIdImpresora.Text, out id))
                        {
                            obj.id_impresora = id;
                            new ImpresoraBL().ActualizarImpresora(obj);
                            actualizar = true;
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

        private MSTt10_impresora GetObjeto()
        {
            var obj = new MSTt10_impresora();
            try
            {
                obj.txt_desc = txtNombre.Text.Trim();
                obj.cod_impresora = txtCodigo.Text.Trim();
                obj.txt_ip = txtIp.Text.Trim();
                obj.txt_marca = txtMarca.Text.Trim();
                obj.txt_modelo = txtModelo.Text.Trim();
                obj.txt_info01 = txtInfo01.Text.Trim();

                obj.id_estado = chkActivo.Checked ? Estado.IdActivo : Estado.IdInactivo;
                obj.txt_estado = chkActivo.Checked ? Estado.TxtActivo : Estado.TxtInactivo;

                obj.id_tipo_impresora = int.Parse(cboTipoImpresora.SelectedValue.ToString());

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Excepción en el Get: " + e.Message);
            }

            return obj;
        }
        private void SetObjeto(MSTt10_impresora obj)
        {
            try
            {

                isChangedRow = true;
                LimpiarForm();

                chkActivo.Checked = (obj.id_estado == Estado.IdActivo) ? true : false;

                lblIdImpresora.Text = obj.id_impresora.ToString();
                codSelected = obj.cod_impresora;

                txtNombre.Text = obj.txt_desc;
                txtCodigo.Text = obj.cod_impresora;
                txtMarca.Text = obj.txt_marca;
                txtModelo.Text = obj.txt_modelo;
                txtInfo01.Text = obj.txt_info01;
                txtIp.Text = obj.txt_ip;

                cboTipoImpresora.SelectedValue = obj.id_tipo_impresora;

            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Excepción en el Set: " + e.Message);
            }

        }

        private bool esValido()
        {
            //Por ver - validar combos.
            bool no_error = true;
            errorProv.Clear();
            //validando los controles para el tabPageGeneral
            //Foreach en caso se requiera validar más controles - por ver.

            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                tabImpresora.SelectedTab = tabPagGeneral;
                errorProv.SetError(txtNombre, "Este campo es requerido.");
                txtNombre.Focus();
                no_error = false;
            }

            if (!int.TryParse(cboTipoImpresora.SelectedValue?.ToString(), out int id))
            {
                errorProv.SetError(cboTipoImpresora, "Este campo es requerido.");
                cboTipoImpresora.Focus();
                no_error = false;
            }
            #region código único

            if (no_error)
            {
                string cod = txtCodigo.Text.Trim();
                if (cod.Length > 0)
                {
                    if (int.TryParse(cod, out int numCod) && numCod == Reserved.Code)
                    {
                        tabImpresora.SelectedTab = tabPagGeneral;
                        string msg = $"El código '{Reserved.Code.ToString()}' es reservado para el sistema.";
                        MessageBox.Show(msg, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        errorProv.SetError(txtCodigo, msg);
                        txtCodigo.Focus();
                        no_error = false;
                    }
                    else
                    {
                        var obj = new ImpresoraBL().ImpresoraXCod(cod);
                        if (TipoOperacion == TipoOperacionABM.Insertar)
                        {
                            if (obj != null && obj.id_impresora > 0)
                            {
                                tabImpresora.SelectedTab = tabPagGeneral;
                                MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                errorProv.SetError(txtCodigo, "El código ya está en uso.");
                                txtCodigo.Focus();
                                no_error = false;
                            }
                        }
                        else if (TipoOperacion == TipoOperacionABM.Modificar)
                        {
                            if (cod != codSelected && obj != null && obj.id_impresora > 0)
                            {
                                tabImpresora.SelectedTab = tabPagGeneral;
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

            if (no_error && !string.IsNullOrEmpty(txtIp.Text.Trim()))
            {
                if (!IPAddress.TryParse(txtIp.Text.Trim(), out IPAddress ip))
                {
                    errorProv.SetError(txtIp, "La dirección IP es incorrecta.");
                    txtIp.Focus();
                    no_error = false;
                }
            }

            #region validación delete

            if (no_error && !chkActivo.Checked && TipoOperacion == TipoOperacionABM.Modificar)
            {
                if (int.TryParse(lblIdImpresora.Text, out int idImp))
                {
                    bool validDelete = false;
                    validDelete = new UtilBL().ValidarDelete(idImp, CodValDelete.Impresora_Caja);
                    if (!validDelete)
                    {
                        MessageBox.Show(this, "Este registro no se puede desactivar porque se usa en otro lado.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabImpresora.SelectedTab = tabPagGeneral;
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
        private void Filtrar(int criterio, string filtro)
        {
            int index = 0;
            try
            {
                //si no haya alguna fila con el id enviado, signfica que no está el id

                if (criterio == Filtro.Nombre)
                {
                    DataGridViewRow row = dgvImpresora.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["NOMBRE"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvImpresora.Rows.Count > 0)
                        {
                            dgvImpresora.Rows[index].Selected = true;
                            dgvImpresora.FirstDisplayedScrollingRowIndex = index;

                        }
                    }
                }
                else if (criterio == Filtro.Codigo)
                {
                    DataGridViewRow row = dgvImpresora.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["CODIGO"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvImpresora.Rows.Count > 0)
                        {
                            dgvImpresora.Rows[index].Selected = true;
                            dgvImpresora.FirstDisplayedScrollingRowIndex = index;
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
                DataGridViewRow row = dgvImpresora.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["id_impresora"].Value.ToString().Equals(id.ToString()))
                .FirstOrDefault();
                if (row != null)
                {
                    index = row.Index;
                    if (dgvImpresora.Rows.Count > 0)
                    {
                        dgvImpresora.Rows[index].Selected = true;
                        dgvImpresora.FirstDisplayedScrollingRowIndex = index;
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
            if (dgvImpresora.RowCount > 0 && dgvImpresora.SelectedRows.Count > 0 && dgvImpresora.CurrentRow.Index != -1)
            {
                int id = 0;
                if (int.TryParse(GetIdSelected(), out id))
                {
                    if (id > 0)
                    {
                        var obj = new ImpresoraBL().ImpresoraXId(id);
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
                if (dgvImpresora.SelectedRows.Count > 0 && dgvImpresora.Rows.Count > 0)
                {
                    id = dgvImpresora.SelectedRows[0].Cells[0].Value.ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Excepción al capturar el id seleccionado: " + e.Message);
            }
            return id;
        }


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
            lblIdImpresora.Text = 0 + "";
            codSelected = "";

            txtNombre.Clear();
            txtCodigo.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtInfo01.Clear();
            txtIp.Clear();

            if (TipoOperacion == TipoOperacionABM.Nuevo)
                chkActivo.Enabled = false;
            else
                chkActivo.Enabled = true;

            chkActivo.Checked = true;

            if (cboTipoImpresora.Items.Count > 0) cboTipoImpresora.SelectedIndex = 0;

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
                //tabProducto.SelectedTab = tabPagGeneral;
            }
            else
            {
                if (TipoOperacion == TipoOperacionABM.Nuevo)
                {
                    ControlarBotones(false, false, true, true, false, false);
                    errorProv.Clear();
                    LimpiarForm();
                    tabImpresora.SelectedTab = tabPagGeneral;
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
                        tabImpresora.SelectedTab = tabPagGeneral;
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
                            tabImpresora.SelectedTab = tabPagGeneral;
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
                                tabImpresora.SelectedTab = tabPagGeneral;
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

                                        tabImpresora.SelectedTab = tabPagGeneral;

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
        private void MantenerEstadoABM()
        {
            if (TipoOperacion == TipoOperacionABM.Nuevo)
            {
                ControlarBotones(false, false, true, true, false, false);
            }
            else if (TipoOperacion == TipoOperacionABM.Cambio)
            {
                ControlarBotones(false, false, true, true, false, false);
                isPending = true;
            }
            else if (TipoOperacion == TipoOperacionABM.No_Action)
            {
                isPending = false;
                ControlarBotones(true, true, false, false, true, true);
            }
            else
            {
                isPending = false;
                ControlarBotones(true, true, false, false, true, true);
            }
        }
        private void CargarCombos()
        {
            try
            {
                cboTipoImpresora.DataSource = null;
                cboTipoImpresora.DisplayMember = "txt_desc";
                cboTipoImpresora.ValueMember = "id_tipo_impresora";
                cboTipoImpresora.DataSource = new TipoImpresoraBL().ListaTipoImpresora(Estado.IdActivo, false, true);
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al cargar los combos: " + e.Message, "MENSAJE");
            }
        }
        private void CargarGrilla(int? id_estado = null)
        {
            try
            {
                var lista = new ImpresoraBL().ListaImpresora(id_estado, true);
                var listaView = lista.Select(x => new { x.id_impresora, CODIGO = x.cod_impresora, NOMBRE = x.txt_desc })
               .OrderBy(x => string.IsNullOrEmpty(x.CODIGO)).ThenBy(x => x.CODIGO, new AlphaNumericComparer()).ThenBy(x => x.NOMBRE).ToList();

                if (lista != null)
                {
                    ContarEstados(lista);
                    dgvImpresora.DataSource = listaView;
                    dgvImpresora.Columns["id_impresora"].Visible = false;
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
            dgvImpresora.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ecf0f1");
            dgvImpresora.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FAFAFA");

            //Cabecera
            dgvImpresora.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#00B2EE");
            dgvImpresora.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //Selección
            dgvImpresora.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;

            //Para que no sobreescriba los estilos de cabecera
            dgvImpresora.EnableHeadersVisualStyles = false;

            //Configurando columnas del grid
            dgvImpresora.AllowUserToResizeColumns = true;
            dgvImpresora.Columns["CODIGO"].HeaderText = "CÓDIGO";

            dgvImpresora.Columns["CODIGO"].Width = 100;
            dgvImpresora.Columns["NOMBRE"].Width = 300;
        }
        private void SetMaxLengthTxt()
        {
            txtCodigo.MaxLength = 10;
            txtNombre.MaxLength = 100;
            txtIp.MaxLength = 15;
            txtMarca.MaxLength = 100;
            txtModelo.MaxLength = 100;
            txtInfo01.MaxLength = 100;

        }
        private void ContarEstados(List<MSTt10_impresora> lista)
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
        private void CerrarForm()
        {
            Dispose();
            Hide();
            Close();
        }

        #endregion

        #region Eventos de ventana

        private void FormImpresora_Load(object sender, EventArgs e)
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
            lblIdImpresora.Visible = false;
            SetMaxLengthTxt();
            ControlarEventosABM();
            CargarCombos();
            LimpiarForm();
            CargarGrilla(Estado.IdActivo);
            CargarComboFiltro();
            panelFiltro.Visible = false;
            AddHandlers();
            tglListarInactivos.AutoCheck = false;
            ConfigurarGrilla();
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
            else
            {
                if (TipoOperacion == TipoOperacionABM.Cambio)
                {
                    TipoOperacion = TipoOperacionABM.Modificar;
                }
            }
            Commit();
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

        private void dgvImpresora_SelectionChanged(object sender, EventArgs e)
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
                        bool isValid = false;
                        string idSelect = GetIdSelected();

                        if (idSelect != lblIdImpresora.Text && idSelect != "-1")
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
                    bool isValid = false;
                    string idSelect = GetIdSelected();

                    //Indica que está seleccionado otro registro
                    //que el que se quiere modificar
                    if (idSelect != lblIdImpresora.Text && idSelect != "-1")
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

        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            txtFiltro.Focus();
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

        #region Eventos ventana emergente

        private void btnTipoImpresora_Click(object sender, EventArgs e)
        {

            try
            {
                int oldValue = 0;
                int op = TipoOperacion;

                if (cboTipoImpresora.SelectedValue != null)
                    oldValue = int.Parse(cboTipoImpresora.SelectedValue.ToString());

                var frm = new FormTipoImpresora();
                frm.ShowDialog();

                if (frm.actualizar)
                {
                    cboTipoImpresora.DataSource = null;
                    cboTipoImpresora.DisplayMember = "txt_desc";
                    cboTipoImpresora.ValueMember = "id_tipo_impresora";
                    cboTipoImpresora.DataSource = new TipoImpresoraBL().ListaTipoImpresora(Estado.IdActivo, false, true);
                    cboTipoImpresora.DropDownWidth = ControlHelper.DropDownWidth(cboTipoImpresora);
                    cboTipoImpresora.SelectedValue = oldValue;
                    TipoOperacion = op;
                    MantenerEstadoABM();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(this, $"Excepción cuando se intentaba actualizar el combo. {exc.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion
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
