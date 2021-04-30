using Microsoft.EntityFrameworkCore.Migrations;

namespace Studomat.DAL.Migrations
{
    public partial class DodavanjeKolegijaINastavnika : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Nastavnici",
                columns: new[] { "ID", "Adresa", "Ime", "Lozinka", "MjestoId", "Prezime", "TitulaIspred", "TitulaIza" },
                values: new object[,]
                {
                    { 1, null, "Sanja", null, 1, "Sikora", "Prof.dr.sc.", null },
                    { 131, null, "Zrinka", null, 1, "Lacković Vincek", "Prof.dr.sc.", null },
                    { 132, null, "Ema", null, 3, "Novak", "Izv.prof.dr.sc.", null },
                    { 133, null, "Nina", null, 2, "Begičević Ređep", "Univ.spec.st.eur.", null },
                    { 134, null, "Nikola", null, 5, "Kadoić", "Doc.dr.sc.", null },
                    { 135, null, "Barbara", null, 4, "Šlibar", "Mag.oec", null },
                    { 136, null, "Mladen", null, 1, "Konecki", "Prof.dr.sc.", null },
                    { 137, null, "Danijel", null, 3, "Radošević", "Izv.prof.dr.sc.", null },
                    { 138, null, "Vladimir", null, 2, "Bermanec", "Univ.spec.st.eur.", null },
                    { 139, null, "Zoran", null, 5, "Glavaš", "Doc.dr.sc.", null },
                    { 140, null, "Mirko", null, 4, "Gojić", "Mag.oec", null },
                    { 141, null, "Damir", null, 1, "Hršak", "Prof.dr.sc.", null },
                    { 142, null, "Stjepan", null, 3, "Kožuh", "Izv.prof.dr.sc.", null },
                    { 143, null, "Ladislav", null, 2, "Lazić", "Univ.spec.st.eur.", null },
                    { 144, null, "Anita", null, 5, "Begić Hadžipašić", "Doc.dr.sc.", null },
                    { 145, null, "Ivan", null, 4, "Brnardić", "Mag.oec", null },
                    { 146, null, "Natalija", null, 1, "Dolić", "Prof.dr.sc.", null },
                    { 147, null, "Tamara", null, 3, "Holjevac Grgurić", "Izv.prof.dr.sc.", null },
                    { 148, null, "Robert", null, 2, "Pezer", "Univ.spec.st.eur.", null },
                    { 149, null, "Ljerka", null, 5, "Slokar Benić", "Doc.dr.sc.", null },
                    { 150, null, "Anita", null, 4, "Štrkalj", "Mag.oec", null },
                    { 151, null, "Zdenka", null, 1, "Zovko Brodarac", "Prof.dr.sc.", null },
                    { 130, null, "Lucija", null, 4, "Radetić", "Mag.oec", null },
                    { 129, null, "Mario", null, 5, "Šiljeg", "Doc.dr.sc.", null },
                    { 128, null, "Mladen", null, 2, "Božičević", "Univ.spec.st.eur.", null },
                    { 127, null, "Sanja", null, 3, "Kovač", "Izv.prof.dr.sc.", null },
                    { 105, null, "Snježana", null, 4, "Križanić", "Mag.oec", null },
                    { 106, null, "Bogdan", null, 1, "Okreša Đurić", "Prof.dr.sc.", null },
                    { 107, null, "Stjepan", null, 3, "Dvorski", "Izv.prof.dr.sc.", null },
                    { 108, null, "Vladimir", null, 2, "Kovšca", "Univ.spec.st.eur.", null },
                    { 109, null, "Ivana", null, 5, "Dvorski Lacković", "Doc.dr.sc.", null },
                    { 110, null, "Suzana", null, 4, "Keglević Kozjak", "Mag.oec", null },
                    { 111, null, "Meri", null, 1, "Tadinac", "Prof.dr.sc.", null },
                    { 112, null, "Katarina", null, 3, "Faraguna", "Izv.prof.dr.sc.", null },
                    { 113, null, "Andrea", null, 2, "Vranić", "Univ.spec.st.eur.", null },
                    { 114, null, "Ivana", null, 5, "Hromatko", "Doc.dr.sc.", null },
                    { 152, null, "Jakov", null, 3, "Baleta", "Izv.prof.dr.sc.", null },
                    { 115, null, "Dragutin", null, 4, "Ivanec", "Mag.oec", null },
                    { 117, null, "Denis", null, 3, "Bratko", "Izv.prof.dr.sc.", null },
                    { 118, null, "Dragutin", null, 2, "Ivanec", "Univ.spec.st.eur.", null },
                    { 119, null, " Francesca", null, 5, "Dumančić", "Doc.dr.sc.", null },
                    { 120, null, "Denis", null, 4, "Vlašiček", "Mag.oec", null },
                    { 121, null, "Vesna", null, 1, "Alikalfić", "Prof.dr.sc.", null },
                    { 122, null, "Svetlana", null, 3, "Božić", "Izv.prof.dr.sc.", null },
                    { 123, null, "Mirjana", null, 2, "Tonković", "Univ.spec.st.eur.", null },
                    { 124, null, "Tina", null, 5, "Miholjančan", "Doc.dr.sc.", null },
                    { 125, null, "Jasna", null, 4, "Ćirić", "Mag.oec", null },
                    { 126, null, "Predrag", null, 1, "Lončar", "Prof.dr.sc.", null },
                    { 116, null, "Marina", null, 1, "Martinčević", "Prof.dr.sc.", null },
                    { 153, null, "Ivana", null, 2, "Ivanić", "Univ.spec.st.eur.", null },
                    { 154, null, "Ivan", null, 5, "Ivec", "Doc.dr.sc.", null },
                    { 155, null, "Ivan", null, 4, "Jandrlić", "Mag.oec", null },
                    { 182, null, "Andreja", null, 3, "Đuka", "Izv.prof.dr.sc.", null },
                    { 183, null, "Krešimir", null, 2, "Krapinec", "Univ.spec.st.eur.", null },
                    { 184, null, "Ivan", null, 5, "Mlinar", "Doc.dr.sc.", null },
                    { 185, null, "Kajba", null, 4, "Davorin", "Mag.oec", null },
                    { 186, null, "Roman", null, 1, "Rosavec", "Prof.dr.sc.", null },
                    { 187, null, "Ivica", null, 3, "Tikvić", "Izv.prof.dr.sc.", null },
                    { 188, null, "Lea", null, 2, "Petrović Krajnik", "Univ.spec.st.eur.", null },
                    { 189, null, "Igor", null, 5, "Poljak", "Doc.dr.sc.", null },
                    { 190, null, "Ernest", null, 4, "Goršić", "Mag.oec", null },
                    { 191, null, "Marilena", null, 1, "Idžojtić", "Prof.dr.sc.", null },
                    { 181, null, "Željko", null, 1, "Zečić", "Prof.dr.sc.", null },
                    { 192, null, "Ante", null, 3, "Seletković", "Izv.prof.dr.sc.", null },
                    { 194, null, "Ivan", null, 1, "Cesar", "Mag.oec", null },
                    { 195, null, "Miroslav", null, 1, "Slamić", "Prof.dr.sc.", null },
                    { 196, null, "Sanja", null, 1, "Kraljević", "Doc.dr.sc.", null },
                    { 197, null, "Željko", null, 1, "Kovačević", "Mag.oec", null },
                    { 198, null, "Davor", null, 1, "Cafuta", "Doc.dr.sc.", null },
                    { 199, null, "Aleksander", null, 1, "Radovan", "Mag.oec", null },
                    { 200, null, "Anka", null, 1, "Jurčević Lozančić", "Mag.oec", null },
                    { 201, null, "Ivana", null, 2, "Golik Homolak", "Prof.dr.sc.", null },
                    { 202, null, "Diana", null, 3, "Zalar", "Doc.dr.sc.", null },
                    { 203, null, "Branimir", null, 4, "Stojanović", "Mag.oec", null },
                    { 193, null, "Anka Ozana", null, 2, "Čavlović", "Univ.spec.st.eur.", null },
                    { 104, null, "Kornelije", null, 5, "Rabuzin", "Doc.dr.sc.", null },
                    { 180, null, "Krunoslav", null, 4, "Sever", "Mag.oec", null },
                    { 178, null, "Marin", null, 2, "Hasan", "Univ.spec.st.eur.", null },
                    { 156, null, "Martina", null, 1, "Lovrenić-Jugović", "Prof.dr.sc.", null },
                    { 157, null, "Vesna", null, 3, "Ocelić Bulatović", "Izv.prof.dr.sc.", null },
                    { 158, null, "Sandra", null, 2, "Brajčinović", "Univ.spec.st.eur.", null },
                    { 159, null, "Tin", null, 5, "Brlić", "Doc.dr.sc.", null },
                    { 160, null, "Damijan", null, 4, "Cerinski", "Mag.oec", null },
                    { 161, null, "Igor", null, 1, "Jajčinović", "Prof.dr.sc.", null },
                    { 162, null, "Barbara", null, 3, "Tubić Bulat", "Izv.prof.dr.sc.", null },
                    { 163, null, "Selim", null, 2, "Pašić", "Univ.spec.st.eur.", null },
                    { 164, null, "Vibor", null, 5, "Roje", "Doc.dr.sc.", null },
                    { 165, null, "Darko", null, 4, "Bakšić", "Mag.oec", null },
                    { 179, null, "Daniel", null, 5, "Krstonošić", "Doc.dr.sc.", null },
                    { 166, null, "Ivan", null, 1, "Perković", "Prof.dr.sc.", null },
                    { 168, null, "Anamarija", null, 2, "Jazbec", "Univ.spec.st.eur.", null },
                    { 169, null, "Mario", null, 5, "Božić", "Doc.dr.sc.", null },
                    { 170, null, "Dunja", null, 4, "Aljinović", "Mag.oec", null },
                    { 171, null, "Bojan", null, 1, "Matoš", "Prof.dr.sc.", null },
                    { 172, null, "Nikola", null, 3, "Pernar", "Izv.prof.dr.sc.", null },
                    { 173, null, "Tomislav", null, 2, "Poršinsky", "Univ.spec.st.eur.", null },
                    { 174, null, "Boris", null, 5, "Hrašovec", "Doc.dr.sc.", null },
                    { 175, null, "Mario ", null, 4, "Šporčić", "Mag.oec", null },
                    { 176, null, "Jelena", null, 1, "Kolić", "Prof.dr.sc.", null },
                    { 177, null, "Tomislav", null, 3, "Sinković", "Izv.prof.dr.sc.", null },
                    { 167, null, "Azra", null, 3, "Tafo", "Izv.prof.dr.sc.", null },
                    { 204, null, "Blaženka", null, 5, "Bačlija Sušić", "Doc.dr.sc.", null },
                    { 103, null, "Damir", null, 2, "Vučić", "Univ.spec.st.eur.", null },
                    { 101, null, "Dijana", null, 1, "Plantak Vukovac", "Prof.dr.sc.", null },
                    { 28, null, "Veljko", null, 1, "Oluić", "Univ.spec.st.eur.", null },
                    { 29, null, "Milan", null, 1, "Opalić", "Doc.dr.sc.", null },
                    { 30, null, "Mladen", null, 1, "Orešić", "Mag.oec", null },
                    { 31, null, "Ivan", null, 2, "Ferenčak", "Prof.dr.sc.", null },
                    { 32, null, "Branko", null, 3, "Crnković", "Izv.prof.dr.sc.", null },
                    { 33, null, "Josip", null, 2, "Horvat", "Univ.spec.st.eur.", null },
                    { 34, null, "Jasna", null, 4, "Mijoč", "Doc.dr.sc.", null },
                    { 35, null, "Željka", null, 4, "Turkalj", "Mag.oec", null },
                    { 36, null, "Ivana", null, 6, "Fosić", "Prof.dr.sc.", null },
                    { 37, null, "Aleks", null, 3, "Živković", "Izv.prof.dr.sc.", null },
                    { 38, null, "Alma", null, 4, "Šundalić", "Univ.spec.st.eur.", null },
                    { 39, null, "Ljiljana", null, 3, "Radoš", "Doc.dr.sc.", null },
                    { 40, null, "Karlo", null, 3, "Knežević", "Mag.oec", null },
                    { 41, null, "Branka", null, 1, "Marasović", "Prof.dr.sc.", null },
                    { 42, null, "Snježana", null, 3, "Pivac", "Izv.prof.dr.sc.", null },
                    { 43, null, "Marija", null, 2, "Šimić Šarić", "Univ.spec.st.eur.", null },
                    { 44, null, "Tino", null, 6, "Kusanović", "Doc.dr.sc.", null },
                    { 45, null, "Tina", null, 7, "Vuko", "Mag.oec", null },
                    { 46, null, "Vinko", null, 7, "Glavinić", "Prof.dr.sc.", null },
                    { 47, null, "Ana", null, 3, "Aglić Aljinović", "Izv.prof.dr.sc.", null },
                    { 48, null, "Tajana", null, 5, "Burić", "Univ.spec.st.eur.", null },
                    { 27, null, "Tin", null, 2, "Oberman", "Izv.prof.dr.sc.", null },
                    { 26, null, "Marko", null, 1, "Obad Šćitaroci", "Prof.dr.sc.", null },
                    { 25, null, "Alan", null, 2, "Braun", "Mag.oec", null },
                    { 24, null, "Ana Martina", null, 4, "Bakić", "Doc.dr.sc.", null },
                    { 2, null, "Mihaela", null, 2, "Britvec", "Izv.prof.dr.sc.", null },
                    { 3, null, "Ivo", null, 3, "Grgić", "Univ.spec.st.eur.", null },
                    { 4, null, "Marina", null, 4, "Ninčević", "Doc.dr.sc.", null },
                    { 5, null, "Milan", null, 5, "Mesić", "Mag.oec", null },
                    { 6, null, "Korina", null, 1, "Hunjak", "Prof.dr.sc.", null },
                    { 7, null, "Siniša", null, 1, "Majkus", "Izv.prof.dr.sc.", null },
                    { 8, null, "Elvis", null, 2, "Krstulović", "Univ.spec.st.eur.", null },
                    { 9, null, "Goran", null, 3, "Štimac", "Doc.dr.sc.", null },
                    { 10, null, "Marina", null, 4, "Banić-Zrinšćak", "Mag.oec", null },
                    { 11, null, "Željka", null, 5, "Lapuh", "Prof.dr.sc.", null },
                    { 49, null, "Goran", null, 4, "Gledec", "Doc.dr.sc.", null },
                    { 12, null, "Daniel", null, 6, "Jurić", "Izv.prof.dr.sc.", null },
                    { 14, null, "Laura", null, 6, "Konda Labaš", "Doc.dr.sc.", null },
                    { 15, null, "Marin", null, 1, "Bačić", "Mag.oec", null },
                    { 16, null, "Emilija", null, 1, "Duparova", "Prof.dr.sc.", null },
                    { 17, null, "Dajana", null, 3, "Radoš", "Izv.prof.dr.sc.", null },
                    { 18, null, "Marin", null, 2, "Lukanović", "Univ.spec.st.eur.", null },
                    { 19, null, "Robert", null, 1, "Mijalić", "Doc.dr.sc.", null },
                    { 20, null, "Valentina", null, 2, "Lončarić", "Mag.oec", null },
                    { 21, null, "Davor", null, 1, "Andrić", "Prof.dr.sc.", null },
                    { 22, null, "Gorana", null, 6, "Aras Gazić", "Izv.prof.dr.sc.", null },
                    { 23, null, "Dubravko", null, 5, "Bačić", "Univ.spec.st.eur.", null },
                    { 13, null, "Nikola", null, 5, "Bilić", "Univ.spec.st.eur.", null },
                    { 50, null, "Ivan", null, 1, "Botički", "Mag.oec", null },
                    { 51, null, "Dragan", null, 1, "Vulin", "Prof.dr.sc.", null },
                    { 52, null, "Marinko", null, 1, "Barukčić", "Izv.prof.dr.sc.", null },
                    { 79, null, "Nikola", null, 1, "Ivković", "Doc.dr.sc.", null },
                    { 80, null, "Ivan", null, 2, "Magdalenić", "Mag.oec", null },
                    { 81, null, "Luka", null, 5, "Milić", "Prof.dr.sc.", null },
                    { 82, null, "Aleksandra", null, 3, "Sobodić", "Izv.prof.dr.sc.", null },
                    { 83, null, "Miran", null, 2, "Zlatović", "Univ.spec.st.eur.", null },
                    { 84, null, "Elvis", null, 5, "Popović", "Doc.dr.sc.", null },
                    { 85, null, "Danijel", null, 2, "Filipović", "Mag.oec", null },
                    { 86, null, "Blaženka", null, 1, "Divjak", "Prof.dr.sc.", null },
                    { 87, null, "Zlatko", null, 3, "Erjavec", "Izv.prof.dr.sc.", null },
                    { 88, null, "Marcel", null, 2, "Maretić", "Univ.spec.st.eur.", null },
                    { 78, null, "Igor", null, 2, "Balaban", "Univ.spec.st.eur.", null },
                    { 89, null, "Damjan", null, 1, "Klemenčić", "Doc.dr.sc.", null },
                    { 91, null, "Lucija", null, 1, "Žignić", "Prof.dr.sc.", null },
                    { 92, null, "Ivan", null, 3, "Malbašić", "Izv.prof.dr.sc.", null },
                    { 93, null, "Anamarija", null, 2, "Jelaković", "Univ.spec.st.eur.", null },
                    { 94, null, "Nikolina", null, 1, "Posarić", "Doc.dr.sc.", null },
                    { 95, null, "Valentina", null, 2, "Kolačko", "Mag.oec", null },
                    { 96, null, "Emina", null, 1, "Crleni", "Prof.dr.sc.", null },
                    { 97, null, "Goran", null, 3, "Bubaš", "Izv.prof.dr.sc.", null },
                    { 98, null, "Violeta", null, 2, "Vidaček-Hainš", "Univ.spec.st.eur.", null },
                    { 99, null, "Antonela", null, 5, "Čižmešija", "Doc.dr.sc.", null },
                    { 100, null, "Ana", null, 4, "Kutnjak", "Mag.oec", null },
                    { 90, null, "Mihaela", null, 2, "Laljek", "Mag.oec", null },
                    { 102, null, "Robert", null, 3, "Kudelić", "Izv.prof.dr.sc.", null },
                    { 77, null, "Andreja", null, 3, "Kovačić", "Izv.prof.dr.sc.", null },
                    { 75, null, "Vlado", null, 5, "Tomašić", "Mag.oec", null },
                    { 53, null, "Ivan", null, 2, "Biondić", "Univ.spec.st.eur.", null },
                    { 54, null, "Luka", null, 2, "Filipović", "Doc.dr.sc.", null },
                    { 55, null, "Tomislav", null, 2, "Matić", "Mag.oec", null },
                    { 56, null, "Jani", null, 1, "Barle", "Prof.dr.sc.", null },
                    { 57, null, "Ivan", null, 1, "Jadrić", "Izv.prof.dr.sc.", null },
                    { 58, null, "Josip", null, 1, "Eterović", "Univ.spec.st.eur.", null },
                    { 59, null, "Dario", null, 1, "Bezmalinović", "Doc.dr.sc.", null },
                    { 60, null, "Ivan", null, 1, "Tolj", "Mag.oec", null },
                    { 61, null, "Slavko", null, 1, "Vulić Vranković", "Prof.dr.sc.", null },
                    { 62, null, "Velimir", null, 3, "Franić Tomić", "Izv.prof.dr.sc.", null },
                    { 76, null, "Mario", null, 5, "Konecki", "Prof.dr.sc.", null },
                    { 63, null, "Stanko", null, 1, "Tadić", "Univ.spec.st.eur.", null },
                    { 65, null, "Daniel", null, 1, "Piskač", "Mag.oec", null },
                    { 66, null, "Branimir", null, 2, "Zelić", "Prof.dr.sc.", null },
                    { 67, null, "Nikola", null, 3, "Bolf", "Izv.prof.dr.sc.", null },
                    { 68, null, "Vlatka", null, 4, "Filipan", "Univ.spec.st.eur.", null },
                    { 69, null, "Šime", null, 1, "Ukić", "Doc.dr.sc.", null },
                    { 70, null, "Elvira", null, 4, "Begović Kovač", "Mag.oec", null },
                    { 71, null, "Marijana", null, 1, "Ćurak", "Prof.dr.sc.", null },
                    { 72, null, "Ana", null, 3, "Rimac Smiljanić", "Izv.prof.dr.sc.", null },
                    { 73, null, "Goran", null, 2, "Matijašić", "Univ.spec.st.eur.", null },
                    { 74, null, "Janko", null, 1, "Peršun", "Doc.dr.sc.", null },
                    { 64, null, "Ivan", null, 1, "Kresnik", "Doc.dr.sc.", null },
                    { 205, null, "Danijel", null, 6, "Žabčić", "Mag.oec", null }
                });

            migrationBuilder.InsertData(
                table: "Kolegiji",
                columns: new[] { "ID", "FakultetId", "NastavnikId", "Naziv", "Opis" },
                values: new object[,]
                {
                    { 1, 1, 1, "Uvod u mikrobiologiju tla", null },
                    { 131, 34, 131, "Atletika-hodanja i trčanja", null },
                    { 132, 34, 132, "Funkcionalna anatomija", null },
                    { 133, 34, 133, "Osnovne kineziološke transformacije I", null },
                    { 134, 35, 134, "Medicinska biologija", null },
                    { 135, 35, 135, "Medicinska fizika i biofizika", null },
                    { 136, 35, 136, "Medicinska kemija i biokemija", null },
                    { 137, 36, 137, "Uvod u medicinu i povijest medicine", null },
                    { 138, 36, 138, "Socijalna medicina", null },
                    { 139, 36, 139, "Psihološka medicina", null },
                    { 140, 37, 140, "Imunologija i medicinska genetika", null },
                    { 141, 37, 141, "Temelji neuroznanosti", null },
                    { 142, 37, 142, "Fiziologija", null },
                    { 143, 38, 143, "Anatomija", null },
                    { 144, 38, 144, "Medicinska biologija", null },
                    { 145, 38, 145, "Fizika i biofizika", null },
                    { 146, 39, 146, "Matematika 1 ", null },
                    { 147, 39, 147, "Fizika", null },
                    { 148, 39, 148, "Uvod u metalurgiju", null },
                    { 149, 40, 149, "Biologija stanice", null },
                    { 150, 40, 150, "Mikrobiologija", null },
                    { 151, 40, 151, "Opća zoologija", null },
                    { 130, 33, 130, "Opći uvod u Sveto pismo", null },
                    { 129, 33, 129, "Uvod u filozofiju i teologiju", null },
                    { 128, 33, 128, "Patrologija", null },
                    { 127, 32, 127, "Uvod u filozofiju", null },
                    { 105, 25, 105, "Percepcija i pamćenje", null },
                    { 106, 25, 106, "Psihologija kao znanost i struka", null },
                    { 107, 26, 107, "Geodetski instrumenti", null },
                    { 108, 26, 108, "Inženjerska grafika u geodeziji i geoinformatici", null },
                    { 109, 26, 109, "Analitička geometrija i linearna algebra", null },
                    { 110, 27, 110, "Osnove zaštite okoliša", null },
                    { 111, 27, 111, "Nacrtna geometrija", null },
                    { 112, 27, 112, "Geologija", null },
                    { 113, 28, 113, "Deskriptivna geometrija", null },
                    { 114, 28, 114, "Geodezija", null },
                    { 152, 41, 152, "Osnove informatike", null },
                    { 115, 28, 115, "Matematički programi za inženjere", null },
                    { 117, 29, 117, "Uvod u graditeljstvo", null },
                    { 118, 29, 118, "Poznavanje materijala", null },
                    { 119, 30, 119, "Inženjerska grafika", null },
                    { 120, 30, 120, "Tehnička mehanika", null },
                    { 121, 30, 121, "Likovno grafička kultura 1", null },
                    { 122, 31, 122, "Uvod u misterij Krista i povijest spasenja", null },
                    { 123, 31, 123, "Hebrejski jezik", null },
                    { 124, 31, 124, "Opća crkvena povijest, I.: stari i srednji vijek", null },
                    { 125, 32, 125, "Crkvena umjetnost", null },
                    { 126, 32, 126, "Razvojna psihologija", null },
                    { 116, 29, 116, "Konstrukcijska geometrija", null },
                    { 153, 41, 153, "Osnove fizike 1", null },
                    { 154, 41, 154, "Matematika 1", null },
                    { 155, 42, 155, "Programiranje 1", null },
                    { 182, 51, 182, "Matematika", null },
                    { 183, 51, 183, "Opća zoologija", null },
                    { 184, 51, 184, "Stanična i molekularna biologija", null },
                    { 185, 52, 185, "Histologija s embriologijom", null },
                    { 186, 52, 186, "Uvod u dentalnu medicinu", null },
                    { 187, 52, 187, "Stanična biologija s genetikom", null },
                    { 188, 53, 188, "Alati i naprave I", null },
                    { 189, 53, 189, "Automatizacija", null },
                    { 190, 53, 190, "Čvrstoća", null },
                    { 191, 54, 191, "Kemija s biokemijom", null },
                    { 181, 50, 181, "Programiranje I", null },
                    { 192, 54, 192, "Zoologija u šumarstvu", null },
                    { 194, 55, 194, "Programiranje", null },
                    { 195, 55, 195, "Objektno orijentirano programiranje", null },
                    { 196, 55, 196, "Uvod u web tehnologije	", null },
                    { 197, 55, 197, "Algoritmi i strukture podataka", null },
                    { 198, 55, 198, "Operacijski sustavi", null },
                    { 199, 55, 199, "Programiranje u jeziku Java", null },
                    { 200, 56, 200, "Pedagogija ranoga odgoja 1", null },
                    { 201, 56, 201, "Razvojna psihologija 1", null },
                    { 202, 56, 202, "Glazbena kultura", null },
                    { 203, 57, 203, "Uvod u veterinarstvo", null },
                    { 193, 54, 193, "Petrologija s geologijom", null },
                    { 104, 25, 104, "Biološka psihologija I", null },
                    { 180, 50, 180, "Uvod u algebru s analitičkom geometrijom", null },
                    { 178, 49, 178, "Tehnička fizika", null },
                    { 156, 42, 156, "Osnove informatike", null },
                    { 157, 42, 157, "Multimedijski sustavi", null },
                    { 158, 43, 158, "Poljoprivredna botanika", null },
                    { 159, 43, 159, "Primjena računala u poljoprivredi", null },
                    { 160, 43, 160, "Pedologija", null },
                    { 161, 44, 161, "Brodska elektrotehnika", null },
                    { 162, 44, 162, "Poznavanje broda i plovidbe", null },
                    { 163, 44, 163, "Matematika I", null },
                    { 164, 45, 164, "Teorija prava i države", null },
                    { 165, 45, 165, "Povijest hrvatskog prava i države", null },
                    { 179, 50, 179, "Osnove matematike", null },
                    { 166, 45, 166, "Seminar", null },
                    { 168, 46, 168, "Socijologija", null },
                    { 169, 46, 169, "Politička ekonomija", null },
                    { 170, 47, 170, "Opća povijest prava i države", null },
                    { 171, 47, 171, "Rimsko privatno pravo", null },
                    { 172, 47, 172, "Hrvatska pravna povijest u europskom kontekstu", null },
                    { 173, 48, 173, "Opća kemija", null },
                    { 174, 48, 174, "Uvod u prehrambene tehnologije", null },
                    { 175, 48, 175, "Organska kemija", null },
                    { 176, 49, 176, "Opća i anorganska kemija", null },
                    { 177, 49, 177, "Analitička kemija", null },
                    { 167, 46, 167, "Opća pravna povijest", null },
                    { 204, 57, 204, "Anatomija s organogenezom domaćih životinja", null },
                    { 103, 24, 103, "Pretraživanje informacija", null },
                    { 101, 24, 101, "Osnove usmene i pisane kulture", null },
                    { 28, 6, 28, "Uvod u psihologiju djetinjstva i adolescencije", null },
                    { 29, 6, 29, "Motorički poremećaji, kronične bolesti i sofrologija", null },
                    { 30, 6, 30, "Statistika", null },
                    { 31, 7, 31, "Počela ekonomije", null },
                    { 32, 7, 32, "Statistika", null },
                    { 33, 7, 33, "Osnove organizacije ", null },
                    { 34, 7, 34, "Sociologija", null },
                    { 35, 7, 35, "Engleski jezik 1", null },
                    { 36, 8, 36, "Aktuarska matematika", null },
                    { 37, 8, 37, "Alternativni izvori financiranja", null },
                    { 38, 8, 38, "Analiza financijskih izvješća", null },
                    { 39, 8, 39, "Bankarstvo", null },
                    { 40, 8, 40, "Burze i vrijednosnice", null },
                    { 41, 9, 41, "Ekonometrija", null },
                    { 42, 9, 42, "Ekonomija tržišta rada", null },
                    { 43, 9, 43, "E-marketing", null },
                    { 44, 9, 44, "Financijski sustav", null },
                    { 45, 9, 45, "Gospodarstvo Hrvatske", null },
                    { 46, 10, 46, "Digitalna logika", null },
                    { 47, 10, 47, "Linearna algebra", null },
                    { 48, 10, 48, "Matematička analiza 1", null },
                    { 27, 6, 27, "Funkcionalna anatomija i fiziologija", null },
                    { 26, 6, 26, "Osnove humane genetike", null },
                    { 25, 5, 25, "Uvod u pro­jek­ti­ra­nje stam­be­nih zgra­da", null },
                    { 24, 5, 24, "Pri­mje­na ra­ču­na­la u ar­hi­tek­tu­ri", null },
                    { 2, 1, 2, "Botanika", null },
                    { 3, 1, 3, "Osnove agroekonomike", null },
                    { 4, 1, 4, "Matematika", null },
                    { 5, 1, 5, "Agroklimatologija", null },
                    { 6, 2, 6, "Dramsko pismo", null },
                    { 7, 2, 7, "Filmsko pismo", null },
                    { 8, 2, 8, "Estetika filma", null },
                    { 9, 2, 9, "Analiza filma", null },
                    { 10, 2, 10, "Dramatologija", null },
                    { 11, 3, 11, "Crtanje", null },
                    { 49, 10, 49, "Uvod u programiranje", null },
                    { 12, 3, 12, "Uvod u slikanje", null },
                    { 14, 3, 14, "Uvod u likovnu umjetnost", null },
                    { 15, 3, 15, "Sociologija kulture", null },
                    { 16, 4, 16, "Književnost", null },
                    { 17, 4, 17, "Svjetska književnost", null },
                    { 18, 4, 18, "Povijest kazališta i drame", null },
                    { 19, 4, 19, "Film i druge umjetnosti", null },
                    { 20, 4, 20, "Radiofonija", null },
                    { 21, 5, 21, "Zgrade za rad i trgovinu", null },
                    { 22, 5, 22, "Osnove nacrtne geometrije", null },
                    { 23, 5, 23, "Uvod u primjenu računala", null },
                    { 13, 3, 13, "Kiparstvo", null },
                    { 50, 10, 50, "Algoritmi i strukture podataka", null },
                    { 51, 11, 51, "Osnove elektrotehnike i elektronike", null },
                    { 52, 11, 52, "Inženjerska grafika i dokumentiranje", null },
                    { 79, 17, 79, "Održavanje vozila javnog gradskog prijevoza", null },
                    { 80, 17, 80, "Vozila za javni gradski prijevoz", null },
                    { 81, 17, 81, "Gradske prometnice", null },
                    { 82, 18, 82, "Matematika I", null },
                    { 83, 18, 83, "Mehanika I", null },
                    { 84, 18, 84, "Materijali I", null },
                    { 85, 18, 85, "Računalna i inženjerska grafika", null },
                    { 86, 19, 86, "Hrvatska povijest", null },
                    { 87, 19, 87, "Nenasilna komunikacija", null },
                    { 88, 19, 88, "Pedagogija", null },
                    { 78, 16, 78, "Mediji i nasilje", null },
                    { 89, 20, 89, "Uvod u farmaciju", null },
                    { 91, 20, 91, "Stanična biologija s genetikom", null },
                    { 92, 21, 92, "Grčka filozofija I", null },
                    { 93, 21, 93, "Uvod u filozofiju", null },
                    { 94, 21, 94, "Filozofija politike", null },
                    { 95, 22, 95, "Metodologija istraživanja u kulturi", null },
                    { 96, 22, 96, "Uvod u filozofiju", null },
                    { 97, 22, 97, "Uvod u kulturalne studije", null },
                    { 98, 23, 98, "Povijest starih civilizacija", null },
                    { 99, 23, 99, "Povijest Grčke i Rima sa starom poviješću hrvatskih zemalja", null },
                    { 100, 23, 100, "Latinski jezik", null },
                    { 90, 20, 90, "Matematika sa statističkom analizom", null },
                    { 102, 24, 102, "Osnove informacijske tehnologije", null },
                    { 77, 16, 77, "Komunikologija", null },
                    { 75, 15, 75, "Programiranje 1", null },
                    { 53, 11, 53, "Programiranje I", null },
                    { 54, 11, 54, "Matematičke osnove računarstva", null },
                    { 55, 11, 55, "Engleski jezik", null },
                    { 56, 12, 56, "Matematika 1 ", null },
                    { 57, 12, 57, "Materijali 1", null },
                    { 58, 12, 58, "Mehanika 1", null },
                    { 59, 12, 59, "Fizika", null },
                    { 60, 12, 60, "Inženjerska grafika 1", null },
                    { 61, 13, 61, "Fonologija hrvatskoga jezika", null },
                    { 62, 13, 62, "Hrvatska književnost srednjovjekovlja", null },
                    { 76, 16, 76, "Uvod u novinarstvo", null },
                    { 63, 13, 63, "Hrvatski identitet u europskom kontekstu", null },
                    { 65, 13, 65, "Uvod u kroatologiju", null },
                    { 66, 14, 66, "Analitička kemija", null },
                    { 67, 14, 67, "Osnove elektrotehnike", null },
                    { 68, 14, 68, "Opća i anorganska kemija", null },
                    { 69, 14, 69, "Osnove strojarstva", null },
                    { 70, 14, 70, "Bilanca tvari i energije", null },
                    { 71, 15, 71, "Engleski jezik u informatičkoj struci", null },
                    { 72, 15, 72, "Informacijski i računalni sustavi", null },
                    { 73, 15, 73, "Organizacija", null },
                    { 74, 15, 74, "Poslovno komuniciranje", null },
                    { 64, 13, 64, "Osnove hrvatske jezične kulture", null },
                    { 205, 57, 205, "Botanika u veterinarskoj medicini", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Kolegiji",
                keyColumn: "ID",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Nastavnici",
                keyColumn: "ID",
                keyValue: 205);
        }
    }
}
