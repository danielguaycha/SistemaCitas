using ProisProject.View.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProisProject.View
{
    public partial class FrmSearch : Form
    {
        
        public FrmSearch()
        {
            InitializeComponent();
        }
        public FrmSearch(Panels.PanelCitas pc)
        {
            InitializeComponent();
            int x = Screen.PrimaryScreen.WorkingArea.Width;
            this.Left = ((x - this.Width) / 2) + 109;
            this.Top = (searchPanel1.txtType.Location.X) - 30;
            searchPanel1.CitasPanel = pc;

            searchPanel1.rdCitas.Visible = false;
            searchPanel1.rdPacientes.Visible = false;
            searchPanel1.rdMedicos.Visible = true;

            searchPanel1.txtType.Text = "Médicos";

            searchPanel1.rdCitas.Checked = false;
            searchPanel1.rdPacientes.Checked = false;
            searchPanel1.rdMedicos.Checked = true;
            searchPanel1.setinstructions(1);
        }

        public FrmSearch(Panels.PanelCitas citas, int a = 1) {
            InitializeComponent();
            int x = Screen.PrimaryScreen.WorkingArea.Width;
            this.Left = ((x - this.Width) / 2) + 109;
            this.Top = (searchPanel1.txtType.Location.X) - 30;

            searchPanel1.CitasPanel = citas;
            searchPanel1.rdCitas.Visible = true;
            searchPanel1.rdPacientes.Visible = false;
            searchPanel1.rdMedicos.Visible = false;
            searchPanel1.txtType.Text = "Citas";
            searchPanel1.rdCitas.Checked = true;
            searchPanel1.rdPacientes.Checked = false;
            searchPanel1.rdMedicos.Checked = false;
            searchPanel1.setinstructions(3);

        }

        public FrmSearch(DoctorPanel a) {
            InitializeComponent();
            searchPanel1.DoctorPanel = a;
            int x = Screen.PrimaryScreen.WorkingArea.Width;
            this.Left = ((x-this.Width)/2)+109;
            this.Top = (a.label1.Location.X)+90;
     
            searchPanel1.rdCitas.Visible = false;
            searchPanel1.rdPacientes.Visible = false;
            searchPanel1.txtType.Text = "Médicos";
            searchPanel1.rdMedicos.Checked = true;
            searchPanel1.rdMedicos.Enabled = false;
        }

        public FrmSearch(PacientePanel a)
        {
            InitializeComponent();
            searchPanel1.PacientePanel = a;
            int x = Screen.PrimaryScreen.WorkingArea.Width;
            this.Left = ((x - this.Width) / 2) + 109;
            this.Top = (a.label1.Location.X) + 90;

            searchPanel1.rdCitas.Visible = false;
            searchPanel1.rdCitas.Checked = false;

            searchPanel1.rdMedicos.Checked = false;
            searchPanel1.rdMedicos.Visible = false;

            searchPanel1.rdPacientes.Visible = true;
            searchPanel1.rdPacientes.Checked = true;
            searchPanel1.txtType.Text = "Pacientes";
        }

        public FrmSearch(UserPanel p) {
            InitializeComponent();
            searchPanel1.UserPanel = p;
            int x = Screen.PrimaryScreen.WorkingArea.Width;
            this.Left = ((x - this.Width) / 2) + 109;
            this.Top = (p.label1.Location.X) + 90;

            searchPanel1.rdCitas.Visible = false;
            searchPanel1.rdCitas.Checked = false;

            searchPanel1.rdMedicos.Checked = false;
            searchPanel1.rdMedicos.Visible = false;

            searchPanel1.rdPacientes.Visible = false;
            searchPanel1.rdPacientes.Checked = false;
            searchPanel1.txtType.Text = "Usuarios";
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
