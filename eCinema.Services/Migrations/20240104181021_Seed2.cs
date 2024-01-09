using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eCinema.Services.Migrations
{
    public partial class Seed2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImePrezime",
                table: "Glumac",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Glumac",
                columns: new[] { "GlumacId", "Ime", "ImePrezime", "Prezime" },
                values: new object[,]
                {
                    { 1, "Angelina", "Angelina Jolie", "Jolie" },
                    { 2, "Brad", "Brad Pitt", "Pitt" },
                    { 3, "Jennifer", "Jennifer Lopez", "Lopez" },
                    { 4, "George", "George Clooney", "Clooney" }
                });

            migrationBuilder.InsertData(
                table: "ObavijestKategorija",
                columns: new[] { "ObavijestKategorijaId", "Naziv" },
                values: new object[,]
                {
                    { 1, "Novosti" },
                    { 2, "Vijesti" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Glumac",
                keyColumn: "GlumacId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Glumac",
                keyColumn: "GlumacId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Glumac",
                keyColumn: "GlumacId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Glumac",
                keyColumn: "GlumacId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ObavijestKategorija",
                keyColumn: "ObavijestKategorijaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ObavijestKategorija",
                keyColumn: "ObavijestKategorijaId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "ImePrezime",
                table: "Glumac");
        }
    }
}
