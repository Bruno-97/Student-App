using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Studomat.MODEL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Studomat.DAL
{
    public class StudentManagerDbContext : IdentityDbContext<AppUser> 
    {
        protected StudentManagerDbContext () {}

        public StudentManagerDbContext (DbContextOptions options) : base(options) { }

        public DbSet<Fakultet> Fakulteti { get; set; }
        public DbSet<Kolegij> Kolegiji { get; set; }
        public DbSet<Ocjene> Ocjene { get; set; }
        public DbSet<Zupanija> Zupanije { get; set; }
        public DbSet<Mjesto> Mjesta { get; set; }
        public DbSet<Nastavnik> Nastavnici { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            ///modelBuilder.Entity<Ocjene>()
            ///.HasOne(p => p.AppUser)
            ///.WithMany()
            ///.OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<MyFile>()
            //    .HasOne(p => p.Workspace)
            //    .WithMany(b => b.MyFile);

            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { ID = 1, NazivZupanija = "Zagrebačka" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { ID = 2, NazivZupanija = "Krapinsko-zagorska" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { ID = 3, NazivZupanija = "Sisačko-moslavačka" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { ID = 4, NazivZupanija = "Karlovačka" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { ID = 5, NazivZupanija = "Varaždinska" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { ID = 6, NazivZupanija = "Koprivničko-križevačka" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { ID = 7, NazivZupanija = "Bjelovarsko-bilogorska" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { ID = 8, NazivZupanija = "Primorsko-goranska" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { ID = 9, NazivZupanija = "Ličko-senjska" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { ID = 10, NazivZupanija = "Virovitičko-podravska" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { ID = 11, NazivZupanija = "Požeško-slavonska" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { ID = 12, NazivZupanija = "Brodsko-posavska" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { ID = 13, NazivZupanija = "Zadarska" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { ID = 14, NazivZupanija = "Osječko-baranjska" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { ID = 15, NazivZupanija = "Šibensko-kninska" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { ID = 16, NazivZupanija = "Vukovarsko-srijemska" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { ID = 17, NazivZupanija = "Splitsko-dalmatinska" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { ID = 18, NazivZupanija = "Istarska" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { ID = 19, NazivZupanija = "Dubrovačko-neretvanska" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { ID = 20, NazivZupanija = "Međimurska" });
            modelBuilder.Entity<Zupanija>().HasData(new Zupanija { ID = 21, NazivZupanija = "Grad Zagreb" });

            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 1, NazivMjesta = "Zagreb", ZupanijaId = 21 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 2, NazivMjesta = "Split", ZupanijaId = 17 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 3, NazivMjesta = "Rijeka", ZupanijaId = 8 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 4, NazivMjesta = "Osijek", ZupanijaId = 14 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 5, NazivMjesta = "Zadar", ZupanijaId = 13 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 6, NazivMjesta = "Slavonski Brod", ZupanijaId = 12 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 7, NazivMjesta = "Pula", ZupanijaId = 18 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 8, NazivMjesta = "Otočac", ZupanijaId = 9 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 9, NazivMjesta = "Kaštela", ZupanijaId = 17 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 10, NazivMjesta = "Karlovac", ZupanijaId = 4 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 11, NazivMjesta = "Sisak", ZupanijaId = 3 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 12, NazivMjesta = "Dubrovnik", ZupanijaId = 19 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 13, NazivMjesta = "Varaždin", ZupanijaId = 5 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 14, NazivMjesta = "Šibenik", ZupanijaId = 15 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 15, NazivMjesta = "Velika Gorica", ZupanijaId = 1 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 16, NazivMjesta = "Vinkovci", ZupanijaId = 16 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 17, NazivMjesta = "Vukovar", ZupanijaId = 16 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 18, NazivMjesta = "Bjelovar", ZupanijaId = 7 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 19, NazivMjesta = "Koprivnica", ZupanijaId = 6 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 20, NazivMjesta = "Đakovo", ZupanijaId = 14 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 21, NazivMjesta = "Požega", ZupanijaId = 11 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 22, NazivMjesta = "Zaprešić", ZupanijaId = 1 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 23, NazivMjesta = "Solin", ZupanijaId = 17 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 24, NazivMjesta = "Čakovec", ZupanijaId = 20 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 25, NazivMjesta = "Virovitica", ZupanijaId = 10 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 26, NazivMjesta = "Samobor", ZupanijaId = 1 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 27, NazivMjesta = "Kutina", ZupanijaId = 3 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 28, NazivMjesta = "Metković", ZupanijaId = 19 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 29, NazivMjesta = "Petrinja", ZupanijaId = 3 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 30, NazivMjesta = "Županja", ZupanijaId = 16 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 31, NazivMjesta = "Rovinj", ZupanijaId = 18 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 32, NazivMjesta = "Makarska", ZupanijaId = 17 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 33, NazivMjesta = "Nova Gradiška", ZupanijaId = 12 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 34, NazivMjesta = "Križevci", ZupanijaId = 6 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 35, NazivMjesta = "Sinj", ZupanijaId = 17 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 36, NazivMjesta = "Knin", ZupanijaId = 15 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 37, NazivMjesta = "Slatina", ZupanijaId = 10 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 38, NazivMjesta = "Trogir", ZupanijaId = 17 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 39, NazivMjesta = "Poreč", ZupanijaId = 18 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 40, NazivMjesta = "Sveta Nedelja", ZupanijaId = 1 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 41, NazivMjesta = "Dugo Selo", ZupanijaId = 1 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 42, NazivMjesta = "Našice", ZupanijaId = 14 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 43, NazivMjesta = "Jastrebarsko", ZupanijaId = 1 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 44, NazivMjesta = "Omiš", ZupanijaId = 17 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 45, NazivMjesta = "Vrbovec", ZupanijaId = 1 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 46, NazivMjesta = "Gospić", ZupanijaId = 9 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 47, NazivMjesta = "Krapina", ZupanijaId = 2 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 48, NazivMjesta = "Delnice", ZupanijaId = 8 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 49, NazivMjesta = "Ogulin", ZupanijaId = 4 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 50, NazivMjesta = "Opatija", ZupanijaId = 8 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 51, NazivMjesta = "Pazin", ZupanijaId = 18 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 52, NazivMjesta = "Pakrac", ZupanijaId = 11 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 53, NazivMjesta = "Drniš", ZupanijaId = 15 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 54, NazivMjesta = "Senj", ZupanijaId = 9 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 55, NazivMjesta = "Beli Manastir", ZupanijaId = 14 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 56, NazivMjesta = "Imotski", ZupanijaId = 17 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 57, NazivMjesta = "Ploče", ZupanijaId = 19 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 58, NazivMjesta = "Crikvenica", ZupanijaId = 8 });
            modelBuilder.Entity<Mjesto>().HasData(new Mjesto { ID = 59, NazivMjesta = "Ozalj", ZupanijaId = 4 });

            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 1, Naziv = "Agronomski fakultet u Zagrebu", Adresa = "Svetošimunska cesta 25", GodinaOsnutka = "1919", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 2, Naziv = "Akademija dramske umjetnosti u Zagrebu", Adresa = "Trg Republike Hrvatske 5", GodinaOsnutka = "1896", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 3, Naziv = "Akademija likovnih umjetnosti u Zagrebu", Adresa = "Ilica 85", GodinaOsnutka = "1907", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 4, Naziv = "Akademija primijenjenih umjetnosti u Rijeci", Adresa = "Slavka Krautzeka 83", GodinaOsnutka = "2005", MjestoId = 3 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 5, Naziv = "Arhitektonski fakultet u Zagrebu", Adresa = "Fra Andrije Kačića Miošića 26", GodinaOsnutka = "1919", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 6, Naziv = "Edukacijsko-rehabilitacijski fakultet u Zagrebu", Adresa = " Borongajska cesta 83f", GodinaOsnutka = "1962", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 7, Naziv = "Ekonomski fakultet u Osijeku", Adresa = "Trg Ljudevita Gaja 7", GodinaOsnutka = "1959", MjestoId = 4 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 8, Naziv = "Ekonomski fakultet u Splitu", Adresa = "Cvite Fiskovića 5", GodinaOsnutka = "1975", MjestoId = 2 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 9, Naziv = "Ekonomski fakultet u Zagrebu", Adresa = "Trg John F. Kennedy 6", GodinaOsnutka = "1920", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 10, Naziv = "Fakultet elektrotehnike i računarstva", Adresa = "Unska ul. 3", GodinaOsnutka = "1956", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 11, Naziv = "Fakultet elektrotehnike, računarstva i informacijskih tehnologija u Osijeku", Adresa = "Kneza Trpimira 2B", GodinaOsnutka = "1978", MjestoId = 4 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 12, Naziv = "Fakultet elektrotehnike, strojarstva i brodogradnje u Splitu", Adresa = "Ul. Ruđera Boškovića 32", GodinaOsnutka = "1960", MjestoId = 2 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 13, Naziv = "Fakultet hrvatskih studija", Adresa = "Borongajska cesta 83d", GodinaOsnutka = "1992", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 14, Naziv = "Fakultet kemijskog inženjerstva i tehnologije u Zagrebu", Adresa = "Trg Marka Marulića 19", GodinaOsnutka = "1919", MjestoId = 1});
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 15, Naziv = "Fakultet organizacije i informatike u Varaždinu", Adresa = "Pavlinska ul. 2", GodinaOsnutka = "1974", MjestoId = 13 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 16, Naziv = "Fakultet političkih znanosti u Zagrebu", Adresa = "Lepušićeva ul. 6", GodinaOsnutka = "1962", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 17, Naziv = "Fakultet prometnih znanosti u Zagrebu", Adresa = "Vukelićeva ul. 4", GodinaOsnutka = "1984", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 18, Naziv = "Fakultet strojarstva i brodogradnje", Adresa = "Ul. Ivana Lučića 5", GodinaOsnutka = "1956", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 19, Naziv = "Fakultet za odgojne i obrazovne znanosti u Osijeku", Adresa = "Ul. cara Hadrijana 10", GodinaOsnutka = "1961", MjestoId = 4 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 20, Naziv = "Farmaceutsko-biokemijski fakultet u Zagrebu", Adresa = "Ul. Ante Kovačića 1", GodinaOsnutka = "1882", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 21, Naziv = "Filozofski fakultet u Osijeku", Adresa = "Ul. Lorenza Jagera 9", GodinaOsnutka = "2004", MjestoId = 4 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 22, Naziv = "Filozofski fakultet u Rijeci", Adresa = "Sveučilišna Av 4", GodinaOsnutka = "1953", MjestoId = 3 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 23, Naziv = "Filozofski fakultet u Splitu", Adresa = "Poljička cesta 35", GodinaOsnutka = "2005", MjestoId = 2 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 24, Naziv = "Filozofski fakultet u Zadru", Adresa = "Ul. Mihovila Pavlinovića", GodinaOsnutka = "2002", MjestoId = 5 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 25, Naziv = "Filozofski fakultet u Zagrebu", Adresa = "Ul. Ivana Lučića 3", GodinaOsnutka = "1874", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 26, Naziv = "Geodetski fakultet u Zagrebu", Adresa = "Kačićeva ul. 26", GodinaOsnutka = "1962", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 27, Naziv = "Geotehnički fakultet u Varaždinu", Adresa = "Hallerova aleja 7", GodinaOsnutka = "1969", MjestoId = 13 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 28, Naziv = "Građevinski fakultet u Zagrebu", Adresa = "Kačićeva ul. 26", GodinaOsnutka = "1919", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 29, Naziv = "Građevinski i arhitektonski fakultet u Osijeku", Adresa = "Vladimira Preloga 3", GodinaOsnutka = "1967", MjestoId = 4 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 30, Naziv = "Grafički fakultet u Zagrebu", Adresa = "Getaldićeva ul. 2", GodinaOsnutka = "1959", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 31, Naziv = "Katolički bogoslovni fakultet u Đakovu", Adresa = "Petra Preradovića 17", GodinaOsnutka = "1806", MjestoId = 20 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 32, Naziv = "Katolički bogoslovni fakultet u Splitu", Adresa = "Ul. Zrinsko Frankopanska 19", GodinaOsnutka = "1999", MjestoId = 2 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 33, Naziv = "Katolički bogoslovni fakultet u Zagrebu", Adresa = "Vlaška ul. 38", GodinaOsnutka = "1670", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 34, Naziv = "Kineziološki fakultet u Zagrebu", Adresa = "Horvaćanski zavoj 15", GodinaOsnutka = "1959", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 35, Naziv = "Medicinski fakultet u Osijeku", Adresa = "Ul. Josipa Huttlera 4", GodinaOsnutka = "1998", MjestoId = 4 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 36, Naziv = "Medicinski fakultet u Rijeci", Adresa = "Ul. Braće Branchetta 20/1", GodinaOsnutka = "1955", MjestoId = 3 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 37, Naziv = "Medicinski fakultet u Splitu", Adresa = "Šoltanska ul. 2", GodinaOsnutka = "1997", MjestoId = 2 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 38, Naziv = "Medicinski fakultet u Zagrebu", Adresa = "Šalata ul. 2", GodinaOsnutka = "1917", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 39, Naziv = "Metalurški fakultet u Sisku", Adresa = "Aleja narodnih heroja 3", GodinaOsnutka = "1958", MjestoId = 11 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 40, Naziv = "Odjel za biologiju Sveučilišta Josipa Jurja Strossmayera u Osijeku", Adresa = "Ul. cara Hadrijana 8/A", GodinaOsnutka = "2005", MjestoId = 4 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 41, Naziv = "Odjel za fiziku Sveučilišta Josipa Jurja Strossmayera u Osijeku", Adresa = "Trg Ljudevita Gaja 6", GodinaOsnutka = "2005", MjestoId = 4 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 42, Naziv = "Odjel za informatiku Sveučilišta u Rijeci", Adresa = "Ul. Radmile Matejčić 2", GodinaOsnutka = "2008", MjestoId = 3 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 43, Naziv = "Poljoprivredni fakultet u Osijeku", Adresa = "Vladimira Preloga 1", GodinaOsnutka = "1960", MjestoId = 4 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 44, Naziv = "Pomorski fakultet u Splitu", Adresa = "Ul. Ruđera Boškovića 37", GodinaOsnutka = "1959", MjestoId = 2 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 45, Naziv = "Pravni fakultet u Osijeku", Adresa = "Ul. Stjepana Radića 13", GodinaOsnutka = "1975", MjestoId = 4 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 46, Naziv = "Pravni fakultet u Splitu", Adresa = "Ul. Domovinskog rata 8", GodinaOsnutka = "1961", MjestoId = 2 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 47, Naziv = "Pravni fakultet u Zagrebu", Adresa = "Trg Republike Hrvatske 14", GodinaOsnutka = "1776", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 48, Naziv = "Prehrambeno-biotehnološki fakultet u Zagrebu", Adresa = "Pierottijeva ul. 6", GodinaOsnutka = "1956", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 49, Naziv = "Prehrambeno-tehnološki fakultet u Osijeku", Adresa = "Ul. Franje Kuhača 20", GodinaOsnutka = "1976", MjestoId = 4 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 50, Naziv = "Prirodoslovno-matematički fakultet u Splitu", Adresa = "Ul. Ruđera Boškovića 33", GodinaOsnutka = "1945", MjestoId = 2 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 51, Naziv = "Prirodoslovno-matematički fakultet u Zagrebu", Adresa = "Horvatovac ul. 102a", GodinaOsnutka = "1946", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 52, Naziv = "Stomatološki fakultet u Zagrebu", Adresa = "Gundulićeva ul. 5", GodinaOsnutka = "1962", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 53, Naziv = "Strojarski fakultet u Slavonskom Brodu", Adresa = "Ul. Ivana Gundulića 20A", GodinaOsnutka = "1970", MjestoId = 6 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 54, Naziv = "Šumarski fakultet u Zagrebu", Adresa = "Svetošimunska cesta 25", GodinaOsnutka = "1898", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 55, Naziv = "Tehničko veleučilište u Zagrebu", Adresa = "Vrbik 8", GodinaOsnutka = "1998", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 56, Naziv = "Učiteljski fakultet u Zagrebu", Adresa = "Savska cesta 77", GodinaOsnutka = "2006", MjestoId = 1 });
            modelBuilder.Entity<Fakultet>().HasData(new Fakultet { ID = 57, Naziv = "Veterinarski fakultet u Zagrebu", Adresa = "Heinzelova ul. 55", GodinaOsnutka = "1919", MjestoId = 1 });

            modelBuilder.Entity<Nastavnik>().HasData
            (
                new Nastavnik { ID = 1, Ime = "Sanja", Prezime = "Sikora", TitulaIspred= "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 2, Ime = "Mihaela", Prezime = "Britvec", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 2 },
                new Nastavnik { ID = 3, Ime = "Ivo", Prezime = "Grgić", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 3 },
                new Nastavnik { ID = 4, Ime = "Marina", Prezime = "Ninčević", TitulaIspred = "Doc.dr.sc.", MjestoId = 4 },
                new Nastavnik { ID = 5, Ime = "Milan", Prezime = "Mesić", TitulaIspred = "Mag.oec", MjestoId = 5 },

                new Nastavnik { ID = 6, Ime = "Korina", Prezime = "Hunjak", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 7, Ime = "Siniša", Prezime = "Majkus", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 8, Ime = "Elvis", Prezime = "Krstulović", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 9, Ime = "Goran", Prezime = "Štimac", TitulaIspred = "Doc.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 10, Ime = "Marina", Prezime = "Banić-Zrinšćak", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 11, Ime = "Željka", Prezime = "Lapuh", TitulaIspred = "Prof.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 12, Ime = "Daniel", Prezime = "Jurić", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 6 },
                new Nastavnik { ID = 13, Ime = "Nikola", Prezime = "Bilić", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 5 },
                new Nastavnik { ID = 14, Ime = "Laura", Prezime = "Konda Labaš", TitulaIspred = "Doc.dr.sc.", MjestoId = 6 },
                new Nastavnik { ID = 15, Ime = "Marin", Prezime = "Bačić", TitulaIspred = "Mag.oec", MjestoId = 1 },

                new Nastavnik { ID = 16, Ime = "Emilija", Prezime = "Duparova", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 17, Ime = "Dajana", Prezime = "Radoš", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 18, Ime = "Marin", Prezime = "Lukanović", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 19, Ime = "Robert", Prezime = "Mijalić", TitulaIspred = "Doc.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 20, Ime = "Valentina", Prezime = "Lončarić", TitulaIspred = "Mag.oec", MjestoId = 2 },

                new Nastavnik { ID = 21, Ime = "Davor", Prezime = "Andrić", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 22, Ime = "Gorana", Prezime = "Aras Gazić", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 6 },
                new Nastavnik { ID = 23, Ime = "Dubravko", Prezime = "Bačić", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 5 },
                new Nastavnik { ID = 24, Ime = "Ana Martina", Prezime = "Bakić", TitulaIspred = "Doc.dr.sc.", MjestoId = 4 },
                new Nastavnik { ID = 25, Ime = "Alan", Prezime = "Braun", TitulaIspred = "Mag.oec", MjestoId = 2 },

                new Nastavnik { ID = 26, Ime = "Marko", Prezime = "Obad Šćitaroci", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 27, Ime = "Tin", Prezime = "Oberman", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 2 },
                new Nastavnik { ID = 28, Ime = "Veljko", Prezime = "Oluić", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 1 },
                new Nastavnik { ID = 29, Ime = "Milan", Prezime = "Opalić", TitulaIspred = "Doc.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 30, Ime = "Mladen", Prezime = "Orešić", TitulaIspred = "Mag.oec", MjestoId = 1 },

                new Nastavnik { ID = 31, Ime = "Ivan", Prezime = "Ferenčak", TitulaIspred = "Prof.dr.sc.", MjestoId = 2 },
                new Nastavnik { ID = 32, Ime = "Branko", Prezime = "Crnković", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 33, Ime = "Josip", Prezime = "Horvat", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 34, Ime = "Jasna", Prezime = "Mijoč", TitulaIspred = "Doc.dr.sc.", MjestoId = 4 },
                new Nastavnik { ID = 35, Ime = "Željka", Prezime = "Turkalj", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 36, Ime = "Ivana", Prezime = "Fosić", TitulaIspred = "Prof.dr.sc.", MjestoId = 6 },
                new Nastavnik { ID = 37, Ime = "Aleks", Prezime = "Živković", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 38, Ime = "Alma", Prezime = "Šundalić", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 4 },
                new Nastavnik { ID = 39, Ime = "Ljiljana", Prezime = "Radoš", TitulaIspred = "Doc.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 40, Ime = "Karlo", Prezime = "Knežević", TitulaIspred = "Mag.oec", MjestoId = 3 },

                new Nastavnik { ID = 41, Ime = "Branka", Prezime = "Marasović", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 42, Ime = "Snježana", Prezime = "Pivac", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 43, Ime = "Marija", Prezime = "Šimić Šarić", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 44, Ime = "Tino", Prezime = "Kusanović", TitulaIspred = "Doc.dr.sc.", MjestoId = 6 },
                new Nastavnik { ID = 45, Ime = "Tina", Prezime = "Vuko", TitulaIspred = "Mag.oec", MjestoId = 7 },
                
                new Nastavnik { ID = 46, Ime = "Vinko", Prezime = "Glavinić", TitulaIspred = "Prof.dr.sc.", MjestoId = 7 },
                new Nastavnik { ID = 47, Ime = "Ana", Prezime = "Aglić Aljinović", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 48, Ime = "Tajana", Prezime = "Burić", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 5 },
                new Nastavnik { ID = 49, Ime = "Goran", Prezime = "Gledec", TitulaIspred = "Doc.dr.sc.", MjestoId = 4 },
                new Nastavnik { ID = 50, Ime = "Ivan", Prezime = "Botički", TitulaIspred = "Mag.oec", MjestoId = 1 },

                new Nastavnik { ID = 51, Ime = "Dragan", Prezime = "Vulin", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 52, Ime = "Marinko", Prezime = "Barukčić", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 53, Ime = "Ivan", Prezime = "Biondić", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 54, Ime = "Luka", Prezime = "Filipović", TitulaIspred = "Doc.dr.sc.", MjestoId = 2 },
                new Nastavnik { ID = 55, Ime = "Tomislav", Prezime = "Matić", TitulaIspred = "Mag.oec", MjestoId = 2 },

                new Nastavnik { ID = 56, Ime = "Jani", Prezime = "Barle", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 57, Ime = "Ivan", Prezime = "Jadrić", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 58, Ime = "Josip", Prezime = "Eterović", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 1 },
                new Nastavnik { ID = 59, Ime = "Dario", Prezime = "Bezmalinović", TitulaIspred = "Doc.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 60, Ime = "Ivan", Prezime = "Tolj", TitulaIspred = "Mag.oec", MjestoId = 1 },

                new Nastavnik { ID = 61, Ime = "Slavko", Prezime = "Vulić Vranković", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 62, Ime = "Velimir", Prezime = "Franić Tomić", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 63, Ime = "Stanko", Prezime = "Tadić", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 1 },
                new Nastavnik { ID = 64, Ime = "Ivan", Prezime = "Kresnik", TitulaIspred = "Doc.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 65, Ime = "Daniel", Prezime = "Piskač", TitulaIspred = "Mag.oec", MjestoId = 1 },

                new Nastavnik { ID = 66, Ime = "Branimir", Prezime = "Zelić", TitulaIspred = "Prof.dr.sc.", MjestoId = 2 },
                new Nastavnik { ID = 67, Ime = "Nikola", Prezime = "Bolf", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 68, Ime = "Vlatka", Prezime = "Filipan", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 4 },
                new Nastavnik { ID = 69, Ime = "Šime", Prezime = "Ukić", TitulaIspred = "Doc.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 70, Ime = "Elvira", Prezime = "Begović Kovač", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 71, Ime = "Marijana", Prezime = "Ćurak", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 72, Ime = "Ana", Prezime = "Rimac Smiljanić", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 73, Ime = "Goran", Prezime = "Matijašić", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 74, Ime = "Janko", Prezime = "Peršun", TitulaIspred = "Doc.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 75, Ime = "Vlado", Prezime = "Tomašić", TitulaIspred = "Mag.oec", MjestoId = 5 },

                new Nastavnik { ID = 76, Ime = "Mario", Prezime = "Konecki", TitulaIspred = "Prof.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 77, Ime = "Andreja", Prezime = "Kovačić", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 78, Ime = "Igor", Prezime = "Balaban", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 79, Ime = "Nikola", Prezime = "Ivković", TitulaIspred = "Doc.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 80, Ime = "Ivan", Prezime = "Magdalenić", TitulaIspred = "Mag.oec", MjestoId = 2 },

                new Nastavnik { ID = 81, Ime = "Luka", Prezime = "Milić", TitulaIspred = "Prof.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 82, Ime = "Aleksandra", Prezime = "Sobodić", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 83, Ime = "Miran", Prezime = "Zlatović", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 84, Ime = "Elvis", Prezime = "Popović", TitulaIspred = "Doc.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 85, Ime = "Danijel", Prezime = "Filipović", TitulaIspred = "Mag.oec", MjestoId = 2 },

                new Nastavnik { ID = 86, Ime = "Blaženka", Prezime = "Divjak", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 87, Ime = "Zlatko", Prezime = "Erjavec", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 88, Ime = "Marcel", Prezime = "Maretić", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 89, Ime = "Damjan", Prezime = "Klemenčić", TitulaIspred = "Doc.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 90, Ime = "Mihaela", Prezime = "Laljek", TitulaIspred = "Mag.oec", MjestoId = 2 },

                new Nastavnik { ID = 91, Ime = "Lucija", Prezime = "Žignić", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 92, Ime = "Ivan", Prezime = "Malbašić", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 93, Ime = "Anamarija", Prezime = "Jelaković", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 94, Ime = "Nikolina", Prezime = "Posarić", TitulaIspred = "Doc.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 95, Ime = "Valentina", Prezime = "Kolačko", TitulaIspred = "Mag.oec", MjestoId = 2 },

                new Nastavnik { ID = 96, Ime = "Emina", Prezime = "Crleni", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 97, Ime = "Goran", Prezime = "Bubaš", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 98, Ime = "Violeta", Prezime = "Vidaček-Hainš", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 99, Ime = "Antonela", Prezime = "Čižmešija", TitulaIspred = "Doc.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 100, Ime = "Ana", Prezime = "Kutnjak", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 101, Ime = "Dijana", Prezime = "Plantak Vukovac", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 102, Ime = "Robert", Prezime = "Kudelić", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 103, Ime = "Damir", Prezime = "Vučić", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 104, Ime = "Kornelije", Prezime = "Rabuzin", TitulaIspred = "Doc.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 105, Ime = "Snježana", Prezime = "Križanić", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 106, Ime = "Bogdan", Prezime = "Okreša Đurić", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 107, Ime = "Stjepan", Prezime = "Dvorski", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 108, Ime = "Vladimir", Prezime = "Kovšca", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 109, Ime = "Ivana", Prezime = "Dvorski Lacković", TitulaIspred = "Doc.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 110, Ime = "Suzana", Prezime = "Keglević Kozjak", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 111, Ime = "Meri", Prezime = "Tadinac", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 112, Ime = "Katarina", Prezime = "Faraguna", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 113, Ime = "Andrea", Prezime = "Vranić", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 114, Ime = "Ivana", Prezime = "Hromatko", TitulaIspred = "Doc.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 115, Ime = "Dragutin", Prezime = "Ivanec", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 116, Ime = "Marina", Prezime = "Martinčević", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 117, Ime = "Denis", Prezime = "Bratko", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 118, Ime = "Dragutin", Prezime = "Ivanec", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 119, Ime = " Francesca", Prezime = "Dumančić", TitulaIspred = "Doc.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 120, Ime = "Denis", Prezime = "Vlašiček", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 121, Ime = "Vesna", Prezime = "Alikalfić", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 122, Ime = "Svetlana", Prezime = "Božić", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 123, Ime = "Mirjana", Prezime = "Tonković", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 124, Ime = "Tina", Prezime = "Miholjančan", TitulaIspred = "Doc.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 125, Ime = "Jasna", Prezime = "Ćirić", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 126, Ime = "Predrag", Prezime = "Lončar", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 127, Ime = "Sanja", Prezime = "Kovač", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 128, Ime = "Mladen", Prezime = "Božičević", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 129, Ime = "Mario", Prezime = "Šiljeg", TitulaIspred = "Doc.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 130, Ime = "Lucija", Prezime = "Radetić", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 131, Ime = "Zrinka", Prezime = "Lacković Vincek", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 132, Ime = "Ema", Prezime = "Novak", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 133, Ime = "Nina", Prezime = "Begičević Ređep", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 134, Ime = "Nikola", Prezime = "Kadoić", TitulaIspred = "Doc.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 135, Ime = "Barbara", Prezime = "Šlibar", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 136, Ime = "Mladen", Prezime = "Konecki", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 137, Ime = "Danijel", Prezime = "Radošević", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 138, Ime = "Vladimir", Prezime = "Bermanec", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 139, Ime = "Zoran", Prezime = "Glavaš", TitulaIspred = "Doc.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 140, Ime = "Mirko", Prezime = "Gojić", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 141, Ime = "Damir", Prezime = "Hršak", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 142, Ime = "Stjepan", Prezime = "Kožuh", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 143, Ime = "Ladislav", Prezime = "Lazić", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 144, Ime = "Anita", Prezime = "Begić Hadžipašić", TitulaIspred = "Doc.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 145, Ime = "Ivan", Prezime = "Brnardić", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 146, Ime = "Natalija", Prezime = "Dolić", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 147, Ime = "Tamara", Prezime = "Holjevac Grgurić", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 148, Ime = "Robert", Prezime = "Pezer", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 149, Ime = "Ljerka", Prezime = "Slokar Benić", TitulaIspred = "Doc.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 150, Ime = "Anita", Prezime = "Štrkalj", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 151, Ime = "Zdenka", Prezime = "Zovko Brodarac", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 152, Ime = "Jakov", Prezime = "Baleta", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 153, Ime = "Ivana", Prezime = "Ivanić", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 154, Ime = "Ivan", Prezime = "Ivec", TitulaIspred = "Doc.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 155, Ime = "Ivan", Prezime = "Jandrlić", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 156, Ime = "Martina", Prezime = "Lovrenić-Jugović", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 157, Ime = "Vesna", Prezime = "Ocelić Bulatović", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 158, Ime = "Sandra", Prezime = "Brajčinović", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 159, Ime = "Tin", Prezime = "Brlić", TitulaIspred = "Doc.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 160, Ime = "Damijan", Prezime = "Cerinski", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 161, Ime = "Igor", Prezime = "Jajčinović", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 162, Ime = "Barbara", Prezime = "Tubić Bulat", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 163, Ime = "Selim", Prezime = "Pašić", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 164, Ime = "Vibor", Prezime = "Roje", TitulaIspred = "Doc.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 165, Ime = "Darko", Prezime = "Bakšić", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 166, Ime = "Ivan", Prezime = "Perković", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 167, Ime = "Azra", Prezime = "Tafo", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 168, Ime = "Anamarija", Prezime = "Jazbec", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 169, Ime = "Mario", Prezime = "Božić", TitulaIspred = "Doc.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 170, Ime = "Dunja", Prezime = "Aljinović", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 171, Ime = "Bojan", Prezime = "Matoš", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 172, Ime = "Nikola", Prezime = "Pernar", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 173, Ime = "Tomislav", Prezime = "Poršinsky", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 174, Ime = "Boris", Prezime = "Hrašovec", TitulaIspred = "Doc.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 175, Ime = "Mario ", Prezime = "Šporčić", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 176, Ime = "Jelena", Prezime = "Kolić", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 177, Ime = "Tomislav", Prezime = "Sinković", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 178, Ime = "Marin", Prezime = "Hasan", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 179, Ime = "Daniel", Prezime = "Krstonošić", TitulaIspred = "Doc.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 180, Ime = "Krunoslav", Prezime = "Sever", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 181, Ime = "Željko", Prezime = "Zečić", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 182, Ime = "Andreja", Prezime = "Đuka", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 183, Ime = "Krešimir", Prezime = "Krapinec", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 184, Ime = "Ivan", Prezime = "Mlinar", TitulaIspred = "Doc.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 185, Ime = "Kajba", Prezime = "Davorin", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 186, Ime = "Roman", Prezime = "Rosavec", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 187, Ime = "Ivica", Prezime = "Tikvić", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 188, Ime = "Lea", Prezime = "Petrović Krajnik", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                new Nastavnik { ID = 189, Ime = "Igor", Prezime = "Poljak", TitulaIspred = "Doc.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 190, Ime = "Ernest", Prezime = "Goršić", TitulaIspred = "Mag.oec", MjestoId = 4 },

                new Nastavnik { ID = 191, Ime = "Marilena", Prezime = "Idžojtić", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 192, Ime = "Ante", Prezime = "Seletković", TitulaIspred = "Izv.prof.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 193, Ime = "Anka Ozana", Prezime = "Čavlović", TitulaIspred = "Univ.spec.st.eur.", MjestoId = 2 },
                
                new Nastavnik { ID = 194, Ime = "Ivan", Prezime = "Cesar", TitulaIspred = "Mag.oec", MjestoId = 1 },
                new Nastavnik { ID = 195, Ime = "Miroslav", Prezime = "Slamić", TitulaIspred = "Prof.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 196, Ime = "Sanja", Prezime = "Kraljević", TitulaIspred = "Doc.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 197, Ime = "Željko", Prezime = "Kovačević", TitulaIspred = "Mag.oec", MjestoId = 1 },
                new Nastavnik { ID = 198, Ime = "Davor", Prezime = "Cafuta", TitulaIspred = "Doc.dr.sc.", MjestoId = 1 },
                new Nastavnik { ID = 199, Ime = "Aleksander", Prezime = "Radovan", TitulaIspred = "Mag.oec", MjestoId = 1 },

                new Nastavnik { ID = 200, Ime = "Anka", Prezime = "Jurčević Lozančić", TitulaIspred = "Mag.oec", MjestoId = 1 },
                new Nastavnik { ID = 201, Ime = "Ivana", Prezime = "Golik Homolak", TitulaIspred = "Prof.dr.sc.", MjestoId = 2 },
                new Nastavnik { ID = 202, Ime = "Diana", Prezime = "Zalar", TitulaIspred = "Doc.dr.sc.", MjestoId = 3 },
                new Nastavnik { ID = 203, Ime = "Branimir", Prezime = "Stojanović", TitulaIspred = "Mag.oec", MjestoId = 4 },
                new Nastavnik { ID = 204, Ime = "Blaženka", Prezime = "Bačlija Sušić", TitulaIspred = "Doc.dr.sc.", MjestoId = 5 },
                new Nastavnik { ID = 205, Ime = "Danijel", Prezime = "Žabčić", TitulaIspred = "Mag.oec", MjestoId = 6 }
            );

            modelBuilder.Entity<Kolegij>().HasData
            (
                new Kolegij { ID = 1, Naziv = "Uvod u mikrobiologiju tla", FakultetId = 1, NastavnikId = 1 },
                new Kolegij { ID = 2, Naziv = "Botanika", FakultetId = 1, NastavnikId = 2 },
                new Kolegij { ID = 3, Naziv = "Osnove agroekonomike", FakultetId = 1, NastavnikId = 3 },
                new Kolegij { ID = 4, Naziv = "Matematika", FakultetId = 1, NastavnikId = 4 },
                new Kolegij { ID = 5, Naziv = "Agroklimatologija", FakultetId = 1, NastavnikId = 5 },

                new Kolegij { ID = 6, Naziv = "Dramsko pismo", FakultetId = 2, NastavnikId = 6 },
                new Kolegij { ID = 7, Naziv = "Filmsko pismo", FakultetId = 2, NastavnikId = 7 },
                new Kolegij { ID = 8, Naziv = "Estetika filma", FakultetId = 2, NastavnikId = 8 },
                new Kolegij { ID = 9, Naziv = "Analiza filma", FakultetId = 2, NastavnikId = 9 },
                new Kolegij { ID = 10, Naziv = "Dramatologija", FakultetId = 2, NastavnikId = 10 },

                new Kolegij { ID = 11, Naziv = "Crtanje", FakultetId = 3, NastavnikId = 11 },
                new Kolegij { ID = 12, Naziv = "Uvod u slikanje", FakultetId = 3, NastavnikId = 12 },
                new Kolegij { ID = 13, Naziv = "Kiparstvo", FakultetId = 3, NastavnikId = 13 },
                new Kolegij { ID = 14, Naziv = "Uvod u likovnu umjetnost", FakultetId = 3, NastavnikId = 14 },
                new Kolegij { ID = 15, Naziv = "Sociologija kulture", FakultetId = 3, NastavnikId = 15 },

                new Kolegij { ID = 16, Naziv = "Književnost", FakultetId = 4, NastavnikId = 16 },
                new Kolegij { ID = 17, Naziv = "Svjetska književnost", FakultetId = 4, NastavnikId = 17 },
                new Kolegij { ID = 18, Naziv = "Povijest kazališta i drame", FakultetId = 4, NastavnikId = 18 },
                new Kolegij { ID = 19, Naziv = "Film i druge umjetnosti", FakultetId = 4, NastavnikId = 19 },
                new Kolegij { ID = 20, Naziv = "Radiofonija", FakultetId = 4, NastavnikId = 20 },

                new Kolegij { ID = 21, Naziv = "Zgrade za rad i trgovinu", FakultetId = 5, NastavnikId = 21 },
                new Kolegij { ID = 22, Naziv = "Osnove nacrtne geometrije", FakultetId = 5, NastavnikId = 22 },
                new Kolegij { ID = 23, Naziv = "Uvod u primjenu računala", FakultetId = 5, NastavnikId = 23 },
                new Kolegij { ID = 24, Naziv = "Pri­mje­na ra­ču­na­la u ar­hi­tek­tu­ri", FakultetId = 5, NastavnikId = 24 },
                new Kolegij { ID = 25, Naziv = "Uvod u pro­jek­ti­ra­nje stam­be­nih zgra­da", FakultetId = 5, NastavnikId = 25 },

                new Kolegij { ID = 26, Naziv = "Osnove humane genetike", FakultetId = 6, NastavnikId = 26 },
                new Kolegij { ID = 27, Naziv = "Funkcionalna anatomija i fiziologija", FakultetId = 6, NastavnikId = 27 },
                new Kolegij { ID = 28, Naziv = "Uvod u psihologiju djetinjstva i adolescencije", FakultetId = 6, NastavnikId = 28 },
                new Kolegij { ID = 29, Naziv = "Motorički poremećaji, kronične bolesti i sofrologija", FakultetId = 6, NastavnikId = 29 },
                new Kolegij { ID = 30, Naziv = "Statistika", FakultetId = 6, NastavnikId = 30 },

                new Kolegij { ID = 31, Naziv = "Počela ekonomije", FakultetId = 7, NastavnikId = 31 },
                new Kolegij { ID = 32, Naziv = "Statistika", FakultetId = 7, NastavnikId = 32 },
                new Kolegij { ID = 33, Naziv = "Osnove organizacije ", FakultetId = 7, NastavnikId = 33 },
                new Kolegij { ID = 34, Naziv = "Sociologija", FakultetId = 7, NastavnikId = 34 },
                new Kolegij { ID = 35, Naziv = "Engleski jezik 1", FakultetId = 7, NastavnikId = 35 },

                new Kolegij { ID = 36, Naziv = "Aktuarska matematika", FakultetId = 8, NastavnikId = 36 },
                new Kolegij { ID = 37, Naziv = "Alternativni izvori financiranja", FakultetId = 8, NastavnikId = 37 },
                new Kolegij { ID = 38, Naziv = "Analiza financijskih izvješća", FakultetId = 8, NastavnikId = 38 },
                new Kolegij { ID = 39, Naziv = "Bankarstvo", FakultetId = 8, NastavnikId = 39 },
                new Kolegij { ID = 40, Naziv = "Burze i vrijednosnice", FakultetId = 8, NastavnikId = 40 },

                new Kolegij { ID = 41, Naziv = "Ekonometrija", FakultetId = 9, NastavnikId = 41 },
                new Kolegij { ID = 42, Naziv = "Ekonomija tržišta rada", FakultetId = 9, NastavnikId = 42 },
                new Kolegij { ID = 43, Naziv = "E-marketing", FakultetId = 9, NastavnikId = 43 },
                new Kolegij { ID = 44, Naziv = "Financijski sustav", FakultetId = 9, NastavnikId = 44 },
                new Kolegij { ID = 45, Naziv = "Gospodarstvo Hrvatske", FakultetId = 9, NastavnikId = 45 },

                new Kolegij { ID = 46, Naziv = "Digitalna logika", FakultetId = 10, NastavnikId = 46 },
                new Kolegij { ID = 47, Naziv = "Linearna algebra", FakultetId = 10, NastavnikId = 47 },
                new Kolegij { ID = 48, Naziv = "Matematička analiza 1", FakultetId = 10, NastavnikId = 48 },
                new Kolegij { ID = 49, Naziv = "Uvod u programiranje", FakultetId = 10, NastavnikId = 49 },
                new Kolegij { ID = 50, Naziv = "Algoritmi i strukture podataka", FakultetId = 10, NastavnikId = 50 },

                new Kolegij { ID = 51, Naziv = "Osnove elektrotehnike i elektronike", FakultetId = 11, NastavnikId = 51 },
                new Kolegij { ID = 52, Naziv = "Inženjerska grafika i dokumentiranje", FakultetId = 11, NastavnikId = 52 },
                new Kolegij { ID = 53, Naziv = "Programiranje I", FakultetId = 11, NastavnikId = 53 },
                new Kolegij { ID = 54, Naziv = "Matematičke osnove računarstva", FakultetId = 11, NastavnikId = 54 },
                new Kolegij { ID = 55, Naziv = "Engleski jezik", FakultetId = 11, NastavnikId = 55 },

                new Kolegij { ID = 56, Naziv = "Matematika 1 ", FakultetId = 12, NastavnikId = 56 },
                new Kolegij { ID = 57, Naziv = "Materijali 1", FakultetId = 12, NastavnikId = 57 },
                new Kolegij { ID = 58, Naziv = "Mehanika 1", FakultetId = 12, NastavnikId = 58 },
                new Kolegij { ID = 59, Naziv = "Fizika", FakultetId = 12, NastavnikId = 59 },
                new Kolegij { ID = 60, Naziv = "Inženjerska grafika 1", FakultetId = 12, NastavnikId = 60 },

                new Kolegij { ID = 61, Naziv = "Fonologija hrvatskoga jezika", FakultetId = 13, NastavnikId = 61 },
                new Kolegij { ID = 62, Naziv = "Hrvatska književnost srednjovjekovlja", FakultetId = 13, NastavnikId = 62 },
                new Kolegij { ID = 63, Naziv = "Hrvatski identitet u europskom kontekstu", FakultetId = 13, NastavnikId = 63 },
                new Kolegij { ID = 64, Naziv = "Osnove hrvatske jezične kulture", FakultetId = 13, NastavnikId = 64 },
                new Kolegij { ID = 65, Naziv = "Uvod u kroatologiju", FakultetId = 13, NastavnikId = 65 },

                new Kolegij { ID = 66, Naziv = "Analitička kemija", FakultetId = 14, NastavnikId = 66 },
                new Kolegij { ID = 67, Naziv = "Osnove elektrotehnike", FakultetId = 14, NastavnikId = 67 },
                new Kolegij { ID = 68, Naziv = "Opća i anorganska kemija", FakultetId = 14, NastavnikId = 68 },
                new Kolegij { ID = 69, Naziv = "Osnove strojarstva", FakultetId = 14, NastavnikId = 69 },
                new Kolegij { ID = 70, Naziv = "Bilanca tvari i energije", FakultetId = 14, NastavnikId = 70 },

                new Kolegij { ID = 71, Naziv = "Engleski jezik u informatičkoj struci", FakultetId = 15, NastavnikId = 71 },
                new Kolegij { ID = 72, Naziv = "Informacijski i računalni sustavi", FakultetId = 15, NastavnikId = 72 },
                new Kolegij { ID = 73, Naziv = "Organizacija", FakultetId = 15, NastavnikId = 73 },
                new Kolegij { ID = 74, Naziv = "Poslovno komuniciranje", FakultetId = 15, NastavnikId = 74 },
                new Kolegij { ID = 75, Naziv = "Programiranje 1", FakultetId = 15, NastavnikId = 75 },

                new Kolegij { ID = 76, Naziv = "Uvod u novinarstvo", FakultetId = 16, NastavnikId = 76 },
                new Kolegij { ID = 77, Naziv = "Komunikologija", FakultetId = 16, NastavnikId = 77 },
                new Kolegij { ID = 78, Naziv = "Mediji i nasilje", FakultetId = 16, NastavnikId = 78 },
                
                new Kolegij { ID = 79, Naziv = "Održavanje vozila javnog gradskog prijevoza", FakultetId = 17, NastavnikId = 79 },
                new Kolegij { ID = 80, Naziv = "Vozila za javni gradski prijevoz", FakultetId = 17, NastavnikId = 80 },
                new Kolegij { ID = 81, Naziv = "Gradske prometnice", FakultetId = 17, NastavnikId = 81 },
                
                new Kolegij { ID = 82, Naziv = "Matematika I", FakultetId = 18, NastavnikId = 82 },
                new Kolegij { ID = 83, Naziv = "Mehanika I", FakultetId = 18, NastavnikId = 83 },
                new Kolegij { ID = 84, Naziv = "Materijali I", FakultetId = 18, NastavnikId = 84 },
                new Kolegij { ID = 85, Naziv = "Računalna i inženjerska grafika", FakultetId = 18, NastavnikId = 85 },

                new Kolegij { ID = 86, Naziv = "Hrvatska povijest", FakultetId = 19, NastavnikId = 86 },
                new Kolegij { ID = 87, Naziv = "Nenasilna komunikacija", FakultetId = 19, NastavnikId = 87 },
                new Kolegij { ID = 88, Naziv = "Pedagogija", FakultetId = 19, NastavnikId = 88 },
                
                new Kolegij { ID = 89, Naziv = "Uvod u farmaciju", FakultetId = 20, NastavnikId = 89 },
                new Kolegij { ID = 90, Naziv = "Matematika sa statističkom analizom", FakultetId = 20, NastavnikId = 90 },
                new Kolegij { ID = 91, Naziv = "Stanična biologija s genetikom", FakultetId = 20, NastavnikId = 91 },

                new Kolegij { ID = 92, Naziv = "Grčka filozofija I", FakultetId = 21, NastavnikId = 92 },
                new Kolegij { ID = 93, Naziv = "Uvod u filozofiju", FakultetId = 21, NastavnikId = 93 },
                new Kolegij { ID = 94, Naziv = "Filozofija politike", FakultetId = 21, NastavnikId = 94 },

                new Kolegij { ID = 95, Naziv = "Metodologija istraživanja u kulturi", FakultetId = 22, NastavnikId = 95 },
                new Kolegij { ID = 96, Naziv = "Uvod u filozofiju", FakultetId = 22, NastavnikId = 96 },
                new Kolegij { ID = 97, Naziv = "Uvod u kulturalne studije", FakultetId = 22, NastavnikId = 97 },

                new Kolegij { ID = 98, Naziv = "Povijest starih civilizacija", FakultetId = 23, NastavnikId = 98 },
                new Kolegij { ID = 99, Naziv = "Povijest Grčke i Rima sa starom poviješću hrvatskih zemalja", FakultetId = 23, NastavnikId = 99 },
                new Kolegij { ID = 100, Naziv = "Latinski jezik", FakultetId = 23, NastavnikId = 100 },

                new Kolegij { ID = 101, Naziv = "Osnove usmene i pisane kulture", FakultetId = 24, NastavnikId = 101 },
                new Kolegij { ID = 102, Naziv = "Osnove informacijske tehnologije", FakultetId = 24, NastavnikId = 102 },
                new Kolegij { ID = 103, Naziv = "Pretraživanje informacija", FakultetId = 24, NastavnikId = 103 },

                new Kolegij { ID = 104, Naziv = "Biološka psihologija I", FakultetId = 25, NastavnikId = 104 },
                new Kolegij { ID = 105, Naziv = "Percepcija i pamćenje", FakultetId = 25, NastavnikId = 105 },
                new Kolegij { ID = 106, Naziv = "Psihologija kao znanost i struka", FakultetId = 25, NastavnikId = 106 },

                new Kolegij { ID = 107, Naziv = "Geodetski instrumenti", FakultetId = 26, NastavnikId = 107 },
                new Kolegij { ID = 108, Naziv = "Inženjerska grafika u geodeziji i geoinformatici", FakultetId = 26, NastavnikId = 108 },
                new Kolegij { ID = 109, Naziv = "Analitička geometrija i linearna algebra", FakultetId = 26, NastavnikId = 109 },

                new Kolegij { ID = 110, Naziv = "Osnove zaštite okoliša", FakultetId = 27, NastavnikId = 110 },
                new Kolegij { ID = 111, Naziv = "Nacrtna geometrija", FakultetId = 27, NastavnikId = 111 },
                new Kolegij { ID = 112, Naziv = "Geologija", FakultetId = 27, NastavnikId = 112 },

                new Kolegij { ID = 113, Naziv = "Deskriptivna geometrija", FakultetId = 28, NastavnikId = 113 },
                new Kolegij { ID = 114, Naziv = "Geodezija", FakultetId = 28, NastavnikId = 114 },
                new Kolegij { ID = 115, Naziv = "Matematički programi za inženjere", FakultetId = 28, NastavnikId = 115 },

                new Kolegij { ID = 116, Naziv = "Konstrukcijska geometrija", FakultetId = 29, NastavnikId = 116 },
                new Kolegij { ID = 117, Naziv = "Uvod u graditeljstvo", FakultetId = 29, NastavnikId = 117 },
                new Kolegij { ID = 118, Naziv = "Poznavanje materijala", FakultetId = 29, NastavnikId = 118 },

                new Kolegij { ID = 119, Naziv = "Inženjerska grafika", FakultetId = 30, NastavnikId = 119 },
                new Kolegij { ID = 120, Naziv = "Tehnička mehanika", FakultetId = 30, NastavnikId = 120 },
                new Kolegij { ID = 121, Naziv = "Likovno grafička kultura 1", FakultetId = 30, NastavnikId = 121 },

                new Kolegij { ID = 122, Naziv = "Uvod u misterij Krista i povijest spasenja", FakultetId = 31, NastavnikId = 122 },
                new Kolegij { ID = 123, Naziv = "Hebrejski jezik", FakultetId = 31, NastavnikId = 123 },
                new Kolegij { ID = 124, Naziv = "Opća crkvena povijest, I.: stari i srednji vijek", FakultetId = 31, NastavnikId = 124 },

                new Kolegij { ID = 125, Naziv = "Crkvena umjetnost", FakultetId = 32, NastavnikId = 125 },
                new Kolegij { ID = 126, Naziv = "Razvojna psihologija", FakultetId = 32, NastavnikId = 126 },
                new Kolegij { ID = 127, Naziv = "Uvod u filozofiju", FakultetId = 32, NastavnikId = 127 },

                new Kolegij { ID = 128, Naziv = "Patrologija", FakultetId = 33, NastavnikId = 128 },
                new Kolegij { ID = 129, Naziv = "Uvod u filozofiju i teologiju", FakultetId = 33, NastavnikId = 129 },
                new Kolegij { ID = 130, Naziv = "Opći uvod u Sveto pismo", FakultetId = 33, NastavnikId = 130 },
                
                new Kolegij { ID = 131, Naziv = "Atletika-hodanja i trčanja", FakultetId = 34, NastavnikId = 131 },
                new Kolegij { ID = 132, Naziv = "Funkcionalna anatomija", FakultetId = 34, NastavnikId = 132 },
                new Kolegij { ID = 133, Naziv = "Osnovne kineziološke transformacije I", FakultetId = 34, NastavnikId = 133 },
                
                new Kolegij { ID = 134, Naziv = "Medicinska biologija", FakultetId = 35, NastavnikId = 134 },
                new Kolegij { ID = 135, Naziv = "Medicinska fizika i biofizika", FakultetId = 35, NastavnikId = 135 },
                new Kolegij { ID = 136, Naziv = "Medicinska kemija i biokemija", FakultetId = 35, NastavnikId = 136 },
               
                new Kolegij { ID = 137, Naziv = "Uvod u medicinu i povijest medicine", FakultetId = 36, NastavnikId = 137 },
                new Kolegij { ID = 138, Naziv = "Socijalna medicina", FakultetId = 36, NastavnikId = 138 },
                new Kolegij { ID = 139, Naziv = "Psihološka medicina", FakultetId = 36, NastavnikId = 139 },

                new Kolegij { ID = 140, Naziv = "Imunologija i medicinska genetika", FakultetId = 37, NastavnikId = 140 },
                new Kolegij { ID = 141, Naziv = "Temelji neuroznanosti", FakultetId = 37, NastavnikId = 141 },
                new Kolegij { ID = 142, Naziv = "Fiziologija", FakultetId = 37, NastavnikId = 142 },

                new Kolegij { ID = 143, Naziv = "Anatomija", FakultetId = 38, NastavnikId = 143 },
                new Kolegij { ID = 144, Naziv = "Medicinska biologija", FakultetId = 38, NastavnikId = 144 },
                new Kolegij { ID = 145, Naziv = "Fizika i biofizika", FakultetId = 38, NastavnikId = 145 },

                new Kolegij { ID = 146, Naziv = "Matematika 1 ", FakultetId = 39, NastavnikId = 146 },
                new Kolegij { ID = 147, Naziv = "Fizika", FakultetId = 39, NastavnikId = 147 },
                new Kolegij { ID = 148, Naziv = "Uvod u metalurgiju", FakultetId = 39, NastavnikId = 148 },

                new Kolegij { ID = 149, Naziv = "Biologija stanice", FakultetId = 40, NastavnikId = 149 },
                new Kolegij { ID = 150, Naziv = "Mikrobiologija", FakultetId = 40, NastavnikId = 150 },
                new Kolegij { ID = 151, Naziv = "Opća zoologija", FakultetId = 40, NastavnikId = 151 },

                new Kolegij { ID = 152, Naziv = "Osnove informatike", FakultetId = 41, NastavnikId = 152 },
                new Kolegij { ID = 153, Naziv = "Osnove fizike 1", FakultetId = 41, NastavnikId = 153 },
                new Kolegij { ID = 154, Naziv = "Matematika 1", FakultetId = 41, NastavnikId = 154 },

                new Kolegij { ID = 155, Naziv = "Programiranje 1", FakultetId = 42, NastavnikId = 155 },
                new Kolegij { ID = 156, Naziv = "Osnove informatike", FakultetId = 42, NastavnikId = 156 },
                new Kolegij { ID = 157, Naziv = "Multimedijski sustavi", FakultetId = 42, NastavnikId = 157 },

                new Kolegij { ID = 158, Naziv = "Poljoprivredna botanika", FakultetId = 43, NastavnikId = 158 },
                new Kolegij { ID = 159, Naziv = "Primjena računala u poljoprivredi", FakultetId = 43, NastavnikId = 159 },
                new Kolegij { ID = 160, Naziv = "Pedologija", FakultetId = 43, NastavnikId = 160 },

                new Kolegij { ID = 161, Naziv = "Brodska elektrotehnika", FakultetId = 44, NastavnikId = 161 },
                new Kolegij { ID = 162, Naziv = "Poznavanje broda i plovidbe", FakultetId = 44, NastavnikId = 162 },
                new Kolegij { ID = 163, Naziv = "Matematika I", FakultetId = 44, NastavnikId = 163 },

                new Kolegij { ID = 164, Naziv = "Teorija prava i države", FakultetId = 45, NastavnikId = 164 },
                new Kolegij { ID = 165, Naziv = "Povijest hrvatskog prava i države", FakultetId = 45, NastavnikId = 165 },
                new Kolegij { ID = 166, Naziv = "Seminar", FakultetId = 45, NastavnikId = 166 },

                new Kolegij { ID = 167, Naziv = "Opća pravna povijest", FakultetId = 46, NastavnikId = 167 },
                new Kolegij { ID = 168, Naziv = "Socijologija", FakultetId = 46, NastavnikId = 168 },
                new Kolegij { ID = 169, Naziv = "Politička ekonomija", FakultetId = 46, NastavnikId = 169 },

                new Kolegij { ID = 170, Naziv = "Opća povijest prava i države", FakultetId = 47, NastavnikId = 170 },
                new Kolegij { ID = 171, Naziv = "Rimsko privatno pravo", FakultetId = 47, NastavnikId = 171 },
                new Kolegij { ID = 172, Naziv = "Hrvatska pravna povijest u europskom kontekstu", FakultetId = 47, NastavnikId = 172 },

                new Kolegij { ID = 173, Naziv = "Opća kemija", FakultetId = 48, NastavnikId = 173 },
                new Kolegij { ID = 174, Naziv = "Uvod u prehrambene tehnologije", FakultetId = 48, NastavnikId = 174 },
                new Kolegij { ID = 175, Naziv = "Organska kemija", FakultetId = 48, NastavnikId = 175 },

                new Kolegij { ID = 176, Naziv = "Opća i anorganska kemija", FakultetId = 49, NastavnikId = 176 },
                new Kolegij { ID = 177, Naziv = "Analitička kemija", FakultetId = 49, NastavnikId = 177 },
                new Kolegij { ID = 178, Naziv = "Tehnička fizika", FakultetId = 49, NastavnikId = 178 },

                new Kolegij { ID = 179, Naziv = "Osnove matematike", FakultetId = 50, NastavnikId = 179 },
                new Kolegij { ID = 180, Naziv = "Uvod u algebru s analitičkom geometrijom", FakultetId = 50, NastavnikId = 180 },
                new Kolegij { ID = 181, Naziv = "Programiranje I", FakultetId = 50, NastavnikId = 181 },

                new Kolegij { ID = 182, Naziv = "Matematika", FakultetId = 51, NastavnikId = 182 },
                new Kolegij { ID = 183, Naziv = "Opća zoologija", FakultetId = 51, NastavnikId = 183 },
                new Kolegij { ID = 184, Naziv = "Stanična i molekularna biologija", FakultetId = 51, NastavnikId = 184 },

                new Kolegij { ID = 185, Naziv = "Histologija s embriologijom", FakultetId = 52, NastavnikId = 185 },
                new Kolegij { ID = 186, Naziv = "Uvod u dentalnu medicinu", FakultetId = 52, NastavnikId = 186 },
                new Kolegij { ID = 187, Naziv = "Stanična biologija s genetikom", FakultetId = 52, NastavnikId = 187 },

                new Kolegij { ID = 188, Naziv = "Alati i naprave I", FakultetId = 53, NastavnikId = 188 },
                new Kolegij { ID = 189, Naziv = "Automatizacija", FakultetId = 53, NastavnikId = 189 },
                new Kolegij { ID = 190, Naziv = "Čvrstoća", FakultetId = 53, NastavnikId = 190 },

                new Kolegij { ID = 191, Naziv = "Kemija s biokemijom", FakultetId = 54, NastavnikId = 191 },
                new Kolegij { ID = 192, Naziv = "Zoologija u šumarstvu", FakultetId = 54, NastavnikId = 192 },
                new Kolegij { ID = 193, Naziv = "Petrologija s geologijom", FakultetId = 54, NastavnikId = 193 },

                new Kolegij { ID = 194, Naziv = "Programiranje", FakultetId = 55, NastavnikId = 194 },
                new Kolegij { ID = 195, Naziv = "Objektno orijentirano programiranje", FakultetId = 55, NastavnikId = 195 },
                new Kolegij { ID = 196, Naziv = "Uvod u web tehnologije	", FakultetId = 55, NastavnikId = 196 },
                new Kolegij { ID = 197, Naziv = "Algoritmi i strukture podataka", FakultetId = 55, NastavnikId = 197 },
                new Kolegij { ID = 198, Naziv = "Operacijski sustavi", FakultetId = 55, NastavnikId = 198 },
                new Kolegij { ID = 199, Naziv = "Programiranje u jeziku Java", FakultetId = 55, NastavnikId = 199 },

                new Kolegij { ID = 200, Naziv = "Pedagogija ranoga odgoja 1", FakultetId = 56, NastavnikId = 200 },
                new Kolegij { ID = 201, Naziv = "Razvojna psihologija 1", FakultetId = 56, NastavnikId = 201 },
                new Kolegij { ID = 202, Naziv = "Glazbena kultura", FakultetId = 56, NastavnikId = 202 },

                new Kolegij { ID = 203, Naziv = "Uvod u veterinarstvo", FakultetId = 57, NastavnikId = 203 },
                new Kolegij { ID = 204, Naziv = "Anatomija s organogenezom domaćih životinja", FakultetId = 57, NastavnikId = 204 },
                new Kolegij { ID = 205, Naziv = "Botanika u veterinarskoj medicini", FakultetId = 57, NastavnikId = 205 }
            );
        }
    }
}

