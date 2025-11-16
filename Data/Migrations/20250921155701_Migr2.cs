using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VistavkaApp.Migrations
{
    /// <inheritdoc />
    public partial class Migr2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bilets_Posetitels_PosetitelId",
                table: "Bilets");

            migrationBuilder.DropForeignKey(
                name: "FK_Bilets_Vistavkas_VistavkaId",
                table: "Bilets");

            migrationBuilder.AlterColumn<int>(
                name: "VistavkaId",
                table: "Bilets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PosetitelId",
                table: "Bilets",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Bilets_Posetitels_PosetitelId",
                table: "Bilets",
                column: "PosetitelId",
                principalTable: "Posetitels",
                principalColumn: "PosetitelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bilets_Vistavkas_VistavkaId",
                table: "Bilets",
                column: "VistavkaId",
                principalTable: "Vistavkas",
                principalColumn: "VistavkaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bilets_Posetitels_PosetitelId",
                table: "Bilets");

            migrationBuilder.DropForeignKey(
                name: "FK_Bilets_Vistavkas_VistavkaId",
                table: "Bilets");

            migrationBuilder.AlterColumn<int>(
                name: "VistavkaId",
                table: "Bilets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PosetitelId",
                table: "Bilets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Bilets_Posetitels_PosetitelId",
                table: "Bilets",
                column: "PosetitelId",
                principalTable: "Posetitels",
                principalColumn: "PosetitelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bilets_Vistavkas_VistavkaId",
                table: "Bilets",
                column: "VistavkaId",
                principalTable: "Vistavkas",
                principalColumn: "VistavkaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
