using Microsoft.EntityFrameworkCore.Migrations;

namespace Vipexfinal.Migrations
{
    public partial class Sorgut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sorgu_SorguType_SorguTypeId",
                table: "Sorgu");

            migrationBuilder.DropTable(
                name: "SorguType");

            migrationBuilder.DropIndex(
                name: "IX_Sorgu_SorguTypeId",
                table: "Sorgu");

            migrationBuilder.DropColumn(
                name: "SorguTypeId",
                table: "Sorgu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SorguTypeId",
                table: "Sorgu",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SorguType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SorguType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sorgu_SorguTypeId",
                table: "Sorgu",
                column: "SorguTypeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Sorgu_SorguType_SorguTypeId",
                table: "Sorgu",
                column: "SorguTypeId",
                principalTable: "SorguType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
