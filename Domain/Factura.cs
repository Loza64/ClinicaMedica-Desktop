using Entities;
using Logic;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using MySql.Data.MySqlClient;

namespace Domain
{
    public class Factura
    {
        public long IdPago { get; private set; }
        public string Usuario { get; private set; }
        public string Email { get; private set; }
        public string NombreUsuario { get; private set; }
        public double SubTotal { get; private set; }
        public double TotalPagar { get; private set; }
        public string FechaFacturacion { get; private set; }
        public List<ListadoFactura> FacturaLista { get; private set; }
        public void ListarFactura(long Id, string Username)
        {
            try
            {
                //Obtener informacion del pago
                Pago pago = LNPago.GetInstance().GetPago(Id);
                IdPago = pago.Id;
                FechaFacturacion = pago.FechaPago.ToShortDateString();

                //Obtener informacion del Username
                Usuario usuario = LNUsuario.GetInstance().GetUsuario(Username);
                Usuario = usuario.Username;
                Email = usuario.Email;
                NombreUsuario = usuario.NombreCompleto;

                //Obtener detalle de pago
                FacturaLista = new List<ListadoFactura>();
                foreach (DetallePago detalle in LNDetallePago.GetInstance().GetDetallePagos(Id))
                {
                    ListadoFactura factura = new ListadoFactura()
                    {
                        Nº = detalle.Nº,
                        Detalle = detalle.Detalle,
                        Precio = detalle.Precio,
                        Cantidad = detalle.Cantidad,
                        SubTotal = detalle.SubTotal,
                        PagoTotal = detalle.PagoTotal
                    };
                    FacturaLista.Add(factura);
                    SubTotal += detalle.SubTotal;
                    TotalPagar += detalle.PagoTotal;
                }
            }
            catch (TimeoutException ex)
            {
                throw ex;
            }
            catch (NullReferenceException ex)
            {
                throw ex;
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            catch (SqlNullValueException ex)
            {
                throw ex;
            }
            catch (ApplicationException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
