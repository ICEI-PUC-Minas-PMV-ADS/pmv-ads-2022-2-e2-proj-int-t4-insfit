using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace INSFIT.Migrations
{
    public partial class Relatorio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "relatorio",
                columns: table => new
                {
                    Id_relatorio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    peso = table.Column<double>(type: "float", nullable: false),
                    altura = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_relatorio", x => x.Id_relatorio);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "relatorio");
        }
    }
}
