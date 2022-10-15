using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace INSFIT.Migrations
{
    public partial class cadastroeperfil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Mapa",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "perfilId",
                table: "Mapa",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Feed",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Dieta",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "perfilId",
                table: "Dieta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Cadastro",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "perfilId",
                table: "Cadastro",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "relatorio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    peso = table.Column<double>(type: "float", nullable: false),
                    altura = table.Column<double>(type: "float", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: true),
                    perfilId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_relatorio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_relatorio_Usuarios_perfilId",
                        column: x => x.perfilId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mapa_perfilId",
                table: "Mapa",
                column: "perfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Dieta_perfilId",
                table: "Dieta",
                column: "perfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Cadastro_perfilId",
                table: "Cadastro",
                column: "perfilId");

            migrationBuilder.CreateIndex(
                name: "IX_relatorio_perfilId",
                table: "relatorio",
                column: "perfilId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cadastro_Usuarios_perfilId",
                table: "Cadastro",
                column: "perfilId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dieta_Usuarios_perfilId",
                table: "Dieta",
                column: "perfilId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mapa_Usuarios_perfilId",
                table: "Mapa",
                column: "perfilId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cadastro_Usuarios_perfilId",
                table: "Cadastro");

            migrationBuilder.DropForeignKey(
                name: "FK_Dieta_Usuarios_perfilId",
                table: "Dieta");

            migrationBuilder.DropForeignKey(
                name: "FK_Mapa_Usuarios_perfilId",
                table: "Mapa");

            migrationBuilder.DropTable(
                name: "relatorio");

            migrationBuilder.DropIndex(
                name: "IX_Mapa_perfilId",
                table: "Mapa");

            migrationBuilder.DropIndex(
                name: "IX_Dieta_perfilId",
                table: "Dieta");

            migrationBuilder.DropIndex(
                name: "IX_Cadastro_perfilId",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Mapa");

            migrationBuilder.DropColumn(
                name: "perfilId",
                table: "Mapa");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Feed");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Dieta");

            migrationBuilder.DropColumn(
                name: "perfilId",
                table: "Dieta");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Cadastro");

            migrationBuilder.DropColumn(
                name: "perfilId",
                table: "Cadastro");
        }
    }
}
