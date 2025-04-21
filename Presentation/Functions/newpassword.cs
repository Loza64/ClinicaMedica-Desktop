using Entities;
using Logic;
using MySql.Data.MySqlClient;
using System;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentation.Functions
{
    public partial class NewPassword : Form
    {
        public NewPassword()
        {
            InitializeComponent();
        }

        #region DLL
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        private void btncambio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtantiguacontraseña.Text) || string.IsNullOrEmpty(txtnuevacontraseña.Text) || string.IsNullOrEmpty(txtusuario.Text) || string.IsNullOrEmpty(txtcontraseña2.Text))
            {
                MessageBox.Show("Por favor llene de manera correcta el formulario.",
                          "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtcontraseña2.Text != txtnuevacontraseña.Text)
                {
                    MessageBox.Show("Las contraseñas no coinciden",
                     "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        UserEmpleado confirm = LNUserEmpleado.GetInstance().ConfirmUpdatePassword(txtusuario.Text, txtantiguacontraseña.Text);
                        if (confirm != null)
                        {
                            bool update = LNUserEmpleado.GetInstance().UpdatePassword(txtusuario.Text, txtnuevacontraseña.Text);
                            if (update)
                            {
                                EmailMessages.GetInstance().Warning(txtusuario.Text, confirm.Email);
                                DialogResult dialogResult = MessageBox.Show("La contraseña se actualizo de manera correcta.", "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                if (dialogResult == DialogResult.OK)
                                {
                                    Login login = new Login();
                                    login.Show();
                                    this.Close();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nombre de usuario o antigua contraseña no son los correctos.", "Error de actulización", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
        private void newpassword_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtantiguacontraseña_Click(object sender, EventArgs e)
        {
            if (txtantiguacontraseña.UseSystemPasswordChar == false)
            {
                txtantiguacontraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtnuevacontraseña_Click(object sender, EventArgs e)
        {
            if (txtnuevacontraseña.UseSystemPasswordChar == false)
            {
                txtnuevacontraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtcontraseña2_Click(object sender, EventArgs e)
        {
            if (txtcontraseña2.UseSystemPasswordChar == false)
            {
                txtcontraseña2.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
