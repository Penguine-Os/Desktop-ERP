using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_agile_concrete_DAL.Migrations
{
    public partial class AddDiensten : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductFactuur_Producten_ProductId",
                table: "ProductFactuur");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductFactuur",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DienstId",
                table: "ProductFactuur",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Prijs",
                table: "Producten",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.CreateTable(
                name: "Diensten",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(nullable: false),
                    CategorieId = table.Column<int>(nullable: false),
                    Prijs = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diensten", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Diensten_Categories_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductFactuur_DienstId",
                table: "ProductFactuur",
                column: "DienstId");

            migrationBuilder.CreateIndex(
                name: "IX_Diensten_CategorieId",
                table: "Diensten",
                column: "CategorieId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFactuur_Diensten_DienstId",
                table: "ProductFactuur",
                column: "DienstId",
                principalTable: "Diensten",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFactuur_Producten_ProductId",
                table: "ProductFactuur",
                column: "ProductId",
                principalTable: "Producten",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductFactuur_Diensten_DienstId",
                table: "ProductFactuur");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductFactuur_Producten_ProductId",
                table: "ProductFactuur");

            migrationBuilder.DropTable(
                name: "Diensten");

            migrationBuilder.DropIndex(
                name: "IX_ProductFactuur_DienstId",
                table: "ProductFactuur");

            migrationBuilder.DropColumn(
                name: "DienstId",
                table: "ProductFactuur");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "ProductFactuur",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Prijs",
                table: "Producten",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AddForeignKey(
                name: "FK_ProductFactuur_Producten_ProductId",
                table: "ProductFactuur",
                column: "ProductId",
                principalTable: "Producten",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
