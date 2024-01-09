using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCinema.Services.Migrations
{
    public partial class film : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Film",
                columns: new[] { "FilmId", "Godina", "Naziv", "PocetakPrikazivanja", "Redatelj", "Sadrzaj", "Slika", "VrijemeTrajanje" },
                values: new object[,]
                {
                    { 1, "2023", "Spiderman", new DateTime(2024, 1, 5, 23, 46, 43, 110, DateTimeKind.Local).AddTicks(7337), "Stan Lee", "Peter Parker, a shy and awkward high school student, is often bullied by people, including his best friend. His life changes when he is bitten by a genetically altered spider and gains superpowers.", null, 90 },
                    { 2, "2023", "Ironman", new DateTime(2024, 1, 5, 23, 46, 43, 110, DateTimeKind.Local).AddTicks(7374), "Stan Lee", "When Tony Stark, an industrialist, is captured, he constructs a high-tech armoured suit to escape. Once he manages to escape, he decides to use his suit to fight against evil forces to save the world.", null, 90 },
                    { 3, "2023", "Black widow", new DateTime(2024, 1, 5, 23, 46, 43, 110, DateTimeKind.Local).AddTicks(7376), "Stan Lee", "Natasha Romanoff, a member of the Avengers and a former KGB spy, is forced to confront her dark past when a conspiracy involving her old handler arises.", null, null },
                    { 4, "2023", "Thor", new DateTime(2024, 1, 5, 23, 46, 43, 110, DateTimeKind.Local).AddTicks(7379), "Stan Lee", "Thor is exiled by his father, Odin, the King of Asgard, to the Earth to live among mortals. When he lands on Earth, his trusted weapon Mjolnir is discovered and captured by S.H.I.E.L.D.", null, 90 },
                    { 5, "2023", "Hulk", new DateTime(2024, 1, 5, 23, 46, 43, 110, DateTimeKind.Local).AddTicks(7381), "Stan Lee", "After being exposed to dangerous levels of radiation, a scientist, Bruce Banner, transforms into an angry green monster at the slightest hint of conflict.", null, 90 },
                    { 6, "2023", "Ant-man", new DateTime(2024, 1, 5, 23, 46, 43, 110, DateTimeKind.Local).AddTicks(7384), "Stan Lee", "Scott, a master thief, gains the ability to shrink in scale with the help of a futuristic suit. Now he must rise to the occasion of his superhero status and protect his secret from unsavoury elements.", null, 90 }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Film",
                keyColumn: "FilmId",
                keyValue: 6);

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
    }
}
