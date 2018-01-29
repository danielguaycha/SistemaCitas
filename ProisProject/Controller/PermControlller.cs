using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProisProject.Model;
using ProisProject.Model.Data;
namespace ProisProject.Controller
{
    class PermControlller
    {
        PostDataContext db = new PostDataContext();
        List<Permisos> perms = new List<Permisos>();

        public Dictionary<String, Permisos> get() {
            var perm = new Dictionary<String, Permisos>();
            var q = from p in db.Permisos select p;
            foreach (Permisos p in q) {
                perm[p.valor] = p;
            }
            return perm;
        }

        public void init() {
            var q = from p in db.Permisos select p;
            foreach (Permisos p in q) {
                perms.Add(p);
            }
            _medicPerm();
            _pacPerm();
            _citasPerm();
            _consultaPerm();
            _othersPerm();
        }

        public bool exist(string value) {
            return (from p in perms where p.valor == value select p).Count()>0;
        }

        private void _medicPerm() {
            try
            {
                if (!this.exist(PermType.MEDIC_STORE.ToString()))
                {
                    Permisos d1 = new Permisos();
                    d1.descripcion = "Registrar Médico";
                    d1.valor = PermType.MEDIC_STORE.ToString();
                    db.Permisos.InsertOnSubmit(d1);
                }
                if (!this.exist(PermType.MEDIC_UPDATE.ToString()))
                {
                    Permisos d2 = new Permisos();
                    d2.descripcion = "Actualizar Médicos";
                    d2.valor = PermType.MEDIC_UPDATE.ToString();
                    db.Permisos.InsertOnSubmit(d2);
                }
                if (!this.exist(PermType.MEDIC_DELETE.ToString()))
                {
                    Permisos d2 = new Permisos();
                    d2.descripcion = "Eliminar Médicos";
                    d2.valor = PermType.MEDIC_DELETE.ToString();
                    db.Permisos.InsertOnSubmit(d2);
                }
                if (!this.exist(PermType.MEDIC_VIEW.ToString()))
                {
                    Permisos d2 = new Permisos();
                    d2.descripcion = "Listar Médicos";
                    d2.valor = PermType.MEDIC_VIEW.ToString();
                    db.Permisos.InsertOnSubmit(d2);
                }
                db.SubmitChanges();
            }
            catch (Exception ex) {
                Console.WriteLine("Error instalando Permisos {Medicos}"+ex.Message);
                _medicPerm();
            }
        }

        private void _pacPerm() {
            try
            {
                if (!this.exist(PermType.PACIENTE_STORE.ToString()))
                {
                    Permisos d1 = new Permisos();
                    d1.descripcion = "Registrar Paciente";
                    d1.valor = PermType.PACIENTE_STORE.ToString();
                    db.Permisos.InsertOnSubmit(d1);
                }
                if (!this.exist(PermType.PACIENTE_UPDATE.ToString()))
                {
                    Permisos d2 = new Permisos();
                    d2.descripcion = "Actualizar Paciente";
                    d2.valor = PermType.PACIENTE_UPDATE.ToString();
                    db.Permisos.InsertOnSubmit(d2);
                }
                if (!this.exist(PermType.PACIENTE_DELETE.ToString()))
                {
                    Permisos d2 = new Permisos();
                    d2.descripcion = "Eliminar Paciente";
                    d2.valor = PermType.PACIENTE_DELETE.ToString();
                    db.Permisos.InsertOnSubmit(d2);
                }
                if (!this.exist(PermType.PACIENTE_VIEW.ToString()))
                {
                    Permisos d2 = new Permisos();
                    d2.descripcion = "Listar Paciente";
                    d2.valor = PermType.PACIENTE_VIEW.ToString();
                    db.Permisos.InsertOnSubmit(d2);
                }
                db.SubmitChanges();
            }
            catch (Exception ex) {
                Console.WriteLine("Error instalando Permisos {Pacientes}"+ex.Message);
                _pacPerm();
            }
        }

