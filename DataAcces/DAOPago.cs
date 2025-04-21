using System;
using Entities;
using System.Data;
using System.Data.SqlTypes;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DataAcces
{
    public class DAOPago : ConnectionDB
    {
        private static DAOPago pago = null;
        private DAOPago() { }
        public static DAOPago GetInstance()
        {
            if (pago == null)
            {
                pago = new DAOPago();
            }
            return pago;
        }

        MySqlConnection con = null;
        MySqlCommand scmd;
        MySqlDataReader sdr;
        DataTable list = null;

        public bool GenerarPago(Pago pago, List<DetallePago> detalles)
        {
            bool responce = false;
            using (con = GetSqlConnection())
            {
                using (scmd = new MySqlCommand())
                {
                    try
                    {
                        con.Open();
                        scmd.Connection = con;
                        scmd.CommandText = "NewPago";
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.Parameters.AddWithValue("Pago", pago.Id);
                        scmd.Parameters.AddWithValue("Usuario", pago.IdUsuario);
                        scmd.Parameters.AddWithValue("Cita", pago.IdCita);
                        scmd.Parameters.AddWithValue("SubTotal", pago.SubTotal);
                        scmd.Parameters.AddWithValue("PagoTotal", pago.PagoTotal);
                        scmd.Parameters.AddWithValue("FechaPago", DateTime.Now.Date);
                        if (scmd.ExecuteNonQuery() != 0)
                        {
                            foreach (DetallePago detallePago in detalles)
                            {
                                DAODetallePago.GetInstance().GuardarDetallePago(detallePago);
                            }
                            responce = true;
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
                        con.Close();
                        scmd.Parameters.Clear();
                    }
                }
            }
            return responce;
        }
        public long NumeroFactura()
        {
            long count;
            using (con = GetSqlConnection())
            {
                using (scmd = new MySqlCommand())
                {
                    try
                    {
                        con.Open();
                        scmd.Connection = con;
                        scmd.CommandText = "GetNumFactura";
                        scmd.CommandType = CommandType.StoredProcedure;
                        count = Convert.ToInt64(scmd.ExecuteScalar()) + 1;
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
            return count;
        }
        public Pago GetPago(long Id)
        {
            Pago pago = null;
            using (con = GetSqlConnection())
            {
                using (scmd = new MySqlCommand())
                {
                    try
                    {
                        con.Open();
                        scmd.Connection = con;
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.CommandText = "GetPago";
                        scmd.Parameters.AddWithValue("Pago", Id);
                        sdr = scmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            pago = new Pago
                            {
                                Id = sdr.GetInt64(0),
                                IdUsuario = sdr.GetInt64(1),
                                IdCita = sdr.GetInt64(2),
                                SubTotal = (double)sdr.GetDecimal(3),
                                PagoTotal = (double)sdr.GetDecimal(4),
                                FechaPago = sdr.GetDateTime(5)
                            };
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
                        con.Close();
                        scmd.Parameters.Clear();
                    }
                }
            }
            return pago;
        }
        public DataTable ListarPagos()
        {
            using (con = GetSqlConnection())
            {
                using (scmd = new MySqlCommand())
                {
                    try
                    {
                        con.Open();
                        list = new DataTable();
                        scmd.Connection = con;
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.CommandText = "GetListPagos";
                        sdr = scmd.ExecuteReader();
                        list.Load(sdr);
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
            return list;
        }
        public DataTable BuscarPago(long numfactura)
        {
            using (con = GetSqlConnection())
            {
                using (scmd = new MySqlCommand())
                {
                    try
                    {
                        con.Open();
                        list = new DataTable();
                        scmd.Connection = con;
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.CommandText = "GetPagoByNumero";
                        scmd.Parameters.AddWithValue("Numero", numfactura);
                        sdr = scmd.ExecuteReader();
                        list.Load(sdr);
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
            return list;
        }
    }
}
