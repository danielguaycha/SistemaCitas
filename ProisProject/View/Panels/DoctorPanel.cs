using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProisProject.Model;
using ProisProject.View.Components;
using ProisProject.Controller;
using ProisProject.Model.Data;
using System.Globalization;

namespace ProisProject.View
{
    
    public partial class DoctorPanel : UserControl
    {

        MedicController mc = null;
        SpecialtyController sc = null;
        public long selectedPerson = 0;
        public string oldDni ="";
        public DoctorPanel()
        {
            InitializeComponent();
            mc = new MedicController();
            sc = new SpecialtyController();
        }

        /*Add items to Especialidad*/
        private void _loadItemsEspecialidad(List<String> items) {
            if (txtEspecialidad.Items.Count >= 1)
                txtEspecialidad.Items.Clear();
            foreach (String item in items) {
                this.txtEspecialidad.Items.Add(item);
            }
        }
        public void _loadItemsEspecialidadEdit(List<String> items)
        {
            if (txteditespecialidad.Items.Count >= 1)
                txteditespecialidad.Items.Clear();
            foreach (String item in items)
            {
                this.txteditespecialidad.Items.Add(item);
            }
        }

        /*Clear inputs*/
        private void _clearRegisterInputs() {
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtEstadoCiv.SelectedIndex = -1;
            txtTel.Text = "";
            txtFNac.Text = "";
            txtEdad.Text = "";
            txtPeso.Text = "";
            txtSangre.Text = "";
            txtDiscapacidad.Text = "Ninguna";
            txtTalla.Text = "";
            txtTitulo.Text = "";
            txtEspecialidad.SelectedIndex  = - 1;
        }

