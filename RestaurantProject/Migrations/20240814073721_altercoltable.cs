using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantProject.Migrations
{
    /// <inheritdoc />
    public partial class altercoltable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "userId",
                table: "MenuUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "userId",
                table: "MenuUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
