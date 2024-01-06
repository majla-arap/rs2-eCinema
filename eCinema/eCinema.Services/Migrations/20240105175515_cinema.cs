using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCinema.Services.Migrations
{
    public partial class cinema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "CinemaId", "Adresa", "Aktivan", "BrTelefona", "Email", "Logo", "Naziv", "Webstranica" },
                values: new object[,]
                {
                    { 1, "marsala tita br. 2", true, "036-550-128", "info@cinestar.com", null, "Cinestar", "https://www.blitz-cinestar-bh.ba/cinestar-mostar" },
                    { 2, "Plaza br. 21", true, "036-347-128", "info@cineplexx.com", null, "cineplexx", "https://www.cineplexx.ba/movies?date=2024-01-05&category=now&location=all" }
                });

            migrationBuilder.UpdateData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2024, 1, 5, 18, 55, 14, 837, DateTimeKind.Local).AddTicks(2948));

            migrationBuilder.UpdateData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2024, 1, 5, 18, 55, 14, 837, DateTimeKind.Local).AddTicks(2993));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "CinemaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "CinemaId",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2024, 1, 4, 21, 30, 28, 684, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2024, 1, 4, 21, 30, 28, 684, DateTimeKind.Local).AddTicks(1353));
        }
    }
}
