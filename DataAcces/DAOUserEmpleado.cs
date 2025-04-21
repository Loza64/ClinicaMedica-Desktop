using System;
using Entities;
using System.Data;
using System.Data.SqlTypes;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DataAcces
{
    public class DAOUserEmpleado : ConnectionDB
    {
        private static DAOUserEmpleado userEmpleado = null;
        private DAOUserEmpleado() { }
        public static DAOUserEmpleado GetInstance()
        {
            if (userEmpleado == null)
            {
                userEmpleado = new DAOUserEmpleado();
            }
            return userEmpleado;
        }

        MySqlConnection con;
        MySqlCommand scmd;
        MySqlDataReader sdr;

        public UserEmpleado LoginUser(string user, string password)
        {
            UserEmpleado employee = null;
            using (con = GetSqlConnection())
            {
                using (scmd = new MySqlCommand())
                {
                    try
                    {
                        con.Open();
                        scmd.Connection = con;
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.CommandText = "LoginUserEmpleado";
                        scmd.Parameters.AddWithValue("Username", user);
                        scmd.Parameters.AddWithValue("Password", password);
                        sdr = scmd.ExecuteReader();
                        if (sdr.HasRows)
                        {
                            employee = new UserEmpleado();
                            while (sdr.Read())
                            {
                                employee = new UserEmpleado
                                {
                                    Id = sdr.GetInt64(0),
                                    Area = sdr.GetInt64(1),
                                    Imagen = (byte[])sdr[2],
                                    UserName = sdr.GetString(3),
                                    NombreCompleto = sdr.GetString(4),
                                    Edad = sdr.GetInt32(5),
                                    Nacimiento = sdr.GetDateTime(6),
                                    Genero = sdr.GetString(7),
                                    Dui = sdr.GetString(8),
                                    Email = sdr.GetString(9),
                                    Direccion = sdr.GetString(10),
                                    Telefono = sdr.GetString(11),
                                    Estado = sdr.GetBoolean(13),
                                    Roll = sdr.GetInt64(14)
                                };
                            }
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
            return employee;
        }
        public bool SingUp(UserEmpleado employee)
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
                        scmd.CommandText = "NewUserEmpleado";
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.Parameters.AddWithValue("Area", employee.Area);
                        scmd.Parameters.AddWithValue("Imagen", employee.Imagen);
                        scmd.Parameters.AddWithValue("Username", employee.UserName);
                        scmd.Parameters.AddWithValue("NombreCompleto", employee.NombreCompleto);
                        scmd.Parameters.AddWithValue("Nacimiento", employee.Nacimiento);
                        scmd.Parameters.AddWithValue("Email", employee.Email);
                        scmd.Parameters.AddWithValue("Edad", employee.Edad);
                        scmd.Parameters.AddWithValue("Sexo", employee.Genero);
                        scmd.Parameters.AddWithValue("Dui", employee.Dui);
                        scmd.Parameters.AddWithValue("Direccion", employee.Direccion);
                        scmd.Parameters.AddWithValue("Telefono", employee.Telefono);
                        scmd.Parameters.AddWithValue("Password", employee.Password);
                        scmd.Parameters.AddWithValue("Roll", employee.Roll);
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
                    return responce;
                }
            }
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
                        scmd.CommandText = "ChekUserEmpleado";
                        scmd.Parameters.AddWithValue("Usuario", user);
                        scmd.Parameters.AddWithValue("Email", email);
                        scmd.Parameters.AddWithValue("Dui", dui);
                        scmd.Parameters.AddWithValue("Telefono", telefono);
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
        public UserEmpleado GetEmployee(long id)
        {
            UserEmpleado employee = null;
            using (con = GetSqlConnection())
            {
                using (scmd = new MySqlCommand())
                {
                    try
                    {
                        con.Open();
                        scmd.Connection = con;
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.CommandText = "GetEmployee";
                        scmd.Parameters.AddWithValue("Employee", id);
                        sdr = scmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            employee = new UserEmpleado
                            {
                                Id = sdr.GetInt64(0),
                                Area = sdr.GetInt64(1),
                                Imagen = (byte[])sdr[2],
                                UserName = sdr.GetString(3),
                                NombreCompleto = sdr.GetString(4),
                                Edad = sdr.GetInt32(5),
                                Nacimiento = sdr.GetDateTime(6),
                                Genero = sdr.GetString(7),
                                Dui = sdr.GetString(8),
                                Email = sdr.GetString(9),
                                Direccion = sdr.GetString(10),
                                Telefono = sdr.GetString(11),
                                Estado = sdr.GetBoolean(13),
                                Roll = sdr.GetInt64(14)
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
            return employee;
        }
        public List<UserEmpleado> GetListEmployees()
        {
            List<UserEmpleado> list = new List<UserEmpleado>();
            UserEmpleado employee;
            using (con = GetSqlConnection())
            {
                using (scmd = new MySqlCommand())
                {
                    try
                    {
                        con.Open();
                        scmd.Connection = con;
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.CommandText = "GetListEmployee";
                        sdr = scmd.ExecuteReader();
                        while (sdr.Read())
                        {
                            employee = new UserEmpleado
                            {
                                Id = sdr.GetInt64(0),
                                Area = sdr.GetInt64(1),
                                Imagen = (byte[])sdr[2],
                                UserName = sdr.GetString(3),
                                NombreCompleto = sdr.GetString(4),
                                Edad = sdr.GetInt32(5),
                                Nacimiento = sdr.GetDateTime(6),
                                Genero = sdr.GetString(7),
                                Dui = sdr.GetString(8),
                                Email = sdr.GetString(9),
                                Direccion = sdr.GetString(10),
                                Telefono = sdr.GetString(11),
                                Estado = sdr.GetBoolean(13),
                                Roll = sdr.GetInt64(14)
                            };
                            list.Add(employee);
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
            return list;
        }
        public bool UpdateData(UserEmpleado employee)
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
                        scmd.CommandText = "UpdateEmployee";
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.Parameters.AddWithValue("Usuario", employee.UserName);
                        scmd.Parameters.AddWithValue("Nombre", employee.NombreCompleto);
                        scmd.Parameters.AddWithValue("Dui", employee.Dui);
                        scmd.Parameters.AddWithValue("Direccion", employee.Direccion);
                        scmd.Parameters.AddWithValue("Email", employee.Email);
                        scmd.Parameters.AddWithValue("Genero", employee.Genero);
                        scmd.Parameters.AddWithValue("Nacimiento", employee.Nacimiento);
                        scmd.Parameters.AddWithValue("Edad", employee.Edad);
                        scmd.Parameters.AddWithValue("Telefono", employee.Telefono);
                        scmd.Parameters.AddWithValue("Employee", employee.Id);
                        responce = scmd.ExecuteNonQuery() != 0;
                    }

                    catch (MySqlException ex)
                    {
                        if (ex.Number == 2601 || ex.Number == 2627)
                        {
                            responce = false;
                        }
                        else
                        {
                            throw ex;
                        }
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
        public bool UpdateStateEmployee(long Id, bool state)
        {
            bool account = false;
            using (con = GetSqlConnection())
            {
                using (scmd = new MySqlCommand())
                {
                    try
                    {
                        con.Open();
                        scmd.Connection = con;
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.CommandText = "UpdateEmployeeState";
                        scmd.Parameters.AddWithValue("Employee", Id);
                        scmd.Parameters.AddWithValue("State", state);
                        account = scmd.ExecuteNonQuery() != 0;
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
            return account;
        }
        public bool UpdateImage(long Id, byte[] img)
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
                        scmd.CommandText = "UpdateEmployeeImagen";
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.Parameters.AddWithValue("Employee", Id);
                        scmd.Parameters.AddWithValue("Imagen", img);
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
        public bool DeleteEmployee(long Id)
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
                        scmd.CommandText = "DeleteEmployee";
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.Parameters.AddWithValue("IdEmployee", Id);
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

        public bool UpdatePassword(string user, string newpassword)
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
                        scmd.CommandText = "UpdatePasswordUserEmpleado";
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.Parameters.AddWithValue("Username", user);
                        scmd.Parameters.AddWithValue("Password", newpassword);
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
        public UserEmpleado RecoveryPass(string email)
        {
            UserEmpleado user = null;
            using (con = GetSqlConnection())
            {
                using (scmd = new MySqlCommand())
                {
                    try
                    {
                        con.Open();
                        scmd.Connection = con;
                        scmd.CommandText = "GetPasswordUserEmpleado";
                        scmd.CommandType = CommandType.StoredProcedure;
                        scmd.Parameters.AddWithValue("@Email", email);
                        sdr = scmd.ExecuteReader();
                        if (sdr.Read())
                        {
                            user = new UserEmpleado
                            {
                                Email = email,
                                UserName = sdr["Username"].ToString(),
                                Password = sdr["Password"].ToString()
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
            return user;
        }
        public long CountEmployees()
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
                        scmd.CommandText = "GetCountEmployees";
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