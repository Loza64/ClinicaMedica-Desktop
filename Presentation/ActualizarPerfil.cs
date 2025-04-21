using Entities;
using Logic;
using MySql.Data.MySqlClient;
using Presentation.Cache;
using System;
using System.Data.SqlTypes;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentation
{
    public partial class ActualizarPerfil : Form
    {
        public ActualizarPerfil()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ActualizarPerfil_Load(object sender, EventArgs e)
        {
            txtdireccion.Text = CacheSoftware.Employee.Direccion;
            txtdui.Text = CacheSoftware.Employee.Dui;
            txtedad.Text = Convert.ToString(CacheSoftware.Employee.Edad);
            txtemail.Text = CacheSoftware.Employee.Email;
            txtgenero.Text = CacheSoftware.Employee.Genero;
            txtnacimiento.Text = CacheSoftware.Employee.Nacimiento.ToShortDateString();
            txtnombre.Text = CacheSoftware.Employee.NombreCompleto;
            txttelefono.Text = CacheSoftware.Employee.Telefono;
            txtusuario.Text = CacheSoftware.Employee.UserName;
        }

        #region DLL
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        private void ActualizarPerfil_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public UserEmpleado GetEntities()
        {
            return new UserEmpleado
            {
                Direccion = txtdireccion.Text,
                Dui = txtdui.Text,
                Edad = Convert.ToInt32(txtedad.Text),
                Email = txtemail.Text,
                Genero = txtgenero.Text,
                Nacimiento = Convert.ToDateTime(txtnacimiento.Text),
                NombreCompleto = txtnombre.Text,
                Telefono = txttelefono.Text,
                UserName = txtusuario.Text,
                Id = CacheSoftware.Employee.Id
            };
        }

        private void bntupdate_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text.Length > 13)
            {
                MessageBox.Show("Nombre de usuario solo debe de tener un maximo de 12 caracteres.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtusuario.Text = "";
            }
            else if (Convert.ToDateTime(txtnacimiento.Text) >= DateTime.Now.Date)
            {
                MessageBox.Show("Fecha de nacimiento no valida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!validacionemail(txtemail.Text))
            {
                MessageBox.Show("Email de actualización invalido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!validacinnacimiento(txtnacimiento.Text))
            {
                MessageBox.Show("Fecha de nacimiento no valida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (!validacionedad(txtedad.Text))
            {
                MessageBox.Show("Edad no valida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (!string.IsNullOrEmpty(txtdireccion.Text) || !string.IsNullOrEmpty(txtdui.Text) || !string.IsNullOrEmpty(txtedad.Text)
                    || !string.IsNullOrEmpty(txtemail.Text) || !string.IsNullOrEmpty(txtgenero.Text) || !string.IsNullOrEmpty(txtnacimiento.Text)
                    || !string.IsNullOrEmpty(txtnombre.Text) || !string.IsNullOrEmpty(txttelefono.Text) || !string.IsNullOrEmpty(txtusuario.Text))
                {
                    try
                    {
                        UserEmpleado emplo = GetEntities();
                        bool responce = LNUserEmpleado.GetInstance().UpdateData(emplo);
                        if (responce)
                        {
                            CacheSoftware.Employee = LNUserEmpleado.GetInstance().GetEmployee(CacheSoftware.Employee.Id);
                            //Notificacion
                            Notificacion notificacion = new Notificacion();
                            notificacion.IdEmpleado = CacheSoftware.Employee.Id;
                            notificacion.Titulo = "Cambios en tu perfil";
                            notificacion.DetalleNotificacion = "Se han realizado cambios en la información de tu perfil de manera exitosa usuario: " + CacheSoftware.Employee.UserName + ".";
                            LNNotificacion.GetInstance().RegistrarNotificacion(notificacion);
                            DialogResult dialogResult = MessageBox.Show("Cambios realizados de manera exitosa.", "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            if (dialogResult == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nombre de usuario, DUI, telefono o email ya son utilizados por otro empleado, no pueden existir empleados con la misma información", "Error de identidad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                else
                {
                    MessageBox.Show("Todos los campos deben de estar llenos.", "Campos invalidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        bool validacionemail(string email)
        {
            bool responce;
            try
            {
                MailAddress mail = new MailAddress(email);
                responce = true;
            }
            catch
            {
                responce = false;
            }
            return responce;
        }

        bool validacinnacimiento(string nacimiento)
        {
            bool responce;
            try
            {
                DateTime numero = Convert.ToDateTime(nacimiento);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
