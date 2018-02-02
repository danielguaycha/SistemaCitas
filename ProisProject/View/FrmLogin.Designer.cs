namespace ProisProject.View
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelImgae = new System.Windows.Forms.PictureBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.ContanierLogin = new System.Windows.Forms.Panel();
            this.ContaninerPanelLogin = new System.Windows.Forms.Panel();
            this.ContaninerPasswordChange = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPass1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCambiar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtPass2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnIniciar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCedula = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.HeaderLogin = new System.Windows.Forms.Panel();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelImgae)).BeginInit();
            this.ContanierLogin.SuspendLayout();
            this.ContaninerPanelLogin.SuspendLayout();
            this.ContaninerPasswordChange.SuspendLayout();
            this.HeaderLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.HeaderLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 500);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.splitContainer1.Panel1.Controls.Add(this.panelImgae);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel2.Controls.Add(this.lblAviso);
            this.splitContainer1.Panel2.Controls.Add(this.ContanierLogin);
            this.splitContainer1.Size = new System.Drawing.Size(800, 470);
            this.splitContainer1.SplitterDistance = 481;
            this.splitContainer1.TabIndex = 1;
            // 
            // panelImgae
            // 
            this.panelImgae.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImgae.Image = ((System.Drawing.Image)(resources.GetObject("panelImgae.Image")));
            this.panelImgae.Location = new System.Drawing.Point(0, 0);
            this.panelImgae.Name = "panelImgae";
            this.panelImgae.Size = new System.Drawing.Size(481, 470);
            this.panelImgae.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.panelImgae.TabIndex = 0;
            this.panelImgae.TabStop = false;
            // 
            // lblAviso
            // 
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(15, 375);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(265, 23);
            this.lblAviso.TabIndex = 4;
            this.lblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContanierLogin
            // 
            this.ContanierLogin.Controls.Add(this.ContaninerPanelLogin);
            this.ContanierLogin.Controls.Add(this.ContaninerPasswordChange);
            this.ContanierLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContanierLogin.Location = new System.Drawing.Point(0, 0);
            this.ContanierLogin.Name = "ContanierLogin";
            this.ContanierLogin.Size = new System.Drawing.Size(315, 470);
            this.ContanierLogin.TabIndex = 5;
            // 
            // ContaninerPanelLogin
            // 
            this.ContaninerPanelLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ContaninerPanelLogin.Controls.Add(this.label4);
            this.ContaninerPanelLogin.Controls.Add(this.label3);
            this.ContaninerPanelLogin.Controls.Add(this.bunifuCustomLabel1);
            this.ContaninerPanelLogin.Controls.Add(this.btnIniciar);
            this.ContaninerPanelLogin.Controls.Add(this.txtPassword);
            this.ContaninerPanelLogin.Controls.Add(this.txtCedula);
            this.ContaninerPanelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContaninerPanelLogin.Location = new System.Drawing.Point(0, 0);
            this.ContaninerPanelLogin.Name = "ContaninerPanelLogin";
            this.ContaninerPanelLogin.Size = new System.Drawing.Size(315, 470);
            this.ContaninerPanelLogin.TabIndex = 4;
            // 
            // ContaninerPasswordChange
            // 
            this.ContaninerPasswordChange.Controls.Add(this.label2);
            this.ContaninerPasswordChange.Controls.Add(this.label1);
            this.ContaninerPasswordChange.Controls.Add(this.bunifuCustomLabel2);
            this.ContaninerPasswordChange.Controls.Add(this.txtPass1);
            this.ContaninerPasswordChange.Controls.Add(this.btnCambiar);
            this.ContaninerPasswordChange.Controls.Add(this.txtPass2);
            this.ContaninerPasswordChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContaninerPasswordChange.Location = new System.Drawing.Point(0, 0);
            this.ContaninerPasswordChange.Name = "ContaninerPasswordChange";
            this.ContaninerPasswordChange.Size = new System.Drawing.Size(315, 470);
            this.ContaninerPasswordChange.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Repita Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ingrese Contraseña";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(42, 77);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(227, 25);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "Cambiar Contraseña";
            // 
            // txtPass1
            // 
            this.txtPass1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPass1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass1.HintForeColor = System.Drawing.Color.Empty;
            this.txtPass1.HintText = "";
            this.txtPass1.isPassword = true;
            this.txtPass1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.txtPass1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.txtPass1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.txtPass1.LineThickness = 3;
            this.txtPass1.Location = new System.Drawing.Point(21, 140);
            this.txtPass1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.Size = new System.Drawing.Size(262, 33);
            this.txtPass1.TabIndex = 7;
            this.txtPass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPass1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass1_KeyPress);
            // 
            // btnCambiar
            // 
            this.btnCambiar.ActiveBorderThickness = 3;
            this.btnCambiar.ActiveCornerRadius = 20;
            this.btnCambiar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.btnCambiar.ActiveForecolor = System.Drawing.Color.White;
            this.btnCambiar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.btnCambiar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCambiar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCambiar.BackgroundImage")));
            this.btnCambiar.ButtonText = "Cambiar";
            this.btnCambiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCambiar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.btnCambiar.IdleBorderThickness = 3;
            this.btnCambiar.IdleCornerRadius = 20;
            this.btnCambiar.IdleFillColor = System.Drawing.Color.White;
            this.btnCambiar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.btnCambiar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.btnCambiar.Location = new System.Drawing.Point(68, 276);
            this.btnCambiar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(181, 52);
            this.btnCambiar.TabIndex = 5;
            this.btnCambiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // txtPass2
            // 
            this.txtPass2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPass2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPass2.HintForeColor = System.Drawing.Color.Empty;
            this.txtPass2.HintText = "";
            this.txtPass2.isPassword = true;
            this.txtPass2.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.txtPass2.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.txtPass2.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.txtPass2.LineThickness = 3;
            this.txtPass2.Location = new System.Drawing.Point(20, 205);
            this.txtPass2.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass2.Name = "txtPass2";
            this.txtPass2.Size = new System.Drawing.Size(262, 33);
            this.txtPass2.TabIndex = 4;
            this.txtPass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPass2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass2_KeyPress);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 77);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(300, 25);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Iniciar Sesión";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnIniciar
            // 
            this.btnIniciar.ActiveBorderThickness = 3;
            this.btnIniciar.ActiveCornerRadius = 20;
            this.btnIniciar.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.btnIniciar.ActiveForecolor = System.Drawing.Color.White;
            this.btnIniciar.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.btnIniciar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIniciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIniciar.BackgroundImage")));
            this.btnIniciar.ButtonText = "Iniciar";
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.btnIniciar.IdleBorderThickness = 3;
            this.btnIniciar.IdleCornerRadius = 20;
            this.btnIniciar.IdleFillColor = System.Drawing.Color.White;
            this.btnIniciar.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.btnIniciar.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.btnIniciar.Location = new System.Drawing.Point(68, 276);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(5);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(181, 52);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtPassword.HintText = "";
            this.txtPassword.isPassword = true;
            this.txtPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.txtPassword.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.txtPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.txtPassword.LineThickness = 3;
            this.txtPassword.Location = new System.Drawing.Point(20, 205);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(262, 33);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
            // 
            // txtCedula
            // 
            this.txtCedula.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCedula.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCedula.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCedula.HintForeColor = System.Drawing.Color.Empty;
            this.txtCedula.HintText = "";
            this.txtCedula.isPassword = false;
            this.txtCedula.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.txtCedula.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(70)))));
            this.txtCedula.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(105)))));
            this.txtCedula.LineThickness = 3;
            this.txtCedula.Location = new System.Drawing.Point(20, 140);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(263, 33);
            this.txtCedula.TabIndex = 1;
            this.txtCedula.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // HeaderLogin
            // 
            this.HeaderLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.HeaderLogin.Controls.Add(this.minimizeButton);
            this.HeaderLogin.Controls.Add(this.btnClose);
            this.HeaderLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(26)))), ((int)(((byte)(35)))));
            this.HeaderLogin.Location = new System.Drawing.Point(0, 0);
            this.HeaderLogin.Name = "HeaderLogin";
            this.HeaderLogin.Size = new System.Drawing.Size(800, 30);
            this.HeaderLogin.TabIndex = 0;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.ImageActive = null;
            this.minimizeButton.Location = new System.Drawing.Point(739, 4);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(26, 23);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 5;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(771, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(17, 23);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.HeaderLogin;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panelImgae;
            this.bunifuDragControl2.Vertical = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese Cedula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ingrese Contraseña";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelImgae)).EndInit();
            this.ContanierLogin.ResumeLayout(false);
            this.ContaninerPanelLogin.ResumeLayout(false);
            this.ContaninerPanelLogin.PerformLayout();
            this.ContaninerPasswordChange.ResumeLayout(false);
            this.ContaninerPasswordChange.PerformLayout();
            this.HeaderLogin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel HeaderLogin;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox panelImgae;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnIniciar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCedula;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassword;
        private System.Windows.Forms.Label lblAviso;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Panel ContanierLogin;
        private System.Windows.Forms.Panel ContaninerPanelLogin;
        private System.Windows.Forms.Panel ContaninerPasswordChange;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPass1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCambiar;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPass2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}