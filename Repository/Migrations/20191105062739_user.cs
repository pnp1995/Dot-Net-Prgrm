using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooRepository.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardType",
                table: "UserDetail",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfilePicUpload",
                table: "UserDetail",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardType",
                table: "UserDetail");

            migrationBuilder.DropColumn(
                name: "ProfilePicUpload",
                table: "UserDetail");
        }
    }
}
