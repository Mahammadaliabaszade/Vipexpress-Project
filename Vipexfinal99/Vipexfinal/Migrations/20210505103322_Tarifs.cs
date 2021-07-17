using Microsoft.EntityFrameworkCore.Migrations;

namespace Vipexfinal.Migrations
{
    public partial class Tarifs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cekitwo",
                table: "Tarifusas",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Cekitwo",
                table: "TarifTurkeys",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cekitwo",
                table: "Tarifusas");

            migrationBuilder.DropColumn(
                name: "Cekitwo",
                table: "TarifTurkeys");
        }
    }
}
