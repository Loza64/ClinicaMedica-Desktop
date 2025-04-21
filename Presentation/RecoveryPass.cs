using Entities;
using Logic;
using MySql.Data.MySqlClient;
using Presentation.Functions;
using System;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentation
{
    public partial class RecoveryPass : Form
    {
        public RecoveryPass()
        {
            InitializeComponent();
        }

        #region DLL
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
        private void Recovery_password_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Ingrese correctamente su correo electronico por favor", "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    UserEmpleado user = LNUserEmpleado.GetInstance().RecoveryPass(email);
                    if (user != null)
                    {
                        EmailMessages.GetInstance().PasswordRecovery(user.Email, user.UserName, user.Password);
                        MessageBox.Show("Se te ha enviado un email con la recuperación de contraseña", "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Login login = new Login();
                        login.Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese su correo con el cual esta registrado a Clínica Médica por favor.", "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (TimeoutException ex)
                {
                    DialogResult dr = MessageBox.Show("Información del error: " + ex + " ¿desea cerrar la aplicacion?", "Lo sentimos, ocurrio un error inesperado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("Si el error aun persiste por favor comuniquese con UFOSTART DEVELOPMENT lo mas breve posible");
                        Application.Exit();
                    }
                }
                catch (NullReferenceException ex)
                {
                    DialogResult dr = MessageBox.Show("Información del error: " + ex + " ¿desea cerrar la aplicacion?", "Lo sentimos, ocurrio un error inesperado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("Si el error aun persiste por favor comuniquese con UFOSTART DEVELOPMENT lo mas breve posible");
                        Application.Exit();
                    }
                }
                catch (MySqlException ex)
                {
                    DialogResult dr = MessageBox.Show("Información del error: " + ex + " ¿desea cerrar la aplicacion?", "Lo sentimos, ocurrio un error inesperado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("Si el error aun persiste por favor comuniquese con UFOSTART DEVELOPMENT lo mas breve posible");
                        Application.Exit();
                    }
                }
                catch (SqlNullValueException ex)
                {
                    DialogResult dr = MessageBox.Show("Información del error: " + ex + " ¿desea cerrar la aplicacion?", "Lo sentimos, ocurrio un error inesperado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("Si el error aun persiste por favor comuniquese con UFOSTART DEVELOPMENT lo mas breve posible");
                        Application.Exit();
                    }
                }
                catch (ApplicationException ex)
                {
                    DialogResult dr = MessageBox.Show("Información del error: " + ex + " ¿desea cerrar la aplicacion?", "Lo sentimos, ocurrio un error inesperado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("Si el error aun persiste por favor comuniquese con UFOSTART DEVELOPMENT lo mas breve posible");
                        Application.Exit();
                    }
                }
                catch (Exception ex)
                {
                    DialogResult dr = MessageBox.Show("Información del error: " + ex + " ¿desea cerrar la aplicacion?", "Lo sentimos, ocurrio un error inesperado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (dr == DialogResult.OK)
                    {
                        MessageBox.Show("Si el error aun persiste por favor comuniquese con UFOSTART DEVELOPMENT lo mas breve posible");
                        Application.Exit();
                    }
                }
            }
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            NewPassword newpassword = new NewPassword();
            newpassword.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
