using Microsoft.EntityFrameworkCore.Migrations;

namespace MersTrenuri.Migrations
{
    public partial class migrareAddDistantaPretComenzi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Distanta",
                table: "Comenzi",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Pret",
                table: "Comenzi",
                maxLength: 30,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Distanta",
                table: "Comenzi");

            migrationBuilder.DropColumn(
                name: "Pret",
                table: "Comenzi");
        }
    }
}
