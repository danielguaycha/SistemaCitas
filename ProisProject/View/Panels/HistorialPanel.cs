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
namespace ProisProject.View.Panels
{
    public partial class HistorialPanel : UserControl
    {
        PostDataContext db = new PostDataContext();
        List<Consulta> lc = null;
        public HistorialPanel()
        {

            InitializeComponent();
        }

        private void HistorialPanel_Load(object sender, EventArgs e)
        {
            loadTable("");

        }

        public void loadTable(String data) {
            if (tbHistorial.Rows.Count > 0) {
                tbHistorial.Rows.Clear();
            }
            if (lc != null) {
                lc.Clear();
                lc = null;
            }
            lc = new List<Consulta>();
            var q = from c in db.Consulta where c.Cita.status == 2 && (c.Cita.Persona.dni.Contains(data)
                    || c.Cita.Persona.nombre.Contains(data) || c.Cita.Persona.apellido.Contains(data)) select c;

            foreach (Consulta c in q)
            {
                lc.Add(c);
                tbHistorial.Rows.Add(c.Cita.fecha.Value.ToString("dd/MM/yyyy"), c.Cita.Persona.nombre+" "+c.Cita.Persona.apellido,
                    c.diagnostico, c.medicacion);
            }
        }

        private void tbHistorial_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lc!=null){
                Consulta c = lc[tbHistorial.CurrentRow.Index];
                FrmViewHistorial fv = new FrmViewHistorial(c);
                fv.ShowDialog();
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            loadTable(txtSearch.Text);
        }
    }
}
