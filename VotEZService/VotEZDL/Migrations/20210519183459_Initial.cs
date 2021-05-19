using Microsoft.EntityFrameworkCore.Migrations;

namespace VotEZDL.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PollVote_PollChoices_PollChoiceID",
                table: "PollVote");

            migrationBuilder.DropForeignKey(
                name: "FK_PollVote_User_UserID",
                table: "PollVote");

            migrationBuilder.DropIndex(
                name: "IX_PollVote_PollChoiceID",
                table: "PollVote");

            migrationBuilder.DropIndex(
                name: "IX_PollVote_UserID",
                table: "PollVote");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "PollVote",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PollChoiceID",
                table: "PollVote",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "PollVote",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PollChoiceID",
                table: "PollVote",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_PollVote_PollChoiceID",
                table: "PollVote",
                column: "PollChoiceID");

            migrationBuilder.CreateIndex(
                name: "IX_PollVote_UserID",
                table: "PollVote",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_PollVote_PollChoices_PollChoiceID",
                table: "PollVote",
                column: "PollChoiceID",
                principalTable: "PollChoices",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PollVote_User_UserID",
                table: "PollVote",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
