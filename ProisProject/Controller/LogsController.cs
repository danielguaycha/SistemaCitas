using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProisProject.Model.Data;
using System.ComponentModel;

namespace ProisProject.Controller
{
    static class LogsController
    {
        private static ControlLog log = null;

        public static void store(string description, LogLevel level) {
            log = new ControlLog();
            log.nivel = level.ToString();
            log.descripcion = description;
            log.fecha = DateTime.Now;
            log.status = 1;
            log.id_usuario = 1;

            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += executeWorker;
            worker.RunWorkerCompleted += finishWorker;
            worker.RunWorkerAsync();
        }

        private static void executeWorker(object o , DoWorkEventArgs arg) {
            try
            {
                PostDataContext db = new PostDataContext();
                Console.WriteLine("Guardando Log... Fecha: " + log.fecha + " | Nivel: " + log.nivel);
                db.ControlLog.InsertOnSubmit(log);
                db.SubmitChanges();
                db = null;
            }catch(Exception e){
                Console.WriteLine("Log no ejecutado! "+e.Message);
                log = null;
            }
        }

        private static void finishWorker(object o, RunWorkerCompletedEventArgs arg) {
            log = null;
            Console.WriteLine("Destruyendo Log y terminando...");
        }

        public enum LogLevel {
            INFO, SUCCESS, ERROR, WARNING
        }
    }
    
}
