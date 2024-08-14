using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantProject.Migrations
{
    /// <inheritdoc />
    public partial class alter1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Information_Users_RandomId",
                table: "Information");

            migrationBuilder.DropForeignKey(
                name: "FK_MenuUsers_Users_RegisterRandomId",
                table: "MenuUsers");

            migrationBuilder.DropIndex(
                name: "IX_MenuUsers_RegisterRandomId",
                table: "MenuUsers");

            migrationBuilder.DropColumn(
                name: "RegisterRandomId",
                table: "MenuUsers");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "MenuUsers",
                newName: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "IX_MenuUsers_FoodId",
                table: "MenuUsers");

            migrationBuilder.DropIndex(
                name: "IX_MenuUsers_RandomId",
                table: "MenuUsers");

            migrationBuilder.DropColumn(
                name: "RandomId",
                table: "MenuUsers");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "MenuUsers",
                newName: "id");

            migrationBuilder.AddColumn<string>(
                name: "RegisterRandomId",
                table: "MenuUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MenuUsers_RegisterRandomId",
                table: "MenuUsers",
                column: "RegisterRandomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Information_Users_RandomId",
                table: "Information",
                column: "RandomId",
                principalTable: "Users",
                principalColumn: "RandomId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MenuUsers_Users_RegisterRandomId",
                table: "MenuUsers",
                column: "RegisterRandomId",
                principalTable: "Users",
                principalColumn: "RandomId");
        }
    }
}
