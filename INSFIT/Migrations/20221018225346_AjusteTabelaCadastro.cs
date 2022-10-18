using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace INSFIT.Migrations
{
    public partial class AjusteTabelaCadastro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cadastro_Usuarios_perfilId",
                table: "Cadastro");

            migrationBuilder.DropIndex(
                name: "IX_Cadastro_perfilId",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Cadastro");

            migrationBuilder.RenameColumn(
                name: "perfilId",
                table: "Cadastro",
                newName: "tipoUsuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tipoUsuario",
                table: "Cadastro",
                newName: "perfilId");

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Cadastro",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cadastro_perfilId",
                table: "Cadastro",
                column: "perfilId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cadastro_Usuarios_perfilId",
                table: "Cadastro",
                column: "perfilId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
