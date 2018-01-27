using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProisProject
{
   
    public partial class Index : Form
    {
        private static bool MAXIMIZED = false;
        public static Panel PANELNOTIFY;
        public static Label TEXTNOTIFY;
        public static Label ICONOTIFY;
        public Index()
        {
            InitializeComponent();
            doctorPanel1.Width = PanelContainer.Width;
            doctorPanel1.BringToFront();
            horizontalMenu.Renderer = new MyRenderer();
            PANELNOTIFY = this.panelNotitify;

            String body = Controller.UtilController.TEMPLATEMAILPASSWORD.Replace("{clave}", "123456789000").Replace("{destinatario}", "danielguaycha@gmail.com");
           // Controller.UtilController.sendMail("danielguaycha@gmail.com", body, "Mail Password","");
        }

        public void coloqueFocus(Bunifu.Framework.UI.BunifuFlatButton b)
        {
            SlidePanel.Height = b.Height;
            SlidePanel.Top = b.Top;
        }
             

        private void btnClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoctores_Click(object sender, EventArgs e)
        {
            doctorPanel1.BringToFront();
            coloqueFocus(btnDoctores);
        }

        private void nowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cerrarSesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
           // Left = Top = 0;
           // Width = Screen.PrimaryScreen.WorkingArea.Width;
           // Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (MAXIMIZED)
            {
                WindowState = FormWindowState.Normal;
                MAXIMIZED = false;
            }
            else
            {
                WindowState = FormWindowState.Maximized;
                MAXIMIZED = true;
            }

        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            coloqueFocus(btnHome);
            homePanel1.BringToFront();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            coloqueFocus(btnSearch);
            searchPanel1.BringToFront();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            coloqueFocus(btnConsultas);
            panelConsulta1.BringToFront();
        }

        private void btnPacientes_Click(object sender, EventArgs e)
        {
            coloqueFocus(btnPacientes);
            pacientePanel1.BringToFront();
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            coloqueFocus(btnHistorial);
            historialPanel1.BringToFront();
        }

        private void btnReservaciones_Click(object sender, EventArgs e)
        {
            coloqueFocus(btnReservaciones);
            panelCitas1.BringToFront();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (SideBarMenu.Width == 218)
            {
                SideBarMenu.Visible = false;
                SideBarMenu.Width = 70;
                menuAnimator.ShowSync(SideBarMenu);
            }
            else {
                SideBarMenu.Visible = false;
                SideBarMenu.Width = 218;
                menuAnimator.ShowSync(SideBarMenu);
            }

        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            specialityPanel1.BringToFront();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelUsuario1.BringToFront();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rolPanel1.BringToFront();
        }
    }

    public class MyRenderer : ToolStripProfessionalRenderer
    {
        public MyRenderer() : base(new MyColors()) { }
    }

    public class MyColors : ProfessionalColorTable
    {
        public override Color MenuBorder { get; }
        public override Color MenuItemBorder { get; }
        public override Color MenuItemSelected
        {
            get { return Color.FromArgb(223, 221, 218); }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.FromArgb(21, 22, 24); }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.FromArgb(21, 22, 24); }
        }
        public override Color MenuItemPressedGradientBegin { get { return Color.FromArgb(21, 22, 24); } }
        public override Color MenuItemPressedGradientEnd { get { return Color.FromArgb(21, 22, 24); } }
       
    }

}