        private void _clearEditInputs() {
            txteditCedula.Text = "";
            txteditNombre.Text = "";
            txteditApellido.Text = "";
            txteditDir.Text = "";
            txteditMail.Text = "";
            txteditEstCiv.SelectedIndex = -1;
            txteditTel.Text = "";
            txteditFNacimiento.Text = "";
            txteditEdad.Text = "";
            txteditPeso.Text = "";
            txteditSangre.Text = "";
            txteditDiscapacidad.Text = "Ninguna";
            txteditAltura.Text = "";
            txteditTitulo.Text = "";
            txteditespecialidad.SelectedIndex = -1;
            selectedPerson = 0;
            btnCancel.Hide();
            btnDelete.Hide();
            btnUpdate.Hide();
        }
        private void btnSaveDoctor_Click(object sender, EventArgs e)
        {
            if (!UtilController.VerificarCedula(txtCedula.Text))
            {
                Notification.Show("Ingrese un numero de cedula valido", AlertType.warm);
                return;
            }

            if (mc.exist(txtCedula.Text)) {
                Notification.Show("Ya existe una persona registrada con esta cédula", AlertType.warm);
                return;
            }

            Medico med = new Medico();
            med.Persona = new Persona();

            med.Persona.dni = txtCedula.Text;
            med.Persona.nombre = txtNombre.Text;
            med.Persona.apellido = txtApellido.Text;
            med.Persona.email = txtEmail.Text.Trim();
            med.Persona.telefono = txtTel.Text.Trim();
            med.Persona.edad = (txtEdad.Text == "") ? 0 : int.Parse(txtEdad.Text);
            med.Persona.peso = (txtPeso.Text =="")? 0 : decimal.Parse(txtPeso.Text);
            med.Persona.altura = (txtTalla.Text.Equals("")) ? 0 : decimal.Parse(txtTalla.Text);
            med.Persona.sangre = txtSangre.Text;
            med.Persona.fnac = (txtFNac.Text.Equals(""))?DateTime.Now:DateTime.Parse(txtFNac.Text);
            med.Persona.ecivil = txtEstadoCiv.Text;
            med.Persona.direccion = txtDireccion.Text;
            med.Persona.status = 1;
            if (rdDoctor.Checked)
                med.Persona.tipo = 1;
            else if (rdEnfermera.Checked)
                med.Persona.tipo = 2;
            med.status = 1;
            med.titulo = txtTitulo.Text;
            med.id_especialidad = txtEspecialidad.SelectedIndex+1;
            
            
            String data = mc.validate(med);
            if (data == "")
            {
                if (!mc.exist(med.Persona.dni))
                {
                    if (mc.store(med))
                    {
                        _clearRegisterInputs();
                        Notification.Show("Registro realizado con exito.", AlertType.ok, 5000);
                    }
                    else
                    {
                        Notification.Show("Ocurrió un error al validar sus datos, intentelo de nuevo.", AlertType.error, Notification.HIGHT);
                    }
                }
                else {
                    Notification.Show("Ya existe un registro con la cedula proporcionada", AlertType.info);
                }
            }
            else
            {
                Notification.Show(data, AlertType.warm, 5000);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            _clearRegisterInputs();
        }

        private void txteditCedula_Leave(object sender, EventArgs e)
        {
            if (txteditCedula.Text == "")
                return;

            string cedula = txteditCedula.Text;
            Medico med = mc.edit(cedula);
            if (med != null)
            {
                _loadItemsEspecialidadEdit(sc.list());
                oldDni = txteditCedula.Text;
                selectedPerson = med.id_person.Value;
                txteditNombre.Text = med.Persona.nombre;
                txteditApellido.Text = med.Persona.apellido;
                txteditMail.Text = med.Persona.email;
                txteditDir.Text = med.Persona.direccion;
                txteditEstCiv.SelectedItem = med.Persona.ecivil;
                txteditTel.Text = med.Persona.telefono;
                txteditFNacimiento.Text = med.Persona.fnac.ToString();
                txteditEdad.Text = med.Persona.edad.ToString();
                txteditPeso.Text = med.Persona.peso + "";
                txteditSangre.Text = med.Persona.sangre;
                txteditAltura.Text = med.Persona.altura + "";
                txteditDiscapacidad.Text = "Ninguna";
                txteditTitulo.Text = med.titulo;
                txteditespecialidad.SelectedItem = sc.getById(med.id_especialidad.Value).nombre;
                btnCancel.Show();
                btnUpdate.Show();
                btnDelete.Show();
            }
            else {
                if (selectedPerson <= 0)
                {
                    _clearEditInputs();
                    txteditCedula.Text = cedula;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.selectedPerson > 0)
            {
                var confirmResult = MessageBox.Show("¿Estás seguro que deseeas eliminar este Médico?",
                                     "Confirmar Borrado!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    mc.delete(int.Parse(selectedPerson+""));
                    Notification.Show("Registro Eliminado con exito", AlertType.ok, Notification.LOW);
                    _clearEditInputs();
                }
            }
            else {
                Notification.Show("Asegurese de seleccionar el medico que desea modificar", AlertType.info, Notification.HIGHT);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _clearEditInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedPerson == 0) {
                Notification.Show("Necesitas seleccionar un médico para actualizar datos", AlertType.info, Notification.NORMAL);
                return;
            }
            if (!UtilController.VerificarCedula(txteditCedula.Text)) {
                Notification.Show("Ingrese un numero de cedula valido", AlertType.warm);
                return;
            }

            if (oldDni != txteditCedula.Text) {
                if (mc.exist(txteditCedula.Text)) {
                    Notification.Show("No puedes asignar este nuevo dni, otro registro la yo esta usando", AlertType.info);
                    return;
                }
            }

            Medico med = new Medico();
            med.Persona = new Persona();

            med.Persona.dni = txteditCedula.Text;
            med.Persona.nombre = txteditNombre.Text;
            med.Persona.apellido = txteditApellido.Text;
            med.Persona.email = txteditMail.Text.Trim();
            med.Persona.telefono = txteditTel.Text.Trim();
            med.Persona.edad = (txteditEdad.Text == "") ? 0 : int.Parse(txteditEdad.Text);
            med.Persona.peso = (txteditPeso.Text == "") ? 0 : decimal.Parse(txteditPeso.Text);
            med.Persona.altura = (txteditAltura.Text.Equals("")) ? 0 : decimal.Parse(txteditAltura.Text);
            med.Persona.sangre = txteditSangre.Text;
            med.Persona.fnac = (txteditFNacimiento.Text.Equals("")) ? DateTime.Now : DateTime.Parse(txteditFNacimiento.Text);
            med.Persona.ecivil = txteditEstCiv.Text;
            med.Persona.direccion = txteditDir.Text;

            int id_especialidad = sc.getByName(txteditespecialidad.SelectedItem.ToString()).id_especialidad;
            med.titulo = txteditTitulo.Text;
            med.id_especialidad = id_especialidad;
            if (radioEditDoctor.Checked)
                med.Persona.tipo = 1;
            else if (radioEditEnfermera.Checked)
                med.Persona.tipo = 2;
            
            String validate = mc.validate(med);
            if (validate != "")
            {
                Notification.Show(validate, AlertType.warm, Notification.HIGHT);
                return;
            }

            mc.update(int.Parse(selectedPerson+""), med);
            _clearEditInputs();
            Notification.Show("Actualización realizada con exito", AlertType.ok, Notification.LOW);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmSearch f = new FrmSearch(this);
            f.ShowDialog();
        }

        private void txtEspecialidad_MouseClick(object sender, MouseEventArgs e)
        {
            
            this._loadItemsEspecialidad(sc.list());

        }

        private void txteditEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validaNumerosDecimales(e);
            
        }

        private void txteditPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validaNumerosDecimales(e);
        }

        private void txteditAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validaNumerosDecimales(e);
        }

        private void txteditNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validaLetras(e);
        }

        private void txteditApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validaLetras(e);
        }

        private void txteditTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validaLetras(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validaLetras(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validaLetras(e);
        }

        private void txtTitulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validaLetras(e);
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validaNumerosDecimales(e);
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validaNumerosDecimales(e);
        }

        private void txtTalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validaNumerosDecimales(e);
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validarNumeros(e);
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validarNumeros(e);
        }

        private void txteditCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validarNumeros(e);
        }

        private void txteditTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validarNumeros(e);
        }
    }
}
