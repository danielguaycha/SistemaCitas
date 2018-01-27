using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProisProject.Model.Data;
namespace ProisProject.Controller
{

    class ConsultaController
    {
        PostDataContext db = new PostDataContext();
        public void store(Consulta c) {
            db.Consulta.InsertOnSubmit(c);
            db.SubmitChanges();
            db.Log = Console.Out;
        }

        public Consulta Get(long id_cita) {
            Consulta c = null;
            if (exist(id_cita))
            {
                c =  db.Consulta.Where(p => p.id_cita == id_cita).Single();
            }
            return c;
        }

        public Boolean exist(long id) {
            return ((from p in db.Consulta where p.id_cita == id select p).Count() > 0);
        }

        public string validate(Consulta c) {

            return "";
        }

        public void update(long id, Consulta c)
        {
            Consulta con = db.Consulta.Where(cn => cn.id_consulta == id).Single();
            con.diagnostico = c.diagnostico;
            con.medicacion = c.medicacion;
            con.prescripcion = c.prescripcion;

            db.SubmitChanges();
        }

        public void delete(long id) {
            Consulta con = db.Consulta.Where(cn => cn.id_consulta == id).Single();
            db.Consulta.DeleteOnSubmit(con);
            db.SubmitChanges();
        }
    }
}
