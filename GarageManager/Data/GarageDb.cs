using System;
using System.Configuration;
using System.IO;
using Microsoft.Data.Sqlite;

namespace GarageManager.Data
{
    public static class GarageDb
    {
        private static readonly string ConnectionString;

        static GarageDb()
        {
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["GarageDb"];

            if (settings != null && !string.IsNullOrWhiteSpace(settings.ConnectionString))
            {
                ConnectionString = settings.ConnectionString;
            }
            else
            {
                ConnectionString = "Data Source=|DataDirectory|garage.db";
            }
        }

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
                            Mecanico_id        INTEGER,
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

                        CREATE TABLE IF NOT EXISTS Mecanicos (
                            Id              INTEGER PRIMARY KEY AUTOINCREMENT,
                            Nome            TEXT NOT NULL,
                            Especialidade   TEXT,
                            Telefone        TEXT,
                            Ativo           INTEGER NOT NULL DEFAULT 1
                        );

                        CREATE TABLE IF NOT EXISTS Clientes (
                            Id              INTEGER PRIMARY KEY AUTOINCREMENT,
                            Nome            TEXT NOT NULL,
                            Telefone        TEXT,
                            Email           TEXT,
                            Endereco        TEXT
                        );

                        CREATE TABLE IF NOT EXISTS Servicos (
                            Id              INTEGER PRIMARY KEY AUTOINCREMENT,
                            Descricao       TEXT NOT NULL,
                            ValorBase       NUMERIC NOT NULL DEFAULT 0,
                            TempoEstimado   INTEGER NOT NULL DEFAULT 0
                        );
                    ";
                    command.ExecuteNonQuery();
                }

                TryExecuteSchemaFile(connection);

                EnsureAuditoriaSchema(connection);
                EnsureSeed(connection);

                using (SqliteCommand command = connection.CreateCommand())
                {
                    command.CommandText = @"PRAGMA table_info(OrdemServico);";
                    using (var reader = command.ExecuteReader())
                    {
                        bool hasMecanicoId = false;
                        while (reader.Read())
                        {
                            if (reader["name"].ToString() == "Mecanico_id")
                            {
                                hasMecanicoId = true;
                                break;
                            }
                        }
                        if (!hasMecanicoId)
                        {
                            using (var alterCmd = connection.CreateCommand())
                            {
                                alterCmd.CommandText = "ALTER TABLE OrdemServico ADD COLUMN Mecanico_id INTEGER";
                                alterCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
            }
        }

        private static void TryExecuteSchemaFile(SqliteConnection connection)
        {
            string schemaPath = null;
            var candidates = new[]
            {
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "schema.sql"),
                Path.Combine(Path.GetDirectoryName(typeof(GarageDb).Assembly.Location) ?? "", "Data", "schema.sql"),
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "schema.sql"),
                Path.Combine(Directory.GetCurrentDirectory(), "GarageManager", "Data", "schema.sql"),
                Path.Combine(Directory.GetCurrentDirectory(), "Data", "schema.sql"),
                @"D:\Projetos\Pessoal\GarageManager\GarageManager\Data\schema.sql"
            };
            foreach (var p in candidates) if (File.Exists(p)) { schemaPath = p; break; }
            if (schemaPath == null) return;
            try
            {
                string sql = File.ReadAllText(schemaPath);
                if (string.IsNullOrWhiteSpace(sql)) return;
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
            }
            catch { }
        }

        private static void EnsureAuditoriaSchema(SqliteConnection connection)
        {
            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = "SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name='auditoria'";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) return;
                cmd.CommandText = "PRAGMA table_info(auditoria)";
                bool hasEmpresa = false;
                using (var r = cmd.ExecuteReader())
                    while (r.Read()) if (r["name"].ToString() == "id_empresa") { hasEmpresa = true; break; }
                if (!hasEmpresa)
                {
                    using (var alter = connection.CreateCommand())
                    {
                        alter.CommandText = "ALTER TABLE auditoria ADD COLUMN id_empresa INTEGER REFERENCES empresa(id) ON DELETE SET NULL";
                        try { alter.ExecuteNonQuery(); } catch { }
                    }
                }
            }
            foreach (var idx in new[] {
                "CREATE INDEX IF NOT EXISTS idx_auditoria_tabela_registro ON auditoria(tabela, id_registro)",
                "CREATE INDEX IF NOT EXISTS idx_auditoria_empresa_data ON auditoria(id_empresa, data_hora DESC)",
                "CREATE INDEX IF NOT EXISTS idx_auditoria_usuario ON auditoria(id_usuario)",
                "CREATE VIEW IF NOT EXISTS vw_auditoria_detalhada AS SELECT a.id, a.metodo, a.tabela, a.id_registro, a.antigo, a.novo, a.id_usuario, a.id_empresa, a.data_hora, p.nome AS usuario_nome, e.nome AS empresa_nome, f.id AS id_funcionario FROM auditoria a JOIN usuario u ON u.id=a.id_usuario JOIN funcionario f ON f.id=u.id_colaborador JOIN pessoa p ON p.id=f.id_pessoa LEFT JOIN empresa e ON e.id=a.id_empresa"
            })
            {
                using (var cmd = connection.CreateCommand()) { cmd.CommandText = idx; try { cmd.ExecuteNonQuery(); } catch { } }
            }
        }

        private static void EnsureSeed(SqliteConnection connection)
        {
            using (var cmd = connection.CreateCommand())
            {
                cmd.CommandText = "SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name='empresa'";
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 0) return;
                cmd.CommandText = "INSERT OR IGNORE INTO empresa(id, nome, razao_social, cnpj, guid_empresa) VALUES (1, 'Matriz', 'Matriz LTDA', '00000000000191', lower(hex(randomblob(16))))";
                try { cmd.ExecuteNonQuery(); } catch { }
                cmd.CommandText = "INSERT OR IGNORE INTO pessoa(id, nome) VALUES (1, 'Admin')";
                try { cmd.ExecuteNonQuery(); } catch { }
                cmd.CommandText = "INSERT OR IGNORE INTO funcionario(id, id_pessoa, id_empresa, carga_horaria_semanal) VALUES (1, 1, 1, 44)";
                try { cmd.ExecuteNonQuery(); } catch { }
                cmd.CommandText = "INSERT OR IGNORE INTO usuario(id, hash, id_colaborador) VALUES (1, 'seed', 1)";
                try { cmd.ExecuteNonQuery(); } catch { }
                Sessao.UsuarioId = Sessao.UsuarioId ?? 1;
                Sessao.EmpresaId = Sessao.EmpresaId ?? 1;
            }
        }
    }
}