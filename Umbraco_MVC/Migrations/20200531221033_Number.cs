using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Umbraco_MVC.Migrations
{
    public partial class Number : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Age",
                table: "Submissions",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "serialNumbers",
                columns: table => new
                {
                    KeyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyCode = table.Column<string>(nullable: true),
                    NumberOfUses = table.Column<int>(nullable: false),
                    Validity = table.Column<bool>(nullable: false),
                    SubmissionId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serialNumbers", x => x.KeyId);
                    table.ForeignKey(
                        name: "FK_serialNumbers_Submissions_SubmissionId",
                        column: x => x.SubmissionId,
                        principalTable: "Submissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_serialNumbers_SubmissionId",
                table: "serialNumbers",
                column: "SubmissionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "serialNumbers");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Submissions");
        }
    }
}
