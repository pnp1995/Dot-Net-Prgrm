using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooRepository.Migrations
{
    public partial class labal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NotesDetail",
                table: "NotesDetail");

            migrationBuilder.RenameTable(
                name: "NotesDetail",
                newName: "NotesModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotesModel",
                table: "NotesModel",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_NotesModel",
                table: "NotesModel");

            migrationBuilder.RenameTable(
                name: "NotesModel",
                newName: "NotesDetail");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotesDetail",
                table: "NotesDetail",
                column: "Id");
        }
    }
}
