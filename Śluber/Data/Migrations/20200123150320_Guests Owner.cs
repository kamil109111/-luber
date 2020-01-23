using Microsoft.EntityFrameworkCore.Migrations;

namespace Śluber.Data.Migrations
{
    public partial class GuestsOwner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Guest",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Guest_OwnerId",
                table: "Guest",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Guest_AspNetUsers_OwnerId",
                table: "Guest",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guest_AspNetUsers_OwnerId",
                table: "Guest");

            migrationBuilder.DropIndex(
                name: "IX_Guest_OwnerId",
                table: "Guest");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Guest");
        }
    }
}
