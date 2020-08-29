using Microsoft.EntityFrameworkCore.Migrations;

namespace MersTrenuri.Migrations
{
    public partial class AddEmailToComanda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Comenzi",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Comenzi");
        }
    }
}
