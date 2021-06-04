namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Status : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.OrdemServico", "Status", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.OrdemServico", "Status", c => c.String());
        }
    }
}
