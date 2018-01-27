using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProisProject.Model.Data;
namespace ProisProject.Controller
{
    class CitasController
    {
        PostDataContext db = new PostDataContext();
        public void store(Cita c) {
            db.Cita.InsertOnSubmit(c);
            db.SubmitChanges();
        }

        public void confirm(long id, int status) {
            Cita c = db.Cita.Where(p => p.id_cita == id).Single();
            c.status = status; // confirma que la cita fue atendida
            db.SubmitChanges();
        }

        public string validate(Cita c) {
            if (DateTime.Parse(c.fecha.Value.ToString("dd/MM/yyyy")) < DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"))) {
                return "No puedes asignar citas a fechas pasadas";
            }
            if (this.CitaByDate(c)) {
                return "Este paciente ya tiene una cita para la fecha indicada con este médico";
            }
            
            return "";
        }

        public bool CitaByDate(Cita c) {
            return (from item in db.Cita
                    where item.fecha == c.fecha && item.id_medico == c.id_medico &&
                    item.id_person == c.id_person && c.status == 3
                    select item).Count() > 0;
        }

        internal void update(long id_cita, Cita c)
        {
            Cita ct = db.Cita.Where(sp => sp.id_cita == id_cita).Single();
            ct.fecha = c.fecha;
            ct.retencion = c.retencion;
            ct.precio = c.precio;
            ct.status = c.status;

            db.SubmitChanges();
        }

        internal void delete(long id_cita)
        {
            Cita ct = db.Cita.Where(sp => sp.id_cita == id_cita).Single();
            db.Cita.DeleteOnSubmit(ct);
            db.SubmitChanges();
        }

        public void getFacturas() {

        }
    }
}
