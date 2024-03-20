﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstateMaximum.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedFKToAppt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartment_AspNetUsers_UserId",
                table: "Apartment");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Apartment",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Apartment_AspNetUsers_UserId",
                table: "Apartment",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartment_AspNetUsers_UserId",
                table: "Apartment");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Apartment",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartment_AspNetUsers_UserId",
                table: "Apartment",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