        private void _citasPerm()
        {
            try
            {
                if (!this.exist(PermType.CITA_STORE.ToString()))
                {
                    Permisos d1 = new Permisos();
                    d1.descripcion = "Registrar Cita";
                    d1.valor = PermType.CITA_STORE.ToString();
                    db.Permisos.InsertOnSubmit(d1);
                }
                if (!this.exist(PermType.CITA_UPDATE.ToString()))
                {
                    Permisos d2 = new Permisos();
                    d2.descripcion = "Actualizar Cita";
                    d2.valor = PermType.CITA_UPDATE.ToString();
                    db.Permisos.InsertOnSubmit(d2);
                }
                if (!this.exist(PermType.CITA_DELETE.ToString()))
                {
                    Permisos d2 = new Permisos();
                    d2.descripcion = "Eliminar Cita";
                    d2.valor = PermType.CITA_DELETE.ToString();
                    db.Permisos.InsertOnSubmit(d2);
                }
                if (!this.exist(PermType.CITA_VIEW.ToString()))
                {
                    Permisos d2 = new Permisos();
                    d2.descripcion = "Listar citas";
                    d2.valor = PermType.CITA_VIEW.ToString();
                    db.Permisos.InsertOnSubmit(d2);
                }
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error instalando Permisos {Medicos}" + ex.Message);
                _citasPerm();
            }
        }

        private void _consultaPerm()
        {
            try
            {
                if (!this.exist(PermType.CONSULTA_STORE.ToString()))
                {
                    Permisos d1 = new Permisos();
                    d1.descripcion = "Registrar consulta";
                    d1.valor = PermType.CONSULTA_STORE.ToString();
                    db.Permisos.InsertOnSubmit(d1);
                }
                if (!this.exist(PermType.CONSULTA_UPDATE.ToString()))
                {
                    Permisos d2 = new Permisos();
                    d2.descripcion = "Actualizar consulta";
                    d2.valor = PermType.CONSULTA_UPDATE.ToString();
                    db.Permisos.InsertOnSubmit(d2);
                }
                if (!this.exist(PermType.CONSULTA_DELETE.ToString()))
                {
                    Permisos d2 = new Permisos();
                    d2.descripcion = "Eliminar consulta";
                    d2.valor = PermType.CONSULTA_DELETE.ToString();
                    db.Permisos.InsertOnSubmit(d2);
                }
                if (!this.exist(PermType.CONSULTA_VIEW.ToString()))
                {
                    Permisos d2 = new Permisos();
                    d2.descripcion = "Listar consulta";
                    d2.valor = PermType.CONSULTA_VIEW.ToString();
                    db.Permisos.InsertOnSubmit(d2);
                }
                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error instalando Permisos {Cosultas}" + ex.Message);
                _consultaPerm();
            }
        }

        private void _othersPerm() {
            try
            {
                if (!this.exist(PermType.REPORT_VIEW.ToString()))
                {
                    Permisos d1 = new Permisos();
                    d1.descripcion = "Ver Reportes";
                    d1.valor = PermType.REPORT_VIEW.ToString();
                    db.Permisos.InsertOnSubmit(d1);
                }
                if (!this.exist(PermType.LOG_VIEW.ToString()))
                {
                    Permisos d1 = new Permisos();
                    d1.descripcion = "Ver Log";
                    d1.valor = PermType.LOG_VIEW.ToString();
                    db.Permisos.InsertOnSubmit(d1);
                }

                if (!this.exist(PermType.HISTORIAL_VIEW.ToString()))
                {
                    Permisos d1 = new Permisos();
                    d1.descripcion = "Ver Historial";
                    d1.valor = PermType.HISTORIAL_VIEW.ToString();
                    db.Permisos.InsertOnSubmit(d1);
                }

                db.SubmitChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error instalando Permisos {Otros}" + ex.Message);
                _othersPerm();
            }
        }
    }

    public enum PermType {
        MEDIC_STORE, MEDIC_UPDATE, MEDIC_DELETE, MEDIC_VIEW,
        PACIENTE_STORE, PACIENTE_UPDATE, PACIENTE_DELETE, PACIENTE_VIEW,
        USER_STORE, USER_UPDATE, USER_DELETE, USER_VIEW,
        CITA_STORE, CITA_UPDATE, CITA_DELETE, CITA_VIEW, 
        CONSULTA_STORE, CONSULTA_UPDATE, CONSULTA_DELETE, CONSULTA_VIEW,
        REPORT_VIEW, LOG_VIEW, HISTORIAL_VIEW
    }
}
