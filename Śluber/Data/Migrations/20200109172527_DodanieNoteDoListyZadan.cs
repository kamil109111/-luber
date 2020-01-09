using Microsoft.EntityFrameworkCore.Migrations;

namespace Śluber.Data.Migrations
{
    public partial class DodanieNoteDoListyZadan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "Errand",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Note",
                table: "Errand");
        }
    }
}
