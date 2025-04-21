
using System;
using System.Data;
using System.Data.SqlTypes;
using MySql.Data.MySqlClient;

namespace DataAcces
{
    public class DAORoll : ConnectionDB
    {
        private static DAORoll roll = null;
        private DAORoll() { }
        public static DAORoll GetInstace()
        {
            if (roll == null)
            {
                roll = new DAORoll();
            }
            return roll;
        }

        MySqlConnection con;
        DataTable list = null;
        MySqlCommand scmd = null;
        MySqlDataReader sdr;

        public DataTable ListarRoll()
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
                        scmd.CommandText = "GetListRoll";
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
        public string GetRoll(long id)
        {
            string roll = null;
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
                        scmd.CommandText = "GetRoll";
                        scmd.Parameters.AddWithValue("Roll", id);
                        sdr = scmd.ExecuteReader();
                        if (sdr.HasRows)
                        {
                            while (sdr.Read())
                            {
                                roll = sdr.GetString(1);
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
                        scmd.Parameters.Clear();
                        con.Close();
                    }
                }
            }
            return roll;
        }
    }
}
