using Domain;
using MySql.Data.MySqlClient;
using System;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace Presentation.Functions
{
    public partial class ImprimirFactura : Form
    {
        public ImprimirFactura()
        {
            InitializeComponent();
        }
        public long NumFactura;
        public string Usuario;
        private void ImprimirFactura_Load(object sender, EventArgs e)
        {
            GetFactura(NumFactura, Usuario);
            this.reportViewer1.RefreshReport();
        }
        public void GetFactura(long Factura, string Usuario)
        {
            try
            {
                Factura factura = new Factura();
                factura.ListarFactura(Factura, Usuario);
                facturaBindingSource.DataSource = factura;
                listadoFacturaBindingSource.DataSource = factura.FacturaLista;
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
            Close();
        }
    }
}
