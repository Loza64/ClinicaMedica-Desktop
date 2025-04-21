using Logic;
using MySql.Data.MySqlClient;
using Presentation.Functions;
using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Presentation
{
    public partial class TargetEmployee : UserControl
    {
        public TargetEmployee()
        {
            InitializeComponent();
        }
        private long Id;
        private string Usuario;
        private string area;
        private string roll;
        private bool estado;
        private byte[] image;

        [Category("Custom props")]
        public long GetId
        {
            get { return Id; }
            set { Id = value; }
        }

        [Category("Custom props")]
        public string GetUsuario
        {
            get { return Usuario; }
            set { Usuario = value; }
        }

        [Category("Custom props")]
        public string GetArea
        {
            get { return area; }
            set { area = value; }
        }

        [Category("Custom props")]
        public string GetRoll
        {
            get { return roll; }
            set { roll = value; }
        }

        [Category("Custom props")]
        public bool GetEstado
        {
            get { return estado; }
            set { estado = value; }
        }

        [Category("Custom props")]
        public byte[] GetImage
        {
            get { return image; }
            set { image = value; }
        }

        private void TargetEmployee_Load(object sender, EventArgs e)
        {
            //Mostrar datos
            lblusuario.Text = GetUsuario;
            lblarea.Text = GetArea;
            lblroll.Text = GetRoll;
            imgusuario.Image = Image.FromStream(new MemoryStream(GetImage));

            //Mostrar Estado del empleado
            if (GetEstado)
            {
                lblestado.Text = "Habilitado";
            }
            else
            {
                lblestado.Text = "Inhabilitado";
            }
        }

        private void BtnViewProfile_Click_1(object sender, EventArgs e)
        {
            try
            {
                ViewEmployee view = new ViewEmployee();
                view.employee = LNUserEmpleado.GetInstance().GetEmployee(GetId);
                view.ShowDialog();
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
    }
}

