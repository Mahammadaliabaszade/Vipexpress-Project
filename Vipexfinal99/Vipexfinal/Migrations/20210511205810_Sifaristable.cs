using Microsoft.EntityFrameworkCore.Migrations;

namespace Vipexfinal.Migrations
{
    public partial class Sifaristable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fastoffer",
                table: "Sifaris");

            migrationBuilder.DropColumn(
                name: "Qaydalarrazi",
                table: "Sifaris");

            migrationBuilder.DropColumn(
                name: "Tesdiq",
                table: "Sifaris");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Fastoffer",
                table: "Sifaris",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Qaydalarrazi",
                table: "Sifaris",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Tesdiq",
                table: "Sifaris",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
