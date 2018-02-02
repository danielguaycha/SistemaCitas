using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProisProject.Model.Data;

namespace ProisProject.Controller
{

    class RolController
    {
        PostDataContext db = new PostDataContext();
        public int store(Rol rol) {
            db.Rol.InsertOnSubmit(rol);
            db.SubmitChanges();
            return rol.id_rol;
        }
        public void store_RolPermiso(List<int> rp, int id_rol) {
            foreach (int perm in rp)
            {
                Rol_Permiso rolper = new Rol_Permiso();
                rolper.id_rol = id_rol;
                rolper.id_permiso = perm;
                db.Rol_Permiso.InsertOnSubmit(rolper);
            }
            db.SubmitChanges();
        }

        public List<Rol> get() {
            List<Rol> r = new List<Rol>();
            var q = from p in db.Rol select p;
            foreach (Rol rol in q) {
                r.Add(rol);
            }
            return r;
        }

        public List<Permisos> getPermsByRol(int id_rol) {
            List<Permisos> temp = new List<Permisos>();
            var q = from p in db.Rol_Permiso where p.id_rol == id_rol select p;
            if (q.Count() > 0)
            {
                foreach (Rol_Permiso rp in q)
                {
                    temp.Add(rp.Permisos);
                }
            }
            return temp;
        }

        internal void update_RolPermiso(List<int> id_perms,Rol r, int selectedRol)
        {
            // remove actuals perms
            var q = from rp in db.Rol_Permiso where rp.id_rol == selectedRol select rp;
            foreach (Rol_Permiso rolper in q) {
                db.Rol_Permiso.DeleteOnSubmit(rolper);
            }
           

            Rol uptrol = db.Rol.Where(uptr=> uptr.id_rol == selectedRol).Single();
            uptrol.nombre_rol = r.nombre_rol;
            db.SubmitChanges();
            // set news perms
            this.store_RolPermiso(id_perms, selectedRol);            
        }

        internal void delete(int selectedRol, string rolstatus)
        {
            Rol uptrol = db.Rol.Where(uptr => uptr.id_rol == selectedRol).Single();
            if (rolstatus == "Activo")
            {
                uptrol.status = 0;
            }
            else {
                uptrol.status = 1;
            }
            db.SubmitChanges();
        }

        public int getRolIdByName(String name) {
            Rol uptrol = db.Rol.Where(uptr => uptr.nombre_rol == name).Single();
            return uptrol.id_rol;
        }

        public Rol getRol(String name) {
            Rol uptrol = db.Rol.Where(uptr => uptr.nombre_rol == name).Single();
            return uptrol;
        }
    }
}
