using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCinema.Services.Migrations
{
    public partial class filmzanr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "FilmZanr",
                columns: new[] { "FilmZanrId", "FilmId", "ZanrId" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 2, 2 },
                    { 3, 3, 2 },
                    { 4, 4, 1 },
                    { 5, 5, 1 },
                    { 6, 6, 1 },
                    { 7, 6, 2 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "FilmZanr",
                keyColumn: "FilmZanrId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FilmZanr",
                keyColumn: "FilmZanrId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FilmZanr",
                keyColumn: "FilmZanrId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FilmZanr",
                keyColumn: "FilmZanrId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FilmZanr",
                keyColumn: "FilmZanrId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FilmZanr",
                keyColumn: "FilmZanrId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FilmZanr",
                keyColumn: "FilmZanrId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 1,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 5, 23, 46, 43, 110, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 2,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 5, 23, 46, 43, 110, DateTimeKind.Local).AddTicks(7374));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 3,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 5, 23, 46, 43, 110, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 4,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 5, 23, 46, 43, 110, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 5,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 5, 23, 46, 43, 110, DateTimeKind.Local).AddTicks(7381));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 6,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 5, 23, 46, 43, 110, DateTimeKind.Local).AddTicks(7384));

            migrationBuilder.UpdateData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2024, 1, 5, 23, 46, 43, 110, DateTimeKind.Local).AddTicks(7244));

            migrationBuilder.UpdateData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2024, 1, 5, 23, 46, 43, 110, DateTimeKind.Local).AddTicks(7284));
        }
    }
}
