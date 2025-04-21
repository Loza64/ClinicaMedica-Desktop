using DataAcces;
using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace Logic
{
    public class LNNotificacion
    {
        private static LNNotificacion notifiacion = null;
        private LNNotificacion() { }
        public static LNNotificacion GetInstance()
        {
            if (notifiacion == null) notifiacion = new LNNotificacion();

            return notifiacion;
        }

        public List<Notificacion> ListarNotificaciones(long Id)
        {
            try
            {
                return DAONotificacion.GetInstance().ListarNotificaciones(Id);
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
        public List<Notificacion> NotificacionesNoLeidas(long Id)
        {
            try
            {
                return DAONotificacion.GetInstance().NotificacionesNoLeidas(Id);
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
        public long CountNotificacion(long Id)
        {
            try
            {
                return DAONotificacion.GetInstance().CountNotificacion(Id);
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
        public void UpdateNotification(long IdEmpleado, long IdNotificacion)
        {
            try
            {
                DAONotificacion.GetInstance().UpdateNotification(IdEmpleado, IdNotificacion);
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
        public void RegistrarNotificacion(Notificacion notificacion)
        {
            try
            {
                DAONotificacion.GetInstance().RegistrarNotificacion(notificacion);
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
