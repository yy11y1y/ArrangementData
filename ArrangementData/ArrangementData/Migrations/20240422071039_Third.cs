using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArrangementData.Migrations
{
    /// <inheritdoc />
    public partial class Third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Arranges",
                table: "Arranges");

            migrationBuilder.DropColumn(
               name: "Bed_Id",
               table: "Arranges");

            migrationBuilder.DropColumn(
                name: "Schedule",
                table: "Arranges");

            migrationBuilder.RenameColumn(
                name: "DateTime",
                table: "Arranges",
                newName: "Date");

            migrationBuilder.AlterColumn<string>(
                name: "Patient_Id",
                table: "Arranges",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Operator",
                table: "Arranges",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Arranges",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Bed_Id",
                table: "Arranges",
                type: "int",
                nullable: false);

            migrationBuilder.AddColumn<int>(
                name: "Slot",
                table: "Arranges",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Arranges",
                table: "Arranges",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Arranges",
                table: "Arranges");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Arranges");

            migrationBuilder.DropColumn(
                name: "Slot",
                table: "Arranges");

            migrationBuilder.DropColumn(
                    name: "Bed_Id",
                    table: "Arranges");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Arranges",
                newName: "DateTime");

            migrationBuilder.AlterColumn<string>(
                name: "Patient_Id",
                table: "Arranges",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Operator",
                table: "Arranges",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);


            migrationBuilder.AddColumn<bool>(
                name: "Schedule",
                table: "Arranges",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Bed_Id",
                table: "Arranges",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Arranges",
                table: "Arranges",
                column: "Bed_Id");
        }
    }
}
