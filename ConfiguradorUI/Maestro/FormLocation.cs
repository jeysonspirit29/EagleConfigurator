﻿using ConfigBusinessEntity;
using ConfigBusinessLogic.Maestro;
using ConfigBusinessLogic.Sunat;
using ConfigBusinessLogic.Utiles;
using ConfiguradorUI.FormUtil;
using ConfigUtilitarios;
using ConfigUtilitarios.HelperControl;
using ConfigUtilitarios.KeyValues;
using MetroFramework.Components;
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
    public partial class FormLocation : MetroForm
    {
        #region Variables
        bool isSelected = false;
        bool isChangedRow = false;
        bool isPending = false;
        bool preguntar = true;
        private int TipoOperacion = TipoOperacionABM.No_Action;

        string codSelected = "";
        MetroToolTip tooltip;
        #endregion

        public FormLocation()
        {
            InitializeComponent();
        }

        #region Métodos de ventana

        private void AddHandlers()
        {
            //Form
            KeyPreview = true;
            KeyDown += ControlHelper.FormCloseShiftEsc_KeyDown;

            var txtsNumeric = new[]
            {
                 txtLatitud, txtLongitud
            };

            var txts = new[] { txtNombre, txtCodigo,txtAbrev01,txtAbrev02,
                                txtDato01,txtDato02,txtDato03,txtDato04,
                                txtFono01,txtFono02,txtNumRuc,txtDireccion01,
                                txtDireccion02};
            foreach (var txt in txts.Union(txtsNumeric))
            {
                txt.TextChanged += new EventHandler(OnContentChanged);
            }

            var cbos = new[] { cboTipoLocation, cboDepartamento, cboProvincia, cboDistrito };
            foreach (var cbo in cbos)
            {
                cbo.SelectedIndexChanged += new EventHandler(OnContentChanged);
                cbo.IntegralHeight = false;
                cbo.MaxDropDownItems = ControlHelper.maxDropDownItems;
                cbo.DropDownWidth = ControlHelper.DropDownWidth(cboTipoLocation);
            }

            var chks = new[] { chkActivo, chkAlmacen, chkLocationActual };

            foreach (var chk in chks)
            {
                chk.CheckedChanged += new EventHandler(OnContentChanged);
            }
            foreach (var txtNum in txtsNumeric)
            {
                txtNum.KeyPress += ControlHelper.TxtValidAllDecimal;
            }

            dtpFechaNegocio.CloseUp += dtpVer_CloseUp;
            dtpFechaNegocio.MouseDown += DtpVer_MouseDown;
            dtpFechaNegocio.KeyPress += DtpLimpiar_KeyPress;

            dtpFechaNegocio.ValueChanged += OnContentChanged;
            dtpFechaNegocio.CloseUp += OnContentChanged;
            dtpFechaNegocio.MouseDown += OnContentChanged;
            dtpFechaNegocio.KeyPress += OnContentChanged;
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
                    if (EsValido())
                    {
                        var obj = new MSTt08_location();
                        obj = GetObjeto();
                        int id = new LocationBL().InsertarLocation(obj);
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
                if (dgvLocation.RowCount > 0)
                {
                    if (dgvLocation.SelectedRows.Count > 0)
                    {
                        try
                        {
                            int id = 0;
                            if (int.TryParse(lblIdLocation.Text, out id) && id > 0)
                            {
                                DialogResult rp = MessageBox.Show("¿Seguro de eliminar el registro?", "CONFIRMACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (rp == DialogResult.Yes)
                                {
                                    new LocationBL().EliminarLocation(id);
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
            bool isValid = false;
            try
            {
                if (TipoOperacion == TipoOperacionABM.Modificar && isSelected && isPending)
                {
                    if (EsValido())
                    {
                        var obj = new MSTt08_location();
                        obj = GetObjeto();
                        int id = 0;
                        if (int.TryParse(lblIdLocation.Text, out id))
                        {
                            obj.id_location = id;
                            new LocationBL().ActualizarLocation(obj);
                            ControlarEventosABM(obj.id_location);
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
                        var obj = new MSTt08_location();
                        obj = GetObjeto();
                        int id = 0;
                        if (int.TryParse(lblIdLocation.Text, out id))
                        {
                            obj.id_location = id;
                            new LocationBL().ActualizarLocation(obj);
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

        private MSTt08_location GetObjeto()
        {
            var obj = new MSTt08_location();
            try
            {

                obj.id_estado = chkActivo.Checked ? Estado.IdActivo : Estado.IdInactivo;
                obj.txt_estado = chkActivo.Checked ? Estado.TxtActivo : Estado.TxtInactivo;

                if (dtpFechaNegocio.CustomFormat == DateFormat.DateOnly)
                {
                    obj.fecha_negocio = dtpFechaNegocio.Value.Date;
                }

                if (cboDistrito.SelectedValue != null)
                    obj.id_dist = int.Parse(cboDistrito.SelectedValue.ToString());

                obj.txt_desc = txtNombre.Text.Trim();
                obj.cod_location = txtCodigo.Text.Trim();
                obj.txt_direccion1 = txtDireccion01.Text.Trim();
                obj.txt_direccion2 = txtDireccion02.Text.Trim();
                obj.txt_abrev1 = txtAbrev01.Text.Trim();
                obj.txt_abrev2 = txtAbrev02.Text.Trim();
                obj.nro_ruc = txtNumRuc.Text.Trim();
                obj.fono1 = txtFono01.Text.Trim();
                obj.fono2 = txtFono02.Text.Trim();
                obj.txt_datos1 = txtDato01.Text.Trim();
                obj.txt_datos2 = txtDato02.Text.Trim();
                obj.txt_datos3 = txtDato03.Text.Trim();
                obj.txt_datos4 = txtDato04.Text.Trim();


                if (decimal.TryParse(txtLatitud.Text.Trim(), out decimal latitudTemp))
                {
                    obj.latitud = latitudTemp;
                }
                if (decimal.TryParse(txtLongitud.Text.Trim(), out decimal longitudTemp))
                {
                    obj.longitud = longitudTemp;
                }

                obj.sn_almacen = chkAlmacen.Checked ? 1 : 0;
                obj.sn_location_current = chkLocationActual.Checked ? 1 : 0;

                obj.id_tipo_location = int.Parse(cboTipoLocation.SelectedValue.ToString());

            }
            catch (Exception e)
            {
                Msg.Ok_Err("Excepción en el Get: " + e.Message);
            }

            return obj;
        }
        private void SetObjeto(MSTt08_location obj)
        {
            try
            {
                isChangedRow = true;
                LimpiarForm();

                chkActivo.Checked = obj.id_estado == Estado.IdActivo ? true : false;

                lblIdLocation.Text = obj.id_location.ToString();
                codSelected = obj.cod_location;

                if (obj.fecha_negocio != null)
                {
                    DateFormat.SetFormat(dtpFechaNegocio, DateFormat.DateOnly);
                    dtpFechaNegocio.Value = (DateTime)obj.fecha_negocio;
                }

                txtNombre.Text = obj.txt_desc;
                txtCodigo.Text = obj.cod_location;
                txtDireccion01.Text = obj.txt_direccion1;
                txtDireccion02.Text = obj.txt_direccion2;
                txtAbrev01.Text = obj.txt_abrev1;
                txtAbrev02.Text = obj.txt_abrev2;
                txtNumRuc.Text = obj.nro_ruc;
                txtLatitud.Text = obj.latitud?.RemoveTrailingZeros();
                txtLongitud.Text = obj.longitud?.RemoveTrailingZeros();
                txtFono01.Text = obj.fono1;
                txtFono02.Text = obj.fono2;
                txtDato01.Text = obj.txt_datos1;
                txtDato02.Text = obj.txt_datos2;
                txtDato03.Text = obj.txt_datos3;
                txtDato04.Text = obj.txt_datos4;
                chkAlmacen.Checked = obj.sn_almacen == 1 ? true : false;
                chkLocationActual.Checked = obj.sn_location_current == 1 ? true : false;

                cboTipoLocation.SelectedValue = obj.id_tipo_location;

                if (obj.id_dist != null)
                {
                    cboDepartamento.SelectedValue = obj.SNTt33_distrito.SNTt32_provincia.id_dpto;
                    cboProvincia.SelectedValue = obj.SNTt33_distrito.id_prov;
                    cboDistrito.SelectedValue = obj.id_dist;
                }
                else
                {
                    cboDepartamento.SelectedIndex = -1;
                    cboProvincia.SelectedIndex = -1;
                    cboDistrito.SelectedIndex = -1;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(this, "Excepción en el Set: " + e.Message);
            }
        }

        private bool EsValido()
        {
            //Por ver - validar combos.
            errorProv.Clear();
            bool no_error = true;


            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                tabLocation.SelectedTab = tabPagGeneral;
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
                        tabLocation.SelectedTab = tabPagGeneral;
                        string msg = $"El código '{Reserved.Code.ToString()}' es reservado para el sistema.";
                        MessageBox.Show(msg, "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        errorProv.SetError(txtCodigo, msg);
                        txtCodigo.Focus();
                        no_error = false;
                    }
                    else
                    {
                        var obj = new LocationBL().LocationXCod(cod);
                        if (TipoOperacion == TipoOperacionABM.Insertar)
                        {
                            if (obj != null && obj.id_location > 0)
                            {
                                tabLocation.SelectedTab = tabPagGeneral;
                                MessageBox.Show("El código ya está en uso.", "MENSAJE EAGLE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                errorProv.SetError(txtCodigo, "El código ya está en uso.");
                                txtCodigo.Focus();
                                no_error = false;
                            }
                        }
                        else if (TipoOperacion == TipoOperacionABM.Modificar)
                        {
                            if (cod != codSelected && obj != null && obj.id_location > 0)
                            {
                                tabLocation.SelectedTab = tabPagGeneral;
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

            if (no_error)
            {
                if (dtpFechaNegocio.CustomFormat != DateFormat.DateOnly)
                {
                    tabLocation.SelectedTab = tabPagGeneral;
                    errorProv.SetError(dtpFechaNegocio, "Este campo es requerido.");
                    dtpFechaNegocio.Focus();
                    no_error = false;
                }
                else
                {
                    var hoy = UtilBL.GetCurrentDateTime.Date;
                    if (dtpFechaNegocio.Value.Date > hoy)
                    {
                        tabLocation.SelectedTab = tabPagGeneral;
                        errorProv.SetError(dtpFechaNegocio, $"La fecha de negocio no puede ser mayor a la fecha actual ({hoy.ToString(DateFormat.DateOnly)}).");
                        dtpFechaNegocio.Focus();
                        no_error = false;
                    }
                }
            }

            if (no_error)
            {
                var latitudTxt = txtLatitud.Text.Trim();
                var longitudTxt = txtLongitud.Text.Trim();

                if (decimal.TryParse(longitudTxt, out decimal longitud) && (longitud > 180 || longitud < -180))
                {
                    tabLocation.SelectedTab = tabPagDireccion;
                    errorProv.SetError(txtLongitud, "La longitud debe ser un número entre -180 y 180.");
                    txtLongitud.Focus();
                    no_error = false;
                }

                if (decimal.TryParse(latitudTxt, out decimal latitud) && (latitud > 90 || latitud < -90))
                {
                    tabLocation.SelectedTab = tabPagDireccion;
                    errorProv.SetError(txtLatitud, "La latitud debe ser un número entre -90 y 90.");
                    txtLatitud.Focus();
                    no_error = false;
                }
            }

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
                    DataGridViewRow row = dgvLocation.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["NOMBRE"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvLocation.Rows.Count > 0)
                        {
                            dgvLocation.Rows[index].Selected = true;
                            dgvLocation.FirstDisplayedScrollingRowIndex = index;
                        }
                    }
                }
                else if (criterio == Filtro.Codigo)
                {
                    DataGridViewRow row = dgvLocation.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["CODIGO"].Value.ToString().ToUpper().Contains(filtro.ToUpper()))
                    .FirstOrDefault();
                    if (row != null)
                    {
                        index = row.Index;
                        if (dgvLocation.Rows.Count > 0)
                        {
                            dgvLocation.Rows[index].Selected = true;
                            dgvLocation.FirstDisplayedScrollingRowIndex = index;
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
                DataGridViewRow row = dgvLocation.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["id_location"].Value.ToString().Equals(id.ToString()))
                .FirstOrDefault();
                if (row != null)
                {
                    index = row.Index;
                    if (dgvLocation.Rows.Count > 0)
                    {
                        dgvLocation.Rows[index].Selected = true;
                        dgvLocation.FirstDisplayedScrollingRowIndex = index;
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
            if (dgvLocation.RowCount > 0 && dgvLocation.SelectedRows.Count > 0 && dgvLocation.CurrentRow.Index != -1)
            {
                int id = 0;
                if (int.TryParse(GetIdSelected(), out id))
                {
                    if (id > 0)
                    {
                        var obj = new LocationBL().LocationXIdMM(id);
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
                if (dgvLocation.SelectedRows.Count > 0 && dgvLocation.Rows.Count > 0)
                {
                    id = dgvLocation.SelectedRows[0].Cells[0].Value.ToString();
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
            lblIdLocation.Text = 0 + "";
            codSelected = "";
            var hoy = UtilBL.GetCurrentDateTime.Date;

            dtpFechaNegocio.Value = hoy;
            DateFormat.SetFormat(dtpFechaNegocio, DateFormat.Blank);

            txtNombre.Clear();
            txtCodigo.Clear();
            txtDireccion01.Clear();
            txtDireccion02.Clear();
            txtAbrev01.Clear();
            txtAbrev02.Clear();
            txtNumRuc.Clear();
            txtLatitud.Clear();
            txtLongitud.Clear();
            txtFono01.Clear();
            txtFono02.Clear();
            txtDato01.Clear();
            txtDato02.Clear();
            txtDato03.Clear();
            txtDato04.Clear();
            chkAlmacen.Checked = false;
            chkLocationActual.Checked = false;

            if (TipoOperacion == TipoOperacionABM.Nuevo)
                chkActivo.Enabled = false;
            else
                chkActivo.Enabled = true;

            chkActivo.Checked = true;

            if (cboTipoLocation.Items.Count > 0) cboTipoLocation.SelectedIndex = 0;
            cboDepartamento.SelectedIndex = (cboDepartamento.Items.Count > 0) ? 0 : -1;
            cboProvincia.SelectedIndex = (cboProvincia.Items.Count > 0) ? 0 : -1;
            cboDistrito.SelectedIndex = (cboDistrito.Items.Count > 0) ? 0 : -1;
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
            }
            else
            {
                if (TipoOperacion == TipoOperacionABM.Nuevo)
                {
                    ControlarBotones(false, false, true, true, false, false);
                    errorProv.Clear();
                    LimpiarForm();
                    tabLocation.SelectedTab = tabPagGeneral;
                    txtNombre.Focus();
                }
                else
                {
                    if (TipoOperacion == TipoOperacionABM.Insertar)
                    {
                        ControlarBotones(true, true, false, false, true, true);
                        LimpiarForm();

                        if (tglListarInactivos.Checked) { ActualizarGrilla(); } else { ActualizarGrilla(Estado.IdActivo); }

                        int idInsertado = (int)id;
                        SeleccionarPorId(idInsertado);
                        btnNuevo.Focus();
                    }
                    else
                    {
                        if (TipoOperacion == TipoOperacionABM.Eliminar)
                        {
                            errorProv.Clear();
                            ControlarBotones(true, true, false, false, true, true);
                            LimpiarForm();
                            if (tglListarInactivos.Checked) { ActualizarGrilla(); } else { ActualizarGrilla(Estado.IdActivo); }
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
                cboTipoLocation.DataSource = null;
                cboTipoLocation.DisplayMember = "txt_desc";
                cboTipoLocation.ValueMember = "id_tipo_location";
                cboTipoLocation.DataSource = new TipoLocationBL().ListaTipoLocation(Estado.IdActivo, false, true);

                cboDepartamento.DataSource = null;
                cboDepartamento.DisplayMember = "txt_desc";
                cboDepartamento.ValueMember = "id_dpto";
                cboDepartamento.DataSource = new DepartamentoBL().ListaDepartamento(Estado.IdActivo, true);

                cboProvincia.DataSource = null;
                cboProvincia.DisplayMember = "txt_desc";
                cboProvincia.ValueMember = "id_prov";
                cboProvincia.DataSource = (cboDepartamento.SelectedValue != null) ?
                    new ProvinciaBL().ListaProvinciaXDep(int.Parse(cboDepartamento.SelectedValue.ToString()), Estado.IdActivo) : null;

                cboDistrito.DataSource = null;
                cboDistrito.DisplayMember = "txt_desc";
                cboDistrito.ValueMember = "id_dist";
                cboDistrito.DataSource = (cboProvincia.SelectedValue != null) ?
                    new DistritoBL().ListaDistritoXProv(int.Parse(cboProvincia.SelectedValue.ToString()), Estado.IdActivo) : null;

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
                var lista = new LocationBL().ListaLocation(id_estado, true);
                var listaView = lista.Select(x => new { x.id_location, CODIGO = x.cod_location, NOMBRE = x.txt_desc })
                .OrderBy(x => string.IsNullOrEmpty(x.CODIGO)).ThenBy(x => x.CODIGO, new AlphaNumericComparer()).ThenBy(x => x.NOMBRE).ToList();

                if (lista != null)
                {
                    ContarEstados(lista);
                    dgvLocation.DataSource = listaView;
                    dgvLocation.Columns["id_location"].Visible = false;
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
            dgvLocation.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ecf0f1");
            dgvLocation.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#FAFAFA");

            //Cabecera
            dgvLocation.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#00B2EE");
            dgvLocation.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //Selección
            dgvLocation.DefaultCellStyle.SelectionBackColor = Color.DeepSkyBlue;

            //Para que no sobreescriba los estilos de cabecera
            dgvLocation.EnableHeadersVisualStyles = false;

            //Configurando columnas del grid
            dgvLocation.AllowUserToResizeColumns = true;
            dgvLocation.Columns["CODIGO"].HeaderText = "CÓDIGO";

            dgvLocation.Columns["CODIGO"].Width = 100;
            dgvLocation.Columns["NOMBRE"].Width = 300;
        }
        private void SetMaxLengthTxt()
        {
            txtCodigo.MaxLength = 10;
            txtNombre.MaxLength = 250;
            txtDireccion01.MaxLength = 300;
            txtDireccion02.MaxLength = 300;
            txtAbrev01.MaxLength = 30;
            txtAbrev02.MaxLength = 30;
            txtNumRuc.MaxLength = 20;
            txtFono01.MaxLength = 20;
            txtFono02.MaxLength = 20;
            txtDato01.MaxLength = 150;
            txtDato02.MaxLength = 150;
            txtDato03.MaxLength = 150;
            txtDato04.MaxLength = 150;
            txtLatitud.MaxLength = 11;
            txtLongitud.MaxLength = 11;
        }
        private void ContarEstados(List<MSTt08_location> lista)
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
                MessageBox.Show(this, $"Excepción el contar los estados: {e.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void FormLocation_Load(object sender, EventArgs e)
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
            lblIdLocation.Visible = false;
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

        private void cboFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            txtFiltro.Focus();
        }

        private void dgvLocation_SelectionChanged(object sender, EventArgs e)
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
                        if (idSelect != lblIdLocation.Text && idSelect != "-1")
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
                    if (idSelect != lblIdLocation.Text && idSelect != "-1")
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

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDepartamento.SelectedValue != null)
            {
                cboProvincia.DataSource = null;
                cboProvincia.DisplayMember = "txt_desc";
                cboProvincia.ValueMember = "id_prov";
                cboProvincia.DataSource = new ProvinciaBL().ListaProvinciaXDep(int.Parse(cboDepartamento.SelectedValue.ToString()), Estado.IdActivo);
            }
            else cboProvincia.DataSource = null;

            cboProvincia.DropDownWidth = ControlHelper.DropDownWidth(cboProvincia);

            isChangedRow = false;
        }

        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboProvincia.SelectedValue != null)
            {
                cboDistrito.DataSource = null;
                cboDistrito.DisplayMember = "txt_desc";
                cboDistrito.ValueMember = "id_dist";
                cboDistrito.DataSource = new DistritoBL().ListaDistritoXProv(int.Parse(cboProvincia.SelectedValue.ToString()), Estado.IdActivo);
            }
            else cboDistrito.DataSource = null;

            cboDistrito.DropDownWidth = ControlHelper.DropDownWidth(cboDistrito);

            isChangedRow = false;
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

        private void DtpLimpiar_KeyPress(object sender, KeyPressEventArgs e)
        {
            var dtp = ((DateTimePicker)sender);
            if (e.KeyChar == (char)Keys.Escape && dtp.CustomFormat != DateFormat.Blank)
            {
                DateFormat.SetFormat(dtp, DateFormat.Blank);
                isChangedRow = false;
            }
        }

        private void DtpVer_MouseDown(object sender, MouseEventArgs e)
        {
            var dtp = ((DateTimePicker)sender);
            if (dtp.CustomFormat != DateFormat.DateOnly)
            {
                DateFormat.SetFormat(dtp, DateFormat.DateOnly);
                isChangedRow = false;
            }
        }

        private void dtpVer_CloseUp(object sender, EventArgs e)
        {
            var dtp = ((DateTimePicker)sender);
            if (dtp.CustomFormat != DateFormat.DateOnly)
            {
                DateFormat.SetFormat(dtp, DateFormat.DateOnly);
                isChangedRow = false;
            }
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Convert.ToInt32(Keys.Enter))
            {
                btnFilter_Click(null, null);
            }
        }

        private void btnTipoLocation_Click(object sender, EventArgs e)
        {
            try
            {
                int oldValue = 0;
                int op = TipoOperacion;

                if (cboTipoLocation.SelectedValue != null)
                    oldValue = int.Parse(cboTipoLocation.SelectedValue.ToString());

                var frm = new FormTipoLocation();
                frm.ShowDialog();

                if (frm.actualizar)
                {
                    cboTipoLocation.DataSource = null;
                    cboTipoLocation.DisplayMember = "txt_desc";
                    cboTipoLocation.ValueMember = "id_tipo_location";
                    cboTipoLocation.DataSource = new TipoLocationBL().ListaTipoLocation(Estado.IdActivo, false, true);
                    cboTipoLocation.DropDownWidth = ControlHelper.DropDownWidth(cboTipoLocation);
                    cboTipoLocation.SelectedValue = oldValue;
                    TipoOperacion = op;
                    MantenerEstadoABM();
                }

            }
            catch (Exception exc)
            {
                MessageBox.Show(this, $"Excepción cuando se intentaba actualizar el combo. {exc.Message}", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
