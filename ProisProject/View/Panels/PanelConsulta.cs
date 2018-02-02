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


namespace ProisProject.View.Panels
{
    public partial class PanelConsulta : UserControl
    {
        

        PostDataContext post = new PostDataContext();

        PacientControlller pc = new PacientControlller();
        ConsultaController cc = new ConsultaController();
        CitasController ctc = new CitasController();

        DataTable datatableSearch;
        List<Cita> listaCitas = new List<Cita>();
        List<Cita> listEditCitas = new List<Cita>();
        

        private long selectPaciente = 0;
        private Cita cita =null;
        private Cita citaEdit = null;
        private long selectConsulta = 0;

        public PanelConsulta()
        {
            InitializeComponent();
            SearchActionNormal("");
            SearchActionAttent("");
        }
        public void _clearRegisterInputs() {
            cita = null;
            selectPaciente = 0;
            txtCedula.Text = "";
            txtNombre.Text = "";
            txtTel.Text = "";
            txtEdad.Text = "";
            txtMedicacion.Text = "";
            txtPrescripcion.Text = "";
            txtDiagnostico.Text = "";
            tabControlConsultas.SelectedIndex = 0;
            SearchActionNormal("");
            SearchActionAttent("");
        }

        public void _clearEditInputs() {
            citaEdit = null;
            txtEditCedula.Text = "";
            txtEditNombre.Text = "";
            txtEditTel.Text = "";
            txtEditEdad.Text = "";
            txtEditMedicacion.Text = "";
            txtEditDescripcion.Text = "";
            txtEditDiagnostico.Text = "";
            tabControlConsultas.SelectedIndex = 2;
            selectConsulta = 0;
            SearchActionNormal("");
            SearchActionAttent("");
            btnAnular.Hide();
            btnUpdate.Hide();
            btnCancel.Hide();
        }
        public void SearchActionNormal(String data)
        {
            lblAviso.Text = "";
            datatableSearch = new DataTable();
            datatableSearch.Columns.Add("Fecha");
            datatableSearch.Columns.Add("Cedula");
            datatableSearch.Columns.Add("Médico");
            datatableSearch.Columns.Add("Paciente");
            datatableSearch.Columns.Add("Especialidad");
            datatableSearch.Columns.Add("Estado");

            var q = from c in post.Cita
                    where c.status ==1 && (c.fecha.ToString().Contains(data) ||
                    c.Persona.dni.Contains(data) ||
                    c.Persona.apellido.Contains(data) ||
                    c.Persona.nombre.Contains(data))
                    select c;
            q = q.OrderBy(c => c.id_cita).Take(20);

            if (q.Count() > 0)
            {
                if (listaCitas.Count > 0)
                    listaCitas.Clear();
                if (data != "")
                {
                    lblAviso.ForeColor = Color.FromArgb(22, 160, 133);
                    lblAviso.Text = "Hemos encontrado " + q.Count() + " coincidencias";
                }
                foreach (Cita p in q)
                {
                    string estado = "";
                    switch (p.status) {
                        case 0:
                            estado = "PENDIENTE";
                            break;
                        case 1:
                            estado = "PAGADA";
                            break;
                        case 2:
                            estado = "ATENDIDA";
                            break;
                    }
                    listaCitas.Add(p);
                    datatableSearch.Rows.Add(new Object[]
                    {
                            p.fecha.Value.ToString("dd/MM/yyyy"),
                            p.Persona.dni,
                            p.Medico.Persona.nombre+" "+p.Medico.Persona.apellido,
                            p.Persona.nombre+" "+p.Persona.apellido,
                            p.Medico.Especialidad.nombre,
                            estado
                    });

                }
            }
            else
            {
                lblAviso.ForeColor = Color.Red;
                lblAviso.Text = "No hemos encontrado coincidencias con tu busqueda";
            }
            tbSearchCita.DataSource = datatableSearch;
        }

