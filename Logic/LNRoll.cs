using DataAcces;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlTypes;

namespace Logic
{
    public class LNRoll
    {
        private static LNRoll roll = null;
        private LNRoll() { }
        public static LNRoll GetInstance()
        {
            if (roll == null)
            {
                roll = new LNRoll();
            }
            return roll;
        }

        public DataTable ListarRoll()
        {
            try
            {
                return DAORoll.GetInstace().ListarRoll();
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
        }
        public string GetRoll(long id)
        {
            try
            {
                return DAORoll.GetInstace().GetRoll(id);
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
        }
    }
}
