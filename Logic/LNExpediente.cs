using DataAcces;
using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlTypes;

namespace Logic
{
    public class LNExpediente
    {
        private static LNExpediente expedientes = null;
        private LNExpediente() { }
        public static LNExpediente GetInstance()
        {
            if (expedientes == null)
            {
                expedientes = new LNExpediente();
            }
            return expedientes;
        }

        public bool NuevoExpediente(Expediente expediente)
        {
            try
            {
                return DAOExpediente.GetInstance().NuevoExpediente(expediente);
            }
            catch(MySqlException ex)
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
        public long CountExpediente()
        {
            try
            {
                return DAOExpediente.GetInstance().CountExpediente();
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
        public DataTable ListExpediente()
        {
            try
            {
                return DAOExpediente.GetInstance().ListExpediente();
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
