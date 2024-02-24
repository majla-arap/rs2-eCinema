using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCinema.Services.Migrations
{
    public partial class zarada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 1,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 2, 24, 15, 41, 11, 331, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 2,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 2, 24, 15, 41, 11, 331, DateTimeKind.Local).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 3,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 2, 24, 15, 41, 11, 331, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 4,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 2, 24, 15, 41, 11, 331, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 5,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 2, 24, 15, 41, 11, 331, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 6,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 2, 24, 15, 41, 11, 331, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "Kupovina",
                keyColumn: "KupovinaId",
                keyValue: 1,
                column: "DatumKupovine",
                value: new DateTime(2024, 2, 24, 15, 41, 11, 332, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Kupovina",
                keyColumn: "KupovinaId",
                keyValue: 2,
                column: "DatumKupovine",
                value: new DateTime(2024, 2, 24, 15, 41, 11, 332, DateTimeKind.Local).AddTicks(1427));

            migrationBuilder.UpdateData(
                table: "Kupovina",
                keyColumn: "KupovinaId",
                keyValue: 3,
                column: "DatumKupovine",
                value: new DateTime(2024, 2, 24, 15, 41, 11, 332, DateTimeKind.Local).AddTicks(1434));

            migrationBuilder.UpdateData(
                table: "Kupovina",
                keyColumn: "KupovinaId",
                keyValue: 4,
                column: "DatumKupovine",
                value: new DateTime(2024, 2, 24, 15, 41, 11, 332, DateTimeKind.Local).AddTicks(1439));

            migrationBuilder.UpdateData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2024, 2, 24, 15, 41, 11, 331, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2024, 2, 24, 15, 41, 11, 331, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 1,
                column: "DatumOdrzavanja",
                value: new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 2,
                column: "DatumOdrzavanja",
                value: new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 3,
                column: "DatumOdrzavanja",
                value: new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 4,
                column: "DatumOdrzavanja",
                value: new DateTime(2024, 2, 26, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 5,
                column: "DatumOdrzavanja",
                value: new DateTime(2024, 2, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 6,
                column: "DatumOdrzavanja",
                value: new DateTime(2024, 2, 27, 0, 0, 0, 0, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 1,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 8, 14, 2, 39, 479, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 2,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 8, 14, 2, 39, 479, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 3,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 8, 14, 2, 39, 479, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 4,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 8, 14, 2, 39, 479, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 5,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 8, 14, 2, 39, 479, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 6,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 8, 14, 2, 39, 479, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "Kupovina",
                keyColumn: "KupovinaId",
                keyValue: 1,
                column: "DatumKupovine",
                value: new DateTime(2024, 1, 8, 14, 2, 39, 479, DateTimeKind.Local).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Kupovina",
                keyColumn: "KupovinaId",
                keyValue: 2,
                column: "DatumKupovine",
                value: new DateTime(2024, 1, 8, 14, 2, 39, 479, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "Kupovina",
                keyColumn: "KupovinaId",
                keyValue: 3,
                column: "DatumKupovine",
                value: new DateTime(2024, 1, 8, 14, 2, 39, 479, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "Kupovina",
                keyColumn: "KupovinaId",
                keyValue: 4,
                column: "DatumKupovine",
                value: new DateTime(2024, 1, 8, 14, 2, 39, 479, DateTimeKind.Local).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2024, 1, 8, 14, 2, 39, 479, DateTimeKind.Local).AddTicks(3689));

            migrationBuilder.UpdateData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2024, 1, 8, 14, 2, 39, 479, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 1,
                column: "DatumOdrzavanja",
                value: new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 2,
                column: "DatumOdrzavanja",
                value: new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 3,
                column: "DatumOdrzavanja",
                value: new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 4,
                column: "DatumOdrzavanja",
                value: new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 5,
                column: "DatumOdrzavanja",
                value: new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 6,
                column: "DatumOdrzavanja",
                value: new DateTime(2024, 1, 11, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
