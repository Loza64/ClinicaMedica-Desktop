using Logic;
using MySql.Data.MySqlClient;
using Presentation.Cache;
using Presentation.Functions;
using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentation
{
    public partial class ViewPaciente : Form
    {
        public ViewPaciente()
        {
            InitializeComponent();
        }
        private void dissabled_btn(object sender, EventArgs e)
        {
            try
            {
                bool responce = LNUsuario.GetInstance().ModifyStateUser(lblusuario.Text, false);
                if (responce == true)
                {
                    EmailMessages.GetInstance().MessageDisableUser(lblemail.Text, lblusuario.Text);
                    MessageBox.Show("El usuario se ha inhabilitado de manera correcta.", "Usuario inhabilitado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Usuario no existente en la bases de datos.");
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool responce = LNUsuario.GetInstance().ModifyStateUser(lblusuario.Text, true);
                if (responce == true)
                {
                    MessageBox.Show("El usuario se ha habilitado de manera correcta.", "Usuario habilitado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Usuario no existente en la bases de datos.", "Usuariono existente", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

        #region DLL
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
        private void Mostrar_Paciente_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (CacheSoftware.Employee.Roll != 1)
            {
                MessageBox.Show("Solo el administrador tiene permitido eliminar pacientes", "Administración", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                try
                {
                    long Id = Convert.ToInt64(lblidentidad.Text);
                    DialogResult result = MessageBox.Show("¿Estas seguro de que quieres eliminarlo?, ten en cuenta que una vez eliminado se borrara toda la información relacionado a este usuario", "¿Estas seguro?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                    {
                        bool delete = LNUsuario.GetInstance().DeleteUser(Id);
                        if (delete)
                        {
                            MessageBox.Show("El paciente se ha eliminado de manera exitosa", "Paciente eliminado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Lo sentimos o ocurrio un erro inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        }
                    }
                    else
                    {
                        this.Hide();
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
        private void Mostrar_Paciente_Load(object sender, EventArgs e)
        {
            if (CacheSoftware.Employee.Roll == 1)
            {
                if (checkestado.Checked == true)
                {
                    lblestado.Text = "Habilitado";
                    button1.Visible = false;
                    btninhabilitar.Location = new Point(416, 577);
                    btninhabilitar.Visible = true;
                }
                else
                {
                    lblestado.Text = "Deshabilitado";
                    button1.Visible = true;
                    btninhabilitar.Location = new Point(194, 577);
                }
            }
            else
            {
                if (checkestado.Checked == true)
                {
                    lblestado.Text = "Habilitado";
                    button1.Visible = false;
                    btninhabilitar.Location = new Point(416, 577);
                    btninhabilitar.Visible = true;
                }
                else
                {
                    lblestado.Text = "Deshabilitado";
                    button1.Visible = true;
                    btninhabilitar.Location = new Point(194, 577);
                }
                button1.Visible = false;
                btneliminar.Visible = false;
                btninhabilitar.Visible = false;
                this.Size = new Size(770, 560);
            }
        }
        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
