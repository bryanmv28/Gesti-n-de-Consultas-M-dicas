using System.Data;
using MySql.Data.MySqlClient;

namespace ClinicaMedica.Config
{
    public class Conexion
    {
        private readonly string _connectionString = "server=localhost;database=clinica_medica;uid=root;pwd=;";

        public IDbConnection AbrirConexion()
        {
            IDbConnection connection = new MySqlConnection(_connectionString);
            connection.Open();
            return connection;
        }
    }
}