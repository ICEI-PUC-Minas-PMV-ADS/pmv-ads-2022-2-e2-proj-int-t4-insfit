using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace INSFIT.Migrations
{
    public partial class AjusteMapa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mapa_Usuarios_perfilId",
                table: "Mapa");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Mapa");

            migrationBuilder.RenameColumn(
                name: "perfilId",
                table: "Mapa",
                newName: "PerfilId");

            migrationBuilder.RenameIndex(
                name: "IX_Mapa_perfilId",
                table: "Mapa",
                newName: "IX_Mapa_PerfilId");

            migrationBuilder.AlterColumn<int>(
                name: "PerfilId",
                table: "Mapa",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Mapa_Usuarios_PerfilId",
                table: "Mapa",
                column: "PerfilId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mapa_Usuarios_PerfilId",
                table: "Mapa");

            migrationBuilder.RenameColumn(
                name: "PerfilId",
                table: "Mapa",
                newName: "perfilId");

            migrationBuilder.RenameIndex(
                name: "IX_Mapa_PerfilId",
                table: "Mapa",
                newName: "IX_Mapa_perfilId");

            migrationBuilder.AlterColumn<int>(
                name: "perfilId",
                table: "Mapa",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Mapa",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Mapa_Usuarios_perfilId",
                table: "Mapa",
                column: "perfilId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
