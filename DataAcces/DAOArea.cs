using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace DataAcces
{
    public class DAOArea : ConnectionDB
    {
        private static DAOArea daoArea = null;
        private DAOArea() { }
        public static DAOArea GetInstace()
        {
            if (daoArea == null)
            {
                daoArea = new DAOArea();
            }
            return daoArea;
        }

        MySqlConnection con;
        DataTable list = null;
        MySqlCommand scmd = null;
        MySqlDataReader sdr;

        public DataTable ListarArea()
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
                        scmd.CommandText = "GetListAreas";
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
        public string GetArea(long id)
        {
            string area = null;
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
                        scmd.CommandText = "GetArea";
                        scmd.Parameters.AddWithValue("AreaItem", id);
                        sdr = scmd.ExecuteReader();
                        if (sdr.HasRows)
                        {
                            while (sdr.Read())
                            {
                                area = sdr.GetString(1);
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
            return area;
        }
    }
}
