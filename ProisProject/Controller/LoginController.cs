using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProisProject.Model.Data;
using ProisProject.Model;
namespace ProisProject.Controller
{
    class LoginController
    {
        PostDataContext db = new PostDataContext();
        // comprueba el estado, si ya cambio su contraseña y esta activo
        // o esta dado de baja

        public int getStatus(string dni) {
            Usuario u = db.Usuario.Where(us => us.Persona.dni == dni).Single();
            return u.status.Value;
        }

        public bool isCorrect(string dni, string pw) {
            return (from u in db.Usuario where u.status !=-1 && u.Persona.dni == dni && u.password == UtilController.Encriptar(pw) select u).Count() > 0;
        }

        public bool exits(String dni) {
            return (from u in db.Usuario where u.Persona.dni == dni select u).Count()>0;
        }

        public bool changePassword(string password, long id_user) {
            Usuario u = db.Usuario.Where(us => us.id_usuario == id_user).Single();
            if (u.status == 0) {
                u.password = UtilController.Encriptar(password);
                u.status = 1;
                db.SubmitChanges();
                return true;
            }
            return false;
        }

        public void startSession(string dni) {
            Usuario u = db.Usuario.Where(us => us.Persona.dni == dni).Single();
            Session.user = u;
            Session.onStartSession(u);
        }
    }
}
