using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Studomat.DAL.Migrations
{
    public partial class DodatnePromjeneDva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ocjene_AspNetUsers_AppUserId",
                table: "Ocjene");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ocjene",
                table: "Ocjene");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Ocjene");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Ocjene",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Kolegiji",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ocjene",
                table: "Ocjene",
                column: "ID");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kolegiji_AspNetUsers_AppUserId",
                table: "Kolegiji");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ocjene",
                table: "Ocjene");

            migrationBuilder.DropIndex(
                name: "IX_Kolegiji_AppUserId",
                table: "Kolegiji");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Ocjene");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Kolegiji");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Ocjene",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ocjene",
                table: "Ocjene",
                column: "AppUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ocjene_AspNetUsers_AppUserId",
                table: "Ocjene",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
