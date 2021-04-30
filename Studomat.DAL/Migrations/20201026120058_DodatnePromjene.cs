using Microsoft.EntityFrameworkCore.Migrations;

namespace Studomat.DAL.Migrations
{
    public partial class DodatnePromjene : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FakultetId",
                table: "Kolegiji",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FakultetId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kolegiji_FakultetId",
                table: "Kolegiji",
                column: "FakultetId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_FakultetId",
                table: "AspNetUsers",
                column: "FakultetId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Fakulteti_FakultetId",
                table: "AspNetUsers",
                column: "FakultetId",
                principalTable: "Fakulteti",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Kolegiji_Fakulteti_FakultetId",
                table: "Kolegiji",
                column: "FakultetId",
                principalTable: "Fakulteti",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Fakulteti_FakultetId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Kolegiji_Fakulteti_FakultetId",
                table: "Kolegiji");

            migrationBuilder.DropIndex(
                name: "IX_Kolegiji_FakultetId",
                table: "Kolegiji");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_FakultetId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FakultetId",
                table: "Kolegiji");

            migrationBuilder.DropColumn(
                name: "FakultetId",
                table: "AspNetUsers");
        }
    }
}
