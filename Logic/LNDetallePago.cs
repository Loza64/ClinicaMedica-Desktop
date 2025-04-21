using DataAcces;
using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace Logic
{
    public class LNDetallePago
    {
        private static LNDetallePago detalle = null;
        private LNDetallePago() { }
        public static LNDetallePago GetInstance()
        {
            if (detalle == null)
            {
                detalle = new LNDetallePago();
            }
            return detalle;
        }
        public List<DetallePago> GetDetallePagos(long Id)
        {
            try
            {
                return DAODetallePago.GetInstance().GetDetallePagos(Id);
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
