using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EstateMaximum.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedSetToBathroom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Bathrooms",
                table: "House",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bathrooms",
                table: "House");
        }
    }
}
