using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using ProisProject.Controller;
using System.Net.Mail;
using System.Net;

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

        public Mail(string to, string body, string subject, string ruta) {
            this.to = to;
            this.body = body;
            this.content = subject;
            this.ruta = ruta;
        }

        public void Send() {
            BackgroundWorker worker = new BackgroundWorker();
            worker.DoWork += executeWorker;
            worker.RunWorkerCompleted += finishWorker;
            worker.RunWorkerAsync();
        }
        private  void executeWorker(object o, DoWorkEventArgs arg)
        {
            if (UtilController.haveInternet())
            {
                try
                {
                    MailMessage correos = new MailMessage();
                    SmtpClient envios = new SmtpClient();
                    correos.To.Clear();
                    correos.Body =this.Body ;
                    correos.Subject = this.Context;
                    correos.IsBodyHtml = true;
                    correos.To.Add(this.To.Trim());
                    //A continuacion se agrega el archivo adjunto
                    if (ruta.Equals("") == false)
                    {
                        System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(ruta);
                        correos.Attachments.Add(archivo);
                    }
                    correos.From = new MailAddress(EMISOR);
                    envios.Credentials = new NetworkCredential(EMISOR, PASSWORD);
                    //Datos importantes no modificables para tener acceso a las cuentas
                    //envios.Host = "smtp.live.com";
                    envios.Host = "smtp.gmail.com";
                    envios.Port = 587;
                    envios.EnableSsl = true;
                    envios.Send(correos);
                }
                catch (Exception e)
                {
                    Console.WriteLine("No se puedo enviar correo a: " + this.To + " | " + e.Message);
                    LogsController.store("No se envio el correo a" + this.To + " contenido {" + body + "}", LogsController.LogLevel.ERROR);
                }
            }
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
