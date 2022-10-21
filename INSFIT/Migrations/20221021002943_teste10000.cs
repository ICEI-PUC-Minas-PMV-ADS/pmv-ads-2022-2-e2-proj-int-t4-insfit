using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace INSFIT.Migrations
{
    public partial class teste10000 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cadastro",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "cadastroid_cadastro",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_cadastroid_cadastro",
                table: "Usuarios",
                column: "cadastroid_cadastro");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Cadastro_cadastroid_cadastro",
                table: "Usuarios",
                column: "cadastroid_cadastro",
                principalTable: "Cadastro",
                principalColumn: "id_cadastro",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Cadastro_cadastroid_cadastro",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_cadastroid_cadastro",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Cadastro",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "cadastroid_cadastro",
                table: "Usuarios");
        }
    }
}
