
using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Śluber.Data.Migrations
{
    public partial class owner : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedById",
                table: "Wedding",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Createdbb",
                table: "Wedding",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Modified",
                table: "Wedding",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ModifiedById",
                table: "Wedding",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Wedding",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Wedding_CreatedById",
                table: "Wedding",
                column: "CreatedById");

            migrationBuilder.CreateIndex(
                name: "IX_Wedding_ModifiedById",
                table: "Wedding",
                column: "ModifiedById");

            migrationBuilder.CreateIndex(
                name: "IX_Wedding_OwnerId",
                table: "Wedding",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Wedding_AspNetUsers_CreatedById",
                table: "Wedding",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wedding_AspNetUsers_ModifiedById",
                table: "Wedding",
                column: "ModifiedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wedding_AspNetUsers_OwnerId",
                table: "Wedding",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Wedding_AspNetUsers_CreatedById",
                table: "Wedding");

            migrationBuilder.DropForeignKey(
                name: "FK_Wedding_AspNetUsers_ModifiedById",
                table: "Wedding");

            migrationBuilder.DropForeignKey(
                name: "FK_Wedding_AspNetUsers_OwnerId",
                table: "Wedding");

            migrationBuilder.DropIndex(
                name: "IX_Wedding_CreatedById",
                table: "Wedding");

            migrationBuilder.DropIndex(
                name: "IX_Wedding_ModifiedById",
                table: "Wedding");

            migrationBuilder.DropIndex(
                name: "IX_Wedding_OwnerId",
                table: "Wedding");

            migrationBuilder.DropColumn(
                name: "CreatedById",
                table: "Wedding");

            migrationBuilder.DropColumn(
                name: "Createdbb",
                table: "Wedding");

            migrationBuilder.DropColumn(
                name: "Modified",
                table: "Wedding");

            migrationBuilder.DropColumn(
                name: "ModifiedById",
                table: "Wedding");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Wedding");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");
        }
    }
}
