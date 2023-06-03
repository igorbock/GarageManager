namespace GarageManagerAPI.Extensions;

public static class StringBuilderExtensions
{
    public static void ParametrizaOsValoresParaInsert(this StringBuilder builder, IList<Tuple<Type,string, object?>> tipos_e_valores) 
        => builder.AppendJoin(", ", ParametrizaValores(tipos_e_valores));

    public static void ParametrizaOsValoresParaUpdate(this StringBuilder builder, IList<Tuple<Type, string, object?>> tipos_e_valores)
        => builder.AppendJoin(", ", ParametrizaColunasComValores(tipos_e_valores));

    private static IEnumerable<string> ParametrizaValores(IList<Tuple<Type, string, object?>> tipos_e_valores)
    {
        foreach (var item in tipos_e_valores)
        {
            var valor = item.Item3!.ToString();
            if (string.IsNullOrWhiteSpace(valor) || valor == "0")
                continue;

            if (item.Item1 == typeof(string) || item.Item1 == typeof(DateTime))
                yield return $"\'{item.Item3}\'";
            else
                yield return $"{item.Item3}";
        }
    }

    private static IEnumerable<string> ParametrizaColunasComValores(IList<Tuple<Type, string, object?>> tipos_e_valores)
    {
        foreach (var item in tipos_e_valores)
        {
            if (item.Item1 == typeof(string) || item.Item1 == typeof(DateTime))
                yield return $"\"{item.Item2}\" = \'{item.Item3}\'";
            else
                yield return $"\"{item.Item2}\" = {item.Item3}";
        }
    }
}
