using DataAcces;
using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlTypes;

namespace Logic
{
    public class LNRecetaMedica
    {
        private static LNRecetaMedica receta = null;
        private LNRecetaMedica() { }
        public static LNRecetaMedica GetInstance()
        {
            if (receta == null)
            {
                receta = new LNRecetaMedica();
            }
            return receta;
        }

        public bool EnviarReceta(RecetaMedica recetaMedica)
        {
            try
            {
                return DAORecetaMedica.GetInstance().EnviarReceta(recetaMedica);
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
        public long CountRecetas()
        {
            try
            {

                return DAORecetaMedica.GetInstance().CountRecetas();
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
        public DataTable ListRecetas()
        {
            try
            {
                return DAORecetaMedica.GetInstance().ListRecetas();
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
        public DataTable ListRecetaByEmployee(long Id)
        {
            try
            {
                return DAORecetaMedica.GetInstance().ListRecetaByEmployee(Id);
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
