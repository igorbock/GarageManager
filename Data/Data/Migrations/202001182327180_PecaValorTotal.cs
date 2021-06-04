namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PecaValorTotal : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pecas", "Valor_total", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pecas", "Valor_total");
        }
    }
}
