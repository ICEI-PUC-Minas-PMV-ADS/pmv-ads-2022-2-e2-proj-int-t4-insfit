using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace INSFIT.Migrations
{
    public partial class ajusteCadastro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "relatorio",
                newName: "Id_relatorio");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Cadastro",
                newName: "id_cadastro");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id_relatorio",
                table: "relatorio",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "id_cadastro",
                table: "Cadastro",
                newName: "id");
        }
    }
}
