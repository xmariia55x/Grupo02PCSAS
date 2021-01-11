using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Grupo02PCSAS
{
    class Correo
    {
        public static void sendEmail(string cuerpo, string asunto, Usuario usuario)
        {
            try
            {
                MailMessage message = new MailMessage();
                SmtpClient smtp = new SmtpClient();
                message.From = new MailAddress("grupo02pcsas@gmail.com");
                message.To.Add(new MailAddress(usuario.CorreoUsuario));
                message.Subject = asunto;
                message.IsBodyHtml = true; //to make message body as html  
                message.Body = cuerpo;
                smtp.Port = 587;
                smtp.Host = "smtp.gmail.com"; //for gmail host  
                smtp.EnableSsl = true;
                //smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("grupo02pcsas@gmail.com", "grupo02pcsas!!");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(message);
                //System.Windows.Forms.MessageBox.Show("ENVIADO");
            }
            catch (Exception )
            {

            }
        }
        /*private void button1_Click(object sender, EventArgs e)
        {
            //string htmlString = recordatorioEvento("2/1/2021"); //here you will be getting an html string  
            //sendEmail(htmlString, "Eventos proximos", null);
        }*/

        public static string recuperarContrasenia(Usuario usuario)
        {
            try
            {
                string nuevaContrasenia = usuario.NombreUsuario.ToLower() + "2021";
                string messageBody = "<font>Hola, desde PCSAS te mandamos una nueva contraseña para que puedas iniciar sesion: " + nuevaContrasenia + ". </font><br><br>";
                messageBody = messageBody + "<font> Puedes cambiarla desde tu perfil, muchas gracias. Un saludo. NO RESPONDER A ESTE CORREO. </font><br><br>";
                usuario.ContraseniaUsuario = nuevaContrasenia;
                return messageBody;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static string recordatorioCurso(Curso curso)
        {
            try
            {
                string messageBody = "<font>Hola, desde PCSAS te recordamos que proximamente tienes un evento: " + curso.ToString() + ". </font><br><br>";
                messageBody = messageBody + "<font> Esperamos tu asistencia, muchas gracias. Un saludo. NO RESPONDER A ESTE CORREO. </font><br><br>";
                return messageBody; 
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static string recordatorioActividad(Actividad actividad)
        {
            try
            {
                string messageBody = "<font>Hola, desde PCSAS te recordamos que proximamente tienes un evento: " + actividad.ToString() + ". </font><br><br>";
                messageBody = messageBody + "<font> Esperamos tu asistencia, muchas gracias. Un saludo. NO RESPONDER A ESTE CORREO. </font><br><br>";
                return messageBody;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
