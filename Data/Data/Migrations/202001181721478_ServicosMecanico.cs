namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ServicosMecanico : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrdemServico", "Servicos_esperados", c => c.String(maxLength: 200));
            AddColumn("dbo.OrdemServico", "Servicos_realizados", c => c.String(maxLength: 200));
            AddColumn("dbo.OrdemServico", "Mecanico", c => c.String(maxLength: 50));
            AddColumn("dbo.OrdemServico", "Status", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrdemServico", "Mecanico");
            DropColumn("dbo.OrdemServico", "Servicos_realizados");
            DropColumn("dbo.OrdemServico", "Servicos_esperados");
            DropColumn("dbo.OrdemServico", "Status");
        }
    }
}
