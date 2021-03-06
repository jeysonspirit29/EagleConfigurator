﻿using ConfigUtilitarios.Controls;

namespace ConfiguradorUI.Persona
{
    partial class FormEmpleado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleado));
            this.tglListarInactivos = new MetroFramework.Controls.MetroToggle();
            this.lblListarInactivos = new MetroFramework.Controls.MetroLabel();
            this.panelFiltro = new MetroFramework.Controls.MetroPanel();
            this.lblFiltro = new MetroFramework.Controls.MetroLabel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFiltro = new MetroFramework.Controls.MetroTextBox();
            this.cboFiltro = new ConfigUtilitarios.Controls.BorderedCombo();
            this.tabEmpleado = new MetroFramework.Controls.MetroTabControl();
            this.tabPagGeneral = new MetroFramework.Controls.MetroTabPage();
            this.lblDescUsername = new MetroFramework.Controls.MetroLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grbUser = new System.Windows.Forms.GroupBox();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cboMotivoBaja = new ConfigUtilitarios.Controls.BorderedCombo();
            this.cboSuspLaboral = new ConfigUtilitarios.Controls.BorderedCombo();
            this.btnCategoriaEmp = new MetroFramework.Controls.MetroLink();
            this.btnClaseEmp = new MetroFramework.Controls.MetroLink();
            this.lblMotivoBaja = new MetroFramework.Controls.MetroLabel();
            this.lblCategoriaEmp = new MetroFramework.Controls.MetroLabel();
            this.cboCategoriaEmp = new ConfigUtilitarios.Controls.BorderedCombo();
            this.cboClaseEmp = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblClaseEmp = new MetroFramework.Controls.MetroLabel();
            this.chkActivo = new MetroFramework.Controls.MetroCheckBox();
            this.txtSegundoNom = new MetroFramework.Controls.MetroTextBox();
            this.lblPrimerNom = new MetroFramework.Controls.MetroLabel();
            this.lblSituacion = new MetroFramework.Controls.MetroLabel();
            this.txtPrimerNom = new MetroFramework.Controls.MetroTextBox();
            this.cboSituacion = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblSegundoNom = new MetroFramework.Controls.MetroLabel();
            this.txtNumRuc = new MetroFramework.Controls.MetroTextBox();
            this.lblNumRuc = new MetroFramework.Controls.MetroLabel();
            this.txtNumDoc = new MetroFramework.Controls.MetroTextBox();
            this.lblNumDoc = new MetroFramework.Controls.MetroLabel();
            this.cboTipoDocIdentidad = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblTipoDocIdentidad = new MetroFramework.Controls.MetroLabel();
            this.txtNomComercial = new MetroFramework.Controls.MetroTextBox();
            this.lblNomComercial = new MetroFramework.Controls.MetroLabel();
            this.txtRazonSocial = new MetroFramework.Controls.MetroTextBox();
            this.lblRazonSocial = new MetroFramework.Controls.MetroLabel();
            this.lblSexo = new MetroFramework.Controls.MetroLabel();
            this.rbtFemenino = new MetroFramework.Controls.MetroRadioButton();
            this.rbtMasculino = new MetroFramework.Controls.MetroRadioButton();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.lblCodigo = new MetroFramework.Controls.MetroLabel();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFechaNac = new MetroFramework.Controls.MetroLabel();
            this.cboEstadoCivil = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblEstadoCivil = new MetroFramework.Controls.MetroLabel();
            this.txtApMaterno = new MetroFramework.Controls.MetroTextBox();
            this.lblApMaterno = new MetroFramework.Controls.MetroLabel();
            this.txtApPaterno = new MetroFramework.Controls.MetroTextBox();
            this.lblApPaterno = new MetroFramework.Controls.MetroLabel();
            this.lblSuspLaboral = new MetroFramework.Controls.MetroLabel();
            this.tabPagDetalles = new MetroFramework.Controls.MetroTabPage();
            this.grbLaboralSaludPen = new System.Windows.Forms.GroupBox();
            this.cboSaludEps = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblSaludEps = new MetroFramework.Controls.MetroLabel();
            this.cboRegSalud = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblRegSalud = new MetroFramework.Controls.MetroLabel();
            this.cboRegLaboral = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblRegLaboral = new MetroFramework.Controls.MetroLabel();
            this.cboRegPension = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblRegPension = new MetroFramework.Controls.MetroLabel();
            this.cboCondicionLaboral = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblCondicionLaboral = new MetroFramework.Controls.MetroLabel();
            this.cboOcupacion = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblOcupacion = new MetroFramework.Controls.MetroLabel();
            this.cboTipoTrabajador = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblTipoTrabajador = new MetroFramework.Controls.MetroLabel();
            this.dtpFechaCese = new System.Windows.Forms.DateTimePicker();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.grbSalario = new System.Windows.Forms.GroupBox();
            this.cboPeriodoPago = new ConfigUtilitarios.Controls.BorderedCombo();
            this.cboEntidadFinanciera = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblPeriodoPago = new MetroFramework.Controls.MetroLabel();
            this.txtNumHorasMes = new MetroFramework.Controls.MetroTextBox();
            this.lblNumHorasMes = new MetroFramework.Controls.MetroLabel();
            this.txtNumCuenta = new MetroFramework.Controls.MetroTextBox();
            this.lblNumCuenta = new MetroFramework.Controls.MetroLabel();
            this.lblEntidadFinanciera = new MetroFramework.Controls.MetroLabel();
            this.txtSalQuincenal = new MetroFramework.Controls.MetroTextBox();
            this.lblSalQuincenal = new MetroFramework.Controls.MetroLabel();
            this.txtSalHora = new MetroFramework.Controls.MetroTextBox();
            this.lblSalHora = new MetroFramework.Controls.MetroLabel();
            this.txtSalMensual = new MetroFramework.Controls.MetroTextBox();
            this.lblSalMensual = new MetroFramework.Controls.MetroLabel();
            this.tabPagTrabajo = new MetroFramework.Controls.MetroTabPage();
            this.btnAsignarTrabajo = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnDesasignarTrabajo = new System.Windows.Forms.Button();
            this.cboTrabajo = new ConfigUtilitarios.Controls.BorderedCombo();
            this.dgvTrabajoEmpleado = new System.Windows.Forms.DataGridView();
            this.tabPagDireccion = new MetroFramework.Controls.MetroTabPage();
            this.grbUbicacionDetallada = new System.Windows.Forms.GroupBox();
            this.txtDireccion01 = new MetroFramework.Controls.MetroTextBox();
            this.lblDireccion02 = new MetroFramework.Controls.MetroLabel();
            this.lblDireccion01 = new MetroFramework.Controls.MetroLabel();
            this.txtDireccion02 = new MetroFramework.Controls.MetroTextBox();
            this.txtNomZona = new MetroFramework.Controls.MetroTextBox();
            this.lblNomZona = new MetroFramework.Controls.MetroLabel();
            this.txtNomVia = new MetroFramework.Controls.MetroTextBox();
            this.lblZona = new MetroFramework.Controls.MetroLabel();
            this.cboZona = new ConfigUtilitarios.Controls.BorderedCombo();
            this.txtReferencia = new MetroFramework.Controls.MetroTextBox();
            this.lblNomVia = new MetroFramework.Controls.MetroLabel();
            this.lblReferencia = new MetroFramework.Controls.MetroLabel();
            this.txtNumVia = new MetroFramework.Controls.MetroTextBox();
            this.lblVia = new MetroFramework.Controls.MetroLabel();
            this.cboVia = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblNumVia = new MetroFramework.Controls.MetroLabel();
            this.gbrUbigeo = new System.Windows.Forms.GroupBox();
            this.lblDepartamento = new MetroFramework.Controls.MetroLabel();
            this.cboDepartamento = new ConfigUtilitarios.Controls.BorderedCombo();
            this.cboDistrito = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblDistrito = new MetroFramework.Controls.MetroLabel();
            this.lblNacionalidad = new MetroFramework.Controls.MetroLabel();
            this.lblProvincia = new MetroFramework.Controls.MetroLabel();
            this.cboNacionalidad = new ConfigUtilitarios.Controls.BorderedCombo();
            this.cboProvincia = new ConfigUtilitarios.Controls.BorderedCombo();
            this.tabPagEducacion = new MetroFramework.Controls.MetroTabPage();
            this.grbSkillsEducativas = new System.Windows.Forms.GroupBox();
            this.cboEspcMedica = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblEspcMedica = new MetroFramework.Controls.MetroLabel();
            this.lblSituacionEdu = new MetroFramework.Controls.MetroLabel();
            this.cboTipoEspc = new ConfigUtilitarios.Controls.BorderedCombo();
            this.cboSituacionEdu = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblTipoEspc = new MetroFramework.Controls.MetroLabel();
            this.lblModalidadFormativa = new MetroFramework.Controls.MetroLabel();
            this.cboModalidadFormativa = new ConfigUtilitarios.Controls.BorderedCombo();
            this.tabPagContacto = new MetroFramework.Controls.MetroTabPage();
            this.grbEmailYWeb = new System.Windows.Forms.GroupBox();
            this.txtEmail02 = new MetroFramework.Controls.MetroTextBox();
            this.lblEmail02 = new MetroFramework.Controls.MetroLabel();
            this.txtPagWeb = new MetroFramework.Controls.MetroTextBox();
            this.lblPagWeb = new MetroFramework.Controls.MetroLabel();
            this.txtEmail01 = new MetroFramework.Controls.MetroTextBox();
            this.lblEmail01 = new MetroFramework.Controls.MetroLabel();
            this.grbNumerosContacto = new System.Windows.Forms.GroupBox();
            this.txtTelfFijo02 = new MetroFramework.Controls.MetroTextBox();
            this.txtCelular02 = new MetroFramework.Controls.MetroTextBox();
            this.txtTelfFijo01 = new MetroFramework.Controls.MetroTextBox();
            this.lblCelular02 = new MetroFramework.Controls.MetroLabel();
            this.lblTelFijo02 = new MetroFramework.Controls.MetroLabel();
            this.txtCelular03 = new MetroFramework.Controls.MetroTextBox();
            this.lblTelFijo01 = new MetroFramework.Controls.MetroLabel();
            this.lblCelular03 = new MetroFramework.Controls.MetroLabel();
            this.txtTelfFijo03 = new MetroFramework.Controls.MetroTextBox();
            this.lblTelFijo03 = new MetroFramework.Controls.MetroLabel();
            this.txtCelular01 = new MetroFramework.Controls.MetroTextBox();
            this.lblCelular01 = new MetroFramework.Controls.MetroLabel();
            this.tabPagInfoExtra = new MetroFramework.Controls.MetroTabPage();
            this.grbInfoExtra = new System.Windows.Forms.GroupBox();
            this.txtInfo10 = new MetroFramework.Controls.MetroTextBox();
            this.lblInfo10 = new MetroFramework.Controls.MetroLabel();
            this.txtInfo08 = new MetroFramework.Controls.MetroTextBox();
            this.lblInfo08 = new MetroFramework.Controls.MetroLabel();
            this.txtInfo09 = new MetroFramework.Controls.MetroTextBox();
            this.lblInfo09 = new MetroFramework.Controls.MetroLabel();
            this.txtInfo07 = new MetroFramework.Controls.MetroTextBox();
            this.lblInfo07 = new MetroFramework.Controls.MetroLabel();
            this.txtInfo05 = new MetroFramework.Controls.MetroTextBox();
            this.lblInfo05 = new MetroFramework.Controls.MetroLabel();
            this.txtInfo06 = new MetroFramework.Controls.MetroTextBox();
            this.lblInfo06 = new MetroFramework.Controls.MetroLabel();
            this.txtInfo04 = new MetroFramework.Controls.MetroTextBox();
            this.lblInfo04 = new MetroFramework.Controls.MetroLabel();
            this.txtInfo02 = new MetroFramework.Controls.MetroTextBox();
            this.lblInfo02 = new MetroFramework.Controls.MetroLabel();
            this.txtInfo03 = new MetroFramework.Controls.MetroTextBox();
            this.lblInfo03 = new MetroFramework.Controls.MetroLabel();
            this.txtInfo01 = new MetroFramework.Controls.MetroTextBox();
            this.lblInfo01 = new MetroFramework.Controls.MetroLabel();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.btnCerrar = new MetroFramework.Controls.MetroLink();
            this.panelMantenimiento = new MetroFramework.Controls.MetroPanel();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnRollback = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblIdEmpleado = new MetroFramework.Controls.MetroLabel();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.lblNumInactivo = new System.Windows.Forms.Label();
            this.lblNumActivo = new System.Windows.Forms.Label();
            this.lblNumReg = new System.Windows.Forms.Label();
            this.panelFiltro.SuspendLayout();
            this.tabEmpleado.SuspendLayout();
            this.tabPagGeneral.SuspendLayout();
            this.grbUser.SuspendLayout();
            this.tabPagDetalles.SuspendLayout();
            this.grbLaboralSaludPen.SuspendLayout();
            this.grbSalario.SuspendLayout();
            this.tabPagTrabajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajoEmpleado)).BeginInit();
            this.tabPagDireccion.SuspendLayout();
            this.grbUbicacionDetallada.SuspendLayout();
            this.gbrUbigeo.SuspendLayout();
            this.tabPagEducacion.SuspendLayout();
            this.grbSkillsEducativas.SuspendLayout();
            this.tabPagContacto.SuspendLayout();
            this.grbEmailYWeb.SuspendLayout();
            this.grbNumerosContacto.SuspendLayout();
            this.tabPagInfoExtra.SuspendLayout();
            this.grbInfoExtra.SuspendLayout();
            this.panelMantenimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // tglListarInactivos
            // 
            this.tglListarInactivos.AutoSize = true;
            this.tglListarInactivos.Location = new System.Drawing.Point(138, 104);
            this.tglListarInactivos.Name = "tglListarInactivos";
            this.tglListarInactivos.Size = new System.Drawing.Size(80, 17);
            this.tglListarInactivos.TabIndex = 4;
            this.tglListarInactivos.Text = "Off";
            this.tglListarInactivos.UseSelectable = true;
            this.tglListarInactivos.Click += new System.EventHandler(this.tglListarInactivos_Click);
            // 
            // lblListarInactivos
            // 
            this.lblListarInactivos.AutoSize = true;
            this.lblListarInactivos.Location = new System.Drawing.Point(38, 104);
            this.lblListarInactivos.Name = "lblListarInactivos";
            this.lblListarInactivos.Size = new System.Drawing.Size(92, 19);
            this.lblListarInactivos.TabIndex = 4;
            this.lblListarInactivos.Text = "Listar inactivos";
            // 
            // panelFiltro
            // 
            this.panelFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panelFiltro.Controls.Add(this.lblFiltro);
            this.panelFiltro.Controls.Add(this.btnFilter);
            this.panelFiltro.Controls.Add(this.txtFiltro);
            this.panelFiltro.Controls.Add(this.cboFiltro);
            this.panelFiltro.HorizontalScrollbarBarColor = true;
            this.panelFiltro.HorizontalScrollbarHighlightOnWheel = false;
            this.panelFiltro.HorizontalScrollbarSize = 10;
            this.panelFiltro.Location = new System.Drawing.Point(407, 561);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(564, 44);
            this.panelFiltro.TabIndex = 3;
            this.panelFiltro.UseCustomBackColor = true;
            this.panelFiltro.VerticalScrollbarBarColor = true;
            this.panelFiltro.VerticalScrollbarHighlightOnWheel = false;
            this.panelFiltro.VerticalScrollbarSize = 10;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltro.ForeColor = System.Drawing.Color.Navy;
            this.lblFiltro.Location = new System.Drawing.Point(13, 13);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(76, 19);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Buscar por:";
            this.lblFiltro.UseCustomBackColor = true;
            this.lblFiltro.UseCustomForeColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFilter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnFilter.Image")));
            this.btnFilter.Location = new System.Drawing.Point(520, 8);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(37, 30);
            this.btnFilter.TabIndex = 1;
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtFiltro
            // 
            // 
            // 
            // 
            this.txtFiltro.CustomButton.Image = null;
            this.txtFiltro.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtFiltro.CustomButton.Name = "";
            this.txtFiltro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltro.CustomButton.TabIndex = 1;
            this.txtFiltro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltro.CustomButton.UseSelectable = true;
            this.txtFiltro.CustomButton.Visible = false;
            this.txtFiltro.Lines = new string[0];
            this.txtFiltro.Location = new System.Drawing.Point(291, 11);
            this.txtFiltro.MaxLength = 32767;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.PasswordChar = '\0';
            this.txtFiltro.PromptText = "Filtro";
            this.txtFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltro.SelectedText = "";
            this.txtFiltro.SelectionLength = 0;
            this.txtFiltro.SelectionStart = 0;
            this.txtFiltro.ShortcutsEnabled = true;
            this.txtFiltro.Size = new System.Drawing.Size(222, 23);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.UseSelectable = true;
            this.txtFiltro.WaterMark = "Filtro";
            this.txtFiltro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // cboFiltro
            // 
            this.cboFiltro.BackColor = System.Drawing.Color.White;
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Location = new System.Drawing.Point(95, 11);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(172, 23);
            this.cboFiltro.TabIndex = 2;
            this.cboFiltro.SelectedIndexChanged += new System.EventHandler(this.cboFiltro_SelectedIndexChanged);
            // 
            // tabEmpleado
            // 
            this.tabEmpleado.Controls.Add(this.tabPagGeneral);
            this.tabEmpleado.Controls.Add(this.tabPagDetalles);
            this.tabEmpleado.Controls.Add(this.tabPagTrabajo);
            this.tabEmpleado.Controls.Add(this.tabPagDireccion);
            this.tabEmpleado.Controls.Add(this.tabPagEducacion);
            this.tabEmpleado.Controls.Add(this.tabPagContacto);
            this.tabEmpleado.Controls.Add(this.tabPagInfoExtra);
            this.tabEmpleado.Location = new System.Drawing.Point(407, 91);
            this.tabEmpleado.Name = "tabEmpleado";
            this.tabEmpleado.SelectedIndex = 0;
            this.tabEmpleado.Size = new System.Drawing.Size(586, 464);
            this.tabEmpleado.TabIndex = 1;
            this.tabEmpleado.UseSelectable = true;
            // 
            // tabPagGeneral
            // 
            this.tabPagGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.tabPagGeneral.Controls.Add(this.lblDescUsername);
            this.tabPagGeneral.Controls.Add(this.panel3);
            this.tabPagGeneral.Controls.Add(this.grbUser);
            this.tabPagGeneral.Controls.Add(this.panel2);
            this.tabPagGeneral.Controls.Add(this.cboMotivoBaja);
            this.tabPagGeneral.Controls.Add(this.cboSuspLaboral);
            this.tabPagGeneral.Controls.Add(this.btnCategoriaEmp);
            this.tabPagGeneral.Controls.Add(this.btnClaseEmp);
            this.tabPagGeneral.Controls.Add(this.lblMotivoBaja);
            this.tabPagGeneral.Controls.Add(this.lblCategoriaEmp);
            this.tabPagGeneral.Controls.Add(this.cboCategoriaEmp);
            this.tabPagGeneral.Controls.Add(this.cboClaseEmp);
            this.tabPagGeneral.Controls.Add(this.lblClaseEmp);
            this.tabPagGeneral.Controls.Add(this.chkActivo);
            this.tabPagGeneral.Controls.Add(this.txtSegundoNom);
            this.tabPagGeneral.Controls.Add(this.lblPrimerNom);
            this.tabPagGeneral.Controls.Add(this.lblSituacion);
            this.tabPagGeneral.Controls.Add(this.txtPrimerNom);
            this.tabPagGeneral.Controls.Add(this.cboSituacion);
            this.tabPagGeneral.Controls.Add(this.lblSegundoNom);
            this.tabPagGeneral.Controls.Add(this.txtNumRuc);
            this.tabPagGeneral.Controls.Add(this.lblNumRuc);
            this.tabPagGeneral.Controls.Add(this.txtNumDoc);
            this.tabPagGeneral.Controls.Add(this.lblNumDoc);
            this.tabPagGeneral.Controls.Add(this.cboTipoDocIdentidad);
            this.tabPagGeneral.Controls.Add(this.lblTipoDocIdentidad);
            this.tabPagGeneral.Controls.Add(this.txtNomComercial);
            this.tabPagGeneral.Controls.Add(this.lblNomComercial);
            this.tabPagGeneral.Controls.Add(this.txtRazonSocial);
            this.tabPagGeneral.Controls.Add(this.lblRazonSocial);
            this.tabPagGeneral.Controls.Add(this.lblSexo);
            this.tabPagGeneral.Controls.Add(this.rbtFemenino);
            this.tabPagGeneral.Controls.Add(this.rbtMasculino);
            this.tabPagGeneral.Controls.Add(this.txtCodigo);
            this.tabPagGeneral.Controls.Add(this.lblCodigo);
            this.tabPagGeneral.Controls.Add(this.dtpFechaNacimiento);
            this.tabPagGeneral.Controls.Add(this.panel1);
            this.tabPagGeneral.Controls.Add(this.lblFechaNac);
            this.tabPagGeneral.Controls.Add(this.cboEstadoCivil);
            this.tabPagGeneral.Controls.Add(this.lblEstadoCivil);
            this.tabPagGeneral.Controls.Add(this.txtApMaterno);
            this.tabPagGeneral.Controls.Add(this.lblApMaterno);
            this.tabPagGeneral.Controls.Add(this.txtApPaterno);
            this.tabPagGeneral.Controls.Add(this.lblApPaterno);
            this.tabPagGeneral.Controls.Add(this.lblSuspLaboral);
            this.tabPagGeneral.HorizontalScrollbarBarColor = true;
            this.tabPagGeneral.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.HorizontalScrollbarSize = 10;
            this.tabPagGeneral.Location = new System.Drawing.Point(4, 38);
            this.tabPagGeneral.Name = "tabPagGeneral";
            this.tabPagGeneral.Size = new System.Drawing.Size(578, 422);
            this.tabPagGeneral.TabIndex = 0;
            this.tabPagGeneral.Text = "General";
            this.tabPagGeneral.VerticalScrollbarBarColor = true;
            this.tabPagGeneral.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.VerticalScrollbarSize = 10;
            // 
            // lblDescUsername
            // 
            this.lblDescUsername.AutoSize = true;
            this.lblDescUsername.ForeColor = System.Drawing.Color.Navy;
            this.lblDescUsername.Location = new System.Drawing.Point(290, 396);
            this.lblDescUsername.Name = "lblDescUsername";
            this.lblDescUsername.Size = new System.Drawing.Size(56, 19);
            this.lblDescUsername.TabIndex = 114;
            this.lblDescUsername.Text = "Usuario:";
            this.lblDescUsername.UseCustomForeColor = true;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(3, 380);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(555, 5);
            this.panel3.TabIndex = 113;
            // 
            // grbUser
            // 
            this.grbUser.BackColor = System.Drawing.Color.White;
            this.grbUser.Controls.Add(this.lblUsername);
            this.grbUser.Controls.Add(this.btnCrearUsuario);
            this.grbUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUser.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbUser.Location = new System.Drawing.Point(376, 380);
            this.grbUser.Name = "grbUser";
            this.grbUser.Size = new System.Drawing.Size(177, 41);
            this.grbUser.TabIndex = 20;
            this.grbUser.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUsername.ForeColor = System.Drawing.Color.Navy;
            this.lblUsername.Location = new System.Drawing.Point(5, 12);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(167, 24);
            this.lblUsername.TabIndex = 108;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsername.UseCustomForeColor = true;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCrearUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCrearUsuario.FlatAppearance.BorderSize = 0;
            this.btnCrearUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCrearUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.ForeColor = System.Drawing.Color.White;
            this.btnCrearUsuario.Location = new System.Drawing.Point(5, 12);
            this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(167, 24);
            this.btnCrearUsuario.TabIndex = 0;
            this.btnCrearUsuario.Text = "Crear usuario";
            this.btnCrearUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(3, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 5);
            this.panel2.TabIndex = 58;
            // 
            // cboMotivoBaja
            // 
            this.cboMotivoBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboMotivoBaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotivoBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMotivoBaja.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMotivoBaja.FormattingEnabled = true;
            this.cboMotivoBaja.Location = new System.Drawing.Point(376, 312);
            this.cboMotivoBaja.Name = "cboMotivoBaja";
            this.cboMotivoBaja.Size = new System.Drawing.Size(180, 23);
            this.cboMotivoBaja.TabIndex = 17;
            this.cboMotivoBaja.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // cboSuspLaboral
            // 
            this.cboSuspLaboral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboSuspLaboral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSuspLaboral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSuspLaboral.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSuspLaboral.FormattingEnabled = true;
            this.cboSuspLaboral.Location = new System.Drawing.Point(82, 346);
            this.cboSuspLaboral.Name = "cboSuspLaboral";
            this.cboSuspLaboral.Size = new System.Drawing.Size(184, 23);
            this.cboSuspLaboral.TabIndex = 18;
            this.cboSuspLaboral.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // btnCategoriaEmp
            // 
            this.btnCategoriaEmp.Image = ((System.Drawing.Image)(resources.GetObject("btnCategoriaEmp.Image")));
            this.btnCategoriaEmp.ImageSize = 24;
            this.btnCategoriaEmp.Location = new System.Drawing.Point(534, 157);
            this.btnCategoriaEmp.Name = "btnCategoriaEmp";
            this.btnCategoriaEmp.Size = new System.Drawing.Size(29, 27);
            this.btnCategoriaEmp.TabIndex = 22;
            this.btnCategoriaEmp.UseSelectable = true;
            this.btnCategoriaEmp.Click += new System.EventHandler(this.btnCategoriaEmp_Click);
            // 
            // btnClaseEmp
            // 
            this.btnClaseEmp.Image = ((System.Drawing.Image)(resources.GetObject("btnClaseEmp.Image")));
            this.btnClaseEmp.ImageSize = 24;
            this.btnClaseEmp.Location = new System.Drawing.Point(244, 157);
            this.btnClaseEmp.Name = "btnClaseEmp";
            this.btnClaseEmp.Size = new System.Drawing.Size(29, 27);
            this.btnClaseEmp.TabIndex = 21;
            this.btnClaseEmp.UseSelectable = true;
            this.btnClaseEmp.Click += new System.EventHandler(this.btnClaseEmp_Click);
            // 
            // lblMotivoBaja
            // 
            this.lblMotivoBaja.AutoSize = true;
            this.lblMotivoBaja.ForeColor = System.Drawing.Color.Navy;
            this.lblMotivoBaja.Location = new System.Drawing.Point(289, 312);
            this.lblMotivoBaja.Name = "lblMotivoBaja";
            this.lblMotivoBaja.Size = new System.Drawing.Size(82, 19);
            this.lblMotivoBaja.TabIndex = 2;
            this.lblMotivoBaja.Text = "Motivo Baja:";
            this.lblMotivoBaja.UseCustomForeColor = true;
            // 
            // lblCategoriaEmp
            // 
            this.lblCategoriaEmp.AutoSize = true;
            this.lblCategoriaEmp.ForeColor = System.Drawing.Color.Navy;
            this.lblCategoriaEmp.Location = new System.Drawing.Point(289, 163);
            this.lblCategoriaEmp.Name = "lblCategoriaEmp";
            this.lblCategoriaEmp.Size = new System.Drawing.Size(81, 19);
            this.lblCategoriaEmp.TabIndex = 19;
            this.lblCategoriaEmp.Text = "Categ. Emp:";
            this.lblCategoriaEmp.UseCustomForeColor = true;
            // 
            // cboCategoriaEmp
            // 
            this.cboCategoriaEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboCategoriaEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoriaEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategoriaEmp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoriaEmp.FormattingEnabled = true;
            this.cboCategoriaEmp.Location = new System.Drawing.Point(376, 161);
            this.cboCategoriaEmp.Name = "cboCategoriaEmp";
            this.cboCategoriaEmp.Size = new System.Drawing.Size(152, 23);
            this.cboCategoriaEmp.TabIndex = 10;
            this.cboCategoriaEmp.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // cboClaseEmp
            // 
            this.cboClaseEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboClaseEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClaseEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboClaseEmp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboClaseEmp.FormattingEnabled = true;
            this.cboClaseEmp.Location = new System.Drawing.Point(83, 161);
            this.cboClaseEmp.Name = "cboClaseEmp";
            this.cboClaseEmp.Size = new System.Drawing.Size(155, 23);
            this.cboClaseEmp.TabIndex = 9;
            this.cboClaseEmp.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblClaseEmp
            // 
            this.lblClaseEmp.AutoSize = true;
            this.lblClaseEmp.ForeColor = System.Drawing.Color.Navy;
            this.lblClaseEmp.Location = new System.Drawing.Point(0, 163);
            this.lblClaseEmp.Name = "lblClaseEmp";
            this.lblClaseEmp.Size = new System.Drawing.Size(74, 19);
            this.lblClaseEmp.TabIndex = 17;
            this.lblClaseEmp.Text = "Clase Emp:";
            this.lblClaseEmp.UseCustomForeColor = true;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkActivo.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkActivo.ForeColor = System.Drawing.Color.Navy;
            this.chkActivo.Location = new System.Drawing.Point(5, 396);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(61, 19);
            this.chkActivo.TabIndex = 19;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseCustomForeColor = true;
            this.chkActivo.UseSelectable = true;
            this.chkActivo.CheckedChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // txtSegundoNom
            // 
            this.txtSegundoNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtSegundoNom.CustomButton.Image = null;
            this.txtSegundoNom.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtSegundoNom.CustomButton.Name = "";
            this.txtSegundoNom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSegundoNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSegundoNom.CustomButton.TabIndex = 1;
            this.txtSegundoNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSegundoNom.CustomButton.UseSelectable = true;
            this.txtSegundoNom.CustomButton.Visible = false;
            this.txtSegundoNom.Lines = new string[0];
            this.txtSegundoNom.Location = new System.Drawing.Point(376, 12);
            this.txtSegundoNom.MaxLength = 32767;
            this.txtSegundoNom.Name = "txtSegundoNom";
            this.txtSegundoNom.PasswordChar = '\0';
            this.txtSegundoNom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSegundoNom.SelectedText = "";
            this.txtSegundoNom.SelectionLength = 0;
            this.txtSegundoNom.SelectionStart = 0;
            this.txtSegundoNom.ShortcutsEnabled = true;
            this.txtSegundoNom.Size = new System.Drawing.Size(181, 23);
            this.txtSegundoNom.TabIndex = 1;
            this.txtSegundoNom.UseCustomBackColor = true;
            this.txtSegundoNom.UseSelectable = true;
            this.txtSegundoNom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSegundoNom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSegundoNom.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblPrimerNom
            // 
            this.lblPrimerNom.AutoSize = true;
            this.lblPrimerNom.ForeColor = System.Drawing.Color.Navy;
            this.lblPrimerNom.Location = new System.Drawing.Point(1, 14);
            this.lblPrimerNom.Name = "lblPrimerNom";
            this.lblPrimerNom.Size = new System.Drawing.Size(76, 19);
            this.lblPrimerNom.TabIndex = 0;
            this.lblPrimerNom.Text = "1° Nombre:";
            this.lblPrimerNom.UseCustomForeColor = true;
            // 
            // lblSituacion
            // 
            this.lblSituacion.AutoSize = true;
            this.lblSituacion.ForeColor = System.Drawing.Color.Navy;
            this.lblSituacion.Location = new System.Drawing.Point(2, 310);
            this.lblSituacion.Name = "lblSituacion";
            this.lblSituacion.Size = new System.Drawing.Size(64, 19);
            this.lblSituacion.TabIndex = 0;
            this.lblSituacion.Text = "Situación:";
            this.lblSituacion.UseCustomForeColor = true;
            // 
            // txtPrimerNom
            // 
            this.txtPrimerNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPrimerNom.CustomButton.Image = null;
            this.txtPrimerNom.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtPrimerNom.CustomButton.Name = "";
            this.txtPrimerNom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrimerNom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrimerNom.CustomButton.TabIndex = 1;
            this.txtPrimerNom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrimerNom.CustomButton.UseSelectable = true;
            this.txtPrimerNom.CustomButton.Visible = false;
            this.txtPrimerNom.Lines = new string[0];
            this.txtPrimerNom.Location = new System.Drawing.Point(84, 12);
            this.txtPrimerNom.MaxLength = 32767;
            this.txtPrimerNom.Name = "txtPrimerNom";
            this.txtPrimerNom.PasswordChar = '\0';
            this.txtPrimerNom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrimerNom.SelectedText = "";
            this.txtPrimerNom.SelectionLength = 0;
            this.txtPrimerNom.SelectionStart = 0;
            this.txtPrimerNom.ShortcutsEnabled = true;
            this.txtPrimerNom.Size = new System.Drawing.Size(184, 23);
            this.txtPrimerNom.TabIndex = 0;
            this.txtPrimerNom.UseCustomBackColor = true;
            this.txtPrimerNom.UseSelectable = true;
            this.txtPrimerNom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrimerNom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrimerNom.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // cboSituacion
            // 
            this.cboSituacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboSituacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSituacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSituacion.FormattingEnabled = true;
            this.cboSituacion.Location = new System.Drawing.Point(82, 310);
            this.cboSituacion.Name = "cboSituacion";
            this.cboSituacion.Size = new System.Drawing.Size(184, 23);
            this.cboSituacion.TabIndex = 16;
            this.cboSituacion.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblSegundoNom
            // 
            this.lblSegundoNom.AutoSize = true;
            this.lblSegundoNom.ForeColor = System.Drawing.Color.Navy;
            this.lblSegundoNom.Location = new System.Drawing.Point(290, 14);
            this.lblSegundoNom.Name = "lblSegundoNom";
            this.lblSegundoNom.Size = new System.Drawing.Size(78, 19);
            this.lblSegundoNom.TabIndex = 2;
            this.lblSegundoNom.Text = "2° Nombre:";
            this.lblSegundoNom.UseCustomForeColor = true;
            // 
            // txtNumRuc
            // 
            this.txtNumRuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNumRuc.CustomButton.Image = null;
            this.txtNumRuc.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtNumRuc.CustomButton.Name = "";
            this.txtNumRuc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumRuc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumRuc.CustomButton.TabIndex = 1;
            this.txtNumRuc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumRuc.CustomButton.UseSelectable = true;
            this.txtNumRuc.CustomButton.Visible = false;
            this.txtNumRuc.Lines = new string[0];
            this.txtNumRuc.Location = new System.Drawing.Point(82, 262);
            this.txtNumRuc.MaxLength = 32767;
            this.txtNumRuc.Name = "txtNumRuc";
            this.txtNumRuc.PasswordChar = '\0';
            this.txtNumRuc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumRuc.SelectedText = "";
            this.txtNumRuc.SelectionLength = 0;
            this.txtNumRuc.SelectionStart = 0;
            this.txtNumRuc.ShortcutsEnabled = true;
            this.txtNumRuc.Size = new System.Drawing.Size(184, 23);
            this.txtNumRuc.TabIndex = 15;
            this.txtNumRuc.UseCustomBackColor = true;
            this.txtNumRuc.UseSelectable = true;
            this.txtNumRuc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumRuc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumRuc.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblNumRuc
            // 
            this.lblNumRuc.AutoSize = true;
            this.lblNumRuc.ForeColor = System.Drawing.Color.Navy;
            this.lblNumRuc.Location = new System.Drawing.Point(2, 264);
            this.lblNumRuc.Name = "lblNumRuc";
            this.lblNumRuc.Size = new System.Drawing.Size(74, 19);
            this.lblNumRuc.TabIndex = 29;
            this.lblNumRuc.Text = "Núm. RUC:";
            this.lblNumRuc.UseCustomForeColor = true;
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNumDoc.CustomButton.Image = null;
            this.txtNumDoc.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtNumDoc.CustomButton.Name = "";
            this.txtNumDoc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumDoc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumDoc.CustomButton.TabIndex = 1;
            this.txtNumDoc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumDoc.CustomButton.UseSelectable = true;
            this.txtNumDoc.CustomButton.Visible = false;
            this.txtNumDoc.Lines = new string[0];
            this.txtNumDoc.Location = new System.Drawing.Point(376, 228);
            this.txtNumDoc.MaxLength = 32767;
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.PasswordChar = '\0';
            this.txtNumDoc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumDoc.SelectedText = "";
            this.txtNumDoc.SelectionLength = 0;
            this.txtNumDoc.SelectionStart = 0;
            this.txtNumDoc.ShortcutsEnabled = true;
            this.txtNumDoc.Size = new System.Drawing.Size(182, 23);
            this.txtNumDoc.TabIndex = 14;
            this.txtNumDoc.UseCustomBackColor = true;
            this.txtNumDoc.UseSelectable = true;
            this.txtNumDoc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumDoc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumDoc.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblNumDoc
            // 
            this.lblNumDoc.AutoSize = true;
            this.lblNumDoc.ForeColor = System.Drawing.Color.Navy;
            this.lblNumDoc.Location = new System.Drawing.Point(289, 230);
            this.lblNumDoc.Name = "lblNumDoc";
            this.lblNumDoc.Size = new System.Drawing.Size(71, 19);
            this.lblNumDoc.TabIndex = 27;
            this.lblNumDoc.Text = "Núm. Doc:";
            this.lblNumDoc.UseCustomForeColor = true;
            // 
            // cboTipoDocIdentidad
            // 
            this.cboTipoDocIdentidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboTipoDocIdentidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocIdentidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoDocIdentidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoDocIdentidad.FormattingEnabled = true;
            this.cboTipoDocIdentidad.Location = new System.Drawing.Point(83, 228);
            this.cboTipoDocIdentidad.Name = "cboTipoDocIdentidad";
            this.cboTipoDocIdentidad.Size = new System.Drawing.Size(184, 23);
            this.cboTipoDocIdentidad.TabIndex = 13;
            this.cboTipoDocIdentidad.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblTipoDocIdentidad
            // 
            this.lblTipoDocIdentidad.AutoSize = true;
            this.lblTipoDocIdentidad.ForeColor = System.Drawing.Color.Navy;
            this.lblTipoDocIdentidad.Location = new System.Drawing.Point(2, 230);
            this.lblTipoDocIdentidad.Name = "lblTipoDocIdentidad";
            this.lblTipoDocIdentidad.Size = new System.Drawing.Size(65, 19);
            this.lblTipoDocIdentidad.TabIndex = 25;
            this.lblTipoDocIdentidad.Text = "Tipo Doc:";
            this.lblTipoDocIdentidad.UseCustomForeColor = true;
            // 
            // txtNomComercial
            // 
            this.txtNomComercial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNomComercial.CustomButton.Image = null;
            this.txtNomComercial.CustomButton.Location = new System.Drawing.Point(160, 1);
            this.txtNomComercial.CustomButton.Name = "";
            this.txtNomComercial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomComercial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomComercial.CustomButton.TabIndex = 1;
            this.txtNomComercial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomComercial.CustomButton.UseSelectable = true;
            this.txtNomComercial.CustomButton.Visible = false;
            this.txtNomComercial.Lines = new string[0];
            this.txtNomComercial.Location = new System.Drawing.Point(376, 194);
            this.txtNomComercial.MaxLength = 32767;
            this.txtNomComercial.Name = "txtNomComercial";
            this.txtNomComercial.PasswordChar = '\0';
            this.txtNomComercial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomComercial.SelectedText = "";
            this.txtNomComercial.SelectionLength = 0;
            this.txtNomComercial.SelectionStart = 0;
            this.txtNomComercial.ShortcutsEnabled = true;
            this.txtNomComercial.Size = new System.Drawing.Size(182, 23);
            this.txtNomComercial.TabIndex = 12;
            this.txtNomComercial.UseCustomBackColor = true;
            this.txtNomComercial.UseSelectable = true;
            this.txtNomComercial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomComercial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomComercial.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblNomComercial
            // 
            this.lblNomComercial.AutoSize = true;
            this.lblNomComercial.ForeColor = System.Drawing.Color.Navy;
            this.lblNomComercial.Location = new System.Drawing.Point(289, 196);
            this.lblNomComercial.Name = "lblNomComercial";
            this.lblNomComercial.Size = new System.Drawing.Size(89, 19);
            this.lblNomComercial.TabIndex = 23;
            this.lblNomComercial.Text = "N. Comercial:";
            this.lblNomComercial.UseCustomForeColor = true;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtRazonSocial.CustomButton.Image = null;
            this.txtRazonSocial.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtRazonSocial.CustomButton.Name = "";
            this.txtRazonSocial.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtRazonSocial.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRazonSocial.CustomButton.TabIndex = 1;
            this.txtRazonSocial.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRazonSocial.CustomButton.UseSelectable = true;
            this.txtRazonSocial.CustomButton.Visible = false;
            this.txtRazonSocial.Lines = new string[0];
            this.txtRazonSocial.Location = new System.Drawing.Point(82, 194);
            this.txtRazonSocial.MaxLength = 32767;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.PasswordChar = '\0';
            this.txtRazonSocial.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRazonSocial.SelectedText = "";
            this.txtRazonSocial.SelectionLength = 0;
            this.txtRazonSocial.SelectionStart = 0;
            this.txtRazonSocial.ShortcutsEnabled = true;
            this.txtRazonSocial.Size = new System.Drawing.Size(184, 23);
            this.txtRazonSocial.TabIndex = 11;
            this.txtRazonSocial.UseCustomBackColor = true;
            this.txtRazonSocial.UseSelectable = true;
            this.txtRazonSocial.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRazonSocial.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRazonSocial.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.ForeColor = System.Drawing.Color.Navy;
            this.lblRazonSocial.Location = new System.Drawing.Point(0, 196);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(86, 19);
            this.lblRazonSocial.TabIndex = 21;
            this.lblRazonSocial.Text = "Razón Social:";
            this.lblRazonSocial.UseCustomForeColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.ForeColor = System.Drawing.Color.Navy;
            this.lblSexo.Location = new System.Drawing.Point(289, 115);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(40, 19);
            this.lblSexo.TabIndex = 14;
            this.lblSexo.Text = "Sexo:";
            this.lblSexo.UseCustomForeColor = true;
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(482, 119);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(76, 15);
            this.rbtFemenino.TabIndex = 8;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseSelectable = true;
            this.rbtFemenino.CheckedChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(376, 119);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(78, 15);
            this.rbtMasculino.TabIndex = 7;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseSelectable = true;
            this.rbtMasculino.CheckedChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtCodigo.CustomButton.Image = null;
            this.txtCodigo.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtCodigo.CustomButton.Name = "";
            this.txtCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo.CustomButton.TabIndex = 1;
            this.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo.CustomButton.UseSelectable = true;
            this.txtCodigo.CustomButton.Visible = false;
            this.txtCodigo.Lines = new string[0];
            this.txtCodigo.Location = new System.Drawing.Point(83, 80);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(184, 23);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.UseCustomBackColor = true;
            this.txtCodigo.UseSelectable = true;
            this.txtCodigo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCodigo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCodigo.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.ForeColor = System.Drawing.Color.Navy;
            this.lblCodigo.Location = new System.Drawing.Point(0, 82);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 19);
            this.lblCodigo.TabIndex = 8;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.UseCustomForeColor = true;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(376, 80);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(179, 23);
            this.dtpFechaNacimiento.TabIndex = 5;
            this.dtpFechaNacimiento.ValueChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(3, 146);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 5);
            this.panel1.TabIndex = 57;
            // 
            // lblFechaNac
            // 
            this.lblFechaNac.AutoSize = true;
            this.lblFechaNac.ForeColor = System.Drawing.Color.Navy;
            this.lblFechaNac.Location = new System.Drawing.Point(289, 82);
            this.lblFechaNac.Name = "lblFechaNac";
            this.lblFechaNac.Size = new System.Drawing.Size(73, 19);
            this.lblFechaNac.TabIndex = 10;
            this.lblFechaNac.Text = "Fecha Nac:";
            this.lblFechaNac.UseCustomForeColor = true;
            // 
            // cboEstadoCivil
            // 
            this.cboEstadoCivil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboEstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoCivil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEstadoCivil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstadoCivil.FormattingEnabled = true;
            this.cboEstadoCivil.Location = new System.Drawing.Point(84, 114);
            this.cboEstadoCivil.Name = "cboEstadoCivil";
            this.cboEstadoCivil.Size = new System.Drawing.Size(181, 23);
            this.cboEstadoCivil.TabIndex = 6;
            this.cboEstadoCivil.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.ForeColor = System.Drawing.Color.Navy;
            this.lblEstadoCivil.Location = new System.Drawing.Point(2, 116);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(79, 19);
            this.lblEstadoCivil.TabIndex = 12;
            this.lblEstadoCivil.Text = "Estado Civil:";
            this.lblEstadoCivil.UseCustomForeColor = true;
            // 
            // txtApMaterno
            // 
            this.txtApMaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtApMaterno.CustomButton.Image = null;
            this.txtApMaterno.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtApMaterno.CustomButton.Name = "";
            this.txtApMaterno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApMaterno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApMaterno.CustomButton.TabIndex = 1;
            this.txtApMaterno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApMaterno.CustomButton.UseSelectable = true;
            this.txtApMaterno.CustomButton.Visible = false;
            this.txtApMaterno.Lines = new string[0];
            this.txtApMaterno.Location = new System.Drawing.Point(376, 46);
            this.txtApMaterno.MaxLength = 32767;
            this.txtApMaterno.Name = "txtApMaterno";
            this.txtApMaterno.PasswordChar = '\0';
            this.txtApMaterno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApMaterno.SelectedText = "";
            this.txtApMaterno.SelectionLength = 0;
            this.txtApMaterno.SelectionStart = 0;
            this.txtApMaterno.ShortcutsEnabled = true;
            this.txtApMaterno.Size = new System.Drawing.Size(181, 23);
            this.txtApMaterno.TabIndex = 3;
            this.txtApMaterno.UseCustomBackColor = true;
            this.txtApMaterno.UseSelectable = true;
            this.txtApMaterno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApMaterno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtApMaterno.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblApMaterno
            // 
            this.lblApMaterno.AutoSize = true;
            this.lblApMaterno.ForeColor = System.Drawing.Color.Navy;
            this.lblApMaterno.Location = new System.Drawing.Point(289, 48);
            this.lblApMaterno.Name = "lblApMaterno";
            this.lblApMaterno.Size = new System.Drawing.Size(86, 19);
            this.lblApMaterno.TabIndex = 6;
            this.lblApMaterno.Text = "Ap. Materno:";
            this.lblApMaterno.UseCustomForeColor = true;
            // 
            // txtApPaterno
            // 
            this.txtApPaterno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtApPaterno.CustomButton.Image = null;
            this.txtApPaterno.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtApPaterno.CustomButton.Name = "";
            this.txtApPaterno.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtApPaterno.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtApPaterno.CustomButton.TabIndex = 1;
            this.txtApPaterno.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtApPaterno.CustomButton.UseSelectable = true;
            this.txtApPaterno.CustomButton.Visible = false;
            this.txtApPaterno.Lines = new string[0];
            this.txtApPaterno.Location = new System.Drawing.Point(83, 46);
            this.txtApPaterno.MaxLength = 32767;
            this.txtApPaterno.Name = "txtApPaterno";
            this.txtApPaterno.PasswordChar = '\0';
            this.txtApPaterno.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtApPaterno.SelectedText = "";
            this.txtApPaterno.SelectionLength = 0;
            this.txtApPaterno.SelectionStart = 0;
            this.txtApPaterno.ShortcutsEnabled = true;
            this.txtApPaterno.Size = new System.Drawing.Size(184, 23);
            this.txtApPaterno.TabIndex = 2;
            this.txtApPaterno.UseCustomBackColor = true;
            this.txtApPaterno.UseSelectable = true;
            this.txtApPaterno.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtApPaterno.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtApPaterno.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblApPaterno
            // 
            this.lblApPaterno.AutoSize = true;
            this.lblApPaterno.ForeColor = System.Drawing.Color.Navy;
            this.lblApPaterno.Location = new System.Drawing.Point(0, 48);
            this.lblApPaterno.Name = "lblApPaterno";
            this.lblApPaterno.Size = new System.Drawing.Size(81, 19);
            this.lblApPaterno.TabIndex = 4;
            this.lblApPaterno.Text = "Ap. Paterno:";
            this.lblApPaterno.UseCustomForeColor = true;
            // 
            // lblSuspLaboral
            // 
            this.lblSuspLaboral.AutoSize = true;
            this.lblSuspLaboral.ForeColor = System.Drawing.Color.Navy;
            this.lblSuspLaboral.Location = new System.Drawing.Point(2, 346);
            this.lblSuspLaboral.Name = "lblSuspLaboral";
            this.lblSuspLaboral.Size = new System.Drawing.Size(81, 19);
            this.lblSuspLaboral.TabIndex = 4;
            this.lblSuspLaboral.Text = "Susp. Labor:";
            this.lblSuspLaboral.UseCustomForeColor = true;
            // 
            // tabPagDetalles
            // 
            this.tabPagDetalles.Controls.Add(this.grbLaboralSaludPen);
            this.tabPagDetalles.Controls.Add(this.dtpFechaCese);
            this.tabPagDetalles.Controls.Add(this.metroLabel5);
            this.tabPagDetalles.Controls.Add(this.dtpFechaIngreso);
            this.tabPagDetalles.Controls.Add(this.metroLabel4);
            this.tabPagDetalles.Controls.Add(this.grbSalario);
            this.tabPagDetalles.HorizontalScrollbarBarColor = true;
            this.tabPagDetalles.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagDetalles.HorizontalScrollbarSize = 10;
            this.tabPagDetalles.Location = new System.Drawing.Point(4, 38);
            this.tabPagDetalles.Name = "tabPagDetalles";
            this.tabPagDetalles.Size = new System.Drawing.Size(578, 422);
            this.tabPagDetalles.TabIndex = 3;
            this.tabPagDetalles.Text = "Salario y Regimen";
            this.tabPagDetalles.VerticalScrollbarBarColor = true;
            this.tabPagDetalles.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagDetalles.VerticalScrollbarSize = 10;
            // 
            // grbLaboralSaludPen
            // 
            this.grbLaboralSaludPen.BackColor = System.Drawing.Color.Transparent;
            this.grbLaboralSaludPen.Controls.Add(this.cboSaludEps);
            this.grbLaboralSaludPen.Controls.Add(this.lblSaludEps);
            this.grbLaboralSaludPen.Controls.Add(this.cboRegSalud);
            this.grbLaboralSaludPen.Controls.Add(this.lblRegSalud);
            this.grbLaboralSaludPen.Controls.Add(this.cboRegLaboral);
            this.grbLaboralSaludPen.Controls.Add(this.lblRegLaboral);
            this.grbLaboralSaludPen.Controls.Add(this.cboRegPension);
            this.grbLaboralSaludPen.Controls.Add(this.lblRegPension);
            this.grbLaboralSaludPen.Controls.Add(this.cboCondicionLaboral);
            this.grbLaboralSaludPen.Controls.Add(this.lblCondicionLaboral);
            this.grbLaboralSaludPen.Controls.Add(this.cboOcupacion);
            this.grbLaboralSaludPen.Controls.Add(this.lblOcupacion);
            this.grbLaboralSaludPen.Controls.Add(this.cboTipoTrabajador);
            this.grbLaboralSaludPen.Controls.Add(this.lblTipoTrabajador);
            this.grbLaboralSaludPen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbLaboralSaludPen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLaboralSaludPen.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbLaboralSaludPen.Location = new System.Drawing.Point(4, 196);
            this.grbLaboralSaludPen.Name = "grbLaboralSaludPen";
            this.grbLaboralSaludPen.Size = new System.Drawing.Size(571, 155);
            this.grbLaboralSaludPen.TabIndex = 3;
            this.grbLaboralSaludPen.TabStop = false;
            this.grbLaboralSaludPen.Text = "Situación Laboral, Salud y Pensión";
            // 
            // cboSaludEps
            // 
            this.cboSaludEps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboSaludEps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSaludEps.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSaludEps.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSaludEps.FormattingEnabled = true;
            this.cboSaludEps.Location = new System.Drawing.Point(97, 120);
            this.cboSaludEps.Name = "cboSaludEps";
            this.cboSaludEps.Size = new System.Drawing.Size(176, 23);
            this.cboSaludEps.TabIndex = 6;
            this.cboSaludEps.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblSaludEps
            // 
            this.lblSaludEps.AutoSize = true;
            this.lblSaludEps.ForeColor = System.Drawing.Color.Navy;
            this.lblSaludEps.Location = new System.Drawing.Point(12, 122);
            this.lblSaludEps.Name = "lblSaludEps";
            this.lblSaludEps.Size = new System.Drawing.Size(70, 19);
            this.lblSaludEps.TabIndex = 12;
            this.lblSaludEps.Text = "Salud EPS:";
            this.lblSaludEps.UseCustomForeColor = true;
            // 
            // cboRegSalud
            // 
            this.cboRegSalud.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboRegSalud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegSalud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRegSalud.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRegSalud.FormattingEnabled = true;
            this.cboRegSalud.Location = new System.Drawing.Point(379, 88);
            this.cboRegSalud.Name = "cboRegSalud";
            this.cboRegSalud.Size = new System.Drawing.Size(176, 23);
            this.cboRegSalud.TabIndex = 5;
            this.cboRegSalud.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblRegSalud
            // 
            this.lblRegSalud.AutoSize = true;
            this.lblRegSalud.ForeColor = System.Drawing.Color.Navy;
            this.lblRegSalud.Location = new System.Drawing.Point(290, 90);
            this.lblRegSalud.Name = "lblRegSalud";
            this.lblRegSalud.Size = new System.Drawing.Size(74, 19);
            this.lblRegSalud.TabIndex = 10;
            this.lblRegSalud.Text = "Reg. Salud:";
            this.lblRegSalud.UseCustomForeColor = true;
            // 
            // cboRegLaboral
            // 
            this.cboRegLaboral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboRegLaboral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegLaboral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRegLaboral.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRegLaboral.FormattingEnabled = true;
            this.cboRegLaboral.Location = new System.Drawing.Point(97, 88);
            this.cboRegLaboral.Name = "cboRegLaboral";
            this.cboRegLaboral.Size = new System.Drawing.Size(176, 23);
            this.cboRegLaboral.TabIndex = 4;
            this.cboRegLaboral.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblRegLaboral
            // 
            this.lblRegLaboral.AutoSize = true;
            this.lblRegLaboral.ForeColor = System.Drawing.Color.Navy;
            this.lblRegLaboral.Location = new System.Drawing.Point(12, 90);
            this.lblRegLaboral.Name = "lblRegLaboral";
            this.lblRegLaboral.Size = new System.Drawing.Size(77, 19);
            this.lblRegLaboral.TabIndex = 8;
            this.lblRegLaboral.Text = "Reg. Labor:";
            this.lblRegLaboral.UseCustomForeColor = true;
            // 
            // cboRegPension
            // 
            this.cboRegPension.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboRegPension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRegPension.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboRegPension.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRegPension.FormattingEnabled = true;
            this.cboRegPension.Location = new System.Drawing.Point(379, 56);
            this.cboRegPension.Name = "cboRegPension";
            this.cboRegPension.Size = new System.Drawing.Size(176, 23);
            this.cboRegPension.TabIndex = 3;
            this.cboRegPension.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblRegPension
            // 
            this.lblRegPension.AutoSize = true;
            this.lblRegPension.ForeColor = System.Drawing.Color.Navy;
            this.lblRegPension.Location = new System.Drawing.Point(290, 58);
            this.lblRegPension.Name = "lblRegPension";
            this.lblRegPension.Size = new System.Drawing.Size(86, 19);
            this.lblRegPension.TabIndex = 6;
            this.lblRegPension.Text = "Reg. Pensión:";
            this.lblRegPension.UseCustomForeColor = true;
            // 
            // cboCondicionLaboral
            // 
            this.cboCondicionLaboral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboCondicionLaboral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCondicionLaboral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCondicionLaboral.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCondicionLaboral.FormattingEnabled = true;
            this.cboCondicionLaboral.Location = new System.Drawing.Point(97, 56);
            this.cboCondicionLaboral.Name = "cboCondicionLaboral";
            this.cboCondicionLaboral.Size = new System.Drawing.Size(176, 23);
            this.cboCondicionLaboral.TabIndex = 2;
            this.cboCondicionLaboral.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblCondicionLaboral
            // 
            this.lblCondicionLaboral.AutoSize = true;
            this.lblCondicionLaboral.ForeColor = System.Drawing.Color.Navy;
            this.lblCondicionLaboral.Location = new System.Drawing.Point(12, 58);
            this.lblCondicionLaboral.Name = "lblCondicionLaboral";
            this.lblCondicionLaboral.Size = new System.Drawing.Size(86, 19);
            this.lblCondicionLaboral.TabIndex = 4;
            this.lblCondicionLaboral.Text = "Cond. Labor:";
            this.lblCondicionLaboral.UseCustomForeColor = true;
            // 
            // cboOcupacion
            // 
            this.cboOcupacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboOcupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOcupacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboOcupacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOcupacion.FormattingEnabled = true;
            this.cboOcupacion.Location = new System.Drawing.Point(379, 24);
            this.cboOcupacion.Name = "cboOcupacion";
            this.cboOcupacion.Size = new System.Drawing.Size(176, 23);
            this.cboOcupacion.TabIndex = 1;
            this.cboOcupacion.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblOcupacion
            // 
            this.lblOcupacion.AutoSize = true;
            this.lblOcupacion.ForeColor = System.Drawing.Color.Navy;
            this.lblOcupacion.Location = new System.Drawing.Point(290, 26);
            this.lblOcupacion.Name = "lblOcupacion";
            this.lblOcupacion.Size = new System.Drawing.Size(75, 19);
            this.lblOcupacion.TabIndex = 2;
            this.lblOcupacion.Text = "Ocupación:";
            this.lblOcupacion.UseCustomForeColor = true;
            // 
            // cboTipoTrabajador
            // 
            this.cboTipoTrabajador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboTipoTrabajador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoTrabajador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoTrabajador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoTrabajador.FormattingEnabled = true;
            this.cboTipoTrabajador.Location = new System.Drawing.Point(97, 24);
            this.cboTipoTrabajador.Name = "cboTipoTrabajador";
            this.cboTipoTrabajador.Size = new System.Drawing.Size(176, 23);
            this.cboTipoTrabajador.TabIndex = 0;
            this.cboTipoTrabajador.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblTipoTrabajador
            // 
            this.lblTipoTrabajador.AutoSize = true;
            this.lblTipoTrabajador.ForeColor = System.Drawing.Color.Navy;
            this.lblTipoTrabajador.Location = new System.Drawing.Point(12, 26);
            this.lblTipoTrabajador.Name = "lblTipoTrabajador";
            this.lblTipoTrabajador.Size = new System.Drawing.Size(77, 19);
            this.lblTipoTrabajador.TabIndex = 0;
            this.lblTipoTrabajador.Text = "Tipo Trabaj:";
            this.lblTipoTrabajador.UseCustomForeColor = true;
            // 
            // dtpFechaCese
            // 
            this.dtpFechaCese.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.dtpFechaCese.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaCese.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaCese.Location = new System.Drawing.Point(379, 12);
            this.dtpFechaCese.Name = "dtpFechaCese";
            this.dtpFechaCese.ShowCheckBox = true;
            this.dtpFechaCese.Size = new System.Drawing.Size(116, 23);
            this.dtpFechaCese.TabIndex = 1;
            this.dtpFechaCese.ValueChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel5.Location = new System.Drawing.Point(292, 14);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(78, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Fecha Cese:";
            this.metroLabel5.UseCustomForeColor = true;
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.dtpFechaIngreso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(154, 12);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(116, 23);
            this.dtpFechaIngreso.TabIndex = 0;
            this.dtpFechaIngreso.ValueChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel4.Location = new System.Drawing.Point(71, 14);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 19);
            this.metroLabel4.TabIndex = 0;
            this.metroLabel4.Text = "Fec. Ingreso:";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // grbSalario
            // 
            this.grbSalario.BackColor = System.Drawing.Color.Transparent;
            this.grbSalario.Controls.Add(this.cboPeriodoPago);
            this.grbSalario.Controls.Add(this.cboEntidadFinanciera);
            this.grbSalario.Controls.Add(this.lblPeriodoPago);
            this.grbSalario.Controls.Add(this.txtNumHorasMes);
            this.grbSalario.Controls.Add(this.lblNumHorasMes);
            this.grbSalario.Controls.Add(this.txtNumCuenta);
            this.grbSalario.Controls.Add(this.lblNumCuenta);
            this.grbSalario.Controls.Add(this.lblEntidadFinanciera);
            this.grbSalario.Controls.Add(this.txtSalQuincenal);
            this.grbSalario.Controls.Add(this.lblSalQuincenal);
            this.grbSalario.Controls.Add(this.txtSalHora);
            this.grbSalario.Controls.Add(this.lblSalHora);
            this.grbSalario.Controls.Add(this.txtSalMensual);
            this.grbSalario.Controls.Add(this.lblSalMensual);
            this.grbSalario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbSalario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSalario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbSalario.Location = new System.Drawing.Point(3, 41);
            this.grbSalario.Name = "grbSalario";
            this.grbSalario.Size = new System.Drawing.Size(571, 149);
            this.grbSalario.TabIndex = 2;
            this.grbSalario.TabStop = false;
            this.grbSalario.Text = "Horas y Salario";
            // 
            // cboPeriodoPago
            // 
            this.cboPeriodoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboPeriodoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPeriodoPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPeriodoPago.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPeriodoPago.FormattingEnabled = true;
            this.cboPeriodoPago.Location = new System.Drawing.Point(98, 56);
            this.cboPeriodoPago.Name = "cboPeriodoPago";
            this.cboPeriodoPago.Size = new System.Drawing.Size(176, 23);
            this.cboPeriodoPago.TabIndex = 1;
            this.cboPeriodoPago.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // cboEntidadFinanciera
            // 
            this.cboEntidadFinanciera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboEntidadFinanciera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEntidadFinanciera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEntidadFinanciera.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEntidadFinanciera.FormattingEnabled = true;
            this.cboEntidadFinanciera.Location = new System.Drawing.Point(98, 24);
            this.cboEntidadFinanciera.Name = "cboEntidadFinanciera";
            this.cboEntidadFinanciera.Size = new System.Drawing.Size(176, 23);
            this.cboEntidadFinanciera.TabIndex = 0;
            this.cboEntidadFinanciera.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblPeriodoPago
            // 
            this.lblPeriodoPago.AutoSize = true;
            this.lblPeriodoPago.ForeColor = System.Drawing.Color.Navy;
            this.lblPeriodoPago.Location = new System.Drawing.Point(10, 60);
            this.lblPeriodoPago.Name = "lblPeriodoPago";
            this.lblPeriodoPago.Size = new System.Drawing.Size(92, 19);
            this.lblPeriodoPago.TabIndex = 2;
            this.lblPeriodoPago.Text = "Periodo Pago:";
            this.lblPeriodoPago.UseCustomForeColor = true;
            // 
            // txtNumHorasMes
            // 
            this.txtNumHorasMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNumHorasMes.CustomButton.Image = null;
            this.txtNumHorasMes.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtNumHorasMes.CustomButton.Name = "";
            this.txtNumHorasMes.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumHorasMes.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumHorasMes.CustomButton.TabIndex = 1;
            this.txtNumHorasMes.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumHorasMes.CustomButton.UseSelectable = true;
            this.txtNumHorasMes.CustomButton.Visible = false;
            this.txtNumHorasMes.Lines = new string[0];
            this.txtNumHorasMes.Location = new System.Drawing.Point(448, 117);
            this.txtNumHorasMes.MaxLength = 32767;
            this.txtNumHorasMes.Name = "txtNumHorasMes";
            this.txtNumHorasMes.PasswordChar = '\0';
            this.txtNumHorasMes.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumHorasMes.SelectedText = "";
            this.txtNumHorasMes.SelectionLength = 0;
            this.txtNumHorasMes.SelectionStart = 0;
            this.txtNumHorasMes.ShortcutsEnabled = true;
            this.txtNumHorasMes.Size = new System.Drawing.Size(104, 23);
            this.txtNumHorasMes.TabIndex = 6;
            this.txtNumHorasMes.UseCustomBackColor = true;
            this.txtNumHorasMes.UseSelectable = true;
            this.txtNumHorasMes.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumHorasMes.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumHorasMes.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblNumHorasMes
            // 
            this.lblNumHorasMes.AutoSize = true;
            this.lblNumHorasMes.BackColor = System.Drawing.Color.Transparent;
            this.lblNumHorasMes.ForeColor = System.Drawing.Color.Navy;
            this.lblNumHorasMes.Location = new System.Drawing.Point(327, 119);
            this.lblNumHorasMes.Name = "lblNumHorasMes";
            this.lblNumHorasMes.Size = new System.Drawing.Size(74, 19);
            this.lblNumHorasMes.TabIndex = 0;
            this.lblNumHorasMes.Text = "Horas Mes:";
            this.lblNumHorasMes.UseCustomForeColor = true;
            // 
            // txtNumCuenta
            // 
            this.txtNumCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNumCuenta.CustomButton.Image = null;
            this.txtNumCuenta.CustomButton.Location = new System.Drawing.Point(154, 1);
            this.txtNumCuenta.CustomButton.Name = "";
            this.txtNumCuenta.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumCuenta.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumCuenta.CustomButton.TabIndex = 1;
            this.txtNumCuenta.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumCuenta.CustomButton.UseSelectable = true;
            this.txtNumCuenta.CustomButton.Visible = false;
            this.txtNumCuenta.Lines = new string[0];
            this.txtNumCuenta.Location = new System.Drawing.Point(98, 88);
            this.txtNumCuenta.MaxLength = 32767;
            this.txtNumCuenta.Name = "txtNumCuenta";
            this.txtNumCuenta.PasswordChar = '\0';
            this.txtNumCuenta.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumCuenta.SelectedText = "";
            this.txtNumCuenta.SelectionLength = 0;
            this.txtNumCuenta.SelectionStart = 0;
            this.txtNumCuenta.ShortcutsEnabled = true;
            this.txtNumCuenta.Size = new System.Drawing.Size(176, 23);
            this.txtNumCuenta.TabIndex = 2;
            this.txtNumCuenta.UseCustomBackColor = true;
            this.txtNumCuenta.UseSelectable = true;
            this.txtNumCuenta.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumCuenta.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumCuenta.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblNumCuenta
            // 
            this.lblNumCuenta.AutoSize = true;
            this.lblNumCuenta.BackColor = System.Drawing.Color.Transparent;
            this.lblNumCuenta.ForeColor = System.Drawing.Color.Navy;
            this.lblNumCuenta.Location = new System.Drawing.Point(10, 92);
            this.lblNumCuenta.Name = "lblNumCuenta";
            this.lblNumCuenta.Size = new System.Drawing.Size(88, 19);
            this.lblNumCuenta.TabIndex = 6;
            this.lblNumCuenta.Text = "N° de cuenta:";
            this.lblNumCuenta.UseCustomForeColor = true;
            // 
            // lblEntidadFinanciera
            // 
            this.lblEntidadFinanciera.AutoSize = true;
            this.lblEntidadFinanciera.ForeColor = System.Drawing.Color.Navy;
            this.lblEntidadFinanciera.Location = new System.Drawing.Point(10, 26);
            this.lblEntidadFinanciera.Name = "lblEntidadFinanciera";
            this.lblEntidadFinanciera.Size = new System.Drawing.Size(71, 19);
            this.lblEntidadFinanciera.TabIndex = 4;
            this.lblEntidadFinanciera.Text = "Financiera:";
            this.lblEntidadFinanciera.UseCustomForeColor = true;
            // 
            // txtSalQuincenal
            // 
            this.txtSalQuincenal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtSalQuincenal.CustomButton.Image = null;
            this.txtSalQuincenal.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtSalQuincenal.CustomButton.Name = "";
            this.txtSalQuincenal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSalQuincenal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSalQuincenal.CustomButton.TabIndex = 1;
            this.txtSalQuincenal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSalQuincenal.CustomButton.UseSelectable = true;
            this.txtSalQuincenal.CustomButton.Visible = false;
            this.txtSalQuincenal.ForeColor = System.Drawing.Color.Black;
            this.txtSalQuincenal.Lines = new string[0];
            this.txtSalQuincenal.Location = new System.Drawing.Point(448, 56);
            this.txtSalQuincenal.MaxLength = 32767;
            this.txtSalQuincenal.Name = "txtSalQuincenal";
            this.txtSalQuincenal.PasswordChar = '\0';
            this.txtSalQuincenal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalQuincenal.SelectedText = "";
            this.txtSalQuincenal.SelectionLength = 0;
            this.txtSalQuincenal.SelectionStart = 0;
            this.txtSalQuincenal.ShortcutsEnabled = true;
            this.txtSalQuincenal.Size = new System.Drawing.Size(104, 23);
            this.txtSalQuincenal.TabIndex = 4;
            this.txtSalQuincenal.UseCustomBackColor = true;
            this.txtSalQuincenal.UseSelectable = true;
            this.txtSalQuincenal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSalQuincenal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSalQuincenal.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblSalQuincenal
            // 
            this.lblSalQuincenal.AutoSize = true;
            this.lblSalQuincenal.BackColor = System.Drawing.Color.Transparent;
            this.lblSalQuincenal.ForeColor = System.Drawing.Color.Navy;
            this.lblSalQuincenal.Location = new System.Drawing.Point(327, 58);
            this.lblSalQuincenal.Name = "lblSalQuincenal";
            this.lblSalQuincenal.Size = new System.Drawing.Size(114, 19);
            this.lblSalQuincenal.TabIndex = 10;
            this.lblSalQuincenal.Text = "Salario Quincenal:";
            this.lblSalQuincenal.UseCustomForeColor = true;
            // 
            // txtSalHora
            // 
            this.txtSalHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtSalHora.CustomButton.Image = null;
            this.txtSalHora.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtSalHora.CustomButton.Name = "";
            this.txtSalHora.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSalHora.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSalHora.CustomButton.TabIndex = 1;
            this.txtSalHora.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSalHora.CustomButton.UseSelectable = true;
            this.txtSalHora.CustomButton.Visible = false;
            this.txtSalHora.Lines = new string[0];
            this.txtSalHora.Location = new System.Drawing.Point(448, 86);
            this.txtSalHora.MaxLength = 32767;
            this.txtSalHora.Name = "txtSalHora";
            this.txtSalHora.PasswordChar = '\0';
            this.txtSalHora.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalHora.SelectedText = "";
            this.txtSalHora.SelectionLength = 0;
            this.txtSalHora.SelectionStart = 0;
            this.txtSalHora.ShortcutsEnabled = true;
            this.txtSalHora.Size = new System.Drawing.Size(104, 23);
            this.txtSalHora.TabIndex = 5;
            this.txtSalHora.UseCustomBackColor = true;
            this.txtSalHora.UseSelectable = true;
            this.txtSalHora.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSalHora.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSalHora.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblSalHora
            // 
            this.lblSalHora.AutoSize = true;
            this.lblSalHora.BackColor = System.Drawing.Color.Transparent;
            this.lblSalHora.ForeColor = System.Drawing.Color.Navy;
            this.lblSalHora.Location = new System.Drawing.Point(327, 88);
            this.lblSalHora.Name = "lblSalHora";
            this.lblSalHora.Size = new System.Drawing.Size(85, 19);
            this.lblSalHora.TabIndex = 12;
            this.lblSalHora.Text = "Salario Hora:";
            this.lblSalHora.UseCustomForeColor = true;
            // 
            // txtSalMensual
            // 
            this.txtSalMensual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtSalMensual.CustomButton.Image = null;
            this.txtSalMensual.CustomButton.Location = new System.Drawing.Point(82, 1);
            this.txtSalMensual.CustomButton.Name = "";
            this.txtSalMensual.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSalMensual.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSalMensual.CustomButton.TabIndex = 1;
            this.txtSalMensual.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSalMensual.CustomButton.UseSelectable = true;
            this.txtSalMensual.CustomButton.Visible = false;
            this.txtSalMensual.Lines = new string[0];
            this.txtSalMensual.Location = new System.Drawing.Point(448, 24);
            this.txtSalMensual.MaxLength = 32767;
            this.txtSalMensual.Name = "txtSalMensual";
            this.txtSalMensual.PasswordChar = '\0';
            this.txtSalMensual.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalMensual.SelectedText = "";
            this.txtSalMensual.SelectionLength = 0;
            this.txtSalMensual.SelectionStart = 0;
            this.txtSalMensual.ShortcutsEnabled = true;
            this.txtSalMensual.Size = new System.Drawing.Size(104, 23);
            this.txtSalMensual.TabIndex = 3;
            this.txtSalMensual.UseCustomBackColor = true;
            this.txtSalMensual.UseSelectable = true;
            this.txtSalMensual.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSalMensual.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSalMensual.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblSalMensual
            // 
            this.lblSalMensual.AutoSize = true;
            this.lblSalMensual.BackColor = System.Drawing.Color.Transparent;
            this.lblSalMensual.ForeColor = System.Drawing.Color.Navy;
            this.lblSalMensual.Location = new System.Drawing.Point(327, 26);
            this.lblSalMensual.Name = "lblSalMensual";
            this.lblSalMensual.Size = new System.Drawing.Size(104, 19);
            this.lblSalMensual.TabIndex = 8;
            this.lblSalMensual.Text = "Salario Mensual:";
            this.lblSalMensual.UseCustomForeColor = true;
            // 
            // tabPagTrabajo
            // 
            this.tabPagTrabajo.Controls.Add(this.btnAsignarTrabajo);
            this.tabPagTrabajo.Controls.Add(this.metroLabel1);
            this.tabPagTrabajo.Controls.Add(this.btnDesasignarTrabajo);
            this.tabPagTrabajo.Controls.Add(this.cboTrabajo);
            this.tabPagTrabajo.Controls.Add(this.dgvTrabajoEmpleado);
            this.tabPagTrabajo.HorizontalScrollbarBarColor = true;
            this.tabPagTrabajo.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagTrabajo.HorizontalScrollbarSize = 10;
            this.tabPagTrabajo.Location = new System.Drawing.Point(4, 38);
            this.tabPagTrabajo.Name = "tabPagTrabajo";
            this.tabPagTrabajo.Size = new System.Drawing.Size(578, 422);
            this.tabPagTrabajo.TabIndex = 7;
            this.tabPagTrabajo.Text = "Trabajos";
            this.tabPagTrabajo.VerticalScrollbarBarColor = true;
            this.tabPagTrabajo.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagTrabajo.VerticalScrollbarSize = 10;
            // 
            // btnAsignarTrabajo
            // 
            this.btnAsignarTrabajo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAsignarTrabajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAsignarTrabajo.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAsignarTrabajo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnAsignarTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarTrabajo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarTrabajo.ForeColor = System.Drawing.Color.White;
            this.btnAsignarTrabajo.Image = ((System.Drawing.Image)(resources.GetObject("btnAsignarTrabajo.Image")));
            this.btnAsignarTrabajo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAsignarTrabajo.Location = new System.Drawing.Point(390, 8);
            this.btnAsignarTrabajo.Name = "btnAsignarTrabajo";
            this.btnAsignarTrabajo.Size = new System.Drawing.Size(81, 30);
            this.btnAsignarTrabajo.TabIndex = 2;
            this.btnAsignarTrabajo.Text = "Asignar";
            this.btnAsignarTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsignarTrabajo.UseVisualStyleBackColor = false;
            this.btnAsignarTrabajo.Click += new System.EventHandler(this.btnAsignarTrabajo_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel1.Location = new System.Drawing.Point(3, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(137, 19);
            this.metroLabel1.TabIndex = 182;
            this.metroLabel1.Text = "Seleccione un trabajo:";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // btnDesasignarTrabajo
            // 
            this.btnDesasignarTrabajo.BackColor = System.Drawing.Color.Gray;
            this.btnDesasignarTrabajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDesasignarTrabajo.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDesasignarTrabajo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDesasignarTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesasignarTrabajo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesasignarTrabajo.ForeColor = System.Drawing.Color.White;
            this.btnDesasignarTrabajo.Image = ((System.Drawing.Image)(resources.GetObject("btnDesasignarTrabajo.Image")));
            this.btnDesasignarTrabajo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesasignarTrabajo.Location = new System.Drawing.Point(477, 8);
            this.btnDesasignarTrabajo.Name = "btnDesasignarTrabajo";
            this.btnDesasignarTrabajo.Size = new System.Drawing.Size(98, 30);
            this.btnDesasignarTrabajo.TabIndex = 3;
            this.btnDesasignarTrabajo.Text = "Desasignar";
            this.btnDesasignarTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDesasignarTrabajo.UseVisualStyleBackColor = false;
            this.btnDesasignarTrabajo.Click += new System.EventHandler(this.btnDesasignarTrabajo_Click);
            // 
            // cboTrabajo
            // 
            this.cboTrabajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboTrabajo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTrabajo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrabajo.FormattingEnabled = true;
            this.cboTrabajo.Location = new System.Drawing.Point(141, 12);
            this.cboTrabajo.Name = "cboTrabajo";
            this.cboTrabajo.Size = new System.Drawing.Size(243, 23);
            this.cboTrabajo.TabIndex = 1;
            // 
            // dgvTrabajoEmpleado
            // 
            this.dgvTrabajoEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajoEmpleado.Location = new System.Drawing.Point(3, 44);
            this.dgvTrabajoEmpleado.Name = "dgvTrabajoEmpleado";
            this.dgvTrabajoEmpleado.Size = new System.Drawing.Size(572, 347);
            this.dgvTrabajoEmpleado.TabIndex = 0;
            this.dgvTrabajoEmpleado.DataSourceChanged += new System.EventHandler(this.dgvTrabajoEmpleado_DataSourceChanged);
            // 
            // tabPagDireccion
            // 
            this.tabPagDireccion.Controls.Add(this.grbUbicacionDetallada);
            this.tabPagDireccion.Controls.Add(this.gbrUbigeo);
            this.tabPagDireccion.HorizontalScrollbarBarColor = true;
            this.tabPagDireccion.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagDireccion.HorizontalScrollbarSize = 10;
            this.tabPagDireccion.Location = new System.Drawing.Point(4, 38);
            this.tabPagDireccion.Name = "tabPagDireccion";
            this.tabPagDireccion.Size = new System.Drawing.Size(578, 422);
            this.tabPagDireccion.TabIndex = 4;
            this.tabPagDireccion.Text = "Dirección";
            this.tabPagDireccion.VerticalScrollbarBarColor = true;
            this.tabPagDireccion.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagDireccion.VerticalScrollbarSize = 10;
            // 
            // grbUbicacionDetallada
            // 
            this.grbUbicacionDetallada.BackColor = System.Drawing.Color.Transparent;
            this.grbUbicacionDetallada.Controls.Add(this.txtDireccion01);
            this.grbUbicacionDetallada.Controls.Add(this.lblDireccion02);
            this.grbUbicacionDetallada.Controls.Add(this.lblDireccion01);
            this.grbUbicacionDetallada.Controls.Add(this.txtDireccion02);
            this.grbUbicacionDetallada.Controls.Add(this.txtNomZona);
            this.grbUbicacionDetallada.Controls.Add(this.lblNomZona);
            this.grbUbicacionDetallada.Controls.Add(this.txtNomVia);
            this.grbUbicacionDetallada.Controls.Add(this.lblZona);
            this.grbUbicacionDetallada.Controls.Add(this.cboZona);
            this.grbUbicacionDetallada.Controls.Add(this.txtReferencia);
            this.grbUbicacionDetallada.Controls.Add(this.lblNomVia);
            this.grbUbicacionDetallada.Controls.Add(this.lblReferencia);
            this.grbUbicacionDetallada.Controls.Add(this.txtNumVia);
            this.grbUbicacionDetallada.Controls.Add(this.lblVia);
            this.grbUbicacionDetallada.Controls.Add(this.cboVia);
            this.grbUbicacionDetallada.Controls.Add(this.lblNumVia);
            this.grbUbicacionDetallada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbUbicacionDetallada.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbUbicacionDetallada.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbUbicacionDetallada.Location = new System.Drawing.Point(5, 106);
            this.grbUbicacionDetallada.Name = "grbUbicacionDetallada";
            this.grbUbicacionDetallada.Size = new System.Drawing.Size(555, 210);
            this.grbUbicacionDetallada.TabIndex = 1;
            this.grbUbicacionDetallada.TabStop = false;
            this.grbUbicacionDetallada.Text = "Ubicación detallada";
            // 
            // txtDireccion01
            // 
            this.txtDireccion01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtDireccion01.CustomButton.Image = null;
            this.txtDireccion01.CustomButton.Location = new System.Drawing.Point(443, 1);
            this.txtDireccion01.CustomButton.Name = "";
            this.txtDireccion01.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDireccion01.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDireccion01.CustomButton.TabIndex = 1;
            this.txtDireccion01.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDireccion01.CustomButton.UseSelectable = true;
            this.txtDireccion01.CustomButton.Visible = false;
            this.txtDireccion01.Lines = new string[0];
            this.txtDireccion01.Location = new System.Drawing.Point(82, 105);
            this.txtDireccion01.MaxLength = 32767;
            this.txtDireccion01.Name = "txtDireccion01";
            this.txtDireccion01.PasswordChar = '\0';
            this.txtDireccion01.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDireccion01.SelectedText = "";
            this.txtDireccion01.SelectionLength = 0;
            this.txtDireccion01.SelectionStart = 0;
            this.txtDireccion01.ShortcutsEnabled = true;
            this.txtDireccion01.Size = new System.Drawing.Size(465, 23);
            this.txtDireccion01.TabIndex = 5;
            this.txtDireccion01.UseCustomBackColor = true;
            this.txtDireccion01.UseSelectable = true;
            this.txtDireccion01.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDireccion01.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccion01.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblDireccion02
            // 
            this.lblDireccion02.AutoSize = true;
            this.lblDireccion02.ForeColor = System.Drawing.Color.Navy;
            this.lblDireccion02.Location = new System.Drawing.Point(6, 142);
            this.lblDireccion02.Name = "lblDireccion02";
            this.lblDireccion02.Size = new System.Drawing.Size(48, 19);
            this.lblDireccion02.TabIndex = 54;
            this.lblDireccion02.Text = "Dir. 02:";
            this.lblDireccion02.UseCustomForeColor = true;
            // 
            // lblDireccion01
            // 
            this.lblDireccion01.AutoSize = true;
            this.lblDireccion01.ForeColor = System.Drawing.Color.Navy;
            this.lblDireccion01.Location = new System.Drawing.Point(6, 107);
            this.lblDireccion01.Name = "lblDireccion01";
            this.lblDireccion01.Size = new System.Drawing.Size(46, 19);
            this.lblDireccion01.TabIndex = 52;
            this.lblDireccion01.Text = "Dir. 01:";
            this.lblDireccion01.UseCustomForeColor = true;
            // 
            // txtDireccion02
            // 
            this.txtDireccion02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtDireccion02.CustomButton.Image = null;
            this.txtDireccion02.CustomButton.Location = new System.Drawing.Point(443, 1);
            this.txtDireccion02.CustomButton.Name = "";
            this.txtDireccion02.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDireccion02.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDireccion02.CustomButton.TabIndex = 1;
            this.txtDireccion02.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDireccion02.CustomButton.UseSelectable = true;
            this.txtDireccion02.CustomButton.Visible = false;
            this.txtDireccion02.Lines = new string[0];
            this.txtDireccion02.Location = new System.Drawing.Point(82, 140);
            this.txtDireccion02.MaxLength = 32767;
            this.txtDireccion02.Name = "txtDireccion02";
            this.txtDireccion02.PasswordChar = '\0';
            this.txtDireccion02.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDireccion02.SelectedText = "";
            this.txtDireccion02.SelectionLength = 0;
            this.txtDireccion02.SelectionStart = 0;
            this.txtDireccion02.ShortcutsEnabled = true;
            this.txtDireccion02.Size = new System.Drawing.Size(465, 23);
            this.txtDireccion02.TabIndex = 6;
            this.txtDireccion02.UseCustomBackColor = true;
            this.txtDireccion02.UseSelectable = true;
            this.txtDireccion02.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDireccion02.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccion02.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // txtNomZona
            // 
            this.txtNomZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNomZona.CustomButton.Image = null;
            this.txtNomZona.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtNomZona.CustomButton.Name = "";
            this.txtNomZona.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomZona.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomZona.CustomButton.TabIndex = 1;
            this.txtNomZona.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomZona.CustomButton.UseSelectable = true;
            this.txtNomZona.CustomButton.Visible = false;
            this.txtNomZona.Lines = new string[0];
            this.txtNomZona.Location = new System.Drawing.Point(363, 33);
            this.txtNomZona.MaxLength = 32767;
            this.txtNomZona.Name = "txtNomZona";
            this.txtNomZona.PasswordChar = '\0';
            this.txtNomZona.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomZona.SelectedText = "";
            this.txtNomZona.SelectionLength = 0;
            this.txtNomZona.SelectionStart = 0;
            this.txtNomZona.ShortcutsEnabled = true;
            this.txtNomZona.Size = new System.Drawing.Size(184, 23);
            this.txtNomZona.TabIndex = 1;
            this.txtNomZona.UseCustomBackColor = true;
            this.txtNomZona.UseSelectable = true;
            this.txtNomZona.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomZona.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomZona.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblNomZona
            // 
            this.lblNomZona.AutoSize = true;
            this.lblNomZona.ForeColor = System.Drawing.Color.Navy;
            this.lblNomZona.Location = new System.Drawing.Point(278, 35);
            this.lblNomZona.Name = "lblNomZona";
            this.lblNomZona.Size = new System.Drawing.Size(79, 19);
            this.lblNomZona.TabIndex = 42;
            this.lblNomZona.Text = "Nom. Zona:";
            this.lblNomZona.UseCustomForeColor = true;
            // 
            // txtNomVia
            // 
            this.txtNomVia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNomVia.CustomButton.Image = null;
            this.txtNomVia.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtNomVia.CustomButton.Name = "";
            this.txtNomVia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomVia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomVia.CustomButton.TabIndex = 1;
            this.txtNomVia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomVia.CustomButton.UseSelectable = true;
            this.txtNomVia.CustomButton.Visible = false;
            this.txtNomVia.Lines = new string[0];
            this.txtNomVia.Location = new System.Drawing.Point(363, 69);
            this.txtNomVia.MaxLength = 32767;
            this.txtNomVia.Name = "txtNomVia";
            this.txtNomVia.PasswordChar = '\0';
            this.txtNomVia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomVia.SelectedText = "";
            this.txtNomVia.SelectionLength = 0;
            this.txtNomVia.SelectionStart = 0;
            this.txtNomVia.ShortcutsEnabled = true;
            this.txtNomVia.Size = new System.Drawing.Size(125, 23);
            this.txtNomVia.TabIndex = 3;
            this.txtNomVia.UseCustomBackColor = true;
            this.txtNomVia.UseSelectable = true;
            this.txtNomVia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomVia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNomVia.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblZona
            // 
            this.lblZona.AutoSize = true;
            this.lblZona.ForeColor = System.Drawing.Color.Navy;
            this.lblZona.Location = new System.Drawing.Point(5, 33);
            this.lblZona.Name = "lblZona";
            this.lblZona.Size = new System.Drawing.Size(72, 19);
            this.lblZona.TabIndex = 40;
            this.lblZona.Text = "Tipo Zona:";
            this.lblZona.UseCustomForeColor = true;
            // 
            // cboZona
            // 
            this.cboZona.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboZona.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboZona.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboZona.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboZona.FormattingEnabled = true;
            this.cboZona.Location = new System.Drawing.Point(82, 33);
            this.cboZona.Name = "cboZona";
            this.cboZona.Size = new System.Drawing.Size(163, 23);
            this.cboZona.TabIndex = 0;
            this.cboZona.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // txtReferencia
            // 
            this.txtReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtReferencia.CustomButton.Image = null;
            this.txtReferencia.CustomButton.Location = new System.Drawing.Point(443, 1);
            this.txtReferencia.CustomButton.Name = "";
            this.txtReferencia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtReferencia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReferencia.CustomButton.TabIndex = 1;
            this.txtReferencia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReferencia.CustomButton.UseSelectable = true;
            this.txtReferencia.CustomButton.Visible = false;
            this.txtReferencia.Lines = new string[0];
            this.txtReferencia.Location = new System.Drawing.Point(82, 175);
            this.txtReferencia.MaxLength = 32767;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.PasswordChar = '\0';
            this.txtReferencia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReferencia.SelectedText = "";
            this.txtReferencia.SelectionLength = 0;
            this.txtReferencia.SelectionStart = 0;
            this.txtReferencia.ShortcutsEnabled = true;
            this.txtReferencia.Size = new System.Drawing.Size(465, 23);
            this.txtReferencia.TabIndex = 7;
            this.txtReferencia.UseCustomBackColor = true;
            this.txtReferencia.UseSelectable = true;
            this.txtReferencia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReferencia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtReferencia.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblNomVia
            // 
            this.lblNomVia.AutoSize = true;
            this.lblNomVia.ForeColor = System.Drawing.Color.Navy;
            this.lblNomVia.Location = new System.Drawing.Point(278, 71);
            this.lblNomVia.Name = "lblNomVia";
            this.lblNomVia.Size = new System.Drawing.Size(67, 19);
            this.lblNomVia.TabIndex = 46;
            this.lblNomVia.Text = "Nom. Vía:";
            this.lblNomVia.UseCustomForeColor = true;
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.ForeColor = System.Drawing.Color.Navy;
            this.lblReferencia.Location = new System.Drawing.Point(6, 177);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(73, 19);
            this.lblReferencia.TabIndex = 50;
            this.lblReferencia.Text = "Referencia:";
            this.lblReferencia.UseCustomForeColor = true;
            // 
            // txtNumVia
            // 
            this.txtNumVia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNumVia.CustomButton.Image = null;
            this.txtNumVia.CustomButton.Location = new System.Drawing.Point(11, 1);
            this.txtNumVia.CustomButton.Name = "";
            this.txtNumVia.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNumVia.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNumVia.CustomButton.TabIndex = 1;
            this.txtNumVia.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNumVia.CustomButton.UseSelectable = true;
            this.txtNumVia.CustomButton.Visible = false;
            this.txtNumVia.Lines = new string[0];
            this.txtNumVia.Location = new System.Drawing.Point(514, 69);
            this.txtNumVia.MaxLength = 32767;
            this.txtNumVia.Name = "txtNumVia";
            this.txtNumVia.PasswordChar = '\0';
            this.txtNumVia.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNumVia.SelectedText = "";
            this.txtNumVia.SelectionLength = 0;
            this.txtNumVia.SelectionStart = 0;
            this.txtNumVia.ShortcutsEnabled = true;
            this.txtNumVia.Size = new System.Drawing.Size(33, 23);
            this.txtNumVia.TabIndex = 4;
            this.txtNumVia.UseCustomBackColor = true;
            this.txtNumVia.UseSelectable = true;
            this.txtNumVia.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNumVia.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNumVia.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblVia
            // 
            this.lblVia.AutoSize = true;
            this.lblVia.ForeColor = System.Drawing.Color.Navy;
            this.lblVia.Location = new System.Drawing.Point(6, 71);
            this.lblVia.Name = "lblVia";
            this.lblVia.Size = new System.Drawing.Size(60, 19);
            this.lblVia.TabIndex = 44;
            this.lblVia.Text = "Tipo Vía:";
            this.lblVia.UseCustomForeColor = true;
            // 
            // cboVia
            // 
            this.cboVia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboVia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboVia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboVia.FormattingEnabled = true;
            this.cboVia.Location = new System.Drawing.Point(82, 69);
            this.cboVia.Name = "cboVia";
            this.cboVia.Size = new System.Drawing.Size(163, 23);
            this.cboVia.TabIndex = 2;
            this.cboVia.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblNumVia
            // 
            this.lblNumVia.AutoSize = true;
            this.lblNumVia.ForeColor = System.Drawing.Color.Navy;
            this.lblNumVia.Location = new System.Drawing.Point(489, 71);
            this.lblNumVia.Name = "lblNumVia";
            this.lblNumVia.Size = new System.Drawing.Size(24, 19);
            this.lblNumVia.TabIndex = 48;
            this.lblNumVia.Text = "N°";
            this.lblNumVia.UseCustomForeColor = true;
            // 
            // gbrUbigeo
            // 
            this.gbrUbigeo.BackColor = System.Drawing.Color.Transparent;
            this.gbrUbigeo.Controls.Add(this.lblDepartamento);
            this.gbrUbigeo.Controls.Add(this.cboDepartamento);
            this.gbrUbigeo.Controls.Add(this.cboDistrito);
            this.gbrUbigeo.Controls.Add(this.lblDistrito);
            this.gbrUbigeo.Controls.Add(this.lblNacionalidad);
            this.gbrUbigeo.Controls.Add(this.lblProvincia);
            this.gbrUbigeo.Controls.Add(this.cboNacionalidad);
            this.gbrUbigeo.Controls.Add(this.cboProvincia);
            this.gbrUbigeo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbrUbigeo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbrUbigeo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbrUbigeo.Location = new System.Drawing.Point(4, 7);
            this.gbrUbigeo.Name = "gbrUbigeo";
            this.gbrUbigeo.Size = new System.Drawing.Size(555, 93);
            this.gbrUbigeo.TabIndex = 0;
            this.gbrUbigeo.TabStop = false;
            this.gbrUbigeo.Text = "Ubicación general";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.ForeColor = System.Drawing.Color.Navy;
            this.lblDepartamento.Location = new System.Drawing.Point(6, 26);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(53, 19);
            this.lblDepartamento.TabIndex = 32;
            this.lblDepartamento.Text = "Región:";
            this.lblDepartamento.UseCustomForeColor = true;
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDepartamento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Location = new System.Drawing.Point(62, 24);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(184, 23);
            this.cboDepartamento.TabIndex = 0;
            this.cboDepartamento.SelectedIndexChanged += new System.EventHandler(this.cboDepartamento_SelectedIndexChanged);
            // 
            // cboDistrito
            // 
            this.cboDistrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboDistrito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDistrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDistrito.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDistrito.FormattingEnabled = true;
            this.cboDistrito.Location = new System.Drawing.Point(62, 59);
            this.cboDistrito.Name = "cboDistrito";
            this.cboDistrito.Size = new System.Drawing.Size(184, 23);
            this.cboDistrito.TabIndex = 2;
            this.cboDistrito.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblDistrito
            // 
            this.lblDistrito.AutoSize = true;
            this.lblDistrito.ForeColor = System.Drawing.Color.Navy;
            this.lblDistrito.Location = new System.Drawing.Point(6, 61);
            this.lblDistrito.Name = "lblDistrito";
            this.lblDistrito.Size = new System.Drawing.Size(53, 19);
            this.lblDistrito.TabIndex = 36;
            this.lblDistrito.Text = "Distrito:";
            this.lblDistrito.UseCustomForeColor = true;
            // 
            // lblNacionalidad
            // 
            this.lblNacionalidad.AutoSize = true;
            this.lblNacionalidad.ForeColor = System.Drawing.Color.Navy;
            this.lblNacionalidad.Location = new System.Drawing.Point(272, 61);
            this.lblNacionalidad.Name = "lblNacionalidad";
            this.lblNacionalidad.Size = new System.Drawing.Size(89, 19);
            this.lblNacionalidad.TabIndex = 38;
            this.lblNacionalidad.Text = "Nacionalidad:";
            this.lblNacionalidad.UseCustomForeColor = true;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.ForeColor = System.Drawing.Color.Navy;
            this.lblProvincia.Location = new System.Drawing.Point(272, 26);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(65, 19);
            this.lblProvincia.TabIndex = 34;
            this.lblProvincia.Text = "Provincia:";
            this.lblProvincia.UseCustomForeColor = true;
            // 
            // cboNacionalidad
            // 
            this.cboNacionalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNacionalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboNacionalidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNacionalidad.FormattingEnabled = true;
            this.cboNacionalidad.Location = new System.Drawing.Point(364, 59);
            this.cboNacionalidad.Name = "cboNacionalidad";
            this.cboNacionalidad.Size = new System.Drawing.Size(184, 23);
            this.cboNacionalidad.TabIndex = 3;
            this.cboNacionalidad.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // cboProvincia
            // 
            this.cboProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProvincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboProvincia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProvincia.FormattingEnabled = true;
            this.cboProvincia.Location = new System.Drawing.Point(364, 24);
            this.cboProvincia.Name = "cboProvincia";
            this.cboProvincia.Size = new System.Drawing.Size(184, 23);
            this.cboProvincia.TabIndex = 1;
            this.cboProvincia.SelectedIndexChanged += new System.EventHandler(this.cboProvincia_SelectedIndexChanged);
            // 
            // tabPagEducacion
            // 
            this.tabPagEducacion.Controls.Add(this.grbSkillsEducativas);
            this.tabPagEducacion.HorizontalScrollbarBarColor = true;
            this.tabPagEducacion.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagEducacion.HorizontalScrollbarSize = 10;
            this.tabPagEducacion.Location = new System.Drawing.Point(4, 38);
            this.tabPagEducacion.Name = "tabPagEducacion";
            this.tabPagEducacion.Size = new System.Drawing.Size(578, 422);
            this.tabPagEducacion.TabIndex = 6;
            this.tabPagEducacion.Text = "Educación";
            this.tabPagEducacion.VerticalScrollbarBarColor = true;
            this.tabPagEducacion.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagEducacion.VerticalScrollbarSize = 10;
            // 
            // grbSkillsEducativas
            // 
            this.grbSkillsEducativas.BackColor = System.Drawing.Color.Transparent;
            this.grbSkillsEducativas.Controls.Add(this.cboEspcMedica);
            this.grbSkillsEducativas.Controls.Add(this.lblEspcMedica);
            this.grbSkillsEducativas.Controls.Add(this.lblSituacionEdu);
            this.grbSkillsEducativas.Controls.Add(this.cboTipoEspc);
            this.grbSkillsEducativas.Controls.Add(this.cboSituacionEdu);
            this.grbSkillsEducativas.Controls.Add(this.lblTipoEspc);
            this.grbSkillsEducativas.Controls.Add(this.lblModalidadFormativa);
            this.grbSkillsEducativas.Controls.Add(this.cboModalidadFormativa);
            this.grbSkillsEducativas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbSkillsEducativas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSkillsEducativas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbSkillsEducativas.Location = new System.Drawing.Point(4, 8);
            this.grbSkillsEducativas.Name = "grbSkillsEducativas";
            this.grbSkillsEducativas.Size = new System.Drawing.Size(571, 91);
            this.grbSkillsEducativas.TabIndex = 0;
            this.grbSkillsEducativas.TabStop = false;
            this.grbSkillsEducativas.Text = "Formación y Educación";
            // 
            // cboEspcMedica
            // 
            this.cboEspcMedica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboEspcMedica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspcMedica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEspcMedica.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEspcMedica.FormattingEnabled = true;
            this.cboEspcMedica.Location = new System.Drawing.Point(380, 56);
            this.cboEspcMedica.Name = "cboEspcMedica";
            this.cboEspcMedica.Size = new System.Drawing.Size(175, 23);
            this.cboEspcMedica.TabIndex = 3;
            this.cboEspcMedica.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblEspcMedica
            // 
            this.lblEspcMedica.AutoSize = true;
            this.lblEspcMedica.ForeColor = System.Drawing.Color.Navy;
            this.lblEspcMedica.Location = new System.Drawing.Point(290, 58);
            this.lblEspcMedica.Name = "lblEspcMedica";
            this.lblEspcMedica.Size = new System.Drawing.Size(88, 19);
            this.lblEspcMedica.TabIndex = 6;
            this.lblEspcMedica.Text = "Espc. Médica:";
            this.lblEspcMedica.UseCustomForeColor = true;
            // 
            // lblSituacionEdu
            // 
            this.lblSituacionEdu.AutoSize = true;
            this.lblSituacionEdu.ForeColor = System.Drawing.Color.Navy;
            this.lblSituacionEdu.Location = new System.Drawing.Point(12, 26);
            this.lblSituacionEdu.Name = "lblSituacionEdu";
            this.lblSituacionEdu.Size = new System.Drawing.Size(75, 19);
            this.lblSituacionEdu.TabIndex = 0;
            this.lblSituacionEdu.Text = "Situac. Edu:";
            this.lblSituacionEdu.UseCustomForeColor = true;
            // 
            // cboTipoEspc
            // 
            this.cboTipoEspc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboTipoEspc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEspc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTipoEspc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoEspc.FormattingEnabled = true;
            this.cboTipoEspc.Location = new System.Drawing.Point(90, 56);
            this.cboTipoEspc.Name = "cboTipoEspc";
            this.cboTipoEspc.Size = new System.Drawing.Size(177, 23);
            this.cboTipoEspc.TabIndex = 2;
            this.cboTipoEspc.SelectedIndexChanged += new System.EventHandler(this.cboTipoEspc_SelectedIndexChanged);
            // 
            // cboSituacionEdu
            // 
            this.cboSituacionEdu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboSituacionEdu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSituacionEdu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSituacionEdu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSituacionEdu.FormattingEnabled = true;
            this.cboSituacionEdu.Location = new System.Drawing.Point(90, 24);
            this.cboSituacionEdu.Name = "cboSituacionEdu";
            this.cboSituacionEdu.Size = new System.Drawing.Size(177, 23);
            this.cboSituacionEdu.TabIndex = 0;
            this.cboSituacionEdu.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblTipoEspc
            // 
            this.lblTipoEspc.AutoSize = true;
            this.lblTipoEspc.ForeColor = System.Drawing.Color.Navy;
            this.lblTipoEspc.Location = new System.Drawing.Point(12, 58);
            this.lblTipoEspc.Name = "lblTipoEspc";
            this.lblTipoEspc.Size = new System.Drawing.Size(68, 19);
            this.lblTipoEspc.TabIndex = 4;
            this.lblTipoEspc.Text = "Tipo Espc:";
            this.lblTipoEspc.UseCustomForeColor = true;
            // 
            // lblModalidadFormativa
            // 
            this.lblModalidadFormativa.AutoSize = true;
            this.lblModalidadFormativa.BackColor = System.Drawing.Color.Transparent;
            this.lblModalidadFormativa.ForeColor = System.Drawing.Color.Navy;
            this.lblModalidadFormativa.Location = new System.Drawing.Point(290, 26);
            this.lblModalidadFormativa.Name = "lblModalidadFormativa";
            this.lblModalidadFormativa.Size = new System.Drawing.Size(90, 19);
            this.lblModalidadFormativa.TabIndex = 2;
            this.lblModalidadFormativa.Text = "M. Formativa:";
            this.lblModalidadFormativa.UseCustomBackColor = true;
            this.lblModalidadFormativa.UseCustomForeColor = true;
            // 
            // cboModalidadFormativa
            // 
            this.cboModalidadFormativa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboModalidadFormativa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboModalidadFormativa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboModalidadFormativa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboModalidadFormativa.FormattingEnabled = true;
            this.cboModalidadFormativa.Location = new System.Drawing.Point(380, 24);
            this.cboModalidadFormativa.Name = "cboModalidadFormativa";
            this.cboModalidadFormativa.Size = new System.Drawing.Size(175, 23);
            this.cboModalidadFormativa.TabIndex = 1;
            this.cboModalidadFormativa.SelectedIndexChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // tabPagContacto
            // 
            this.tabPagContacto.Controls.Add(this.grbEmailYWeb);
            this.tabPagContacto.Controls.Add(this.grbNumerosContacto);
            this.tabPagContacto.HorizontalScrollbarBarColor = true;
            this.tabPagContacto.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagContacto.HorizontalScrollbarSize = 10;
            this.tabPagContacto.Location = new System.Drawing.Point(4, 38);
            this.tabPagContacto.Name = "tabPagContacto";
            this.tabPagContacto.Size = new System.Drawing.Size(578, 422);
            this.tabPagContacto.TabIndex = 1;
            this.tabPagContacto.Text = "Contacto";
            this.tabPagContacto.VerticalScrollbarBarColor = true;
            this.tabPagContacto.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagContacto.VerticalScrollbarSize = 10;
            // 
            // grbEmailYWeb
            // 
            this.grbEmailYWeb.BackColor = System.Drawing.Color.Transparent;
            this.grbEmailYWeb.Controls.Add(this.txtEmail02);
            this.grbEmailYWeb.Controls.Add(this.lblEmail02);
            this.grbEmailYWeb.Controls.Add(this.txtPagWeb);
            this.grbEmailYWeb.Controls.Add(this.lblPagWeb);
            this.grbEmailYWeb.Controls.Add(this.txtEmail01);
            this.grbEmailYWeb.Controls.Add(this.lblEmail01);
            this.grbEmailYWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbEmailYWeb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEmailYWeb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbEmailYWeb.Location = new System.Drawing.Point(12, 7);
            this.grbEmailYWeb.Name = "grbEmailYWeb";
            this.grbEmailYWeb.Size = new System.Drawing.Size(555, 130);
            this.grbEmailYWeb.TabIndex = 0;
            this.grbEmailYWeb.TabStop = false;
            this.grbEmailYWeb.Text = "Email\'s y Web";
            // 
            // txtEmail02
            // 
            this.txtEmail02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtEmail02.CustomButton.Image = null;
            this.txtEmail02.CustomButton.Location = new System.Drawing.Point(424, 1);
            this.txtEmail02.CustomButton.Name = "";
            this.txtEmail02.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail02.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail02.CustomButton.TabIndex = 1;
            this.txtEmail02.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail02.CustomButton.UseSelectable = true;
            this.txtEmail02.CustomButton.Visible = false;
            this.txtEmail02.Lines = new string[0];
            this.txtEmail02.Location = new System.Drawing.Point(91, 60);
            this.txtEmail02.MaxLength = 32767;
            this.txtEmail02.Name = "txtEmail02";
            this.txtEmail02.PasswordChar = '\0';
            this.txtEmail02.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail02.SelectedText = "";
            this.txtEmail02.SelectionLength = 0;
            this.txtEmail02.SelectionStart = 0;
            this.txtEmail02.ShortcutsEnabled = true;
            this.txtEmail02.Size = new System.Drawing.Size(446, 23);
            this.txtEmail02.TabIndex = 1;
            this.txtEmail02.UseCustomBackColor = true;
            this.txtEmail02.UseSelectable = true;
            this.txtEmail02.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail02.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail02.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblEmail02
            // 
            this.lblEmail02.AutoSize = true;
            this.lblEmail02.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail02.ForeColor = System.Drawing.Color.Navy;
            this.lblEmail02.Location = new System.Drawing.Point(6, 62);
            this.lblEmail02.Name = "lblEmail02";
            this.lblEmail02.Size = new System.Drawing.Size(62, 19);
            this.lblEmail02.TabIndex = 2;
            this.lblEmail02.Text = "Email 02:";
            this.lblEmail02.UseCustomForeColor = true;
            // 
            // txtPagWeb
            // 
            this.txtPagWeb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPagWeb.CustomButton.Image = null;
            this.txtPagWeb.CustomButton.Location = new System.Drawing.Point(424, 1);
            this.txtPagWeb.CustomButton.Name = "";
            this.txtPagWeb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPagWeb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPagWeb.CustomButton.TabIndex = 1;
            this.txtPagWeb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPagWeb.CustomButton.UseSelectable = true;
            this.txtPagWeb.CustomButton.Visible = false;
            this.txtPagWeb.Lines = new string[0];
            this.txtPagWeb.Location = new System.Drawing.Point(91, 94);
            this.txtPagWeb.MaxLength = 32767;
            this.txtPagWeb.Name = "txtPagWeb";
            this.txtPagWeb.PasswordChar = '\0';
            this.txtPagWeb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPagWeb.SelectedText = "";
            this.txtPagWeb.SelectionLength = 0;
            this.txtPagWeb.SelectionStart = 0;
            this.txtPagWeb.ShortcutsEnabled = true;
            this.txtPagWeb.Size = new System.Drawing.Size(446, 23);
            this.txtPagWeb.TabIndex = 2;
            this.txtPagWeb.UseCustomBackColor = true;
            this.txtPagWeb.UseSelectable = true;
            this.txtPagWeb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPagWeb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPagWeb.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblPagWeb
            // 
            this.lblPagWeb.AutoSize = true;
            this.lblPagWeb.BackColor = System.Drawing.Color.Transparent;
            this.lblPagWeb.ForeColor = System.Drawing.Color.Navy;
            this.lblPagWeb.Location = new System.Drawing.Point(6, 96);
            this.lblPagWeb.Name = "lblPagWeb";
            this.lblPagWeb.Size = new System.Drawing.Size(79, 19);
            this.lblPagWeb.TabIndex = 4;
            this.lblPagWeb.Text = "Página web:";
            this.lblPagWeb.UseCustomForeColor = true;
            // 
            // txtEmail01
            // 
            this.txtEmail01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtEmail01.CustomButton.Image = null;
            this.txtEmail01.CustomButton.Location = new System.Drawing.Point(424, 1);
            this.txtEmail01.CustomButton.Name = "";
            this.txtEmail01.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail01.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail01.CustomButton.TabIndex = 1;
            this.txtEmail01.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail01.CustomButton.UseSelectable = true;
            this.txtEmail01.CustomButton.Visible = false;
            this.txtEmail01.Lines = new string[0];
            this.txtEmail01.Location = new System.Drawing.Point(91, 26);
            this.txtEmail01.MaxLength = 32767;
            this.txtEmail01.Name = "txtEmail01";
            this.txtEmail01.PasswordChar = '\0';
            this.txtEmail01.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail01.SelectedText = "";
            this.txtEmail01.SelectionLength = 0;
            this.txtEmail01.SelectionStart = 0;
            this.txtEmail01.ShortcutsEnabled = true;
            this.txtEmail01.Size = new System.Drawing.Size(446, 23);
            this.txtEmail01.TabIndex = 0;
            this.txtEmail01.UseCustomBackColor = true;
            this.txtEmail01.UseSelectable = true;
            this.txtEmail01.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail01.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail01.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblEmail01
            // 
            this.lblEmail01.AutoSize = true;
            this.lblEmail01.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail01.ForeColor = System.Drawing.Color.Navy;
            this.lblEmail01.Location = new System.Drawing.Point(6, 28);
            this.lblEmail01.Name = "lblEmail01";
            this.lblEmail01.Size = new System.Drawing.Size(60, 19);
            this.lblEmail01.TabIndex = 0;
            this.lblEmail01.Text = "Email 01:";
            this.lblEmail01.UseCustomForeColor = true;
            // 
            // grbNumerosContacto
            // 
            this.grbNumerosContacto.BackColor = System.Drawing.Color.Transparent;
            this.grbNumerosContacto.Controls.Add(this.txtTelfFijo02);
            this.grbNumerosContacto.Controls.Add(this.txtCelular02);
            this.grbNumerosContacto.Controls.Add(this.txtTelfFijo01);
            this.grbNumerosContacto.Controls.Add(this.lblCelular02);
            this.grbNumerosContacto.Controls.Add(this.lblTelFijo02);
            this.grbNumerosContacto.Controls.Add(this.txtCelular03);
            this.grbNumerosContacto.Controls.Add(this.lblTelFijo01);
            this.grbNumerosContacto.Controls.Add(this.lblCelular03);
            this.grbNumerosContacto.Controls.Add(this.txtTelfFijo03);
            this.grbNumerosContacto.Controls.Add(this.lblTelFijo03);
            this.grbNumerosContacto.Controls.Add(this.txtCelular01);
            this.grbNumerosContacto.Controls.Add(this.lblCelular01);
            this.grbNumerosContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbNumerosContacto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNumerosContacto.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbNumerosContacto.Location = new System.Drawing.Point(12, 143);
            this.grbNumerosContacto.Name = "grbNumerosContacto";
            this.grbNumerosContacto.Size = new System.Drawing.Size(555, 129);
            this.grbNumerosContacto.TabIndex = 1;
            this.grbNumerosContacto.TabStop = false;
            this.grbNumerosContacto.Text = "Celulares y teléfonos";
            // 
            // txtTelfFijo02
            // 
            this.txtTelfFijo02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtTelfFijo02.CustomButton.Image = null;
            this.txtTelfFijo02.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtTelfFijo02.CustomButton.Name = "";
            this.txtTelfFijo02.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelfFijo02.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelfFijo02.CustomButton.TabIndex = 1;
            this.txtTelfFijo02.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelfFijo02.CustomButton.UseSelectable = true;
            this.txtTelfFijo02.CustomButton.Visible = false;
            this.txtTelfFijo02.Lines = new string[0];
            this.txtTelfFijo02.Location = new System.Drawing.Point(381, 60);
            this.txtTelfFijo02.MaxLength = 32767;
            this.txtTelfFijo02.Name = "txtTelfFijo02";
            this.txtTelfFijo02.PasswordChar = '\0';
            this.txtTelfFijo02.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelfFijo02.SelectedText = "";
            this.txtTelfFijo02.SelectionLength = 0;
            this.txtTelfFijo02.SelectionStart = 0;
            this.txtTelfFijo02.ShortcutsEnabled = true;
            this.txtTelfFijo02.Size = new System.Drawing.Size(156, 23);
            this.txtTelfFijo02.TabIndex = 4;
            this.txtTelfFijo02.UseCustomBackColor = true;
            this.txtTelfFijo02.UseSelectable = true;
            this.txtTelfFijo02.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelfFijo02.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelfFijo02.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // txtCelular02
            // 
            this.txtCelular02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtCelular02.CustomButton.Image = null;
            this.txtCelular02.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtCelular02.CustomButton.Name = "";
            this.txtCelular02.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCelular02.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCelular02.CustomButton.TabIndex = 1;
            this.txtCelular02.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCelular02.CustomButton.UseSelectable = true;
            this.txtCelular02.CustomButton.Visible = false;
            this.txtCelular02.Lines = new string[0];
            this.txtCelular02.Location = new System.Drawing.Point(91, 60);
            this.txtCelular02.MaxLength = 32767;
            this.txtCelular02.Name = "txtCelular02";
            this.txtCelular02.PasswordChar = '\0';
            this.txtCelular02.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCelular02.SelectedText = "";
            this.txtCelular02.SelectionLength = 0;
            this.txtCelular02.SelectionStart = 0;
            this.txtCelular02.ShortcutsEnabled = true;
            this.txtCelular02.Size = new System.Drawing.Size(156, 23);
            this.txtCelular02.TabIndex = 1;
            this.txtCelular02.UseCustomBackColor = true;
            this.txtCelular02.UseSelectable = true;
            this.txtCelular02.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCelular02.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCelular02.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // txtTelfFijo01
            // 
            this.txtTelfFijo01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtTelfFijo01.CustomButton.Image = null;
            this.txtTelfFijo01.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtTelfFijo01.CustomButton.Name = "";
            this.txtTelfFijo01.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelfFijo01.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelfFijo01.CustomButton.TabIndex = 1;
            this.txtTelfFijo01.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelfFijo01.CustomButton.UseSelectable = true;
            this.txtTelfFijo01.CustomButton.Visible = false;
            this.txtTelfFijo01.Lines = new string[0];
            this.txtTelfFijo01.Location = new System.Drawing.Point(381, 26);
            this.txtTelfFijo01.MaxLength = 32767;
            this.txtTelfFijo01.Name = "txtTelfFijo01";
            this.txtTelfFijo01.PasswordChar = '\0';
            this.txtTelfFijo01.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelfFijo01.SelectedText = "";
            this.txtTelfFijo01.SelectionLength = 0;
            this.txtTelfFijo01.SelectionStart = 0;
            this.txtTelfFijo01.ShortcutsEnabled = true;
            this.txtTelfFijo01.Size = new System.Drawing.Size(156, 23);
            this.txtTelfFijo01.TabIndex = 3;
            this.txtTelfFijo01.UseCustomBackColor = true;
            this.txtTelfFijo01.UseSelectable = true;
            this.txtTelfFijo01.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelfFijo01.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelfFijo01.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblCelular02
            // 
            this.lblCelular02.AutoSize = true;
            this.lblCelular02.BackColor = System.Drawing.Color.Transparent;
            this.lblCelular02.ForeColor = System.Drawing.Color.Navy;
            this.lblCelular02.Location = new System.Drawing.Point(6, 62);
            this.lblCelular02.Name = "lblCelular02";
            this.lblCelular02.Size = new System.Drawing.Size(71, 19);
            this.lblCelular02.TabIndex = 2;
            this.lblCelular02.Text = "Celular 02:";
            this.lblCelular02.UseCustomForeColor = true;
            // 
            // lblTelFijo02
            // 
            this.lblTelFijo02.AutoSize = true;
            this.lblTelFijo02.BackColor = System.Drawing.Color.Transparent;
            this.lblTelFijo02.ForeColor = System.Drawing.Color.Navy;
            this.lblTelFijo02.Location = new System.Drawing.Point(294, 62);
            this.lblTelFijo02.Name = "lblTelFijo02";
            this.lblTelFijo02.Size = new System.Drawing.Size(76, 19);
            this.lblTelFijo02.TabIndex = 2;
            this.lblTelFijo02.Text = "Telf. Fijo 02:";
            this.lblTelFijo02.UseCustomForeColor = true;
            // 
            // txtCelular03
            // 
            this.txtCelular03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtCelular03.CustomButton.Image = null;
            this.txtCelular03.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtCelular03.CustomButton.Name = "";
            this.txtCelular03.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCelular03.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCelular03.CustomButton.TabIndex = 1;
            this.txtCelular03.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCelular03.CustomButton.UseSelectable = true;
            this.txtCelular03.CustomButton.Visible = false;
            this.txtCelular03.Lines = new string[0];
            this.txtCelular03.Location = new System.Drawing.Point(91, 93);
            this.txtCelular03.MaxLength = 32767;
            this.txtCelular03.Name = "txtCelular03";
            this.txtCelular03.PasswordChar = '\0';
            this.txtCelular03.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCelular03.SelectedText = "";
            this.txtCelular03.SelectionLength = 0;
            this.txtCelular03.SelectionStart = 0;
            this.txtCelular03.ShortcutsEnabled = true;
            this.txtCelular03.Size = new System.Drawing.Size(156, 23);
            this.txtCelular03.TabIndex = 2;
            this.txtCelular03.UseCustomBackColor = true;
            this.txtCelular03.UseSelectable = true;
            this.txtCelular03.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCelular03.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCelular03.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblTelFijo01
            // 
            this.lblTelFijo01.AutoSize = true;
            this.lblTelFijo01.BackColor = System.Drawing.Color.Transparent;
            this.lblTelFijo01.ForeColor = System.Drawing.Color.Navy;
            this.lblTelFijo01.Location = new System.Drawing.Point(296, 30);
            this.lblTelFijo01.Name = "lblTelFijo01";
            this.lblTelFijo01.Size = new System.Drawing.Size(74, 19);
            this.lblTelFijo01.TabIndex = 0;
            this.lblTelFijo01.Text = "Telf. Fijo 01:";
            this.lblTelFijo01.UseCustomForeColor = true;
            // 
            // lblCelular03
            // 
            this.lblCelular03.AutoSize = true;
            this.lblCelular03.BackColor = System.Drawing.Color.Transparent;
            this.lblCelular03.ForeColor = System.Drawing.Color.Navy;
            this.lblCelular03.Location = new System.Drawing.Point(6, 95);
            this.lblCelular03.Name = "lblCelular03";
            this.lblCelular03.Size = new System.Drawing.Size(71, 19);
            this.lblCelular03.TabIndex = 4;
            this.lblCelular03.Text = "Celular 03:";
            this.lblCelular03.UseCustomForeColor = true;
            // 
            // txtTelfFijo03
            // 
            this.txtTelfFijo03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtTelfFijo03.CustomButton.Image = null;
            this.txtTelfFijo03.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtTelfFijo03.CustomButton.Name = "";
            this.txtTelfFijo03.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTelfFijo03.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTelfFijo03.CustomButton.TabIndex = 1;
            this.txtTelfFijo03.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTelfFijo03.CustomButton.UseSelectable = true;
            this.txtTelfFijo03.CustomButton.Visible = false;
            this.txtTelfFijo03.Lines = new string[0];
            this.txtTelfFijo03.Location = new System.Drawing.Point(381, 93);
            this.txtTelfFijo03.MaxLength = 32767;
            this.txtTelfFijo03.Name = "txtTelfFijo03";
            this.txtTelfFijo03.PasswordChar = '\0';
            this.txtTelfFijo03.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTelfFijo03.SelectedText = "";
            this.txtTelfFijo03.SelectionLength = 0;
            this.txtTelfFijo03.SelectionStart = 0;
            this.txtTelfFijo03.ShortcutsEnabled = true;
            this.txtTelfFijo03.Size = new System.Drawing.Size(156, 23);
            this.txtTelfFijo03.TabIndex = 5;
            this.txtTelfFijo03.UseCustomBackColor = true;
            this.txtTelfFijo03.UseSelectable = true;
            this.txtTelfFijo03.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTelfFijo03.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelfFijo03.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblTelFijo03
            // 
            this.lblTelFijo03.AutoSize = true;
            this.lblTelFijo03.BackColor = System.Drawing.Color.Transparent;
            this.lblTelFijo03.ForeColor = System.Drawing.Color.Navy;
            this.lblTelFijo03.Location = new System.Drawing.Point(294, 95);
            this.lblTelFijo03.Name = "lblTelFijo03";
            this.lblTelFijo03.Size = new System.Drawing.Size(76, 19);
            this.lblTelFijo03.TabIndex = 4;
            this.lblTelFijo03.Text = "Telf. Fijo 03:";
            this.lblTelFijo03.UseCustomForeColor = true;
            // 
            // txtCelular01
            // 
            this.txtCelular01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtCelular01.CustomButton.Image = null;
            this.txtCelular01.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtCelular01.CustomButton.Name = "";
            this.txtCelular01.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCelular01.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCelular01.CustomButton.TabIndex = 1;
            this.txtCelular01.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCelular01.CustomButton.UseSelectable = true;
            this.txtCelular01.CustomButton.Visible = false;
            this.txtCelular01.Lines = new string[0];
            this.txtCelular01.Location = new System.Drawing.Point(91, 26);
            this.txtCelular01.MaxLength = 32767;
            this.txtCelular01.Name = "txtCelular01";
            this.txtCelular01.PasswordChar = '\0';
            this.txtCelular01.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCelular01.SelectedText = "";
            this.txtCelular01.SelectionLength = 0;
            this.txtCelular01.SelectionStart = 0;
            this.txtCelular01.ShortcutsEnabled = true;
            this.txtCelular01.Size = new System.Drawing.Size(156, 23);
            this.txtCelular01.TabIndex = 0;
            this.txtCelular01.UseCustomBackColor = true;
            this.txtCelular01.UseSelectable = true;
            this.txtCelular01.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCelular01.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCelular01.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblCelular01
            // 
            this.lblCelular01.AutoSize = true;
            this.lblCelular01.BackColor = System.Drawing.Color.Transparent;
            this.lblCelular01.ForeColor = System.Drawing.Color.Navy;
            this.lblCelular01.Location = new System.Drawing.Point(6, 27);
            this.lblCelular01.Name = "lblCelular01";
            this.lblCelular01.Size = new System.Drawing.Size(69, 19);
            this.lblCelular01.TabIndex = 0;
            this.lblCelular01.Text = "Celular 01:";
            this.lblCelular01.UseCustomForeColor = true;
            // 
            // tabPagInfoExtra
            // 
            this.tabPagInfoExtra.Controls.Add(this.grbInfoExtra);
            this.tabPagInfoExtra.HorizontalScrollbarBarColor = true;
            this.tabPagInfoExtra.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagInfoExtra.HorizontalScrollbarSize = 10;
            this.tabPagInfoExtra.Location = new System.Drawing.Point(4, 38);
            this.tabPagInfoExtra.Name = "tabPagInfoExtra";
            this.tabPagInfoExtra.Size = new System.Drawing.Size(578, 422);
            this.tabPagInfoExtra.TabIndex = 2;
            this.tabPagInfoExtra.Text = "Info. Extra";
            this.tabPagInfoExtra.VerticalScrollbarBarColor = true;
            this.tabPagInfoExtra.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagInfoExtra.VerticalScrollbarSize = 10;
            // 
            // grbInfoExtra
            // 
            this.grbInfoExtra.BackColor = System.Drawing.Color.Transparent;
            this.grbInfoExtra.Controls.Add(this.txtInfo10);
            this.grbInfoExtra.Controls.Add(this.lblInfo10);
            this.grbInfoExtra.Controls.Add(this.txtInfo08);
            this.grbInfoExtra.Controls.Add(this.lblInfo08);
            this.grbInfoExtra.Controls.Add(this.txtInfo09);
            this.grbInfoExtra.Controls.Add(this.lblInfo09);
            this.grbInfoExtra.Controls.Add(this.txtInfo07);
            this.grbInfoExtra.Controls.Add(this.lblInfo07);
            this.grbInfoExtra.Controls.Add(this.txtInfo05);
            this.grbInfoExtra.Controls.Add(this.lblInfo05);
            this.grbInfoExtra.Controls.Add(this.txtInfo06);
            this.grbInfoExtra.Controls.Add(this.lblInfo06);
            this.grbInfoExtra.Controls.Add(this.txtInfo04);
            this.grbInfoExtra.Controls.Add(this.lblInfo04);
            this.grbInfoExtra.Controls.Add(this.txtInfo02);
            this.grbInfoExtra.Controls.Add(this.lblInfo02);
            this.grbInfoExtra.Controls.Add(this.txtInfo03);
            this.grbInfoExtra.Controls.Add(this.lblInfo03);
            this.grbInfoExtra.Controls.Add(this.txtInfo01);
            this.grbInfoExtra.Controls.Add(this.lblInfo01);
            this.grbInfoExtra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbInfoExtra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfoExtra.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbInfoExtra.Location = new System.Drawing.Point(11, 8);
            this.grbInfoExtra.Name = "grbInfoExtra";
            this.grbInfoExtra.Size = new System.Drawing.Size(555, 201);
            this.grbInfoExtra.TabIndex = 0;
            this.grbInfoExtra.TabStop = false;
            this.grbInfoExtra.Text = "Agregue la información extra que necesite";
            // 
            // txtInfo10
            // 
            this.txtInfo10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInfo10.CustomButton.Image = null;
            this.txtInfo10.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtInfo10.CustomButton.Name = "";
            this.txtInfo10.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInfo10.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInfo10.CustomButton.TabIndex = 1;
            this.txtInfo10.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInfo10.CustomButton.UseSelectable = true;
            this.txtInfo10.CustomButton.Visible = false;
            this.txtInfo10.Lines = new string[0];
            this.txtInfo10.Location = new System.Drawing.Point(353, 165);
            this.txtInfo10.MaxLength = 32767;
            this.txtInfo10.Name = "txtInfo10";
            this.txtInfo10.PasswordChar = '\0';
            this.txtInfo10.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo10.SelectedText = "";
            this.txtInfo10.SelectionLength = 0;
            this.txtInfo10.SelectionStart = 0;
            this.txtInfo10.ShortcutsEnabled = true;
            this.txtInfo10.Size = new System.Drawing.Size(184, 23);
            this.txtInfo10.TabIndex = 9;
            this.txtInfo10.UseCustomBackColor = true;
            this.txtInfo10.UseSelectable = true;
            this.txtInfo10.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo10.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo10.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblInfo10
            // 
            this.lblInfo10.AutoSize = true;
            this.lblInfo10.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo10.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo10.Location = new System.Drawing.Point(292, 167);
            this.lblInfo10.Name = "lblInfo10";
            this.lblInfo10.Size = new System.Drawing.Size(53, 19);
            this.lblInfo10.TabIndex = 18;
            this.lblInfo10.Text = "Info. 10:";
            this.lblInfo10.UseCustomForeColor = true;
            // 
            // txtInfo08
            // 
            this.txtInfo08.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInfo08.CustomButton.Image = null;
            this.txtInfo08.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtInfo08.CustomButton.Name = "";
            this.txtInfo08.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInfo08.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInfo08.CustomButton.TabIndex = 1;
            this.txtInfo08.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInfo08.CustomButton.UseSelectable = true;
            this.txtInfo08.CustomButton.Visible = false;
            this.txtInfo08.Lines = new string[0];
            this.txtInfo08.Location = new System.Drawing.Point(353, 97);
            this.txtInfo08.MaxLength = 32767;
            this.txtInfo08.Name = "txtInfo08";
            this.txtInfo08.PasswordChar = '\0';
            this.txtInfo08.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo08.SelectedText = "";
            this.txtInfo08.SelectionLength = 0;
            this.txtInfo08.SelectionStart = 0;
            this.txtInfo08.ShortcutsEnabled = true;
            this.txtInfo08.Size = new System.Drawing.Size(184, 23);
            this.txtInfo08.TabIndex = 7;
            this.txtInfo08.UseCustomBackColor = true;
            this.txtInfo08.UseSelectable = true;
            this.txtInfo08.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo08.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo08.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblInfo08
            // 
            this.lblInfo08.AutoSize = true;
            this.lblInfo08.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo08.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo08.Location = new System.Drawing.Point(292, 99);
            this.lblInfo08.Name = "lblInfo08";
            this.lblInfo08.Size = new System.Drawing.Size(55, 19);
            this.lblInfo08.TabIndex = 14;
            this.lblInfo08.Text = "Info. 08:";
            this.lblInfo08.UseCustomForeColor = true;
            // 
            // txtInfo09
            // 
            this.txtInfo09.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInfo09.CustomButton.Image = null;
            this.txtInfo09.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtInfo09.CustomButton.Name = "";
            this.txtInfo09.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInfo09.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInfo09.CustomButton.TabIndex = 1;
            this.txtInfo09.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInfo09.CustomButton.UseSelectable = true;
            this.txtInfo09.CustomButton.Visible = false;
            this.txtInfo09.Lines = new string[0];
            this.txtInfo09.Location = new System.Drawing.Point(353, 131);
            this.txtInfo09.MaxLength = 32767;
            this.txtInfo09.Name = "txtInfo09";
            this.txtInfo09.PasswordChar = '\0';
            this.txtInfo09.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo09.SelectedText = "";
            this.txtInfo09.SelectionLength = 0;
            this.txtInfo09.SelectionStart = 0;
            this.txtInfo09.ShortcutsEnabled = true;
            this.txtInfo09.Size = new System.Drawing.Size(184, 23);
            this.txtInfo09.TabIndex = 8;
            this.txtInfo09.UseCustomBackColor = true;
            this.txtInfo09.UseSelectable = true;
            this.txtInfo09.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo09.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo09.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblInfo09
            // 
            this.lblInfo09.AutoSize = true;
            this.lblInfo09.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo09.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo09.Location = new System.Drawing.Point(292, 133);
            this.lblInfo09.Name = "lblInfo09";
            this.lblInfo09.Size = new System.Drawing.Size(55, 19);
            this.lblInfo09.TabIndex = 16;
            this.lblInfo09.Text = "Info. 09:";
            this.lblInfo09.UseCustomForeColor = true;
            // 
            // txtInfo07
            // 
            this.txtInfo07.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInfo07.CustomButton.Image = null;
            this.txtInfo07.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtInfo07.CustomButton.Name = "";
            this.txtInfo07.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInfo07.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInfo07.CustomButton.TabIndex = 1;
            this.txtInfo07.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInfo07.CustomButton.UseSelectable = true;
            this.txtInfo07.CustomButton.Visible = false;
            this.txtInfo07.Lines = new string[0];
            this.txtInfo07.Location = new System.Drawing.Point(353, 63);
            this.txtInfo07.MaxLength = 32767;
            this.txtInfo07.Name = "txtInfo07";
            this.txtInfo07.PasswordChar = '\0';
            this.txtInfo07.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo07.SelectedText = "";
            this.txtInfo07.SelectionLength = 0;
            this.txtInfo07.SelectionStart = 0;
            this.txtInfo07.ShortcutsEnabled = true;
            this.txtInfo07.Size = new System.Drawing.Size(184, 23);
            this.txtInfo07.TabIndex = 6;
            this.txtInfo07.UseCustomBackColor = true;
            this.txtInfo07.UseSelectable = true;
            this.txtInfo07.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo07.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo07.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblInfo07
            // 
            this.lblInfo07.AutoSize = true;
            this.lblInfo07.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo07.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo07.Location = new System.Drawing.Point(292, 65);
            this.lblInfo07.Name = "lblInfo07";
            this.lblInfo07.Size = new System.Drawing.Size(55, 19);
            this.lblInfo07.TabIndex = 12;
            this.lblInfo07.Text = "Info. 07:";
            this.lblInfo07.UseCustomForeColor = true;
            // 
            // txtInfo05
            // 
            this.txtInfo05.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInfo05.CustomButton.Image = null;
            this.txtInfo05.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtInfo05.CustomButton.Name = "";
            this.txtInfo05.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInfo05.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInfo05.CustomButton.TabIndex = 1;
            this.txtInfo05.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInfo05.CustomButton.UseSelectable = true;
            this.txtInfo05.CustomButton.Visible = false;
            this.txtInfo05.Lines = new string[0];
            this.txtInfo05.Location = new System.Drawing.Point(74, 165);
            this.txtInfo05.MaxLength = 32767;
            this.txtInfo05.Name = "txtInfo05";
            this.txtInfo05.PasswordChar = '\0';
            this.txtInfo05.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo05.SelectedText = "";
            this.txtInfo05.SelectionLength = 0;
            this.txtInfo05.SelectionStart = 0;
            this.txtInfo05.ShortcutsEnabled = true;
            this.txtInfo05.Size = new System.Drawing.Size(184, 23);
            this.txtInfo05.TabIndex = 4;
            this.txtInfo05.UseCustomBackColor = true;
            this.txtInfo05.UseSelectable = true;
            this.txtInfo05.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo05.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo05.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblInfo05
            // 
            this.lblInfo05.AutoSize = true;
            this.lblInfo05.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo05.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo05.Location = new System.Drawing.Point(13, 167);
            this.lblInfo05.Name = "lblInfo05";
            this.lblInfo05.Size = new System.Drawing.Size(55, 19);
            this.lblInfo05.TabIndex = 8;
            this.lblInfo05.Text = "Info. 05:";
            this.lblInfo05.UseCustomForeColor = true;
            // 
            // txtInfo06
            // 
            this.txtInfo06.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInfo06.CustomButton.Image = null;
            this.txtInfo06.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtInfo06.CustomButton.Name = "";
            this.txtInfo06.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInfo06.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInfo06.CustomButton.TabIndex = 1;
            this.txtInfo06.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInfo06.CustomButton.UseSelectable = true;
            this.txtInfo06.CustomButton.Visible = false;
            this.txtInfo06.Lines = new string[0];
            this.txtInfo06.Location = new System.Drawing.Point(353, 29);
            this.txtInfo06.MaxLength = 32767;
            this.txtInfo06.Name = "txtInfo06";
            this.txtInfo06.PasswordChar = '\0';
            this.txtInfo06.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo06.SelectedText = "";
            this.txtInfo06.SelectionLength = 0;
            this.txtInfo06.SelectionStart = 0;
            this.txtInfo06.ShortcutsEnabled = true;
            this.txtInfo06.Size = new System.Drawing.Size(184, 23);
            this.txtInfo06.TabIndex = 5;
            this.txtInfo06.UseCustomBackColor = true;
            this.txtInfo06.UseSelectable = true;
            this.txtInfo06.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo06.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo06.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblInfo06
            // 
            this.lblInfo06.AutoSize = true;
            this.lblInfo06.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo06.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo06.Location = new System.Drawing.Point(292, 31);
            this.lblInfo06.Name = "lblInfo06";
            this.lblInfo06.Size = new System.Drawing.Size(55, 19);
            this.lblInfo06.TabIndex = 10;
            this.lblInfo06.Text = "Info. 06:";
            this.lblInfo06.UseCustomForeColor = true;
            // 
            // txtInfo04
            // 
            this.txtInfo04.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInfo04.CustomButton.Image = null;
            this.txtInfo04.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtInfo04.CustomButton.Name = "";
            this.txtInfo04.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInfo04.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInfo04.CustomButton.TabIndex = 1;
            this.txtInfo04.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInfo04.CustomButton.UseSelectable = true;
            this.txtInfo04.CustomButton.Visible = false;
            this.txtInfo04.Lines = new string[0];
            this.txtInfo04.Location = new System.Drawing.Point(74, 131);
            this.txtInfo04.MaxLength = 32767;
            this.txtInfo04.Name = "txtInfo04";
            this.txtInfo04.PasswordChar = '\0';
            this.txtInfo04.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo04.SelectedText = "";
            this.txtInfo04.SelectionLength = 0;
            this.txtInfo04.SelectionStart = 0;
            this.txtInfo04.ShortcutsEnabled = true;
            this.txtInfo04.Size = new System.Drawing.Size(184, 23);
            this.txtInfo04.TabIndex = 3;
            this.txtInfo04.UseCustomBackColor = true;
            this.txtInfo04.UseSelectable = true;
            this.txtInfo04.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo04.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo04.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblInfo04
            // 
            this.lblInfo04.AutoSize = true;
            this.lblInfo04.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo04.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo04.Location = new System.Drawing.Point(13, 133);
            this.lblInfo04.Name = "lblInfo04";
            this.lblInfo04.Size = new System.Drawing.Size(55, 19);
            this.lblInfo04.TabIndex = 6;
            this.lblInfo04.Text = "Info. 04:";
            this.lblInfo04.UseCustomForeColor = true;
            // 
            // txtInfo02
            // 
            this.txtInfo02.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInfo02.CustomButton.Image = null;
            this.txtInfo02.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtInfo02.CustomButton.Name = "";
            this.txtInfo02.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInfo02.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInfo02.CustomButton.TabIndex = 1;
            this.txtInfo02.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInfo02.CustomButton.UseSelectable = true;
            this.txtInfo02.CustomButton.Visible = false;
            this.txtInfo02.Lines = new string[0];
            this.txtInfo02.Location = new System.Drawing.Point(74, 63);
            this.txtInfo02.MaxLength = 32767;
            this.txtInfo02.Name = "txtInfo02";
            this.txtInfo02.PasswordChar = '\0';
            this.txtInfo02.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo02.SelectedText = "";
            this.txtInfo02.SelectionLength = 0;
            this.txtInfo02.SelectionStart = 0;
            this.txtInfo02.ShortcutsEnabled = true;
            this.txtInfo02.Size = new System.Drawing.Size(184, 23);
            this.txtInfo02.TabIndex = 1;
            this.txtInfo02.UseCustomBackColor = true;
            this.txtInfo02.UseSelectable = true;
            this.txtInfo02.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo02.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo02.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblInfo02
            // 
            this.lblInfo02.AutoSize = true;
            this.lblInfo02.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo02.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo02.Location = new System.Drawing.Point(13, 65);
            this.lblInfo02.Name = "lblInfo02";
            this.lblInfo02.Size = new System.Drawing.Size(55, 19);
            this.lblInfo02.TabIndex = 2;
            this.lblInfo02.Text = "Info. 02:";
            this.lblInfo02.UseCustomForeColor = true;
            // 
            // txtInfo03
            // 
            this.txtInfo03.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInfo03.CustomButton.Image = null;
            this.txtInfo03.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtInfo03.CustomButton.Name = "";
            this.txtInfo03.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInfo03.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInfo03.CustomButton.TabIndex = 1;
            this.txtInfo03.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInfo03.CustomButton.UseSelectable = true;
            this.txtInfo03.CustomButton.Visible = false;
            this.txtInfo03.Lines = new string[0];
            this.txtInfo03.Location = new System.Drawing.Point(74, 97);
            this.txtInfo03.MaxLength = 32767;
            this.txtInfo03.Name = "txtInfo03";
            this.txtInfo03.PasswordChar = '\0';
            this.txtInfo03.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo03.SelectedText = "";
            this.txtInfo03.SelectionLength = 0;
            this.txtInfo03.SelectionStart = 0;
            this.txtInfo03.ShortcutsEnabled = true;
            this.txtInfo03.Size = new System.Drawing.Size(184, 23);
            this.txtInfo03.TabIndex = 2;
            this.txtInfo03.UseCustomBackColor = true;
            this.txtInfo03.UseSelectable = true;
            this.txtInfo03.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo03.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo03.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblInfo03
            // 
            this.lblInfo03.AutoSize = true;
            this.lblInfo03.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo03.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo03.Location = new System.Drawing.Point(13, 99);
            this.lblInfo03.Name = "lblInfo03";
            this.lblInfo03.Size = new System.Drawing.Size(55, 19);
            this.lblInfo03.TabIndex = 4;
            this.lblInfo03.Text = "Info. 03:";
            this.lblInfo03.UseCustomForeColor = true;
            // 
            // txtInfo01
            // 
            this.txtInfo01.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtInfo01.CustomButton.Image = null;
            this.txtInfo01.CustomButton.Location = new System.Drawing.Point(162, 1);
            this.txtInfo01.CustomButton.Name = "";
            this.txtInfo01.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtInfo01.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInfo01.CustomButton.TabIndex = 1;
            this.txtInfo01.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInfo01.CustomButton.UseSelectable = true;
            this.txtInfo01.CustomButton.Visible = false;
            this.txtInfo01.Lines = new string[0];
            this.txtInfo01.Location = new System.Drawing.Point(74, 29);
            this.txtInfo01.MaxLength = 32767;
            this.txtInfo01.Name = "txtInfo01";
            this.txtInfo01.PasswordChar = '\0';
            this.txtInfo01.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInfo01.SelectedText = "";
            this.txtInfo01.SelectionLength = 0;
            this.txtInfo01.SelectionStart = 0;
            this.txtInfo01.ShortcutsEnabled = true;
            this.txtInfo01.Size = new System.Drawing.Size(184, 23);
            this.txtInfo01.TabIndex = 0;
            this.txtInfo01.UseCustomBackColor = true;
            this.txtInfo01.UseSelectable = true;
            this.txtInfo01.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInfo01.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInfo01.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblInfo01
            // 
            this.lblInfo01.AutoSize = true;
            this.lblInfo01.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo01.ForeColor = System.Drawing.Color.Navy;
            this.lblInfo01.Location = new System.Drawing.Point(15, 31);
            this.lblInfo01.Name = "lblInfo01";
            this.lblInfo01.Size = new System.Drawing.Size(53, 19);
            this.lblInfo01.TabIndex = 0;
            this.lblInfo01.Text = "Info. 01:";
            this.lblInfo01.UseCustomForeColor = true;
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(90, 40);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(128, 32);
            this.lblNombreForm.TabIndex = 62;
            this.lblNombreForm.Text = "Empleados";
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageSize = 48;
            this.btnCerrar.Location = new System.Drawing.Point(28, 28);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 57);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.UseSelectable = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panelMantenimiento
            // 
            this.panelMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panelMantenimiento.Controls.Add(this.btnCommit);
            this.panelMantenimiento.Controls.Add(this.btnSearch);
            this.panelMantenimiento.Controls.Add(this.btnNuevo);
            this.panelMantenimiento.Controls.Add(this.btnRollback);
            this.panelMantenimiento.Controls.Add(this.btnDelete);
            this.panelMantenimiento.HorizontalScrollbarBarColor = true;
            this.panelMantenimiento.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMantenimiento.HorizontalScrollbarSize = 10;
            this.panelMantenimiento.Location = new System.Drawing.Point(407, 36);
            this.panelMantenimiento.Name = "panelMantenimiento";
            this.panelMantenimiento.Size = new System.Drawing.Size(572, 49);
            this.panelMantenimiento.Style = MetroFramework.MetroColorStyle.Green;
            this.panelMantenimiento.TabIndex = 2;
            this.panelMantenimiento.UseCustomBackColor = true;
            this.panelMantenimiento.UseStyleColors = true;
            this.panelMantenimiento.VerticalScrollbarBarColor = true;
            this.panelMantenimiento.VerticalScrollbarHighlightOnWheel = false;
            this.panelMantenimiento.VerticalScrollbarSize = 10;
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCommit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCommit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCommit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommit.Image = ((System.Drawing.Image)(resources.GetObject("btnCommit.Image")));
            this.btnCommit.Location = new System.Drawing.Point(481, 5);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(40, 40);
            this.btnCommit.TabIndex = 0;
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(397, 5);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(40, 40);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnRollback
            // 
            this.btnRollback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnRollback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRollback.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRollback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnRollback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRollback.Image = ((System.Drawing.Image)(resources.GetObject("btnRollback.Image")));
            this.btnRollback.Location = new System.Drawing.Point(523, 5);
            this.btnRollback.Name = "btnRollback";
            this.btnRollback.Size = new System.Drawing.Size(40, 40);
            this.btnRollback.TabIndex = 1;
            this.btnRollback.UseVisualStyleBackColor = false;
            this.btnRollback.Click += new System.EventHandler(this.btnRollback_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(439, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.ForeColor = System.Drawing.Color.Navy;
            this.lblIdEmpleado.Location = new System.Drawing.Point(552, 14);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(0, 0);
            this.lblIdEmpleado.TabIndex = 107;
            this.lblIdEmpleado.UseCustomForeColor = true;
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.AllowUserToAddRows = false;
            this.dgvEmpleado.AllowUserToResizeColumns = false;
            this.dgvEmpleado.AllowUserToResizeRows = false;
            this.dgvEmpleado.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmpleado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEmpleado.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmpleado.Location = new System.Drawing.Point(38, 129);
            this.dgvEmpleado.MultiSelect = false;
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvEmpleado.RowHeadersVisible = false;
            this.dgvEmpleado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEmpleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmpleado.Size = new System.Drawing.Size(320, 456);
            this.dgvEmpleado.TabIndex = 0;
            this.dgvEmpleado.SelectionChanged += new System.EventHandler(this.dgvEmpleado_SelectionChanged);
            this.dgvEmpleado.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvBordered_Paint);
            // 
            // lblNumInactivo
            // 
            this.lblNumInactivo.AutoSize = true;
            this.lblNumInactivo.BackColor = System.Drawing.Color.Transparent;
            this.lblNumInactivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumInactivo.ForeColor = System.Drawing.Color.Red;
            this.lblNumInactivo.Location = new System.Drawing.Point(183, 588);
            this.lblNumInactivo.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumInactivo.Name = "lblNumInactivo";
            this.lblNumInactivo.Size = new System.Drawing.Size(65, 17);
            this.lblNumInactivo.TabIndex = 110;
            this.lblNumInactivo.Text = "Inactivos: ";
            // 
            // lblNumActivo
            // 
            this.lblNumActivo.AutoSize = true;
            this.lblNumActivo.BackColor = System.Drawing.Color.Transparent;
            this.lblNumActivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumActivo.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblNumActivo.Location = new System.Drawing.Point(103, 588);
            this.lblNumActivo.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumActivo.Name = "lblNumActivo";
            this.lblNumActivo.Size = new System.Drawing.Size(56, 17);
            this.lblNumActivo.TabIndex = 109;
            this.lblNumActivo.Text = "Activos: ";
            // 
            // lblNumReg
            // 
            this.lblNumReg.AutoSize = true;
            this.lblNumReg.BackColor = System.Drawing.Color.Transparent;
            this.lblNumReg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumReg.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNumReg.Location = new System.Drawing.Point(34, 588);
            this.lblNumReg.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumReg.Name = "lblNumReg";
            this.lblNumReg.Size = new System.Drawing.Size(43, 17);
            this.lblNumReg.TabIndex = 108;
            this.lblNumReg.Text = "Total: ";
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 636);
            this.Controls.Add(this.lblNumInactivo);
            this.Controls.Add(this.lblNumActivo);
            this.Controls.Add(this.lblNumReg);
            this.Controls.Add(this.dgvEmpleado);
            this.Controls.Add(this.lblIdEmpleado);
            this.Controls.Add(this.tglListarInactivos);
            this.Controls.Add(this.lblListarInactivos);
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.tabEmpleado);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panelMantenimiento);
            this.MaximizeBox = false;
            this.Name = "FormEmpleado";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FormEmpleado_Load);
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            this.tabEmpleado.ResumeLayout(false);
            this.tabPagGeneral.ResumeLayout(false);
            this.tabPagGeneral.PerformLayout();
            this.grbUser.ResumeLayout(false);
            this.tabPagDetalles.ResumeLayout(false);
            this.tabPagDetalles.PerformLayout();
            this.grbLaboralSaludPen.ResumeLayout(false);
            this.grbLaboralSaludPen.PerformLayout();
            this.grbSalario.ResumeLayout(false);
            this.grbSalario.PerformLayout();
            this.tabPagTrabajo.ResumeLayout(false);
            this.tabPagTrabajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajoEmpleado)).EndInit();
            this.tabPagDireccion.ResumeLayout(false);
            this.grbUbicacionDetallada.ResumeLayout(false);
            this.grbUbicacionDetallada.PerformLayout();
            this.gbrUbigeo.ResumeLayout(false);
            this.gbrUbigeo.PerformLayout();
            this.tabPagEducacion.ResumeLayout(false);
            this.grbSkillsEducativas.ResumeLayout(false);
            this.grbSkillsEducativas.PerformLayout();
            this.tabPagContacto.ResumeLayout(false);
            this.grbEmailYWeb.ResumeLayout(false);
            this.grbEmailYWeb.PerformLayout();
            this.grbNumerosContacto.ResumeLayout(false);
            this.grbNumerosContacto.PerformLayout();
            this.tabPagInfoExtra.ResumeLayout(false);
            this.grbInfoExtra.ResumeLayout(false);
            this.grbInfoExtra.PerformLayout();
            this.panelMantenimiento.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroToggle tglListarInactivos;
        private MetroFramework.Controls.MetroLabel lblListarInactivos;
        private MetroFramework.Controls.MetroPanel panelFiltro;
        private MetroFramework.Controls.MetroLabel lblFiltro;
        private System.Windows.Forms.Button btnFilter;
        private MetroFramework.Controls.MetroTextBox txtFiltro;
        private BorderedCombo cboFiltro;
        private MetroFramework.Controls.MetroTabControl tabEmpleado;
        private MetroFramework.Controls.MetroTabPage tabPagGeneral;
        private MetroFramework.Controls.MetroCheckBox chkActivo;
        private MetroFramework.Controls.MetroTextBox txtReferencia;
        private MetroFramework.Controls.MetroLabel lblReferencia;
        private MetroFramework.Controls.MetroTextBox txtDireccion02;
        private MetroFramework.Controls.MetroLabel lblDireccion02;
        private MetroFramework.Controls.MetroTextBox txtDireccion01;
        private MetroFramework.Controls.MetroLabel lblDireccion01;
        private MetroFramework.Controls.MetroTextBox txtNumVia;
        private MetroFramework.Controls.MetroLabel lblNumVia;
        private BorderedCombo cboNacionalidad;
        private MetroFramework.Controls.MetroLabel lblNacionalidad;
        private BorderedCombo cboProvincia;
        private MetroFramework.Controls.MetroLabel lblProvincia;
        private BorderedCombo cboDepartamento;
        private MetroFramework.Controls.MetroLabel lblDepartamento;
        private BorderedCombo cboDistrito;
        private MetroFramework.Controls.MetroLabel lblDistrito;
        private MetroFramework.Controls.MetroTextBox txtNomVia;
        private MetroFramework.Controls.MetroLabel lblNomVia;
        private MetroFramework.Controls.MetroTextBox txtNomZona;
        private MetroFramework.Controls.MetroLabel lblNomZona;
        private BorderedCombo cboVia;
        private MetroFramework.Controls.MetroLabel lblVia;
        private BorderedCombo cboZona;
        private MetroFramework.Controls.MetroLabel lblZona;
        private MetroFramework.Controls.MetroTextBox txtNumRuc;
        private MetroFramework.Controls.MetroLabel lblNumRuc;
        private MetroFramework.Controls.MetroTextBox txtNumDoc;
        private MetroFramework.Controls.MetroLabel lblNumDoc;
        private BorderedCombo cboTipoDocIdentidad;
        private MetroFramework.Controls.MetroLabel lblTipoDocIdentidad;
        private MetroFramework.Controls.MetroTextBox txtNomComercial;
        private MetroFramework.Controls.MetroLabel lblNomComercial;
        private MetroFramework.Controls.MetroTextBox txtRazonSocial;
        private MetroFramework.Controls.MetroLabel lblRazonSocial;
        private MetroFramework.Controls.MetroLabel lblSexo;
        private MetroFramework.Controls.MetroRadioButton rbtFemenino;
        private MetroFramework.Controls.MetroRadioButton rbtMasculino;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private MetroFramework.Controls.MetroLabel lblCodigo;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel lblFechaNac;
        private BorderedCombo cboEstadoCivil;
        private MetroFramework.Controls.MetroLabel lblEstadoCivil;
        private MetroFramework.Controls.MetroTextBox txtSegundoNom;
        private MetroFramework.Controls.MetroLabel lblSegundoNom;
        private MetroFramework.Controls.MetroTextBox txtApMaterno;
        private MetroFramework.Controls.MetroLabel lblApMaterno;
        private MetroFramework.Controls.MetroTextBox txtPrimerNom;
        private MetroFramework.Controls.MetroLabel lblPrimerNom;
        private MetroFramework.Controls.MetroTextBox txtApPaterno;
        private MetroFramework.Controls.MetroLabel lblApPaterno;
        private MetroFramework.Controls.MetroTabPage tabPagContacto;
        private System.Windows.Forms.GroupBox grbEmailYWeb;
        private MetroFramework.Controls.MetroTextBox txtEmail02;
        private MetroFramework.Controls.MetroLabel lblEmail02;
        private MetroFramework.Controls.MetroTextBox txtPagWeb;
        private MetroFramework.Controls.MetroLabel lblPagWeb;
        private MetroFramework.Controls.MetroTextBox txtEmail01;
        private MetroFramework.Controls.MetroLabel lblEmail01;
        private MetroFramework.Controls.MetroTextBox txtTelfFijo02;
        private MetroFramework.Controls.MetroTextBox txtTelfFijo01;
        private MetroFramework.Controls.MetroLabel lblTelFijo02;
        private MetroFramework.Controls.MetroLabel lblTelFijo01;
        private MetroFramework.Controls.MetroTextBox txtTelfFijo03;
        private MetroFramework.Controls.MetroLabel lblTelFijo03;
        private System.Windows.Forms.GroupBox grbNumerosContacto;
        private MetroFramework.Controls.MetroTextBox txtCelular02;
        private MetroFramework.Controls.MetroLabel lblCelular02;
        private MetroFramework.Controls.MetroTextBox txtCelular03;
        private MetroFramework.Controls.MetroLabel lblCelular03;
        private MetroFramework.Controls.MetroTextBox txtCelular01;
        private MetroFramework.Controls.MetroLabel lblCelular01;
        private MetroFramework.Controls.MetroTabPage tabPagInfoExtra;
        private System.Windows.Forms.GroupBox grbInfoExtra;
        private MetroFramework.Controls.MetroTextBox txtInfo10;
        private MetroFramework.Controls.MetroLabel lblInfo10;
        private MetroFramework.Controls.MetroTextBox txtInfo08;
        private MetroFramework.Controls.MetroLabel lblInfo08;
        private MetroFramework.Controls.MetroTextBox txtInfo09;
        private MetroFramework.Controls.MetroLabel lblInfo09;
        private MetroFramework.Controls.MetroTextBox txtInfo07;
        private MetroFramework.Controls.MetroLabel lblInfo07;
        private MetroFramework.Controls.MetroTextBox txtInfo05;
        private MetroFramework.Controls.MetroLabel lblInfo05;
        private MetroFramework.Controls.MetroTextBox txtInfo06;
        private MetroFramework.Controls.MetroLabel lblInfo06;
        private MetroFramework.Controls.MetroTextBox txtInfo04;
        private MetroFramework.Controls.MetroLabel lblInfo04;
        private MetroFramework.Controls.MetroTextBox txtInfo02;
        private MetroFramework.Controls.MetroLabel lblInfo02;
        private MetroFramework.Controls.MetroTextBox txtInfo03;
        private MetroFramework.Controls.MetroLabel lblInfo03;
        private MetroFramework.Controls.MetroTextBox txtInfo01;
        private MetroFramework.Controls.MetroLabel lblInfo01;
        private System.Windows.Forms.Label lblNombreForm;
        private MetroFramework.Controls.MetroLink btnCerrar;
        private MetroFramework.Controls.MetroPanel panelMantenimiento;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnRollback;
        private System.Windows.Forms.Button btnDelete;
        private MetroFramework.Controls.MetroLabel lblIdEmpleado;
        private MetroFramework.Controls.MetroTabPage tabPagDetalles;
        private System.Windows.Forms.GroupBox grbSkillsEducativas;
        private System.Windows.Forms.GroupBox grbLaboralSaludPen;
        private System.Windows.Forms.DateTimePicker dtpFechaCese;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.GroupBox grbSalario;
        private MetroFramework.Controls.MetroTextBox txtNumHorasMes;
        private MetroFramework.Controls.MetroLabel lblNumHorasMes;
        private MetroFramework.Controls.MetroTextBox txtNumCuenta;
        private MetroFramework.Controls.MetroLabel lblNumCuenta;
        private MetroFramework.Controls.MetroLabel lblEntidadFinanciera;
        private MetroFramework.Controls.MetroTextBox txtSalQuincenal;
        private MetroFramework.Controls.MetroLabel lblSalQuincenal;
        private MetroFramework.Controls.MetroTextBox txtSalHora;
        private MetroFramework.Controls.MetroLabel lblSalHora;
        private MetroFramework.Controls.MetroTextBox txtSalMensual;
        private MetroFramework.Controls.MetroLabel lblSalMensual;
        private BorderedCombo cboPeriodoPago;
        private MetroFramework.Controls.MetroLabel lblPeriodoPago;
        private BorderedCombo cboOcupacion;
        private MetroFramework.Controls.MetroLabel lblOcupacion;
        private BorderedCombo cboTipoTrabajador;
        private MetroFramework.Controls.MetroLabel lblTipoTrabajador;
        private BorderedCombo cboRegPension;
        private MetroFramework.Controls.MetroLabel lblRegPension;
        private BorderedCombo cboCondicionLaboral;
        private MetroFramework.Controls.MetroLabel lblCondicionLaboral;
        private BorderedCombo cboSaludEps;
        private MetroFramework.Controls.MetroLabel lblSaludEps;
        private BorderedCombo cboRegSalud;
        private MetroFramework.Controls.MetroLabel lblRegSalud;
        private BorderedCombo cboRegLaboral;
        private MetroFramework.Controls.MetroLabel lblRegLaboral;
        private MetroFramework.Controls.MetroLabel lblSuspLaboral;
        private BorderedCombo cboSuspLaboral;
        private BorderedCombo cboMotivoBaja;
        private MetroFramework.Controls.MetroLabel lblMotivoBaja;
        private MetroFramework.Controls.MetroLabel lblSituacion;
        private BorderedCombo cboSituacion;
        private BorderedCombo cboEspcMedica;
        private MetroFramework.Controls.MetroLabel lblEspcMedica;
        private MetroFramework.Controls.MetroLabel lblSituacionEdu;
        private BorderedCombo cboTipoEspc;
        private BorderedCombo cboSituacionEdu;
        private MetroFramework.Controls.MetroLabel lblTipoEspc;
        private MetroFramework.Controls.MetroLabel lblModalidadFormativa;
        private BorderedCombo cboModalidadFormativa;
        private System.Windows.Forms.ErrorProvider errorProv;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private BorderedCombo cboEntidadFinanciera;
        private System.Windows.Forms.Label lblNumInactivo;
        private System.Windows.Forms.Label lblNumActivo;
        private System.Windows.Forms.Label lblNumReg;
        private BorderedCombo cboClaseEmp;
        private MetroFramework.Controls.MetroLabel lblClaseEmp;
        private MetroFramework.Controls.MetroLabel lblCategoriaEmp;
        private BorderedCombo cboCategoriaEmp;
        private MetroFramework.Controls.MetroLink btnCategoriaEmp;
        private MetroFramework.Controls.MetroLink btnClaseEmp;
        private MetroFramework.Controls.MetroTabPage tabPagDireccion;
        private MetroFramework.Controls.MetroTabPage tabPagEducacion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grbUbicacionDetallada;
        private System.Windows.Forms.GroupBox gbrUbigeo;
        private MetroFramework.Controls.MetroTabPage tabPagTrabajo;
        private System.Windows.Forms.DataGridView dgvTrabajoEmpleado;
        private System.Windows.Forms.Button btnAsignarTrabajo;
        private System.Windows.Forms.Button btnDesasignarTrabajo;
        private BorderedCombo cboTrabajo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.GroupBox grbUser;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroLabel lblDescUsername;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCommit;
    }
}