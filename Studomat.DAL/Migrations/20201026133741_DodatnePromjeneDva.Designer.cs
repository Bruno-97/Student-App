﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Studomat.DAL;

namespace Studomat.DAL.Migrations
{
    [DbContext(typeof(StudentManagerDbContext))]
    [Migration("20201026133741_DodatnePromjeneDva")]
    partial class DodatnePromjeneDva
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Studomat.MODEL.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime>("DatumRodjenja");

                    b.Property<DateTime>("DatumUpisa");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<int?>("FakultetId");

                    b.Property<string>("Ime");

                    b.Property<string>("JMBAG");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<int?>("MjestoId");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("OIB");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("Prezime");

                    b.Property<string>("SecurityStamp");

                    b.Property<string>("Status");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("FakultetId");

                    b.HasIndex("MjestoId");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Studomat.MODEL.Fakultet", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa");

                    b.Property<DateTime>("DatumOsnutka");

                    b.Property<int?>("MjestoId");

                    b.Property<string>("Naziv");

                    b.HasKey("ID");

                    b.HasIndex("MjestoId");

                    b.ToTable("Fakulteti");
                });

            modelBuilder.Entity("Studomat.MODEL.Kolegij", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AppUserId");

                    b.Property<int?>("FakultetId");

                    b.Property<int?>("NastavnikId");

                    b.Property<string>("Naziv");

                    b.Property<string>("Opis");

                    b.HasKey("ID");

                    b.HasIndex("AppUserId");

                    b.HasIndex("FakultetId");

                    b.HasIndex("NastavnikId");

                    b.ToTable("Kolegiji");
                });

            modelBuilder.Entity("Studomat.MODEL.Mjesto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NazivMjesta");

                    b.Property<int?>("ZupanijaId");

                    b.HasKey("ID");

                    b.HasIndex("ZupanijaId");

                    b.ToTable("Mjesta");

                    b.HasData(
                        new { ID = 1, NazivMjesta = "Zagreb", ZupanijaId = 21 },
                        new { ID = 2, NazivMjesta = "Split", ZupanijaId = 17 },
                        new { ID = 3, NazivMjesta = "Rijeka", ZupanijaId = 8 },
                        new { ID = 4, NazivMjesta = "Osijek", ZupanijaId = 14 },
                        new { ID = 5, NazivMjesta = "Zadar", ZupanijaId = 13 },
                        new { ID = 6, NazivMjesta = "Slavonski Brod", ZupanijaId = 12 },
                        new { ID = 7, NazivMjesta = "Pula", ZupanijaId = 18 },
                        new { ID = 8, NazivMjesta = "Otočac", ZupanijaId = 9 },
                        new { ID = 9, NazivMjesta = "Kaštela", ZupanijaId = 17 },
                        new { ID = 10, NazivMjesta = "Karlovac", ZupanijaId = 4 },
                        new { ID = 11, NazivMjesta = "Sisak", ZupanijaId = 3 },
                        new { ID = 12, NazivMjesta = "Dubrovnik", ZupanijaId = 19 },
                        new { ID = 13, NazivMjesta = "Varaždin", ZupanijaId = 5 },
                        new { ID = 14, NazivMjesta = "Šibenik", ZupanijaId = 15 },
                        new { ID = 15, NazivMjesta = "Velika Gorica", ZupanijaId = 1 },
                        new { ID = 16, NazivMjesta = "Vinkovci", ZupanijaId = 16 },
                        new { ID = 17, NazivMjesta = "Vukovar", ZupanijaId = 16 },
                        new { ID = 18, NazivMjesta = "Bjelovar", ZupanijaId = 7 },
                        new { ID = 19, NazivMjesta = "Koprivnica", ZupanijaId = 6 },
                        new { ID = 20, NazivMjesta = "Đakovo", ZupanijaId = 14 },
                        new { ID = 21, NazivMjesta = "Požega", ZupanijaId = 11 },
                        new { ID = 22, NazivMjesta = "Zaprešić", ZupanijaId = 1 },
                        new { ID = 23, NazivMjesta = "Solin", ZupanijaId = 17 },
                        new { ID = 24, NazivMjesta = "Čakovec", ZupanijaId = 20 },
                        new { ID = 25, NazivMjesta = "Virovitica", ZupanijaId = 10 },
                        new { ID = 26, NazivMjesta = "Samobor", ZupanijaId = 1 },
                        new { ID = 27, NazivMjesta = "Kutina", ZupanijaId = 3 },
                        new { ID = 28, NazivMjesta = "Metković", ZupanijaId = 19 },
                        new { ID = 29, NazivMjesta = "Petrinja", ZupanijaId = 3 },
                        new { ID = 30, NazivMjesta = "Županja", ZupanijaId = 16 },
                        new { ID = 31, NazivMjesta = "Rovinj", ZupanijaId = 18 },
                        new { ID = 32, NazivMjesta = "Makarska", ZupanijaId = 17 },
                        new { ID = 33, NazivMjesta = "Nova Gradiška", ZupanijaId = 12 },
                        new { ID = 34, NazivMjesta = "Križevci", ZupanijaId = 6 },
                        new { ID = 35, NazivMjesta = "Sinj", ZupanijaId = 17 },
                        new { ID = 36, NazivMjesta = "Knin", ZupanijaId = 15 },
                        new { ID = 37, NazivMjesta = "Slatina", ZupanijaId = 10 },
                        new { ID = 38, NazivMjesta = "Trogir", ZupanijaId = 17 },
                        new { ID = 39, NazivMjesta = "Poreč", ZupanijaId = 18 },
                        new { ID = 40, NazivMjesta = "Sveta Nedelja", ZupanijaId = 1 },
                        new { ID = 41, NazivMjesta = "Dugo Selo", ZupanijaId = 1 },
                        new { ID = 42, NazivMjesta = "Našice", ZupanijaId = 14 },
                        new { ID = 43, NazivMjesta = "Jastrebarsko", ZupanijaId = 1 },
                        new { ID = 44, NazivMjesta = "Omiš", ZupanijaId = 17 },
                        new { ID = 45, NazivMjesta = "Vrbovec", ZupanijaId = 1 },
                        new { ID = 46, NazivMjesta = "Gospić", ZupanijaId = 9 },
                        new { ID = 47, NazivMjesta = "Krapina", ZupanijaId = 2 },
                        new { ID = 48, NazivMjesta = "Delnice", ZupanijaId = 8 },
                        new { ID = 49, NazivMjesta = "Ogulin", ZupanijaId = 4 },
                        new { ID = 50, NazivMjesta = "Opatija", ZupanijaId = 8 },
                        new { ID = 51, NazivMjesta = "Pazin", ZupanijaId = 18 },
                        new { ID = 52, NazivMjesta = "Pakrac", ZupanijaId = 11 },
                        new { ID = 53, NazivMjesta = "Drniš", ZupanijaId = 15 },
                        new { ID = 54, NazivMjesta = "Senj", ZupanijaId = 9 },
                        new { ID = 55, NazivMjesta = "Beli Manastir", ZupanijaId = 14 },
                        new { ID = 56, NazivMjesta = "Imotski", ZupanijaId = 17 },
                        new { ID = 57, NazivMjesta = "Ploče", ZupanijaId = 19 },
                        new { ID = 58, NazivMjesta = "Crikvenica", ZupanijaId = 8 },
                        new { ID = 59, NazivMjesta = "Ozalj", ZupanijaId = 4 }
                    );
                });

            modelBuilder.Entity("Studomat.MODEL.Nastavnik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa");

                    b.Property<string>("Ime");

                    b.Property<string>("Lozinka");

                    b.Property<int?>("MjestoId");

                    b.Property<string>("Prezime");

                    b.Property<string>("TitulaIspred");

                    b.Property<string>("TitulaIza");

                    b.HasKey("ID");

                    b.HasIndex("MjestoId");

                    b.ToTable("Nastavnici");
                });

            modelBuilder.Entity("Studomat.MODEL.Ocjene", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumPolaganja");

                    b.Property<int?>("KolegijId");

                    b.Property<int>("Ocjena");

                    b.HasKey("ID");

                    b.HasIndex("KolegijId");

                    b.ToTable("Ocjene");
                });

            modelBuilder.Entity("Studomat.MODEL.Zupanija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NazivZupanija");

                    b.HasKey("ID");

                    b.ToTable("Zupanije");

                    b.HasData(
                        new { ID = 1, NazivZupanija = "Zagrebačka" },
                        new { ID = 2, NazivZupanija = "Krapinsko-zagorska" },
                        new { ID = 3, NazivZupanija = "Sisačko-moslavačka" },
                        new { ID = 4, NazivZupanija = "Karlovačka" },
                        new { ID = 5, NazivZupanija = "Varaždinska" },
                        new { ID = 6, NazivZupanija = "Koprivničko-križevačka" },
                        new { ID = 7, NazivZupanija = "Bjelovarsko-bilogorska" },
                        new { ID = 8, NazivZupanija = "Primorsko-goranska" },
                        new { ID = 9, NazivZupanija = "Ličko-senjska" },
                        new { ID = 10, NazivZupanija = "Virovitičko-podravska" },
                        new { ID = 11, NazivZupanija = "Požeško-slavonska" },
                        new { ID = 12, NazivZupanija = "Brodsko-posavska" },
                        new { ID = 13, NazivZupanija = "Zadarska" },
                        new { ID = 14, NazivZupanija = "Osječko-baranjska" },
                        new { ID = 15, NazivZupanija = "Šibensko-kninska" },
                        new { ID = 16, NazivZupanija = "Vukovarsko-srijemska" },
                        new { ID = 17, NazivZupanija = "Splitsko-dalmatinska" },
                        new { ID = 18, NazivZupanija = "Istarska" },
                        new { ID = 19, NazivZupanija = "Dubrovačko-neretvanska" },
                        new { ID = 20, NazivZupanija = "Međimurska" },
                        new { ID = 21, NazivZupanija = "Grad Zagreb" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Studomat.MODEL.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Studomat.MODEL.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Studomat.MODEL.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Studomat.MODEL.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Studomat.MODEL.AppUser", b =>
                {
                    b.HasOne("Studomat.MODEL.Fakultet", "Fakultet")
                        .WithMany("AppUsers")
                        .HasForeignKey("FakultetId");

                    b.HasOne("Studomat.MODEL.Mjesto", "Mjesto")
                        .WithMany("AppUsers")
                        .HasForeignKey("MjestoId");
                });

            modelBuilder.Entity("Studomat.MODEL.Fakultet", b =>
                {
                    b.HasOne("Studomat.MODEL.Mjesto", "Mjesto")
                        .WithMany("Fakulteti")
                        .HasForeignKey("MjestoId");
                });

            modelBuilder.Entity("Studomat.MODEL.Kolegij", b =>
                {
                    b.HasOne("Studomat.MODEL.AppUser", "AppUser")
                        .WithMany("Kolegiji")
                        .HasForeignKey("AppUserId");

                    b.HasOne("Studomat.MODEL.Fakultet", "Fakultet")
                        .WithMany("Kolegiji")
                        .HasForeignKey("FakultetId");

                    b.HasOne("Studomat.MODEL.Nastavnik", "Nastavnik")
                        .WithMany("Kolegiji")
                        .HasForeignKey("NastavnikId");
                });

            modelBuilder.Entity("Studomat.MODEL.Mjesto", b =>
                {
                    b.HasOne("Studomat.MODEL.Zupanija", "Zupanija")
                        .WithMany("Mjesta")
                        .HasForeignKey("ZupanijaId");
                });

            modelBuilder.Entity("Studomat.MODEL.Nastavnik", b =>
                {
                    b.HasOne("Studomat.MODEL.Mjesto", "Mjesto")
                        .WithMany("Nastavnici")
                        .HasForeignKey("MjestoId");
                });

            modelBuilder.Entity("Studomat.MODEL.Ocjene", b =>
                {
                    b.HasOne("Studomat.MODEL.Kolegij", "Kolegij")
                        .WithMany("Ocjenes")
                        .HasForeignKey("KolegijId");
                });
#pragma warning restore 612, 618
        }
    }
}
