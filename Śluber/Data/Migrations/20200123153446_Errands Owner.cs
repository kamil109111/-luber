using Microsoft.EntityFrameworkCore.Migrations;

namespace Śluber.Data.Migrations
{
    public partial class ErrandsOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Errand",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Errand");
        }
    }
}
