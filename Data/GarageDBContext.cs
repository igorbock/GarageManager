using System.Data.Entity;
using Domain;

namespace Data
{
    public class GarageDBContext : DbContext
    {
        public GarageDBContext() : base("Name=GarageDB")
        {
            Database.SetInitializer<GarageDBContext>(new CreateDatabaseIfNotExists<GarageDBContext>());
            Database.Initialize(false);

            
        }

        public DbSet<OrdemServico> OrdensServicos { get; set; }
        public DbSet<Peca> Pecas { get; set; }
    }
}
