namespace GarageManagerAPI.Extensions;

public static class MigrateExtension
{
    public static List<Marca>? Marcas { get; private set; }
    public static List<Modelo>? Modelos { get; private set; }

    public static IHost MigrateDatabase(this IHost host)
    {
        try
        {
            using var scope = host.Services.CreateScope();
            using var contexto = scope.ServiceProvider.GetRequiredService<Context.Modelo>();

            contexto.Database.Migrate();
        }
        catch (Exception)
        {
            //throw;
        }

        return host;
    }

    public static IHost MigrateMarcas(this IHost host)
    {
        try
        {
            using var scope = host.Services.CreateScope();
            using var contexto = scope.ServiceProvider.GetRequiredService<Context.Modelo>();

            using var reader_marca_carros = new StreamReader("Arquivos\\marcas-carros.csv");
            using var reader_marca_motos = new StreamReader("Arquivos\\marcas-motos.csv");
            using var csv_marca_carros = new CsvReader(reader_marca_carros, CultureInfo.InvariantCulture);
            using var csv_marca_motos = new CsvReader(reader_marca_motos, CultureInfo.InvariantCulture);

            Marcas = new List<Marca>();
            Marcas.AddRange(csv_marca_motos.GetRecords<Marca>());
            Marcas.AddRange(csv_marca_carros.GetRecords<Marca>());

            var query_marcas = @"INSERT INTO oficina.marcas (""Id"", ""Nome"") VALUES ";
            var valores = string.Join(",", Marcas.DistinctBy(a => a.Id).OrderBy(a => a.Id).Select(a => string.Format("\n({0}, '{1}')", a.Id, a.Nome)));
            var query = string.Format("{0}{1}", query_marcas, valores);

            contexto.Database.ExecuteSqlRaw(query);
        }
        catch (Exception)
        {
            //throw;
        }

        return host;
    }

    public static IHost MigrateModelos(this IHost host)
    {
        try
        {
            using var scope = host.Services.CreateScope();
            using var contexto = scope.ServiceProvider.GetRequiredService<Context.Modelo>();

            using var reader_modelo_carros = new StreamReader("Arquivos\\modelos-carro.csv");
            using var reader_modelo_motos = new StreamReader("Arquivos\\modelos-moto.csv");
            using var csv_modelo_carros = new CsvReader(reader_modelo_carros, CultureInfo.InvariantCulture);
            using var csv_modelo_motos = new CsvReader(reader_modelo_motos, CultureInfo.InvariantCulture);

            Modelos = new List<Modelo>();
            Modelos.AddRange(csv_modelo_carros.GetRecords<Modelo>());
            Modelos.AddRange(csv_modelo_motos.GetRecords<Modelo>());

            var query_modelos = @"INSERT INTO oficina.modelos (""Id"", ""Nome"", ""IdMarca"") VALUES ";
            var valores = string.Join(",", Modelos!.DistinctBy(a => a.Id).OrderBy(a => a.Id).Select(a => $"\n({a.Id}, '{a.Nome}', {a.IdMarca})"));
            var query = $"{query_modelos}{valores}";

            contexto.Database.ExecuteSqlRaw(query);
        }
        catch (Exception)
        {
            //throw;
        }

        return host;
    }
}
