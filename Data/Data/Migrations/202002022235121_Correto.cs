﻿namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Correto : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Pecas", "Custo_peca");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pecas", "Custo_peca", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
