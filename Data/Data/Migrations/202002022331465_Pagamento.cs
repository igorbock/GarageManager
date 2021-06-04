namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Pagamento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrdemServico", "Pagamento", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrdemServico", "Pagamento");
        }
    }
}
