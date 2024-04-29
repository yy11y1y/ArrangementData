using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArrangementData.Migrations
{
    /// <inheritdoc />
    public partial class Ninth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Bed_Id",
                table: "Arranges",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Calens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Reservation_Id = table.Column<int>(type: "int", nullable: false),
                    TimeSlot = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsReserved = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calens", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calens");

            migrationBuilder.AlterColumn<int>(
                name: "Bed_Id",
                table: "Arranges",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
