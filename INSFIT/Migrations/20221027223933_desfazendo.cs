using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace INSFIT.Migrations
{
    public partial class desfazendo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dieta_Usuarios_perfilId",
                table: "Dieta");

            migrationBuilder.DropForeignKey(
                name: "FK_Feed_Usuarios_perfilId",
                table: "Feed");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Cadastro_cadastroid_cadastro",
                table: "Usuarios");

            migrationBuilder.DropTable(
                name: "relatorio");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_cadastroid_cadastro",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Feed_perfilId",
                table: "Feed");

            migrationBuilder.DropIndex(
                name: "IX_Dieta_perfilId",
                table: "Dieta");

            migrationBuilder.DropColumn(
                name: "Cadastro",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "cadastroid_cadastro",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Feed");

            migrationBuilder.DropColumn(
                name: "perfilId",
                table: "Feed");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Dieta");

            migrationBuilder.DropColumn(
                name: "perfilId",
                table: "Dieta");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "relatorio",
                columns: table => new
                {
                    Id_relatorio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    perfilId = table.Column<int>(type: "int", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: true),
                    altura = table.Column<double>(type: "float", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    peso = table.Column<double>(type: "float", nullable: false)
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
                name: "IX_Usuarios_cadastroid_cadastro",
                table: "Usuarios",
                column: "cadastroid_cadastro");

            migrationBuilder.CreateIndex(
                name: "IX_Feed_perfilId",
                table: "Feed",
                column: "perfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Dieta_perfilId",
                table: "Dieta",
                column: "perfilId");

            migrationBuilder.CreateIndex(
                name: "IX_relatorio_perfilId",
                table: "relatorio",
                column: "perfilId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dieta_Usuarios_perfilId",
                table: "Dieta",
                column: "perfilId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Feed_Usuarios_perfilId",
                table: "Feed",
                column: "perfilId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Cadastro_cadastroid_cadastro",
                table: "Usuarios",
                column: "cadastroid_cadastro",
                principalTable: "Cadastro",
                principalColumn: "id_cadastro",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
