using DataAcces;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlTypes;

namespace Logic
{
    public class LNArea
    {
        private static LNArea lnArea = null;
        private LNArea() { }
        public static LNArea GetInstance()
        {
            if (lnArea == null)
            {
                lnArea = new LNArea();
            }
            return lnArea;
        }

        public DataTable ListarArea()
        {
            try
            {
                return DAOArea.GetInstace().ListarArea();
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
        public string GetArea(long id)
        {
            try
            {
                return DAOArea.GetInstace().GetArea(id);
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
