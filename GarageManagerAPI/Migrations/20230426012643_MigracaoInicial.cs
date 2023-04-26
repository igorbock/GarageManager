using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GarageManagerAPI.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "oficina");

            migrationBuilder.CreateTable(
                name: "clientes",
                schema: "oficina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Telefone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    CPF = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "marcas",
                schema: "oficina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marcas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pecas",
                schema: "oficina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    Marca = table.Column<string>(type: "text", nullable: true),
                    Quantidade = table.Column<decimal>(type: "numeric", nullable: false),
                    Valor = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pecas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "modelos",
                schema: "oficina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    IdMarca = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_modelos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_modelos_marcas_IdMarca",
                        column: x => x.IdMarca,
                        principalSchema: "oficina",
                        principalTable: "marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "veiculos",
                schema: "oficina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Placa = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false),
                    Cor = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: true),
                    Ano = table.Column<int>(type: "integer", nullable: true),
                    Km = table.Column<decimal>(type: "numeric", nullable: true),
                    IdModelo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_veiculos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_veiculos_modelos_IdModelo",
                        column: x => x.IdModelo,
                        principalSchema: "oficina",
                        principalTable: "modelos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ordem_servico",
                schema: "oficina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Inicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Fim = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Esperados = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Realizados = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Mecanico = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    Lavacao = table.Column<bool>(type: "boolean", nullable: true),
                    Pagamento = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    IdVeiculo = table.Column<int>(type: "integer", nullable: false),
                    IdCliente = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordem_servico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ordem_servico_clientes_IdCliente",
                        column: x => x.IdCliente,
                        principalSchema: "oficina",
                        principalTable: "clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ordem_servico_veiculos_IdVeiculo",
                        column: x => x.IdVeiculo,
                        principalSchema: "oficina",
                        principalTable: "veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ordens_pecas",
                schema: "oficina",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdOrdemServico = table.Column<int>(type: "integer", nullable: false),
                    IdPeca = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordens_pecas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ordens_pecas_ordem_servico_IdOrdemServico",
                        column: x => x.IdOrdemServico,
                        principalSchema: "oficina",
                        principalTable: "ordem_servico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ordens_pecas_pecas_IdPeca",
                        column: x => x.IdPeca,
                        principalSchema: "oficina",
                        principalTable: "pecas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_modelos_IdMarca",
                schema: "oficina",
                table: "modelos",
                column: "IdMarca");

            migrationBuilder.CreateIndex(
                name: "IX_ordem_servico_IdCliente",
                schema: "oficina",
                table: "ordem_servico",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_ordem_servico_IdVeiculo",
                schema: "oficina",
                table: "ordem_servico",
                column: "IdVeiculo");

            migrationBuilder.CreateIndex(
                name: "IX_ordens_pecas_IdOrdemServico",
                schema: "oficina",
                table: "ordens_pecas",
                column: "IdOrdemServico");

            migrationBuilder.CreateIndex(
                name: "IX_ordens_pecas_IdPeca",
                schema: "oficina",
                table: "ordens_pecas",
                column: "IdPeca");

            migrationBuilder.CreateIndex(
                name: "IX_veiculos_IdModelo",
                schema: "oficina",
                table: "veiculos",
                column: "IdModelo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ordens_pecas",
                schema: "oficina");

            migrationBuilder.DropTable(
                name: "ordem_servico",
                schema: "oficina");

            migrationBuilder.DropTable(
                name: "pecas",
                schema: "oficina");

            migrationBuilder.DropTable(
                name: "clientes",
                schema: "oficina");

            migrationBuilder.DropTable(
                name: "veiculos",
                schema: "oficina");

            migrationBuilder.DropTable(
                name: "modelos",
                schema: "oficina");

            migrationBuilder.DropTable(
                name: "marcas",
                schema: "oficina");
        }
    }
}
