﻿using ConfigBusinessEntity;
using ConfigBusinessLogic.Maestro;
using ConfiguradorUI.FormUtil;
using ConfigUtilitarios;
using ConfigUtilitarios.HelperClass;
using ConfigUtilitarios.HelperControl;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfiguradorUI.Maestro
{
    public partial class FormTurno : MetroForm
    {
        #region Variables
        bool isSelected = false;
        bool isChangedRow = false;
        bool isPending = false;
        bool preguntar = true;
        public bool actualizar = false;
        private int TipoOperacion = TipoOperacionABM.No_Action;
        string codSelected = "";
        #endregion

        public FormTurno()
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
            var txts = new[] { txtNombre, txtCodigo, txtAbreviacion };
            foreach (var txt in txts)
            {
                txt.TextChanged += new EventHandler(OnContentChanged);
            }

            var cbos = new[] { cboHoraEntradaHH, cboHoraEntradaMM, cboHoraEntradaTT,
                                cboHoraSalidaHH, cboHoraSalidaMM, cboHoraSalidaTT};
            foreach (var cbo in cbos)
            {
                cbo.SelectedIndexChanged += new EventHandler(OnContentChanged);
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

        private void Commit()
        {
            try
            {
                if (TipoOperacion == TipoOperacionABM.Insertar)
                {
                    if (esValido())
                    {
                        var obj = new MSTt13_turno();
                        obj = GetObjeto();
                        int id = new TurnoBL().InsertarTurno(obj);
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
                if (dgvTurno.RowCount > 0)
                {
                    if (dgvTurno.SelectedRows.Count > 0)
                    {
                        try
                        {
                            int id = 0;
                            if (int.TryParse(lblIdTurno.Text, out id) && id > 0)
                            {
                                DialogResult rp = MessageBox.Show("¿Seguro de eliminar el registro?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (rp == DialogResult.Yes)
                                {
                                    new TurnoBL().EliminarTurno(id);
                                    actualizar = true;
                                    ControlarEventosABM();
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
            //Esta variable booleana se usa en algunos para controlar la validez
            // del reg, por ejemplo, cuando el usuario quiere salir
            //y tiene una modificación pendiente(pero si no es válida no sale)
            //en esa caso usaremos esta variables, en otras no.
            bool isValid = false;
            try
            {
                if (TipoOperacion == TipoOperacionABM.Modificar && isSelected && isPending)
                {
                    if (esValido())
                    {
                        var obj = new MSTt13_turno();
                        obj = GetObjeto();
                        int id = 0;
                        if (int.TryParse(lblIdTurno.Text, out id))
                        {
                            obj.id_turno = id;
                            new TurnoBL().ActualizarTurno(obj);
                            actualizar = true;
                            ControlarEventosABM(obj.id_turno);
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
                        var obj = new MSTt13_turno();
                        obj = GetObjeto();
                        int id = 0;
                        if (int.TryParse(lblIdTurno.Text, out id))
                        {
                            obj.id_turno = id;
                            new TurnoBL().ActualizarTurno(obj);
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

        private bool ValidTimeFromCbos(ComboBox cboHH, ComboBox cboMM, ComboBox cboTT)
        {
            var hh = cboHH.SelectedValue?.ToString();
            var mm = cboMM.SelectedValue?.ToString();
            var tt = cboTT.SelectedValue?.ToString();
            var time = $"{hh}:{mm} {tt}";
            return DateTime.TryParseExact(time, "hh:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dt);
        }
        private TimeSpan GetTimeFromCbos(ComboBox cboHH, ComboBox cboMM, ComboBox cboTT)
        {
            var hh = cboHH.SelectedValue?.ToString();
            var mm = cboMM.SelectedValue?.ToString();
            var tt = cboTT.SelectedValue?.ToString();
            var full = $"{hh}:{mm} {tt}";
            return DateTime.ParseExact(full, "hh:mm tt", CultureInfo.InvariantCulture).TimeOfDay;
        }
        private void SetTimeToCbos(TimeSpan time, ComboBox cboHH, ComboBox cboMM, ComboBox cboTT)
        {
            var dateTime = new DateTime(time.Ticks); // Date es 01-01-0001
            var dt = dateTime.ToString("hh:mm tt", CultureInfo.InvariantCulture);

            var hh = dt.Substring(0, 2);
            var mm = dt.Substring(3, 2);
            var tt = dt.Substring(6, 2);

            cboHH.SelectedValue = hh;
            cboMM.SelectedValue = mm;
            cboTT.SelectedValue = tt;
        }

        private MSTt13_turno GetObjeto()
        {
            var obj = new MSTt13_turno();
            try
            {
                obj.txt_desc = txtNombre.Text.Trim();
                obj.txt_abrv = txtAbreviacion.Text.Trim();
                obj.cod_turno = txtCodigo.Text.Trim();
                obj.hora_inicio = GetTimeFromCbos(cboHoraEntradaHH, cboHoraEntradaMM, cboHoraEntradaTT);
                obj.hora_fin = GetTimeFromCbos(cboHoraSalidaHH, cboHoraSalidaMM, cboHoraSalidaTT);
                obj.id_estado = chkActivo.Checked ? Estado.IdActivo : Estado.IdInactivo;
                obj.txt_estado = chkActivo.Checked ? Estado.TxtActivo : Estado.TxtInactivo;
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Excepción en el Get: " + e.Message);
            }

            return obj;
        }
        private void SetObjeto(MSTt13_turno obj)
        {
            try
            {
                // Variable de la lógica de cambio.
                // Indica que la asignación de los datos de un reg se está dando
                // porque se cambió de fila.
                isChangedRow = true;
                LimpiarForm();
                chkActivo.Checked = (obj.id_estado == Estado.IdActivo) ? true : false;

                lblIdTurno.Text = obj.id_turno.ToString();
                codSelected = obj.cod_turno;

                txtNombre.Text = obj.txt_desc;
                txtAbreviacion.Text = obj.txt_abrv;
                txtCodigo.Text = obj.cod_turno;
                //hora inicio
                SetTimeToCbos(obj.hora_inicio, cboHoraEntradaHH, cboHoraEntradaMM, cboHoraEntradaTT);
                SetTimeToCbos(obj.hora_fin, cboHoraSalidaHH, cboHoraSalidaMM, cboHoraSalidaTT);
                //hora salida

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
            //validando los controles para el tabPageGeneral
            //Foreach en caso se requiera validar más controles - por ver.
            errorProv.Clear();

            if (!ValidTimeFromCbos(cboHoraSalidaHH, cboHoraSalidaMM, cboHoraSalidaTT))
            {
                tabTurno.SelectedTab = tabPagGeneral;
                errorProv.SetError(cboHoraSalidaTT, "Formato de hora incorrecto.");
                cboHoraSalidaHH.Focus();
                no_error = false;
            }

            if (!ValidTimeFromCbos(cboHoraEntradaHH, cboHoraEntradaMM, cboHoraEntradaTT))
            {
                tabTurno.SelectedTab = tabPagGeneral;
                errorProv.SetError(cboHoraEntradaTT, "Formato de hora incorrecto.");
                cboHoraEntradaHH.Focus();
                no_error = false;
            }

            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                tabTurno.SelectedTab = tabPagGeneral;
                errorProv.SetError(txtNombre, "Este campo es requerido.");
                txtNombre.Focus();
                no_error = false;
            }

            if (no_error)
            {
                string cod = txtCodigo.Text.Trim();
                if (cod.Length > 0)
                {
                    var obj = new TurnoBL().TurnoXCod(cod);
                    if (TipoOperacion == TipoOperacionABM.Insertar)
                    {
                        if (obj != null && obj.id_turno > 0)
                        {
                            tabTurno.SelectedTab = tabPagGeneral;
                            MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            errorProv.SetError(txtCodigo, "El código ya está en uso.");
                            txtCodigo.Focus();
                            no_error = false;
                        }
                    }
                    else if (TipoOperacion == TipoOperacionABM.Modificar)
                    {
                        if (cod != codSelected && obj != null && obj.id_turno > 0)
                        {
                            tabTurno.SelectedTab = tabPagGeneral;
                            MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            errorProv.SetError(txtCodigo, "El código ya está en uso.");
                            txtCodigo.Focus();
                            no_error = false;
                        }
                    }
                }
            }

            //Se podría validar que no tenga hijas al desactivar.

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
                    DataGridViewRow row = dgvTurno.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["NOMBRE"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvTurno.Rows.Count > 0)
                        {
                            dgvTurno.Rows[index].Selected = true;
                            dgvTurno.FirstDisplayedScrollingRowIndex = index;
                        }
                    }
                }
                else if (criterio == Filtro.Codigo)
                {
                    DataGridViewRow row = dgvTurno.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["CODIGO"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvTurno.Rows.Count > 0)
                        {
                            dgvTurno.Rows[index].Selected = true;
                            dgvTurno.FirstDisplayedScrollingRowIndex = index;
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
                DataGridViewRow row = dgvTurno.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["id_turno"].Value.ToString().Equals(id.ToString()))
                .FirstOrDefault();
                if (row != null)
                {
                    index = row.Index;
                    if (dgvTurno.Rows.Count > 0)
                    {
                        dgvTurno.Rows[index].Selected = true;
                        dgvTurno.FirstDisplayedScrollingRowIndex = index;
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
            if (dgvTurno.RowCount > 0 && dgvTurno.SelectedRows.Count > 0 && dgvTurno.CurrentRow.Index != -1)
            {
                int id = 0;
                if (int.TryParse(GetIdSelected(), out id))
                {
                    if (id > 0)
                    {
                        var obj = new TurnoBL().TurnoXId(id);
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
                if (dgvTurno.SelectedRows.Count > 0 && dgvTurno.Rows.Count > 0)
                {
                    id = dgvTurno.SelectedRows[0].Cells[0].Value.ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Excepción al capturar el id seleccionado: " + e.Message);
            }
            return id;
        }

        private void CargarComboHHMMTT()
        {

            try
            {

                var hhs = new ComboItem().GetHHs().ToList();
                var mms = new ComboItem().GetMMs();
                var tts = new ComboItem().GetTTs();

                //entrada
                cboHoraEntradaHH.DisplayMember = "Value";
                cboHoraEntradaHH.ValueMember = "Key";
                cboHoraEntradaHH.DataSource = hhs;
                cboHoraEntradaMM.DisplayMember = "Value";
                cboHoraEntradaMM.ValueMember = "Key";
                cboHoraEntradaMM.DataSource = mms;
                cboHoraEntradaTT.DisplayMember = "Value";
                cboHoraEntradaTT.ValueMember = "Key";
                cboHoraEntradaTT.DataSource = tts;

                //salida
                //se asigna una lista apartir de la otra para disolver el binding
                cboHoraSalidaHH.DisplayMember = "Value";
                cboHoraSalidaHH.ValueMember = "Key";
                cboHoraSalidaHH.DataSource = hhs.ToList();
                cboHoraSalidaMM.DisplayMember = "Value";
                cboHoraSalidaMM.ValueMember = "Key";
                cboHoraSalidaMM.DataSource = mms.ToList();
                cboHoraSalidaTT.DisplayMember = "Value";
                cboHoraSalidaTT.ValueMember = "Key";
                cboHoraSalidaTT.DataSource = tts.ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Ocurrió una excepción al cargar el combo de las horas-minutos-tiempo: " + e.Message, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
            lblIdTurno.Text = 0 + "";
            codSelected = "";

            txtNombre.Clear();
            txtAbreviacion.Clear();
            txtCodigo.Clear();

            if (TipoOperacion == TipoOperacionABM.Nuevo)
                chkActivo.Enabled = false;
            else
                chkActivo.Enabled = true;

            chkActivo.Checked = true;

            if (cboHoraEntradaHH.Items.Count > 0) cboHoraEntradaHH.SelectedIndex = 0;
            if (cboHoraEntradaMM.Items.Count > 0) cboHoraEntradaMM.SelectedIndex = 0;
            if (cboHoraEntradaTT.Items.Count > 0) cboHoraEntradaTT.SelectedIndex = 0;

            if (cboHoraSalidaHH.Items.Count > 0) cboHoraSalidaHH.SelectedIndex = 0;
            if (cboHoraSalidaMM.Items.Count > 0) cboHoraSalidaMM.SelectedIndex = 0;
            if (cboHoraSalidaTT.Items.Count > 0) cboHoraSalidaTT.SelectedIndex = 0;
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
                    tabTurno.SelectedTab = tabPagGeneral;
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
                        tabTurno.SelectedTab = tabPagGeneral;
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
                            tabTurno.SelectedTab = tabPagGeneral;
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
                                tabTurno.SelectedTab = tabPagGeneral;
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

                                        tabTurno.SelectedTab = tabPagGeneral;

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
                var lista = new TurnoBL().ListaTurno(id_estado, true);
                var listaView = lista.Select(x => new { x.id_turno, CODIGO = x.cod_turno, NOMBRE = x.txt_desc })
                                    .OrderBy(x => string.IsNullOrEmpty(x.CODIGO)).ThenBy(x => x.CODIGO, new AlphaNumericComparer()).ThenBy(x => x.NOMBRE).ToList();
                if (lista != null)
                {
                    ContarEstados(lista);
                    dgvTurno.DataSource = listaView;
                    dgvTurno.Columns["id_turno"].Visible = false;
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
            dgvTurno.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ecf0f1");
            dgvTurno.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FAFAFA");

            //Cabecera
            dgvTurno.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#00B2EE");
            dgvTurno.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //Selección
            dgvTurno.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;

            //Para que no sobreescriba los estilos de cabecera
            dgvTurno.EnableHeadersVisualStyles = false;
        }
        private void SetMaxLengthTxt()
        {
            txtCodigo.MaxLength = 10;
            txtAbreviacion.MaxLength = 10;
            txtNombre.MaxLength = 50;
        }
        private void ContarEstados(List<MSTt13_turno> lista)
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

        private void FormTurno_Load(object sender, EventArgs e)
        {
            lblIdTurno.Visible = false;
            SetMaxLengthTxt();
            ControlarEventosABM();
            LimpiarForm();
            CargarComboHHMMTT();
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
            if (panelFiltro.Visible)
            {
                panelFiltro.Visible = false;
            }
            else
            {
                panelFiltro.Visible = true;
            }
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

        private void dgvTurno_SelectionChanged(object sender, EventArgs e)
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
                        if (idSelect != lblIdTurno.Text && idSelect != "-1")
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
                    if (idSelect != lblIdTurno.Text && idSelect != "-1")
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
