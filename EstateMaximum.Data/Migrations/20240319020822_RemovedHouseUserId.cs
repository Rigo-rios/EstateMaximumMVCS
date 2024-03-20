using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstateMaximum.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovedHouseUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_House_AspNetUsers_UserId",
                table: "House");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "House",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_House_AspNetUsers_UserId",
                table: "House",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_House_AspNetUsers_UserId",
                table: "House");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "House",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_House_AspNetUsers_UserId",
                table: "House",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
