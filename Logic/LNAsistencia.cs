using DataAcces;
using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlTypes;

namespace Logic
{
    public class LNAsistencia
    {
        private static LNAsistencia asistencia = null;
        private LNAsistencia() { }
        public static LNAsistencia GetInstance()
        {
            if (asistencia == null)
            {
                asistencia = new LNAsistencia();
            }
            return asistencia;
        }

        public bool NewAsistencia(Asistencia asistance)
        {
            try
            {
                return DAOAsistencia.GetInstance().NewAsistencia(asistance);
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
        public DataTable GetAsistencias()
        {
            try
            {
                return DAOAsistencia.GetInstance().GetAsistencias();
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
