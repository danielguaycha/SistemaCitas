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

        public List<Usuario> get() {
            db = null;
            db = new PostDataContext();
            List<Usuario> temp = new List<Usuario>();
            var q = from u in db.Usuario where u.status>=0 select u;
            foreach (Usuario u in q) {
                temp.Add(u);
            }
            return temp;
        }

        public Persona getIdByCedula(String cedula) {
            Persona p = db.Persona.Where(u =>u.status==1 && u.dni == cedula).Single();
            return p;
        }

        public bool exist(String cedula)
        {
            return (from u in db.Usuario where u.id_person == getIdByCedula(cedula).id_person select u).Count()>0;
        }

        internal void store(Usuario s)
        {
            db.Usuario.InsertOnSubmit(s);
            db.SubmitChanges();
        }

        internal void update(Usuario user)
        {
            try
            {
                if(user.password==null || user.password =="")
                    db.ExecuteCommand("UPDATE [dbo].[Usuario] SET [id_rol] = " + user.id_rol + " WHERE [id_person] = " + user.id_person);
                else
                    db.ExecuteCommand("UPDATE [dbo].[Usuario] SET [id_rol] = "+user.id_rol+" ,[password] = '"+user.password+"', status = 0 WHERE [id_person] = "+user.id_person);
            }
            catch (Exception e) {
                Console.WriteLine("#ERROR UC: "+e.Message);
            }
        }

        public void delete(long id_person, int status) {
            Usuario u = db.Usuario.Where(us => us.id_person == id_person).Single();
            u.status = status;
            db.SubmitChanges();
        }
       
    }
}
