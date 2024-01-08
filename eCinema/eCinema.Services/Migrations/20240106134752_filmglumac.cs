using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCinema.Services.Migrations
{
    public partial class filmglumac : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 1,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 6, 14, 47, 51, 681, DateTimeKind.Local).AddTicks(9521));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 2,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 6, 14, 47, 51, 681, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 3,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 6, 14, 47, 51, 681, DateTimeKind.Local).AddTicks(9529));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 4,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 6, 14, 47, 51, 681, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 5,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 6, 14, 47, 51, 681, DateTimeKind.Local).AddTicks(9535));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 6,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 6, 14, 47, 51, 681, DateTimeKind.Local).AddTicks(9538));

            migrationBuilder.InsertData(
                table: "FilmGlumac",
                columns: new[] { "FilmGlumacId", "FilmId", "GlumacId", "NazivUloge" },
                values: new object[,]
                {
                    { 1, 1, 2, "Spiderman" },
                    { 2, 2, 2, "Ironman" },
                    { 3, 3, 2, "Black widow" },
                    { 4, 4, 1, "Thor" },
                    { 5, 5, 1, "Hulk" },
                    { 6, 6, 1, "Antman" },
                    { 7, 6, 2, "Antman" }
                });

            migrationBuilder.UpdateData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2024, 1, 6, 14, 47, 51, 681, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2024, 1, 6, 14, 47, 51, 681, DateTimeKind.Local).AddTicks(9441));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilmGlumac",
                keyColumn: "FilmGlumacId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FilmGlumac",
                keyColumn: "FilmGlumacId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FilmGlumac",
                keyColumn: "FilmGlumacId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FilmGlumac",
                keyColumn: "FilmGlumacId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FilmGlumac",
                keyColumn: "FilmGlumacId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FilmGlumac",
                keyColumn: "FilmGlumacId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FilmGlumac",
                keyColumn: "FilmGlumacId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 1,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 6, 14, 19, 0, 564, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 2,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 6, 14, 19, 0, 564, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 3,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 6, 14, 19, 0, 564, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 4,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 6, 14, 19, 0, 564, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 5,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 6, 14, 19, 0, 564, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 6,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 6, 14, 19, 0, 564, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2024, 1, 6, 14, 19, 0, 564, DateTimeKind.Local).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2024, 1, 6, 14, 19, 0, 564, DateTimeKind.Local).AddTicks(6823));
        }
    }
}
