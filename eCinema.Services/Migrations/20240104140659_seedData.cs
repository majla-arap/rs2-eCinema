using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCinema.Services.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cinema",
                columns: table => new
                {
                    CinemaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Webstranica = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrTelefona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aktivan = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinema", x => x.CinemaId);
                });

            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    FilmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sadrzaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slika = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VrijemeTrajanje = table.Column<int>(type: "int", nullable: true),
                    Redatelj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Godina = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    PocetakPrikazivanja = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.FilmId);
                });

            migrationBuilder.CreateTable(
                name: "Glumac",
                columns: table => new
                {
                    GlumacId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Glumac", x => x.GlumacId);
                });

            migrationBuilder.CreateTable(
                name: "Korisnik",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrTelefona = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LozinkaHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LozinkaSalt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aktivan = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnik", x => x.KorisnikId);
                });

            migrationBuilder.CreateTable(
                name: "ObavijestKategorija",
                columns: table => new
                {
                    ObavijestKategorijaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ObavijestKategorija", x => x.ObavijestKategorijaId);
                });

            migrationBuilder.CreateTable(
                name: "Uloga",
                columns: table => new
                {
                    UlogaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloga", x => x.UlogaId);
                });

            migrationBuilder.CreateTable(
                name: "Zanr",
                columns: table => new
                {
                    ZanrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zanr", x => x.ZanrId);
                });

            migrationBuilder.CreateTable(
                name: "Dvorana",
                columns: table => new
                {
                    DvoranaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrSjedista = table.Column<int>(type: "int", nullable: true),
                    BrRedova = table.Column<int>(type: "int", nullable: true),
                    BrSjedistaPoRedu = table.Column<int>(type: "int", nullable: true),
                    CinemaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dvorana", x => x.DvoranaId);
                    table.ForeignKey(
                        name: "FK__Dvorana__CinemaI__33D4B598",
                        column: x => x.CinemaId,
                        principalTable: "Cinema",
                        principalColumn: "CinemaId");
                });

            migrationBuilder.CreateTable(
                name: "FilmGlumac",
                columns: table => new
                {
                    FilmGlumacId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GlumacId = table.Column<int>(type: "int", nullable: true),
                    FilmId = table.Column<int>(type: "int", nullable: true),
                    NazivUloge = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmGlumac", x => x.FilmGlumacId);
                    table.ForeignKey(
                        name: "FK__FilmGluma__FilmI__412EB0B6",
                        column: x => x.FilmId,
                        principalTable: "Film",
                        principalColumn: "FilmId");
                    table.ForeignKey(
                        name: "FK__FilmGluma__Gluma__403A8C7D",
                        column: x => x.GlumacId,
                        principalTable: "Glumac",
                        principalColumn: "GlumacId");
                });

            migrationBuilder.CreateTable(
                name: "Kupovina",
                columns: table => new
                {
                    KupovinaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kolicina = table.Column<int>(type: "int", nullable: true),
                    Cijena = table.Column<int>(type: "int", nullable: true),
                    DatumKupovine = table.Column<DateTime>(type: "datetime", nullable: true),
                    KorisnikId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kupovina", x => x.KupovinaId);
                    table.ForeignKey(
                        name: "FK__Kupovina__Korisn__4AB81AF0",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId");
                });

            migrationBuilder.CreateTable(
                name: "Obavijest",
                columns: table => new
                {
                    ObavijestId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naslov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Podnaslov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sadrzaj = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slika = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DatumKreiranja = table.Column<DateTime>(type: "datetime", nullable: true),
                    ObavijestKategorijaId = table.Column<int>(type: "int", nullable: true),
                    KorisnikId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavijest", x => x.ObavijestId);
                    table.ForeignKey(
                        name: "FK__Obavijest__Koris__2F10007B",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId");
                    table.ForeignKey(
                        name: "FK__Obavijest__Obavi__2E1BDC42",
                        column: x => x.ObavijestKategorijaId,
                        principalTable: "ObavijestKategorija",
                        principalColumn: "ObavijestKategorijaId");
                });

            migrationBuilder.CreateTable(
                name: "KorisnikUloge",
                columns: table => new
                {
                    KorisnikUlogeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UlogaId = table.Column<int>(type: "int", nullable: true),
                    KorisnikId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnikUloge", x => x.KorisnikUlogeId);
                    table.ForeignKey(
                        name: "FK__KorisnikU__Koris__29572725",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "KorisnikId");
                    table.ForeignKey(
                        name: "FK__KorisnikU__Uloga__286302EC",
                        column: x => x.UlogaId,
                        principalTable: "Uloga",
                        principalColumn: "UlogaId");
                });

            migrationBuilder.CreateTable(
                name: "FilmZanr",
                columns: table => new
                {
                    FilmZanrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ZanrId = table.Column<int>(type: "int", nullable: true),
                    FilmId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmZanr", x => x.FilmZanrId);
                    table.ForeignKey(
                        name: "FK__FilmZanr__FilmId__44FF419A",
                        column: x => x.FilmId,
                        principalTable: "Film",
                        principalColumn: "FilmId");
                    table.ForeignKey(
                        name: "FK__FilmZanr__ZanrId__440B1D61",
                        column: x => x.ZanrId,
                        principalTable: "Zanr",
                        principalColumn: "ZanrId");
                });

            migrationBuilder.CreateTable(
                name: "Termin",
                columns: table => new
                {
                    TerminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DvoranaId = table.Column<int>(type: "int", nullable: true),
                    FilmId = table.Column<int>(type: "int", nullable: true),
                    Premijera = table.Column<bool>(type: "bit", nullable: true),
                    Predpremijera = table.Column<bool>(type: "bit", nullable: true),
                    CijenaKarte = table.Column<int>(type: "int", nullable: true),
                    DatumOdrzavanja = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Termin", x => x.TerminId);
                    table.ForeignKey(
                        name: "FK__Termin__DvoranaI__3C69FB99",
                        column: x => x.DvoranaId,
                        principalTable: "Dvorana",
                        principalColumn: "DvoranaId");
                    table.ForeignKey(
                        name: "FK__Termin__FilmId__3D5E1FD2",
                        column: x => x.FilmId,
                        principalTable: "Film",
                        principalColumn: "FilmId");
                });

            migrationBuilder.CreateTable(
                name: "Karta",
                columns: table => new
                {
                    KartaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Aktivna = table.Column<bool>(type: "bit", nullable: true),
                    TerminId = table.Column<int>(type: "int", nullable: true),
                    Sjediste = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Karta__EC3FA9EE350BB06B", x => x.KartaId);
                    table.ForeignKey(
                        name: "FK__Karta__TerminId__47DBAE45",
                        column: x => x.TerminId,
                        principalTable: "Termin",
                        principalColumn: "TerminId");
                });

            migrationBuilder.InsertData(
                table: "Korisnik",
                columns: new[] { "KorisnikId", "Aktivan", "BrTelefona", "Email", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime" },
                values: new object[,]
                {
                    { 1, true, "062-859-752", "admin@gmail.com", "Admin", "admin", "523l3SXvXt/OIGacFmI0PUlXkJM=", "ORNOSgr59Nd5PGJx/GNMKg==", "Admin" },
                    { 2, true, "062-205-156", "majla@gmail.com", "Majla", "majla123", "523l3SXvXt/OIGacFmI0PUlXkJM=", "ORNOSgr59Nd5PGJx/GNMKg==", "Arap" }
                });

            migrationBuilder.InsertData(
                table: "Uloga",
                columns: new[] { "UlogaId", "Naziv" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "Kupac" }
                });

            migrationBuilder.InsertData(
                table: "KorisnikUloge",
                columns: new[] { "KorisnikUlogeId", "KorisnikId", "UlogaId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "KorisnikUloge",
                columns: new[] { "KorisnikUlogeId", "KorisnikId", "UlogaId" },
                values: new object[] { 2, 2, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Dvorana_CinemaId",
                table: "Dvorana",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmGlumac_FilmId",
                table: "FilmGlumac",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmGlumac_GlumacId",
                table: "FilmGlumac",
                column: "GlumacId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmZanr_FilmId",
                table: "FilmZanr",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmZanr_ZanrId",
                table: "FilmZanr",
                column: "ZanrId");

            migrationBuilder.CreateIndex(
                name: "IX_Karta_TerminId",
                table: "Karta",
                column: "TerminId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikUloge_KorisnikId",
                table: "KorisnikUloge",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisnikUloge_UlogaId",
                table: "KorisnikUloge",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_Kupovina_KorisnikId",
                table: "Kupovina",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Obavijest_KorisnikId",
                table: "Obavijest",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Obavijest_ObavijestKategorijaId",
                table: "Obavijest",
                column: "ObavijestKategorijaId");

            migrationBuilder.CreateIndex(
                name: "IX_Termin_DvoranaId",
                table: "Termin",
                column: "DvoranaId");

            migrationBuilder.CreateIndex(
                name: "IX_Termin_FilmId",
                table: "Termin",
                column: "FilmId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmGlumac");

            migrationBuilder.DropTable(
                name: "FilmZanr");

            migrationBuilder.DropTable(
                name: "Karta");

            migrationBuilder.DropTable(
                name: "KorisnikUloge");

            migrationBuilder.DropTable(
                name: "Kupovina");

            migrationBuilder.DropTable(
                name: "Obavijest");

            migrationBuilder.DropTable(
                name: "Glumac");

            migrationBuilder.DropTable(
                name: "Zanr");

            migrationBuilder.DropTable(
                name: "Termin");

            migrationBuilder.DropTable(
                name: "Uloga");

            migrationBuilder.DropTable(
                name: "Korisnik");

            migrationBuilder.DropTable(
                name: "ObavijestKategorija");

            migrationBuilder.DropTable(
                name: "Dvorana");

            migrationBuilder.DropTable(
                name: "Film");

            migrationBuilder.DropTable(
                name: "Cinema");
        }
    }
}
