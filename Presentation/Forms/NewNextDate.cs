using Entities;
using Logic;
using MySql.Data.MySqlClient;
using Presentation.Cache;
using Presentation.Functions;
using System;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class NewNextDate : Form
    {
        public NewNextDate()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #region DLL
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        Usuario usuario;

        private void nextdate_Load(object sender, EventArgs e)
        {
            try
            {
                txttiempo.Text = DateTime.Now.ToShortTimeString();
                usuario = LNUsuario.GetInstance().GetUsuario(lblnombreusuario.Text);
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
        public ProximaCita GetEntities()
        {
            ProximaCita cita = new ProximaCita();
            cita.Idempleado = CacheSoftware.Employee.Id;
            cita.IdUsuario = usuario.Id;
            cita.Proximacita = Convert.ToDateTime(dateTime.Text);
            cita.Idcita = Convert.ToInt64(lblidcita.Text);
            cita.hora = Convert.ToDateTime(txttiempo.Text);
            return cita;
        }
        private void nextdate_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (dateTime.Value < DateTime.Now.Date)
            {
                MessageBox.Show("Reserve la cita de manera correcta por favor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!Validationtime(txttiempo.Text))
                {
                    MessageBox.Show("Hora asignada no valida.", "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        ProximaCita next = GetEntities();
                        bool upload = LNCitaProxima.GetInstance().ProximaCita(next);
                        if (upload == true)
                        {
                            MessageBox.Show("La proxima cita sera el día y hora en el cual tu lo programaste.", "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            foreach (UserEmpleado employee in LNUserEmpleado.GetInstance().GetListEmployees())
                            {
                                Notificacion notificacion = new Notificacion();
                                notificacion.IdEmpleado = employee.Id;
                                notificacion.Titulo = "Proxima cita";
                                notificacion.DetalleNotificacion = "Se ha recervado una proxima cita para el paciente: " + lblnombrepaciente.Text + " el día " + dateTime.Value.ToShortDateString() + " a las:" + txttiempo.Text + ".";
                                LNNotificacion.GetInstance().RegistrarNotificacion(notificacion);
                            }
                            EmailMessages.GetInstance().NextDate(next, usuario.Email, usuario.Username);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Lo sentimos acaba de ocurrir un error inesperado en el sistema, comunica con el desarrollador de inmediato acerca del problema.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        bool Validationtime(string time)
        {
            bool responce;
            try
            {
                DateTime hora = Convert.ToDateTime(time);
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

