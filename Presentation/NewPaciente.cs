using Entities;
using Logic;
using MySql.Data.MySqlClient;
using System;
using System.Data.SqlTypes;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentation
{
    public partial class NewPaciente : Form
    {
        public NewPaciente()
        {
            InitializeComponent();
        }


        public Usuario GetEntities()
        {
            Usuario user = new Usuario();
            user.Username = txtusuario.Text;
            user.Dui = txtdui.Text;
            user.NombreCompleto = txtnombre.Text;
            user.Edad = Convert.ToInt32(txtedad.Text);
            user.Nacimiento = dateTime.Value;
            try
            {
                user.Genero = cmbgenero.SelectedItem.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione el genero por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MemoryStream memory = new MemoryStream();
            imgperfil.Image.Save(memory, ImageFormat.Jpeg);
            user.Imagen = memory.ToArray();
            user.Direccion = txtdireccion.Text;
            user.Email = txtemail.Text;
            user.Telefono = txt_telefono.Text;
            user.Password = txtcontraseña.Text;
            user.Confirmacion = true;
            user.EstadoUsuario = true;
            return user;
        }

        #region DLL
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtusuario.Text) || !string.IsNullOrEmpty(txtdui.Text) || !string.IsNullOrEmpty(txtnombre.Text)
                || !string.IsNullOrEmpty(txtedad.Text) || !string.IsNullOrEmpty(txtdireccion.Text)
                || !string.IsNullOrEmpty(txtemail.Text) || !string.IsNullOrEmpty(txt_telefono.Text) || !string.IsNullOrEmpty(txtcontraseña.Text))
            {
                if (txtusuario.Text.Length > 13)
                {
                    MessageBox.Show("Nombre de usuario solo debe de tener un maximo de 12 caracteres y 6 como minimo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtusuario.Text = "";
                }
                else if (txt_telefono.Text.Length < 8)
                {
                    MessageBox.Show("Dijite un telefono valido", "Numero no validos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_telefono.Text = "";
                }
                else if (!EmailValidation(txtemail.Text))
                {
                    MessageBox.Show("Dijite un email valido", "Correo invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtemail.Text = "";
                }
                else if (txtdui.Text.Length != 10)
                {
                    MessageBox.Show("DUI no valido", "Correo invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdui.Text = "";
                }
                else if (!validacionedad(txtedad.Text))
                {
                    MessageBox.Show("Edad no valida", "Edad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtedad.Text = "";
                }
                else if (dateTime.Value > DateTime.Now.Date)
                {
                    MessageBox.Show("Fecha de nacimiento no valida", "Nacimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    try
                    {
                        Usuario users = GetEntities();
                        bool check = LNUsuario.GetInstance().CheckData(txtusuario.Text, txtemail.Text, txtdui.Text, txt_telefono.Text);
                        if (!check)
                        {
                            bool user = LNUsuario.GetInstance().NewUser(users);
                            if (user == true)
                            {
                                MessageBox.Show("El paciente se ha registrado de manera exitosa", "Bien hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("DUI, nombre de usuario, email o numero de telefono ya son registrados por otro usuario", "Dato ocupado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            else
            {
                MessageBox.Show("Por favor llene todo el formulario", "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtcontraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtcontraseña.UseSystemPasswordChar == false)
            {
                txtcontraseña.UseSystemPasswordChar = true;
            }
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel9_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Registrar_paciente_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        bool EmailValidation(string email)
        {
            bool responce = true;
            try
            {
                var mail = new MailAddress(txtemail.Text);
                responce = true;
            }
            catch
            {
                responce = false;
            }
            return responce;
        }

        bool validacionedad(string edad)
        {
            bool responce;
            try
            {
                int numero = Convert.ToInt32(txtedad.Text);
                responce = true;
            }
            catch
            {
                responce = false;
            }
            return responce;
        }

        private void Registrar_paciente_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
