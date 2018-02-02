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
using ProisProject.View.Components;
namespace ProisProject.View
{
    public partial class FrmRptPacientes : Form
    {
        PostDataContext db = new PostDataContext();
        public FrmRptPacientes()
        {
            InitializeComponent();
        }

        private void FrmRptPacientes_Load(object sender, EventArgs e)
        {
            var q = from p in db.Persona where p.status==1 && p.tipo == 3 select new {
                p.id_person, p.dni, p.nombre, p.apellido, p.email, p.telefono,
                p.direccion, p.tipo
            };
            RptPacientes rpt = new RptPacientes();
            rpt.SetDataSource(q);
            ViewRptPacientes.ReportSource = rpt;
        }
    }
}
