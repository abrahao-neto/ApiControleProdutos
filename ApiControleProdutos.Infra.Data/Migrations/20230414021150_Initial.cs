using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiControleProdutos.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FORNECEDOR",
                columns: table => new
                {
                    IDFORNECEDOR = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOME = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false),
                    NOMEFANTASIA = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false),
                    RAZAOSOCIAL = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false),
                    Cnpj = table.Column<int>(type: "int", nullable: false),
                    DATAHORACRIACAO = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    DATAHORAALTERACAO = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FORNECEDOR", x => x.IDFORNECEDOR);
                });

            migrationBuilder.CreateTable(
                name: "PRODUTO",
                columns: table => new
                {
                    IDPRODUTO = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NOME = table.Column<string>(type: "NVARCHAR(100)", maxLength: 100, nullable: false),
                    PRECO = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    QUANTIDADE = table.Column<int>(type: "INTEGER", nullable: false),
                    DATAHORACRIACAO = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    DATAHORAALTERACAO = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    IdFornecedor = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRODUTO", x => x.IDPRODUTO);
                    table.ForeignKey(
                        name: "FK_PRODUTO_FORNECEDOR_IdFornecedor",
                        column: x => x.IdFornecedor,
                        principalTable: "FORNECEDOR",
                        principalColumn: "IDFORNECEDOR",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PRODUTO_IdFornecedor",
                table: "PRODUTO",
                column: "IdFornecedor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PRODUTO");

            migrationBuilder.DropTable(
                name: "FORNECEDOR");
        }
    }
}
