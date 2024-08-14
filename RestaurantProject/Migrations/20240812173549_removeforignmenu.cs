using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantProject.Migrations
{
    /// <inheritdoc />
    public partial class removeforignmenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuUsers_Menus_FoodId",
                table: "MenuUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuUsers_Users_RandomId",
                table: "MenuUsers");

            migrationBuilder.DropIndex(
                name: "IX_MenuUsers_FoodId",
                table: "MenuUsers");

            migrationBuilder.DropIndex(
                name: "IX_MenuUsers_RandomId",
                table: "MenuUsers");

            migrationBuilder.DropColumn(
                name: "RandomId",
                table: "MenuUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RandomId",
                table: "MenuUsers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_MenuUsers_FoodId",
                table: "MenuUsers",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuUsers_RandomId",
                table: "MenuUsers",
                column: "RandomId");

            migrationBuilder.AddForeignKey(
                name: "FK_MenuUsers_Menus_FoodId",
                table: "MenuUsers",
                column: "FoodId",
                principalTable: "Menus",
                principalColumn: "FoodId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuUsers_Users_RandomId",
                table: "MenuUsers",
                column: "RandomId",
                principalTable: "Users",
                principalColumn: "RandomId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
