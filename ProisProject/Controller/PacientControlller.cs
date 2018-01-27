using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProisProject.Model.Data;
namespace ProisProject.Controller
{
    
    class PacientControlller
    {
        PostDataContext db = new PostDataContext();

        public void store(Persona per) {
            db.Persona.InsertOnSubmit(per);
            db.SubmitChanges();
        }

        public void edit(String cedula) {            
        }

        public void delete(String oldni) {
            Persona p = db.Persona.Where(per => per.dni == oldni).Single();
            p.status = 0;
            db.SubmitChanges();
        }

        public Boolean exist(String cedula) {
            return (from item in db.Persona
                    where item.dni == cedula
                    select item).Count() > 0;
        }
        public string validate(Persona per)
        {
            if (per.edad <= 0)
            {
                return "La edad no puede ser menor o igual a 0";
            }
            return "";
        }

        public Persona Get(string cedula) {
            Persona per = null;
            per = db.Persona.Where(c => c.dni == cedula).Single();
            return per;
        }

        internal void update(string oldDni, Persona per)
        {
            Persona temp = db.Persona.Where(p => p.dni == oldDni).Single();
            temp.dni = per.dni;
            temp.nombre = per.nombre;
            temp.apellido = per.apellido;
            temp.edad = per.edad;
            temp.email = per.email;
            temp.telefono = per.telefono;
            temp.direccion = per.direccion;
            db.SubmitChanges();
        }

        internal void update(long ind, Persona per)
        {
            Persona temp = db.Persona.Where(p => p.id_person == ind).Single();
            temp.dni = per.dni;
            temp.nombre = per.nombre;
            temp.apellido = per.apellido;
            temp.edad = per.edad;
            temp.email = per.email;
            temp.telefono = per.telefono;
            temp.direccion = per.direccion;
            temp.status = 1;
            db.SubmitChanges();
        }

        public void comprobate(int id_pacient)
        {
            Persona p = db.Persona.Where(per => per.id_person == id_pacient).Single();
            if (p.status == 0) {
                p.status = 1;
                db.SubmitChanges();
            }
        }
    }
}
