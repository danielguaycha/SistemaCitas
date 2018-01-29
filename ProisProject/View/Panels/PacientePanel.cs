using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProisProject.Model.Data;
using ProisProject.Controller;
using ProisProject.View.Components;
namespace ProisProject.View
{
    public partial class PacientePanel : UserControl
    {
        PacientControlller pc = null;
        public string oldDni;
        public PacientePanel()
        {
            InitializeComponent();
            pc = new PacientControlller();
        }
        public void _clearRegisterInputs() {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtedad.Text = "";
            txtTel.Text = "";
        }
        public void _clearUpdateInputs() {
            txtEditCedula.Text = "";
            txteditNombre.Text = "";
            txteditApellido.Text = "";
            txtEditDir.Text = "";
            txtEditEmail.Text = "";
            txtEditEdad.Text = "";
            txteditTel.Text = "";
            oldDni = "";
            btnUpdate.Hide();
            btnDelete.Hide();
            btnCancel.Hide();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "" || txtedad.Text == "" || txtCedula.Text == ""
                     || txtNombre.Text == "" || txtTel.Text == "")
            {
                Notification.Show("Los campos cedula, nombres, apellidos, telefono y edad son requeridos", AlertType.warm);
                return;
            }
            if (!UtilController.VerificarCedula(txtCedula.Text)) {
                Notification.Show("La cedula especificada es invalida", AlertType.warm);
                return;
            }
            if (pc.exist(txtCedula.Text)) {
                Notification.Show("Ya existe un registro con esta cedula", AlertType.info);
                return;
            }
            Persona per = new Persona();
            per.nombre = txtNombre.Text;
            per.apellido = txtApellido.Text;
            per.edad = int.Parse(txtedad.Text);
            per.email = txtEmail.Text;
            per.telefono = txtTel.Text;
            per.dni = txtCedula.Text;
            per.direccion = txtDireccion.Text;
            per.tipo = 3; // paciente
            string validate = pc.validate(per);
            if (validate == "")
            {
                pc.store(per);
                _clearRegisterInputs();
                Notification.Show("Los datos fueron registrados con exito", AlertType.ok);
            }
            else {
                Notification.Show(validate, AlertType.warm);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txteditApellido.Text == "" || txtEditEdad.Text == "" || txtEditCedula.Text == ""
                     || txteditNombre.Text == "" || txteditTel.Text == "")
            {
                Notification.Show("Los campos cedula, nombres, apellidos, telefono y edad son requeridos", AlertType.warm);
                return;
            }

            if (!UtilController.VerificarCedula(txtEditCedula.Text.Trim()))
            {
                Notification.Show("La cedula especificada es invalida", AlertType.warm);
                return;
            }

            if (oldDni !=txtEditCedula.Text)
            {
                if (pc.exist(txtEditCedula.Text))
                {
                    Notification.Show("Ya existe un registro con esta cedula", AlertType.info);
                    return;
                }
            }

            Persona per = new Persona();
            per.nombre = txteditNombre.Text;
            per.apellido = txteditApellido.Text;
            per.edad = int.Parse(txtEditEdad.Text);
            per.email = txtEditEmail.Text;
            per.telefono = txteditTel.Text;
            per.dni = txtEditCedula.Text.Trim();
            per.direccion = txtEditDir.Text;
            per.tipo = 3; // paciente
            string validate = pc.validate(per);
            if (validate == "")
            {
                pc.update(oldDni,per);
                _clearUpdateInputs();
                Notification.Show("Los datos fueron actualizados con exito", AlertType.ok);
            }
            else
            {
                Notification.Show(validate, AlertType.warm);
            }

        }
        private void txtEditCedula_Leave(object sender, EventArgs e)
        {
            if (pc.exist(txtCedula.Text))
            {
                Persona p = pc.Get(txtCedula.Text);
                txteditNombre.Text = p.nombre;
                txteditApellido.Text = p.apellido;
                txtEditDir.Text = p.direccion;
                txtEditEdad.Text = p.edad + "";
                txteditTel.Text = p.telefono;
                txtEditDir.Text = p.direccion;
                txtEditEmail.Text = p.email;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validaLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validaLetras(e);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validaNumeros(e);
        }

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validaNumeros(e);
        }

        private void txteditNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validaLetras(e);
        }

        private void txteditApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validaLetras(e);
        }

        private void txtEditEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validaNumeros(e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _clearUpdateInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Console.Write(oldDni);
            if (this.oldDni!="")
            {
                var confirmResult = MessageBox.Show("¿Estás seguro que deseeas eliminar este paciente?",
                                     "Confirmar Borrado!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    pc.delete(oldDni);
                    _clearUpdateInputs();
                    Notification.Show("Registro Eliminado con exito", AlertType.ok, Notification.LOW);
                }
            }
            else
            {
                Notification.Show("Asegurese de seleccionar el paciente que desea modificar", AlertType.info, Notification.HIGHT);
            }
        }

        private void btnSearchPaciente_Click(object sender, EventArgs e)
        {
            FrmSearch fr = new FrmSearch(this);
            fr.ShowDialog();
        }

        private void txteditTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validaNumeros(e);
        }
    }
}
