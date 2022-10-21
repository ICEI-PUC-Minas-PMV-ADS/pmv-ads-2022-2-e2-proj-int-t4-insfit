using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace INSFIT.Migrations
{
    public partial class ercf3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cadastro",
                columns: table => new
                {
                    id_cadastro = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<int>(type: "int", nullable: false),
                    senha = table.Column<int>(type: "int", nullable: false),
                    tipoUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastro", x => x.id_cadastro);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Altura = table.Column<double>(type: "float", nullable: false),
                    Peso = table.Column<double>(type: "float", nullable: false),
                    Telefone = table.Column<int>(type: "int", nullable: false),
                    Usuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dieta",
                columns: table => new
                {
                    Id_Dieta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampoImgem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampodePesquisa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataPublicacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: true),
                    perfilId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dieta", x => x.Id_Dieta);
                    table.ForeignKey(
                        name: "FK_Dieta_Usuarios_perfilId",
                        column: x => x.perfilId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feed",
                columns: table => new
                {
                    Id_Feed = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CampoTexto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampoImgem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CampodePesquisa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataPublicacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: true),
                    perfilId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feed", x => x.Id_Feed);
                    table.ForeignKey(
                        name: "FK_Feed_Usuarios_perfilId",
                        column: x => x.perfilId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "relatorio",
                columns: table => new
                {
                    Id_relatorio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    peso = table.Column<double>(type: "float", nullable: false),
                    altura = table.Column<double>(type: "float", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: true),
                    perfilId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_relatorio", x => x.Id_relatorio);
                    table.ForeignKey(
                        name: "FK_relatorio_Usuarios_perfilId",
                        column: x => x.perfilId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dieta_perfilId",
                table: "Dieta",
                column: "perfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Feed_perfilId",
                table: "Feed",
                column: "perfilId");

            migrationBuilder.CreateIndex(
                name: "IX_relatorio_perfilId",
                table: "relatorio",
                column: "perfilId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cadastro");

            migrationBuilder.DropTable(
                name: "Dieta");

            migrationBuilder.DropTable(
                name: "Feed");

            migrationBuilder.DropTable(
                name: "relatorio");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
