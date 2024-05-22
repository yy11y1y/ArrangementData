using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArrangementData.Migrations
{
    /// <inheritdoc />
    public partial class _05202 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "BedId", "Day", "NursingStation", "OperatOr", "OperatingTime", "PatientId", "SlOt" },
                values: new object[,]
                {
                    { 1, "A", new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "上午" },
                    { 2, "A", new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "下午" },
                    { 3, "A", new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "上午" },
                    { 4, "A", new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "下午" },
                    { 5, "A", new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "上午" },
                    { 6, "A", new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "下午" },
                    { 7, "A", new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "上午" },
                    { 8, "A", new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "下午" },
                    { 9, "A", new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "上午" },
                    { 10, "A", new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "下午" },
                    { 11, "A", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "上午" },
                    { 12, "A", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "下午" },
                    { 13, "A", new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "上午" },
                    { 14, "A", new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "下午" },
                    { 15, "A", new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "上午" },
                    { 16, "A", new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "下午" },
                    { 17, "A", new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "上午" },
                    { 18, "A", new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "下午" },
                    { 19, "A", new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "上午" },
                    { 20, "A", new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "下午" },
                    { 21, "B", new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "上午" },
                    { 22, "B", new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "下午" },
                    { 23, "B", new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "上午" },
                    { 24, "B", new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "下午" },
                    { 25, "B", new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "上午" },
                    { 26, "B", new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "下午" },
                    { 27, "B", new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "上午" },
                    { 28, "B", new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "下午" },
                    { 29, "B", new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "上午" },
                    { 30, "B", new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "下午" },
                    { 31, "B", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "上午" },
                    { 32, "B", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "下午" },
                    { 33, "B", new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "上午" },
                    { 34, "B", new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "下午" },
                    { 35, "B", new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "上午" },
                    { 36, "B", new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "下午" },
                    { 37, "B", new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "上午" },
                    { 38, "B", new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "下午" },
                    { 39, "B", new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "上午" },
                    { 40, "B", new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "下午" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "Id",
                keyValue: 40);
        }
    }
}
