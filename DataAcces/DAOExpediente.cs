using System;
using Entities;
using System.Data;
using System.Data.SqlTypes;
using MySql.Data.MySqlClient;

namespace DataAcces
{
    public class DAOExpediente : ConnectionDB
    {
        private static DAOExpediente expedientes = null;
        private DAOExpediente() { }
        public static DAOExpediente GetInstance()
        {
            if (expedientes == null)
            {
                expedientes = new DAOExpediente();
            }
            return expedientes;
        }

        MySqlConnection con;
        MySqlCommand scmd = null;
        MySqlDataReader sdr;
        DataTable list = null;

        public bool NuevoExpediente(Expediente expediente)
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
                        scmd.CommandText = "NewExpediente";
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.Parameters.AddWithValue("Cita", expediente.IdCita);
                        scmd.Parameters.AddWithValue("Empleado", expediente.IdUserEmpleado);
                        scmd.Parameters.AddWithValue("Tratamiento",expediente.Tratamiento);
                        scmd.Parameters.AddWithValue("Antecedentes",expediente.Antecedentes);
                        scmd.Parameters.AddWithValue("Diagnostico",expediente.Diagnostico);
                        scmd.Parameters.AddWithValue("Fecha", DateTime.Now.Date);
                        responce = scmd.ExecuteNonQuery() != 0;
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
        public long CountExpediente()
        {
            long count = 0;
            using (con = GetSqlConnection())
            {
                using (scmd = new MySqlCommand())
                {
                    try
                    {
                        con.Open();
                        scmd.Connection = con;
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.CommandText = "GetCountExpedientes";
                        count = Convert.ToInt64(scmd.ExecuteScalar());
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
        public DataTable ListExpediente()
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
                        scmd.CommandText = "GetListExpedientes";
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
