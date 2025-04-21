using System;
using Entities;
using System.Data;
using System.Data.SqlTypes;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DataAcces
{
    public class DAODetallePago : ConnectionDB
    {
        private static DAODetallePago detalle = null;
        private DAODetallePago() { }
        public static DAODetallePago GetInstance()
        {
            if (detalle == null)
            {
                detalle = new DAODetallePago();
            }
            return detalle;
        }

        MySqlConnection con;
        MySqlCommand scmd;
        MySqlDataReader sdr;

        public void GuardarDetallePago(DetallePago detallePago)
        {
            using (con = GetSqlConnection())
            {
                using (scmd = new MySqlCommand())
                {
                    try
                    {
                        con.Open();
                        scmd.Connection = con;
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.CommandText = "NewDetallePago";
                        scmd.Parameters.AddWithValue("Pago", detallePago.IdPago);
                        scmd.Parameters.AddWithValue("Item",detallePago.Nº);
                        scmd.Parameters.AddWithValue("Detalles", detallePago.Detalle);
                        scmd.Parameters.AddWithValue("Precio",  detallePago.Precio);
                        scmd.Parameters.AddWithValue("Cantidad", detallePago.Cantidad);
                        scmd.Parameters.AddWithValue("Subtotal", detallePago.SubTotal);
                        scmd.Parameters.AddWithValue("Total", detallePago.PagoTotal);
                        scmd.ExecuteNonQuery();
                    }
                    catch (MySqlException ex)
                    {
                        throw ex;
                    }
                    catch (SqlNullValueException ex)
                    {
                        throw ex;
                    }
                    catch (TimeoutException ex)
                    {
                        throw ex;
                    }
                    catch (NullReferenceException ex)
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
                    finally
                    {
                        con.Close();
                        scmd.Parameters.Clear();
                    }
                }
            }
        }
        public List<DetallePago> GetDetallePagos(long Id)
        {
            List<DetallePago> ListadoPago = new List<DetallePago>();
            DetallePago detallePago;
            using (con = GetSqlConnection())
            {
                using (scmd = new MySqlCommand())
                {
                    try
                    {
                        con.Open();
                        scmd.Connection = con;
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.CommandText = "GetListDetallesPago";
                        scmd.Parameters.AddWithValue("Pago", Id);
                        sdr = scmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            detallePago = new DetallePago()
                            {
                                Nº = sdr.GetInt32(0),
                                Detalle = sdr.GetString(1),
                                Precio = sdr.GetDouble(2),
                                Cantidad = sdr.GetInt32(3),
                                SubTotal = sdr.GetDouble(4),
                                PagoTotal = sdr.GetDouble(5),
                            };
                            ListadoPago.Add(detallePago);
                        }
                    }
                    catch (MySqlException ex)
                    {
                        throw ex;
                    }
                    catch (SqlNullValueException ex)
                    {
                        throw ex;
                    }
                    catch (TimeoutException ex)
                    {
                        throw ex;
                    }
                    catch (NullReferenceException ex)
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
                    finally
                    {
                        scmd.Parameters.Clear();
                        con.Close();
                    }
                }
            }
            return ListadoPago;
        }
    }
}
