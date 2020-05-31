using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Umbraco_MVC.Migrations
{
    public partial class serialNumber2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Age",
                table: "Submissions",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Age",
                table: "Submissions",
                type: "int",
                nullable: false,
                oldClrType: typeof(DateTime));
        }
    }
}
