using System;
using Entities;
using System.Data;
using System.Data.SqlTypes;
using MySql.Data.MySqlClient;

namespace DataAcces
{
    public class DAOUsuario : ConnectionDB
    {
        //Patron singleton
        private static DAOUsuario daoUsuario = null;
        private DAOUsuario() { }
        public static DAOUsuario GetInstance()
        {
            if (daoUsuario == null)
            {
                daoUsuario = new DAOUsuario();
            }
            return daoUsuario;
        }

        MySqlConnection con = null;
        MySqlCommand scmd = null;
        MySqlDataReader sdr;

        public bool NewUser(Usuario paciente)
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
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.CommandText = "NewUsuario";
                        scmd.Parameters.AddWithValue("Usuario", paciente.Username);
                        scmd.Parameters.AddWithValue("NombreCompleto", paciente.NombreCompleto);
                        scmd.Parameters.AddWithValue("Nacimiento", paciente.Nacimiento);
                        scmd.Parameters.AddWithValue("Email", paciente.Email);
                        scmd.Parameters.AddWithValue("Edad", paciente.Edad);
                        scmd.Parameters.AddWithValue("Sexo", paciente.Genero);
                        scmd.Parameters.AddWithValue("Dui", paciente.Dui);
                        scmd.Parameters.AddWithValue("Direccion", paciente.Direccion);
                        scmd.Parameters.AddWithValue("Telefono", paciente.Telefono);
                        scmd.Parameters.AddWithValue("Password", paciente.Password);
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
        public bool CheckData(string user, string email, string dui, string telefono)
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
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.CommandText = "CheckUsuario";
                        scmd.Parameters.AddWithValue("Usuario", SqlDbType.VarChar).Value = user;
                        scmd.Parameters.AddWithValue("Email", SqlDbType.Variant).Value = email;
                        scmd.Parameters.AddWithValue("Dui", SqlDbType.VarChar).Value = dui;
                        scmd.Parameters.AddWithValue("Telefono", SqlDbType.Variant).Value = telefono;
                        sdr = scmd.ExecuteReader();
                        responce = sdr.Read();
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
        public Usuario GetUsuario(string username)
        {
            Usuario usuario = null;
            using (con = GetSqlConnection())
            {
                using (scmd = new MySqlCommand())
                {
                    try
                    {
                        con.Open();
                        scmd.Connection = con;
                        scmd.CommandText = "GetUsuario";
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.Parameters.AddWithValue("Usuario",username);
                        sdr = scmd.ExecuteReader();
                        if (sdr.Read())
                        {
                            usuario = new Usuario
                            {
                                Id = sdr.GetInt64(0),
                                Username = sdr.GetString(1),
                                NombreCompleto = sdr.GetString(2),
                                Edad = sdr.GetInt32(3),
                                Nacimiento = sdr.GetDateTime(4),
                                Genero = sdr.GetString(5),
                                Dui = sdr.GetString(6),
                                Email = sdr.GetString(7),
                                Direccion = sdr.GetString(8),
                                Telefono = sdr.GetString(9),
                                Confirmacion = sdr.GetBoolean(11),
                                EstadoUsuario = sdr.GetBoolean(12)
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
            return usuario;
        }
        public DataTable ListUsers()
        {
            DataTable list = new DataTable();
            using (con = GetSqlConnection())
            {
                using (scmd = new MySqlCommand())
                {
                    try
                    {
                        con.Open();
                        scmd.Connection = con;
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.CommandText = "GetListUsuarios";
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
        public DataTable ListDissableUsers()
        {
            DataTable list = new DataTable();
            using (con = GetSqlConnection())
            {
                using (scmd = new MySqlCommand())
                {
                    try
                    {
                        con.Open();
                        scmd.Connection = con;
                        scmd.CommandText = "GetListDisabledUsuarios";
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
                        con.Close();
                        scmd.Parameters.Clear();
                    }
                }
            }
            return list;
        }
        public DataTable SearchUser(string texto)
        {
            DataTable list = new DataTable();
            using (con = GetSqlConnection())
            {
                using (scmd = new MySqlCommand())
                {
                    try
                    {
                        con.Open();
                        scmd.Connection = con;
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.CommandText = "GetUsuarioItem";
                        scmd.Parameters.AddWithValue("Usuario",  texto);
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

        public bool ModifyStateUser(string User, bool state)
        {
            bool update = false;
            using (con = GetSqlConnection())
            {
                using (scmd = new MySqlCommand())
                {
                    try
                    {
                        con.Open();
                        scmd.Connection = con;
                        scmd.CommandType = CommandType.Text;
                        scmd.CommandText = "UpdateStateUser";
                        scmd.Parameters.AddWithValue("Usuario",User);
                        scmd.Parameters.AddWithValue("Estado", state);
                        update = scmd.ExecuteNonQuery() != 0;
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
            return update;
        }
        public bool DeletDissabledUsers()
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
                        scmd.CommandText = "DeleteDissabledUsers";
                        scmd.CommandType = CommandType.StoredProcedure;
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
                    }
                }
            }
            return responce;
        }
        public bool DeleteUser(long id)
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
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.CommandText = "DeleteUser";
                        scmd.Parameters.AddWithValue("IdUser", id);
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
                    }
                }
            }
            return responce;
        }
        public long Countusers()
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
                        scmd.CommandText = "GetCountUsers";
                        scmd.CommandType = CommandType.StoredProcedure;
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
        public long Countdissableusers()
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
                        scmd.CommandText = "GetCountDisableUsers";
                        scmd.CommandType = CommandType.StoredProcedure;
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
        public long Countenabledusers()
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
                        scmd.CommandText = "GetCountEnableUsers";
                        scmd.CommandType = CommandType.StoredProcedure;
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
    }
}