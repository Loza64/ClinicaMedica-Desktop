using Entities;
using Logic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Presentation.Functions
{
    public partial class NewPago : Form
    {
        #region DLL
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion
        private double subtotal;
        private double totalpagar;
        public static long IdUsuario;
        public static long NumFactura;
        Usuario usuario;

        public NewPago()
        {
            InitializeComponent();
        }
        private void GenerarPago_Load(object sender, EventArgs e)
        {
            try
            {
                AppTime.Start();
                usuario = LNUsuario.GetInstance().GetUsuario(lblusuario.Text);
                NumFactura = LNPago.GetInstance().NumeroFactura();
                dgbpago.DefaultCellStyle.ForeColor = Color.White;
                lblnumfactura.Text = NumFactura.ToString();
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
        private void AppTime_Tick(object sender, EventArgs e)
        {
            lblnombre.Text = usuario.NombreCompleto;
            lblemail.Text = usuario.Email;
            IdUsuario = usuario.Id;
            lblusuario.Text = usuario.Username;
            lblsubtotal.Text = "$" + subtotal.ToString();
            lblpago.Text = "$" + totalpagar.ToString();
        }

        //Obtener la informacion tanto de pago como de detalle pago para btnenviar_click
        public Pago GetEntities()
        {
            Pago pago = new Pago
            {
                Id = Convert.ToInt64(lblnumfactura.Text),
                IdCita = Convert.ToInt64(lblnumcita.Text),
                IdUsuario = IdUsuario,
                SubTotal = subtotal,
                PagoTotal = totalpagar
            };
            return pago;
        }
        public List<DetallePago> ListarDetalles()
        {
            List<DetallePago> lista = new List<DetallePago>();
            int Item = 1;
            foreach (DataGridViewRow row in dgbpago.Rows)
            {
                DetallePago detallePago = new DetallePago()
                {
                    IdPago = NumFactura,
                    Nº = Item,
                    Detalle = row.Cells[0].Value.ToString(),
                    Precio = Convert.ToDouble(row.Cells[1].Value.ToString()),
                    Cantidad = Convert.ToInt32(row.Cells[2].Value.ToString()),
                    SubTotal = Convert.ToDouble(row.Cells[3].Value.ToString()),
                    PagoTotal = Convert.ToDouble(row.Cells[4].Value.ToString())
                };
                lista.Add(detallePago);
                Item++;
            }
            return lista;
        }

        //Guardar los detalles
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcantidad.Text) || !string.IsNullOrEmpty(txtdetalle.Text) || !string.IsNullOrEmpty(txtprecio.Text))
            {
                if (validarcantidad(txtcantidad.Text) && validarprecio(txtprecio.Text))
                {
                    bool chekproduct = false;
                    subtotal = 0.0;
                    totalpagar = 0.0;
                    if (dgbpago.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow DGBRow in dgbpago.Rows)
                        {
                            if (DGBRow.Cells[0].Value.ToString() == txtdetalle.Text)
                            {
                                chekproduct = true;
                                DGBRow.Cells[2].Value = Convert.ToInt32(DGBRow.Cells[2].Value.ToString()) + 1; //Cantidad
                                DGBRow.Cells[3].Value = Math.Round(Convert.ToDouble(DGBRow.Cells[1].Value.ToString()) * Convert.ToInt32(DGBRow.Cells[2].Value.ToString()), 2); //SubTotal
                                DGBRow.Cells[4].Value = Math.Round((Convert.ToDouble(DGBRow.Cells[3].Value.ToString()) * 0.02) + Convert.ToDouble(DGBRow.Cells[3].Value.ToString()), 2); //TotalPagar
                                txtcantidad.Clear();
                                txtdetalle.Clear();
                                txtprecio.Clear();
                                break;
                            }
                        }
                        if (!chekproduct)
                        {
                            DetallePago detallepago = new DetallePago();
                            detallepago.Detalle = txtdetalle.Text;
                            detallepago.Precio = Convert.ToDouble(txtprecio.Text);
                            detallepago.Cantidad = Convert.ToInt32(txtcantidad.Text);
                            detallepago.SubTotal = Math.Round(Convert.ToDouble(txtprecio.Text) * Convert.ToInt32(txtcantidad.Text), 2);
                            detallepago.PagoTotal = Math.Round((detallepago.SubTotal * 0.06) + detallepago.SubTotal, 2);
                            dgbpago.Rows.Add(detallepago.Detalle, detallepago.Precio, detallepago.Cantidad, detallepago.SubTotal, detallepago.PagoTotal);
                            txtcantidad.Clear();
                            txtdetalle.Clear();
                            txtprecio.Clear();
                        }
                    }
                    else
                    {
                        DetallePago detallepago = new DetallePago();
                        detallepago.Detalle = txtdetalle.Text;
                        detallepago.Precio = Convert.ToDouble(txtprecio.Text);
                        detallepago.Cantidad = Convert.ToInt32(txtcantidad.Text);
                        detallepago.SubTotal = Math.Round(Convert.ToDouble(txtprecio.Text) * Convert.ToInt32(txtcantidad.Text), 2);
                        detallepago.PagoTotal = Math.Round((detallepago.SubTotal * 0.02) + detallepago.SubTotal, 2);
                        dgbpago.Rows.Add(detallepago.Detalle, detallepago.Precio, detallepago.Cantidad, detallepago.SubTotal, detallepago.PagoTotal);
                        txtcantidad.Clear();
                        txtdetalle.Clear();
                        txtprecio.Clear();
                    }
                    foreach (DataGridViewRow DGBRow in dgbpago.Rows)
                    {
                        subtotal += Convert.ToDouble(DGBRow.Cells[3].Value.ToString());
                        totalpagar += Convert.ToDouble(DGBRow.Cells[4].Value.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Dijite los datos correctamente por favor.", "Datos no valido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Por favor llene todos los campos", "Datos no valido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Guardar todo el pago en la base de datos, tanto pago como detalle pabo
        private void btnenviar_Click(object sender, EventArgs e)
        {
            if (dgbpago.Rows.Count > 0)
            {
                try
                {
                    Pago pago = GetEntities();
                    List<DetallePago> detallepago = ListarDetalles();
                    bool responce = LNPago.GetInstance().GenerarPago(pago, detallepago);
                    if (responce)
                    {
                        EmailMessages.GetInstance().Pago(lblemail.Text, lblnombre.Text, lblnumfactura.Text);
                        DialogResult dialogResult = MessageBox.Show("El comprobante de pago se ha enviado al paciente de manera exitosa,¿Desea imprimir el comprobante de pago?", "En hora buena", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (dialogResult == DialogResult.OK)
                        {
                            ImprimirFactura factura = new ImprimirFactura();
                            factura.NumFactura = pago.Id;
                            factura.Usuario = lblusuario.Text;
                            factura.ShowDialog();
                        }
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
            else
            {
                MessageBox.Show("No podemos enviar la factura al paciente, ingrese almenos un dato por favor", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Funciones de interfas
        private void button2_Click(object sender, EventArgs e)
        {
            AppTime.Stop();
            Close();
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        bool validarcantidad(string number)
        {
            bool responce;
            try
            {
                int numero = Convert.ToInt32(number);
                responce = true;
            }
            catch (Exception)
            {
                responce = false;
            }
            return responce;
        }
        public bool validarprecio(string number)
        {
            bool responce;
            try
            {
                float numero = (float)Convert.ToDecimal(number);
                responce = true;
            }
            catch (Exception)
            {
                responce = false;
            }
            return responce;
        }

        //Borrar item
        private void dgbpago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgbpago.SelectedCells.Count > 0)
            {
                if (dgbpago.SelectedCells[5].Value.ToString() == "Borrar")
                {
                    subtotal = 0.0;
                    totalpagar = 0.0;
                    foreach (DataGridViewRow row in dgbpago.Rows)
                    {
                        if (row.Cells[0].Value.ToString() == dgbpago.CurrentRow.Cells[0].Value.ToString())
                        {
                            dgbpago.Rows.Remove(row);
                        }
                    }
                }
                foreach (DataGridViewRow DGBRow in dgbpago.Rows)
                {
                    subtotal += Convert.ToDouble(DGBRow.Cells[3].Value.ToString());
                    totalpagar += Convert.ToDouble(DGBRow.Cells[4].Value.ToString());
                }
            }
        }


    }
}
