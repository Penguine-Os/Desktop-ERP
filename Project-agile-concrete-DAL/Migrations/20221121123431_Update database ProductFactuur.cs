using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_agile_concrete_DAL.Migrations
{
    public partial class UpdatedatabaseProductFactuur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KlantFactuur");

            migrationBuilder.AddColumn<int>(
                name: "KlantId",
                table: "Facturen",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ProductFactuur",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FactuurId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Hoeveelheid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFactuur", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFactuur_Facturen_FactuurId",
                        column: x => x.FactuurId,
                        principalTable: "Facturen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductFactuur_Producten_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Producten",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Facturen_KlantId",
                table: "Facturen",
                column: "KlantId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFactuur_FactuurId",
                table: "ProductFactuur",
                column: "FactuurId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductFactuur_ProductId",
                table: "ProductFactuur",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Facturen_Klanten_KlantId",
                table: "Facturen",
                column: "KlantId",
                principalTable: "Klanten",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Facturen_Klanten_KlantId",
                table: "Facturen");

            migrationBuilder.DropTable(
                name: "ProductFactuur");

            migrationBuilder.DropIndex(
                name: "IX_Facturen_KlantId",
                table: "Facturen");

            migrationBuilder.DropColumn(
                name: "KlantId",
                table: "Facturen");

            migrationBuilder.CreateTable(
                name: "KlantFactuur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FactuurId = table.Column<int>(type: "int", nullable: false),
                    Hoeveelheid = table.Column<int>(type: "int", nullable: false),
                    KlantId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KlantFactuur", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KlantFactuur_Facturen_FactuurId",
                        column: x => x.FactuurId,
                        principalTable: "Facturen",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KlantFactuur_Klanten_KlantId",
                        column: x => x.KlantId,
                        principalTable: "Klanten",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KlantFactuur_Producten_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Producten",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KlantFactuur_FactuurId",
                table: "KlantFactuur",
                column: "FactuurId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KlantFactuur_KlantId",
                table: "KlantFactuur",
                column: "KlantId");

            migrationBuilder.CreateIndex(
                name: "IX_KlantFactuur_ProductId",
                table: "KlantFactuur",
                column: "ProductId");
        }
    }
}
