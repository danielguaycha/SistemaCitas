using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProisProject.Model.Data;
namespace ProisProject.Controller
{
    class SpecialtyController
    {
        PostDataContext post = new PostDataContext();
        
        public Boolean store(Especialidad especialidad) {
            try
            {
                post.Especialidad.InsertOnSubmit(especialidad);
                post.SubmitChanges();
                LogsController.store("Se guardo la especialidad Nombre: "+especialidad.nombre, LogsController.LogLevel.INFO);
            }
            catch (Exception e) {
                LogsController.store("No se pudo guardar la especialidad | "+e.Message, LogsController.LogLevel.ERROR);
                Console.WriteLine(e.Message);
                return false;
            }
            return true;
        }

        public Especialidad edit(int id)
        {
            Especialidad tempesp = null;
            var query = from esp in post.Especialidad where esp.id_especialidad == id select esp;
            foreach (Especialidad e in query) {
                tempesp = e;
            }
           return tempesp;
        }

        public bool update(int id, Especialidad especialidad) {
            try
            {
                Especialidad c = post.Especialidad.Single(tempesp => tempesp.id_especialidad == id);
                c.nombre = especialidad.nombre;
                c.descripcion = especialidad.descripcion;
                c.costo = especialidad.costo;
                post.SubmitChanges();
              //  LogsController.store("Se actualizo la especialidad Id: "+id+" Nombre: " + especialidad.nombre, LogsController.LogLevel.INFO);
                return true;
            }
            catch (Exception e) {
                LogsController.store("No se pudo actualizar la especialidad Id: "+id+" | " + e.Message, LogsController.LogLevel.ERROR);
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public void delete(int id) {
            Especialidad c = post.Especialidad.Single(tempesp => tempesp.id_especialidad == id);
            if (c.status == 1)
                c.status = 0;
            else
                c.status = 1;
            post.SubmitChanges();
        }

        public String validate(Especialidad especialidad) {
            if (especialidad.nombre == "") {
                return "El nombre de la especailidad es requerido";
            }
            if (especialidad.descripcion == "") {
                return "La descripción de la especialidad es requerida";
            }
            return "";
        }

        public List<String> list() {
            List<String> temlist = new List<string>();
            var data = from speciality in post.Especialidad where speciality.status ==1 select speciality.nombre;
            foreach (String s in data) {
                temlist.Add(s);
            }
            return temlist;
        }

        public List<Especialidad> getAll() {
            var sp = from p in post.Especialidad select p;
            List<Especialidad> templist = new List<Especialidad>();
            foreach(Especialidad es in sp)
            {
                templist.Add(es);
            }
            return templist;
        }

        public Especialidad getById(int id) {
            Especialidad especialidad = null;
            especialidad = post.Especialidad.Single(e => e.id_especialidad ==id);
            return especialidad;
        }

        public Especialidad getByName(String name) {
            Especialidad especialidad = null;
            if (!name.Equals(""))
            {
                especialidad = post.Especialidad.Where(c => c.nombre == name).Single();

            }
            return especialidad;
        }
    }
}
