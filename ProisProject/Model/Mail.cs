using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;

namespace ProisProject.Model
{
    class Mail
    {
        private string EMISOR = "deldrvictorvargasclinicaurolog@gmail.com";
        private string PASSWORD = "CORREO DE PRUEBA";

        private string to;
        private string body;
        private string content;
        private string ruta;

        public Mail(string to, string body, string content, string ruta) {
            this.to = to;
            this.body = body;
            this.content = content;
            this.ruta = ruta;
        }

        public void Send() {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += executeWorker;
            worker.RunWorkerCompleted += finishWorker;
            worker.RunWorkerAsync();
        }
        private static void executeWorker(object o, DoWorkEventArgs arg)
        {

        }

        private static void finishWorker(object o, RunWorkerCompletedEventArgs arg)
        {
            
        }

        public string To
        {
            get
            {
                return to;
            }

            set
            {
                to = value;
            }
        }

        public string Body
        {
            get
            {
                return body;
            }

            set
            {
                body = value;
            }
        }

        public string Context
        {
            get
            {
                return content;
            }

            set
            {
                content = value;
            }
        }

        public string Ruta
        {
            get
            {
                return ruta;
            }

            set
            {
                ruta = value;
            }
        }

    }
}
