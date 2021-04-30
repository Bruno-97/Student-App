using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Studomat.DAL.Migrations
{
    public partial class PromjenaNaAppuseru : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kolegiji_Smjerovi_SmjerId",
                table: "Kolegiji");

            migrationBuilder.DropForeignKey(
                name: "FK_Ocjene_Studenti_StudentId",
                table: "Ocjene");

            migrationBuilder.DropTable(
                name: "Studenti");

            migrationBuilder.DropTable(
                name: "Smjerovi");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ocjene",
                table: "Ocjene");

            migrationBuilder.DropIndex(
                name: "IX_Ocjene_StudentId",
                table: "Ocjene");

            migrationBuilder.DropIndex(
                name: "IX_Kolegiji_SmjerId",
                table: "Kolegiji");

            migrationBuilder.DropColumn(
                name: "ID",
                table: "Ocjene");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Ocjene");

            migrationBuilder.DropColumn(
                name: "SmjerId",
                table: "Kolegiji");

            migrationBuilder.AddColumn<string>(
                name: "AppUserId",
                table: "Ocjene",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumRodjenja",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumUpisa",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Ime",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MjestoId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prezime",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ocjene",
                table: "Ocjene",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_MjestoId",
                table: "AspNetUsers",
                column: "MjestoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Mjesta_MjestoId",
                table: "AspNetUsers",
                column: "MjestoId",
                principalTable: "Mjesta",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ocjene_AspNetUsers_AppUserId",
                table: "Ocjene",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Mjesta_MjestoId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Ocjene_AspNetUsers_AppUserId",
                table: "Ocjene");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ocjene",
                table: "Ocjene");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_MjestoId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AppUserId",
                table: "Ocjene");

            migrationBuilder.DropColumn(
                name: "DatumRodjenja",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DatumUpisa",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Ime",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MjestoId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Prezime",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "ID",
                table: "Ocjene",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Ocjene",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SmjerId",
                table: "Kolegiji",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ocjene",
                table: "Ocjene",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "Smjerovi",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FakultetId = table.Column<int>(nullable: true),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smjerovi", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Smjerovi_Fakulteti_FakultetId",
                        column: x => x.FakultetId,
                        principalTable: "Fakulteti",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Studenti",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumRodjenja = table.Column<DateTime>(nullable: false),
                    DatumUpisa = table.Column<DateTime>(nullable: false),
                    Ime = table.Column<string>(nullable: true),
                    MjestoId = table.Column<int>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    SmjerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studenti", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Studenti_Mjesta_MjestoId",
                        column: x => x.MjestoId,
                        principalTable: "Mjesta",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Studenti_Smjerovi_SmjerId",
                        column: x => x.SmjerId,
                        principalTable: "Smjerovi",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_StudentId",
                table: "Ocjene",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Kolegiji_SmjerId",
                table: "Kolegiji",
                column: "SmjerId");

            migrationBuilder.CreateIndex(
                name: "IX_Smjerovi_FakultetId",
                table: "Smjerovi",
                column: "FakultetId");

            migrationBuilder.CreateIndex(
                name: "IX_Studenti_MjestoId",
                table: "Studenti",
                column: "MjestoId");

            migrationBuilder.CreateIndex(
                name: "IX_Studenti_SmjerId",
                table: "Studenti",
                column: "SmjerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kolegiji_Smjerovi_SmjerId",
                table: "Kolegiji",
                column: "SmjerId",
                principalTable: "Smjerovi",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ocjene_Studenti_StudentId",
                table: "Ocjene",
                column: "StudentId",
                principalTable: "Studenti",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
