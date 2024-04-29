using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArrangementData.Migrations
{
    /// <inheritdoc />
    public partial class Eleventh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TimeSlot",
                table: "Calens");

            migrationBuilder.AddColumn<int>(
                name: "ArrangeId",
                table: "Calens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Slott",
                table: "Calens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Calens_ArrangeId",
                table: "Calens",
                column: "ArrangeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Calens_Arranges_ArrangeId",
                table: "Calens",
                column: "ArrangeId",
                principalTable: "Arranges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Calens_Arranges_ArrangeId",
                table: "Calens");

            migrationBuilder.DropIndex(
                name: "IX_Calens_ArrangeId",
                table: "Calens");

            migrationBuilder.DropColumn(
                name: "ArrangeId",
                table: "Calens");

            migrationBuilder.DropColumn(
                name: "Slott",
                table: "Calens");

            migrationBuilder.AddColumn<int>(
                name: "TimeSlot",
                table: "Calens",
                type: "int",
                nullable: true);
        }
    }
}
