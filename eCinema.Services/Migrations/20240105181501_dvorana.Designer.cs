﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eCinema.Services.Database;

#nullable disable

namespace eCinema.Services.Migrations
{
    [DbContext(typeof(eCinemaContext))]
    [Migration("20240105181501_dvorana")]
    partial class dvorana
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("eCinema.Services.Database.Cinema", b =>
                {
                    b.Property<int>("CinemaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CinemaId"), 1L, 1);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<string>("BrTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Webstranica")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CinemaId");

                    b.ToTable("Cinema", (string)null);

                    b.HasData(
                        new
                        {
                            CinemaId = 1,
                            Adresa = "marsala tita br. 2",
                            Aktivan = true,
                            BrTelefona = "036-550-128",
                            Email = "info@cinestar.com",
                            Naziv = "Cinestar",
                            Webstranica = "https://www.blitz-cinestar-bh.ba/cinestar-mostar"
                        },
                        new
                        {
                            CinemaId = 2,
                            Adresa = "Plaza br. 21",
                            Aktivan = true,
                            BrTelefona = "036-347-128",
                            Email = "info@cineplexx.com",
                            Naziv = "cineplexx",
                            Webstranica = "https://www.cineplexx.ba/movies?date=2024-01-05&category=now&location=all"
                        });
                });

            modelBuilder.Entity("eCinema.Services.Database.Dvorana", b =>
                {
                    b.Property<int>("DvoranaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DvoranaId"), 1L, 1);

                    b.Property<int?>("BrRedova")
                        .HasColumnType("int");

                    b.Property<int?>("BrSjedista")
                        .HasColumnType("int");

                    b.Property<int?>("BrSjedistaPoRedu")
                        .HasColumnType("int");

                    b.Property<int?>("CinemaId")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DvoranaId");

                    b.HasIndex("CinemaId");

                    b.ToTable("Dvorana", (string)null);

                    b.HasData(
                        new
                        {
                            DvoranaId = 1,
                            BrRedova = 10,
                            BrSjedista = 150,
                            BrSjedistaPoRedu = 15,
                            CinemaId = 1,
                            Naziv = "Velika sala"
                        },
                        new
                        {
                            DvoranaId = 2,
                            BrRedova = 10,
                            BrSjedista = 100,
                            BrSjedistaPoRedu = 10,
                            CinemaId = 1,
                            Naziv = "Mala sala"
                        },
                        new
                        {
                            DvoranaId = 3,
                            BrRedova = 10,
                            BrSjedista = 150,
                            BrSjedistaPoRedu = 15,
                            CinemaId = 2,
                            Naziv = "Velika sala"
                        },
                        new
                        {
                            DvoranaId = 4,
                            BrRedova = 10,
                            BrSjedista = 100,
                            BrSjedistaPoRedu = 10,
                            CinemaId = 2,
                            Naziv = "Mala sala"
                        });
                });

            modelBuilder.Entity("eCinema.Services.Database.Film", b =>
                {
                    b.Property<int>("FilmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilmId"), 1L, 1);

                    b.Property<string>("Godina")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PocetakPrikazivanja")
                        .HasColumnType("datetime");

                    b.Property<string>("Redatelj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sadrzaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("VrijemeTrajanje")
                        .HasColumnType("int");

                    b.HasKey("FilmId");

                    b.ToTable("Film", (string)null);
                });

            modelBuilder.Entity("eCinema.Services.Database.FilmGlumac", b =>
                {
                    b.Property<int>("FilmGlumacId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilmGlumacId"), 1L, 1);

                    b.Property<int?>("FilmId")
                        .HasColumnType("int");

                    b.Property<int?>("GlumacId")
                        .HasColumnType("int");

                    b.Property<string>("NazivUloge")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FilmGlumacId");

                    b.HasIndex("FilmId");

                    b.HasIndex("GlumacId");

                    b.ToTable("FilmGlumac", (string)null);
                });

            modelBuilder.Entity("eCinema.Services.Database.FilmZanr", b =>
                {
                    b.Property<int>("FilmZanrId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilmZanrId"), 1L, 1);

                    b.Property<int?>("FilmId")
                        .HasColumnType("int");

                    b.Property<int?>("ZanrId")
                        .HasColumnType("int");

                    b.HasKey("FilmZanrId");

                    b.HasIndex("FilmId");

                    b.HasIndex("ZanrId");

                    b.ToTable("FilmZanr", (string)null);
                });

            modelBuilder.Entity("eCinema.Services.Database.Glumac", b =>
                {
                    b.Property<int>("GlumacId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GlumacId"), 1L, 1);

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImePrezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GlumacId");

                    b.ToTable("Glumac", (string)null);

                    b.HasData(
                        new
                        {
                            GlumacId = 1,
                            Ime = "Angelina",
                            ImePrezime = "Angelina Jolie",
                            Prezime = "Jolie"
                        },
                        new
                        {
                            GlumacId = 2,
                            Ime = "Brad",
                            ImePrezime = "Brad Pitt",
                            Prezime = "Pitt"
                        },
                        new
                        {
                            GlumacId = 3,
                            Ime = "Jennifer",
                            ImePrezime = "Jennifer Lopez",
                            Prezime = "Lopez"
                        },
                        new
                        {
                            GlumacId = 4,
                            Ime = "George",
                            ImePrezime = "George Clooney",
                            Prezime = "Clooney"
                        });
                });

            modelBuilder.Entity("eCinema.Services.Database.Kartum", b =>
                {
                    b.Property<int>("KartaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KartaId"), 1L, 1);

                    b.Property<bool?>("Aktivna")
                        .HasColumnType("bit");

                    b.Property<string>("Sjediste")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int?>("TerminId")
                        .HasColumnType("int");

                    b.HasKey("KartaId")
                        .HasName("PK__Karta__EC3FA9EE350BB06B");

                    b.HasIndex("TerminId");

                    b.ToTable("Karta");
                });

            modelBuilder.Entity("eCinema.Services.Database.Korisnik", b =>
                {
                    b.Property<int>("KorisnikId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KorisnikId"), 1L, 1);

                    b.Property<bool?>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<string>("BrTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LozinkaSalt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KorisnikId");

                    b.ToTable("Korisnik", (string)null);

                    b.HasData(
                        new
                        {
                            KorisnikId = 1,
                            Aktivan = true,
                            BrTelefona = "062-859-752",
                            Email = "admin@gmail.com",
                            Ime = "Admin",
                            KorisnickoIme = "admin",
                            LozinkaHash = "523l3SXvXt/OIGacFmI0PUlXkJM=",
                            LozinkaSalt = "ORNOSgr59Nd5PGJx/GNMKg==",
                            Prezime = "Admin"
                        },
                        new
                        {
                            KorisnikId = 2,
                            Aktivan = true,
                            BrTelefona = "062-205-156",
                            Email = "majla@gmail.com",
                            Ime = "Majla",
                            KorisnickoIme = "majla123",
                            LozinkaHash = "523l3SXvXt/OIGacFmI0PUlXkJM=",
                            LozinkaSalt = "ORNOSgr59Nd5PGJx/GNMKg==",
                            Prezime = "Arap"
                        });
                });

            modelBuilder.Entity("eCinema.Services.Database.KorisnikUloge", b =>
                {
                    b.Property<int>("KorisnikUlogeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KorisnikUlogeId"), 1L, 1);

                    b.Property<int?>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<int?>("UlogaId")
                        .HasColumnType("int");

                    b.HasKey("KorisnikUlogeId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("UlogaId");

                    b.ToTable("KorisnikUloge", (string)null);

                    b.HasData(
                        new
                        {
                            KorisnikUlogeId = 1,
                            KorisnikId = 1,
                            UlogaId = 1
                        },
                        new
                        {
                            KorisnikUlogeId = 2,
                            KorisnikId = 2,
                            UlogaId = 2
                        });
                });

            modelBuilder.Entity("eCinema.Services.Database.Kupovina", b =>
                {
                    b.Property<int>("KupovinaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KupovinaId"), 1L, 1);

                    b.Property<int?>("Cijena")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DatumKupovine")
                        .HasColumnType("datetime");

                    b.Property<int?>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int?>("KorisnikId")
                        .HasColumnType("int");

                    b.HasKey("KupovinaId");

                    b.HasIndex("KorisnikId");

                    b.ToTable("Kupovina", (string)null);
                });

            modelBuilder.Entity("eCinema.Services.Database.Obavijest", b =>
                {
                    b.Property<int>("ObavijestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObavijestId"), 1L, 1);

                    b.Property<DateTime?>("DatumKreiranja")
                        .HasColumnType("datetime");

                    b.Property<int?>("KorisnikId")
                        .HasColumnType("int");

                    b.Property<string>("Naslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ObavijestKategorijaId")
                        .HasColumnType("int");

                    b.Property<string>("Podnaslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sadrzaj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slika")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ObavijestId");

                    b.HasIndex("KorisnikId");

                    b.HasIndex("ObavijestKategorijaId");

                    b.ToTable("Obavijest", (string)null);

                    b.HasData(
                        new
                        {
                            ObavijestId = 1,
                            DatumKreiranja = new DateTime(2024, 1, 5, 19, 15, 1, 125, DateTimeKind.Local).AddTicks(2375),
                            KorisnikId = 1,
                            Naslov = "Početak projekcije filma Spiderman",
                            ObavijestKategorijaId = 1,
                            Podnaslov = "Novi film oborio rekord",
                            Sadrzaj = "Otkako je izašao u kina film je oborio sve rekorde gledanosti. Karte za film Spiderman homecoming u prodaji od 14.2.2024. godine. Karte možete kupiti online ili na blagajni u našoj poslovnici."
                        },
                        new
                        {
                            ObavijestId = 2,
                            DatumKreiranja = new DateTime(2024, 1, 5, 19, 15, 1, 125, DateTimeKind.Local).AddTicks(2410),
                            KorisnikId = 1,
                            Naslov = "Dan nezavisnosti",
                            ObavijestKategorijaId = 2,
                            Podnaslov = "Drzavni praznik",
                            Sadrzaj = "Povodom Dana nezavisnosti Bosne i Hercegovine u kino neće raditi, 01.03.2024. godine."
                        });
                });

            modelBuilder.Entity("eCinema.Services.Database.ObavijestKategorija", b =>
                {
                    b.Property<int>("ObavijestKategorijaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ObavijestKategorijaId"), 1L, 1);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ObavijestKategorijaId");

                    b.ToTable("ObavijestKategorija", (string)null);

                    b.HasData(
                        new
                        {
                            ObavijestKategorijaId = 1,
                            Naziv = "Novosti"
                        },
                        new
                        {
                            ObavijestKategorijaId = 2,
                            Naziv = "Vijesti"
                        });
                });

            modelBuilder.Entity("eCinema.Services.Database.Termin", b =>
                {
                    b.Property<int>("TerminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TerminId"), 1L, 1);

                    b.Property<int?>("CijenaKarte")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DatumOdrzavanja")
                        .HasColumnType("datetime");

                    b.Property<int?>("DvoranaId")
                        .HasColumnType("int");

                    b.Property<int?>("FilmId")
                        .HasColumnType("int");

                    b.Property<bool?>("Predpremijera")
                        .HasColumnType("bit");

                    b.Property<bool?>("Premijera")
                        .HasColumnType("bit");

                    b.HasKey("TerminId");

                    b.HasIndex("DvoranaId");

                    b.HasIndex("FilmId");

                    b.ToTable("Termin", (string)null);
                });

            modelBuilder.Entity("eCinema.Services.Database.Uloga", b =>
                {
                    b.Property<int>("UlogaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UlogaId"), 1L, 1);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UlogaId");

                    b.ToTable("Uloga", (string)null);

                    b.HasData(
                        new
                        {
                            UlogaId = 1,
                            Naziv = "Admin"
                        },
                        new
                        {
                            UlogaId = 2,
                            Naziv = "Kupac"
                        });
                });

            modelBuilder.Entity("eCinema.Services.Database.Zanr", b =>
                {
                    b.Property<int>("ZanrId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ZanrId"), 1L, 1);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ZanrId");

                    b.ToTable("Zanr", (string)null);

                    b.HasData(
                        new
                        {
                            ZanrId = 1,
                            Naziv = "Drama"
                        },
                        new
                        {
                            ZanrId = 2,
                            Naziv = "Komedija"
                        },
                        new
                        {
                            ZanrId = 3,
                            Naziv = "Akcija"
                        },
                        new
                        {
                            ZanrId = 4,
                            Naziv = "Romansa"
                        });
                });

            modelBuilder.Entity("eCinema.Services.Database.Dvorana", b =>
                {
                    b.HasOne("eCinema.Services.Database.Cinema", "Cinema")
                        .WithMany("Dvoranas")
                        .HasForeignKey("CinemaId")
                        .HasConstraintName("FK__Dvorana__CinemaI__33D4B598");

                    b.Navigation("Cinema");
                });

            modelBuilder.Entity("eCinema.Services.Database.FilmGlumac", b =>
                {
                    b.HasOne("eCinema.Services.Database.Film", "Film")
                        .WithMany("FilmGlumacs")
                        .HasForeignKey("FilmId")
                        .HasConstraintName("FK__FilmGluma__FilmI__412EB0B6");

                    b.HasOne("eCinema.Services.Database.Glumac", "Glumac")
                        .WithMany("FilmGlumacs")
                        .HasForeignKey("GlumacId")
                        .HasConstraintName("FK__FilmGluma__Gluma__403A8C7D");

                    b.Navigation("Film");

                    b.Navigation("Glumac");
                });

            modelBuilder.Entity("eCinema.Services.Database.FilmZanr", b =>
                {
                    b.HasOne("eCinema.Services.Database.Film", "Film")
                        .WithMany("FilmZanrs")
                        .HasForeignKey("FilmId")
                        .HasConstraintName("FK__FilmZanr__FilmId__44FF419A");

                    b.HasOne("eCinema.Services.Database.Zanr", "Zanr")
                        .WithMany("FilmZanrs")
                        .HasForeignKey("ZanrId")
                        .HasConstraintName("FK__FilmZanr__ZanrId__440B1D61");

                    b.Navigation("Film");

                    b.Navigation("Zanr");
                });

            modelBuilder.Entity("eCinema.Services.Database.Kartum", b =>
                {
                    b.HasOne("eCinema.Services.Database.Termin", "Termin")
                        .WithMany("Karta")
                        .HasForeignKey("TerminId")
                        .HasConstraintName("FK__Karta__TerminId__47DBAE45");

                    b.Navigation("Termin");
                });

            modelBuilder.Entity("eCinema.Services.Database.KorisnikUloge", b =>
                {
                    b.HasOne("eCinema.Services.Database.Korisnik", "Korisnik")
                        .WithMany("KorisnikUloges")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK__KorisnikU__Koris__29572725");

                    b.HasOne("eCinema.Services.Database.Uloga", "Uloga")
                        .WithMany("KorisnikUloges")
                        .HasForeignKey("UlogaId")
                        .HasConstraintName("FK__KorisnikU__Uloga__286302EC");

                    b.Navigation("Korisnik");

                    b.Navigation("Uloga");
                });

            modelBuilder.Entity("eCinema.Services.Database.Kupovina", b =>
                {
                    b.HasOne("eCinema.Services.Database.Korisnik", "Korisnik")
                        .WithMany("Kupovinas")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK__Kupovina__Korisn__4AB81AF0");

                    b.Navigation("Korisnik");
                });

            modelBuilder.Entity("eCinema.Services.Database.Obavijest", b =>
                {
                    b.HasOne("eCinema.Services.Database.Korisnik", "Korisnik")
                        .WithMany("Obavijests")
                        .HasForeignKey("KorisnikId")
                        .HasConstraintName("FK__Obavijest__Koris__2F10007B");

                    b.HasOne("eCinema.Services.Database.ObavijestKategorija", "ObavijestKategorija")
                        .WithMany("Obavijests")
                        .HasForeignKey("ObavijestKategorijaId")
                        .HasConstraintName("FK__Obavijest__Obavi__2E1BDC42");

                    b.Navigation("Korisnik");

                    b.Navigation("ObavijestKategorija");
                });

            modelBuilder.Entity("eCinema.Services.Database.Termin", b =>
                {
                    b.HasOne("eCinema.Services.Database.Dvorana", "Dvorana")
                        .WithMany("Termins")
                        .HasForeignKey("DvoranaId")
                        .HasConstraintName("FK__Termin__DvoranaI__3C69FB99");

                    b.HasOne("eCinema.Services.Database.Film", "Film")
                        .WithMany("Termins")
                        .HasForeignKey("FilmId")
                        .HasConstraintName("FK__Termin__FilmId__3D5E1FD2");

                    b.Navigation("Dvorana");

                    b.Navigation("Film");
                });

            modelBuilder.Entity("eCinema.Services.Database.Cinema", b =>
                {
                    b.Navigation("Dvoranas");
                });

            modelBuilder.Entity("eCinema.Services.Database.Dvorana", b =>
                {
                    b.Navigation("Termins");
                });

            modelBuilder.Entity("eCinema.Services.Database.Film", b =>
                {
                    b.Navigation("FilmGlumacs");

                    b.Navigation("FilmZanrs");

                    b.Navigation("Termins");
                });

            modelBuilder.Entity("eCinema.Services.Database.Glumac", b =>
                {
                    b.Navigation("FilmGlumacs");
                });

            modelBuilder.Entity("eCinema.Services.Database.Korisnik", b =>
                {
                    b.Navigation("KorisnikUloges");

                    b.Navigation("Kupovinas");

                    b.Navigation("Obavijests");
                });

            modelBuilder.Entity("eCinema.Services.Database.ObavijestKategorija", b =>
                {
                    b.Navigation("Obavijests");
                });

            modelBuilder.Entity("eCinema.Services.Database.Termin", b =>
                {
                    b.Navigation("Karta");
                });

            modelBuilder.Entity("eCinema.Services.Database.Uloga", b =>
                {
                    b.Navigation("KorisnikUloges");
                });

            modelBuilder.Entity("eCinema.Services.Database.Zanr", b =>
                {
                    b.Navigation("FilmZanrs");
                });
#pragma warning restore 612, 618
        }
    }
}
