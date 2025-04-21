using DataAcces;
using Entities;
using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlTypes;

namespace Logic
{
    public class LNCitaProxima
    {
        private static LNCitaProxima next = null;
        private LNCitaProxima() { }
        public static LNCitaProxima GetInstance()
        {
            if (next == null)
            {
                next = new LNCitaProxima();
            }
            return next;
        }

        public bool ProximaCita(ProximaCita cita)
        {
            try
            {
                return DAOCitaProxima.GetInstance().ProximaCita(cita);
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
        public DataTable GetNextDates()
        {
            try
            {
                return DAOCitaProxima.GetInstance().GetNextDates();
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
