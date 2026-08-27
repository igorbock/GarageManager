using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using Dapper;

namespace GarageManager.Data
{
    public class Repository<T> where T : new()
    {
        private readonly string _tableName;
        private readonly string _keyColumn;
        private readonly PropertyInfo _keyProperty;
        private readonly PropertyInfo[] _properties;

        public Repository()
        {
            var type = typeof(T);

            var tableAttr = type.GetCustomAttribute<TableAttribute>();
            _tableName = tableAttr?.Name ?? type.Name;

            _properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(p => p.CanRead && p.CanWrite)
                .ToArray();

            _keyProperty = _properties.FirstOrDefault(p => p.GetCustomAttribute<KeyAttribute>() != null);
            _keyColumn = _keyProperty?.Name ?? "Id";
        }

        public List<T> GetAll()
        {
            var columns = GetColumnNames();
            using (var conn = GarageDb.OpenConnection())
            {
                return conn.Query<T>($"SELECT {columns} FROM {_tableName} ORDER BY {_keyColumn} DESC").ToList();
            }
        }

        public T GetById(int id)
        {
            var columns = GetColumnNames();
            using (var conn = GarageDb.OpenConnection())
            {
                return conn.QueryFirstOrDefault<T>(
                    $"SELECT {columns} FROM {_tableName} WHERE {_keyColumn} = @id",
                    new { id });
            }
        }

        public int Insert(T entity)
        {
            var insertProps = GetInsertProperties();
            var columns = string.Join(", ", insertProps.Select(p => GetColumnName(p)));
            var paramNames = string.Join(", ", insertProps.Select(p => "@" + p.Name));
            var parameters = BuildParameters(insertProps, entity);

            using (var conn = GarageDb.OpenConnection())
            {
                return conn.ExecuteScalar<int>(
                    $"INSERT INTO {_tableName} ({columns}) VALUES ({paramNames}); SELECT last_insert_rowid();",
                    parameters);
            }
        }

        public void Update(T entity)
        {
            var updateProps = GetInsertProperties();
            var setClause = string.Join(", ", updateProps.Select(p => $"{GetColumnName(p)} = @{p.Name}"));
            var parameters = BuildParameters(updateProps, entity);

            var keyValue = _keyProperty.GetValue(entity);
            parameters.Add(_keyColumn, keyValue);

            using (var conn = GarageDb.OpenConnection())
            {
                conn.Execute(
                    $"UPDATE {_tableName} SET {setClause} WHERE {_keyColumn} = @{_keyColumn}",
                    parameters);
            }
        }

        public void Delete(int id)
        {
            using (var conn = GarageDb.OpenConnection())
            {
                conn.Execute($"DELETE FROM {_tableName} WHERE {_keyColumn} = @id", new { id });
            }
        }

        public bool HasDependency(string foreignTable, string foreignKey, int id)
        {
            using (var conn = GarageDb.OpenConnection())
            {
                int count = conn.ExecuteScalar<int>(
                    $"SELECT COUNT(*) FROM {foreignTable} WHERE {foreignKey} = @id",
                    new { id });
                return count > 0;
            }
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

                if (value == null)
                {
                    erros.Add(required.ErrorMessage ?? $"O campo \"{displayName}\" é obrigatório.");
                }
                else if (value is string str && string.IsNullOrWhiteSpace(str))
                {
                    erros.Add(required.ErrorMessage ?? $"O campo \"{displayName}\" é obrigatório.");
                }
            }

            return erros;
        }

        private string GetColumnNames()
        {
            return string.Join(", ", _properties.Select(p => GetColumnName(p)));
        }

        private PropertyInfo[] GetInsertProperties()
        {
            return _properties
                .Where(p => p.GetCustomAttribute<KeyAttribute>() == null)
                .Where(p => p.GetCustomAttribute<NotMappedAttribute>() == null)
                .ToArray();
        }

        private string GetColumnName(PropertyInfo prop)
        {
            var colAttr = prop.GetCustomAttribute<ColumnAttribute>();
            return colAttr?.Name ?? prop.Name;
        }

        private string GetDisplayName(PropertyInfo prop)
        {
            var displayAttr = prop.GetCustomAttribute<DisplayNameAttribute>();
            return displayAttr?.DisplayName ?? prop.Name;
        }

        private DynamicParameters BuildParameters(PropertyInfo[] props, T entity)
        {
            var parameters = new DynamicParameters();
            foreach (var prop in props)
            {
                parameters.Add(prop.Name, prop.GetValue(entity));
            }
            return parameters;
        }
    }
}
