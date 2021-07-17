using Microsoft.EntityFrameworkCore.Migrations;

namespace Vipexfinal.Migrations
{
    public partial class Tarifth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "Qiymet",
                table: "Tarifusas",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Cekitwo",
                table: "Tarifusas",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Ceki",
                table: "Tarifusas",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Qiymet",
                table: "TarifTurkeys",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Cekitwo",
                table: "TarifTurkeys",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<float>(
                name: "Ceki",
                table: "TarifTurkeys",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Qiymet",
                table: "Tarifusas",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<int>(
                name: "Cekitwo",
                table: "Tarifusas",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<int>(
                name: "Ceki",
                table: "Tarifusas",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<int>(
                name: "Qiymet",
                table: "TarifTurkeys",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<int>(
                name: "Cekitwo",
                table: "TarifTurkeys",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));

            migrationBuilder.AlterColumn<int>(
                name: "Ceki",
                table: "TarifTurkeys",
                type: "int",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
