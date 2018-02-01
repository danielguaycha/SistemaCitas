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
                s.id_person = uc.getIdByCedula(txtCedula.Text);
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
        
    }
}
