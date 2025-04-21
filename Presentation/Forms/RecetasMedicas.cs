using Logic;
using MySql.Data.MySqlClient;
using Presentation.Cache;
using Presentation.Functions;
using System;
using System.Windows.Forms;

namespace Presentation.Forms
{
    public partial class RecetasMedicas : Form
    {
        public RecetasMedicas()
        {
            InitializeComponent();
        }

        private void RecetasMedicas_Load(object sender, EventArgs e)
        {
            try
            {
                switch (CacheSoftware.Employee.Roll)
                {
                    case 1:
                        checkallreceta.Visible = true;
                        label1.Visible = true;
                        label2.Visible = false;
                        dgvrecetas.DataSource = LNRecetaMedica.GetInstance().ListRecetaByEmployee(CacheSoftware.Employee.Id);
                        break;
                    case 2:
                        label1.Text = "Mis recetas médicas almacenadas";
                        checkallreceta.Visible = false;
                        label1.Visible = true;
                        label2.Visible = false;
                        dgvrecetas.DataSource = LNRecetaMedica.GetInstance().ListRecetaByEmployee(CacheSoftware.Employee.Id);
                        label1.Location = new System.Drawing.Point(280, 118);
                        break;
                    default:
                        label1.Text = "Recetas médicas de los pacientes.";
                        checkallreceta.Visible = false;
                        label2.Visible = false;
                        dgvrecetas.DataSource = LNRecetaMedica.GetInstance().ListRecetas();
                        label1.Location = new System.Drawing.Point(280, 118);
                        break;
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
        private void dgvrecetas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewReceta mostrar_Receta = new ViewReceta();
            if (dgvrecetas.SelectedCells.Count > 0)
            {
                mostrar_Receta.lblcantidad.Text = dgvrecetas.CurrentRow.Cells[6].Value.ToString();
                mostrar_Receta.lblempleado.Text = dgvrecetas.CurrentRow.Cells[1].Value.ToString();
                mostrar_Receta.lblfecha.Text = Convert.ToDateTime(dgvrecetas.CurrentRow.Cells[9].Value.ToString()).ToShortDateString();
                mostrar_Receta.lblnombremedicamento.Text = dgvrecetas.CurrentRow.Cells[5].Value.ToString();
                mostrar_Receta.lblnombremedicina.Text = dgvrecetas.CurrentRow.Cells[4].Value.ToString();
                mostrar_Receta.lblpaciente.Text = dgvrecetas.CurrentRow.Cells[2].Value.ToString();
                mostrar_Receta.lblconsumo.Text = dgvrecetas.CurrentRow.Cells[8].Value.ToString();
                mostrar_Receta.txtdetalle.Text = dgvrecetas.CurrentRow.Cells[7].Value.ToString();
                mostrar_Receta.ShowDialog();
            }
        }
        private void checkallreceta_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkallreceta.Checked == true)
                {
                    label1.Visible = false;
                    label2.Visible = true;
                    dgvrecetas.DataSource = LNRecetaMedica.GetInstance().ListRecetas();
                }
                else
                {
                    label1.Visible = true;
                    label2.Visible = false;
                    dgvrecetas.DataSource = LNRecetaMedica.GetInstance().ListRecetaByEmployee(CacheSoftware.Employee.Id);
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
        private void btnreceta_Click(object sender, EventArgs e)
        {
            ViewReceta mostrar_Receta = new ViewReceta();
            if (dgvrecetas.SelectedCells.Count > 0)
            {
                mostrar_Receta.lblcantidad.Text = dgvrecetas.CurrentRow.Cells[6].Value.ToString();
                mostrar_Receta.lblempleado.Text = dgvrecetas.CurrentRow.Cells[1].Value.ToString();
                mostrar_Receta.lblfecha.Text = Convert.ToDateTime(dgvrecetas.CurrentRow.Cells[9].Value.ToString()).ToShortDateString();
                mostrar_Receta.lblnombremedicamento.Text = dgvrecetas.CurrentRow.Cells[5].Value.ToString();
                mostrar_Receta.lblnombremedicina.Text = dgvrecetas.CurrentRow.Cells[4].Value.ToString();
                mostrar_Receta.lblpaciente.Text = dgvrecetas.CurrentRow.Cells[2].Value.ToString();
                mostrar_Receta.lblconsumo.Text = dgvrecetas.CurrentRow.Cells[8].Value.ToString();
                mostrar_Receta.txtdetalle.Text = dgvrecetas.CurrentRow.Cells[7].Value.ToString();
                mostrar_Receta.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor seleccione una celda para ver el contenido.", "Clínca Médica", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
