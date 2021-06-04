namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MaxLengthControles : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrdemServico", "Servicos_esperados", c => c.String(maxLength: 500));
            AlterColumn("dbo.OrdemServico", "Servicos_realizados", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrdemServico", "Servicos_realizados", c => c.String(maxLength: 200));
            AlterColumn("dbo.OrdemServico", "Servicos_esperados", c => c.String(maxLength: 200));
        }
    }
}
