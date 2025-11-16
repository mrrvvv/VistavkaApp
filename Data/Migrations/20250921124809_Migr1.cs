using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VistavkaApp.Migrations
{
    /// <inheritdoc />
    public partial class Migr1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posetitels",
                columns: table => new
                {
                    PosetitelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PosetitelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PosetitelSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Phone = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posetitels", x => x.PosetitelId);
                });

            migrationBuilder.CreateTable(
                name: "Vistavkas",
                columns: table => new
                {
                    VistavkaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VistavkaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateStart = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vistavkas", x => x.VistavkaId);
                });

            migrationBuilder.CreateTable(
                name: "Bilets",
                columns: table => new
                {
                    BiletId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PosetitelId = table.Column<int>(type: "int", nullable: false),
                    VistavkaId = table.Column<int>(type: "int", nullable: false),
                    DateVisit = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bilets", x => x.BiletId);
                    table.ForeignKey(
                        name: "FK_Bilets_Posetitels_PosetitelId",
                        column: x => x.PosetitelId,
                        principalTable: "Posetitels",
                        principalColumn: "PosetitelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bilets_Vistavkas_VistavkaId",
                        column: x => x.VistavkaId,
                        principalTable: "Vistavkas",
                        principalColumn: "VistavkaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bilets_PosetitelId",
                table: "Bilets",
                column: "PosetitelId");

            migrationBuilder.CreateIndex(
                name: "IX_Bilets_VistavkaId",
                table: "Bilets",
                column: "VistavkaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bilets");

            migrationBuilder.DropTable(
                name: "Posetitels");

            migrationBuilder.DropTable(
                name: "Vistavkas");
        }
    }
}
