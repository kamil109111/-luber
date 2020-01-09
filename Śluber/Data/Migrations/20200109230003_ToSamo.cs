using Microsoft.EntityFrameworkCore.Migrations;

namespace Śluber.Data.Migrations
{
    public partial class ToSamo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "ErrandPrice",
                table: "Errand",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "ErrandPrice",
                table: "Errand",
                type: "real",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");
        }
    }
}
