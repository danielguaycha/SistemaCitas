using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProisProject.Model.Data;

namespace ProisProject.Controller
{
    class MedicController
    {
        PostDataContext post = new PostDataContext();

        public Boolean store(Medico m) {
            try
            {
                post.Persona.InsertOnSubmit(m.Persona);
                post.Medico.InsertOnSubmit(m);
                post.SubmitChanges();
                return true;
            }
            catch (Exception e){
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public void update(int id, Medico medico) {
            Medico med = post.Medico.Single(tempmedic => tempmedic.id_person == id);

            if (med != null) {
                med.Persona.dni = medico.Persona.dni;
                med.Persona.nombre = medico.Persona.nombre;
                med.Persona.apellido = medico.Persona.apellido;
                med.Persona.email = medico.Persona.email;
                med.Persona.telefono = medico.Persona.telefono;
                med.Persona.edad = medico.Persona.edad;
                med.Persona.peso = medico.Persona.peso;
                med.Persona.altura = medico.Persona.altura;
                med.Persona.sangre = medico.Persona.sangre;
                med.Persona.fnac = medico.Persona.fnac;
                med.Persona.ecivil = medico.Persona.ecivil;
                med.Persona.direccion = medico.Persona.direccion;

                med.titulo = medico.titulo;
                med.id_especialidad = medico.id_especialidad;
                post.SubmitChanges();
            }
        }

        public void delete(int id){
            Medico med = post.Medico.Single(tempMed => tempMed.id_person == id);
            var user = from tmpuser in post.Usuario where tmpuser.id_person == id select tmpuser;
            if (user.Count() > 0) {
                Usuario deleteuser = post.Usuario.Single(tmpuser => tmpuser.id_person == id);
                post.Usuario.DeleteOnSubmit(deleteuser);
                post.SubmitChanges();
            }
            med.status = 0;           
            post.SubmitChanges();
        }

        public Medico edit(String dni) {
            Medico med = null;
            if (exist(dni))
            {
                med = post.Medico.Where(c => c.Persona.dni == dni).Single();
            }
            return med;
        }

        public bool exist(String dni) {
            return (from item in post.Medico where item.Persona.dni == dni
                           select item).Count() > 0;
        }

        public string validate(Medico m) {
            if (m.Persona.nombre.Equals("") || m.Persona.apellido =="") {
                return "El nombre y apellido del médico son datos requeridos";
            }
            if (m.Persona.dni.Equals("")) {
                return "Es necesario especificar el número de cedula del médico";
            }
            if (m.Persona.edad < 0 || m.Persona.edad == null) {
                return "Es necesario Especificar una edad mayor a 0";
            }
            if (m.Persona.email == "") {
                return "El mail del ";
            }
            return "";
        }

        public Medico GetByIdPerson(int id_person) {
            return post.Medico.Where(p => p.id_person == id_person).Single();
        }
    }
}
