using Presentation;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public class RecoveryPassword
    {
        #region PATRON SINGLETON
        private static RecoveryPassword recovery = null;
        private RecoveryPassword() { }
        public static RecoveryPassword GetInstance()
        {
            if(recovery == null)
            {
                recovery = new RecoveryPassword();
            }
            return recovery;
        }
        #endregion

        public string password_recovery(string email, string UserName, string Password)
        {
            MailMessage Email = new MailMessage();
            Email.From = new MailAddress("medicaclinica196@gmail.com");
            Email.To.Add(email);
            Email.Subject = ("Recuperación de contraseña");
            Email.Body = "Estimado usuario: " + UserName + " la contraseña que usted solicito recuperar es: " + Password;
            Email.Priority = MailPriority.Normal;

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

            return email;
        }

    }
}
