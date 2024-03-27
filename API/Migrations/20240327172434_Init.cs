using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Timestamp = table.Column<int>(type: "INTEGER", nullable: false),
                    Base = table.Column<string>(type: "TEXT", nullable: false),
                    CHF = table.Column<double>(type: "REAL", nullable: false),
                    EUR = table.Column<double>(type: "REAL", nullable: false),
                    GBP = table.Column<double>(type: "REAL", nullable: false),
                    JPY = table.Column<double>(type: "REAL", nullable: false),
                    PLN = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Base", "CHF", "Date", "EUR", "GBP", "JPY", "PLN", "Timestamp" },
                values: new object[,]
                {
                    { 1, "USD", 4.3231999999999999, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Local), 3.3300000000000001, 2.2200000000000002, 3.4220000000000002, 5.3300000000000001, 1238383463 },
                    { 2, "USD", 3.4420000000000002, new DateTime(2024, 3, 26, 0, 0, 0, 0, DateTimeKind.Local), 2.3300000000000001, 5.2199999999999998, 6.4219999999999997, 7.3300000000000001, 1134438463 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Currencies");
        }
    }
}
