using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooRepository.Migrations
{
    public partial class notes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotesDetail",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Descriiption = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Reminder = table.Column<string>(nullable: true),
                    Colour = table.Column<string>(nullable: true),
                    Archive = table.Column<bool>(nullable: false),
                    Trash = table.Column<bool>(nullable: false),
                    Pin = table.Column<bool>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotesDetail", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotesDetail");
        }
    }
}
