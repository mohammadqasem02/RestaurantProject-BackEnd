using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantProject.Migrations
{
    /// <inheritdoc />
    public partial class alter3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RandomId",
                table: "Information",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "FoodId", "FoodImg", "FoodName", "FoodPrice", "FoodTime" },
                values: new object[,]
                {
                    { 1, "https://images.stockcake.com/public/9/7/8/978e9e40-ddf6-499d-836f-4fee5c06a16f_large/hearty-stacked-burger-stockcake.jpg", "Burger", 9.99m, "Morning" },
                    { 2, "https://images.stockcake.com/public/1/4/d/14d7088c-694a-4715-9a6a-560e203799d2_large/wood-fired-pizza-ready-stockcake.jpg", "Pizza", 12.99m, "Evening" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "FoodId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "FoodId",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "RandomId",
                table: "Information",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }
    }
}
