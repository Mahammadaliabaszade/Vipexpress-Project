using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vipexfinal.Migrations
{
    public partial class Beyannametabl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beyanname",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SendTime = table.Column<DateTime>(nullable: false),
                    OlkeName = table.Column<string>(nullable: true),
                    MyProperty = table.Column<int>(nullable: false),
                    AppUserId = table.Column<string>(nullable: true),
                    MagazaName = table.Column<string>(nullable: true),
                    Qiymet = table.Column<int>(nullable: false),
                    OfisName = table.Column<string>(nullable: true),
                    Qeyd = table.Column<string>(nullable: true),
                    StatusId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beyanname", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Beyanname_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Beyanname_Status_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Status",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beyanname_AppUserId",
                table: "Beyanname",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Beyanname_StatusId",
                table: "Beyanname",
                column: "StatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beyanname");
        }
    }
}
