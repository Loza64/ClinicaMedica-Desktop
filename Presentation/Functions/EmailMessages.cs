using Entities;
using Presentation.Cache;
using System;
using System.Net;
using System.Net.Mail;

namespace Presentation.Functions
{
    public class EmailMessages
    {
        #region PATRON SINGLETON
        private static EmailMessages recovery = null;
        private EmailMessages() { }
        public static EmailMessages GetInstance()
        {
            if (recovery == null)
            {
                recovery = new EmailMessages();
            }
            return recovery;
        }
        #endregion


        MailMessage Email = null;
        SmtpClient client = null;
        private readonly NetworkCredential networkCredential = new NetworkCredential
        {
            UserName = EmailCache.Email,
            Password = EmailCache.Password
        };

        public void NextDate(ProximaCita cita, string email, string usuario)
        {
            using (Email = new MailMessage())
            {
                Email.From = new MailAddress(EmailCache.Email, "Servicios Clínia Médica");
                Email.To.Add(email);
                Email.Subject = ("Tu proxima cita");
                Email.Body = "Estimado/a usuario: " + usuario + " su proxima cita será el día:  " + cita.Proximacita.ToShortDateString() + " a las: " + cita.hora.ToShortTimeString() + " lo estaremos esperando para atenderle," + " por favor procure llegar puntual.";
                Email.Priority = MailPriority.High;
                using (client = new SmtpClient())
                {
                    try
                    {
                        client.Credentials = networkCredential;
                        client.Host = "smtp.gmail.com";
                        client.Port = 587;
                        client.EnableSsl = true;
                        client.Send(Email);
                    }
                    catch (TimeoutException ex)
                    {
                        throw ex;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
        public void RecetarPaciente(RecetaMedica receta, string email, string paciente)
        {
            using (Email = new MailMessage())
            {
                Email.From = new MailAddress(EmailCache.Email, "Servicios Clínia Médica");
                Email.To.Add(email);
                Email.Subject = ("Receta médica para tu enfermedad");
                Email.Body = "Estimado usuario: " + paciente + " el doctor: " + receta.Empleado + " le esta recetando la medicina: " + receta.NombreMedicamento + "; la cantidad a ingerir es de: " + receta.Cantidad + " su dosis recetada es: " + receta.Dosis + " su via de consumo es: " + receta.ViaConsumo + " cualquier duda comuniquese con nosotros en nuestras redes sociales, le agradecemos que confie en nostros, esperamos que se recupere pronto. atentamente: Clínca Médica Dra.Alba de Romero";
                Email.Priority = MailPriority.High;
                using (client = new SmtpClient())
                {
                    try
                    {
                        client.Credentials = networkCredential;
                        client.Host = "smtp.gmail.com";
                        client.Port = 587;
                        client.EnableSsl = true;
                        client.Send(Email);
                    }
                    catch (TimeoutException ex)
                    {
                        throw ex;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
        public void MessageDisableUser(string email, string usuario)
        {
            using (Email = new MailMessage())
            {
                Email.From = new MailAddress(EmailCache.Email, "Servicios Clínia Médica");
                Email.To.Add(email);
                Email.Subject = "Tu cuenta se inhabilito";
                Email.Body = "Estimado usuario: " + usuario + " lamentamos informarte que por motivos de seguridad tu cuenta acaba de ser inhabilitada por lo que no podras acceder a nuestro sitio web, lo que implica que tendras que reservar tus citas de manera presencial, si crees que se trata de un error comunicate atravez de nuestras redes sociales.";
                Email.Priority = MailPriority.High;
                using (client = new SmtpClient())
                {
                    try
                    {
                        client.Credentials = networkCredential;
                        client.Host = "smtp.gmail.com";
                        client.Port = 587;
                        client.EnableSsl = true;
                        client.Send(Email);
                    }
                    catch (TimeoutException ex)
                    {
                        throw ex;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
        public void Warning(string user, string email)
        {
            using (Email = new MailMessage())
            {
                Email.From = new MailAddress(EmailCache.Email, "Portal Clínica Médica");
                Email.To.Add(email);
                Email.Subject = "Cambio de contraseña";
                Email.Body = "Estidamo empleado: " + user + " por medio de este correo electronico se ha confirmado que el cambio de su contraseña fue exitosa, si no fue usted el que cambio la contraseña comuniquese con el administrador de la clínica de manera inmediata para evitar iconvenientes.";
                Email.Priority = MailPriority.High;
                using (client = new SmtpClient())
                {
                    try
                    {
                        client.Credentials = networkCredential;
                        client.Host = "smtp.gmail.com";
                        client.Port = 587;
                        client.EnableSsl = true;
                        client.Send(Email);
                    }
                    catch (TimeoutException ex)
                    {
                        throw ex;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
        public void Pago(string email, string nombre, string numfactura)
        {
            using (Email = new MailMessage())
            {
                Email.From = new MailAddress(EmailCache.Email,"Servicios Clínca Médica");
                Email.To.Add(email);
                Email.Subject = ("Comprobante de pago");
                Email.Body = "Estimado/a " + nombre + " por medio de este correo electronico se le ha envia el comprobante de su pago, su numero de factura es: " + numfactura + " por favor guarde su numero de pago en caso de cualquier inconveniente, le mantendremos al tanto acerca de su proxima cita en caso que llegue a necesitarlo, si no recive ningun email, tome en cuenta que su tratamiento ha finalizado, le agradecemos que confie en nosotros, atentamente Clínca Médica Dra.Alba de Romero.";
                using (client = new SmtpClient())
                {
                    try
                    {
                        client.UseDefaultCredentials = true;
                        client.Credentials = new NetworkCredential(EmailCache.Email, EmailCache.Password);
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.Host = "smtp.gmail.com";
                        client.Port = 587;
                        client.EnableSsl = true;
                        client.Send(Email);
                    }
                    catch (TimeoutException ex)
                    {
                        throw ex;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
        public void PasswordRecovery(string email, string UserName, string Password)
        {
            using (Email = new MailMessage())
            {
                Email.From = new MailAddress(EmailCache.Email, "Portal Clínica Médica");
                Email.To.Add(email);
                Email.Subject = ("Recuperación de contraseña");
                Email.Body = "Estimado usuario: " + UserName + " la contraseña que usted solicito recuperar es: " + Password;
                Email.Priority = MailPriority.High;
                using (client = new SmtpClient())
                {
                    try
                    {
                        client.UseDefaultCredentials = true;
                        client.Credentials = new NetworkCredential(EmailCache.Email, EmailCache.Password);
                        client.DeliveryMethod = SmtpDeliveryMethod.Network;
                        client.Host = "smtp.gmail.com";
                        client.Port = 587;
                        client.EnableSsl = true;
                        client.Send(Email);
                    }
                    catch (TimeoutException ex)
                    {
                        throw ex;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }
    }
}
