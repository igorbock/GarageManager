using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using Dapper;
using Microsoft.Data.Sqlite;

namespace GarageManager.Data
{
    public class Repository<T> where T : new()
    {
        private readonly string _tableName;
        private readonly string _keyColumn;
        private readonly PropertyInfo _keyProperty;
        private readonly PropertyInfo[] _properties;
        private static readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
            WriteIndented = false
        };

        public Repository()
        {
            var type = typeof(T);
            var tableAttr = type.GetCustomAttribute<TableAttribute>();
            _tableName = tableAttr?.Name ?? type.Name;
            _properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.CanRead && p.CanWrite).ToArray();
            _keyProperty = _properties.FirstOrDefault(p => p.GetCustomAttribute<KeyAttribute>() != null);
            _keyColumn = _keyProperty?.Name ?? "Id";
        }

        public List<T> GetAll()
        {
            var columns = GetColumnNames();
            using (var conn = GarageDb.OpenConnection())
                return conn.Query<T>($"SELECT {columns} FROM {_tableName} ORDER BY {_keyColumn} DESC").ToList();
        }

        public T GetById(int id)
        {
            var columns = GetColumnNames();
            using (var conn = GarageDb.OpenConnection())
                return conn.QueryFirstOrDefault<T>($"SELECT {columns} FROM {_tableName} WHERE {_keyColumn} = @id", new { id });
        }

        public int Insert(T entity)
        {
            if (IsAuditoriaTable()) return InsertWithoutAudit(entity);
            PreencherEmpresaId(entity);
            var insertProps = GetInsertProperties();
            var columns = string.Join(", ", insertProps.Select(p => GetColumnName(p)));
            var paramNames = string.Join(", ", insertProps.Select(p => "@" + p.Name));
            var parameters = BuildParameters(insertProps, entity);
            using (var conn = GarageDb.OpenConnection())
            using (var tx = conn.BeginTransaction())
            {
                try
                {
                    int id = conn.ExecuteScalar<int>($"INSERT INTO {_tableName} ({columns}) VALUES ({paramNames}); SELECT last_insert_rowid();", parameters, tx);
                    if (_keyProperty != null && _keyProperty.CanWrite)
                    {
                        try { _keyProperty.SetValue(entity, Convert.ChangeType(id, _keyProperty.PropertyType)); } catch { }
                    }
                    Auditar(conn, tx, "INSERT", _tableName, id, null, ToJson(entity));
                    tx.Commit();
                    return id;
                }
                catch { try { tx.Rollback(); } catch { } throw; }
            }
        }

        public void Update(T entity)
        {
            if (IsAuditoriaTable()) { UpdateWithoutAudit(entity); return; }
            PreencherEmpresaId(entity);
            var id = Convert.ToInt32(_keyProperty.GetValue(entity));
            string antigoJson = null;
            try { var antigo = GetById(id); antigoJson = ToJson(antigo); } catch { }
            var updateProps = GetInsertProperties();
            var setClause = string.Join(", ", updateProps.Select(p => $"{GetColumnName(p)} = @{p.Name}"));
            var parameters = BuildParameters(updateProps, entity);
            parameters.Add(_keyColumn, _keyProperty.GetValue(entity));
            string novoJson = ToJson(entity);
            if (antigoJson == novoJson) return;
            using (var conn = GarageDb.OpenConnection())
            using (var tx = conn.BeginTransaction())
            {
                try
                {
                    conn.Execute($"UPDATE {_tableName} SET {setClause} WHERE {_keyColumn} = @{_keyColumn}", parameters, tx);
                    Auditar(conn, tx, "UPDATE", _tableName, id, antigoJson, novoJson);
                    tx.Commit();
                }
                catch { try { tx.Rollback(); } catch { } throw; }
            }
        }

        public void Delete(int id)
        {
            if (IsAuditoriaTable()) { DeleteWithoutAudit(id); return; }
            string antigoJson = null;
            try { var antigo = GetById(id); antigoJson = ToJson(antigo); } catch { }
            using (var conn = GarageDb.OpenConnection())
            using (var tx = conn.BeginTransaction())
            {
                try
                {
                    conn.Execute($"DELETE FROM {_tableName} WHERE {_keyColumn} = @id", new { id }, tx);
                    Auditar(conn, tx, "DELETE", _tableName, id, antigoJson, null);
                    tx.Commit();
                }
                catch { try { tx.Rollback(); } catch { } throw; }
            }
        }

        public bool HasDependency(string foreignTable, string foreignKey, int id)
        {
            using (var conn = GarageDb.OpenConnection())
                return conn.ExecuteScalar<int>($"SELECT COUNT(*) FROM {foreignTable} WHERE {foreignKey} = @id", new { id }) > 0;
        }

        public List<string> Validar(T entity)
        {
            var erros = new List<string>();
            foreach (var prop in _properties)
            {
                if (prop.GetCustomAttribute<KeyAttribute>() != null) continue;
                var required = prop.GetCustomAttribute<RequiredAttribute>();
                if (required == null) continue;
                var value = prop.GetValue(entity);
                var displayName = GetDisplayName(prop);
                if (value == null || (value is string s && string.IsNullOrWhiteSpace(s)))
                    erros.Add(required.ErrorMessage ?? $"O campo \"{displayName}\" é obrigatório.");
            }
            return erros;
        }

        private bool IsAuditoriaTable() => string.Equals(_tableName, "auditoria", StringComparison.OrdinalIgnoreCase);

        private int InsertWithoutAudit(T entity)
        {
            var insertProps = GetInsertProperties();
            var columns = string.Join(", ", insertProps.Select(p => GetColumnName(p)));
            var paramNames = string.Join(", ", insertProps.Select(p => "@" + p.Name));
            var parameters = BuildParameters(insertProps, entity);
            using (var conn = GarageDb.OpenConnection())
                return conn.ExecuteScalar<int>($"INSERT INTO {_tableName} ({columns}) VALUES ({paramNames}); SELECT last_insert_rowid();", parameters);
        }

        private void UpdateWithoutAudit(T entity)
        {
            var updateProps = GetInsertProperties();
            var setClause = string.Join(", ", updateProps.Select(p => $"{GetColumnName(p)} = @{p.Name}"));
            var parameters = BuildParameters(updateProps, entity);
            parameters.Add(_keyColumn, _keyProperty.GetValue(entity));
            using (var conn = GarageDb.OpenConnection())
                conn.Execute($"UPDATE {_tableName} SET {setClause} WHERE {_keyColumn} = @{_keyColumn}", parameters);
        }

        private void DeleteWithoutAudit(int id)
        {
            using (var conn = GarageDb.OpenConnection())
                conn.Execute($"DELETE FROM {_tableName} WHERE {_keyColumn} = @id", new { id });
        }

        private void Auditar(SqliteConnection conn, SqliteTransaction tx, string metodo, string tabela, int idRegistro, string antigo, string novo)
        {
            int uid = Sessao.UsuarioId ?? 1;
            int? eid = Sessao.EmpresaId ?? 1;
            conn.Execute("INSERT INTO auditoria(metodo, tabela, id_registro, antigo, novo, id_usuario, id_empresa) VALUES (@m,@t,@id,@a,@n,@u,@e)",
                new { m = metodo, t = tabela, id = idRegistro, a = antigo, n = novo, u = uid, e = eid }, tx);
        }

        private string ToJson(object obj)
        {
            if (obj == null) return null;
            try { return JsonSerializer.Serialize(obj, obj.GetType(), _jsonOptions); } catch { return null; }
        }

        private void PreencherEmpresaId(T entity)
        {
            var prop = _properties.FirstOrDefault(p => p.Name == "IdEmpresa");
            if (prop != null && prop.PropertyType == typeof(int))
            {
                var val = (int)(prop.GetValue(entity) ?? 0);
                if (val == 0)
                {
                    var eid = Sessao.EmpresaId ?? 1;
                    prop.SetValue(entity, eid);
                }
            }
        }

        private string GetColumnNames() => string.Join(", ", _properties.Select(p => $"{GetColumnName(p)} AS \"{p.Name}\""));
        private PropertyInfo[] GetInsertProperties() => _properties.Where(p => p.GetCustomAttribute<KeyAttribute>() == null).Where(p => p.GetCustomAttribute<NotMappedAttribute>() == null).ToArray();
        private string GetColumnName(PropertyInfo prop) => prop.GetCustomAttribute<ColumnAttribute>()?.Name ?? prop.Name;
        private string GetDisplayName(PropertyInfo prop) => prop.GetCustomAttribute<DisplayNameAttribute>()?.DisplayName ?? prop.Name;
        private DynamicParameters BuildParameters(PropertyInfo[] props, T entity)
        {
            var p = new DynamicParameters();
            foreach (var prop in props) p.Add(prop.Name, prop.GetValue(entity));
            return p;
        }
    }
}
