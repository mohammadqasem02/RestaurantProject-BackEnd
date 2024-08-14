using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantProject.Migrations
{
    /// <inheritdoc />
    public partial class altermenuuser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoodTime",
                table: "MenuUsers");

            migrationBuilder.AddColumn<bool>(
                name: "Evning",
                table: "MenuUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Morning",
                table: "MenuUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Noon",
                table: "MenuUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Evning",
                table: "MenuUsers");

            migrationBuilder.DropColumn(
                name: "Morning",
                table: "MenuUsers");

            migrationBuilder.DropColumn(
                name: "Noon",
                table: "MenuUsers");

            migrationBuilder.AddColumn<string>(
                name: "FoodTime",
                table: "MenuUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
