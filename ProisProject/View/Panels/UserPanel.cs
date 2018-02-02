using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProisProject.Controller;
using ProisProject.Model.Data;
using ProisProject.View.Components;
namespace ProisProject.View.Panels
{
    public partial class UserPanel : UserControl
    {
        RolController rc = new RolController();
        UserController uc = new UserController();
        public UserPanel()
        {
            InitializeComponent();
            txtSendEmail.Enabled = UtilController.haveInternet();
        }

        private void txtRol_Click(object sender, EventArgs e)
        {
            if (txtRol.Items.Count > 0)
                txtRol.Items.Clear();

            List<Rol> rol = rc.get();
            foreach(Rol r in rol)
            {
                txtRol.Items.Add(r.nombre_rol);
            }
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            FrmSearch fr = new FrmSearch(this);
            fr.ShowDialog();
        }

        private void btnGenClave_Click(object sender, EventArgs e)
        {
            txtClave.Text = UtilController.GenerarContraseña();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == "")
            {
                Notification.Show("Es necesario escoger una persona primero", AlertType.warm);
                return;
            }
            if (txtRol.SelectedIndex < 0) {
                Notification.Show("Selecciona un rol primero", AlertType.warm);
                return;
            }
            if (txtClave.Text == "") {
                Notification.Show("Genera o ingresa una clave de acceso para este usuario.", AlertType.warm);
                return;
            }

            if (uc.exist(txtCedula.Text)) {
                Notification.Show("Esta persona ya esta asignado como usuario del sistema", AlertType.info);
                return;
            }

            var confirmResult = MessageBox.Show("¿Estás seguro que deseeas crear un usuario para "+txtSearch.Text+" con el rol "+ txtRol.SelectedItem.ToString() + "?",
                                     "Confirmar la creación!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                Usuario s = new Usuario();
                s.id_person = uc.getIdByCedula(txtCedula.Text).id_person;
                s.id_rol = rc.getRolIdByName(txtRol.SelectedItem.ToString());
                s.password = UtilController.Encriptar(txtClave.Text);
                s.status = 0;
                if (UtilController.haveInternet() && txtSendEmail.Checked && UtilController.IsValidEmail(txtEmail.Text))
                {
                    Model.Mail m = new Model.Mail(txtEmail.Text, UtilController.TEMPLATEMAILPASSWORD.Replace("{clave}", txtClave.Text), "Clave de Acceso - CMSystem", "");
                    m.Send();
                }
                uc.store(s);
                _clearInputs();
                Notification.Show("Usuario registrado con exito : ID -" + s.id_usuario, AlertType.ok);
            }

        }

        private void _clearInputs()
        {
            txtClave.Text = "";
            txtEmail.Text = "";
            txtSearch.Text = "";
            txtRol.SelectedIndex = 0;
            txtCedula.Text = "";
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            if (tbUsers.Rows.Count > 0) {
                tbUsers.Rows.Clear();
            }
            foreach (Usuario u in uc.get()) {
                string stado = "";
                if (u.status == 0)
                    stado = "Inicio por primera vez.";
                else if (u.status == 1)
                    stado = "Inicio concedido";
                else if (u.status == 2)
                    stado = "Acceso denegado";
                Console.WriteLine(u.Persona.nombre+"->"+u.Rol.nombre_rol);
                tbUsers.Rows.Add(u.Persona.dni, u.Persona.nombre, u.Rol.nombre_rol, stado);
            }
        }

        private void tbUsers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            upRolEdit();

            Persona p = uc.getIdByCedula(tbUsers.CurrentRow.Cells[0].Value.ToString());
            txtEditCedula.Text = p.dni +" - "+p.nombre+" "+p.apellido;
            txteditCorreo.Text = (p.email == null || p.email == "") ? "No Disponible":p.email;

            txteditRol.SelectedItem = tbUsers.CurrentRow.Cells[2].Value.ToString();
            txtEditSendEmail.Enabled = !(p.email == null || p.email == "");
            btnCancel.Show();
            btnUpdate.Show();
            btnDelete.Show();
        }

        public void upRolEdit() {
            if (txteditRol.Items.Count > 0)
                txteditRol.Items.Clear();

            List<Rol> rol = rc.get();
            foreach (Rol r in rol)
            {
                txteditRol.Items.Add(r.nombre_rol);
            }
        }

        private void btnEditGenerate_Click(object sender, EventArgs e)
        {
            txtEditClave.Text = UtilController.GenerarContraseña();
        }

        private void _clearEditInputs() {
            txtEditCedula.Text = "";
            txtEditClave.Text = "";
            txteditRol.SelectedIndex = -1;
            txteditCorreo.Text = "";
            txtEditSendEmail.Enabled = true;
            txtEditSendEmail.Checked = false;
            btnUpdate.Hide();
            btnDelete.Hide();
            btnCancel.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _clearEditInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtEditCedula.Text == "")
            {
                Notification.Show("Es necesario escoger una persona primero", AlertType.warm);
                return;
            }
            if (txteditRol.SelectedIndex < 0)
            {
                Notification.Show("Selecciona un rol primero", AlertType.warm);
                return;
            }

            String ced = txtEditCedula.Text.Split('-')[0].Trim();
            if (uc.exist(ced))
            {
                var confirmResult = MessageBox.Show("¿Estás seguro que deseeas actualizar el usuario  " + txtEditCedula.Text + " con el rol " + txteditRol.SelectedItem.ToString() + "?",
                                     "Confirmar la actualización!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    if (UtilController.haveInternet() && txtEditSendEmail.Checked && UtilController.IsValidEmail(txteditCorreo.Text))
                    {
                        Model.Mail m = new Model.Mail(txtEmail.Text, UtilController.TEMPLATEMAILPASSWORD.Replace("{clave}", txtClave.Text), "Clave de Acceso - CMSystem", "");
                        m.Send();
                    }
                    Usuario u = new Usuario();
                    u.id_person = uc.getIdByCedula(ced).id_person;
                    u.id_rol = rc.getRolIdByName(txteditRol.SelectedItem.ToString());
                    u.password = UtilController.Encriptar(txtEditClave.Text).Trim();
                    u.status = 0;
                    uc.update(u);
                    _clearEditInputs();
                    UserPanel_Load(null, null);
                    Notification.Show("Datos actualizados con exito", AlertType.ok);
                }
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (txtEditCedula.Text == "")
            {
                Notification.Show("Es necesario escoger una persona primero", AlertType.warm);
                return;
            }

            String ced = txtEditCedula.Text.Split('-')[0].Trim();
            long id_person = uc.getIdByCedula(ced).id_person;
            if (uc.exist(ced))
            {
                var confirmResult = MessageBox.Show("¿Estás seguro que deseeas Eliminar el usuario  " + txtEditCedula.Text + " con el rol " + txteditRol.SelectedItem.ToString() + "?",
                                     "Confirmar la Eliminación!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {

                    uc.delete(id_person, -1);
                    Notification.Show("El usuario ha sido dado de baja con exito", AlertType.ok);
                }
            }
        }
    }
}
