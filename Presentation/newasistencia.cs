using Entities;
using Logic;
using MySql.Data.MySqlClient;
using Presentation.Cache;
using System;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentation
{
    public partial class NewAsistencia : Form
    {
        public NewAsistencia()
        {
            InitializeComponent();
        }

        public Asistencia GetEntities()
        {
            Asistencia asistencia = new Asistencia();
            asistencia.IdEmpleado = CacheSoftware.Employee.Id;
            asistencia.IdCita = Convert.ToInt64(txtnumcita.Text);
            asistencia.MotivoCita = txtmotivo.Text;
            asistencia.FechaAsistencia = DateTime.Now.Date;
            return asistencia;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Asistencia asistencia = GetEntities();
            if (string.IsNullOrEmpty(txtmotivo.Text))
            {
                MessageBox.Show("Por favor escriba una sistencia de manera correcta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Hide();
            }
            else
            {
                try
                {
                    bool upload = LNAsistencia.GetInstance().NewAsistencia(asistencia);
                    if (upload == true)
                    {
                        MessageBox.Show("La asistencia se alamaceno de manera correcta.", "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Lo sentimos ocurrio un error inesperado por favor vuelve a intentarlo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void newasistencia_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
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