        public void SearchActionAttent(String data)
        {
            datatableSearch = new DataTable();
            datatableSearch.Columns.Add("Cedula");
            datatableSearch.Columns.Add("Médico");
            datatableSearch.Columns.Add("Paciente");
            datatableSearch.Columns.Add("Especialidad");
            datatableSearch.Columns.Add("Estado");

            var q = from c in post.Cita
                    where c.status == 2 && (c.fecha.ToString().Contains(data) ||
                    c.Persona.dni.Contains(data) ||
                    c.Persona.apellido.Contains(data) ||
                    c.Persona.nombre.Contains(data))
                    select c;
            q = q.OrderBy(c => c.id_cita).Take(20);

            if (q.Count() > 0)
            {
                if (listEditCitas.Count > 0)
                    listEditCitas.Clear();

                if (data != "")
                {
                    lblAviso.ForeColor = Color.FromArgb(22, 160, 133);
                    lblAviso.Text = "Hemos encontrado " + q.Count() + " coincidencias";
                }
                foreach (Cita p in q)
                {
                    string estado = "";
                    switch (p.status)
                    {
                        case 0:
                            estado = "PENDIENTE";
                            break;
                        case 1:
                            estado = "PAGADA";
                            break;
                        case 2:
                            estado = "ATENDIDA";
                            break;
                    }
                    listEditCitas.Add(p);
                    datatableSearch.Rows.Add(new Object[]
                    {
                            p.Persona.dni,
                            p.Medico.Persona.nombre+" "+p.Medico.Persona.apellido,
                            p.Persona.nombre+" "+p.Persona.apellido,
                            p.Medico.Especialidad.nombre,
                            estado
                    });

                }
            }
            else
            {
                lblAviso.ForeColor = Color.Red;
               // lblAviso.Text = "No hemos encontrado coincidencias con tu busqueda";
            }
            tbAtentCitas.DataSource = datatableSearch;
        }
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            SearchActionNormal(txtSearch.Text);
        }

        private void tbSearchCita_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cita = listaCitas[tbSearchCita.CurrentRow.Index];
            if (cita != null)
            {
                if (DateTime.Parse(cita.fecha.Value.ToString("dd/MM/yyy")) != DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"))) {
                    Notification.Show("La cita debe ser atendida en la fecha espeficada", AlertType.warm);
                    return;
                }
                Persona p = pc.Get(tbSearchCita.CurrentRow.Cells[1].Value.ToString());
                selectPaciente = p.id_person;
                txtCedula.Text = p.dni;
                txtNombre.Text = p.nombre + " " + p.apellido;
                txtEdad.Text = p.edad + "";
                txtTel.Text = p.telefono;

                tabControlConsultas.SelectedIndex = 1;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Consulta c = new Consulta();
            c.id_cita = this.cita.id_cita;
            c.medicacion = txtMedicacion.Text;
            c.diagnostico = txtDiagnostico.Text;
            c.prescripcion = txtPrescripcion.Text;
            String validate = cc.validate(c);
            if (validate == "")
            {
                cc.store(c);
                ctc.confirm(cita.id_cita, 2);
                _clearRegisterInputs();
                Notification.Show("La consulta se realizó con exito", AlertType.ok);
                c = null;
            }
            else
            {
                Notification.Show(validate, AlertType.warm);
            }
        }

        private void tbAtentCitas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            citaEdit = listEditCitas[tbAtentCitas.CurrentRow.Index];
            if (citaEdit.id_cita > 0)
            {
                Consulta con = cc.Get(citaEdit.id_cita);
                if (con != null)
                {
                    selectConsulta = con.id_consulta;
                    txtEditCedula.Text = citaEdit.Persona.dni;
                    txtEditNombre.Text = citaEdit.Persona.nombre + " " + citaEdit.Persona.apellido;
                    txtEditTel.Text = citaEdit.Persona.telefono;
                    txtEditEdad.Text = citaEdit.Persona.edad + "";


                    txtEditDescripcion.Text = con.prescripcion;
                    txtEditDiagnostico.Text = con.diagnostico;
                    txtEditMedicacion.Text = con.medicacion;

                    tabControlConsultas.SelectedIndex = 3;
                    btnAnular.Show();
                    btnCancel.Show();
                    btnUpdate.Show();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Consulta c = new Consulta();
            c.id_cita = this.citaEdit.id_cita;
            c.medicacion = txtEditMedicacion.Text;
            c.diagnostico = txtEditDiagnostico.Text;
            c.prescripcion = txtEditDescripcion.Text;
            
            String validate  = cc.validate(c);
            if (validate == "")
            {
                cc.update(selectConsulta, c);
                _clearEditInputs();
                Notification.Show("La consulta se actualizo con exito", AlertType.ok);
            }
            else {
                Notification.Show(validate, AlertType.warm);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _clearEditInputs();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (citaEdit.fecha < DateTime.Now)
            {
                ctc.confirm(citaEdit.id_cita, 1);
                cc.delete(selectConsulta);
                Notification.Show("La consulta ha sido anulada.", AlertType.ok);
                _clearEditInputs();
            }
            else {
                Notification.Show("No puedes anular consultas del pasado", AlertType.ok);
            }
        }

        private void txtAtentSearch_KeyUp(object sender, KeyEventArgs e)
        {
            SearchActionAttent("");
        }
    }
}
