using Npgsql;
using System;
using System.Data;
using System.Data.SqlClient;

namespace GarageManager.Database
{
    public static class DatabaseManager
    {
        public static DataTable Consultar(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                using (var connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=localhost;"))
                {
                    connection.Open();
                    using (var command = new NpgsqlCommand(sql, connection))
                    {
                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar a consulta: {ex.Message}");
            }
            return dt;
        }
        public static void Executar(string sql)
        {
            try
            {
                using (var connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=localhost;"))
                {
                    connection.Open();
                    using (var command = new NpgsqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao executar a operação: {ex.Message}");
            }
        }
    }
}
