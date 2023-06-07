using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_agile_concrete_DAL.Migrations
{
    public partial class PropertynamesCapitalized : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ecoCheques",
                table: "Producten");

            migrationBuilder.RenameColumn(
                name: "prijs",
                table: "Producten",
                newName: "Prijs");

            migrationBuilder.AddColumn<bool>(
                name: "EcoCheque",
                table: "Producten",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EcoCheque",
                table: "Producten");

            migrationBuilder.RenameColumn(
                name: "Prijs",
                table: "Producten",
                newName: "prijs");

            migrationBuilder.AddColumn<bool>(
                name: "ecoCheques",
                table: "Producten",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
