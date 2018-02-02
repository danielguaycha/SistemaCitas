using System;
using System.Net;
using System.Net.Mail;
using ProisProject.Controller;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ProisProject.Controller
{
    static class UtilController
    {
        private static string EMISOR = "deldrvictorvargasclinicaurolog@gmail.com";
        private static string PASSWORD = "CORREO DE PRUEBA";

        public static string TEMPLATEMAILPASSWORD = "<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Strict//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd'><html xmlns='http://www.w3.org/1999/xhtml'><head><meta http-equiv='Content-Type' content='text/html; charset=utf-8'/><meta name='viewport' content='width=device-width, initial-scale=1.0'/><title>Correo Recibido</title><style type='text/css'>@media screen and (max-width: 600px){table[class='container']{width: 95% !important;}}body{background-color: #cccccc3d;}#outlook a{padding:0;}body{width:100% !important; -webkit-text-size-adjust:100%; -ms-text-size-adjust:100%; margin:0; padding:0;}.ExternalClass{width:100%;}.ExternalClass, .ExternalClass p, .ExternalClass span, .ExternalClass font, .ExternalClass td, .ExternalClass div{line-height: 100%;}#backgroundTable{padding:0; width:70% !important; line-height: 100% !important;position: relative;border: 1px solid #ebebeb; margin: 0 auto; background: #fff;}img{outline:none; text-decoration:none; -ms-interpolation-mode: bicubic;}a img{border:none;}.image_fix{display:block;}p{margin: 1em 0;}h1, h2, h3, h4, h5, h6{color: black !important;}h1 a, h2 a, h3 a, h4 a, h5 a, h6 a{color: blue !important;}h1 a:active, h2 a:active, h3 a:active, h4 a:active, h5 a:active, h6 a:active{color: red !important;}h1 a:visited, h2 a:visited, h3 a:visited, h4 a:visited, h5 a:visited, h6 a:visited{color: purple !important;}table td{border-collapse: collapse;}table{border-collapse:collapse; mso-table-lspace:0pt; mso-table-rspace:0pt;}a{color: #000;}@media only screen and (max-device-width: 480px){a[href^='tel'], a[href^='sms']{text-decoration: none;color: black; /* or whatever your want */pointer-events: none;cursor: default;}.mobile_link a[href^='tel'], .mobile_link a[href^='sms']{text-decoration: default;color: orange !important; /* or whatever your want */pointer-events: auto;cursor: default;}}@media only screen and (min-device-width: 768px) and (max-device-width: 1024px){a[href^='tel'], a[href^='sms']{text-decoration: none;color: blue; /* or whatever your want */pointer-events: none;cursor: default;}.mobile_link a[href^='tel'], .mobile_link a[href^='sms']{text-decoration: default;color: orange !important;pointer-events: auto;cursor: default;}}@media only screen and (-webkit-min-device-pixel-ratio: 2){/* Put your iPhone 4g styles in here */}@media only screen and (-webkit-device-pixel-ratio:.75){/* Put CSS for low density (ldpi) Android layouts in here */}@media only screen and (-webkit-device-pixel-ratio:1){/* Put CSS for medium density (mdpi) Android layouts in here */}@media only screen and (-webkit-device-pixel-ratio:1.5){/* Put CSS for high density (hdpi) Android layouts in here */}/* end Android targeting */h2{color:#181818;font-family:Helvetica, Arial, sans-serif;font-size:22px;line-height: 22px;font-weight: normal;}a.link1{}a.link2{color:#fff;text-decoration:none;font-family:Helvetica, Arial, sans-serif;font-size:16px;color:#fff;border-radius:4px;}p{color:#555;font-family:Helvetica, Arial, sans-serif;font-size:16px;line-height:160%;}</style><script type='colorScheme' class='swatch active'>{'name':'Default', 'bgBody':'ffffff', 'link':'fff', 'color':'555555', 'bgItem':'ffffff', 'title':'181818'}</script></head><body><table cellpadding='0' width='100%' cellspacing='0' border='0' id='backgroundTable' class='bgBody'><tr><td><table cellpadding='0' width='620' class='container' align='center' cellspacing='0' border='0'><tr><td><table cellpadding='0' cellspacing='0' border='0' align='center' width='600' class='container'><tr><td class='movableContentContainer bgItem'><div class='movableContent'><table cellpadding='0' cellspacing='0' border='0' align='center' width='600' class='container'><tr height='40'><td width='200'>&nbsp;</td><td width='200'>&nbsp;</td><td width='200'>&nbsp;</td></tr><tr><td width='200' valign='top'>&nbsp;</td><td width='200' valign='top' align='center'><div class='contentEditableContainer contentImageEditable'> <div class='contentEditable' align='center' > <img src='https://i.imgur.com/Lku6jWx.png' width='155' height='155' alt='Logo' data-default='placeholder'/> </div></div></td><td width='200' valign='top'>&nbsp;</td></tr><tr height='25'><td width='200'>&nbsp;</td><td width='200'>&nbsp;</td><td width='200'>&nbsp;</td></tr></table></div><div class='movableContent'><table cellpadding='0' cellspacing='0' border='0' align='center' width='600' class='container'><tr><td width='100%' colspan='3' align='center' ><div class='contentEditableContainer contentTextEditable'> <div class='contentEditable' align='center' > <h1 style='font-family: sans-serif;'>CMSystem</h1> <h2>Generación automatica de Contraseña</h2> </div></div></td></tr><tr><td width='100'>&nbsp;</td><td width='400' align='center'><div class='contentEditableContainer contentTextEditable'> <div class='contentEditable' align='left' > <p >Hola, <br/> <br/>Has recibido este correo de parte de la Clínia Urológica, mismo que te concede el permiso para acceder al sistema automatizado de citas médicas, a continuación encontrarás la clave para inicio de sesión.</p></div></div></td><td width='100'>&nbsp;</td></tr></table><table cellpadding='0' cellspacing='0' border='0' align='center' width='600' class='container'><tr><td width='200'>&nbsp;</td><td width='200' align='center' style='padding-top:25px;'><table cellpadding='0' cellspacing='0' border='0' align='center' width='200' height='50'><tr><td bgcolor='#196181' align='center' style='border-radius:4px;' width='300' height='60'><div class='contentEditableContainer contentTextEditable'> <div class='contentEditable' align='center' > <a style='font-size: 30px' class='link2'>{clave}</a> </div></div></td></tr></table></td><td width='200'>&nbsp;</td></tr></table></div><div class='movableContent'><table cellpadding='0' cellspacing='0' border='0' align='center' width='600' class='container'><tr><td width='100%' colspan='2' style='padding-top:65px;'><hr style='height:1px;border:none;color:#333;background-color:#ddd;'/></td></tr><tr><td width='60%' height='70' valign='middle' style='padding-bottom:20px;'><div class='contentEditableContainer contentTextEditable'> <div class='contentEditable' align='left' ><span style='font-size:11px;color:#555;font-family:Helvetica, Arial, sans-serif;line-height:200%;'>Machala - El Oro | 072933831 - 0999612938</span><br/> </div></div></td></tr></table></div></td></tr></table></td></tr></table></td></tr></table></body></html>";
        private static bool sendMail(string destinatario, string body, string asunto,  string ruta)
        {
            if (haveInternet())
            {
                try
                {
                    MailMessage correos = new MailMessage();
                    SmtpClient envios = new SmtpClient();
                    correos.To.Clear();
                    correos.Body = body;
                    correos.Subject = asunto;
                    correos.IsBodyHtml = true;
                    correos.To.Add(destinatario.Trim());
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
                    return true;
                }
                catch(Exception e){
                    Console.WriteLine("No se puedo enviar correo a: "+destinatario+" | "+e.Message);
                    LogsController.store("No se envio el correo a"+destinatario+" contenido {"+body+"}", LogsController.LogLevel.ERROR);
                    return false;
                }
            }
            return false;
        }

        public static bool haveInternet()
        {
            try
            {
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch
            {
                return false;
            }
           
        }

        public static bool VerificarCedula(string dato)
        {
            string cedula = dato;
            char[] vector = cedula.ToArray();
            int sumatotal = 0;
            int numeroveces;
            if (vector.Length == 10)
            {
                numeroveces = 10;
                for (int i = 0; i < numeroveces - 1; i++)
                {
                    int numero = int.Parse(vector[i].ToString());
                    if ((i + 1) % 2 == 1)
                    {
                        numero = int.Parse(vector[i].ToString()) * 2;
                        if (numero > 9)
                        {
                            numero = numero - 9;
                        }
                    }
                    sumatotal += numero;
                }
                sumatotal = 10 - (sumatotal % 10);
                int aux = int.Parse(vector[9].ToString());
                if (sumatotal <= 99 && sumatotal >= 10)
                {
                    string sumatotal2 = Convert.ToString(sumatotal);
                    char[] vector2 = sumatotal2.ToArray();
                    int axu2 = int.Parse(vector2[1].ToString());
                    if (aux == axu2)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    if (sumatotal == aux)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                //no tiene 10 caracteres
                return false;
            }
        }

        public static void validaNumerosDecimales(KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator
                || e.KeyChar == (Char)Keys.Back)
            {

                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static void validarNumeros(KeyPressEventArgs e) {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        public static void validaLetras(KeyPressEventArgs e) {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar !=(char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }
        public static string f(decimal val) {
            return string.Format("{0:C}", val);
        }
        public static string GenerarContraseña()
        {
            Random r = new Random();
            int longitud = r.Next(5, 12);
            char[] contra = new char[longitud];
            Random rand = new Random();
            int aletorio;
            int d;
            string pass = "";
            for (int i = 0; i < longitud; i++)
            {
                d = rand.Next(1, 4);
                switch (d)
                {
                    case 1://NUMEROS
                        aletorio = rand.Next(48, 57);
                        contra[i] = (char)aletorio;
                        break;
                    case 2://MAYUSCULAS
                        aletorio = rand.Next(65, 90);
                        contra[i] = (char)aletorio;
                        break;
                    case 3://minusculas
                        aletorio = rand.Next(97, 122);
                        contra[i] = (char)aletorio;
                        break;
                }
            }
            for (int i = 0; i < longitud; i++)
            {
                pass = pass + contra[i].ToString();
            }
            return pass;
        }

        public static string Encriptar(this string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        public static string DesEncriptar(this string _cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

        private static bool invalid = false;

        public static bool IsValidEmail(string strIn)
        {
            invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            try
            {
                return Regex.IsMatch(strIn,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private static string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }
    }
}
