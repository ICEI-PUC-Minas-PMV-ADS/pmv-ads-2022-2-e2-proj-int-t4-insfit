using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace INSFIT.Migrations
{
    public partial class criandovinculoUsarioefedd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Feed",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "perfilId",
                table: "Feed",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Dieta",
                columns: table => new
                {
                    Id_Dieta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampoImgem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampodePesquisa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataPublicacao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dieta", x => x.Id_Dieta);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Feed_perfilId",
                table: "Feed",
                column: "perfilId");

            migrationBuilder.AddForeignKey(
                name: "FK_Feed_Usuarios_perfilId",
                table: "Feed",
                column: "perfilId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Feed_Usuarios_perfilId",
                table: "Feed");

            migrationBuilder.DropTable(
                name: "Dieta");

            migrationBuilder.DropIndex(
                name: "IX_Feed_perfilId",
                table: "Feed");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Feed");

            migrationBuilder.DropColumn(
                name: "perfilId",
                table: "Feed");
        }
    }
}
