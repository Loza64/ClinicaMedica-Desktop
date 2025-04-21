using DataAcces;
using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlTypes;

namespace Logic
{
    public class LNUsuario
    {
        private static LNUsuario daoUsuario = null;
        private LNUsuario() { }
        public static LNUsuario GetInstance()
        {
            if (daoUsuario == null)
            {
                daoUsuario = new LNUsuario();
            }
            return daoUsuario;
        }

        public bool NewUser(Usuario paciente)
        {
            try
            {
                return DAOUsuario.GetInstance().NewUser(paciente);
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
        public bool CheckData(string user, string email, string dui, string telefono)
        {
            try
            {
                return DAOUsuario.GetInstance().CheckData(user, email, dui, telefono);
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
        public Usuario GetUsuario(string username)
        {
            try
            {
                return DAOUsuario.GetInstance().GetUsuario(username);
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
        public DataTable ListUsers()
        {
            try
            {
                return DAOUsuario.GetInstance().ListUsers();
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
        public DataTable ListDissableUsers()
        {
            try
            {
                return DAOUsuario.GetInstance().ListDissableUsers();
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
        public DataTable SearchUser(string texto)
        {
            try
            {
                return DAOUsuario.GetInstance().SearchUser(texto);
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
        public bool ModifyStateUser(string User, bool state)
        {
            try
            {
                return DAOUsuario.GetInstance().ModifyStateUser(User, state);
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
        public bool DeletDissabledUsers()
        {
            try
            {
                return DAOUsuario.GetInstance().DeletDissabledUsers();
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
        public long Countusers()
        {
            try
            {
                return DAOUsuario.GetInstance().Countusers();
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
        public long Countdissableusers()
        {
            try
            {
                return DAOUsuario.GetInstance().Countdissableusers();
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
        public long Countenabledusers()
        {
            try
            {
                return DAOUsuario.GetInstance().Countenabledusers();
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
        public bool DeleteUser(long id)
        {
            try
            {
                return DAOUsuario.GetInstance().DeleteUser(id);
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
