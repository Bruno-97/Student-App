﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Studomat.DAL.Migrations
{
    public partial class PromjenaNaAppuseruTri : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "AspNetUsers");
        }
    }
}
