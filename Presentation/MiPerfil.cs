using Entities;
using Logic;
using MySql.Data.MySqlClient;
using Presentation.Cache;
using System;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Presentation
{
    public partial class MiPerfil : Form
    {
        public MiPerfil()
        {
            InitializeComponent();
        }

        private void Mi_Perfil_Load(object sender, EventArgs e)
        {
            lbldireccion.Text = CacheSoftware.Employee.Direccion;
            lbldui.Text = CacheSoftware.Employee.Dui;
            lbledad.Text = CacheSoftware.Employee.Edad.ToString();
            lblemail.Text = CacheSoftware.Employee.Email;
            lblgenero.Text = CacheSoftware.Employee.Genero;
            lblnacimiento.Text = CacheSoftware.Employee.Nacimiento.ToShortDateString();
            lblnombre.Text = CacheSoftware.Employee.NombreCompleto;
            lbltelefono.Text = CacheSoftware.Employee.Telefono;
            lbltrabajo.Text = LNArea.GetInstance().GetArea(CacheSoftware.Employee.Area);
            lblusuario.Text = CacheSoftware.Employee.UserName;
            panelprofile.Image = Image.FromStream(new MemoryStream(CacheSoftware.Employee.Imagen));

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            ActualizarPerfil perfil = new ActualizarPerfil();
            perfil.ShowDialog();
        }

        private void BtnCambiarFoto_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog file = new OpenFileDialog
                {
                    Filter = "Choose Image(*.jpg;*png;*gif) | *.jpg;*png;*gif",
                    InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
                    Title = "Seleccionar foto de perfil"
                };
                if (file.ShowDialog() == DialogResult.OK)
                {
                    if (ValidateFoto(file))
                    {
                        string imageLocation = file.FileName.ToString();
                        panelprofile.Image = Image.FromFile(imageLocation);

                        FileStream fileStream = new FileStream(imageLocation, FileMode.Open, FileAccess.Read);
                        BinaryReader binaryReader = new BinaryReader(fileStream);
                        byte[] byteimg = binaryReader.ReadBytes((int)fileStream.Length);

                        bool responce = LNUserEmpleado.GetInstance().UpdateImage(CacheSoftware.Employee.Id, byteimg);
                        if (responce)
                        {
                            //Notificacion
                            Notificacion notificacion = new Notificacion();
                            notificacion.IdEmpleado = CacheSoftware.Employee.Id;
                            notificacion.Titulo = "Foto de perfil";
                            notificacion.DetalleNotificacion = "Tu foto de perfil se ha actualizado exitosamente.";
                            LNNotificacion.GetInstance().RegistrarNotificacion(notificacion);
                            CacheSoftware.Employee.Imagen = byteimg;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una foto por favor.", "Imagen no valida", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (TimeoutException ex)
            {
                DialogResult dr = MessageBox.Show("Información del error: " + ex.Message.ToString() + " ¿desea cerrar la aplicacion?", "Lo sentimos, ocurrio un error inesperado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("Si el error aun persiste por favor comuniquese con UFOSTART DEVELOPMENT lo mas breve posible");
                    Application.Exit();
                }
            }
            catch (NullReferenceException ex)
            {
                DialogResult dr = MessageBox.Show("Información del error: " + ex.Message.ToString() + " ¿desea cerrar la aplicacion?", "Lo sentimos, ocurrio un error inesperado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("Si el error aun persiste por favor comuniquese con UFOSTART DEVELOPMENT lo mas breve posible");
                    Application.Exit();
                }
            }
            catch (MySqlException ex)
            {
                DialogResult dr = MessageBox.Show("Información del error: " + ex.Message.ToString() + " ¿desea cerrar la aplicacion?", "Lo sentimos, ocurrio un error inesperado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
                DialogResult dr = MessageBox.Show("Información del error: " + ex.Message.ToString() + " ¿desea cerrar la aplicacion?", "Lo sentimos, ocurrio un error inesperado", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (dr == DialogResult.OK)
                {
                    MessageBox.Show("Si el error aun persiste por favor comuniquese con UFOSTART DEVELOPMENT lo mas breve posible");
                    Application.Exit();
                }
            }
        }

        private bool ValidateFoto(OpenFileDialog file)
        {
            bool responce;
            try
            {
                Bitmap bitmap = new Bitmap(file.FileName);
                responce = true;
            }
            catch (Exception)
            {
                responce = false;
            }
            return responce;
        }
    }
}
