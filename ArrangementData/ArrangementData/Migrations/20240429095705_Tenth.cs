using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArrangementData.Migrations
{
    /// <inheritdoc />
    public partial class Tenth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Reservation_Id",
                table: "Calens",
                newName: "Bed");

            migrationBuilder.AlterColumn<int>(
                name: "TimeSlot",
                table: "Calens",
                type: "int",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "Day",
                table: "Calens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Day",
                table: "Calens");

            migrationBuilder.RenameColumn(
                name: "Bed",
                table: "Calens",
                newName: "Reservation_Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TimeSlot",
                table: "Calens",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
