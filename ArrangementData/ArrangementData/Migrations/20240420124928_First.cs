using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArrangementData.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arranges",
                columns: table => new
                {
                    Bed_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patient_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nursing_station = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Schedule = table.Column<bool>(type: "bit", nullable: false),
                    Operator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Operating_time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arranges", x => x.Bed_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arranges");
        }
    }
}
