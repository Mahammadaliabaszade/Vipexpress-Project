using Microsoft.EntityFrameworkCore.Migrations;

namespace Vipexfinal.Migrations
{
    public partial class Beyannametwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OlkeName",
                table: "Beyanname");

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Beyanname",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link",
                table: "Beyanname");

            migrationBuilder.AddColumn<string>(
                name: "OlkeName",
                table: "Beyanname",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
