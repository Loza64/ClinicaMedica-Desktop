using System;
using Entities;
using System.Data;
using System.Data.SqlTypes;
using MySql.Data.MySqlClient;

namespace DataAcces
{
    public class DAOAsistencia : ConnectionDB
    {
        private static DAOAsistencia asistencia = null;
        private DAOAsistencia() { }
        public static DAOAsistencia GetInstance()
        {
            if (asistencia == null)
            {
                asistencia = new DAOAsistencia();
            }
            return asistencia;
        }

        MySqlConnection con;
        MySqlCommand scmd = null;
        MySqlDataReader sdr;
        public DataTable list = null;

        public bool NewAsistencia(Asistencia asistance)
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
                        scmd.CommandText = "NewAsistencia";
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.Parameters.AddWithValue("Cita", asistance.IdCita);
                        scmd.Parameters.AddWithValue("UserEmpleado",asistance.IdEmpleado);
                        scmd.Parameters.AddWithValue("Motivo", asistance.MotivoCita);
                        scmd.Parameters.AddWithValue("Fecha",asistance.FechaAsistencia);
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
        public DataTable GetAsistencias()
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
                        scmd.CommandText = "GetListAsistencias";
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
    }
}
