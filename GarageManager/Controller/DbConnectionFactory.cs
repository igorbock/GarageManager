using System.Data;
using Npgsql;

namespace GarageManager.Controller
{
    public class DbConnectionFactory
    {
        private readonly string _connectionString;

        public DbConnectionFactory()
        {
            _connectionString =
                "Host=localhost;" +
                "Port=5432;" +
                "Database=postgres;" +
                "Username=postgres;" +
                "Password=postgres;";
        }

        public IDbConnection CreateConnection()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}