using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCinema.Services.Migrations
{
    public partial class Seed3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Obavijest",
                columns: new[] { "ObavijestId", "DatumKreiranja", "KorisnikId", "Naslov", "ObavijestKategorijaId", "Podnaslov", "Sadrzaj", "Slika" },
                values: new object[] { 1, new DateTime(2024, 1, 4, 19, 10, 55, 894, DateTimeKind.Local).AddTicks(5180), 1, "Početak projekcije filma Spiderman", 1, "Novi film oborio rekord", "Otkako je izašao u kina film je oborio sve rekorde gledanosti. Karte za film Spiderman homecoming u prodaji od 14.2.2024. godine. Karte možete kupiti online ili na blagajni u našoj poslovnici.", null });

            migrationBuilder.InsertData(
                table: "Obavijest",
                columns: new[] { "ObavijestId", "DatumKreiranja", "KorisnikId", "Naslov", "ObavijestKategorijaId", "Podnaslov", "Sadrzaj", "Slika" },
                values: new object[] { 2, new DateTime(2024, 1, 4, 19, 10, 55, 894, DateTimeKind.Local).AddTicks(5220), 1, "Dan nezavisnosti", 2, "Drzavni praznik", "Povodom Dana nezavisnosti Bosne i Hercegovine u kino neće raditi, 01.03.2024. godine.", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 2);
        }
    }
}
