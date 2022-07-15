using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "ID", "Genre", "Price", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 2, "Romantic Comedy", 7.99m, new DateTime(1989, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "When Harry Met Sally" },
                    { 3, "Comedy", 8.99m, new DateTime(1984, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghostbusters " },
                    { 4, "Comedy", 9.99m, new DateTime(1986, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ghostbusters 2" },
                    { 5, "Western", 3.99m, new DateTime(1959, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rio Bravo" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
