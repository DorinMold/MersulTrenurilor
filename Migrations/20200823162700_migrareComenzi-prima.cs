using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MersTrenuri.Migrations
{
    public partial class migrareComenziprima : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comenzi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataBilet = table.Column<DateTime>(nullable: false),
                    statiePlecare = table.Column<string>(maxLength: 30, nullable: false),
                    statieSosire = table.Column<string>(maxLength: 30, nullable: false),
                    numePersoana = table.Column<string>(maxLength: 30, nullable: false),
                    prenumePersoana = table.Column<string>(maxLength: 30, nullable: false),
                    numarTelefon = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comenzi", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comenzi");
        }
    }
}
