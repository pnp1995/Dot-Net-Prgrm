using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooRepository.Migrations
{
    public partial class Label : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotesDetail_UserDetail_userModelEmailid",
                table: "NotesDetail");

            migrationBuilder.DropIndex(
                name: "IX_NotesDetail_userModelEmailid",
                table: "NotesDetail");

            migrationBuilder.DropColumn(
                name: "userModelEmailid",
                table: "NotesDetail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "userModelEmailid",
                table: "NotesDetail",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_NotesDetail_userModelEmailid",
                table: "NotesDetail",
                column: "userModelEmailid");

            migrationBuilder.AddForeignKey(
                name: "FK_NotesDetail_UserDetail_userModelEmailid",
                table: "NotesDetail",
                column: "userModelEmailid",
                principalTable: "UserDetail",
                principalColumn: "Emailid",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
