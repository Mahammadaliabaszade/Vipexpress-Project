using Microsoft.EntityFrameworkCore.Migrations;

namespace Vipexfinal.Migrations
{
    public partial class Bioss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Facebooklink",
                table: "Bio",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Instagramlink",
                table: "Bio",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Facebooklink",
                table: "Bio");

            migrationBuilder.DropColumn(
                name: "Instagramlink",
                table: "Bio");
        }
    }
}
