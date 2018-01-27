namespace ProisProject
{
    partial class Index
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.HeaderTitle = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.maximizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimizeButton = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.horizontalMenu = new System.Windows.Forms.MenuStrip();
            this.cMSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSessiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.SideBarMenu = new System.Windows.Forms.Panel();
            this.SlidePanel = new System.Windows.Forms.Panel();
            this.btnHome = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDoctores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenu = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnConsultas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.div = new System.Windows.Forms.Label();
            this.btnPacientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnHistorial = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReservaciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.panelConsulta1 = new ProisProject.View.Panels.PanelConsulta();
            this.panelCitas1 = new ProisProject.View.Panels.PanelCitas();
            this.historialPanel1 = new ProisProject.View.Panels.HistorialPanel();
            this.rolPanel1 = new ProisProject.View.Panels.RolPanel();
            this.panelUsuario1 = new ProisProject.View.Panels.UserPanel();
            this.pacientePanel1 = new ProisProject.View.PacientePanel();
            this.homePanel1 = new ProisProject.View.Panels.HomePanel();
            this.searchPanel1 = new ProisProject.View.SearchPanel();
            this.specialityPanel1 = new ProisProject.View.SpecialityPanel();
            this.doctorPanel1 = new ProisProject.View.DoctorPanel();
            this.panelNotitify = new System.Windows.Forms.Panel();
            this.nowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAnimator = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.dragWindows = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.HeaderTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            this.panel3.SuspendLayout();
            this.horizontalMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.SideBarMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.PanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderTitle
            // 
            this.HeaderTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.HeaderTitle.Controls.Add(this.pictureBox1);
            this.HeaderTitle.Controls.Add(this.maximizeButton);
            this.HeaderTitle.Controls.Add(this.minimizeButton);
            this.HeaderTitle.Controls.Add(this.panel3);
            this.HeaderTitle.Controls.Add(this.bunifuImageButton2);
            this.menuAnimator.SetDecoration(this.HeaderTitle, BunifuAnimatorNS.DecorationType.None);
            this.HeaderTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderTitle.ForeColor = System.Drawing.Color.Snow;
            this.HeaderTitle.Location = new System.Drawing.Point(0, 0);
            this.HeaderTitle.Name = "HeaderTitle";
            this.HeaderTitle.Size = new System.Drawing.Size(1024, 35);
            this.HeaderTitle.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.menuAnimator.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // maximizeButton
            // 
            this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeButton.BackColor = System.Drawing.Color.Transparent;
            this.maximizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuAnimator.SetDecoration(this.maximizeButton, BunifuAnimatorNS.DecorationType.None);
            this.maximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("maximizeButton.Image")));
            this.maximizeButton.ImageActive = null;
            this.maximizeButton.Location = new System.Drawing.Point(970, 6);
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.Size = new System.Drawing.Size(17, 23);
            this.maximizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.maximizeButton.TabIndex = 4;
            this.maximizeButton.TabStop = false;
            this.maximizeButton.Zoom = 10;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuAnimator.SetDecoration(this.minimizeButton, BunifuAnimatorNS.DecorationType.None);
            this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
            this.minimizeButton.ImageActive = null;
            this.minimizeButton.Location = new System.Drawing.Point(938, 6);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(26, 23);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Zoom = 10;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.horizontalMenu);
            this.menuAnimator.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(27, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(378, 35);
            this.panel3.TabIndex = 1;
            // 
            // horizontalMenu
            // 
            this.horizontalMenu.AutoSize = false;
            this.horizontalMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.menuAnimator.SetDecoration(this.horizontalMenu, BunifuAnimatorNS.DecorationType.None);
            this.horizontalMenu.GripMargin = new System.Windows.Forms.Padding(15, 2, 0, 2);
            this.horizontalMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMSystemToolStripMenuItem,
            this.registrosToolStripMenuItem});
            this.horizontalMenu.Location = new System.Drawing.Point(0, 0);
            this.horizontalMenu.Margin = new System.Windows.Forms.Padding(10, 0, 0, 10);
            this.horizontalMenu.Name = "horizontalMenu";
            this.horizontalMenu.Size = new System.Drawing.Size(378, 30);
            this.horizontalMenu.TabIndex = 0;
            this.horizontalMenu.Text = "menuStrip1";
            // 
            // cMSystemToolStripMenuItem
            // 
            this.cMSystemToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.cMSystemToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cMSystemToolStripMenuItem.Checked = true;
            this.cMSystemToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cMSystemToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cMSystemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaGeneralToolStripMenuItem,
            this.cerrarSessiónToolStripMenuItem,
            this.salirToolStripMenuItem1,
            this.acercaDeToolStripMenuItem1});
            this.cMSystemToolStripMenuItem.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMSystemToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cMSystemToolStripMenuItem.Name = "cMSystemToolStripMenuItem";
            this.cMSystemToolStripMenuItem.Size = new System.Drawing.Size(106, 26);
            this.cMSystemToolStripMenuItem.Text = "CMSystem";
            // 
            // busquedaGeneralToolStripMenuItem
            // 
            this.busquedaGeneralToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaGeneralToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.busquedaGeneralToolStripMenuItem.Name = "busquedaGeneralToolStripMenuItem";
            this.busquedaGeneralToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.busquedaGeneralToolStripMenuItem.Text = "Busqueda General";
            // 
            // cerrarSessiónToolStripMenuItem
            // 
            this.cerrarSessiónToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSessiónToolStripMenuItem.Name = "cerrarSessiónToolStripMenuItem";
            this.cerrarSessiónToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cerrarSessiónToolStripMenuItem.Text = "Cerrar Sessión";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // acercaDeToolStripMenuItem1
            // 
            this.acercaDeToolStripMenuItem1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acercaDeToolStripMenuItem1.Name = "acercaDeToolStripMenuItem1";
            this.acercaDeToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.acercaDeToolStripMenuItem1.Text = "Acerca de";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.especialidadesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.logsToolStripMenuItem});
            this.registrosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 26);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // especialidadesToolStripMenuItem
            // 
            this.especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            this.especialidadesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.especialidadesToolStripMenuItem.Text = "Especialidades";
            this.especialidadesToolStripMenuItem.Click += new System.EventHandler(this.especialidadesToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.rolesToolStripMenuItem.Text = "Roles";
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.logsToolStripMenuItem.Text = "Logs";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuAnimator.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(993, 6);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(17, 23);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.btnClose);
            // 
            // SideBarMenu
            // 
            this.SideBarMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.SideBarMenu.Controls.Add(this.SlidePanel);
            this.SideBarMenu.Controls.Add(this.btnHome);
            this.SideBarMenu.Controls.Add(this.btnDoctores);
            this.SideBarMenu.Controls.Add(this.btnMenu);
            this.SideBarMenu.Controls.Add(this.btnSearch);
            this.SideBarMenu.Controls.Add(this.btnConsultas);
            this.SideBarMenu.Controls.Add(this.div);
            this.SideBarMenu.Controls.Add(this.btnPacientes);
            this.SideBarMenu.Controls.Add(this.btnHistorial);
            this.SideBarMenu.Controls.Add(this.btnReservaciones);
            this.menuAnimator.SetDecoration(this.SideBarMenu, BunifuAnimatorNS.DecorationType.None);
            this.SideBarMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(46)))), ((int)(((byte)(70)))));
            this.SideBarMenu.Location = new System.Drawing.Point(0, 35);
            this.SideBarMenu.Name = "SideBarMenu";
            this.SideBarMenu.Size = new System.Drawing.Size(218, 685);
            this.SideBarMenu.TabIndex = 1;
            // 
            // SlidePanel
            // 
            this.SlidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.menuAnimator.SetDecoration(this.SlidePanel, BunifuAnimatorNS.DecorationType.None);
            this.SlidePanel.Location = new System.Drawing.Point(0, 37);
            this.SlidePanel.Name = "SlidePanel";
            this.SlidePanel.Size = new System.Drawing.Size(7, 48);
            this.SlidePanel.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.BorderRadius = 0;
            this.btnHome.ButtonText = "     Inicio";
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuAnimator.SetDecoration(this.btnHome, BunifuAnimatorNS.DecorationType.None);
            this.btnHome.DisabledColor = System.Drawing.Color.Gray;
            this.btnHome.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHome.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHome.Iconimage")));
            this.btnHome.Iconimage_right = null;
            this.btnHome.Iconimage_right_Selected = null;
            this.btnHome.Iconimage_Selected = null;
            this.btnHome.IconMarginLeft = 15;
            this.btnHome.IconMarginRight = 0;
            this.btnHome.IconRightVisible = true;
            this.btnHome.IconRightZoom = 0D;
            this.btnHome.IconVisible = true;
            this.btnHome.IconZoom = 80D;
            this.btnHome.IsTab = false;
            this.btnHome.Location = new System.Drawing.Point(0, 37);
            this.btnHome.Name = "btnHome";
            this.btnHome.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnHome.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnHome.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHome.selected = false;
            this.btnHome.Size = new System.Drawing.Size(213, 48);
            this.btnHome.TabIndex = 4;
            this.btnHome.Text = "     Inicio";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Textcolor = System.Drawing.Color.White;
            this.btnHome.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnDoctores
            // 
            this.btnDoctores.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnDoctores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnDoctores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoctores.BorderRadius = 0;
            this.btnDoctores.ButtonText = "     Médicos";
            this.btnDoctores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuAnimator.SetDecoration(this.btnDoctores, BunifuAnimatorNS.DecorationType.None);
            this.btnDoctores.DisabledColor = System.Drawing.Color.Gray;
            this.btnDoctores.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctores.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDoctores.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDoctores.Iconimage")));
            this.btnDoctores.Iconimage_right = null;
            this.btnDoctores.Iconimage_right_Selected = null;
            this.btnDoctores.Iconimage_Selected = null;
            this.btnDoctores.IconMarginLeft = 15;
            this.btnDoctores.IconMarginRight = 0;
            this.btnDoctores.IconRightVisible = true;
            this.btnDoctores.IconRightZoom = 0D;
            this.btnDoctores.IconVisible = true;
            this.btnDoctores.IconZoom = 80D;
            this.btnDoctores.IsTab = false;
            this.btnDoctores.Location = new System.Drawing.Point(0, 204);
            this.btnDoctores.Name = "btnDoctores";
            this.btnDoctores.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnDoctores.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnDoctores.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDoctores.selected = false;
            this.btnDoctores.Size = new System.Drawing.Size(213, 48);
            this.btnDoctores.TabIndex = 1;
            this.btnDoctores.Text = "     Médicos";
            this.btnDoctores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctores.Textcolor = System.Drawing.Color.White;
            this.btnDoctores.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctores.Click += new System.EventHandler(this.btnDoctores_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuAnimator.SetDecoration(this.btnMenu, BunifuAnimatorNS.DecorationType.None);
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.ImageActive = null;
            this.btnMenu.Location = new System.Drawing.Point(173, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(23, 25);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenu.TabIndex = 0;
            this.btnMenu.TabStop = false;
            this.btnMenu.Zoom = 10;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.BorderRadius = 0;
            this.btnSearch.ButtonText = "     Busqueda";
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuAnimator.SetDecoration(this.btnSearch, BunifuAnimatorNS.DecorationType.None);
            this.btnSearch.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSearch.Iconimage")));
            this.btnSearch.Iconimage_right = null;
            this.btnSearch.Iconimage_right_Selected = null;
            this.btnSearch.Iconimage_Selected = null;
            this.btnSearch.IconMarginLeft = 15;
            this.btnSearch.IconMarginRight = 0;
            this.btnSearch.IconRightVisible = true;
            this.btnSearch.IconRightZoom = 0D;
            this.btnSearch.IconVisible = true;
            this.btnSearch.IconZoom = 80D;
            this.btnSearch.IsTab = false;
            this.btnSearch.Location = new System.Drawing.Point(0, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearch.selected = false;
            this.btnSearch.Size = new System.Drawing.Size(213, 48);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "     Busqueda";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Textcolor = System.Drawing.Color.White;
            this.btnSearch.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnConsultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnConsultas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultas.BorderRadius = 0;
            this.btnConsultas.ButtonText = "     Consultas";
            this.btnConsultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuAnimator.SetDecoration(this.btnConsultas, BunifuAnimatorNS.DecorationType.None);
            this.btnConsultas.DisabledColor = System.Drawing.Color.Gray;
            this.btnConsultas.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConsultas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConsultas.Iconimage")));
            this.btnConsultas.Iconimage_right = null;
            this.btnConsultas.Iconimage_right_Selected = null;
            this.btnConsultas.Iconimage_Selected = null;
            this.btnConsultas.IconMarginLeft = 15;
            this.btnConsultas.IconMarginRight = 0;
            this.btnConsultas.IconRightVisible = true;
            this.btnConsultas.IconRightZoom = 0D;
            this.btnConsultas.IconVisible = true;
            this.btnConsultas.IconZoom = 80D;
            this.btnConsultas.IsTab = false;
            this.btnConsultas.Location = new System.Drawing.Point(0, 145);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnConsultas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnConsultas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConsultas.selected = false;
            this.btnConsultas.Size = new System.Drawing.Size(213, 48);
            this.btnConsultas.TabIndex = 6;
            this.btnConsultas.Text = "     Consultas";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.Textcolor = System.Drawing.Color.White;
            this.btnConsultas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // div
            // 
            this.menuAnimator.SetDecoration(this.div, BunifuAnimatorNS.DecorationType.None);
            this.div.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.div.Location = new System.Drawing.Point(1, 186);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(213, 23);
            this.div.TabIndex = 7;
            this.div.Text = "___________________________________________";
            // 
            // btnPacientes
            // 
            this.btnPacientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnPacientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPacientes.BorderRadius = 0;
            this.btnPacientes.ButtonText = "     Pacientes";
            this.btnPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuAnimator.SetDecoration(this.btnPacientes, BunifuAnimatorNS.DecorationType.None);
            this.btnPacientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnPacientes.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPacientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPacientes.Iconimage")));
            this.btnPacientes.Iconimage_right = null;
            this.btnPacientes.Iconimage_right_Selected = null;
            this.btnPacientes.Iconimage_Selected = null;
            this.btnPacientes.IconMarginLeft = 15;
            this.btnPacientes.IconMarginRight = 0;
            this.btnPacientes.IconRightVisible = true;
            this.btnPacientes.IconRightZoom = 0D;
            this.btnPacientes.IconVisible = true;
            this.btnPacientes.IconZoom = 80D;
            this.btnPacientes.IsTab = false;
            this.btnPacientes.Location = new System.Drawing.Point(0, 258);
            this.btnPacientes.Name = "btnPacientes";
            this.btnPacientes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnPacientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnPacientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPacientes.selected = false;
            this.btnPacientes.Size = new System.Drawing.Size(213, 48);
            this.btnPacientes.TabIndex = 3;
            this.btnPacientes.Text = "     Pacientes";
            this.btnPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPacientes.Textcolor = System.Drawing.Color.White;
            this.btnPacientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPacientes.Click += new System.EventHandler(this.btnPacientes_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnHistorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHistorial.BorderRadius = 0;
            this.btnHistorial.ButtonText = "     Historial";
            this.btnHistorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuAnimator.SetDecoration(this.btnHistorial, BunifuAnimatorNS.DecorationType.None);
            this.btnHistorial.DisabledColor = System.Drawing.Color.Gray;
            this.btnHistorial.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHistorial.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHistorial.Iconimage")));
            this.btnHistorial.Iconimage_right = null;
            this.btnHistorial.Iconimage_right_Selected = null;
            this.btnHistorial.Iconimage_Selected = null;
            this.btnHistorial.IconMarginLeft = 15;
            this.btnHistorial.IconMarginRight = 0;
            this.btnHistorial.IconRightVisible = true;
            this.btnHistorial.IconRightZoom = 0D;
            this.btnHistorial.IconVisible = true;
            this.btnHistorial.IconZoom = 80D;
            this.btnHistorial.IsTab = false;
            this.btnHistorial.Location = new System.Drawing.Point(0, 312);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnHistorial.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnHistorial.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHistorial.selected = false;
            this.btnHistorial.Size = new System.Drawing.Size(213, 48);
            this.btnHistorial.TabIndex = 8;
            this.btnHistorial.Text = "     Historial";
            this.btnHistorial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHistorial.Textcolor = System.Drawing.Color.White;
            this.btnHistorial.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // btnReservaciones
            // 
            this.btnReservaciones.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnReservaciones.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.btnReservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnReservaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReservaciones.BorderRadius = 0;
            this.btnReservaciones.ButtonText = "     Citas";
            this.btnReservaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuAnimator.SetDecoration(this.btnReservaciones, BunifuAnimatorNS.DecorationType.None);
            this.btnReservaciones.DisabledColor = System.Drawing.Color.Gray;
            this.btnReservaciones.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservaciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReservaciones.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReservaciones.Iconimage")));
            this.btnReservaciones.Iconimage_right = null;
            this.btnReservaciones.Iconimage_right_Selected = null;
            this.btnReservaciones.Iconimage_Selected = null;
            this.btnReservaciones.IconMarginLeft = 15;
            this.btnReservaciones.IconMarginRight = 0;
            this.btnReservaciones.IconRightVisible = true;
            this.btnReservaciones.IconRightZoom = 0D;
            this.btnReservaciones.IconVisible = true;
            this.btnReservaciones.IconZoom = 80D;
            this.btnReservaciones.IsTab = false;
            this.btnReservaciones.Location = new System.Drawing.Point(3, 366);
            this.btnReservaciones.Name = "btnReservaciones";
            this.btnReservaciones.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.btnReservaciones.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(34)))));
            this.btnReservaciones.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReservaciones.selected = false;
            this.btnReservaciones.Size = new System.Drawing.Size(213, 48);
            this.btnReservaciones.TabIndex = 9;
            this.btnReservaciones.Text = "     Citas";
            this.btnReservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReservaciones.Textcolor = System.Drawing.Color.White;
            this.btnReservaciones.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservaciones.Click += new System.EventHandler(this.btnReservaciones_Click);
            // 
            // PanelContainer
            // 
            this.PanelContainer.Controls.Add(this.panelConsulta1);
            this.PanelContainer.Controls.Add(this.panelCitas1);
            this.PanelContainer.Controls.Add(this.historialPanel1);
            this.PanelContainer.Controls.Add(this.rolPanel1);
            this.PanelContainer.Controls.Add(this.panelUsuario1);
            this.PanelContainer.Controls.Add(this.pacientePanel1);
            this.PanelContainer.Controls.Add(this.homePanel1);
            this.PanelContainer.Controls.Add(this.searchPanel1);
            this.PanelContainer.Controls.Add(this.specialityPanel1);
            this.PanelContainer.Controls.Add(this.doctorPanel1);
            this.PanelContainer.Controls.Add(this.panelNotitify);
            this.menuAnimator.SetDecoration(this.PanelContainer, BunifuAnimatorNS.DecorationType.None);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(218, 35);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(806, 685);
            this.PanelContainer.TabIndex = 2;
            // 
            // panelConsulta1
            // 
            this.menuAnimator.SetDecoration(this.panelConsulta1, BunifuAnimatorNS.DecorationType.None);
            this.panelConsulta1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConsulta1.Location = new System.Drawing.Point(0, 0);
            this.panelConsulta1.Name = "panelConsulta1";
            this.panelConsulta1.Size = new System.Drawing.Size(806, 650);
            this.panelConsulta1.TabIndex = 10;
            // 
            // panelCitas1
            // 
            this.menuAnimator.SetDecoration(this.panelCitas1, BunifuAnimatorNS.DecorationType.None);
            this.panelCitas1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCitas1.Location = new System.Drawing.Point(0, 0);
            this.panelCitas1.Name = "panelCitas1";
            this.panelCitas1.Size = new System.Drawing.Size(806, 650);
            this.panelCitas1.TabIndex = 9;
            // 
            // historialPanel1
            // 
            this.menuAnimator.SetDecoration(this.historialPanel1, BunifuAnimatorNS.DecorationType.None);
            this.historialPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historialPanel1.Location = new System.Drawing.Point(0, 0);
            this.historialPanel1.Name = "historialPanel1";
            this.historialPanel1.Size = new System.Drawing.Size(806, 650);
            this.historialPanel1.TabIndex = 8;
            // 
            // rolPanel1
            // 
            this.menuAnimator.SetDecoration(this.rolPanel1, BunifuAnimatorNS.DecorationType.None);
            this.rolPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rolPanel1.Location = new System.Drawing.Point(0, 0);
            this.rolPanel1.Name = "rolPanel1";
            this.rolPanel1.Size = new System.Drawing.Size(806, 650);
            this.rolPanel1.TabIndex = 7;
            // 
            // panelUsuario1
            // 
            this.menuAnimator.SetDecoration(this.panelUsuario1, BunifuAnimatorNS.DecorationType.None);
            this.panelUsuario1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsuario1.Location = new System.Drawing.Point(0, 0);
            this.panelUsuario1.Name = "panelUsuario1";
            this.panelUsuario1.Size = new System.Drawing.Size(806, 650);
            this.panelUsuario1.TabIndex = 6;
            // 
            // pacientePanel1
            // 
            this.menuAnimator.SetDecoration(this.pacientePanel1, BunifuAnimatorNS.DecorationType.None);
            this.pacientePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pacientePanel1.Location = new System.Drawing.Point(0, 0);
            this.pacientePanel1.Name = "pacientePanel1";
            this.pacientePanel1.Size = new System.Drawing.Size(806, 650);
            this.pacientePanel1.TabIndex = 5;
            // 
            // homePanel1
            // 
            this.menuAnimator.SetDecoration(this.homePanel1, BunifuAnimatorNS.DecorationType.None);
            this.homePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePanel1.Location = new System.Drawing.Point(0, 0);
            this.homePanel1.Name = "homePanel1";
            this.homePanel1.Size = new System.Drawing.Size(806, 650);
            this.homePanel1.TabIndex = 4;
            // 
            // searchPanel1
            // 
            this.searchPanel1.CitasPanel = null;
            this.menuAnimator.SetDecoration(this.searchPanel1, BunifuAnimatorNS.DecorationType.None);
            this.searchPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchPanel1.DoctorPanel = null;
            this.searchPanel1.Location = new System.Drawing.Point(0, 0);
            this.searchPanel1.Name = "searchPanel1";
            this.searchPanel1.PacientePanel = null;
            this.searchPanel1.Size = new System.Drawing.Size(806, 650);
            this.searchPanel1.TabIndex = 3;
            // 
            // specialityPanel1
            // 
            this.specialityPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuAnimator.SetDecoration(this.specialityPanel1, BunifuAnimatorNS.DecorationType.None);
            this.specialityPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.specialityPanel1.Location = new System.Drawing.Point(0, 0);
            this.specialityPanel1.Name = "specialityPanel1";
            this.specialityPanel1.Size = new System.Drawing.Size(806, 650);
            this.specialityPanel1.TabIndex = 2;
            // 
            // doctorPanel1
            // 
            this.doctorPanel1.AutoSize = true;
            this.menuAnimator.SetDecoration(this.doctorPanel1, BunifuAnimatorNS.DecorationType.None);
            this.doctorPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctorPanel1.Location = new System.Drawing.Point(0, 0);
            this.doctorPanel1.Name = "doctorPanel1";
            this.doctorPanel1.Size = new System.Drawing.Size(806, 650);
            this.doctorPanel1.TabIndex = 0;
            // 
            // panelNotitify
            // 
            this.panelNotitify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuAnimator.SetDecoration(this.panelNotitify, BunifuAnimatorNS.DecorationType.None);
            this.panelNotitify.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelNotitify.Location = new System.Drawing.Point(0, 650);
            this.panelNotitify.Name = "panelNotitify";
            this.panelNotitify.Size = new System.Drawing.Size(806, 35);
            this.panelNotitify.TabIndex = 1;
            this.panelNotitify.Visible = false;
            // 
            // nowToolStripMenuItem
            // 
            this.nowToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nowToolStripMenuItem.Name = "nowToolStripMenuItem";
            this.nowToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.nowToolStripMenuItem.Text = "Busqueda General";
            this.nowToolStripMenuItem.Click += new System.EventHandler(this.nowToolStripMenuItem_Click);
            // 
            // cerrarSesToolStripMenuItem
            // 
            this.cerrarSesToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cerrarSesToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cerrarSesToolStripMenuItem.Name = "cerrarSesToolStripMenuItem";
            this.cerrarSesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.cerrarSesToolStripMenuItem.Text = "Cerrar Sessión";
            this.cerrarSesToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // menuAnimator
            // 
            this.menuAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.menuAnimator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.menuAnimator.DefaultAnimation = animation1;
            this.menuAnimator.TimeStep = 0.026F;
            // 
            // dragWindows
            // 
            this.dragWindows.Fixed = true;
            this.dragWindows.Horizontal = true;
            this.dragWindows.TargetControl = this.HeaderTitle;
            this.dragWindows.Vertical = true;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.SideBarMenu);
            this.Controls.Add(this.HeaderTitle);
            this.menuAnimator.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 720);
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CmSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.HeaderTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.panel3.ResumeLayout(false);
            this.horizontalMenu.ResumeLayout(false);
            this.horizontalMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.SideBarMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.PanelContainer.ResumeLayout(false);
            this.PanelContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel HeaderTitle;
        private System.Windows.Forms.Panel SideBarMenu;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btnDoctores;
        private Bunifu.Framework.UI.BunifuImageButton btnMenu;
        private System.Windows.Forms.Panel PanelContainer;
        private View.DoctorPanel doctorPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.MenuStrip horizontalMenu;
        private System.Windows.Forms.ToolStripMenuItem cMSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Panel SlidePanel;
        private System.Windows.Forms.ToolStripMenuItem busquedaGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSessiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem1;
        private Bunifu.Framework.UI.BunifuFlatButton btnConsultas;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearch;
        private Bunifu.Framework.UI.BunifuFlatButton btnHome;
        private Bunifu.Framework.UI.BunifuFlatButton btnPacientes;
        private System.Windows.Forms.Label div;
        private Bunifu.Framework.UI.BunifuFlatButton btnReservaciones;
        private Bunifu.Framework.UI.BunifuFlatButton btnHistorial;
        private Bunifu.Framework.UI.BunifuImageButton minimizeButton;
        private Bunifu.Framework.UI.BunifuImageButton maximizeButton;
        private BunifuAnimatorNS.BunifuTransition menuAnimator;
        private System.Windows.Forms.Panel panelNotitify;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadesToolStripMenuItem;
        private View.SpecialityPanel specialityPanel1;
        private Bunifu.Framework.UI.BunifuDragControl dragWindows;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private View.SearchPanel searchPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private View.Panels.HomePanel homePanel1;
        private View.PacientePanel pacientePanel1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private View.Panels.UserPanel panelUsuario1;
        private View.Panels.RolPanel rolPanel1;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private View.Panels.HistorialPanel historialPanel1;
        private View.Panels.PanelCitas panelCitas1;
        private View.Panels.PanelConsulta panelConsulta1;
    }
}

