using Microsoft.EntityFrameworkCore.Migrations;

namespace Vipexfinal.Migrations
{
    public partial class Sonweb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Webpages",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Categories",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Webpages");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Categories");
        }
    }
}
