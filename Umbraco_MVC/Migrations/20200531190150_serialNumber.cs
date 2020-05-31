using Microsoft.EntityFrameworkCore.Migrations;

namespace Umbraco_MVC.Migrations
{
    public partial class serialNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SerialNumber_Submissions_SubmissionId",
                table: "SerialNumber");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SerialNumber",
                table: "SerialNumber");

            migrationBuilder.RenameTable(
                name: "SerialNumber",
                newName: "serialNumbers");

            migrationBuilder.RenameIndex(
                name: "IX_SerialNumber_SubmissionId",
                table: "serialNumbers",
                newName: "IX_serialNumbers_SubmissionId");

            migrationBuilder.AddColumn<int>(
                name: "SerialNumber",
                table: "Submissions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_serialNumbers",
                table: "serialNumbers",
                column: "KeyId");

            migrationBuilder.AddForeignKey(
                name: "FK_serialNumbers_Submissions_SubmissionId",
                table: "serialNumbers",
                column: "SubmissionId",
                principalTable: "Submissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_serialNumbers_Submissions_SubmissionId",
                table: "serialNumbers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_serialNumbers",
                table: "serialNumbers");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "Submissions");

            migrationBuilder.RenameTable(
                name: "serialNumbers",
                newName: "SerialNumber");

            migrationBuilder.RenameIndex(
                name: "IX_serialNumbers_SubmissionId",
                table: "SerialNumber",
                newName: "IX_SerialNumber_SubmissionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SerialNumber",
                table: "SerialNumber",
                column: "KeyId");

            migrationBuilder.AddForeignKey(
                name: "FK_SerialNumber_Submissions_SubmissionId",
                table: "SerialNumber",
                column: "SubmissionId",
                principalTable: "Submissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
