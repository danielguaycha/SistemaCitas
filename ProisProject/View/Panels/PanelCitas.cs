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
    public partial class PanelCitas : UserControl
    {
        PacientControlller pc = new PacientControlller();
        CitasController cc = new CitasController();
        PostDataContext db = new PostDataContext();
        DataTable dt;
        public int id_medic;
        public long id_pacient;
        public long id_cita;

        public PanelCitas()
        {
            InitializeComponent();
            id_medic = 0;
            id_pacient = 0;
            id_cita = 0;
            loadFacturas("");
        }

        public void _clearUpdateInputs()
        {
            id_medic = 0;
            id_pacient = 0;
            id_cita = 0;
            txteEspecialidad.Items.Clear();
            txteCedula.Text = "";
            txteNombresDoc.Text = "";
            txteNombrePAc.Text = "";
            txteApellidos.Text = "";
            txteEdad.Text = "";
            txteTelefono.Text = "";
            txteCosto.Text = "";
            txteRetencion.Text = "0";
            textPendientePago.Checked = false;
            txteFecha.Text = "";
            loadFacturas("");
        }

        public void _clearRegisterInputs()
        {
            id_medic = 0;
            id_pacient = 0;
            txtNombreDoc.Text = "";
            txtEspecialidadDoc.Items.Clear();
            txtCedulaPac.Text = "";
            txtNombrePac.Text = "";
            txtApellidosPac.Text = "";
            txtEdadPac.Text = "";
            txtTelPac.Text = "";
            txtCosto.Text = "";
            txtRetencion.Text = "0";
            txtPendientePAgo.Checked = false;
            txtFecha.Text = "";
            loadFacturas("");
        }

        public void loadFacturas(String dato) {
            db = null;
            db = new PostDataContext();
            dt = new DataTable();
            
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Paciente");
            dt.Columns.Add("Médico");
            dt.Columns.Add("Estado");
            dt.Columns.Add("Retención");
            dt.Columns.Add("Valor Neto");
            dt.Columns.Add("Total");
            var q = from fac in db.Cita where fac.status>=0 &&(
                    fac.Persona.dni.Contains(dato) || 
                    fac.Persona.nombre.Contains(dato)) select fac;

            foreach (Cita c in q) {
                string estado = "";
                switch (c.status)
                {
                    case 0:
                        estado = "PENDIENTE PAGO";
                        break;
                    case 1:
                        estado = "PAGADA";
                        break;
                    case 2:
                        estado = "ATENDIDA";
                        break;
                }
                dt.Rows.Add(new Object[] { c.fecha.Value.ToString("dd/MM/yyyy")
                    , c.Persona.nombre +" "+c.Persona.apellido,
                    c.Medico.Persona.nombre + " "+c.Medico.Persona.apellido,estado,
                    UtilController.f(c.retencion.Value), UtilController.f(c.precio.Value), UtilController.f(c.precio.Value - ((c.precio*c.retencion)/100).Value)

                });

            }
            tbFacturas.DataSource = dt;
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            FrmSearch f = new FrmSearch(this);
            f.ShowDialog();
        }

        private void txtCedulaPac_Leave_1(object sender, EventArgs e)
        {
            if (txtCedulaPac.Text == "")
                return;

            if (pc.exist(txtCedulaPac.Text))
            {
                Persona p = pc.Get(txtCedulaPac.Text);
                txtCedulaPac.Text = p.dni;
                txtNombrePac.Text = p.nombre;
                txtApellidosPac.Text = p.apellido;
                txtEdadPac.Text = p.edad + "";
                txtTelPac.Text = p.telefono;
                id_pacient = Convert.ToInt32(p.id_person);
            }

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {

            if (txtNombreDoc.Text == "" && id_medic <= 0)
            {
                Notification.Show("Necesitas especificar un médico, usa el botón buscar", AlertType.warm);
                return;
            }
            if (txtNombrePac.Text == "" || txtCedulaPac.Text == "" ||
                txtApellidosPac.Text == "" || txtTelPac.Text == "" ||
                txtEdadPac.Text == "")
            {
                Notification.Show("Todos los datos del paciente son requeridos, porfavor complete el formulario.", AlertType.warm);
                return;
            }
            if (txtCosto.Text == "")
            {
                Notification.Show("El valor a cobrar por la consulta es requerido", AlertType.ok);
                return;
            }
            if (txtFecha.Text == "")
            {
                Notification.Show("Necesitas especificar una fecha", AlertType.warm);
                return;
            }
            if (!UtilController.VerificarCedula(txtCedulaPac.Text))
            {
                Notification.Show("Cedula del paciente no valida.", AlertType.warm);
                return;
            }
            

            //Registro del Paciente en caso de no existir
            Persona p = new Persona();
            p.dni = txtCedulaPac.Text;
            p.nombre = txtNombrePac.Text;
            p.apellido = txtApellidosPac.Text;
            p.telefono = txtTelPac.Text;
            try
            {
                p.edad = int.Parse(txtEdadPac.Text);
                if (p.edad < 0) {
                    Notification.Show("La edad no puede ser menor a 0",AlertType.warm);
                    return;
                }
            }
            catch {
                Notification.Show("Asegurese de que la edad sea un valor valido", AlertType.warm);
                return;
            }
            p.tipo = 3;

            string valid = pc.validate(p);
            if (valid == "")
            {
                if (id_pacient == 0)
                {
                    pc.store(p);
                    id_pacient = Convert.ToInt32(p.id_person);
                }
                else
                {
                    pc.update(id_pacient, p);
                }
            }
            else
            {
                Notification.Show(valid, AlertType.warm);
                return;
            }

            // creando la cita
            Cita c = new Cita();
            c.id_medico = id_medic;
            c.id_person = id_pacient;
            c.fecha = DateTime.Parse(txtFecha.Text);
            try
            {
                c.precio = decimal.Parse(txtCosto.Text);
                c.retencion = decimal.Parse(txtRetencion.Text);

                if (c.precio < 0) {
                    Notification.Show("El precio de la consulta no puede ser menor a 0", AlertType.warm);
                    return;
                }
                if(c.retencion<0 || c.retencion > 100)
                {
                    Notification.Show("La retención en un valor porcentual entre 0 y 100", AlertType.warm);
                    return;
                }
            }
            catch {
                Notification.Show("Asegurese de ingresar valores validos para precio y retención", AlertType.warm);
                return;
            }
            // 0 No pagada, 1 pagada, 2 atendida
            c.status = (txtPendientePAgo.Checked) ? 0 : 1;

            String validate = cc.validate(c);
            if (validate == "")
            {
                cc.store(c);
                _clearRegisterInputs();
                Notification.Show("La cita se guardo con exito como : " + ((c.status == 1) ? "PAGADA" : "PENDIENTE DE PAGO"), AlertType.ok);
            }
            else
            {
                Notification.Show(validate, AlertType.warm);
            }
            // save
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            _clearRegisterInputs();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FrmSearch fr = new FrmSearch(this, 1);
            fr.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (id_cita > 0)
            {
                if (txteCosto.Text == "")
                {
                    Notification.Show("El valor a cobrar por la consulta es requerido", AlertType.ok);
                    return;
                }
                if (txteFecha.Text == "")
                {
                    Notification.Show("Necesitas especificar una fecha", AlertType.warm);
                    return;
                }
                Cita c = new Cita();
                c.id_medico = id_medic;
                c.id_person = id_pacient;
                c.fecha = DateTime.Parse(txteFecha.Text);
                try
                {
                    c.precio = decimal.Parse(txteCosto.Text);
                    c.retencion = decimal.Parse(txteRetencion.Text);
                }
                catch {
                    Notification.Show("El precio y la rentencion deben ser numeros", AlertType.warm);
                    return;
                }
                c.status = (textPendientePago.Checked) ? 0 : 1;
                String validate = cc.validateOnUpdate(c);
                if (validate == "")
                {
                    cc.update(id_cita, c);
                    _clearUpdateInputs();
                    Notification.Show("La cita se actualizo con exito como : " + ((c.status == 1) ? "PAGADA" : "PENDIENTE DE PAGO"), AlertType.ok);
                }
                else
                {
                    Notification.Show(validate, AlertType.warm);
                }

            }
            else
            {
                Notification.Show("Se necesito seleccionar una cita a modificar", AlertType.info);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _clearUpdateInputs();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (id_cita > 0)
            {

                var confirmResult = MessageBox.Show("¿Estás seguro que deseeas anular esta Cita?",
                                     "Confirmar Anulación!!",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                   int st = cc.delete(id_cita);
                    if (st == -1)
                    {
                        _clearUpdateInputs();
                        Notification.Show("Anulación Realizada con exito", AlertType.ok);
                    }
                    else {
                        Notification.Show("No puedes anular una cita que ya fué atendida", AlertType.warm);
                        return;
                    }
                }
            }
            else
            {
                Notification.Show("Se necesito seleccionar una cita a modificar", AlertType.info);
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            this.loadFacturas(txtSearch.Text);
        }

        private void txtTelPac_KeyPress(object sender, KeyPressEventArgs e)
        {
            UtilController.validarNumeros(e);
        }
    }
}
