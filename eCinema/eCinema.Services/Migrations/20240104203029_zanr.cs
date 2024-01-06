using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCinema.Services.Migrations
{
    public partial class zanr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Zanr",
                columns: new[] { "ZanrId", "Naziv" },
                values: new object[,]
                {
                    { 1, "Drama" },
                    { 2, "Komedija" },
                    { 3, "Akcija" },
                    { 4, "Romansa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Zanr",
                keyColumn: "ZanrId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Zanr",
                keyColumn: "ZanrId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Zanr",
                keyColumn: "ZanrId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Zanr",
                keyColumn: "ZanrId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2024, 1, 4, 19, 10, 55, 894, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2024, 1, 4, 19, 10, 55, 894, DateTimeKind.Local).AddTicks(5220));
        }
    }
}
