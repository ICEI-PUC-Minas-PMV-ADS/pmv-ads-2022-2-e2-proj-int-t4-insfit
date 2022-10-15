using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace INSFIT.Migrations
{
    public partial class criandovinculoUsarioefeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Feed");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Feed",
                type: "int",
                nullable: true);
        }
    }
}
