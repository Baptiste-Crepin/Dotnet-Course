using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookEFApp.Dal.Migrations
{
    /// <inheritdoc />
    public partial class dataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Auteurs",
                columns: new[] { "Id", "DateNaissance", "Nom" },
                values: new object[,]
                {
                    { 1, new DateOnly(1980, 12, 31), "Jean-Claude" },
                    { 2, new DateOnly(1990, 12, 31), "Jean-Claude" },
                    { 3, new DateOnly(2000, 12, 31), "Jean-Claude" }
                });

            migrationBuilder.InsertData(
                table: "Livres",
                columns: new[] { "Id", "AuteurId", "Date", "Titre" },
                values: new object[,]
                {
                    { 1, 1, new DateOnly(2020, 12, 31), "Le livre 1" },
                    { 2, 2, new DateOnly(2021, 12, 31), "Le livre 2" },
                    { 3, 3, new DateOnly(2022, 12, 31), "Le livre 3" },
                    { 4, 3, new DateOnly(2023, 12, 31), "Le livre 4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Livres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Livres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Livres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Livres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Auteurs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Auteurs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Auteurs",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
