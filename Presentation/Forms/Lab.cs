using Logic;
using MySql.Data.MySqlClient;
using Presentation.Cache;
using Presentation.Functions;
using System;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class Laboratorios : Form
    {
        public Laboratorios()
        {
            InitializeComponent();
        }

        private void Lab_Load(object sender, EventArgs e)
        {
            try
            {
                if (LNArea.GetInstance().GetArea(CacheSoftware.Employee.Area) == "Laboratorio clínico" && CacheSoftware.Employee.Roll == 1)
                {
                    dgvlaboratorio.DataSource = LNLaboratorio.GetInstance().ListLaboratorioByEmployee(CacheSoftware.Employee.Id);
                    label1.Visible = true;
                    lbllaboratorio.Visible = false;
                    checklab.Visible = true;
                }
                else if (LNArea.GetInstance().GetArea(CacheSoftware.Employee.Area) == "Laboratorio clínico" && CacheSoftware.Employee.Roll == 2)
                {
                    dgvlaboratorio.DataSource = LNLaboratorio.GetInstance().ListLaboratorioByEmployee(CacheSoftware.Employee.Id);
                    label1.Visible = false;
                }
                else
                {
                    dgvlaboratorio.DataSource = LNLaboratorio.GetInstance().ListLaboratorio();
                    label1.Visible = true;
                    lbllaboratorio.Visible = false;
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
        private void checklab_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checklab.Checked == true)
                {
                    dgvlaboratorio.DataSource = LNLaboratorio.GetInstance().ListLaboratorio();
                    label1.Visible = false;
                    lbllaboratorio.Visible = true;
                }
                else
                {
                    dgvlaboratorio.DataSource = LNLaboratorio.GetInstance().ListLaboratorioByEmployee(CacheSoftware.Employee.Id);
                    label1.Visible = true;
                    lbllaboratorio.Visible = false;
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
        private void btnlab_Click(object sender, EventArgs e)
        {
            if (dgvlaboratorio.SelectedCells.Count > 0)
            {
                ViewLaboratorio mostrar = new ViewLaboratorio();
                mostrar.lblempleado.Text = dgvlaboratorio.CurrentRow.Cells[1].Value.ToString();
                mostrar.lblfecha.Text = Convert.ToDateTime(dgvlaboratorio.CurrentRow.Cells[5].Value.ToString()).ToShortDateString();
                mostrar.lblfolio.Text = dgvlaboratorio.CurrentRow.Cells[3].Value.ToString();
                mostrar.lblpaciente.Text = dgvlaboratorio.CurrentRow.Cells[2].Value.ToString();
                mostrar.txtlistaexamenes.Text = dgvlaboratorio.CurrentRow.Cells[4].Value.ToString();
                mostrar.ShowDialog();

            }
            else
            {
                MessageBox.Show("Seleccion la celda la cual desea ver el laboratorio por favor", "Clinia Médica", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
