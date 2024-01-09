using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCinema.Services.Migrations
{
    public partial class stripe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "DatumKupovine", "PaymentIntentId" },
                values: new object[] { new DateTime(2024, 1, 8, 14, 2, 39, 479, DateTimeKind.Local).AddTicks(5857), "pi_3OWINVKz7Kvo4INB0vxMg7nh_secret_OCpHVXa9D6FpelaUByuyHJXEH" });

            migrationBuilder.UpdateData(
                table: "Kupovina",
                keyColumn: "KupovinaId",
                keyValue: 2,
                columns: new[] { "DatumKupovine", "PaymentIntentId" },
                values: new object[] { new DateTime(2024, 1, 8, 14, 2, 39, 479, DateTimeKind.Local).AddTicks(6017), "pi_3OWINVKz7Kvo4INB0vxMg7nh_secret_OCpHVXa9D6FpelaUByuyHJXEH" });

            migrationBuilder.UpdateData(
                table: "Kupovina",
                keyColumn: "KupovinaId",
                keyValue: 3,
                columns: new[] { "DatumKupovine", "PaymentIntentId" },
                values: new object[] { new DateTime(2024, 1, 8, 14, 2, 39, 479, DateTimeKind.Local).AddTicks(6021), "pi_3OWINVKz7Kvo4INB0vxMg7nh_secret_OCpHVXa9D6FpelaUByuyHJXEH" });

            migrationBuilder.UpdateData(
                table: "Kupovina",
                keyColumn: "KupovinaId",
                keyValue: 4,
                columns: new[] { "DatumKupovine", "PaymentIntentId" },
                values: new object[] { new DateTime(2024, 1, 8, 14, 2, 39, 479, DateTimeKind.Local).AddTicks(6024), "pi_3OWINVKz7Kvo4INB0vxMg7nh_secret_OCpHVXa9D6FpelaUByuyHJXEH" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 1,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 6, 15, 41, 55, 542, DateTimeKind.Local).AddTicks(6235));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 2,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 6, 15, 41, 55, 542, DateTimeKind.Local).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 3,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 6, 15, 41, 55, 542, DateTimeKind.Local).AddTicks(6241));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 4,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 6, 15, 41, 55, 542, DateTimeKind.Local).AddTicks(6244));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 5,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 6, 15, 41, 55, 542, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 6,
                column: "PocetakPrikazivanja",
                value: new DateTime(2024, 1, 6, 15, 41, 55, 542, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Kupovina",
                keyColumn: "KupovinaId",
                keyValue: 1,
                columns: new[] { "DatumKupovine", "PaymentIntentId" },
                values: new object[] { new DateTime(2024, 1, 6, 15, 41, 55, 542, DateTimeKind.Local).AddTicks(7278), "pi_3NwMiYEDYm8POibP1HZgAANw_secret_L1f7hpTvlCWjJJXmeJaTwZO06" });

            migrationBuilder.UpdateData(
                table: "Kupovina",
                keyColumn: "KupovinaId",
                keyValue: 2,
                columns: new[] { "DatumKupovine", "PaymentIntentId" },
                values: new object[] { new DateTime(2024, 1, 6, 15, 41, 55, 542, DateTimeKind.Local).AddTicks(7288), "pi_3NwMiYEDYm8POibP1HZgAANw_secret_L1f7hpTvlCWjJJXmeJaTwZO06" });

            migrationBuilder.UpdateData(
                table: "Kupovina",
                keyColumn: "KupovinaId",
                keyValue: 3,
                columns: new[] { "DatumKupovine", "PaymentIntentId" },
                values: new object[] { new DateTime(2024, 1, 6, 15, 41, 55, 542, DateTimeKind.Local).AddTicks(7290), "pi_3NwMiYEDYm8POibP1HZgAANw_secret_L1f7hpTvlCWjJJXmeJaTwZO06" });

            migrationBuilder.UpdateData(
                table: "Kupovina",
                keyColumn: "KupovinaId",
                keyValue: 4,
                columns: new[] { "DatumKupovine", "PaymentIntentId" },
                values: new object[] { new DateTime(2024, 1, 6, 15, 41, 55, 542, DateTimeKind.Local).AddTicks(7293), "pi_3NwMiYEDYm8POibP1HZgAANw_secret_L1f7hpTvlCWjJJXmeJaTwZO06" });

            migrationBuilder.UpdateData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 1,
                column: "DatumKreiranja",
                value: new DateTime(2024, 1, 6, 15, 41, 55, 542, DateTimeKind.Local).AddTicks(6121));

            migrationBuilder.UpdateData(
                table: "Obavijest",
                keyColumn: "ObavijestId",
                keyValue: 2,
                column: "DatumKreiranja",
                value: new DateTime(2024, 1, 6, 15, 41, 55, 542, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 1,
                column: "DatumOdrzavanja",
                value: new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 2,
                column: "DatumOdrzavanja",
                value: new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 3,
                column: "DatumOdrzavanja",
                value: new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 4,
                column: "DatumOdrzavanja",
                value: new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 5,
                column: "DatumOdrzavanja",
                value: new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 6,
                column: "DatumOdrzavanja",
                value: new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
