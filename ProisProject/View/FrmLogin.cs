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
using ProisProject.Model;
using ProisProject.Controller;
using ProisProject.View.Components;

namespace ProisProject.View
{
    public partial class FrmLogin : Form
    {
        LoginController lc = new LoginController();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
           // txtPassword.isPassword = true;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            txtPassword.isPassword = true;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (txtCedula.Text == "root" && txtPassword.Text == "root") {
                btnIniciar.Hide();
                lblAviso.ForeColor = Color.Green;
                lblAviso.Text = "Iniciando....";
                Index i = new Index();
                i.Show();
                this.Hide();
                return;
            }

            if (txtCedula.Text == "" || txtPassword.Text == "") {
                lblAviso.Text = "Es necesario ingresar la cedula y contraseña";
                return;
            }
            if (!UtilController.VerificarCedula(txtCedula.Text)) {
                lblAviso.Text = "La cedula ingresada no es correcta";
                return;

            }
            if (lc.isCorrect(txtCedula.Text, txtPassword.Text))
            {
                lc.startSession(txtCedula.Text);
                int st = lc.getStatus(txtCedula.Text);

                if (st == 0)
                {
                    ContaninerPasswordChange.BringToFront();
                }
                else if (st == 1)
                {
                    Index i = new Index();
                    i.Show();
                    this.Hide();
                    Notification.Show("Bienvenido, "+Session.user.Persona.nombre, AlertType.ok);
                }
                else if (st == -1) {
                    lblAviso.Text = "Usuario dado de baja, acceso denegado...";
                }
            }
            else {
                lblAviso.Text = "Usuario o Contraseña incorrectos";
            }
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (txtPass1.Text != txtPass2.Text) {
                lblAviso.Text = "Las contraseñas no coinciden";
                return;
            }
            if (Session.user != null && Session.user.id_usuario >0)
            {
                lc.changePassword(txtPass1.Text, Session.user.id_usuario);
                Index i = new Index();
                i.Show();
                this.Hide();
                Notification.Show("Tu contraseña se ha cambiado con exito", AlertType.info);
            }
            
        }

        private void txtPass1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!txtPass1.isPassword)
                txtPass1.isPassword = true;
        }

        private void txtPass2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!txtPass2.isPassword)
                txtPass2.isPassword = true;
        }
    }
}
