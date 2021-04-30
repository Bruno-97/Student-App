using Microsoft.EntityFrameworkCore.Migrations;

namespace Studomat.DAL.Migrations
{
    public partial class DodavanjeMjesta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Mjesta",
                columns: new[] { "ID", "NazivMjesta", "ZupanijaId" },
                values: new object[,]
                {
                    { 1, "Zagreb", 21 },
                    { 32, "Makarska", 17 },
                    { 33, "Nova Gradiška", 12 },
                    { 34, "Križevci", 6 },
                    { 35, "Sinj", 17 },
                    { 36, "Knin", 15 },
                    { 37, "Slatina", 10 },
                    { 38, "Trogir", 17 },
                    { 39, "Poreč", 18 },
                    { 40, "Sveta Nedelja", 1 },
                    { 41, "Dugo Selo", 1 },
                    { 42, "Našice", 14 },
                    { 43, "Jastrebarsko", 1 },
                    { 31, "Rovinj", 18 },
                    { 44, "Omiš", 17 },
                    { 46, "Gospić", 9 },
                    { 47, "Krapina", 2 },
                    { 48, "Delnice", 8 },
                    { 49, "Ogulin", 4 },
                    { 50, "Opatija", 8 },
                    { 51, "Pazin", 18 },
                    { 52, "Pakrac", 11 },
                    { 53, "Drniš", 15 },
                    { 54, "Senj", 9 },
                    { 55, "Beli Manastir", 14 },
                    { 56, "Imotski", 17 },
                    { 57, "Ploče", 19 },
                    { 45, "Vrbovec", 1 },
                    { 58, "Crikvenica", 8 },
                    { 30, "Županja", 16 },
                    { 28, "Metković", 19 },
                    { 2, "Split", 17 },
                    { 3, "Rijeka", 8 },
                    { 4, "Osijek", 14 },
                    { 5, "Zadar", 13 },
                    { 6, "Slavonski Brod", 12 },
                    { 7, "Pula", 18 },
                    { 8, "Otočac", 9 },
                    { 9, "Kaštela", 17 },
                    { 10, "Karlovac", 4 },
                    { 11, "Sisak", 3 },
                    { 12, "Dubrovnik", 19 },
                    { 13, "Varaždin", 5 },
                    { 29, "Petrinja", 3 },
                    { 14, "Šibenik", 15 },
                    { 16, "Vinkovci", 16 },
                    { 17, "Vukovar", 16 },
                    { 18, "Bjelovar", 7 },
                    { 19, "Koprivnica", 6 },
                    { 20, "Đakovo", 14 },
                    { 21, "Požega", 11 },
                    { 22, "Zaprešić", 1 },
                    { 23, "Solin", 17 },
                    { 24, "Čakovec", 20 },
                    { 25, "Virovitica", 10 },
                    { 26, "Samobor", 1 },
                    { 27, "Kutina", 3 },
                    { 15, "Velika Gorica", 1 },
                    { 59, "Ozalj", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Mjesta",
                keyColumn: "ID",
                keyValue: 59);
        }
    }
}
