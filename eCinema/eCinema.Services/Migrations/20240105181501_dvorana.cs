using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCinema.Services.Migrations
{
    public partial class dvorana : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dvorana",
                columns: new[] { "DvoranaId", "BrRedova", "BrSjedista", "BrSjedistaPoRedu", "CinemaId", "Naziv" },
                values: new object[,]
                {
                    { 1, 10, 150, 15, 1, "Velika sala" },
                    { 2, 10, 100, 10, 1, "Mala sala" },
                    { 3, 10, 150, 15, 2, "Velika sala" },
                    { 4, 10, 100, 10, 2, "Mala sala" }
                });

            migrationBuilder.UpdateData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2024, 1, 5, 19, 15, 1, 125, DateTimeKind.Local).AddTicks(2375));

            migrationBuilder.UpdateData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2024, 1, 5, 19, 15, 1, 125, DateTimeKind.Local).AddTicks(2410));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dvorana",
                keyColumn: "DvoranaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dvorana",
                keyColumn: "DvoranaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dvorana",
                keyColumn: "DvoranaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dvorana",
                keyColumn: "DvoranaId",
                keyValue: 4);

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
    }
}
