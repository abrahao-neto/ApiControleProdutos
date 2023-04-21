using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiControleProdutos.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlterTableFornecedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Cnpj",
                table: "FORNECEDOR",
                newName: "CNPJ");

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "FORNECEDOR",
                type: "NVARCHAR(18)",
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CNPJ",
                table: "FORNECEDOR",
                newName: "Cnpj");

            migrationBuilder.AlterColumn<int>(
                name: "Cnpj",
                table: "FORNECEDOR",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR(18)",
                oldMaxLength: 18);
        }
    }
}
