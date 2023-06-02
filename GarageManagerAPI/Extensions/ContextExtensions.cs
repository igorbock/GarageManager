

namespace GarageManagerAPI.Extensions;

public static class ContextExtensions
{
    public static int ExecutarQueryNoBanco(this DatabaseFacade database, E_TipoQuery tipo_query, string nome_tabela, IEntidade entidade, int? id = null)
    {
        Dictionary<Type, object> colunas_valores = new();
        var valores = new List<string>();
        foreach (var item in entidade.GetType().GetProperties())
        {
            colunas_valores.Add(item.PropertyType, item.PropertyType == typeof(string) ? $"\'{item.GetValue(entidade)}\'" : item.GetValue(entidade)!.ToString() ?? "");//item.GetValue(entidade));
            //valores.Add(item.PropertyType == typeof(string) ? $"\'{item.GetValue(entidade)}\'" : item.GetValue(entidade)!.ToString() ?? "");
        }

        var query_insert = $"INSERT INTO {nome_tabela} ({string.Join(", ", $"\"{colunas_valores.Keys}\"")}) VALUES ({string.Join(", ", colunas_valores.Values)});";
        var query_update = $"UPDATE {nome_tabela} SET {string.Join(", ", $"{colunas_valores.Keys} = {colunas_valores.Values}")} WHERE Id = {id};";

        switch(tipo_query)
        {
            case E_TipoQuery.INSERT: return database.ExecuteSqlRaw(query_insert);
            case E_TipoQuery.UPDATE: return database.ExecuteSqlRaw(query_update);
            case E_TipoQuery.DELETE: throw new NotImplementedException();
            default: throw new NotImplementedException();
        }
    }
}
