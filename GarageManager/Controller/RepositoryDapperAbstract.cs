using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Dapper;
using Dominio.Interfaces;

namespace GarageManager.Controller
{
    public abstract class RepositoryDapperAbstract<TypeT> where TypeT : class, IEntidade
    {
        private readonly DbConnectionFactory _connectionFactory;

        private static readonly string TableName;
        private static readonly string KeyColumn;
        private static readonly string KeyPropertyName;
        private static readonly IReadOnlyList<ColumnMap> Columns;
        private static readonly string SelectColumns;

        static RepositoryDapperAbstract()
        {
            var type = typeof(TypeT);

            var tableAttribute = type.GetCustomAttribute<TableAttribute>();
            TableName = tableAttribute?.Name ?? type.Name;

            var maps = new List<ColumnMap>();
            foreach (var property in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (property.GetCustomAttribute<NotMappedAttribute>() != null)
                    continue;

                var columnAttribute = property.GetCustomAttribute<ColumnAttribute>();
                var isKey = property.GetCustomAttribute<KeyAttribute>() != null ||
                            property.Name.Equals(nameof(IEntidade.Id), StringComparison.OrdinalIgnoreCase);

                if (columnAttribute == null && !isKey)
                    continue;

                var columnName = columnAttribute?.Name ?? property.Name;

                if (isKey && KeyColumn == null)
                {
                    KeyColumn = columnName;
                    KeyPropertyName = property.Name;
                }

                maps.Add(new ColumnMap(property, columnName));
            }

            Columns = maps;
            SelectColumns = string.Join(", ", maps.Select(m => $"{m.ColumnName} AS {m.Property.Name}"));
        }

        protected RepositoryDapperAbstract()
        {
            _connectionFactory = new DbConnectionFactory();
        }

        protected RepositoryDapperAbstract(DbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory ?? throw new ArgumentNullException(nameof(connectionFactory));
        }

        public virtual async Task<IEnumerable<TypeT>> GetAllAsync()
        {
            var sql = $"SELECT {SelectColumns} FROM {TableName}";

            using (var connection = _connectionFactory.CreateConnection())
            {
                return await connection.QueryAsync<TypeT>(sql);
            }
        }

        public virtual async Task<TypeT> GetByIdAsync(long id)
        {
            EnsureMapped();
            var sql = $"SELECT {SelectColumns} FROM {TableName} WHERE {KeyColumn} = @Id";

            using (var connection = _connectionFactory.CreateConnection())
            {
                return await connection.QueryFirstOrDefaultAsync<TypeT>(sql, new { Id = id });
            }
        }

        public virtual async Task<TypeT> InsertAsync(TypeT entity)
        {
            EnsureMapped();
            var insertable = Columns.Where(m => m.Property.Name != KeyPropertyName).ToList();
            var columns = string.Join(", ", insertable.Select(m => m.ColumnName));
            var parameters = string.Join(", ", insertable.Select(m => "@" + m.Property.Name));
            var sql = $"INSERT INTO {TableName} ({columns}) VALUES ({parameters}) RETURNING {KeyColumn}";

            using (var connection = _connectionFactory.CreateConnection())
            {
                var newId = await connection.ExecuteScalarAsync<long>(sql, entity);
                typeof(TypeT).GetProperty(KeyPropertyName)?.SetValue(entity, newId);
                return entity;
            }
        }

        public virtual async Task<TypeT> UpdateAsync(TypeT entity)
        {
            EnsureMapped();
            var settable = Columns.Where(m => m.Property.Name != KeyPropertyName);
            var setClause = string.Join(", ", settable.Select(m => $"{m.ColumnName} = @{m.Property.Name}"));
            var sql = $"UPDATE {TableName} SET {setClause} WHERE {KeyColumn} = @{KeyPropertyName}";

            using (var connection = _connectionFactory.CreateConnection())
            {
                await connection.ExecuteAsync(sql, entity);
                return entity;
            }
        }

        public virtual async Task<bool> DeleteAsync(long id)
        {
            EnsureMapped();
            var sql = $"DELETE FROM {TableName} WHERE {KeyColumn} = @Id";

            using (var connection = _connectionFactory.CreateConnection())
            {
                var affected = await connection.ExecuteAsync(sql, new { Id = id });
                return affected > 0;
            }
        }

        private void EnsureMapped()
        {
            if (string.IsNullOrEmpty(KeyColumn))
                throw new InvalidOperationException(
                    $"Nenhuma chave ([Key]/Id) foi encontrada para a entidade {typeof(TypeT).Name}.");
        }

        private sealed class ColumnMap
        {
            public PropertyInfo Property { get; }
            public string ColumnName { get; }

            public ColumnMap(PropertyInfo property, string columnName)
            {
                Property = property;
                ColumnName = columnName;
            }
        }
    }
}
