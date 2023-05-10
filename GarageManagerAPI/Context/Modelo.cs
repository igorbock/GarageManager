namespace GarageManagerAPI.Context;

public class Modelo : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=postgres;User Id=postgres;Password=teste");

        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OrdemServico>().ToTable("ordem_servico", "oficina");
        modelBuilder.Entity<Peca>().ToTable("pecas", "oficina");
        modelBuilder.Entity<Veiculo>().ToTable("veiculos", "oficina");
        modelBuilder.Entity<Marca>().ToTable("marcas", "oficina");
        modelBuilder.Entity<GarageManagerLib.Models.Modelo>().ToTable("modelos", "oficina");
        modelBuilder.Entity<Cliente>().ToTable("clientes", "oficina");
        modelBuilder.Entity<OrdemServicoPecas>().ToTable("ordens_pecas", "oficina");

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<OrdemServico>? OrdensServico { get; set; }
    public DbSet<Peca>? Pecas { get; set; }
    public DbSet<Veiculo>? Veiculos { get; set; }
    public DbSet<Marca>? Marcas { get; set; }
    public DbSet<GarageManagerLib.Models.Modelo>? Modelos { get; set; }
    public DbSet<Cliente>? Clientes { get; set; }
    public DbSet<OrdemServicoPecas>? OrdensServicoPecas { get; set; }
}
