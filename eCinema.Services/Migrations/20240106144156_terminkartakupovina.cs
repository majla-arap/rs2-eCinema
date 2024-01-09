using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCinema.Services.Migrations
{
    public partial class terminkartakupovina : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DatumOdrzavanja",
                table: "Termin",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VrijemeOdrzavanja",
                table: "Termin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Kolicina",
                table: "Kupovina",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Cijena",
                table: "Kupovina",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PaymentIntentId",
                table: "Kupovina",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Placena",
                table: "Kupovina",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TerminId",
                table: "Kupovina",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BrojReda",
                table: "Karta",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BrojSjedista",
                table: "Karta",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "KupovinaId",
                table: "Karta",
                type: "int",
                nullable: true);

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

            migrationBuilder.InsertData(
                table: "Termin",
                columns: new[] { "TerminId", "CijenaKarte", "DatumOdrzavanja", "DvoranaId", "FilmId", "Predpremijera", "Premijera", "VrijemeOdrzavanja" },
                values: new object[,]
                {
                    { 1, 20, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), 1, 1, true, false, "20:00" },
                    { 2, 10, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), 2, 2, true, false, "20:00" },
                    { 3, 20, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), 2, 3, true, false, "20:00" },
                    { 4, 20, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Local), 2, 4, true, false, "18:00" },
                    { 5, 10, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Local), 2, 5, true, false, "18:00" },
                    { 6, 10, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Local), 2, 6, true, false, "18:00" }
                });

            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "KartaId", "Aktivna", "BrojReda", "BrojSjedista", "KupovinaId", "Sjediste", "TerminId" },
                values: new object[,]
                {
                    { 3, true, "A", 3, null, "A3", 1 },
                    { 4, true, "A", 4, null, "A4", 1 },
                    { 5, true, "A", 5, null, "A5", 1 },
                    { 6, true, "A", 6, null, "A6", 1 },
                    { 7, true, "A", 7, null, "A7", 1 },
                    { 8, true, "A", 8, null, "A8", 1 },
                    { 9, true, "A", 9, null, "A9", 1 },
                    { 10, true, "A", 10, null, "A10", 1 },
                    { 11, true, "A", 11, null, "A11", 1 },
                    { 12, true, "A", 12, null, "A12", 1 },
                    { 13, true, "A", 13, null, "A13", 1 },
                    { 14, true, "A", 14, null, "A14", 1 },
                    { 15, true, "A", 15, null, "A15", 1 },
                    { 16, true, "B", 1, null, "B1", 1 },
                    { 17, true, "B", 2, null, "B2", 1 },
                    { 18, true, "B", 3, null, "B3", 1 },
                    { 19, true, "B", 4, null, "B4", 1 },
                    { 20, true, "B", 5, null, "B5", 1 },
                    { 21, true, "B", 6, null, "B6", 1 },
                    { 22, true, "B", 7, null, "B7", 1 },
                    { 23, true, "B", 8, null, "B8", 1 },
                    { 24, true, "B", 9, null, "B9", 1 },
                    { 25, true, "B", 10, null, "B10", 1 },
                    { 26, true, "B", 11, null, "B11", 1 },
                    { 27, true, "B", 12, null, "B12", 1 },
                    { 28, true, "B", 13, null, "B13", 1 },
                    { 29, true, "B", 14, null, "B14", 1 },
                    { 30, true, "B", 15, null, "B15", 1 },
                    { 31, true, "C", 1, null, "C1", 1 },
                    { 32, true, "C", 2, null, "C2", 1 },
                    { 33, true, "C", 3, null, "C3", 1 },
                    { 34, true, "C", 4, null, "C4", 1 },
                    { 35, true, "C", 5, null, "C5", 1 },
                    { 36, true, "C", 6, null, "C6", 1 },
                    { 37, true, "C", 7, null, "C7", 1 },
                    { 38, true, "C", 8, null, "C8", 1 },
                    { 39, true, "C", 9, null, "C9", 1 },
                    { 40, true, "C", 10, null, "C10", 1 },
                    { 41, true, "C", 11, null, "C11", 1 },
                    { 42, true, "C", 12, null, "C12", 1 },
                    { 43, true, "C", 13, null, "C13", 1 },
                    { 44, true, "C", 14, null, "C14", 1 }
                });

            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "KartaId", "Aktivna", "BrojReda", "BrojSjedista", "KupovinaId", "Sjediste", "TerminId" },
                values: new object[,]
                {
                    { 45, true, "C", 15, null, "C15", 1 },
                    { 46, true, "D", 1, null, "D1", 1 },
                    { 47, true, "D", 2, null, "D2", 1 },
                    { 48, true, "D", 3, null, "D3", 1 },
                    { 49, true, "D", 4, null, "D4", 1 },
                    { 50, true, "D", 5, null, "D5", 1 },
                    { 51, true, "D", 6, null, "D6", 1 },
                    { 52, true, "D", 7, null, "D7", 1 },
                    { 53, true, "D", 8, null, "D8", 1 },
                    { 54, true, "D", 9, null, "D9", 1 },
                    { 55, true, "D", 10, null, "D10", 1 },
                    { 56, true, "D", 11, null, "D11", 1 },
                    { 57, true, "D", 12, null, "D12", 1 },
                    { 58, true, "D", 13, null, "D13", 1 },
                    { 59, true, "D", 14, null, "D14", 1 },
                    { 60, true, "D", 15, null, "D15", 1 },
                    { 61, true, "E", 1, null, "E1", 1 },
                    { 62, true, "E", 2, null, "E2", 1 },
                    { 63, true, "E", 3, null, "E3", 1 },
                    { 64, true, "E", 4, null, "E4", 1 },
                    { 65, true, "E", 5, null, "E5", 1 },
                    { 66, true, "E", 6, null, "E6", 1 },
                    { 67, true, "E", 7, null, "E7", 1 },
                    { 68, true, "E", 8, null, "E8", 1 },
                    { 69, true, "E", 9, null, "E9", 1 },
                    { 70, true, "E", 10, null, "E10", 1 },
                    { 71, true, "E", 11, null, "E11", 1 },
                    { 72, true, "E", 12, null, "E12", 1 },
                    { 73, true, "E", 13, null, "E13", 1 },
                    { 74, true, "E", 14, null, "E14", 1 },
                    { 75, true, "E", 15, null, "E15", 1 },
                    { 76, true, "F", 1, null, "F1", 1 },
                    { 77, true, "F", 2, null, "F2", 1 },
                    { 78, true, "F", 3, null, "F3", 1 },
                    { 79, true, "F", 4, null, "F4", 1 },
                    { 80, true, "F", 5, null, "F5", 1 },
                    { 81, true, "F", 6, null, "F6", 1 },
                    { 82, true, "F", 7, null, "F7", 1 },
                    { 83, true, "F", 8, null, "F8", 1 },
                    { 84, true, "F", 9, null, "F9", 1 },
                    { 85, true, "F", 10, null, "F10", 1 },
                    { 86, true, "F", 11, null, "F11", 1 }
                });

            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "KartaId", "Aktivna", "BrojReda", "BrojSjedista", "KupovinaId", "Sjediste", "TerminId" },
                values: new object[,]
                {
                    { 87, true, "F", 12, null, "F12", 1 },
                    { 88, true, "F", 13, null, "F13", 1 },
                    { 89, true, "F", 14, null, "F14", 1 },
                    { 90, true, "F", 15, null, "F15", 1 },
                    { 91, true, "G", 1, null, "G1", 1 },
                    { 92, true, "G", 2, null, "G2", 1 },
                    { 93, true, "G", 3, null, "G3", 1 },
                    { 94, true, "G", 4, null, "G4", 1 },
                    { 95, true, "G", 5, null, "G5", 1 },
                    { 96, true, "G", 6, null, "G6", 1 },
                    { 97, true, "G", 7, null, "G7", 1 },
                    { 98, true, "G", 8, null, "G8", 1 },
                    { 99, true, "G", 9, null, "G9", 1 },
                    { 100, true, "G", 10, null, "G10", 1 },
                    { 101, true, "G", 11, null, "G11", 1 },
                    { 102, true, "G", 12, null, "G12", 1 },
                    { 103, true, "G", 13, null, "G13", 1 },
                    { 104, true, "G", 14, null, "G14", 1 },
                    { 105, true, "G", 15, null, "G15", 1 },
                    { 106, true, "H", 1, null, "H1", 1 },
                    { 107, true, "H", 2, null, "H2", 1 },
                    { 108, true, "H", 3, null, "H3", 1 },
                    { 109, true, "H", 4, null, "H4", 1 },
                    { 110, true, "H", 5, null, "H5", 1 },
                    { 111, true, "H", 6, null, "H6", 1 },
                    { 112, true, "H", 7, null, "H7", 1 },
                    { 113, true, "H", 8, null, "H8", 1 },
                    { 114, true, "H", 9, null, "H9", 1 },
                    { 115, true, "H", 10, null, "H10", 1 },
                    { 116, true, "H", 11, null, "H11", 1 },
                    { 117, true, "H", 12, null, "H12", 1 },
                    { 118, true, "H", 13, null, "H13", 1 },
                    { 119, true, "H", 14, null, "H14", 1 },
                    { 120, true, "H", 15, null, "H15", 1 },
                    { 121, true, "I", 1, null, "I1", 1 },
                    { 122, true, "I", 2, null, "I2", 1 },
                    { 123, true, "I", 3, null, "I3", 1 },
                    { 124, true, "I", 4, null, "I4", 1 },
                    { 125, true, "I", 5, null, "I5", 1 },
                    { 126, true, "I", 6, null, "I6", 1 },
                    { 127, true, "I", 7, null, "I7", 1 },
                    { 128, true, "I", 8, null, "I8", 1 }
                });

            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "KartaId", "Aktivna", "BrojReda", "BrojSjedista", "KupovinaId", "Sjediste", "TerminId" },
                values: new object[,]
                {
                    { 129, true, "I", 9, null, "I9", 1 },
                    { 130, true, "I", 10, null, "I10", 1 },
                    { 131, true, "I", 11, null, "I11", 1 },
                    { 132, true, "I", 12, null, "I12", 1 },
                    { 133, true, "I", 13, null, "I13", 1 },
                    { 134, true, "I", 14, null, "I14", 1 },
                    { 135, true, "I", 15, null, "I15", 1 },
                    { 136, true, "J", 1, null, "J1", 1 },
                    { 137, true, "J", 2, null, "J2", 1 },
                    { 138, true, "J", 3, null, "J3", 1 },
                    { 139, true, "J", 4, null, "J4", 1 },
                    { 140, true, "J", 5, null, "J5", 1 },
                    { 141, true, "J", 6, null, "J6", 1 },
                    { 142, true, "J", 7, null, "J7", 1 },
                    { 143, true, "J", 8, null, "J8", 1 },
                    { 144, true, "J", 9, null, "J9", 1 },
                    { 145, true, "J", 10, null, "J10", 1 },
                    { 146, true, "J", 11, null, "J11", 1 },
                    { 147, true, "J", 12, null, "J12", 1 },
                    { 148, true, "J", 13, null, "J13", 1 },
                    { 149, true, "J", 14, null, "J14", 1 },
                    { 150, true, "J", 15, null, "J15", 1 },
                    { 153, true, "A", 3, null, "A3", 2 },
                    { 154, true, "A", 4, null, "A4", 2 },
                    { 155, true, "A", 5, null, "A5", 2 },
                    { 156, true, "A", 6, null, "A6", 2 },
                    { 157, true, "A", 7, null, "A7", 2 },
                    { 158, true, "A", 8, null, "A8", 2 },
                    { 159, true, "A", 9, null, "A9", 2 },
                    { 160, true, "A", 10, null, "A10", 2 },
                    { 161, true, "B", 1, null, "B1", 2 },
                    { 162, true, "B", 2, null, "B2", 2 },
                    { 163, true, "B", 3, null, "B3", 2 },
                    { 164, true, "B", 4, null, "B4", 2 },
                    { 165, true, "B", 5, null, "B5", 2 },
                    { 166, true, "B", 6, null, "B6", 2 },
                    { 167, true, "B", 7, null, "B7", 2 },
                    { 168, true, "B", 8, null, "B8", 2 },
                    { 169, true, "B", 9, null, "B9", 2 },
                    { 170, true, "B", 10, null, "B10", 2 },
                    { 171, true, "C", 1, null, "C1", 2 },
                    { 172, true, "C", 2, null, "C2", 2 }
                });

            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "KartaId", "Aktivna", "BrojReda", "BrojSjedista", "KupovinaId", "Sjediste", "TerminId" },
                values: new object[,]
                {
                    { 173, true, "C", 3, null, "C3", 2 },
                    { 174, true, "C", 4, null, "C4", 2 },
                    { 175, true, "C", 5, null, "C5", 2 },
                    { 176, true, "C", 6, null, "C6", 2 },
                    { 177, true, "C", 7, null, "C7", 2 },
                    { 178, true, "C", 8, null, "C8", 2 },
                    { 179, true, "C", 9, null, "C9", 2 },
                    { 180, true, "C", 10, null, "C10", 2 },
                    { 181, true, "D", 1, null, "D1", 2 },
                    { 182, true, "D", 2, null, "D2", 2 },
                    { 183, true, "D", 3, null, "D3", 2 },
                    { 184, true, "D", 4, null, "D4", 2 },
                    { 185, true, "D", 5, null, "D5", 2 },
                    { 186, true, "D", 6, null, "D6", 2 },
                    { 187, true, "D", 7, null, "D7", 2 },
                    { 188, true, "D", 8, null, "D8", 2 },
                    { 189, true, "D", 9, null, "D9", 2 },
                    { 190, true, "D", 10, null, "D10", 2 },
                    { 191, true, "E", 1, null, "E1", 2 },
                    { 192, true, "E", 2, null, "E2", 2 },
                    { 193, true, "E", 3, null, "E3", 2 },
                    { 194, true, "E", 4, null, "E4", 2 },
                    { 195, true, "E", 5, null, "E5", 2 },
                    { 196, true, "E", 6, null, "E6", 2 },
                    { 197, true, "E", 7, null, "E7", 2 },
                    { 198, true, "E", 8, null, "E8", 2 },
                    { 199, true, "E", 9, null, "E9", 2 },
                    { 200, true, "E", 10, null, "E10", 2 },
                    { 201, true, "F", 1, null, "F1", 2 },
                    { 202, true, "F", 2, null, "F2", 2 },
                    { 203, true, "F", 3, null, "F3", 2 },
                    { 204, true, "F", 4, null, "F4", 2 },
                    { 205, true, "F", 5, null, "F5", 2 },
                    { 206, true, "F", 6, null, "F6", 2 },
                    { 207, true, "F", 7, null, "F7", 2 },
                    { 208, true, "F", 8, null, "F8", 2 },
                    { 209, true, "F", 9, null, "F9", 2 },
                    { 210, true, "F", 10, null, "F10", 2 },
                    { 211, true, "G", 1, null, "G1", 2 },
                    { 212, true, "G", 2, null, "G2", 2 },
                    { 213, true, "G", 3, null, "G3", 2 },
                    { 214, true, "G", 4, null, "G4", 2 }
                });

            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "KartaId", "Aktivna", "BrojReda", "BrojSjedista", "KupovinaId", "Sjediste", "TerminId" },
                values: new object[,]
                {
                    { 215, true, "G", 5, null, "G5", 2 },
                    { 216, true, "G", 6, null, "G6", 2 },
                    { 217, true, "G", 7, null, "G7", 2 },
                    { 218, true, "G", 8, null, "G8", 2 },
                    { 219, true, "G", 9, null, "G9", 2 },
                    { 220, true, "G", 10, null, "G10", 2 },
                    { 221, true, "H", 1, null, "H1", 2 },
                    { 222, true, "H", 2, null, "H2", 2 },
                    { 223, true, "H", 3, null, "H3", 2 },
                    { 224, true, "H", 4, null, "H4", 2 },
                    { 225, true, "H", 5, null, "H5", 2 },
                    { 226, true, "H", 6, null, "H6", 2 },
                    { 227, true, "H", 7, null, "H7", 2 },
                    { 228, true, "H", 8, null, "H8", 2 },
                    { 229, true, "H", 9, null, "H9", 2 },
                    { 230, true, "H", 10, null, "H10", 2 },
                    { 231, true, "I", 1, null, "I1", 2 },
                    { 232, true, "I", 2, null, "I2", 2 },
                    { 233, true, "I", 3, null, "I3", 2 },
                    { 234, true, "I", 4, null, "I4", 2 },
                    { 235, true, "I", 5, null, "I5", 2 },
                    { 236, true, "I", 6, null, "I6", 2 },
                    { 237, true, "I", 7, null, "I7", 2 },
                    { 238, true, "I", 8, null, "I8", 2 },
                    { 239, true, "I", 9, null, "I9", 2 },
                    { 240, true, "I", 10, null, "I10", 2 },
                    { 241, true, "J", 1, null, "J1", 2 },
                    { 242, true, "J", 2, null, "J2", 2 },
                    { 243, true, "J", 3, null, "J3", 2 },
                    { 244, true, "J", 4, null, "J4", 2 },
                    { 245, true, "J", 5, null, "J5", 2 },
                    { 246, true, "J", 6, null, "J6", 2 },
                    { 247, true, "J", 7, null, "J7", 2 },
                    { 248, true, "J", 8, null, "J8", 2 },
                    { 249, true, "J", 9, null, "J9", 2 },
                    { 250, true, "J", 10, null, "J10", 2 },
                    { 251, true, "A", 1, null, "A1", 3 },
                    { 252, true, "A", 2, null, "A2", 3 },
                    { 253, true, "A", 3, null, "A3", 3 },
                    { 254, true, "A", 4, null, "A4", 3 },
                    { 255, true, "A", 5, null, "A5", 3 },
                    { 256, true, "A", 6, null, "A6", 3 }
                });

            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "KartaId", "Aktivna", "BrojReda", "BrojSjedista", "KupovinaId", "Sjediste", "TerminId" },
                values: new object[,]
                {
                    { 257, true, "A", 7, null, "A7", 3 },
                    { 258, true, "A", 8, null, "A8", 3 },
                    { 259, true, "A", 9, null, "A9", 3 },
                    { 260, true, "A", 10, null, "A10", 3 },
                    { 261, true, "B", 1, null, "B1", 3 },
                    { 262, true, "B", 2, null, "B2", 3 },
                    { 263, true, "B", 3, null, "B3", 3 },
                    { 264, true, "B", 4, null, "B4", 3 },
                    { 265, true, "B", 5, null, "B5", 3 },
                    { 266, true, "B", 6, null, "B6", 3 },
                    { 267, true, "B", 7, null, "B7", 3 },
                    { 268, true, "B", 8, null, "B8", 3 },
                    { 269, true, "B", 9, null, "B9", 3 },
                    { 270, true, "B", 10, null, "B10", 3 },
                    { 271, true, "C", 1, null, "C1", 3 },
                    { 272, true, "C", 2, null, "C2", 3 },
                    { 273, true, "C", 3, null, "C3", 3 },
                    { 274, true, "C", 4, null, "C4", 3 },
                    { 275, true, "C", 5, null, "C5", 3 },
                    { 276, true, "C", 6, null, "C6", 3 },
                    { 277, true, "C", 7, null, "C7", 3 },
                    { 278, true, "C", 8, null, "C8", 3 },
                    { 279, true, "C", 9, null, "C9", 3 },
                    { 280, true, "C", 10, null, "C10", 3 },
                    { 281, true, "D", 1, null, "D1", 3 },
                    { 282, true, "D", 2, null, "D2", 3 },
                    { 283, true, "D", 3, null, "D3", 3 },
                    { 284, true, "D", 4, null, "D4", 3 },
                    { 285, true, "D", 5, null, "D5", 3 },
                    { 286, true, "D", 6, null, "D6", 3 },
                    { 287, true, "D", 7, null, "D7", 3 },
                    { 288, true, "D", 8, null, "D8", 3 },
                    { 289, true, "D", 9, null, "D9", 3 },
                    { 290, true, "D", 10, null, "D10", 3 },
                    { 291, true, "E", 1, null, "E1", 3 },
                    { 292, true, "E", 2, null, "E2", 3 },
                    { 293, true, "E", 3, null, "E3", 3 },
                    { 294, true, "E", 4, null, "E4", 3 },
                    { 295, true, "E", 5, null, "E5", 3 },
                    { 296, true, "E", 6, null, "E6", 3 },
                    { 297, true, "E", 7, null, "E7", 3 },
                    { 298, true, "E", 8, null, "E8", 3 }
                });

            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "KartaId", "Aktivna", "BrojReda", "BrojSjedista", "KupovinaId", "Sjediste", "TerminId" },
                values: new object[,]
                {
                    { 299, true, "E", 9, null, "E9", 3 },
                    { 300, true, "E", 10, null, "E10", 3 },
                    { 301, true, "F", 1, null, "F1", 3 },
                    { 302, true, "F", 2, null, "F2", 3 },
                    { 303, true, "F", 3, null, "F3", 3 },
                    { 304, true, "F", 4, null, "F4", 3 },
                    { 305, true, "F", 5, null, "F5", 3 },
                    { 306, true, "F", 6, null, "F6", 3 },
                    { 307, true, "F", 7, null, "F7", 3 },
                    { 308, true, "F", 8, null, "F8", 3 },
                    { 309, true, "F", 9, null, "F9", 3 },
                    { 310, true, "F", 10, null, "F10", 3 },
                    { 311, true, "G", 1, null, "G1", 3 },
                    { 312, true, "G", 2, null, "G2", 3 },
                    { 313, true, "G", 3, null, "G3", 3 },
                    { 314, true, "G", 4, null, "G4", 3 },
                    { 315, true, "G", 5, null, "G5", 3 },
                    { 316, true, "G", 6, null, "G6", 3 },
                    { 317, true, "G", 7, null, "G7", 3 },
                    { 318, true, "G", 8, null, "G8", 3 },
                    { 319, true, "G", 9, null, "G9", 3 },
                    { 320, true, "G", 10, null, "G10", 3 },
                    { 321, true, "H", 1, null, "H1", 3 },
                    { 322, true, "H", 2, null, "H2", 3 },
                    { 323, true, "H", 3, null, "H3", 3 },
                    { 324, true, "H", 4, null, "H4", 3 },
                    { 325, true, "H", 5, null, "H5", 3 },
                    { 326, true, "H", 6, null, "H6", 3 },
                    { 327, true, "H", 7, null, "H7", 3 },
                    { 328, true, "H", 8, null, "H8", 3 },
                    { 329, true, "H", 9, null, "H9", 3 },
                    { 330, true, "H", 10, null, "H10", 3 },
                    { 331, true, "I", 1, null, "I1", 3 },
                    { 332, true, "I", 2, null, "I2", 3 },
                    { 333, true, "I", 3, null, "I3", 3 },
                    { 334, true, "I", 4, null, "I4", 3 },
                    { 335, true, "I", 5, null, "I5", 3 },
                    { 336, true, "I", 6, null, "I6", 3 },
                    { 337, true, "I", 7, null, "I7", 3 },
                    { 338, true, "I", 8, null, "I8", 3 },
                    { 339, true, "I", 9, null, "I9", 3 },
                    { 340, true, "I", 10, null, "I10", 3 }
                });

            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "KartaId", "Aktivna", "BrojReda", "BrojSjedista", "KupovinaId", "Sjediste", "TerminId" },
                values: new object[,]
                {
                    { 341, true, "J", 1, null, "J1", 3 },
                    { 342, true, "J", 2, null, "J2", 3 },
                    { 343, true, "J", 3, null, "J3", 3 },
                    { 344, true, "J", 4, null, "J4", 3 },
                    { 345, true, "J", 5, null, "J5", 3 },
                    { 346, true, "J", 6, null, "J6", 3 },
                    { 347, true, "J", 7, null, "J7", 3 },
                    { 348, true, "J", 8, null, "J8", 3 },
                    { 349, true, "J", 9, null, "J9", 3 },
                    { 350, true, "J", 10, null, "J10", 3 },
                    { 351, true, "A", 1, null, "A1", 4 },
                    { 352, true, "A", 2, null, "A2", 4 },
                    { 353, true, "A", 3, null, "A3", 4 },
                    { 354, true, "A", 4, null, "A4", 4 },
                    { 355, true, "A", 5, null, "A5", 4 },
                    { 356, true, "A", 6, null, "A6", 4 },
                    { 357, true, "A", 7, null, "A7", 4 },
                    { 358, true, "A", 8, null, "A8", 4 },
                    { 359, true, "A", 9, null, "A9", 4 },
                    { 360, true, "A", 10, null, "A10", 4 },
                    { 361, true, "B", 1, null, "B1", 4 },
                    { 362, true, "B", 2, null, "B2", 4 },
                    { 363, true, "B", 3, null, "B3", 4 },
                    { 364, true, "B", 4, null, "B4", 4 },
                    { 365, true, "B", 5, null, "B5", 4 },
                    { 366, true, "B", 6, null, "B6", 4 },
                    { 367, true, "B", 7, null, "B7", 4 },
                    { 368, true, "B", 8, null, "B8", 4 },
                    { 369, true, "B", 9, null, "B9", 4 },
                    { 370, true, "B", 10, null, "B10", 4 },
                    { 371, true, "C", 1, null, "C1", 4 },
                    { 372, true, "C", 2, null, "C2", 4 },
                    { 373, true, "C", 3, null, "C3", 4 },
                    { 374, true, "C", 4, null, "C4", 4 },
                    { 375, true, "C", 5, null, "C5", 4 },
                    { 376, true, "C", 6, null, "C6", 4 },
                    { 377, true, "C", 7, null, "C7", 4 },
                    { 378, true, "C", 8, null, "C8", 4 },
                    { 379, true, "C", 9, null, "C9", 4 },
                    { 380, true, "C", 10, null, "C10", 4 },
                    { 381, true, "D", 1, null, "D1", 4 },
                    { 382, true, "D", 2, null, "D2", 4 }
                });

            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "KartaId", "Aktivna", "BrojReda", "BrojSjedista", "KupovinaId", "Sjediste", "TerminId" },
                values: new object[,]
                {
                    { 383, true, "D", 3, null, "D3", 4 },
                    { 384, true, "D", 4, null, "D4", 4 },
                    { 385, true, "D", 5, null, "D5", 4 },
                    { 386, true, "D", 6, null, "D6", 4 },
                    { 387, true, "D", 7, null, "D7", 4 },
                    { 388, true, "D", 8, null, "D8", 4 },
                    { 389, true, "D", 9, null, "D9", 4 },
                    { 390, true, "D", 10, null, "D10", 4 },
                    { 391, true, "E", 1, null, "E1", 4 },
                    { 392, true, "E", 2, null, "E2", 4 },
                    { 393, true, "E", 3, null, "E3", 4 },
                    { 394, true, "E", 4, null, "E4", 4 },
                    { 395, true, "E", 5, null, "E5", 4 },
                    { 396, true, "E", 6, null, "E6", 4 },
                    { 397, true, "E", 7, null, "E7", 4 },
                    { 398, true, "E", 8, null, "E8", 4 },
                    { 399, true, "E", 9, null, "E9", 4 },
                    { 400, true, "E", 10, null, "E10", 4 },
                    { 401, true, "F", 1, null, "F1", 4 },
                    { 402, true, "F", 2, null, "F2", 4 },
                    { 403, true, "F", 3, null, "F3", 4 },
                    { 404, true, "F", 4, null, "F4", 4 },
                    { 405, true, "F", 5, null, "F5", 4 },
                    { 406, true, "F", 6, null, "F6", 4 },
                    { 407, true, "F", 7, null, "F7", 4 },
                    { 408, true, "F", 8, null, "F8", 4 },
                    { 409, true, "F", 9, null, "F9", 4 },
                    { 410, true, "F", 10, null, "F10", 4 },
                    { 411, true, "G", 1, null, "G1", 4 },
                    { 412, true, "G", 2, null, "G2", 4 },
                    { 413, true, "G", 3, null, "G3", 4 },
                    { 414, true, "G", 4, null, "G4", 4 },
                    { 415, true, "G", 5, null, "G5", 4 },
                    { 416, true, "G", 6, null, "G6", 4 },
                    { 417, true, "G", 7, null, "G7", 4 },
                    { 418, true, "G", 8, null, "G8", 4 },
                    { 419, true, "G", 9, null, "G9", 4 },
                    { 420, true, "G", 10, null, "G10", 4 },
                    { 421, true, "H", 1, null, "H1", 4 },
                    { 422, true, "H", 2, null, "H2", 4 },
                    { 423, true, "H", 3, null, "H3", 4 },
                    { 424, true, "H", 4, null, "H4", 4 }
                });

            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "KartaId", "Aktivna", "BrojReda", "BrojSjedista", "KupovinaId", "Sjediste", "TerminId" },
                values: new object[,]
                {
                    { 425, true, "H", 5, null, "H5", 4 },
                    { 426, true, "H", 6, null, "H6", 4 },
                    { 427, true, "H", 7, null, "H7", 4 },
                    { 428, true, "H", 8, null, "H8", 4 },
                    { 429, true, "H", 9, null, "H9", 4 },
                    { 430, true, "H", 10, null, "H10", 4 },
                    { 431, true, "I", 1, null, "I1", 4 },
                    { 432, true, "I", 2, null, "I2", 4 },
                    { 433, true, "I", 3, null, "I3", 4 },
                    { 434, true, "I", 4, null, "I4", 4 },
                    { 435, true, "I", 5, null, "I5", 4 },
                    { 436, true, "I", 6, null, "I6", 4 },
                    { 437, true, "I", 7, null, "I7", 4 },
                    { 438, true, "I", 8, null, "I8", 4 },
                    { 439, true, "I", 9, null, "I9", 4 },
                    { 440, true, "I", 10, null, "I10", 4 },
                    { 441, true, "J", 1, null, "J1", 4 },
                    { 442, true, "J", 2, null, "J2", 4 },
                    { 443, true, "J", 3, null, "J3", 4 },
                    { 444, true, "J", 4, null, "J4", 4 },
                    { 445, true, "J", 5, null, "J5", 4 },
                    { 446, true, "J", 6, null, "J6", 4 },
                    { 447, true, "J", 7, null, "J7", 4 },
                    { 448, true, "J", 8, null, "J8", 4 },
                    { 449, true, "J", 9, null, "J9", 4 },
                    { 450, true, "J", 10, null, "J10", 4 },
                    { 451, true, "A", 1, null, "A1", 5 },
                    { 452, true, "A", 2, null, "A2", 5 },
                    { 454, true, "A", 4, null, "A4", 5 },
                    { 455, true, "A", 5, null, "A5", 5 },
                    { 456, true, "A", 6, null, "A6", 5 },
                    { 457, true, "A", 7, null, "A7", 5 },
                    { 458, true, "A", 8, null, "A8", 5 },
                    { 459, true, "A", 9, null, "A9", 5 },
                    { 460, true, "A", 10, null, "A10", 5 },
                    { 461, true, "B", 1, null, "B1", 5 },
                    { 462, true, "B", 2, null, "B2", 5 },
                    { 463, true, "B", 3, null, "B3", 5 },
                    { 464, true, "B", 4, null, "B4", 5 },
                    { 465, true, "B", 5, null, "B5", 5 },
                    { 466, true, "B", 6, null, "B6", 5 },
                    { 467, true, "B", 7, null, "B7", 5 }
                });

            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "KartaId", "Aktivna", "BrojReda", "BrojSjedista", "KupovinaId", "Sjediste", "TerminId" },
                values: new object[,]
                {
                    { 468, true, "B", 8, null, "B8", 5 },
                    { 469, true, "B", 9, null, "B9", 5 },
                    { 470, true, "B", 10, null, "B10", 5 },
                    { 471, true, "C", 1, null, "C1", 5 },
                    { 472, true, "C", 2, null, "C2", 5 },
                    { 473, true, "C", 3, null, "C3", 5 },
                    { 474, true, "C", 4, null, "C4", 5 },
                    { 475, true, "C", 5, null, "C5", 5 },
                    { 476, true, "C", 6, null, "C6", 5 },
                    { 477, true, "C", 7, null, "C7", 5 },
                    { 478, true, "C", 8, null, "C8", 5 },
                    { 479, true, "C", 9, null, "C9", 5 },
                    { 480, true, "C", 10, null, "C10", 5 },
                    { 481, true, "D", 1, null, "D1", 5 },
                    { 482, true, "D", 2, null, "D2", 5 },
                    { 483, true, "D", 3, null, "D3", 5 },
                    { 484, true, "D", 4, null, "D4", 5 },
                    { 485, true, "D", 5, null, "D5", 5 },
                    { 486, true, "D", 6, null, "D6", 5 },
                    { 487, true, "D", 7, null, "D7", 5 },
                    { 488, true, "D", 8, null, "D8", 5 },
                    { 489, true, "D", 9, null, "D9", 5 },
                    { 490, true, "D", 10, null, "D10", 5 },
                    { 491, true, "E", 1, null, "E1", 5 },
                    { 492, true, "E", 2, null, "E2", 5 },
                    { 493, true, "E", 3, null, "E3", 5 },
                    { 494, true, "E", 4, null, "E4", 5 },
                    { 495, true, "E", 5, null, "E5", 5 },
                    { 496, true, "E", 6, null, "E6", 5 },
                    { 497, true, "E", 7, null, "E7", 5 },
                    { 498, true, "E", 8, null, "E8", 5 },
                    { 499, true, "E", 9, null, "E9", 5 },
                    { 500, true, "E", 10, null, "E10", 5 },
                    { 501, true, "F", 1, null, "F1", 5 },
                    { 502, true, "F", 2, null, "F2", 5 },
                    { 503, true, "F", 3, null, "F3", 5 },
                    { 504, true, "F", 4, null, "F4", 5 },
                    { 505, true, "F", 5, null, "F5", 5 },
                    { 506, true, "F", 6, null, "F6", 5 },
                    { 507, true, "F", 7, null, "F7", 5 },
                    { 508, true, "F", 8, null, "F8", 5 },
                    { 509, true, "F", 9, null, "F9", 5 }
                });

            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "KartaId", "Aktivna", "BrojReda", "BrojSjedista", "KupovinaId", "Sjediste", "TerminId" },
                values: new object[,]
                {
                    { 510, true, "F", 10, null, "F10", 5 },
                    { 511, true, "G", 1, null, "G1", 5 },
                    { 512, true, "G", 2, null, "G2", 5 },
                    { 513, true, "G", 3, null, "G3", 5 },
                    { 514, true, "G", 4, null, "G4", 5 },
                    { 515, true, "G", 5, null, "G5", 5 },
                    { 516, true, "G", 6, null, "G6", 5 },
                    { 517, true, "G", 7, null, "G7", 5 },
                    { 518, true, "G", 8, null, "G8", 5 },
                    { 519, true, "G", 9, null, "G9", 5 },
                    { 520, true, "G", 10, null, "G10", 5 },
                    { 521, true, "H", 1, null, "H1", 5 },
                    { 522, true, "H", 2, null, "H2", 5 },
                    { 523, true, "H", 3, null, "H3", 5 },
                    { 524, true, "H", 4, null, "H4", 5 },
                    { 525, true, "H", 5, null, "H5", 5 },
                    { 526, true, "H", 6, null, "H6", 5 },
                    { 527, true, "H", 7, null, "H7", 5 },
                    { 528, true, "H", 8, null, "H8", 5 },
                    { 529, true, "H", 9, null, "H9", 5 },
                    { 530, true, "H", 10, null, "H10", 5 },
                    { 531, true, "I", 1, null, "I1", 5 },
                    { 532, true, "I", 2, null, "I2", 5 },
                    { 533, true, "I", 3, null, "I3", 5 },
                    { 534, true, "I", 4, null, "I4", 5 },
                    { 535, true, "I", 5, null, "I5", 5 },
                    { 536, true, "I", 6, null, "I6", 5 },
                    { 537, true, "I", 7, null, "I7", 5 },
                    { 538, true, "I", 8, null, "I8", 5 },
                    { 539, true, "I", 9, null, "I9", 5 },
                    { 540, true, "I", 10, null, "I10", 5 },
                    { 541, true, "J", 1, null, "J1", 5 },
                    { 542, true, "J", 2, null, "J2", 5 },
                    { 543, true, "J", 3, null, "J3", 5 },
                    { 544, true, "J", 4, null, "J4", 5 },
                    { 545, true, "J", 5, null, "J5", 5 },
                    { 546, true, "J", 6, null, "J6", 5 },
                    { 547, true, "J", 7, null, "J7", 5 },
                    { 548, true, "J", 8, null, "J8", 5 },
                    { 549, true, "J", 9, null, "J9", 5 },
                    { 553, true, "A", 3, null, "A3", 6 },
                    { 554, true, "A", 4, null, "A4", 6 }
                });

            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "KartaId", "Aktivna", "BrojReda", "BrojSjedista", "KupovinaId", "Sjediste", "TerminId" },
                values: new object[,]
                {
                    { 555, true, "A", 5, null, "A5", 6 },
                    { 556, true, "A", 6, null, "A6", 6 },
                    { 557, true, "A", 7, null, "A7", 6 },
                    { 558, true, "A", 8, null, "A8", 6 },
                    { 559, true, "A", 9, null, "A9", 6 },
                    { 560, true, "A", 10, null, "A10", 6 },
                    { 561, true, "B", 1, null, "B1", 6 },
                    { 562, true, "B", 2, null, "B2", 6 },
                    { 563, true, "B", 3, null, "B3", 6 },
                    { 564, true, "B", 4, null, "B4", 6 },
                    { 565, true, "B", 5, null, "B5", 6 },
                    { 566, true, "B", 6, null, "B6", 6 },
                    { 567, true, "B", 7, null, "B7", 6 },
                    { 568, true, "B", 8, null, "B8", 6 },
                    { 569, true, "B", 9, null, "B9", 6 },
                    { 570, true, "B", 10, null, "B10", 6 },
                    { 571, true, "C", 1, null, "C1", 6 },
                    { 572, true, "C", 2, null, "C2", 6 },
                    { 573, true, "C", 3, null, "C3", 6 },
                    { 574, true, "C", 4, null, "C4", 6 },
                    { 575, true, "C", 5, null, "C5", 6 },
                    { 576, true, "C", 6, null, "C6", 6 },
                    { 577, true, "C", 7, null, "C7", 6 },
                    { 578, true, "C", 8, null, "C8", 6 },
                    { 579, true, "C", 9, null, "C9", 6 },
                    { 580, true, "C", 10, null, "C10", 6 },
                    { 581, true, "D", 1, null, "D1", 6 },
                    { 582, true, "D", 2, null, "D2", 6 },
                    { 583, true, "D", 3, null, "D3", 6 },
                    { 584, true, "D", 4, null, "D4", 6 },
                    { 585, true, "D", 5, null, "D5", 6 },
                    { 586, true, "D", 6, null, "D6", 6 },
                    { 587, true, "D", 7, null, "D7", 6 },
                    { 588, true, "D", 8, null, "D8", 6 },
                    { 589, true, "D", 9, null, "D9", 6 },
                    { 590, true, "D", 10, null, "D10", 6 },
                    { 591, true, "E", 1, null, "E1", 6 },
                    { 592, true, "E", 2, null, "E2", 6 },
                    { 593, true, "E", 3, null, "E3", 6 },
                    { 594, true, "E", 4, null, "E4", 6 },
                    { 595, true, "E", 5, null, "E5", 6 },
                    { 596, true, "E", 6, null, "E6", 6 }
                });

            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "KartaId", "Aktivna", "BrojReda", "BrojSjedista", "KupovinaId", "Sjediste", "TerminId" },
                values: new object[,]
                {
                    { 597, true, "E", 7, null, "E7", 6 },
                    { 598, true, "E", 8, null, "E8", 6 },
                    { 599, true, "E", 9, null, "E9", 6 },
                    { 600, true, "E", 10, null, "E10", 6 },
                    { 601, true, "F", 1, null, "F1", 6 },
                    { 602, true, "F", 2, null, "F2", 6 },
                    { 603, true, "F", 3, null, "F3", 6 },
                    { 604, true, "F", 4, null, "F4", 6 },
                    { 605, true, "F", 5, null, "F5", 6 },
                    { 606, true, "F", 6, null, "F6", 6 },
                    { 607, true, "F", 7, null, "F7", 6 },
                    { 608, true, "F", 8, null, "F8", 6 },
                    { 609, true, "F", 9, null, "F9", 6 },
                    { 610, true, "F", 10, null, "F10", 6 },
                    { 611, true, "G", 1, null, "G1", 6 },
                    { 612, true, "G", 2, null, "G2", 6 },
                    { 613, true, "G", 3, null, "G3", 6 },
                    { 614, true, "G", 4, null, "G4", 6 },
                    { 615, true, "G", 5, null, "G5", 6 },
                    { 616, true, "G", 6, null, "G6", 6 },
                    { 617, true, "G", 7, null, "G7", 6 },
                    { 618, true, "G", 8, null, "G8", 6 },
                    { 619, true, "G", 9, null, "G9", 6 },
                    { 620, true, "G", 10, null, "G10", 6 },
                    { 621, true, "H", 1, null, "H1", 6 },
                    { 622, true, "H", 2, null, "H2", 6 },
                    { 623, true, "H", 3, null, "H3", 6 },
                    { 624, true, "H", 4, null, "H4", 6 },
                    { 625, true, "H", 5, null, "H5", 6 },
                    { 626, true, "H", 6, null, "H6", 6 },
                    { 627, true, "H", 7, null, "H7", 6 },
                    { 628, true, "H", 8, null, "H8", 6 },
                    { 629, true, "H", 9, null, "H9", 6 },
                    { 630, true, "H", 10, null, "H10", 6 },
                    { 631, true, "I", 1, null, "I1", 6 },
                    { 632, true, "I", 2, null, "I2", 6 },
                    { 633, true, "I", 3, null, "I3", 6 },
                    { 634, true, "I", 4, null, "I4", 6 },
                    { 635, true, "I", 5, null, "I5", 6 },
                    { 636, true, "I", 6, null, "I6", 6 },
                    { 637, true, "I", 7, null, "I7", 6 },
                    { 638, true, "I", 8, null, "I8", 6 }
                });

            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "KartaId", "Aktivna", "BrojReda", "BrojSjedista", "KupovinaId", "Sjediste", "TerminId" },
                values: new object[,]
                {
                    { 639, true, "I", 9, null, "I9", 6 },
                    { 640, true, "I", 10, null, "I10", 6 },
                    { 641, true, "J", 1, null, "J1", 6 },
                    { 642, true, "J", 2, null, "J2", 6 },
                    { 643, true, "J", 3, null, "J3", 6 },
                    { 644, true, "J", 4, null, "J4", 6 },
                    { 645, true, "J", 5, null, "J5", 6 },
                    { 646, true, "J", 6, null, "J6", 6 },
                    { 647, true, "J", 7, null, "J7", 6 },
                    { 648, true, "J", 8, null, "J8", 6 },
                    { 649, true, "J", 9, null, "J9", 6 },
                    { 650, true, "J", 10, null, "J10", 6 }
                });

            migrationBuilder.InsertData(
                table: "Kupovina",
                columns: new[] { "KupovinaId", "Cijena", "DatumKupovine", "Kolicina", "KorisnikId", "PaymentIntentId", "Placena", "TerminId" },
                values: new object[,]
                {
                    { 1, 40, new DateTime(2024, 1, 6, 15, 41, 55, 542, DateTimeKind.Local).AddTicks(7278), 2, 2, "pi_3NwMiYEDYm8POibP1HZgAANw_secret_L1f7hpTvlCWjJJXmeJaTwZO06", true, 1 },
                    { 2, 30, new DateTime(2024, 1, 6, 15, 41, 55, 542, DateTimeKind.Local).AddTicks(7288), 3, 2, "pi_3NwMiYEDYm8POibP1HZgAANw_secret_L1f7hpTvlCWjJJXmeJaTwZO06", true, 6 },
                    { 3, 10, new DateTime(2024, 1, 6, 15, 41, 55, 542, DateTimeKind.Local).AddTicks(7290), 1, 2, "pi_3NwMiYEDYm8POibP1HZgAANw_secret_L1f7hpTvlCWjJJXmeJaTwZO06", true, 5 },
                    { 4, 20, new DateTime(2024, 1, 6, 15, 41, 55, 542, DateTimeKind.Local).AddTicks(7293), 2, 2, "pi_3NwMiYEDYm8POibP1HZgAANw_secret_L1f7hpTvlCWjJJXmeJaTwZO06", true, 2 }
                });

            migrationBuilder.InsertData(
                table: "Karta",
                columns: new[] { "KartaId", "Aktivna", "BrojReda", "BrojSjedista", "KupovinaId", "Sjediste", "TerminId" },
                values: new object[,]
                {
                    { 1, false, "A", 1, 1, "A1", 1 },
                    { 2, false, "A", 2, 1, "A2", 1 },
                    { 151, false, "A", 1, 4, "A1", 2 },
                    { 152, false, "A", 2, 4, "A2", 2 },
                    { 453, false, "A", 3, 3, "A3", 5 },
                    { 550, false, "J", 10, 2, "J10", 5 },
                    { 551, false, "A", 1, 2, "A1", 6 },
                    { 552, false, "A", 2, 2, "A2", 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kupovina_TerminId",
                table: "Kupovina",
                column: "TerminId");

            migrationBuilder.CreateIndex(
                name: "IX_Karta_KupovinaId",
                table: "Karta",
                column: "KupovinaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Karta_Kupovina_KupovinaId",
                table: "Karta",
                column: "KupovinaId",
                principalTable: "Kupovina",
                principalColumn: "KupovinaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Kupovina_Termin_TerminId",
                table: "Kupovina",
                column: "TerminId",
                principalTable: "Termin",
                principalColumn: "TerminId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Karta_Kupovina_KupovinaId",
                table: "Karta");

            migrationBuilder.DropForeignKey(
                name: "FK_Kupovina_Termin_TerminId",
                table: "Kupovina");

            migrationBuilder.DropIndex(
                name: "IX_Kupovina_TerminId",
                table: "Kupovina");

            migrationBuilder.DropIndex(
                name: "IX_Karta_KupovinaId",
                table: "Karta");

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Karta",
                keyColumn: "KartaId",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Kupovina",
                keyColumn: "KupovinaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Kupovina",
                keyColumn: "KupovinaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Kupovina",
                keyColumn: "KupovinaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Kupovina",
                keyColumn: "KupovinaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Termin",
                keyColumn: "TerminId",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "VrijemeOdrzavanja",
                table: "Termin");

            migrationBuilder.DropColumn(
                name: "PaymentIntentId",
                table: "Kupovina");

            migrationBuilder.DropColumn(
                name: "Placena",
                table: "Kupovina");

            migrationBuilder.DropColumn(
                name: "TerminId",
                table: "Kupovina");

            migrationBuilder.DropColumn(
                name: "BrojReda",
                table: "Karta");

            migrationBuilder.DropColumn(
                name: "BrojSjedista",
                table: "Karta");

            migrationBuilder.DropColumn(
                name: "KupovinaId",
                table: "Karta");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DatumOdrzavanja",
                table: "Termin",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<int>(
                name: "Kolicina",
                table: "Kupovina",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Cijena",
                table: "Kupovina",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
