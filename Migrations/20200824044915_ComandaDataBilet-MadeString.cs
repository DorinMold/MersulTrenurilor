using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MersTrenuri.Migrations
{
    public partial class ComandaDataBiletMadeString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DataBilet",
                table: "Comenzi",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataBilet",
                table: "Comenzi",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
