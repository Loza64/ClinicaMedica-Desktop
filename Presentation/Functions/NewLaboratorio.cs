using Entities;
using Logic;
using MySql.Data.MySqlClient;
using Presentation.Cache;
using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentation.Functions
{
    public partial class NewLaboratorio : Form
    {
        public NewLaboratorio()
        {
            InitializeComponent();
        }
        #region DLL
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
        private void enviarlaboratorio_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public LaboratorioClinico GetEntities()
        {
            LaboratorioClinico lab = new LaboratorioClinico();
            lab.Fecha = Convert.ToString(DateTime.Now.Date);
            lab.IdUsuario = Convert.ToInt64(lblnumero.Text);
            lab.IdUserEmpleado = CacheSoftware.Employee.Id;
            lab.Folio = txtfolio.Text;
            lab.ListaDeExamanes = txtlista.Text;
            return lab;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string folio = txtfolio.Text;
            string lista = txtlista.Text;
            LaboratorioClinico laboratorio = GetEntities();
            if (!string.IsNullOrEmpty(folio) && !string.IsNullOrEmpty(lista))
            {
                if (txtfolio.Text == "Numero Folio")
                {
                    MessageBox.Show("Por favor envie el laboratorio de manera correcta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtlista.Text == "Escriba la lista de examenes")
                {
                    MessageBox.Show("Por favor envie el laboratorio de manera correcta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        bool responce = LNLaboratorio.GetInstance().NewLaboratorio(laboratorio);
                        if (responce)
                        {
                            MessageBox.Show("En hora buena, el laboratorio se almaceno de manera exitosa.", "Mi Laboratorio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Lo sentimos acaba de ocurrir un error inesperado comunicate con el desarrollador acerca de este problema por favor gracias.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Por favor envie el laboratorio de manera correcta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void enviarlaboratorio_Load(object sender, EventArgs e)
        {
            try
            {
                Usuario usuario = LNUsuario.GetInstance().GetUsuario(lblusuario.Text);
                lblnombre.Text = usuario.NombreCompleto;
                lblemail.Text = usuario.Email;
                lblusuario.Text = usuario.Username;
                lblnumero.Text = Convert.ToString(usuario.Id);
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
        private void txtfolio_MouseClick(object sender, MouseEventArgs e)
        {
            txtfolio.Text = null;
            txtfolio.ForeColor = Color.Black;
        }
        private void panel3_MouseMove(object sender, MouseEventArgs e)
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
