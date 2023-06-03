using System.Text;

namespace GarageManagerAPI.Helpers;

public static class SqlQueryHelper
{
    private static IEnumerable<Tuple<Type, string, object?>> ObtemTipoNomeEValor(IEntidade entidade)
    {
        foreach (var item in entidade.GetType().GetProperties())
            yield return new Tuple<Type, string, object?>(item.PropertyType, item.Name, item.GetValue(entidade));
    }

    public static string? CriarInsert(string schema_tabela, IEntidade entidade)
    {
        var query = new StringBuilder();
        var TiposNomesEValores = ObtemTipoNomeEValor(entidade);

        query.Append($"INSERT INTO {schema_tabela} (");
        query.AppendJoin(", ", TiposNomesEValores.Select(a => $"\"{a.Item2}\""));
        query.Append(") VALUES (");
        query.ParametrizaOsValoresParaInsert(TiposNomesEValores.ToList());
        query.Append(");");

        return query.ToString();
    }

    public static string? CriarUpdate(string schema_tabela, IEntidade entidade)
    {
        var query = new StringBuilder();
        var TiposNomesEValores = ObtemTipoNomeEValor(entidade);

        query.Append($"UPDATE {schema_tabela} SET ");
        query.ParametrizaOsValoresParaUpdate(TiposNomesEValores.ToList());
        query.Append($" WHERE \"Id\" = {entidade.Id});");

        return query.ToString();
    }
}
