using Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class sendmessages
    {
        #region PATRON SINGLETON
        private static sendmessages recovery = null;
        private sendmessages() { }
        public static sendmessages GetInstance()
        {
            if (recovery == null)
            {
                recovery = new sendmessages();
            }
            return recovery;
        }
        #endregion

        public void next_date(ProximaCita cita)
        {
            MailMessage Email = new MailMessage();
            Email.From = new MailAddress("medicaclinica196@gmail.com");
            Email.To.Add(cita.emailusuario);
            Email.Subject = ("Tu proxima cita");
            Email.Body = "Estimado/a usuario: " + cita.usuario + " su proxima cita será el día:  "
                + cita.Proximacita + " a las: " + cita.hora + " con el doctor: " + cita.empleado + " lo estaremos esperando para atenderle," +
                " por favor procure llegar puntual.";
            Email.Priority = MailPriority.High;
            SmtpClient client = new SmtpClient();
            client.Credentials = new NetworkCredential("medicaclinica196@gmail.com", "B6a1C514");
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            try
            {
                client.Send(Email);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void RecetarPaciente(RecetaMedica receta)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("medicaclinica196@gmail.com");
            message.To.Add(receta.Emailpaciente);
            message.Subject = ("Receta médica para tu enfermedad");
            message.Body = "Estimado usuario: " + receta.Paciente + " el doctor: " + receta.Empleado +
                " le esta recetando la medicina: " + receta.NombreMedicamento + "; la cantidad a ingerir es de: "
                + receta.Cantidad + " durante " + receta.Dosis + " su via de consumo es: " + receta.ViaConsumo +
                " cualquier duda comuniquese con nosotros, esperamos que se recupere pronto.";
            message.Priority = MailPriority.High;

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("medicaclinica196@gmail.com", "B6a1C514");
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(message);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void messageuserdisable(string email, string usuario)
        {
            MailMessage message = new MailMessage();
            message.From = new MailAddress("medicaclinica196@gmail.com");
            message.To.Add(email);
            message.Subject = "Tu cuenta se inhabilito";
            message.Body = "Estimado usuario: " + usuario + " lamentamos informarte que por motivos de seguridad tu cuenta " +
                "acaba de ser inhabilitada por lo que no podras acceder a nuestro sitio web, lo que implica que tendras" +
                " que reservar tus citas de manera presencial, si crees que se trata de un error comunicate atravez de nuestras" +
                " redes sociales.";
            message.Priority = MailPriority.High;
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("medicaclinica196@gmail.com", "B6a1C514");
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(message);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
