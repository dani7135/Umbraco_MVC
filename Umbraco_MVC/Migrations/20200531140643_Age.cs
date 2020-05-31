using Microsoft.EntityFrameworkCore.Migrations;

namespace Umbraco_MVC.Migrations
{
    public partial class Age : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "Submissions");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Submissions",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "SerialNumber",
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
                    table.PrimaryKey("PK_SerialNumber", x => x.KeyId);
                    table.ForeignKey(
                        name: "FK_SerialNumber_Submissions_SubmissionId",
                        column: x => x.SubmissionId,
                        principalTable: "Submissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SerialNumber_SubmissionId",
                table: "SerialNumber",
                column: "SubmissionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SerialNumber");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Submissions");

            migrationBuilder.AddColumn<int>(
                name: "SerialNumber",
                table: "Submissions",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
