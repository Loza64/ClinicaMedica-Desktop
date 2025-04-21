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
    public partial class Citas : Form
    {
        public Citas()
        {
            InitializeComponent();
        }
        private void Citas_Load(object sender, EventArgs e)
        {
            try
            {
                GridCita.DataSource = LNCita.GetInstance().GetDates();
                lblnumerocita.Text = LimitCount(LNCita.GetInstance().CountDates());
                lblnumerocitaterminado.Text = LimitCount(LNCita.GetInstance().CountDatesFinish());
                lblpendiente.Text = LimitCount(LNCita.GetInstance().CountPendingDates());
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

            if (CacheSoftware.Employee.Roll == 3)
            {
                bunifuPanel1.Location = new Point(304, 101);
                label1.Location = new Point(330, 108);
                btnlaboratorio.Visible = false;
                btnexpediente.Visible = false;
                button5.Visible = false;
                checkfinish.Visible = false;
                btnpago.Location = new Point(292, 195);
                checkcita.Location = new Point(0, 251);
                checknextdate.Location = new Point(0, 226);
                datenowcheck.Location = new Point(0, 200);
            }
            if (CacheSoftware.Employee.Roll == 2)
            {
                btnproximacita.Visible = false;
                btnasistencia.Visible = false;
                bunifuPanel1.Location = new Point(304, 101);
                label1.Location = new Point(330, 108);
                btnpago.Visible = false;
                btnlaboratorio.Location = new Point(288, 236);
                btnexpediente.Location = new Point(504, 236);
                checknextdate.Location = new Point(0, 174);
                datenowcheck.Location = new Point(0, 200);
            }
        }
        private string LimitCount(long number)
        {
            if (number < 100000)
            {
                return number.ToString();
            }
            else
            {
                return "+99999";
            }
        }
        private void GridCita_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridCita.SelectedCells.Count > 0)
            {
                if (checknextdate.Checked == true)
                {
                    if (GridCita.SelectedCells[0].Value.ToString() == "Mostrar")
                    {
                        ViewNextDate next = new ViewNextDate();
                        next.lblnumero_p_cita.Text = GridCita.CurrentRow.Cells[1].Value.ToString();
                        next.lblnombreempleado.Text = GridCita.CurrentRow.Cells[2].Value.ToString();
                        next.lblusercliente.Text = GridCita.CurrentRow.Cells[3].Value.ToString();
                        next.lblnombrecliente.Text = GridCita.CurrentRow.Cells[4].Value.ToString();
                        next.lblfecha.Text = Convert.ToDateTime(GridCita.CurrentRow.Cells[5].Value.ToString()).ToShortDateString();
                        next.lblhora.Text = Convert.ToDateTime(GridCita.CurrentRow.Cells[6].Value.ToString()).ToShortTimeString();
                        next.ShowDialog();
                    }
                }
                else
                {
                    if (GridCita.SelectedCells[0].Value.ToString() == "Ver detalles")
                    {
                        ViewDate mostrar = new ViewDate();
                        mostrar.lblnumero.Text = GridCita.CurrentRow.Cells[1].Value.ToString();
                        mostrar.lblusuario.Text = GridCita.CurrentRow.Cells[2].Value.ToString();
                        mostrar.lblpersona.Text = GridCita.CurrentRow.Cells[3].Value.ToString();
                        mostrar.lblparentesco.Text = GridCita.CurrentRow.Cells[4].Value.ToString();
                        mostrar.lblpadecimiento.Text = GridCita.CurrentRow.Cells[5].Value.ToString();
                        mostrar.txtalergias.Text = GridCita.CurrentRow.Cells[6].Value.ToString();
                        mostrar.txtsintomas.Text = GridCita.CurrentRow.Cells[7].Value.ToString();
                        mostrar.lblfecha.Text = Convert.ToDateTime(GridCita.CurrentRow.Cells[8].Value.ToString()).ToShortDateString();
                        mostrar.lblhora.Text = Convert.ToDateTime(GridCita.CurrentRow.Cells[9].Value.ToString()).ToShortTimeString();
                        mostrar.lblestado.Text = GridCita.CurrentRow.Cells[10].Value.ToString();
                        mostrar.ShowDialog();
                    }
                }
            }

        }
        private void checknextdate_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checknextdate.Checked == true)
                {
                    textnumber.Enabled = false;
                    btnpago.Enabled = false;
                    btnasistencia.Enabled = false;
                    datenowcheck.Enabled = false;
                    checkcita.Enabled = false;
                    checkfinish.Enabled = false;
                    btnproximacita.Enabled = false;
                    btnexpediente.Enabled = false;
                    btnlaboratorio.Enabled = false;
                    btnproximacita.Enabled = false;
                    button5.Enabled = false;
                    GridCita.DataSource = LNCitaProxima.GetInstance().GetNextDates();
                    btnshow.Text = "Mostrar";
                }
                else
                {
                    btnasistencia.Enabled = true;
                    textnumber.Enabled = true;
                    btnpago.Enabled = true;
                    datenowcheck.Enabled = true;
                    checkcita.Enabled = true;
                    checkfinish.Enabled = true;
                    btnproximacita.Enabled = true;
                    btnexpediente.Enabled = true;
                    btnlaboratorio.Enabled = true;
                    btnproximacita.Enabled = true;
                    button5.Enabled = true;
                    btnshow.Text = "Ver detalles";
                    GridCita.DataSource = LNCita.GetInstance().GetDates();
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
        private void datenowcheck_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (datenowcheck.Checked == true)
                {
                    checkfinish.Enabled = false;
                    checkcita.Enabled = false;
                    textnumber.Enabled = false;
                    checknextdate.Enabled = false;
                    GridCita.DataSource = LNCita.GetInstance().GetPendingDates();
                }
                else
                {
                    checkfinish.Enabled = true;
                    checkcita.Enabled = true;
                    checknextdate.Enabled = true;
                    textnumber.Enabled = true;
                    DataTable show = LNCita.GetInstance().GetDates();
                    GridCita.DataSource = show;
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
        private void checkcita_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (checkcita.Checked == true)
                {
                    checkfinish.Enabled = false;
                    datenowcheck.Enabled = false;
                    checknextdate.Enabled = false;
                }
                else
                {

                    checkfinish.Enabled = true;
                    datenowcheck.Enabled = true;
                    checknextdate.Enabled = true;
                    GridCita.DataSource = LNCita.GetInstance().GetDates();
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
        private void checkfinish_CheckedChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (checkfinish.Checked == true)
                {
                    checkcita.Enabled = false;
                    datenowcheck.Enabled = false;
                    checknextdate.Enabled = false;
                    btnshow.Visible = false;
                    GridCita.DataSource = LNCita.GetInstance().Listdatesfinish();
                }
                else
                {
                    checkcita.Enabled = true;
                    datenowcheck.Enabled = true;
                    btnshow.Visible = true;
                    checknextdate.Enabled = true;
                    GridCita.DataSource = LNCita.GetInstance().GetDates();
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
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (GridCita.SelectedCells.Count > 0)
            {
                NewPago pago = new NewPago();
                pago.lblusuario.Text = GridCita.CurrentRow.Cells[2].Value.ToString();
                pago.lblnumcita.Text = GridCita.CurrentRow.Cells[1].Value.ToString();
                pago.ShowDialog();
            }
            else
            {
                MessageBox.Show("seleccione una celda por favor.", "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (LNArea.GetInstance().GetArea(CacheSoftware.Employee.Area) == "Laboratorio clínico")
                {
                    NewLaboratorio share = new NewLaboratorio();
                    if (GridCita.SelectedCells.Count > 0)
                    {
                        share.lblusuario.Text = GridCita.CurrentRow.Cells[2].Value.ToString();
                        share.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Por favor seleccione una fila o celda para poder enviar el laboratorio clínico");
                    }
                }
                else
                {
                    MessageBox.Show("Lo sentimos tu no perteneces al área de laboratorios clíncos por lo que no tienes permitído realizar esta función", "Funcion denegada", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            NewAsistencia asistencia = new NewAsistencia();
            if (GridCita.SelectedCells.Count > 0)
            {
                asistencia.txtnumcita.Text = GridCita.CurrentRow.Cells[1].Value.ToString();
                asistencia.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila o celda para poder generar la sistencia.", "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void bunifuButton1_Click_2(object sender, EventArgs e)
        {
            NewNextDate date = new NewNextDate();
            if (GridCita.SelectedCells.Count > 0)
            {
                date.lblnombrepaciente.Text = GridCita.CurrentRow.Cells[3].Value.ToString();
                date.lblidcita.Text = GridCita.CurrentRow.Cells[1].Value.ToString();
                date.lblnombreusuario.Text = GridCita.CurrentRow.Cells[2].Value.ToString();
                date.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila o celda para poder programar la proxima cita.", "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            NewExpediente newexpediente = new NewExpediente();
            if (GridCita.SelectedCells.Count > 0)
            {
                newexpediente.idCita = Convert.ToInt64(GridCita.CurrentRow.Cells[1].Value.ToString());
                newexpediente.lblusuario.Text = GridCita.CurrentRow.Cells[2].Value.ToString();
                newexpediente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila o celda para poder generar un expediente.", "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void bunifuButton1_Click_3(object sender, EventArgs e)
        {
            if (GridCita.SelectedCells.Count > 0)
            {
                NewReceta receta = new NewReceta();
                receta.lblnumero.Text = GridCita.CurrentRow.Cells[1].Value.ToString();
                receta.lblusuario.Text = GridCita.CurrentRow.Cells[2].Value.ToString();
                receta.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila o celda para poder enviar la receta médica al paciente.", "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void textnumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (checkcita.Checked == true)
                {
                    if (!string.IsNullOrEmpty(textnumber.Text))
                    {
                        try
                        {
                            long Id = ValidateInputIntegerTextbox(textnumber.Text);
                            DataTable date = LNCita.GetInstance().SearchDate(Id);
                            if (date.Rows.Count != 0)
                            {
                                GridCita.DataSource = date;
                            }
                            else
                            {
                                MessageBox.Show("Numero de cita no registrado en la bases de datos", "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
                        GridCita.DataSource = LNCita.GetInstance().GetDates();
                    }
                }
                else
                {
                    MessageBox.Show("Active la funcion buscar por numeo de cita", "Clínica Médica", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        long ValidateInputIntegerTextbox(string input)
        {
            long number = 0;
            try
            {
                number = Convert.ToInt64(input);
            }
            catch (Exception)
            {
                textnumber.Text = null;
            }
            return number;
        }
    }
}
