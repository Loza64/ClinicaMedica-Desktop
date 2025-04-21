using System;
using Entities;
using System.Data;
using System.Data.SqlTypes;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DataAcces
{
    public class DAONotificacion : ConnectionDB
    {
        private static DAONotificacion notifiacion = null;
        private DAONotificacion() { }
        public static DAONotificacion GetInstance()
        {
            if (notifiacion == null) notifiacion = new DAONotificacion();

            return notifiacion;
        }

        MySqlConnection con;
        MySqlCommand scmd = null;
        MySqlDataReader sdr;

        public List<Notificacion> ListarNotificaciones(long Id)
        {
            List<Notificacion> notificaciones = new List<Notificacion>();
            Notificacion itemnotifiacion;
            using (con = GetSqlConnection())
            {
                using (scmd = new MySqlCommand())
                {
                    try
                    {
                        con.Open();
                        scmd.Connection = con;
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.CommandText = "GetListNoticiaciones";
                        scmd.Parameters.AddWithValue("Empleado", Id);
                        sdr = scmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            itemnotifiacion = new Notificacion
                            {
                                Id = sdr.GetInt64(0),
                                IdEmpleado = sdr.GetInt64(1),
                                Titulo = sdr.GetString(2),
                                DetalleNotificacion = sdr.GetString(3),
                                FechaNotificacion = sdr.GetDateTime(4),
                                Estado = sdr.GetString(5)
                            };
                            notificaciones.Add(itemnotifiacion);
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
            return notificaciones;
        }
        public List<Notificacion> NotificacionesNoLeidas(long Id)
        {
            List<Notificacion> notificaciones = new List<Notificacion>();
            Notificacion itemnotifiacion;
            using (con = GetSqlConnection())
            {
                using (scmd = new MySqlCommand())
                {
                    try
                    {
                        con.Open();
                        scmd.Connection = con;
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.CommandText = "GetListNoticiacionesNoLeidas";
                        scmd.Parameters.AddWithValue("Empleado", Id);
                        sdr = scmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            itemnotifiacion = new Notificacion
                            {
                                Id = sdr.GetInt64(0),
                                IdEmpleado = sdr.GetInt64(1),
                                Titulo = sdr.GetString(2),
                                DetalleNotificacion = sdr.GetString(3),
                                FechaNotificacion = sdr.GetDateTime(4),
                                Estado = sdr.GetString(5)
                            };
                            notificaciones.Add(itemnotifiacion);
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
            return notificaciones;
        }
        public long CountNotificacion(long Id)
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
                        scmd.CommandText = "GetCountNotificacionesNoLeidas";
                        scmd.Parameters.AddWithValue("Empleado", Id);
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
        public void UpdateNotification(long IdEmpleado, long IdNotificacion)
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
                        scmd.CommandText = "UpdateNotificacion";
                        scmd.Parameters.AddWithValue("Empleado", IdEmpleado);
                        scmd.Parameters.AddWithValue("Notificacion", IdNotificacion);
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
        public void RegistrarNotificacion(Notificacion notificacion)
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
                        scmd.CommandText = "NewNotificacion";
                        scmd.Parameters.AddWithValue("Empleado",notificacion.IdEmpleado);
                        scmd.Parameters.AddWithValue("Titulo",notificacion.Titulo);
                        scmd.Parameters.AddWithValue("Detalle", notificacion.DetalleNotificacion);
                        scmd.Parameters.AddWithValue("Fecha", DateTime.Now.AddHours(0));
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
    }
}
