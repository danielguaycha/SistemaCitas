using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProisProject.Model.Data;

namespace ProisProject.Controller
{
    class UserController
    {
        PostDataContext db = new PostDataContext();

        public void store() {

        }

        public long getIdByCedula(String cedula) {
            Persona p = db.Persona.Where(u => u.dni == cedula).Single();
            return p.id_person;
        }

        public bool exist(String cedula)
        {
            return (from u in db.Usuario where u.id_person == getIdByCedula(cedula) select u).Count()>0;
        }

        internal void store(Usuario s)
        {
            db.Usuario.InsertOnSubmit(s);
            db.SubmitChanges();
        }
    }
}
