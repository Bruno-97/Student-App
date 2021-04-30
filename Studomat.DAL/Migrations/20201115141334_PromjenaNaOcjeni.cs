using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Studomat.DAL.Migrations
{
    public partial class PromjenaNaOcjeni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatumPolaganja",
                table: "Ocjene");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DatumPolaganja",
                table: "Ocjene",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
