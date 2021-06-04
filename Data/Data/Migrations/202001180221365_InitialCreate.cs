namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OrdemServico",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HoraInicio = c.String(maxLength: 10),
                        DataInicio = c.String(maxLength: 10),
                        HoraFim = c.String(maxLength: 10),
                        DataFim = c.String(maxLength: 10),
                        Placa_veiculo = c.String(nullable: false, maxLength: 7),
                        Modelo_veiculo = c.String(maxLength: 100),
                        Cor_veiculo = c.String(maxLength: 30),
                        Ano_veiculo = c.String(maxLength: 20),
                        Km_veiculo = c.String(maxLength: 10),
                        Nome_cliente = c.String(nullable: false, maxLength: 100),
                        Telefone_cliente = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pecas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao_peca = c.String(nullable: false, maxLength: 100),
                        Marca_peca = c.String(maxLength: 50),
                        Quantidade_peca = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Valor_peca = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrdemServicoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrdemServico", t => t.OrdemServicoId, cascadeDelete: true)
                .Index(t => t.OrdemServicoId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pecas", "OrdemServicoId", "dbo.OrdemServico");
            DropIndex("dbo.Pecas", new[] { "OrdemServicoId" });
            DropTable("dbo.Pecas");
            DropTable("dbo.OrdemServico");
        }
    }
}
