using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantProject.Migrations
{
    /// <inheritdoc />
    public partial class addnew : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "FoodId", "FoodImg", "FoodName", "FoodPrice", "FoodTime" },
                values: new object[] { 3, "https://images.stockcake.com/public/1/4/d/14d7088c-694a-4715-9a6a-560e203799d2_large/wood-fired-pizza-ready-stockcake.jpg", "Bur2", 13.99m, "Evening" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "FoodId",
                keyValue: 3);
        }
    }
}
