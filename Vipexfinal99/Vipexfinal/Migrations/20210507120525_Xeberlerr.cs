using Microsoft.EntityFrameworkCore.Migrations;

namespace Vipexfinal.Migrations
{
    public partial class Xeberlerr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Xebers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xebers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Xeberdetals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imaged = table.Column<string>(nullable: true),
                    Maintitle = table.Column<string>(nullable: true),
                    Image2 = table.Column<string>(nullable: true),
                    Title2 = table.Column<string>(nullable: true),
                    Image3 = table.Column<string>(nullable: true),
                    Title3 = table.Column<string>(nullable: true),
                    Image4 = table.Column<string>(nullable: true),
                    Title4 = table.Column<string>(nullable: true),
                    Image5 = table.Column<string>(nullable: true),
                    Title5 = table.Column<string>(nullable: true),
                    XeberId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Xeberdetals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Xeberdetals_Xebers_XeberId",
                        column: x => x.XeberId,
                        principalTable: "Xebers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Xeberdetals_XeberId",
                table: "Xeberdetals",
                column: "XeberId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Xeberdetals");

            migrationBuilder.DropTable(
                name: "Xebers");
        }
    }
}
