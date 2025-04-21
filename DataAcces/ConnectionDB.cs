using MySql.Data.MySqlClient;

namespace DataAcces
{
    public class ConnectionDB
    {
        protected MySqlConnection GetSqlConnection()
        {
            return new MySqlConnection
            {
                ConnectionString = "Server=localhost;Database=CLINICAMEDICA;Uid=root;Pwd=PackCode*503;Port=3306;"
            };
        }
    }
}
