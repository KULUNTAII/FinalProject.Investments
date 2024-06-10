using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewParticipant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QualificationTypes_Participants_ParticipantId",
                table: "QualificationTypes");

            migrationBuilder.DropIndex(
                name: "IX_QualificationTypes_ParticipantId",
                table: "QualificationTypes");

            migrationBuilder.DropColumn(
                name: "ParticipantId",
                table: "QualificationTypes");

            migrationBuilder.AlterColumn<string>(
                name: "Skills",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Qualification",
                table: "Participants",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Qualification",
                table: "Participants");

            migrationBuilder.AddColumn<int>(
                name: "ParticipantId",
                table: "QualificationTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Skills",
                table: "Participants",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Participants",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_QualificationTypes_ParticipantId",
                table: "QualificationTypes",
                column: "ParticipantId");

            migrationBuilder.AddForeignKey(
                name: "FK_QualificationTypes_Participants_ParticipantId",
                table: "QualificationTypes",
                column: "ParticipantId",
                principalTable: "Participants",
                principalColumn: "Id");
        }
    }
}
