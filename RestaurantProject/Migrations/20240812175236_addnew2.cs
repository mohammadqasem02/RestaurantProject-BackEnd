using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantProject.Migrations
{
    /// <inheritdoc />
    public partial class addnew2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FoodPrice",
                table: "MenuUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoodPrice",
                table: "MenuUsers");
        }
    }
}
