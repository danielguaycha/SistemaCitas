using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProisProject.Model.Data;
namespace ProisProject.View
{
    public partial class FrmViewHistorial : Form
    {
        
        public FrmViewHistorial()
        {
            InitializeComponent();
        }

        public FrmViewHistorial(Consulta c) {
            InitializeComponent();
            if (c != null && c.id_consulta >0)
            {

                txtCedula.Text = c.Cita.Persona.dni;
                txtNombre.Text = c.Cita.Persona.nombre + "" + c.Cita.Persona.apellido;
                txtEdad.Text = c.Cita.Persona.edad + "";
                txtTel.Text = c.Cita.Persona.telefono;
                txtFecha.Text = c.Cita.fecha.Value.ToString("dd/MM/yyyy");
                txtDiagnostico.Text = c.diagnostico;
                txtMedicacion.Text = c.medicacion;
                txtPrescripcion.Text = c.prescripcion;
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
