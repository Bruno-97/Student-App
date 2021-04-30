using Microsoft.EntityFrameworkCore.Migrations;

namespace Studomat.DAL.Migrations
{
    public partial class Ispravak : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ocjene_AspNetUsers_AppUserId",
                table: "Ocjene");

            migrationBuilder.DropForeignKey(
                name: "FK_Ocjene_AspNetUsers_AppUserId1",
                table: "Ocjene");

            migrationBuilder.DropIndex(
                name: "IX_Ocjene_AppUserId1",
                table: "Ocjene");

            migrationBuilder.DropColumn(
                name: "AppUserId1",
                table: "Ocjene");

            migrationBuilder.AddForeignKey(
                name: "FK_Ocjene_AspNetUsers_AppUserId",
                table: "Ocjene",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ocjene_AspNetUsers_AppUserId",
                table: "Ocjene");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId1",
                table: "Ocjene",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_AppUserId1",
                table: "Ocjene",
                column: "AppUserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Ocjene_AspNetUsers_AppUserId",
                table: "Ocjene",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ocjene_AspNetUsers_AppUserId1",
                table: "Ocjene",
                column: "AppUserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
