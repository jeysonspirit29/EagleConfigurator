﻿namespace ConfiguradorUI.Seguridad
{
    partial class FormConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfiguracion));
            this.lblNombreForm = new System.Windows.Forms.Label();
            this.btnCerrar = new MetroFramework.Controls.MetroLink();
            this.tabConfiguracion = new MetroFramework.Controls.MetroTabControl();
            this.tabPagEmail = new MetroFramework.Controls.MetroTabPage();
            this.grbConfiguracionMensajes = new System.Windows.Forms.GroupBox();
            this.txtAddMsjCredentials = new System.Windows.Forms.TextBox();
            this.txtAddMsjRegister = new System.Windows.Forms.TextBox();
            this.lblAddMsjCredentials = new MetroFramework.Controls.MetroLabel();
            this.lblSubjectCredentials = new MetroFramework.Controls.MetroLabel();
            this.txtSubjectCredentials = new MetroFramework.Controls.MetroTextBox();
            this.chkSendMailPostRegister = new MetroFramework.Controls.MetroCheckBox();
            this.lblAddMsjRegister = new MetroFramework.Controls.MetroLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubjectRegister = new MetroFramework.Controls.MetroLabel();
            this.txtSubjectRegister = new MetroFramework.Controls.MetroTextBox();
            this.grbCredencialesSistema = new System.Windows.Forms.GroupBox();
            this.lblContrasena = new MetroFramework.Controls.MetroLabel();
            this.txtContrasena = new MetroFramework.Controls.MetroTextBox();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.lblDisplayNameEmail = new MetroFramework.Controls.MetroLabel();
            this.txtDisplayNameEmail = new MetroFramework.Controls.MetroTextBox();
            this.grbServidorCorreo = new System.Windows.Forms.GroupBox();
            this.lblPort = new MetroFramework.Controls.MetroLabel();
            this.txtPort = new MetroFramework.Controls.MetroTextBox();
            this.lblMailServer = new MetroFramework.Controls.MetroLabel();
            this.txtMailServer = new MetroFramework.Controls.MetroTextBox();
            this.tabPagDiseno = new MetroFramework.Controls.MetroTabPage();
            this.grbLogo = new System.Windows.Forms.GroupBox();
            this.btnCambiarLogo = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.grbImagenLogin = new System.Windows.Forms.GroupBox();
            this.btnCambiarImagenLogin = new System.Windows.Forms.Button();
            this.picImagenLogin = new System.Windows.Forms.PictureBox();
            this.grbSplash = new System.Windows.Forms.GroupBox();
            this.btnCambiarSplash = new System.Windows.Forms.Button();
            this.picSplash = new System.Windows.Forms.PictureBox();
            this.tabPagBaseDeDatos = new MetroFramework.Controls.MetroTabPage();
            this.grbBackupRestore = new System.Windows.Forms.GroupBox();
            this.chkHabilitarRestore = new MetroFramework.Controls.MetroCheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblCodParametro = new System.Windows.Forms.Label();
            this.lblDescripcionParametro = new System.Windows.Forms.Label();
            this.tabConfiguracion.SuspendLayout();
            this.tabPagEmail.SuspendLayout();
            this.grbConfiguracionMensajes.SuspendLayout();
            this.grbCredencialesSistema.SuspendLayout();
            this.grbServidorCorreo.SuspendLayout();
            this.tabPagDiseno.SuspendLayout();
            this.grbLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.grbImagenLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenLogin)).BeginInit();
            this.grbSplash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSplash)).BeginInit();
            this.tabPagBaseDeDatos.SuspendLayout();
            this.grbBackupRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreForm
            // 
            this.lblNombreForm.AutoSize = true;
            this.lblNombreForm.Font = new System.Drawing.Font("Segoe UI Semilight", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreForm.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblNombreForm.Location = new System.Drawing.Point(96, 40);
            this.lblNombreForm.Name = "lblNombreForm";
            this.lblNombreForm.Size = new System.Drawing.Size(281, 32);
            this.lblNombreForm.TabIndex = 110;
            this.lblNombreForm.Text = "Configuración del sistema";
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageSize = 48;
            this.btnCerrar.Location = new System.Drawing.Point(34, 27);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(56, 57);
            this.btnCerrar.TabIndex = 109;
            this.btnCerrar.UseSelectable = true;
            // 
            // tabConfiguracion
            // 
            this.tabConfiguracion.Controls.Add(this.tabPagEmail);
            this.tabConfiguracion.Controls.Add(this.tabPagDiseno);
            this.tabConfiguracion.Controls.Add(this.tabPagBaseDeDatos);
            this.tabConfiguracion.Location = new System.Drawing.Point(37, 89);
            this.tabConfiguracion.Name = "tabConfiguracion";
            this.tabConfiguracion.SelectedIndex = 0;
            this.tabConfiguracion.Size = new System.Drawing.Size(567, 389);
            this.tabConfiguracion.TabIndex = 111;
            this.tabConfiguracion.UseSelectable = true;
            // 
            // tabPagEmail
            // 
            this.tabPagEmail.Controls.Add(this.grbConfiguracionMensajes);
            this.tabPagEmail.Controls.Add(this.grbCredencialesSistema);
            this.tabPagEmail.Controls.Add(this.grbServidorCorreo);
            this.tabPagEmail.HorizontalScrollbarBarColor = true;
            this.tabPagEmail.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagEmail.HorizontalScrollbarSize = 10;
            this.tabPagEmail.Location = new System.Drawing.Point(4, 38);
            this.tabPagEmail.Name = "tabPagEmail";
            this.tabPagEmail.Size = new System.Drawing.Size(559, 347);
            this.tabPagEmail.TabIndex = 0;
            this.tabPagEmail.Text = "Email";
            this.tabPagEmail.VerticalScrollbarBarColor = true;
            this.tabPagEmail.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagEmail.VerticalScrollbarSize = 10;
            // 
            // grbConfiguracionMensajes
            // 
            this.grbConfiguracionMensajes.BackColor = System.Drawing.Color.White;
            this.grbConfiguracionMensajes.Controls.Add(this.txtAddMsjCredentials);
            this.grbConfiguracionMensajes.Controls.Add(this.txtAddMsjRegister);
            this.grbConfiguracionMensajes.Controls.Add(this.lblAddMsjCredentials);
            this.grbConfiguracionMensajes.Controls.Add(this.lblSubjectCredentials);
            this.grbConfiguracionMensajes.Controls.Add(this.txtSubjectCredentials);
            this.grbConfiguracionMensajes.Controls.Add(this.chkSendMailPostRegister);
            this.grbConfiguracionMensajes.Controls.Add(this.lblAddMsjRegister);
            this.grbConfiguracionMensajes.Controls.Add(this.label1);
            this.grbConfiguracionMensajes.Controls.Add(this.lblSubjectRegister);
            this.grbConfiguracionMensajes.Controls.Add(this.txtSubjectRegister);
            this.grbConfiguracionMensajes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbConfiguracionMensajes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbConfiguracionMensajes.Location = new System.Drawing.Point(254, 12);
            this.grbConfiguracionMensajes.Name = "grbConfiguracionMensajes";
            this.grbConfiguracionMensajes.Size = new System.Drawing.Size(302, 329);
            this.grbConfiguracionMensajes.TabIndex = 7;
            this.grbConfiguracionMensajes.TabStop = false;
            this.grbConfiguracionMensajes.Text = "Configuración de mensajes";
            // 
            // txtAddMsjCredentials
            // 
            this.txtAddMsjCredentials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtAddMsjCredentials.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddMsjCredentials.Location = new System.Drawing.Point(16, 268);
            this.txtAddMsjCredentials.Multiline = true;
            this.txtAddMsjCredentials.Name = "txtAddMsjCredentials";
            this.txtAddMsjCredentials.Size = new System.Drawing.Size(264, 46);
            this.txtAddMsjCredentials.TabIndex = 17;
            // 
            // txtAddMsjRegister
            // 
            this.txtAddMsjRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            this.txtAddMsjRegister.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddMsjRegister.Location = new System.Drawing.Point(16, 96);
            this.txtAddMsjRegister.Multiline = true;
            this.txtAddMsjRegister.Name = "txtAddMsjRegister";
            this.txtAddMsjRegister.Size = new System.Drawing.Size(264, 46);
            this.txtAddMsjRegister.TabIndex = 16;
            // 
            // lblAddMsjCredentials
            // 
            this.lblAddMsjCredentials.AutoSize = true;
            this.lblAddMsjCredentials.ForeColor = System.Drawing.Color.Navy;
            this.lblAddMsjCredentials.Location = new System.Drawing.Point(16, 246);
            this.lblAddMsjCredentials.Name = "lblAddMsjCredentials";
            this.lblAddMsjCredentials.Size = new System.Drawing.Size(250, 19);
            this.lblAddMsjCredentials.TabIndex = 14;
            this.lblAddMsjCredentials.Text = "Adjuntar mensaje - Envío de credenciales";
            this.lblAddMsjCredentials.UseCustomForeColor = true;
            // 
            // lblSubjectCredentials
            // 
            this.lblSubjectCredentials.AutoSize = true;
            this.lblSubjectCredentials.ForeColor = System.Drawing.Color.Navy;
            this.lblSubjectCredentials.Location = new System.Drawing.Point(16, 198);
            this.lblSubjectCredentials.Name = "lblSubjectCredentials";
            this.lblSubjectCredentials.Size = new System.Drawing.Size(188, 19);
            this.lblSubjectCredentials.TabIndex = 12;
            this.lblSubjectCredentials.Text = "Asunto - Envío de credenciales";
            this.lblSubjectCredentials.UseCustomForeColor = true;
            // 
            // txtSubjectCredentials
            // 
            this.txtSubjectCredentials.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtSubjectCredentials.CustomButton.Image = null;
            this.txtSubjectCredentials.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txtSubjectCredentials.CustomButton.Name = "";
            this.txtSubjectCredentials.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSubjectCredentials.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubjectCredentials.CustomButton.TabIndex = 1;
            this.txtSubjectCredentials.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubjectCredentials.CustomButton.UseSelectable = true;
            this.txtSubjectCredentials.CustomButton.Visible = false;
            this.txtSubjectCredentials.Lines = new string[0];
            this.txtSubjectCredentials.Location = new System.Drawing.Point(16, 220);
            this.txtSubjectCredentials.MaxLength = 32767;
            this.txtSubjectCredentials.Name = "txtSubjectCredentials";
            this.txtSubjectCredentials.PasswordChar = '\0';
            this.txtSubjectCredentials.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubjectCredentials.SelectedText = "";
            this.txtSubjectCredentials.SelectionLength = 0;
            this.txtSubjectCredentials.SelectionStart = 0;
            this.txtSubjectCredentials.ShortcutsEnabled = true;
            this.txtSubjectCredentials.Size = new System.Drawing.Size(264, 23);
            this.txtSubjectCredentials.TabIndex = 13;
            this.txtSubjectCredentials.UseCustomBackColor = true;
            this.txtSubjectCredentials.UseSelectable = true;
            this.txtSubjectCredentials.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubjectCredentials.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkSendMailPostRegister
            // 
            this.chkSendMailPostRegister.AutoSize = true;
            this.chkSendMailPostRegister.Checked = true;
            this.chkSendMailPostRegister.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSendMailPostRegister.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkSendMailPostRegister.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkSendMailPostRegister.ForeColor = System.Drawing.Color.Navy;
            this.chkSendMailPostRegister.Location = new System.Drawing.Point(18, 148);
            this.chkSendMailPostRegister.Name = "chkSendMailPostRegister";
            this.chkSendMailPostRegister.Size = new System.Drawing.Size(262, 19);
            this.chkSendMailPostRegister.TabIndex = 11;
            this.chkSendMailPostRegister.Text = "Enviar después de registro de empleado";
            this.chkSendMailPostRegister.UseCustomForeColor = true;
            this.chkSendMailPostRegister.UseSelectable = true;
            // 
            // lblAddMsjRegister
            // 
            this.lblAddMsjRegister.AutoSize = true;
            this.lblAddMsjRegister.ForeColor = System.Drawing.Color.Navy;
            this.lblAddMsjRegister.Location = new System.Drawing.Point(16, 74);
            this.lblAddMsjRegister.Name = "lblAddMsjRegister";
            this.lblAddMsjRegister.Size = new System.Drawing.Size(212, 19);
            this.lblAddMsjRegister.TabIndex = 8;
            this.lblAddMsjRegister.Text = "Adjuntar mensaje - Nuevo usuario:";
            this.lblAddMsjRegister.UseCustomForeColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(16, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 2);
            this.label1.TabIndex = 6;
            // 
            // lblSubjectRegister
            // 
            this.lblSubjectRegister.AutoSize = true;
            this.lblSubjectRegister.ForeColor = System.Drawing.Color.Navy;
            this.lblSubjectRegister.Location = new System.Drawing.Point(16, 26);
            this.lblSubjectRegister.Name = "lblSubjectRegister";
            this.lblSubjectRegister.Size = new System.Drawing.Size(150, 19);
            this.lblSubjectRegister.TabIndex = 4;
            this.lblSubjectRegister.Text = "Asunto - Nuevo usuario:";
            this.lblSubjectRegister.UseCustomForeColor = true;
            // 
            // txtSubjectRegister
            // 
            this.txtSubjectRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtSubjectRegister.CustomButton.Image = null;
            this.txtSubjectRegister.CustomButton.Location = new System.Drawing.Point(242, 1);
            this.txtSubjectRegister.CustomButton.Name = "";
            this.txtSubjectRegister.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSubjectRegister.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubjectRegister.CustomButton.TabIndex = 1;
            this.txtSubjectRegister.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubjectRegister.CustomButton.UseSelectable = true;
            this.txtSubjectRegister.CustomButton.Visible = false;
            this.txtSubjectRegister.Lines = new string[0];
            this.txtSubjectRegister.Location = new System.Drawing.Point(16, 48);
            this.txtSubjectRegister.MaxLength = 32767;
            this.txtSubjectRegister.Name = "txtSubjectRegister";
            this.txtSubjectRegister.PasswordChar = '\0';
            this.txtSubjectRegister.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubjectRegister.SelectedText = "";
            this.txtSubjectRegister.SelectionLength = 0;
            this.txtSubjectRegister.SelectionStart = 0;
            this.txtSubjectRegister.ShortcutsEnabled = true;
            this.txtSubjectRegister.Size = new System.Drawing.Size(264, 23);
            this.txtSubjectRegister.TabIndex = 5;
            this.txtSubjectRegister.UseCustomBackColor = true;
            this.txtSubjectRegister.UseSelectable = true;
            this.txtSubjectRegister.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubjectRegister.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // grbCredencialesSistema
            // 
            this.grbCredencialesSistema.BackColor = System.Drawing.Color.White;
            this.grbCredencialesSistema.Controls.Add(this.lblContrasena);
            this.grbCredencialesSistema.Controls.Add(this.txtContrasena);
            this.grbCredencialesSistema.Controls.Add(this.lblEmail);
            this.grbCredencialesSistema.Controls.Add(this.txtEmail);
            this.grbCredencialesSistema.Controls.Add(this.lblDisplayNameEmail);
            this.grbCredencialesSistema.Controls.Add(this.txtDisplayNameEmail);
            this.grbCredencialesSistema.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCredencialesSistema.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbCredencialesSistema.Location = new System.Drawing.Point(3, 157);
            this.grbCredencialesSistema.Name = "grbCredencialesSistema";
            this.grbCredencialesSistema.Size = new System.Drawing.Size(245, 184);
            this.grbCredencialesSistema.TabIndex = 6;
            this.grbCredencialesSistema.TabStop = false;
            this.grbCredencialesSistema.Text = "Credenciales del sistema";
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.ForeColor = System.Drawing.Color.Navy;
            this.lblContrasena.Location = new System.Drawing.Point(15, 76);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(78, 19);
            this.lblContrasena.TabIndex = 4;
            this.lblContrasena.Text = "Contraseña:";
            this.lblContrasena.UseCustomForeColor = true;
            // 
            // txtContrasena
            // 
            this.txtContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtContrasena.CustomButton.Image = null;
            this.txtContrasena.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtContrasena.CustomButton.Name = "";
            this.txtContrasena.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContrasena.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContrasena.CustomButton.TabIndex = 1;
            this.txtContrasena.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContrasena.CustomButton.UseSelectable = true;
            this.txtContrasena.CustomButton.Visible = false;
            this.txtContrasena.Lines = new string[0];
            this.txtContrasena.Location = new System.Drawing.Point(15, 98);
            this.txtContrasena.MaxLength = 32767;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '\0';
            this.txtContrasena.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContrasena.SelectedText = "";
            this.txtContrasena.SelectionLength = 0;
            this.txtContrasena.SelectionStart = 0;
            this.txtContrasena.ShortcutsEnabled = true;
            this.txtContrasena.Size = new System.Drawing.Size(209, 23);
            this.txtContrasena.TabIndex = 5;
            this.txtContrasena.UseCustomBackColor = true;
            this.txtContrasena.UseSelectable = true;
            this.txtContrasena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContrasena.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Navy;
            this.lblEmail.Location = new System.Drawing.Point(15, 28);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(44, 19);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            this.lblEmail.UseCustomForeColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(15, 50);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(209, 23);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.UseCustomBackColor = true;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblDisplayNameEmail
            // 
            this.lblDisplayNameEmail.AutoSize = true;
            this.lblDisplayNameEmail.ForeColor = System.Drawing.Color.Navy;
            this.lblDisplayNameEmail.Location = new System.Drawing.Point(15, 124);
            this.lblDisplayNameEmail.Name = "lblDisplayNameEmail";
            this.lblDisplayNameEmail.Size = new System.Drawing.Size(187, 19);
            this.lblDisplayNameEmail.TabIndex = 2;
            this.lblDisplayNameEmail.Text = "Nombre de emisor (opcional):";
            this.lblDisplayNameEmail.UseCustomForeColor = true;
            // 
            // txtDisplayNameEmail
            // 
            this.txtDisplayNameEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtDisplayNameEmail.CustomButton.Image = null;
            this.txtDisplayNameEmail.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtDisplayNameEmail.CustomButton.Name = "";
            this.txtDisplayNameEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDisplayNameEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDisplayNameEmail.CustomButton.TabIndex = 1;
            this.txtDisplayNameEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDisplayNameEmail.CustomButton.UseSelectable = true;
            this.txtDisplayNameEmail.CustomButton.Visible = false;
            this.txtDisplayNameEmail.Lines = new string[0];
            this.txtDisplayNameEmail.Location = new System.Drawing.Point(15, 146);
            this.txtDisplayNameEmail.MaxLength = 32767;
            this.txtDisplayNameEmail.Name = "txtDisplayNameEmail";
            this.txtDisplayNameEmail.PasswordChar = '\0';
            this.txtDisplayNameEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDisplayNameEmail.SelectedText = "";
            this.txtDisplayNameEmail.SelectionLength = 0;
            this.txtDisplayNameEmail.SelectionStart = 0;
            this.txtDisplayNameEmail.ShortcutsEnabled = true;
            this.txtDisplayNameEmail.Size = new System.Drawing.Size(209, 23);
            this.txtDisplayNameEmail.TabIndex = 3;
            this.txtDisplayNameEmail.UseCustomBackColor = true;
            this.txtDisplayNameEmail.UseSelectable = true;
            this.txtDisplayNameEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDisplayNameEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // grbServidorCorreo
            // 
            this.grbServidorCorreo.BackColor = System.Drawing.Color.White;
            this.grbServidorCorreo.Controls.Add(this.lblPort);
            this.grbServidorCorreo.Controls.Add(this.txtPort);
            this.grbServidorCorreo.Controls.Add(this.lblMailServer);
            this.grbServidorCorreo.Controls.Add(this.txtMailServer);
            this.grbServidorCorreo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbServidorCorreo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbServidorCorreo.Location = new System.Drawing.Point(3, 12);
            this.grbServidorCorreo.Name = "grbServidorCorreo";
            this.grbServidorCorreo.Size = new System.Drawing.Size(245, 139);
            this.grbServidorCorreo.TabIndex = 4;
            this.grbServidorCorreo.TabStop = false;
            this.grbServidorCorreo.Text = "Servidor de correo";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.ForeColor = System.Drawing.Color.Navy;
            this.lblPort.Location = new System.Drawing.Point(15, 74);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(37, 19);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Port:";
            this.lblPort.UseCustomForeColor = true;
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtPort.CustomButton.Image = null;
            this.txtPort.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtPort.CustomButton.Name = "";
            this.txtPort.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPort.CustomButton.TabIndex = 1;
            this.txtPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPort.CustomButton.UseSelectable = true;
            this.txtPort.CustomButton.Visible = false;
            this.txtPort.Lines = new string[0];
            this.txtPort.Location = new System.Drawing.Point(15, 96);
            this.txtPort.MaxLength = 32767;
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPort.SelectedText = "";
            this.txtPort.SelectionLength = 0;
            this.txtPort.SelectionStart = 0;
            this.txtPort.ShortcutsEnabled = true;
            this.txtPort.Size = new System.Drawing.Size(209, 23);
            this.txtPort.TabIndex = 5;
            this.txtPort.UseCustomBackColor = true;
            this.txtPort.UseSelectable = true;
            this.txtPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblMailServer
            // 
            this.lblMailServer.AutoSize = true;
            this.lblMailServer.ForeColor = System.Drawing.Color.Navy;
            this.lblMailServer.Location = new System.Drawing.Point(15, 26);
            this.lblMailServer.Name = "lblMailServer";
            this.lblMailServer.Size = new System.Drawing.Size(80, 19);
            this.lblMailServer.TabIndex = 2;
            this.lblMailServer.Text = "Mail Server:";
            this.lblMailServer.UseCustomForeColor = true;
            // 
            // txtMailServer
            // 
            this.txtMailServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(253)))), ((int)(((byte)(255)))));
            // 
            // 
            // 
            this.txtMailServer.CustomButton.Image = null;
            this.txtMailServer.CustomButton.Location = new System.Drawing.Point(187, 1);
            this.txtMailServer.CustomButton.Name = "";
            this.txtMailServer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMailServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMailServer.CustomButton.TabIndex = 1;
            this.txtMailServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMailServer.CustomButton.UseSelectable = true;
            this.txtMailServer.CustomButton.Visible = false;
            this.txtMailServer.Lines = new string[0];
            this.txtMailServer.Location = new System.Drawing.Point(15, 48);
            this.txtMailServer.MaxLength = 32767;
            this.txtMailServer.Name = "txtMailServer";
            this.txtMailServer.PasswordChar = '\0';
            this.txtMailServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMailServer.SelectedText = "";
            this.txtMailServer.SelectionLength = 0;
            this.txtMailServer.SelectionStart = 0;
            this.txtMailServer.ShortcutsEnabled = true;
            this.txtMailServer.Size = new System.Drawing.Size(209, 23);
            this.txtMailServer.TabIndex = 3;
            this.txtMailServer.UseCustomBackColor = true;
            this.txtMailServer.UseSelectable = true;
            this.txtMailServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMailServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabPagDiseno
            // 
            this.tabPagDiseno.Controls.Add(this.grbLogo);
            this.tabPagDiseno.Controls.Add(this.grbImagenLogin);
            this.tabPagDiseno.Controls.Add(this.grbSplash);
            this.tabPagDiseno.HorizontalScrollbarBarColor = true;
            this.tabPagDiseno.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagDiseno.HorizontalScrollbarSize = 10;
            this.tabPagDiseno.Location = new System.Drawing.Point(4, 38);
            this.tabPagDiseno.Name = "tabPagDiseno";
            this.tabPagDiseno.Size = new System.Drawing.Size(559, 347);
            this.tabPagDiseno.TabIndex = 1;
            this.tabPagDiseno.Text = "Diseño";
            this.tabPagDiseno.VerticalScrollbarBarColor = true;
            this.tabPagDiseno.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagDiseno.VerticalScrollbarSize = 10;
            // 
            // grbLogo
            // 
            this.grbLogo.BackColor = System.Drawing.Color.White;
            this.grbLogo.Controls.Add(this.btnCambiarLogo);
            this.grbLogo.Controls.Add(this.picLogo);
            this.grbLogo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLogo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbLogo.Location = new System.Drawing.Point(393, 16);
            this.grbLogo.Name = "grbLogo";
            this.grbLogo.Size = new System.Drawing.Size(162, 200);
            this.grbLogo.TabIndex = 23;
            this.grbLogo.TabStop = false;
            this.grbLogo.Text = "Logo del menú principal";
            // 
            // btnCambiarLogo
            // 
            this.btnCambiarLogo.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCambiarLogo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCambiarLogo.FlatAppearance.BorderSize = 0;
            this.btnCambiarLogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCambiarLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCambiarLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarLogo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarLogo.ForeColor = System.Drawing.Color.White;
            this.btnCambiarLogo.Location = new System.Drawing.Point(45, 159);
            this.btnCambiarLogo.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarLogo.Name = "btnCambiarLogo";
            this.btnCambiarLogo.Size = new System.Drawing.Size(69, 24);
            this.btnCambiarLogo.TabIndex = 26;
            this.btnCambiarLogo.Text = "Cambiar";
            this.btnCambiarLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambiarLogo.UseVisualStyleBackColor = false;
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.InitialImage = null;
            this.picLogo.Location = new System.Drawing.Point(17, 28);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(125, 126);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 21;
            this.picLogo.TabStop = false;
            // 
            // grbImagenLogin
            // 
            this.grbImagenLogin.BackColor = System.Drawing.Color.White;
            this.grbImagenLogin.Controls.Add(this.btnCambiarImagenLogin);
            this.grbImagenLogin.Controls.Add(this.picImagenLogin);
            this.grbImagenLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbImagenLogin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbImagenLogin.Location = new System.Drawing.Point(198, 16);
            this.grbImagenLogin.Name = "grbImagenLogin";
            this.grbImagenLogin.Size = new System.Drawing.Size(162, 200);
            this.grbImagenLogin.TabIndex = 22;
            this.grbImagenLogin.TabStop = false;
            this.grbImagenLogin.Text = "Imagen del login";
            // 
            // btnCambiarImagenLogin
            // 
            this.btnCambiarImagenLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCambiarImagenLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCambiarImagenLogin.FlatAppearance.BorderSize = 0;
            this.btnCambiarImagenLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCambiarImagenLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCambiarImagenLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarImagenLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarImagenLogin.ForeColor = System.Drawing.Color.White;
            this.btnCambiarImagenLogin.Location = new System.Drawing.Point(45, 159);
            this.btnCambiarImagenLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarImagenLogin.Name = "btnCambiarImagenLogin";
            this.btnCambiarImagenLogin.Size = new System.Drawing.Size(69, 24);
            this.btnCambiarImagenLogin.TabIndex = 25;
            this.btnCambiarImagenLogin.Text = "Cambiar";
            this.btnCambiarImagenLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambiarImagenLogin.UseVisualStyleBackColor = false;
            // 
            // picImagenLogin
            // 
            this.picImagenLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picImagenLogin.InitialImage = null;
            this.picImagenLogin.Location = new System.Drawing.Point(17, 28);
            this.picImagenLogin.Name = "picImagenLogin";
            this.picImagenLogin.Size = new System.Drawing.Size(125, 126);
            this.picImagenLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picImagenLogin.TabIndex = 21;
            this.picImagenLogin.TabStop = false;
            // 
            // grbSplash
            // 
            this.grbSplash.BackColor = System.Drawing.Color.White;
            this.grbSplash.Controls.Add(this.btnCambiarSplash);
            this.grbSplash.Controls.Add(this.picSplash);
            this.grbSplash.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSplash.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbSplash.Location = new System.Drawing.Point(3, 16);
            this.grbSplash.Name = "grbSplash";
            this.grbSplash.Size = new System.Drawing.Size(162, 200);
            this.grbSplash.TabIndex = 5;
            this.grbSplash.TabStop = false;
            this.grbSplash.Text = "Splash";
            // 
            // btnCambiarSplash
            // 
            this.btnCambiarSplash.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCambiarSplash.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCambiarSplash.FlatAppearance.BorderSize = 0;
            this.btnCambiarSplash.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCambiarSplash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCambiarSplash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarSplash.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarSplash.ForeColor = System.Drawing.Color.White;
            this.btnCambiarSplash.Location = new System.Drawing.Point(45, 159);
            this.btnCambiarSplash.Margin = new System.Windows.Forms.Padding(2);
            this.btnCambiarSplash.Name = "btnCambiarSplash";
            this.btnCambiarSplash.Size = new System.Drawing.Size(69, 24);
            this.btnCambiarSplash.TabIndex = 24;
            this.btnCambiarSplash.Text = "Cambiar";
            this.btnCambiarSplash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCambiarSplash.UseVisualStyleBackColor = false;
            // 
            // picSplash
            // 
            this.picSplash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSplash.InitialImage = null;
            this.picSplash.Location = new System.Drawing.Point(17, 28);
            this.picSplash.Name = "picSplash";
            this.picSplash.Size = new System.Drawing.Size(125, 126);
            this.picSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picSplash.TabIndex = 21;
            this.picSplash.TabStop = false;
            // 
            // tabPagBaseDeDatos
            // 
            this.tabPagBaseDeDatos.Controls.Add(this.grbBackupRestore);
            this.tabPagBaseDeDatos.HorizontalScrollbarBarColor = true;
            this.tabPagBaseDeDatos.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPagBaseDeDatos.HorizontalScrollbarSize = 10;
            this.tabPagBaseDeDatos.Location = new System.Drawing.Point(4, 38);
            this.tabPagBaseDeDatos.Name = "tabPagBaseDeDatos";
            this.tabPagBaseDeDatos.Size = new System.Drawing.Size(559, 347);
            this.tabPagBaseDeDatos.TabIndex = 2;
            this.tabPagBaseDeDatos.Text = "Base de Datos";
            this.tabPagBaseDeDatos.VerticalScrollbarBarColor = true;
            this.tabPagBaseDeDatos.VerticalScrollbarHighlightOnWheel = false;
            this.tabPagBaseDeDatos.VerticalScrollbarSize = 10;
            // 
            // grbBackupRestore
            // 
            this.grbBackupRestore.BackColor = System.Drawing.Color.White;
            this.grbBackupRestore.Controls.Add(this.chkHabilitarRestore);
            this.grbBackupRestore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBackupRestore.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grbBackupRestore.Location = new System.Drawing.Point(3, 16);
            this.grbBackupRestore.Name = "grbBackupRestore";
            this.grbBackupRestore.Size = new System.Drawing.Size(553, 62);
            this.grbBackupRestore.TabIndex = 13;
            this.grbBackupRestore.TabStop = false;
            this.grbBackupRestore.Text = "Backup y Restore";
            // 
            // chkHabilitarRestore
            // 
            this.chkHabilitarRestore.AutoSize = true;
            this.chkHabilitarRestore.Checked = true;
            this.chkHabilitarRestore.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHabilitarRestore.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.chkHabilitarRestore.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.chkHabilitarRestore.ForeColor = System.Drawing.Color.Navy;
            this.chkHabilitarRestore.Location = new System.Drawing.Point(17, 25);
            this.chkHabilitarRestore.Name = "chkHabilitarRestore";
            this.chkHabilitarRestore.Size = new System.Drawing.Size(122, 19);
            this.chkHabilitarRestore.TabIndex = 12;
            this.chkHabilitarRestore.Text = "Habilitar Restore";
            this.chkHabilitarRestore.UseCustomForeColor = true;
            this.chkHabilitarRestore.UseSelectable = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(519, 481);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 30);
            this.btnCancelar.TabIndex = 113;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(437, 481);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 10, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(78, 30);
            this.btnGuardar.TabIndex = 112;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // lblCodParametro
            // 
            this.lblCodParametro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodParametro.Location = new System.Drawing.Point(41, 481);
            this.lblCodParametro.Name = "lblCodParametro";
            this.lblCodParametro.Size = new System.Drawing.Size(77, 30);
            this.lblCodParametro.TabIndex = 114;
            this.lblCodParametro.Text = "COD: 1000000000";
            // 
            // lblDescripcionParametro
            // 
            this.lblDescripcionParametro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionParametro.Location = new System.Drawing.Point(124, 481);
            this.lblDescripcionParametro.Name = "lblDescripcionParametro";
            this.lblDescripcionParametro.Size = new System.Drawing.Size(296, 45);
            this.lblDescripcionParametro.TabIndex = 115;
            this.lblDescripcionParametro.Text = "Descripción del parámetro";
            // 
            // FormConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCerrar;
            this.ClientSize = new System.Drawing.Size(645, 546);
            this.Controls.Add(this.lblDescripcionParametro);
            this.Controls.Add(this.lblCodParametro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tabConfiguracion);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblNombreForm);
            this.MaximizeBox = false;
            this.Name = "FormConfiguracion";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.FormConfiguracion_Load);
            this.tabConfiguracion.ResumeLayout(false);
            this.tabPagEmail.ResumeLayout(false);
            this.grbConfiguracionMensajes.ResumeLayout(false);
            this.grbConfiguracionMensajes.PerformLayout();
            this.grbCredencialesSistema.ResumeLayout(false);
            this.grbCredencialesSistema.PerformLayout();
            this.grbServidorCorreo.ResumeLayout(false);
            this.grbServidorCorreo.PerformLayout();
            this.tabPagDiseno.ResumeLayout(false);
            this.grbLogo.ResumeLayout(false);
            this.grbLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.grbImagenLogin.ResumeLayout(false);
            this.grbImagenLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagenLogin)).EndInit();
            this.grbSplash.ResumeLayout(false);
            this.grbSplash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSplash)).EndInit();
            this.tabPagBaseDeDatos.ResumeLayout(false);
            this.grbBackupRestore.ResumeLayout(false);
            this.grbBackupRestore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink btnCerrar;
        private System.Windows.Forms.Label lblNombreForm;
        private MetroFramework.Controls.MetroTabControl tabConfiguracion;
        private MetroFramework.Controls.MetroTabPage tabPagEmail;
        private MetroFramework.Controls.MetroTabPage tabPagDiseno;
        private MetroFramework.Controls.MetroTabPage tabPagBaseDeDatos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private MetroFramework.Controls.MetroTextBox txtMailServer;
        private MetroFramework.Controls.MetroLabel lblMailServer;
        private System.Windows.Forms.GroupBox grbServidorCorreo;
        private MetroFramework.Controls.MetroLabel lblPort;
        private MetroFramework.Controls.MetroTextBox txtPort;
        private System.Windows.Forms.GroupBox grbCredencialesSistema;
        private MetroFramework.Controls.MetroLabel lblContrasena;
        private MetroFramework.Controls.MetroTextBox txtContrasena;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private System.Windows.Forms.GroupBox grbConfiguracionMensajes;
        private MetroFramework.Controls.MetroLabel lblSubjectRegister;
        private MetroFramework.Controls.MetroTextBox txtSubjectRegister;
        private MetroFramework.Controls.MetroLabel lblDisplayNameEmail;
        private MetroFramework.Controls.MetroTextBox txtDisplayNameEmail;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel lblAddMsjRegister;
        private MetroFramework.Controls.MetroCheckBox chkSendMailPostRegister;
        private MetroFramework.Controls.MetroLabel lblAddMsjCredentials;
        private MetroFramework.Controls.MetroLabel lblSubjectCredentials;
        private MetroFramework.Controls.MetroTextBox txtSubjectCredentials;
        private MetroFramework.Controls.MetroCheckBox chkHabilitarRestore;
        private System.Windows.Forms.TextBox txtAddMsjRegister;
        private System.Windows.Forms.TextBox txtAddMsjCredentials;
        private System.Windows.Forms.GroupBox grbSplash;
        private System.Windows.Forms.GroupBox grbLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.GroupBox grbImagenLogin;
        private System.Windows.Forms.PictureBox picImagenLogin;
        private System.Windows.Forms.PictureBox picSplash;
        private System.Windows.Forms.GroupBox grbBackupRestore;
        private System.Windows.Forms.Button btnCambiarLogo;
        private System.Windows.Forms.Button btnCambiarImagenLogin;
        private System.Windows.Forms.Button btnCambiarSplash;
        private System.Windows.Forms.Label lblCodParametro;
        private System.Windows.Forms.Label lblDescripcionParametro;
    }
}