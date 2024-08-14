using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantProject.Migrations
{
    /// <inheritdoc />
    public partial class alter10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Information_Users_RandomId",
                table: "Information");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuUsers_Menus_FoodId",
                table: "MenuUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuUsers_Users_RandomId",
                table: "MenuUsers");

            migrationBuilder.DropIndex(
                name: "IX_Information_RandomId",
                table: "Information");

            migrationBuilder.DropColumn(
                name: "RandomId",
                table: "Information");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MenuUsers_Menus_FoodId",
                table: "MenuUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuUsers_Users_RandomId",
                table: "MenuUsers");

            migrationBuilder.AddColumn<string>(
                name: "RandomId",
                table: "Information",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Information_RandomId",
                table: "Information",
                column: "RandomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Information_Users_RandomId",
                table: "Information",
                column: "RandomId",
                principalTable: "Users",
                principalColumn: "RandomId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuUsers_Menus_FoodId",
                table: "MenuUsers",
                column: "FoodId",
                principalTable: "Menus",
                principalColumn: "FoodId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuUsers_Users_RandomId",
                table: "MenuUsers",
                column: "RandomId",
                principalTable: "Users",
                principalColumn: "RandomId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
