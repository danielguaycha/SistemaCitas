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
using ProisProject.View.Components;
using ProisProject.Model.Data;

namespace ProisProject.View
{
    public partial class SpecialityPanel : UserControl
    {
        SpecialtyController sp = new SpecialtyController();
        private int selectedID = 0;
        private int status = -1;
        public SpecialityPanel()
        {
            InitializeComponent();
            tbSpeciality.ClearSelection();
            
        }

        private void clearData() {
            btnCancel.Hide();
            btnDelete.Hide();
            btnUpdate.Hide();
            btnSpecialitySave.Show();
            txtDesc.Text = "";
            txtNombre.Text = "";
            txtvalor.Text = "";
            this.selectedID = 0;
            this.status = -1;
        }

        private void SpecialityPanel_Load(object sender, EventArgs e)
        {
            if (tbSpeciality.Rows.Count >= 1) {
                tbSpeciality.Rows.Clear();
            }
            String status = "";
            foreach (Especialidad es in sp.getAll()) {
                status = (es.status == 1) ? "Activo" : "Inactivo";
                tbSpeciality.Rows.Add(es.id_especialidad, es.nombre, es.descripcion, status);
            }

            tbSpeciality.ClearSelection();
        }

        private void btnSpecialitySave_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text == "" || txtNombre.Text == "" && txtDesc.Text =="")
            {
                Notification.Show("Todos los datos son necesarios para establecer este registro", AlertType.warm);
                return;
            }
            Especialidad esp = new Especialidad();
            esp.nombre = txtNombre.Text.Trim();
            esp.descripcion = txtDesc.Text.Trim();
            esp.status = 1;

            esp.costo = (txtvalor.Text.ToString()=="" || txtvalor.Text == null)?0:decimal.Parse((txtvalor.Text));
            string validate = sp.validate(esp);

            if (validate == "")
            {
                sp.store(esp);
                clearData();
                SpecialityPanel_Load(null, null);
                Notification.Show("Especialidad Guardada con exito", AlertType.ok, Notification.HIGHT);
            }
            else {
                Notification.Show(validate, AlertType.warm, Notification.HIGHT);
            }
        }

        private void tbSpeciality_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // edit method
            if (tbSpeciality.SelectedRows.Count <= 0)
                return;
            object val = tbSpeciality.SelectedRows[0].Cells[0].Value;
            if (val != null)
            {
                Especialidad esp = sp.edit(int.Parse(val.ToString()));
                txtDesc.Text = esp.descripcion;
                txtNombre.Text = esp.nombre;
                txtvalor.Text = esp.costo+"";
                selectedID = esp.id_especialidad;
                status = esp.status.Value;
            }
            if (status != -1 && status == 1)
            {
                btnDelete.ButtonText = "Dar de baja";
            }
            else if(status!=-1 && status ==0) {
                btnDelete.ButtonText = "Dar de alta";
            }
            btnCancel.Show();
            btnDelete.Show();
            btnUpdate.Show();
            btnSpecialitySave.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.clearData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedID > 0) {
                Especialidad esp = new Especialidad();
                esp.nombre = txtNombre.Text;
                esp.descripcion = txtDesc.Text;
                esp.costo = decimal.Parse(txtvalor.Text);
                string validate = sp.validate(esp);
                if (validate == "")
                {
                    sp.update(selectedID, esp);
                    clearData();
                    Notification.Show("Especialidad actualizada con exito", AlertType.ok, Notification.HIGHT);
                    SpecialityPanel_Load(null, null);
                }
                else
                {
                    Notification.Show(validate, AlertType.warm, Notification.HIGHT);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("¿Estás seguro que deseas dar "+((status==1)?"de baja":"de alta")+" esta Especialidad?",
                                     "Confirmar!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                sp.delete(selectedID);
                clearData();
                SpecialityPanel_Load(null, null);
                Notification.Show("Especialidad dada de baja con exito", AlertType.ok, 1000);
            }
        }
    }
}
