using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooRepository.Migrations
{
    public partial class level : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "LabelDetail",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LabelDetail", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LabelDetail");

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
    }
}
