using System;
using Entities;
using System.Data;
using System.Data.SqlTypes;
using MySql.Data.MySqlClient;

namespace DataAcces
{
    public class DAORecetaMedica : ConnectionDB
    {
        private static DAORecetaMedica receta = null;
        private DAORecetaMedica() { }
        public static DAORecetaMedica GetInstance()
        {
            if (receta == null)
            {
                receta = new DAORecetaMedica();
            }
            return receta;
        }

        MySqlConnection con;
        MySqlCommand scmd = null;
        MySqlDataReader sdr;
        DataTable list = null;

        public bool EnviarReceta(RecetaMedica recetaMedica)
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
                        scmd.CommandText = "NewReceta";
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.Parameters.AddWithValue("IdEmpleado", recetaMedica.IdUserEmpleado);
                        scmd.Parameters.AddWithValue("IdUsuario", recetaMedica.IdUsuario);
                        scmd.Parameters.AddWithValue("DomicilioPaciente", recetaMedica.DomicilioPaciente);
                        scmd.Parameters.AddWithValue("Diagnostico", recetaMedica.Diagnostico);
                        scmd.Parameters.AddWithValue("NombreMedicamento", recetaMedica.NombreComercialMedicina);
                        scmd.Parameters.AddWithValue("NombreMedicamento", recetaMedica.NombreMedicamento);
                        scmd.Parameters.AddWithValue("Cantidad", recetaMedica.Cantidad);
                        scmd.Parameters.AddWithValue("Dosis", recetaMedica.Dosis);
                        scmd.Parameters.AddWithValue("ViaConsumo", recetaMedica.ViaConsumo);
                        scmd.Parameters.AddWithValue("FechaRecetada", recetaMedica.FechaRecetada);
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
        public long CountRecetas()
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
                        scmd.CommandText = "GetCountRecetas";
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
        public DataTable ListRecetas()
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
                        scmd.CommandText = "GetListRecetas";
                        scmd.CommandType = CommandType.StoredProcedure;
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
        public DataTable ListRecetaByEmployee(long Id)
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
                        scmd.CommandText = "GetListRecetasByEmployee";
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.Parameters.AddWithValue("Employee", Id);
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
