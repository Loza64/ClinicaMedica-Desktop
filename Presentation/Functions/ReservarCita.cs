using Entities;
using Logic;
using MySql.Data.MySqlClient;
using System;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentation.Functions
{
    public partial class ReservarCita : Form
    {
        public ReservarCita()
        {
            InitializeComponent();
        }

        #region DLL
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        long idusuario;

        private void ReservarCita_Load(object sender, EventArgs e)
        {
            txthora.Text = DateTime.Now.ToShortTimeString();
            try
            {
                Usuario user = LNUsuario.GetInstance().GetUsuario(lblusuario.Text);
                lblnombre.Text = user.NombreCompleto;
                lblemail.Text = user.Email;
                idusuario = user.Id;
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

        public Cita GetEntities()
        {
            Cita cita = new Cita
            {
                alergias = string.IsNullOrEmpty(txtalergias.Text) ? "Ninguno" : txtalergias.Text,
                nombrepaciente = txtnombre.Text,
                parentesco = cmbparentesco.SelectedItem.ToString(),
                padecimento = string.IsNullOrEmpty(txtpadecimientos.Text) ? "Ningunno" : txtpadecimientos.Text,
                fecha_reservación = datetime.Value,
                enfermedad_sintomas = txtsitomas.Text,
                hora = Convert.ToDateTime(txthora.Text),
                id_usuario = idusuario
            };
            return cita;
        }


        private void btnreservar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtalergias.Text) || string.IsNullOrEmpty(txtpadecimientos.Text) || string.IsNullOrEmpty(txtsitomas.Text))
            {
                MessageBox.Show("Reserve la cita de manera correcta por favor", "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (datetime.Value < DateTime.Now.Date)
                {
                    MessageBox.Show("Fecha de reserviación no valida", "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        Cita date = GetEntities();
                        bool responce = LNCita.GetInstance().RerservarCita(date);
                        if (responce)
                        {
                            foreach (UserEmpleado employee in LNUserEmpleado.GetInstance().GetListEmployees())
                            {
                                Notificacion notificacion = new Notificacion();
                                notificacion.IdEmpleado = employee.Id;
                                notificacion.Titulo = "Reservacion de cita";
                                notificacion.DetalleNotificacion = "Se reservo cita para el usuario: " + lblusuario.Text + " a nombre de: " + date.nombrepaciente + ", parentesco: " + date.parentesco + ", para el día " + date.fecha_reservación.ToShortDateString() + " a las " + date.hora.ToShortTimeString() + " atravez de esta plataforma.";
                                LNNotificacion.GetInstance().RegistrarNotificacion(notificacion);
                            }
                            DialogResult result = MessageBox.Show("La cita se reservo de manera exitosa.", "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            if (result == DialogResult.OK)
                            {
                                this.Close();
                            }
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

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ReservarCita_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
