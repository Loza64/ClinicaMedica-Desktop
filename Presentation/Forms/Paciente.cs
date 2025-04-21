using Logic;
using MySql.Data.MySqlClient;
using Presentation.Cache;
using Presentation.Functions;
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
        }
        private void Paciente_Load(object sender, EventArgs e)
        {
            try
            {
                GridUsers.DataSource = LNUsuario.GetInstance().ListUsers();
                btnmostrarfactura.Visible = false;
                lblnumero.Text = LimitCount(LNUsuario.GetInstance().Countusers());
                lblnumerohabilitados.Text = LimitCount(LNUsuario.GetInstance().Countenabledusers());
                lblnumeroinhabilitados.Text = LimitCount(LNUsuario.GetInstance().Countdissableusers());
                if (CacheSoftware.Employee.Roll != 1)
                {
                    btnddeletedissabledusers.Visible = false;
                    btnshow.Location = new Point(315, 215);
                    btnreservar.Location = new Point(534, 213);
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
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox.Checked == true)
                {
                    DataTable list = LNUsuario.GetInstance().ListDissableUsers();
                    GridUsers.DataSource = list;
                }
                else
                {
                    GridUsers.DataSource = LNUsuario.GetInstance().ListUsers();
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
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Paciente_Load(sender, e);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkfactura.Checked == true)
                {
                    GridUsers.DataSource = null;
                    GridUsers.DataSource = LNPago.GetInstance().ListarPagos();
                    checkBox.Enabled = false;
                    btnddeletedissabledusers.Enabled = false;
                    btnregister.Enabled = false;
                    btnreservar.Enabled = false;
                    btnimagen.Visible = false;
                    GridUsers.RowHeadersVisible = false;
                    btnmostrarfactura.Visible = true;
                    btnshow.Enabled = false;
                }
                else
                {
                    checkBox.Enabled = true;
                    btnddeletedissabledusers.Enabled = true;
                    btnregister.Enabled = true;
                    btnreservar.Enabled = true;
                    btnimagen.Visible = true;
                    GridUsers.RowHeadersVisible = true;
                    btnmostrarfactura.Visible = false;
                    btnshow.Enabled = true;
                    GridUsers.DataSource = null;
                    GridUsers.DataSource = LNUsuario.GetInstance().ListUsers();
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
        private void GridUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (checkfactura.Checked == true)
            {
                if(GridUsers.SelectedCells.Count >= 0)
                {
                    if (GridUsers.CurrentRow.Cells[0].Value.ToString() == "Ver factura")
                    {
                        ImprimirFactura factura = new ImprimirFactura
                        {
                            NumFactura = Convert.ToInt64(GridUsers.CurrentRow.Cells[2].Value.ToString()),
                            Usuario = GridUsers.CurrentRow.Cells[3].Value.ToString()
                        };
                        factura.ShowDialog();
                    }
                }
                
            }
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            NewPaciente paciente = new NewPaciente();
            paciente.ShowDialog();
        }
        private void btndeleteuserdisable(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estas seguro de que quieres eliminarlos?, ten en cuenta que una vez eliminado se borrara toda la información relacionado a los usuarios", "¿Estas seguro?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                try
                {
                    bool deleteusers = LNUsuario.GetInstance().DeletDissabledUsers();
                    if (deleteusers)
                    {
                        MessageBox.Show("Los usuario fueron eliminados de manera exitosa", "Usuarios eliminados", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Paciente_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Lo sentimos ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (GridUsers.SelectedCells.Count > 0)
            {
                ReservarCita cita = new ReservarCita();
                cita.lblusuario.Text = GridUsers.CurrentRow.Cells[3].Value.ToString();
                cita.lblemail.Text = GridUsers.CurrentRow.Cells[9].Value.ToString();
                cita.lblnombre.Text = GridUsers.CurrentRow.Cells[5].Value.ToString();
                cita.txtnombre.Text = GridUsers.CurrentRow.Cells[5].Value.ToString();
                cita.ShowDialog();
            }
        }
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            ViewPaciente paciente = new ViewPaciente();
            if (GridUsers.SelectedCells.Count > 0)
            {
                paciente.lblidentidad.Text = GridUsers.CurrentRow.Cells[2].Value.ToString();
                paciente.lblusuario.Text = GridUsers.CurrentRow.Cells[3].Value.ToString();
                paciente.lbldui.Text = GridUsers.CurrentRow.Cells[4].Value.ToString();
                paciente.lblnombre.Text = GridUsers.CurrentRow.Cells[5].Value.ToString();
                paciente.lbledad.Text = GridUsers.CurrentRow.Cells[6].Value.ToString();
                paciente.lblnacimiento.Text = Convert.ToDateTime(GridUsers.CurrentRow.Cells[7].Value.ToString()).ToShortDateString();
                paciente.lblgenero.Text = GridUsers.CurrentRow.Cells[8].Value.ToString();
                paciente.lblemail.Text = GridUsers.CurrentRow.Cells[9].Value.ToString();
                paciente.lbldireccion.Text = GridUsers.CurrentRow.Cells[10].Value.ToString();
                paciente.lbltelefono.Text = GridUsers.CurrentRow.Cells[11].Value.ToString();
                paciente.checkestado.Checked = Convert.ToBoolean(GridUsers.CurrentRow.Cells[12].Value.ToString());
                paciente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila, para poder ver la información", "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Error);
                paciente.Close();
            }
        }
        private bool ValiddateNumber(string number)
        {
            bool responce;
            try
            {
                long numero = Convert.ToInt64(number);
                responce = true;
            }
            catch (Exception)
            {
                responce = false;
            }
            return responce;
        }
        private void textnumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkfactura.Checked == true)
                {
                    if (!string.IsNullOrEmpty(textshare.Text))
                    {
                        if (ValiddateNumber(textshare.Text))
                        {
                            long numfactura = Convert.ToInt64(textshare.Text);
                            GridUsers.DataSource = LNPago.GetInstance().BuscarPago(numfactura);
                        }
                        else
                        {
                            MessageBox.Show("Para esta opción no es valido poner letras en el cuadro de busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            textshare.Text = null;
                        }
                    }
                    else
                    {
                        GridUsers.DataSource = LNPago.GetInstance().ListarPagos();
                    }
                }
                else
                {
                    string usuario = textshare.Text;
                    if (usuario != null)
                    {
                        GridUsers.DataSource = LNUsuario.GetInstance().SearchUser(usuario);
                    }
                    else
                    {
                        GridUsers.DataSource = null;
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
        private string LimitCount(long number)
        {
            if (number < 1000000)
            {
                return number.ToString();
            }
            else
            {
                return "+999999";
            }
        }
    }
}
