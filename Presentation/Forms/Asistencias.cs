using Logic;
using MySql.Data.MySqlClient;
using Presentation.Functions;
using System;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class Asistencias : Form
    {
        public Asistencias()
        {
            InitializeComponent();
        }

        private void Asistencias_Load(object sender, EventArgs e)
        {
            try
            {
                Asistencia.DataSource = LNAsistencia.GetInstance().GetAsistencias();
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

        private void Asistencia_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Asistencia.SelectedCells.Count > 0)
            {
                ViewAsistencia asistencias = new ViewAsistencia();
                asistencias.Show();
                asistencias.lblnumero.Text = Asistencia.CurrentRow.Cells[1].Value.ToString();
                asistencias.lblnombre.Text = Asistencia.CurrentRow.Cells[2].Value.ToString();
                asistencias.txtdetalle.Text = Asistencia.CurrentRow.Cells[3].Value.ToString();
                asistencias.lblfecha.Text = Convert.ToDateTime(Asistencia.CurrentRow.Cells[4].Value.ToString()).ToShortDateString();
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila o celda para ver la informacion ", "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnasistencia_Click(object sender, EventArgs e)
        {
            if (Asistencia.SelectedCells.Count > 0)
            {
                ViewAsistencia asistencias = new ViewAsistencia();
                asistencias.Show();
                asistencias.lblnumero.Text = Asistencia.CurrentRow.Cells[1].Value.ToString();
                asistencias.lblnombre.Text = Asistencia.CurrentRow.Cells[2].Value.ToString();
                asistencias.txtdetalle.Text = Asistencia.CurrentRow.Cells[3].Value.ToString();
                asistencias.lblfecha.Text = Convert.ToDateTime(Asistencia.CurrentRow.Cells[4].Value.ToString()).ToShortDateString();
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila o celda para ver la informacion ", "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Asistencia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Asistencia.SelectedCells.Count > 0)
            {
                ViewAsistencia asistencias = new ViewAsistencia();
                asistencias.Show();
                asistencias.lblnumero.Text = Asistencia.CurrentRow.Cells[1].Value.ToString();
                asistencias.lblnombre.Text = Asistencia.CurrentRow.Cells[2].Value.ToString();
                asistencias.txtdetalle.Text = Asistencia.CurrentRow.Cells[3].Value.ToString();
                asistencias.lblfecha.Text = Convert.ToDateTime(Asistencia.CurrentRow.Cells[4].Value.ToString()).ToShortDateString();
            }
            else
            {
                MessageBox.Show("Por favor seleccione una fila o celda para ver la informacion ", "Ocurrio un error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
