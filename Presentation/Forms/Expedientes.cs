using Logic;
using MySql.Data.MySqlClient;
using System;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class Expedientes : Form
    {
        public Expedientes()
        {
            InitializeComponent();

        }

        private void Expedientes_Load(object sender, EventArgs e)
        {
            try
            {
                Expediente.DataSource = LNExpediente.GetInstance().ListExpediente();
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

        private void button2_Click(object sender, EventArgs e)
        {
            NewExpediente newexpediente = new NewExpediente();
            newexpediente.ShowDialog();
        }

        private void btnexpediente_Click(object sender, EventArgs e)
        {
            ViewExpediente _Expediente = new ViewExpediente();
            if (Expediente.SelectedCells.Count > 0)
            {
                _Expediente.lblnumeroantecedente.Text = Expediente.CurrentRow.Cells[0].Value.ToString();
                _Expediente.lblnumero.Text = Expediente.CurrentRow.Cells[1].Value.ToString();
                _Expediente.lblempleado.Text = Expediente.CurrentRow.Cells[2].Value.ToString();
                _Expediente.txtdiagnostico.Text = Expediente.CurrentRow.Cells[3].Value.ToString();
                _Expediente.txttratamiento.Text = Expediente.CurrentRow.Cells[4].Value.ToString();
                _Expediente.txtantecedentes.Text = Expediente.CurrentRow.Cells[5].Value.ToString();
                _Expediente.lblfecha.Text = Convert.ToDateTime(Expediente.CurrentRow.Cells[6].Value.ToString()).ToShortDateString();
                _Expediente.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor seleccion una fila o cleda para poder ver la informacion");
            }
        }

        private void Expediente_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewExpediente _Expediente = new ViewExpediente();
            if (Expediente.SelectedCells.Count > 0)
            {
                _Expediente.lblnumeroantecedente.Text = Expediente.CurrentRow.Cells[0].Value.ToString();
                _Expediente.lblnumero.Text = Expediente.CurrentRow.Cells[1].Value.ToString();
                _Expediente.lblempleado.Text = Expediente.CurrentRow.Cells[2].Value.ToString();
                _Expediente.txtdiagnostico.Text = Expediente.CurrentRow.Cells[3].Value.ToString();
                _Expediente.txttratamiento.Text = Expediente.CurrentRow.Cells[4].Value.ToString();
                _Expediente.txtantecedentes.Text = Expediente.CurrentRow.Cells[5].Value.ToString();
                _Expediente.lblfecha.Text = Convert.ToDateTime(Expediente.CurrentRow.Cells[6].Value.ToString()).ToShortDateString();
                _Expediente.ShowDialog();
            }
        }
    }
}
