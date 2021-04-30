using Microsoft.EntityFrameworkCore.Migrations;

namespace Studomat.DAL.Migrations
{
    public partial class PromjenaNaFakultetu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Fakulteti",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Fakulteti");
        }
    }
}
