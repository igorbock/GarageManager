namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Lavacao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.OrdemServico", "Lavacao", c => c.Boolean(defaultValue:false, nullable:true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.OrdemServico", "Lavacao");
        }
    }
}
