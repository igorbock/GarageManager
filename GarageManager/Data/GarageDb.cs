using System.Configuration;
using Microsoft.Data.Sqlite;

namespace GarageManager.Data
{
    public static class GarageDb
    {
        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["GarageDb"].ConnectionString;

        public static SqliteConnection OpenConnection()
        {
            SqliteConnection connection = new SqliteConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        public static void EnsureCreated()
        {
            using (SqliteConnection connection = OpenConnection())
            {
                using (SqliteCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"
                        CREATE TABLE IF NOT EXISTS OrdemServico (
                            Id                 INTEGER PRIMARY KEY AUTOINCREMENT,
                            HoraInicio         TEXT,
                            DataInicio         TEXT,
                            HoraFim            TEXT,
                            DataFim            TEXT,
                            Placa_veiculo      TEXT NOT NULL,
                            Modelo_veiculo     TEXT,
                            Cor_veiculo        TEXT,
                            Ano_veiculo        TEXT,
                            Km_veiculo         TEXT,
                            Nome_cliente       TEXT NOT NULL,
                            Telefone_cliente   TEXT NOT NULL,
                            Servicos_esperados TEXT,
                            Servicos_realizados TEXT,
                            Mecanico           TEXT,
                            Status             TEXT,
                            Lavacao            INTEGER NOT NULL DEFAULT 0,
                            Pagamento          TEXT
                        );

                        CREATE TABLE IF NOT EXISTS Pecas (
                            Id              INTEGER PRIMARY KEY AUTOINCREMENT,
                            Descricao_peca  TEXT NOT NULL,
                            Marca_peca      TEXT,
                            Quantidade_peca NUMERIC NOT NULL,
                            Valor_peca      NUMERIC NOT NULL,
                            Valor_total     TEXT,
                            OrdemServicoId  INTEGER NOT NULL,
                            FOREIGN KEY (OrdemServicoId) REFERENCES OrdemServico(Id) ON DELETE CASCADE
                        );

                        CREATE INDEX IF NOT EXISTS IX_Pecas_OrdemServicoId ON Pecas(OrdemServicoId);
                    ";
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}