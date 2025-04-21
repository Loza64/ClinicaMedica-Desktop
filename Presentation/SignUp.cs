using Entities;
using Logic;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentation
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        byte[] abyte;

        #region DLL
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
        private void SignUp_Load(object sender, EventArgs e)
        {
            try
            {
                ListarArea();
                ListarRoll();
                ListarGeneros();
                MemoryStream ms = new MemoryStream();
                imgperfil.Image.Save(ms, ImageFormat.Jpeg);
                abyte = ms.ToArray();
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
        private void ListarArea()
        {
            listarea.DataSource = LNArea.GetInstance().ListarArea();
            listarea.DisplayMember = "AreaTrabajo";
            listarea.ValueMember = "Id";
        }
        private void ListarRoll()
        {
            listroll.DataSource = LNRoll.GetInstance().ListarRoll();
            listroll.DisplayMember = "Posicion";
            listroll.ValueMember = "Id";
        }
        private void ListarGeneros()
        {
            List<string> generos = new List<string>
            {
                "Masculino",
                "Femenino"
            };
            cmbgenero.DataSource = generos;
        }
        public UserEmpleado GetEntities()
        {
            return new UserEmpleado
            {
                UserName = txtusuario.Text,
                Dui = txtdui.Text,
                NombreCompleto = txtnombre.Text,
                Edad = Convert.ToInt32(txtedad.Text),
                Nacimiento = dtmfecha.Value,
                Genero = cmbgenero.SelectedItem.ToString(),
                Direccion = txtdireccion.Text,
                Email = txtemail.Text,
                Telefono = txt_telefono.Text,
                Password = txtcontraseña.Text,
                Roll = Convert.ToInt32(listroll.SelectedValue),
                Area = Convert.ToInt32(listarea.SelectedValue),
                Imagen = abyte
            };
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtusuario.Text) || !string.IsNullOrEmpty(txtdui.Text) || !string.IsNullOrEmpty(txtnombre.Text)
               || !string.IsNullOrEmpty(txtedad.Text) || !string.IsNullOrEmpty(txtdireccion.Text) || !string.IsNullOrEmpty(txtemail.Text) 
               || !string.IsNullOrEmpty(txt_telefono.Text) || !string.IsNullOrEmpty(txtcontraseña.Text))
            {
                if (txtusuario.Text.Length > 13)
                {
                    MessageBox.Show("Nombre de usuario solo debe de tener un maxiom de 12 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                else if (dtmfecha.Value > DateTime.Now.Date)
                {
                    MessageBox.Show("Fecha de nacimiento no valida", "Nacimiento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    UserEmpleado users = GetEntities();
                    try
                    {
                        bool check = LNUserEmpleado.GetInstance().CheckData(txtusuario.Text, txtemail.Text, txtdui.Text, txt_telefono.Text);
                        if (!check)
                        {
                            bool user = LNUserEmpleado.GetInstance().SingUp(users);
                            if (user == true)
                            {
                                MessageBox.Show("Registro realizado exitosamete, bienvenido a Clínica Médica empleado: " + users.UserName + ".", "Bien hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Login login = new Login();
                                login.Show();
                                this.Close();
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
        bool EmailValidation(string email)
        {
            bool responce;
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
                int numero = Convert.ToInt32(edad);
                responce = true;
            }
            catch
            {
                responce = false;
            }
            return responce;
        }
        private void SignUp_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel9_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
    }
}
