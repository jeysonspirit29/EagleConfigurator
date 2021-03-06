﻿using ConfigUtilitarios.Controls;

namespace ConfiguradorUI.Producto
{
    partial class FormComboVariable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComboVariable));
            this.lblNumInactivo = new System.Windows.Forms.Label();
            this.lblNumActivo = new System.Windows.Forms.Label();
            this.lblNumReg = new System.Windows.Forms.Label();
            this.lblIdComboVariable = new MetroFramework.Controls.MetroLabel();
            this.panelFiltro = new MetroFramework.Controls.MetroPanel();
            this.lblFiltro = new MetroFramework.Controls.MetroLabel();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtFiltro = new MetroFramework.Controls.MetroTextBox();
            this.cboFiltro = new ConfigUtilitarios.Controls.BorderedCombo();
            this.panelMantenimiento = new MetroFramework.Controls.MetroPanel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnRollback = new System.Windows.Forms.Button();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tglListarInactivos = new MetroFramework.Controls.MetroToggle();
            this.lblListarInactivos = new MetroFramework.Controls.MetroLabel();
            this.tabComboVariable = new MetroFramework.Controls.MetroTabControl();
            this.tabPagGeneral = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblPrecioSinImp = new MetroFramework.Controls.MetroLabel();
            this.lblPrecioConImp = new MetroFramework.Controls.MetroLabel();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.btnBuscarProducto = new MetroFramework.Controls.MetroLink();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtItemCod = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtItemDesc = new MetroFramework.Controls.MetroTextBox();
            this.txtItemQuantity = new MetroFramework.Controls.MetroTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtItemPriceConImp = new MetroFramework.Controls.MetroTextBox();
            this.chkIncluyeImpto = new MetroFramework.Controls.MetroCheckBox();
            this.txtItemPriceSinImp = new MetroFramework.Controls.MetroTextBox();
            this.lblPorcentajeAcumuladoImpto = new System.Windows.Forms.Label();
            this.lblCantidad = new MetroFramework.Controls.MetroLabel();
            this.lblSimboloPorcentaje = new System.Windows.Forms.Label();
            this.cboImpuesto = new ConfigUtilitarios.Controls.BorderedCombo();
            this.lblProducto = new MetroFramework.Controls.MetroLabel();
            this.chkMostrarInactivos = new MetroFramework.Controls.MetroCheckBox();
            this.lblImpuesto = new MetroFramework.Controls.MetroLabel();
            this.btnImpuesto = new MetroFramework.Controls.MetroLink();
            this.dgvDetail = new System.Windows.Forms.DataGridView();
            this.txtPrecioCboSinTax = new MetroFramework.Controls.MetroTextBox();
            this.lblPrecioCboSinTax = new MetroFramework.Controls.MetroLabel();
            this.txtPrecioCboConTax = new MetroFramework.Controls.MetroTextBox();
            this.lblPrecioCboConTax = new MetroFramework.Controls.MetroLabel();
            this.chkActivo = new MetroFramework.Controls.MetroCheckBox();
            this.txtCodigo = new MetroFramework.Controls.MetroTextBox();
            this.lblCodigo = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.lblNombre = new MetroFramework.Controls.MetroLabel();
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvComboVariable = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new MetroFramework.Controls.MetroLink();
            this.errorProvDtl = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelFiltro.SuspendLayout();
            this.panelMantenimiento.SuspendLayout();
            this.tabComboVariable.SuspendLayout();
            this.tabPagGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComboVariable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvDtl)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumInactivo
            // 
            this.lblNumInactivo.AutoSize = true;
            this.lblNumInactivo.BackColor = System.Drawing.Color.Transparent;
            this.lblNumInactivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumInactivo.ForeColor = System.Drawing.Color.Red;
            this.lblNumInactivo.Location = new System.Drawing.Point(178, 573);
            this.lblNumInactivo.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumInactivo.Name = "lblNumInactivo";
            this.lblNumInactivo.Size = new System.Drawing.Size(65, 17);
            this.lblNumInactivo.TabIndex = 140;
            this.lblNumInactivo.Text = "Inactivos: ";
            // 
            // lblNumActivo
            // 
            this.lblNumActivo.AutoSize = true;
            this.lblNumActivo.BackColor = System.Drawing.Color.Transparent;
            this.lblNumActivo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumActivo.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblNumActivo.Location = new System.Drawing.Point(98, 573);
            this.lblNumActivo.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumActivo.Name = "lblNumActivo";
            this.lblNumActivo.Size = new System.Drawing.Size(56, 17);
            this.lblNumActivo.TabIndex = 139;
            this.lblNumActivo.Text = "Activos: ";
            // 
            // lblNumReg
            // 
            this.lblNumReg.AutoSize = true;
            this.lblNumReg.BackColor = System.Drawing.Color.Transparent;
            this.lblNumReg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumReg.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNumReg.Location = new System.Drawing.Point(31, 573);
            this.lblNumReg.MaximumSize = new System.Drawing.Size(550, 1500);
            this.lblNumReg.Name = "lblNumReg";
            this.lblNumReg.Size = new System.Drawing.Size(43, 17);
            this.lblNumReg.TabIndex = 138;
            this.lblNumReg.Text = "Total: ";
            // 
            // lblIdComboVariable
            // 
            this.lblIdComboVariable.AutoSize = true;
            this.lblIdComboVariable.Location = new System.Drawing.Point(551, 30);
            this.lblIdComboVariable.Name = "lblIdComboVariable";
            this.lblIdComboVariable.Size = new System.Drawing.Size(0, 0);
            this.lblIdComboVariable.TabIndex = 137;
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
            this.panelFiltro.Location = new System.Drawing.Point(306, 546);
            this.panelFiltro.Name = "panelFiltro";
            this.panelFiltro.Size = new System.Drawing.Size(671, 44);
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
            this.lblFiltro.Location = new System.Drawing.Point(6, 13);
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
            this.btnFilter.Location = new System.Drawing.Point(629, 6);
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
            this.txtFiltro.CustomButton.Location = new System.Drawing.Point(219, 1);
            this.txtFiltro.CustomButton.Name = "";
            this.txtFiltro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFiltro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFiltro.CustomButton.TabIndex = 1;
            this.txtFiltro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFiltro.CustomButton.UseSelectable = true;
            this.txtFiltro.CustomButton.Visible = false;
            this.txtFiltro.Lines = new string[0];
            this.txtFiltro.Location = new System.Drawing.Point(384, 11);
            this.txtFiltro.MaxLength = 32767;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.PasswordChar = '\0';
            this.txtFiltro.PromptText = "Filtro";
            this.txtFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFiltro.SelectedText = "";
            this.txtFiltro.SelectionLength = 0;
            this.txtFiltro.SelectionStart = 0;
            this.txtFiltro.ShortcutsEnabled = true;
            this.txtFiltro.Size = new System.Drawing.Size(241, 23);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.UseSelectable = true;
            this.txtFiltro.WaterMark = "Filtro";
            this.txtFiltro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFiltro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // cboFiltro
            // 
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboFiltro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Location = new System.Drawing.Point(83, 11);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(213, 23);
            this.cboFiltro.TabIndex = 2;
            this.cboFiltro.SelectedIndexChanged += new System.EventHandler(this.cboFiltro_SelectedIndexChanged);
            // 
            // panelMantenimiento
            // 
            this.panelMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.panelMantenimiento.Controls.Add(this.btnSearch);
            this.panelMantenimiento.Controls.Add(this.btnNuevo);
            this.panelMantenimiento.Controls.Add(this.btnRollback);
            this.panelMantenimiento.Controls.Add(this.btnCommit);
            this.panelMantenimiento.Controls.Add(this.btnDelete);
            this.panelMantenimiento.HorizontalScrollbarBarColor = true;
            this.panelMantenimiento.HorizontalScrollbarHighlightOnWheel = false;
            this.panelMantenimiento.HorizontalScrollbarSize = 10;
            this.panelMantenimiento.Location = new System.Drawing.Point(302, 36);
            this.panelMantenimiento.Name = "panelMantenimiento";
            this.panelMantenimiento.Size = new System.Drawing.Size(675, 49);
            this.panelMantenimiento.Style = MetroFramework.MetroColorStyle.Green;
            this.panelMantenimiento.TabIndex = 2;
            this.panelMantenimiento.UseCustomBackColor = true;
            this.panelMantenimiento.UseStyleColors = true;
            this.panelMantenimiento.VerticalScrollbarBarColor = true;
            this.panelMantenimiento.VerticalScrollbarHighlightOnWheel = false;
            this.panelMantenimiento.VerticalScrollbarSize = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(3, 5);
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
            this.btnNuevo.Location = new System.Drawing.Point(505, 5);
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
            this.btnRollback.Location = new System.Drawing.Point(631, 5);
            this.btnRollback.Name = "btnRollback";
            this.btnRollback.Size = new System.Drawing.Size(40, 40);
            this.btnRollback.TabIndex = 1;
            this.btnRollback.UseVisualStyleBackColor = false;
            this.btnRollback.Click += new System.EventHandler(this.btnRollback_Click);
            // 
            // btnCommit
            // 
            this.btnCommit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCommit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCommit.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCommit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnCommit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommit.Image = ((System.Drawing.Image)(resources.GetObject("btnCommit.Image")));
            this.btnCommit.Location = new System.Drawing.Point(589, 5);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(40, 40);
            this.btnCommit.TabIndex = 0;
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.btnCommit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(547, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tglListarInactivos
            // 
            this.tglListarInactivos.AutoSize = true;
            this.tglListarInactivos.Location = new System.Drawing.Point(131, 104);
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
            this.lblListarInactivos.Location = new System.Drawing.Point(33, 104);
            this.lblListarInactivos.Name = "lblListarInactivos";
            this.lblListarInactivos.Size = new System.Drawing.Size(92, 19);
            this.lblListarInactivos.TabIndex = 133;
            this.lblListarInactivos.Text = "Listar inactivos";
            // 
            // tabComboVariable
            // 
            this.tabComboVariable.Controls.Add(this.tabPagGeneral);
            this.tabComboVariable.Location = new System.Drawing.Point(302, 91);
            this.tabComboVariable.Name = "tabComboVariable";
            this.tabComboVariable.SelectedIndex = 0;
            this.tabComboVariable.Size = new System.Drawing.Size(690, 449);
            this.tabComboVariable.TabIndex = 1;
            this.tabComboVariable.UseSelectable = true;
            // 
            // tabPagGeneral
            // 
            this.tabPagGeneral.Controls.Add(this.metroLabel4);
            this.tabPagGeneral.Controls.Add(this.metroLabel3);
            this.tabPagGeneral.Controls.Add(this.lblPrecioSinImp);
            this.tabPagGeneral.Controls.Add(this.lblPrecioConImp);
            this.tabPagGeneral.Controls.Add(this.btnAddItem);
            this.tabPagGeneral.Controls.Add(this.btnRemoveItem);
            this.tabPagGeneral.Controls.Add(this.btnBuscarProducto);
            this.tabPagGeneral.Controls.Add(this.metroLabel2);
            this.tabPagGeneral.Controls.Add(this.txtItemCod);
            this.tabPagGeneral.Controls.Add(this.metroLabel1);
            this.tabPagGeneral.Controls.Add(this.txtItemDesc);
            this.tabPagGeneral.Controls.Add(this.txtItemQuantity);
            this.tabPagGeneral.Controls.Add(this.panel2);
            this.tabPagGeneral.Controls.Add(this.txtItemPriceConImp);
            this.tabPagGeneral.Controls.Add(this.chkIncluyeImpto);
            this.tabPagGeneral.Controls.Add(this.txtItemPriceSinImp);
            this.tabPagGeneral.Controls.Add(this.lblPorcentajeAcumuladoImpto);
            this.tabPagGeneral.Controls.Add(this.lblCantidad);
            this.tabPagGeneral.Controls.Add(this.lblSimboloPorcentaje);
            this.tabPagGeneral.Controls.Add(this.cboImpuesto);
            this.tabPagGeneral.Controls.Add(this.lblProducto);
            this.tabPagGeneral.Controls.Add(this.chkMostrarInactivos);
            this.tabPagGeneral.Controls.Add(this.lblImpuesto);
            this.tabPagGeneral.Controls.Add(this.btnImpuesto);
            this.tabPagGeneral.Controls.Add(this.dgvDetail);
            this.tabPagGeneral.Controls.Add(this.txtPrecioCboSinTax);
            this.tabPagGeneral.Controls.Add(this.lblPrecioCboSinTax);
            this.tabPagGeneral.Controls.Add(this.txtPrecioCboConTax);
            this.tabPagGeneral.Controls.Add(this.lblPrecioCboConTax);
            this.tabPagGeneral.Controls.Add(this.chkActivo);
            this.tabPagGeneral.Controls.Add(this.txtCodigo);
            this.tabPagGeneral.Controls.Add(this.lblCodigo);
            this.tabPagGeneral.Controls.Add(this.txtNombre);
            this.tabPagGeneral.Controls.Add(this.lblNombre);
            this.tabPagGeneral.HorizontalScrollbarBarColor = true;
            this.tabPagGeneral.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.HorizontalScrollbarSize = 10;
            this.tabPagGeneral.Location = new System.Drawing.Point(4, 38);
            this.tabPagGeneral.Name = "tabPagGeneral";
            this.tabPagGeneral.Size = new System.Drawing.Size(682, 407);
            this.tabPagGeneral.TabIndex = 0;
            this.tabPagGeneral.Text = "General";
            this.tabPagGeneral.VerticalScrollbarBarColor = true;
            this.tabPagGeneral.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagGeneral.VerticalScrollbarSize = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel4.Location = new System.Drawing.Point(533, 67);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 170;
            this.metroLabel4.Text = "Precio sin";
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel3.Location = new System.Drawing.Point(434, 67);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 19);
            this.metroLabel3.TabIndex = 169;
            this.metroLabel3.Text = "Precio con";
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // lblPrecioSinImp
            // 
            this.lblPrecioSinImp.AutoSize = true;
            this.lblPrecioSinImp.ForeColor = System.Drawing.Color.Navy;
            this.lblPrecioSinImp.Location = new System.Drawing.Point(533, 83);
            this.lblPrecioSinImp.MaximumSize = new System.Drawing.Size(100, 50);
            this.lblPrecioSinImp.Name = "lblPrecioSinImp";
            this.lblPrecioSinImp.Size = new System.Drawing.Size(63, 19);
            this.lblPrecioSinImp.TabIndex = 168;
            this.lblPrecioSinImp.Text = "impuesto";
            this.lblPrecioSinImp.UseCustomForeColor = true;
            // 
            // lblPrecioConImp
            // 
            this.lblPrecioConImp.AutoSize = true;
            this.lblPrecioConImp.ForeColor = System.Drawing.Color.Navy;
            this.lblPrecioConImp.Location = new System.Drawing.Point(434, 83);
            this.lblPrecioConImp.MaximumSize = new System.Drawing.Size(100, 50);
            this.lblPrecioConImp.Name = "lblPrecioConImp";
            this.lblPrecioConImp.Size = new System.Drawing.Size(63, 19);
            this.lblPrecioConImp.TabIndex = 167;
            this.lblPrecioConImp.Text = "impuesto";
            this.lblPrecioConImp.UseCustomForeColor = true;
            // 
            // btnAddItem
            // 
            this.btnAddItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddItem.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAddItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddItem.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItem.Image")));
            this.btnAddItem.Location = new System.Drawing.Point(632, 99);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(33, 29);
            this.btnAddItem.TabIndex = 7;
            this.btnAddItem.UseVisualStyleBackColor = false;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.BackColor = System.Drawing.Color.IndianRed;
            this.btnRemoveItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemoveItem.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.btnRemoveItem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemoveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItem.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveItem.Image")));
            this.btnRemoveItem.Location = new System.Drawing.Point(632, 64);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(33, 29);
            this.btnRemoveItem.TabIndex = 8;
            this.btnRemoveItem.UseVisualStyleBackColor = false;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProducto.Image")));
            this.btnBuscarProducto.ImageSize = 20;
            this.btnBuscarProducto.Location = new System.Drawing.Point(60, 78);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(20, 24);
            this.btnBuscarProducto.TabIndex = 15;
            this.btnBuscarProducto.UseCustomBackColor = true;
            this.btnBuscarProducto.UseSelectable = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel2.Location = new System.Drawing.Point(3, 83);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 142;
            this.metroLabel2.Text = "Código";
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // txtItemCod
            // 
            this.txtItemCod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtItemCod.CustomButton.Image = null;
            this.txtItemCod.CustomButton.Location = new System.Drawing.Point(52, 1);
            this.txtItemCod.CustomButton.Name = "";
            this.txtItemCod.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemCod.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemCod.CustomButton.TabIndex = 1;
            this.txtItemCod.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemCod.CustomButton.UseSelectable = true;
            this.txtItemCod.CustomButton.Visible = false;
            this.txtItemCod.Lines = new string[0];
            this.txtItemCod.Location = new System.Drawing.Point(6, 105);
            this.txtItemCod.MaxLength = 32767;
            this.txtItemCod.Name = "txtItemCod";
            this.txtItemCod.PasswordChar = '\0';
            this.txtItemCod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemCod.SelectedText = "";
            this.txtItemCod.SelectionLength = 0;
            this.txtItemCod.SelectionStart = 0;
            this.txtItemCod.ShortcutsEnabled = true;
            this.txtItemCod.Size = new System.Drawing.Size(74, 23);
            this.txtItemCod.TabIndex = 2;
            this.txtItemCod.UseCustomBackColor = true;
            this.txtItemCod.UseSelectable = true;
            this.txtItemCod.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemCod.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.ForeColor = System.Drawing.Color.Navy;
            this.metroLabel1.Location = new System.Drawing.Point(-1, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 158;
            this.metroLabel1.Text = "Combo detalle";
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // txtItemDesc
            // 
            this.txtItemDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtItemDesc.CustomButton.Image = null;
            this.txtItemDesc.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.txtItemDesc.CustomButton.Name = "";
            this.txtItemDesc.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemDesc.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemDesc.CustomButton.TabIndex = 1;
            this.txtItemDesc.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemDesc.CustomButton.UseSelectable = true;
            this.txtItemDesc.CustomButton.Visible = false;
            this.txtItemDesc.Lines = new string[0];
            this.txtItemDesc.Location = new System.Drawing.Point(86, 105);
            this.txtItemDesc.MaxLength = 32767;
            this.txtItemDesc.Name = "txtItemDesc";
            this.txtItemDesc.PasswordChar = '\0';
            this.txtItemDesc.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemDesc.SelectedText = "";
            this.txtItemDesc.SelectionLength = 0;
            this.txtItemDesc.SelectionStart = 0;
            this.txtItemDesc.ShortcutsEnabled = true;
            this.txtItemDesc.Size = new System.Drawing.Size(243, 23);
            this.txtItemDesc.TabIndex = 3;
            this.txtItemDesc.UseCustomBackColor = true;
            this.txtItemDesc.UseSelectable = true;
            this.txtItemDesc.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemDesc.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtItemQuantity
            // 
            this.txtItemQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtItemQuantity.CustomButton.Image = null;
            this.txtItemQuantity.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txtItemQuantity.CustomButton.Name = "";
            this.txtItemQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemQuantity.CustomButton.TabIndex = 1;
            this.txtItemQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemQuantity.CustomButton.UseSelectable = true;
            this.txtItemQuantity.CustomButton.Visible = false;
            this.txtItemQuantity.Lines = new string[0];
            this.txtItemQuantity.Location = new System.Drawing.Point(335, 105);
            this.txtItemQuantity.MaxLength = 32767;
            this.txtItemQuantity.Name = "txtItemQuantity";
            this.txtItemQuantity.PasswordChar = '\0';
            this.txtItemQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemQuantity.SelectedText = "";
            this.txtItemQuantity.SelectionLength = 0;
            this.txtItemQuantity.SelectionStart = 0;
            this.txtItemQuantity.ShortcutsEnabled = true;
            this.txtItemQuantity.Size = new System.Drawing.Size(93, 23);
            this.txtItemQuantity.TabIndex = 4;
            this.txtItemQuantity.UseCustomBackColor = true;
            this.txtItemQuantity.UseSelectable = true;
            this.txtItemQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtItemQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemQuantity_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ConfiguradorUI.Properties.Resources.linea_celeste;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(110, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(555, 5);
            this.panel2.TabIndex = 157;
            // 
            // txtItemPriceConImp
            // 
            this.txtItemPriceConImp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtItemPriceConImp.CustomButton.Image = null;
            this.txtItemPriceConImp.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txtItemPriceConImp.CustomButton.Name = "";
            this.txtItemPriceConImp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemPriceConImp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemPriceConImp.CustomButton.TabIndex = 1;
            this.txtItemPriceConImp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemPriceConImp.CustomButton.UseSelectable = true;
            this.txtItemPriceConImp.CustomButton.Visible = false;
            this.txtItemPriceConImp.Lines = new string[0];
            this.txtItemPriceConImp.Location = new System.Drawing.Point(434, 105);
            this.txtItemPriceConImp.MaxLength = 32767;
            this.txtItemPriceConImp.Name = "txtItemPriceConImp";
            this.txtItemPriceConImp.PasswordChar = '\0';
            this.txtItemPriceConImp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemPriceConImp.SelectedText = "";
            this.txtItemPriceConImp.SelectionLength = 0;
            this.txtItemPriceConImp.SelectionStart = 0;
            this.txtItemPriceConImp.ShortcutsEnabled = true;
            this.txtItemPriceConImp.Size = new System.Drawing.Size(93, 23);
            this.txtItemPriceConImp.TabIndex = 5;
            this.txtItemPriceConImp.UseCustomBackColor = true;
            this.txtItemPriceConImp.UseSelectable = true;
            this.txtItemPriceConImp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemPriceConImp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkIncluyeImpto
            // 
            this.chkIncluyeImpto.AutoSize = true;
            this.chkIncluyeImpto.Checked = true;
            this.chkIncluyeImpto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIncluyeImpto.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkIncluyeImpto.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkIncluyeImpto.ForeColor = System.Drawing.Color.Navy;
            this.chkIncluyeImpto.Location = new System.Drawing.Point(6, 367);
            this.chkIncluyeImpto.Name = "chkIncluyeImpto";
            this.chkIncluyeImpto.Size = new System.Drawing.Size(163, 19);
            this.chkIncluyeImpto.TabIndex = 13;
            this.chkIncluyeImpto.Text = "Precio incluye impuesto";
            this.chkIncluyeImpto.UseCustomForeColor = true;
            this.chkIncluyeImpto.UseSelectable = true;
            this.chkIncluyeImpto.CheckedChanged += new System.EventHandler(this.chkIncluyeImpto_CheckedChanged);
            // 
            // txtItemPriceSinImp
            // 
            this.txtItemPriceSinImp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtItemPriceSinImp.CustomButton.Image = null;
            this.txtItemPriceSinImp.CustomButton.Location = new System.Drawing.Point(71, 1);
            this.txtItemPriceSinImp.CustomButton.Name = "";
            this.txtItemPriceSinImp.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtItemPriceSinImp.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtItemPriceSinImp.CustomButton.TabIndex = 1;
            this.txtItemPriceSinImp.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtItemPriceSinImp.CustomButton.UseSelectable = true;
            this.txtItemPriceSinImp.CustomButton.Visible = false;
            this.txtItemPriceSinImp.Lines = new string[0];
            this.txtItemPriceSinImp.Location = new System.Drawing.Point(533, 105);
            this.txtItemPriceSinImp.MaxLength = 32767;
            this.txtItemPriceSinImp.Name = "txtItemPriceSinImp";
            this.txtItemPriceSinImp.PasswordChar = '\0';
            this.txtItemPriceSinImp.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtItemPriceSinImp.SelectedText = "";
            this.txtItemPriceSinImp.SelectionLength = 0;
            this.txtItemPriceSinImp.SelectionStart = 0;
            this.txtItemPriceSinImp.ShortcutsEnabled = true;
            this.txtItemPriceSinImp.Size = new System.Drawing.Size(93, 23);
            this.txtItemPriceSinImp.TabIndex = 6;
            this.txtItemPriceSinImp.UseCustomBackColor = true;
            this.txtItemPriceSinImp.UseSelectable = true;
            this.txtItemPriceSinImp.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtItemPriceSinImp.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPorcentajeAcumuladoImpto
            // 
            this.lblPorcentajeAcumuladoImpto.BackColor = System.Drawing.Color.Transparent;
            this.lblPorcentajeAcumuladoImpto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcentajeAcumuladoImpto.ForeColor = System.Drawing.Color.Navy;
            this.lblPorcentajeAcumuladoImpto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPorcentajeAcumuladoImpto.Location = new System.Drawing.Point(85, 341);
            this.lblPorcentajeAcumuladoImpto.Name = "lblPorcentajeAcumuladoImpto";
            this.lblPorcentajeAcumuladoImpto.Size = new System.Drawing.Size(176, 23);
            this.lblPorcentajeAcumuladoImpto.TabIndex = 146;
            this.lblPorcentajeAcumuladoImpto.Text = "0";
            this.lblPorcentajeAcumuladoImpto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidad.ForeColor = System.Drawing.Color.Navy;
            this.lblCantidad.Location = new System.Drawing.Point(335, 83);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(62, 19);
            this.lblCantidad.TabIndex = 137;
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.UseCustomBackColor = true;
            this.lblCantidad.UseCustomForeColor = true;
            // 
            // lblSimboloPorcentaje
            // 
            this.lblSimboloPorcentaje.AutoSize = true;
            this.lblSimboloPorcentaje.BackColor = System.Drawing.Color.Transparent;
            this.lblSimboloPorcentaje.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSimboloPorcentaje.ForeColor = System.Drawing.Color.Navy;
            this.lblSimboloPorcentaje.Location = new System.Drawing.Point(267, 344);
            this.lblSimboloPorcentaje.Name = "lblSimboloPorcentaje";
            this.lblSimboloPorcentaje.Size = new System.Drawing.Size(19, 17);
            this.lblSimboloPorcentaje.TabIndex = 145;
            this.lblSimboloPorcentaje.Text = "%";
            // 
            // cboImpuesto
            // 
            this.cboImpuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.cboImpuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboImpuesto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboImpuesto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboImpuesto.FormattingEnabled = true;
            this.cboImpuesto.Location = new System.Drawing.Point(83, 318);
            this.cboImpuesto.Name = "cboImpuesto";
            this.cboImpuesto.Size = new System.Drawing.Size(178, 23);
            this.cboImpuesto.TabIndex = 12;
            this.cboImpuesto.SelectedIndexChanged += new System.EventHandler(this.cboImpuesto_SelectedIndexChanged);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.Transparent;
            this.lblProducto.ForeColor = System.Drawing.Color.Navy;
            this.lblProducto.Location = new System.Drawing.Point(86, 83);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(113, 19);
            this.lblProducto.TabIndex = 131;
            this.lblProducto.Text = "Descrip. Producto";
            this.lblProducto.UseCustomBackColor = true;
            this.lblProducto.UseCustomForeColor = true;
            // 
            // chkMostrarInactivos
            // 
            this.chkMostrarInactivos.AutoSize = true;
            this.chkMostrarInactivos.BackColor = System.Drawing.Color.Transparent;
            this.chkMostrarInactivos.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkMostrarInactivos.ForeColor = System.Drawing.Color.Navy;
            this.chkMostrarInactivos.Location = new System.Drawing.Point(6, 130);
            this.chkMostrarInactivos.Name = "chkMostrarInactivos";
            this.chkMostrarInactivos.Size = new System.Drawing.Size(108, 15);
            this.chkMostrarInactivos.TabIndex = 16;
            this.chkMostrarInactivos.Text = "Mostrar inactivos";
            this.chkMostrarInactivos.UseCustomBackColor = true;
            this.chkMostrarInactivos.UseCustomForeColor = true;
            this.chkMostrarInactivos.UseSelectable = true;
            this.chkMostrarInactivos.CheckedChanged += new System.EventHandler(this.chkMostrarInactivos_CheckedChanged);
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.AutoSize = true;
            this.lblImpuesto.BackColor = System.Drawing.Color.Transparent;
            this.lblImpuesto.ForeColor = System.Drawing.Color.Navy;
            this.lblImpuesto.Location = new System.Drawing.Point(6, 320);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(66, 19);
            this.lblImpuesto.TabIndex = 142;
            this.lblImpuesto.Text = "Impuesto:";
            this.lblImpuesto.UseCustomForeColor = true;
            // 
            // btnImpuesto
            // 
            this.btnImpuesto.Image = ((System.Drawing.Image)(resources.GetObject("btnImpuesto.Image")));
            this.btnImpuesto.ImageSize = 24;
            this.btnImpuesto.Location = new System.Drawing.Point(267, 314);
            this.btnImpuesto.Name = "btnImpuesto";
            this.btnImpuesto.Size = new System.Drawing.Size(29, 27);
            this.btnImpuesto.TabIndex = 17;
            this.btnImpuesto.UseSelectable = true;
            this.btnImpuesto.Click += new System.EventHandler(this.btnImpuesto_Click);
            // 
            // dgvDetail
            // 
            this.dgvDetail.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail.Location = new System.Drawing.Point(6, 147);
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.Size = new System.Drawing.Size(659, 163);
            this.dgvDetail.TabIndex = 9;
            this.dgvDetail.DataSourceChanged += new System.EventHandler(this.CambioEnControl);
            this.dgvDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellContentClick);
            this.dgvDetail.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_CellDoubleClick);
            this.dgvDetail.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvDetail_Paint);
            this.dgvDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDetail_KeyDown);
            // 
            // txtPrecioCboSinTax
            // 
            this.txtPrecioCboSinTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPrecioCboSinTax.CustomButton.Image = null;
            this.txtPrecioCboSinTax.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtPrecioCboSinTax.CustomButton.Name = "";
            this.txtPrecioCboSinTax.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecioCboSinTax.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecioCboSinTax.CustomButton.TabIndex = 1;
            this.txtPrecioCboSinTax.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecioCboSinTax.CustomButton.UseSelectable = true;
            this.txtPrecioCboSinTax.CustomButton.Visible = false;
            this.txtPrecioCboSinTax.Lines = new string[0];
            this.txtPrecioCboSinTax.Location = new System.Drawing.Point(539, 345);
            this.txtPrecioCboSinTax.MaxLength = 32767;
            this.txtPrecioCboSinTax.Name = "txtPrecioCboSinTax";
            this.txtPrecioCboSinTax.PasswordChar = '\0';
            this.txtPrecioCboSinTax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioCboSinTax.SelectedText = "";
            this.txtPrecioCboSinTax.SelectionLength = 0;
            this.txtPrecioCboSinTax.SelectionStart = 0;
            this.txtPrecioCboSinTax.ShortcutsEnabled = true;
            this.txtPrecioCboSinTax.Size = new System.Drawing.Size(126, 23);
            this.txtPrecioCboSinTax.TabIndex = 11;
            this.txtPrecioCboSinTax.UseCustomBackColor = true;
            this.txtPrecioCboSinTax.UseSelectable = true;
            this.txtPrecioCboSinTax.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecioCboSinTax.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioCboSinTax.TextChanged += new System.EventHandler(this.txtPrecioCboSinTax_TextChanged);
            // 
            // lblPrecioCboSinTax
            // 
            this.lblPrecioCboSinTax.AutoSize = true;
            this.lblPrecioCboSinTax.ForeColor = System.Drawing.Color.Navy;
            this.lblPrecioCboSinTax.Location = new System.Drawing.Point(379, 347);
            this.lblPrecioCboSinTax.Name = "lblPrecioCboSinTax";
            this.lblPrecioCboSinTax.Size = new System.Drawing.Size(155, 19);
            this.lblPrecioCboSinTax.TabIndex = 135;
            this.lblPrecioCboSinTax.Text = "Precio cbo. sin impuesto:";
            this.lblPrecioCboSinTax.UseCustomForeColor = true;
            // 
            // txtPrecioCboConTax
            // 
            this.txtPrecioCboConTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPrecioCboConTax.CustomButton.Image = null;
            this.txtPrecioCboConTax.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtPrecioCboConTax.CustomButton.Name = "";
            this.txtPrecioCboConTax.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecioCboConTax.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecioCboConTax.CustomButton.TabIndex = 1;
            this.txtPrecioCboConTax.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecioCboConTax.CustomButton.UseSelectable = true;
            this.txtPrecioCboConTax.CustomButton.Visible = false;
            this.txtPrecioCboConTax.Lines = new string[0];
            this.txtPrecioCboConTax.Location = new System.Drawing.Point(539, 316);
            this.txtPrecioCboConTax.MaxLength = 32767;
            this.txtPrecioCboConTax.Name = "txtPrecioCboConTax";
            this.txtPrecioCboConTax.PasswordChar = '\0';
            this.txtPrecioCboConTax.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecioCboConTax.SelectedText = "";
            this.txtPrecioCboConTax.SelectionLength = 0;
            this.txtPrecioCboConTax.SelectionStart = 0;
            this.txtPrecioCboConTax.ShortcutsEnabled = true;
            this.txtPrecioCboConTax.Size = new System.Drawing.Size(126, 23);
            this.txtPrecioCboConTax.TabIndex = 10;
            this.txtPrecioCboConTax.UseCustomBackColor = true;
            this.txtPrecioCboConTax.UseSelectable = true;
            this.txtPrecioCboConTax.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecioCboConTax.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrecioCboConTax.TextChanged += new System.EventHandler(this.txtPrecioCboConTax_TextChanged);
            // 
            // lblPrecioCboConTax
            // 
            this.lblPrecioCboConTax.AutoSize = true;
            this.lblPrecioCboConTax.ForeColor = System.Drawing.Color.Navy;
            this.lblPrecioCboConTax.Location = new System.Drawing.Point(379, 318);
            this.lblPrecioCboConTax.Name = "lblPrecioCboConTax";
            this.lblPrecioCboConTax.Size = new System.Drawing.Size(161, 19);
            this.lblPrecioCboConTax.TabIndex = 133;
            this.lblPrecioCboConTax.Text = "Precio cbo. con impuesto:";
            this.lblPrecioCboConTax.UseCustomForeColor = true;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkActivo.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkActivo.ForeColor = System.Drawing.Color.Navy;
            this.chkActivo.Location = new System.Drawing.Point(6, 391);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(61, 19);
            this.chkActivo.TabIndex = 14;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseCustomForeColor = true;
            this.chkActivo.UseSelectable = true;
            this.chkActivo.CheckedChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtCodigo.CustomButton.Image = null;
            this.txtCodigo.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txtCodigo.CustomButton.Name = "";
            this.txtCodigo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCodigo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCodigo.CustomButton.TabIndex = 1;
            this.txtCodigo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCodigo.CustomButton.UseSelectable = true;
            this.txtCodigo.CustomButton.Visible = false;
            this.txtCodigo.Lines = new string[0];
            this.txtCodigo.Location = new System.Drawing.Point(446, 14);
            this.txtCodigo.MaxLength = 32767;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.ShortcutsEnabled = true;
            this.txtCodigo.Size = new System.Drawing.Size(219, 23);
            this.txtCodigo.TabIndex = 1;
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
            this.lblCodigo.Location = new System.Drawing.Point(381, 16);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(56, 19);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "Código:";
            this.lblCodigo.UseCustomForeColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(77, 14);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(219, 23);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.UseCustomBackColor = true;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.TextChanged += new System.EventHandler(this.CambioEnControl);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.ForeColor = System.Drawing.Color.Navy;
            this.lblNombre.Location = new System.Drawing.Point(-1, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(62, 19);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.UseCustomForeColor = true;
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(90, 40);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(197, 32);
            this.lblNombreForm.TabIndex = 136;
            this.lblNombreForm.Text = "Combos electivos";
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // dgvComboVariable
            // 
            this.dgvComboVariable.AllowUserToAddRows = false;
            this.dgvComboVariable.AllowUserToResizeColumns = false;
            this.dgvComboVariable.AllowUserToResizeRows = false;
            this.dgvComboVariable.BackgroundColor = System.Drawing.Color.White;
            this.dgvComboVariable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComboVariable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvComboVariable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvComboVariable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvComboVariable.Location = new System.Drawing.Point(33, 129);
            this.dgvComboVariable.MultiSelect = false;
            this.dgvComboVariable.Name = "dgvComboVariable";
            this.dgvComboVariable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvComboVariable.RowHeadersVisible = false;
            this.dgvComboVariable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvComboVariable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComboVariable.Size = new System.Drawing.Size(222, 441);
            this.dgvComboVariable.TabIndex = 0;
            this.dgvComboVariable.SelectionChanged += new System.EventHandler(this.dgvComboVariable_SelectionChanged);
            this.dgvComboVariable.Paint += new System.Windows.Forms.PaintEventHandler(this.dgvBordered_Paint);
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
            // errorProvDtl
            // 
            this.errorProvDtl.ContainerControl = this;
            // 
            // FormComboVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 622);
            this.Controls.Add(this.dgvComboVariable);
            this.Controls.Add(this.lblNumInactivo);
            this.Controls.Add(this.lblNumActivo);
            this.Controls.Add(this.lblNumReg);
            this.Controls.Add(this.lblIdComboVariable);
            this.Controls.Add(this.panelFiltro);
            this.Controls.Add(this.panelMantenimiento);
            this.Controls.Add(this.tglListarInactivos);
            this.Controls.Add(this.lblListarInactivos);
            this.Controls.Add(this.lblNombreForm);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.tabComboVariable);
            this.MaximizeBox = false;
            this.Name = "FormComboVariable";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FormComboVariable_Load);
            this.panelFiltro.ResumeLayout(false);
            this.panelFiltro.PerformLayout();
            this.panelMantenimiento.ResumeLayout(false);
            this.tabComboVariable.ResumeLayout(false);
            this.tabPagGeneral.ResumeLayout(false);
            this.tabPagGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComboVariable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvDtl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumInactivo;
        private System.Windows.Forms.Label lblNumActivo;
        private System.Windows.Forms.Label lblNumReg;
        private MetroFramework.Controls.MetroLabel lblIdComboVariable;
        private MetroFramework.Controls.MetroPanel panelFiltro;
        private MetroFramework.Controls.MetroLabel lblFiltro;
        private System.Windows.Forms.Button btnFilter;
        private MetroFramework.Controls.MetroTextBox txtFiltro;
        private BorderedCombo cboFiltro;
        private MetroFramework.Controls.MetroPanel panelMantenimiento;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnRollback;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnDelete;
        private MetroFramework.Controls.MetroToggle tglListarInactivos;
        private MetroFramework.Controls.MetroLabel lblListarInactivos;
        private MetroFramework.Controls.MetroTabControl tabComboVariable;
        private MetroFramework.Controls.MetroTabPage tabPagGeneral;
        private MetroFramework.Controls.MetroTextBox txtItemPriceConImp;
        private MetroFramework.Controls.MetroTextBox txtItemQuantity;
        private MetroFramework.Controls.MetroLabel lblCantidad;
        private MetroFramework.Controls.MetroTextBox txtPrecioCboSinTax;
        private MetroFramework.Controls.MetroLabel lblPrecioCboSinTax;
        private MetroFramework.Controls.MetroTextBox txtPrecioCboConTax;
        private MetroFramework.Controls.MetroLabel lblPrecioCboConTax;
        private MetroFramework.Controls.MetroTextBox txtItemDesc;
        private MetroFramework.Controls.MetroLabel lblProducto;
        private MetroFramework.Controls.MetroCheckBox chkActivo;
        private MetroFramework.Controls.MetroTextBox txtCodigo;
        private MetroFramework.Controls.MetroLabel lblCodigo;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroLabel lblNombre;
        private System.Windows.Forms.Label lblNombreForm;
        private MetroFramework.Controls.MetroLink btnCerrar;
        private MetroFramework.Controls.MetroTextBox txtItemCod;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ErrorProvider errorProv;
        private MetroFramework.Controls.MetroTextBox txtItemPriceSinImp;
        private System.Windows.Forms.DataGridView dgvDetail;
        private System.Windows.Forms.DataGridView dgvComboVariable;
        private MetroFramework.Controls.MetroLink btnBuscarProducto;
        private System.Windows.Forms.ErrorProvider errorProvDtl;
        private MetroFramework.Controls.MetroCheckBox chkMostrarInactivos;
        private System.Windows.Forms.Label lblPorcentajeAcumuladoImpto;
        private System.Windows.Forms.Label lblSimboloPorcentaje;
        private BorderedCombo cboImpuesto;
        private MetroFramework.Controls.MetroLabel lblImpuesto;
        private MetroFramework.Controls.MetroLink btnImpuesto;
        private MetroFramework.Controls.MetroCheckBox chkIncluyeImpto;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnRemoveItem;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblPrecioSinImp;
        private MetroFramework.Controls.MetroLabel lblPrecioConImp;
    }
}