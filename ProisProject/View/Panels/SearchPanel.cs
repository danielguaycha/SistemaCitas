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
using ProisProject.View.Panels;

namespace ProisProject.View
{
    public partial class SearchPanel : UserControl
    {
        DataTable datatableSearch;
        PostDataContext post = new PostDataContext();
        //
        // opciones para doctores
        private DoctorPanel doctorPanel;
        private Panels.PanelCitas citasPanel;
        private PacientePanel pacientePanel;
        private UserPanel userPanel;

        private List<Medico> listaMedicos;
        private List<Persona> listaPacientes;
        private List<Cita> listaCitas;
        public SearchPanel()
        {
            InitializeComponent();           
        }

        public void setinstructions(int i)
        {
            switch (i)
            {
                case 1:
                    lblInstructions.Text = "Busqueda por Cedula, Nombres, Especialidad";
                    break;
                case 2:
                    lblInstructions.Text = "Busqueda por Cedula, Nombres";
                    break;
                case 3:
                    lblInstructions.Text = "Busqueda por Médico, Fecha, Estado";
                    break;
                default:
                    lblInstructions.Text = "Busqueda por nombres o cedula";
                    break;
            }
            txtSearch.Focus();
            searchAction("");
        }

        public void searchAction(String data) {
            if (rdMedicos.Checked)
            {
                listaMedicos = null;
                lblAviso.Text = "";
                listaMedicos = new List<Medico>();
                datatableSearch = new DataTable();

                datatableSearch.Columns.Add("Cedula");
                datatableSearch.Columns.Add("Nombres");
                datatableSearch.Columns.Add("Especialidad");
                datatableSearch.Columns.Add("Telefono");

                var q = from medicos in post.Medico
                        where medicos.status>0 && medicos.Persona.status>0
                        && medicos.Especialidad.status == 1 && (medicos.Persona.nombre.Contains(data)
                        || medicos.Persona.dni.Contains(data)
                        || medicos.Especialidad.nombre.Contains(data)
                        || medicos.Persona.apellido.Contains(data))
                        select medicos;
                q = q.OrderByDescending(m => m.id_medico).Take(20);
                if (q.Count() > 0)
                {
                    if (data != "")
                    {
                        lblAviso.ForeColor = Color.FromArgb(22, 160, 133);
                        lblAviso.Text = "Hemos encontrado " + q.Count() + " coincidencias";
                    }
                    foreach (Medico m in q)
                    {
                        listaMedicos.Add(m);
                        datatableSearch.Rows.Add(new Object[] { m.Persona.dni, m.Persona.nombre + " " + m.Persona.apellido, m.Especialidad.nombre, m.Persona.telefono });
                    }
                }
                else
                {
                    lblAviso.ForeColor = Color.Red;
                    lblAviso.Text = "No hemos encontrado coincidencias con tu busqueda";
                }

            }
            else if (rdPacientes.Checked)
            {
                lblAviso.Text = "";
                listaPacientes = null;

                listaPacientes = new List<Persona>();
                datatableSearch = new DataTable();

                datatableSearch.Columns.Add("Cedula");
                datatableSearch.Columns.Add("Nombres");
                datatableSearch.Columns.Add("Apellidos");
                datatableSearch.Columns.Add("Telefono");
                datatableSearch.Columns.Add("Edad");

                var q = from per in post.Persona
                        where per.status == 1 && per.tipo == 3 && (per.dni.Contains(data)
                        || per.nombre.Contains(data)
                        || per.apellido.Contains(data))
                        select per;

                q = q.OrderByDescending(m => m.id_person).Take(20);
                if (q.Count() > 0)
                {
                    if (data != "")
                    {
                        lblAviso.ForeColor = Color.FromArgb(22, 160, 133);
                        lblAviso.Text = "Hemos encontrado " + q.Count() + " coincidencias";
                    }
                    foreach (Persona p in q)
                    {
                        listaPacientes.Add(p);
                        datatableSearch.Rows.Add(new Object[] { p.dni, p.nombre, p.apellido, p.telefono, p.edad });
                    }
                }
                else
                {
                    lblAviso.ForeColor = Color.Red;
                    lblAviso.Text = "No hemos encontrado coincidencias con tu busqueda";
                }
            }
            else if (rdCitas.Checked)
            {
                listaCitas = null;
                lblAviso.Text = "";
                listaCitas = new List<Cita>();

                datatableSearch = new DataTable();
                datatableSearch.Columns.Add("Fecha");
                datatableSearch.Columns.Add("Médico");
                datatableSearch.Columns.Add("Paciente");
                datatableSearch.Columns.Add("Especialidad");
                datatableSearch.Columns.Add("Estado");

                var q = from c in post.Cita
                        where c.fecha.ToString().Contains(data) ||
                        c.Persona.dni.Contains(data) ||
                        c.Persona.apellido.Contains(data)
                        select c;
                q = q.OrderBy(c => c.status).Take(20);

                if (q.Count() > 0)
                {
                    if (data != "")
                    {
                        lblAviso.ForeColor = Color.FromArgb(22, 160, 133);
                        lblAviso.Text = "Hemos encontrado " + q.Count() + " coincidencias";
                    }
                    foreach (Cita p in q)
                    {
                        listaCitas.Add(p);
                        string estado = "";
                        switch (p.status)
                        {
                            case 0:
                                estado = "PENDIENTE DE ATENCIÓN & PAGO";
                                break;
                            case 1:
                                estado = "PENDIENTE DE ATENCIÓN - PAGADA";
                                break;
                            case 2:
                                estado = "ATENDIDA & PENDIENTE DE PAGO";
                                break;
                            case 3:
                                estado = "ATENDIDA & COBRADA";
                                break;
                        }
                        datatableSearch.Rows.Add(new Object[]
                        {
                            p.fecha,
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
            }
            else {
                datatableSearch = new DataTable();
                datatableSearch.Columns.Add("Cedula");
                datatableSearch.Columns.Add("Nombres");
                datatableSearch.Columns.Add("Email");
                datatableSearch.Columns.Add("Tipo");

                var q = from p in post.Persona where p.status == 1 && 
                        (p.nombre.Contains(data) || p.apellido.Contains(data) || p.dni.Contains(data))
                        select p;
                q = q.OrderByDescending(c => c.status).Take(20);
                if (q.Count() > 0)
                {
                    foreach (Persona p in q)
                    {
                        string email = p.email;
                        if (p.email == null || p.email == "")
                            email = "No Disponible";
                        datatableSearch.Rows.Add(new Object[] { p.dni, p.nombre+" "+p.apellido,email, p.tipo });
                    }
                }
                else {
                    lblAviso.ForeColor = Color.Red;
                    lblAviso.Text = "No hemos encontrado coincidencias con tu busqueda";
                }

            }
            
            tbSearch.DataSource = datatableSearch;
        }
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            this.searchAction(txtSearch.Text.Trim());
        }

        private void tbSearch_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DoctorPanel != null && rdMedicos.Checked && listaMedicos.Count() > 0)
            {
                Controller.SpecialtyController sc = new Controller.SpecialtyController();
                DoctorPanel._loadItemsEspecialidadEdit(sc.list());
                DoctorPanel.oldDni = listaMedicos[tbSearch.CurrentRow.Index].Persona.dni;
                DoctorPanel.selectedPerson = listaMedicos[tbSearch.CurrentRow.Index].Persona.id_person;
                DoctorPanel.txteditCedula.Text = listaMedicos[tbSearch.CurrentRow.Index].Persona.dni;
                DoctorPanel.txteditNombre.Text = listaMedicos[tbSearch.CurrentRow.Index].Persona.nombre;
                DoctorPanel.txteditApellido.Text = listaMedicos[tbSearch.CurrentRow.Index].Persona.apellido;
                DoctorPanel.txteditMail.Text = listaMedicos[tbSearch.CurrentRow.Index].Persona.email;
                DoctorPanel.txteditDir.Text = listaMedicos[tbSearch.CurrentRow.Index].Persona.direccion;
                DoctorPanel.txteditEstCiv.SelectedItem = listaMedicos[tbSearch.CurrentRow.Index].Persona.ecivil;
                DoctorPanel.txteditTel.Text = listaMedicos[tbSearch.CurrentRow.Index].Persona.telefono;
                DoctorPanel.txteditFNacimiento.Text = listaMedicos[tbSearch.CurrentRow.Index].Persona.fnac.ToString();
                DoctorPanel.txteditEdad.Text = listaMedicos[tbSearch.CurrentRow.Index].Persona.edad.ToString();
                DoctorPanel.txteditPeso.Text = listaMedicos[tbSearch.CurrentRow.Index].Persona.peso + "";
                DoctorPanel.txteditSangre.Text = listaMedicos[tbSearch.CurrentRow.Index].Persona.sangre;
                DoctorPanel.txteditAltura.Text = listaMedicos[tbSearch.CurrentRow.Index].Persona.altura + "";
                DoctorPanel.txteditDiscapacidad.Text = "Ninguna";
                DoctorPanel.txteditTitulo.Text = listaMedicos[tbSearch.CurrentRow.Index].titulo;
                DoctorPanel.txteditespecialidad.SelectedItem = sc.getById(listaMedicos[tbSearch.CurrentRow.Index].id_especialidad.Value).nombre;
                if (listaMedicos[tbSearch.CurrentRow.Index].Persona.tipo == 1) {
                    DoctorPanel.radioEditDoctor.Checked = true;
                    DoctorPanel.radioEditEnfermera.Checked = false;
                } else if (listaMedicos[tbSearch.CurrentRow.Index].Persona.tipo == 2) {
                    DoctorPanel.radioEditEnfermera.Checked = true;
                    DoctorPanel.radioEditDoctor.Checked = false;
                }
                DoctorPanel.btnCancel.Show();
                DoctorPanel.btnUpdate.Show();
                DoctorPanel.btnDelete.Show();

                this.Parent.Parent.Dispose();
            }
            else if (CitasPanel != null && rdMedicos.Checked)
            {
                if (tbSearch.SelectedRows.Count > 0)
                {
                    Controller.SpecialtyController sc = new Controller.SpecialtyController();
                    Controller.MedicController mc = new Controller.MedicController();
                    CitasPanel.txtEspecialidadDoc.Items.Clear();
                    CitasPanel.txtNombreDoc.Text = tbSearch.CurrentRow.Cells[1].Value.ToString();
                    CitasPanel.txtEspecialidadDoc.Items.Add(tbSearch.CurrentRow.Cells[2].Value.ToString());
                    CitasPanel.txtEspecialidadDoc.SelectedIndex = 0;
                    CitasPanel.txtCosto.Text = sc.getByName(tbSearch.CurrentRow.Cells[2].Value.ToString()).costo + "";
                    CitasPanel.id_medic = listaMedicos[tbSearch.CurrentRow.Index].id_medico;
                    sc = null;
                    this.Parent.Parent.Dispose();
                }
            } else if (CitasPanel != null && rdCitas.Checked) {
                if (tbSearch.SelectedRows.Count > 0)
                {
                    String ap = (listaCitas[tbSearch.CurrentRow.Index].Medico.Persona.apellido);
                    decimal valmod = (listaCitas[tbSearch.CurrentRow.Index]).Medico.Especialidad.costo.Value;
                    decimal reten = (listaCitas[tbSearch.CurrentRow.Index]).retencion.Value;

                    CitasPanel.id_medic = (listaCitas[tbSearch.CurrentRow.Index]).Medico.id_medico;
                    CitasPanel.id_pacient = (listaCitas[tbSearch.CurrentRow.Index]).Persona.id_person;
                    citasPanel.id_cita = (listaCitas[tbSearch.CurrentRow.Index]).id_cita;
                    CitasPanel.txteEspecialidad.Items.Clear();
                    CitasPanel.txteNombresDoc.Text = listaCitas[tbSearch.CurrentRow.Index].Medico.Persona.nombre + " " + ap;
                    CitasPanel.txteEspecialidad.Items.Add(listaCitas[tbSearch.CurrentRow.Index].Medico.Especialidad.nombre);
                    CitasPanel.txteEspecialidad.SelectedIndex = 0;
                    CitasPanel.txteNombrePAc.Text = listaCitas[tbSearch.CurrentRow.Index].Persona.nombre + " " + listaCitas[tbSearch.CurrentRow.Index].Persona.apellido;
                    CitasPanel.txteApellidos.Text = listaCitas[tbSearch.CurrentRow.Index].Persona.apellido;
                    CitasPanel.txteEdad.Text = listaCitas[tbSearch.CurrentRow.Index].Persona.edad.ToString();
                    CitasPanel.txteTelefono.Text = listaCitas[tbSearch.CurrentRow.Index].Persona.telefono;
                    CitasPanel.txteCedula.Text = listaCitas[tbSearch.CurrentRow.Index].Persona.dni;

                    CitasPanel.txteFecha.Text = listaCitas[tbSearch.CurrentRow.Index].fecha.ToString();
                    CitasPanel.txteCosto.Text = valmod + "";
                    CitasPanel.txteRetencion.Text = reten + "";
                    CitasPanel.textPendientePago.Checked = (listaCitas[tbSearch.CurrentRow.Index].status == 0);
                    CitasPanel.btnAnular.Show();
                    CitasPanel.btnCancel.Show();
                    CitasPanel.btnUpdate.Show();
                    this.Parent.Parent.Dispose();
                }

            }

            else if (PacientePanel != null && rdPacientes.Checked)
            {
                if (tbSearch.SelectedRows.Count > 0)
                {
                    String dir = listaPacientes[tbSearch.CurrentRow.Index].direccion;
                    String email = listaPacientes[tbSearch.CurrentRow.Index].email;
                    PacientePanel.oldDni = listaPacientes[tbSearch.CurrentRow.Index].dni.ToString();
                    PacientePanel.txtEditCedula.Text = listaPacientes[tbSearch.CurrentRow.Index].dni.ToString();
                    PacientePanel.txteditNombre.Text = listaPacientes[tbSearch.CurrentRow.Index].nombre.ToString();
                    PacientePanel.txteditApellido.Text = listaPacientes[tbSearch.CurrentRow.Index].apellido.ToString();
                    PacientePanel.txtEditDir.Text = dir;
                    PacientePanel.txtEditEdad.Text = listaPacientes[tbSearch.CurrentRow.Index].edad.ToString();
                    PacientePanel.txteditTel.Text = listaPacientes[tbSearch.CurrentRow.Index].telefono.ToString();
                    PacientePanel.txtEditEmail.Text = email;
                    PacientePanel.btnCancel.Show();
                    PacientePanel.btnDelete.Show();
                    PacientePanel.btnUpdate.Show();
                    this.Parent.Parent.Dispose();
                }
            }
            else if (UserPanel !=null && !rdCitas.Checked && !rdMedicos.Checked
                && !rdPacientes.Checked) {
                if (tbSearch.SelectedRows.Count > 0)
                {
                    UserPanel.txtCedula.Text = tbSearch.CurrentRow.Cells[0].Value.ToString();
                    UserPanel.txtSearch.Text = tbSearch.CurrentRow.Cells[1].Value.ToString();
                    UserPanel.txtEmail.Text = tbSearch.CurrentRow.Cells[2].Value.ToString();
                    this.Parent.Parent.Dispose();
                }
            }
            
        }

        public DoctorPanel DoctorPanel
        {
            get { return doctorPanel; }
            set { doctorPanel = value; }
        }

        public PanelCitas CitasPanel
        {
            get
            {
                return citasPanel;
            }

            set
            {
                citasPanel = value;
            }
        }

        public PacientePanel PacientePanel
        {
            get
            {
                return pacientePanel;
            }

            set
            {
                pacientePanel = value;
            }
        }

        public UserPanel UserPanel
        {
            get
            {
                return userPanel;
            }

            set
            {
                userPanel = value;
            }
        }

        private void SearchPanel_Load(object sender, EventArgs e)
        {
            if (rdMedicos.Checked)
                setinstructions(1);
            else if (rdPacientes.Checked)
                setinstructions(2);
            else if (rdCitas.Checked)
                setinstructions(3);
            else
                setinstructions(4);
            this.ActiveControl = txtSearch;

            searchAction("");
        }

        private void rdMedicos_Click(object sender, EventArgs e)
        {
            setinstructions(1);
        }

        private void rdPacientes_CheckedChanged(object sender, EventArgs e)
        {
            setinstructions(2);
        }

        private void rdCitas_CheckedChanged(object sender, EventArgs e)
        {
            setinstructions(3);
        }
    }
}
