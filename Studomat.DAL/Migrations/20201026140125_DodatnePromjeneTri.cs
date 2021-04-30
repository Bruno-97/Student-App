using Microsoft.EntityFrameworkCore.Migrations;

namespace Studomat.DAL.Migrations
{
    public partial class DodatnePromjeneTri : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kolegiji_AspNetUsers_AppUserId",
                table: "Kolegiji");

            migrationBuilder.DropIndex(
                name: "IX_Kolegiji_AppUserId",
                table: "Kolegiji");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Kolegiji");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Ocjene",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_AppUserId",
                table: "Ocjene",
                column: "AppUserId");

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

            migrationBuilder.DropIndex(
                name: "IX_Ocjene_AppUserId",
                table: "Ocjene");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Ocjene");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Kolegiji",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kolegiji_AppUserId",
                table: "Kolegiji",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kolegiji_AspNetUsers_AppUserId",
                table: "Kolegiji",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
