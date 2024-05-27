using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ArrangementData.Migrations
{
    /// <inheritdoc />
    public partial class _05282 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "Id", "BedId", "Day", "NursingStation", "OperatOr", "OperatingTime", "PatientId", "SlOt" },
                values: new object[,]
                {
                    { 1, "A", new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5196), "", "morning" },
                    { 2, "A", new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5211), "", "afterning" },
                    { 3, "A", new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5217), "", "morning" },
                    { 4, "A", new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5218), "", "afterning" },
                    { 5, "A", new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5220), "", "morning" },
                    { 6, "A", new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5221), "", "afterning" },
                    { 7, "A", new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5222), "", "morning" },
                    { 8, "A", new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5223), "", "afterning" },
                    { 9, "A", new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5224), "", "morning" },
                    { 10, "A", new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5226), "", "afterning" },
                    { 11, "A", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5227), "", "morning" },
                    { 12, "A", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5228), "", "afterning" },
                    { 13, "A", new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5229), "", "morning" },
                    { 14, "A", new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5229), "", "afterning" },
                    { 15, "A", new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5230), "", "morning" },
                    { 16, "A", new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5231), "", "afterning" },
                    { 17, "A", new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5232), "", "morning" },
                    { 18, "A", new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5234), "", "afterning" },
                    { 19, "A", new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5235), "", "morning" },
                    { 20, "A", new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5236), "", "afterning" },
                    { 21, "B", new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5238), "", "morning" },
                    { 22, "B", new DateTime(2024, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5239), "", "afterning" },
                    { 23, "B", new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5240), "", "morning" },
                    { 24, "B", new DateTime(2024, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5241), "", "afterning" },
                    { 25, "B", new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5242), "", "morning" },
                    { 26, "B", new DateTime(2024, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5243), "", "afterning" },
                    { 27, "B", new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5244), "", "morning" },
                    { 28, "B", new DateTime(2024, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5244), "", "afterning" },
                    { 29, "B", new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5245), "", "morning" },
                    { 30, "B", new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5246), "", "afterning" },
                    { 31, "B", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5247), "", "morning" },
                    { 32, "B", new DateTime(2024, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5248), "", "afterning" },
                    { 33, "B", new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5249), "", "morning" },
                    { 34, "B", new DateTime(2024, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5250), "", "afterning" },
                    { 35, "B", new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5251), "", "morning" },
                    { 36, "B", new DateTime(2024, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5252), "", "afterning" },
                    { 37, "B", new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5253), "", "morning" },
                    { 38, "B", new DateTime(2024, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5254), "", "afterning" },
                    { 39, "B", new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5255), "", "morning" },
                    { 40, "B", new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "", new DateTime(2024, 5, 28, 4, 0, 27, 640, DateTimeKind.Local).AddTicks(5256), "", "afterning" }
                });
        }
    }
}
