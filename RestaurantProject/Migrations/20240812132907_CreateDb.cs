using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantProject.Migrations
{
    /// <inheritdoc />
    public partial class CreateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FoodTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodImg = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.FoodId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    RandomId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.RandomId);
                });

            migrationBuilder.CreateTable(
                name: "Information",
                columns: table => new
                {
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantStreet = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RestaurantNear = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartHour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EndHour = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RandomId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Information", x => x.RestaurantId);
                    table.ForeignKey(
                        name: "FK_Information_Users_RandomId",
                        column: x => x.RandomId,
                        principalTable: "Users",
                        principalColumn: "RandomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MenuUsers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    RegisterRandomId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuUsers", x => x.id);
                    table.ForeignKey(
                        name: "FK_MenuUsers_Users_RegisterRandomId",
                        column: x => x.RegisterRandomId,
                        principalTable: "Users",
                        principalColumn: "RandomId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Information_RandomId",
                table: "Information",
                column: "RandomId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuUsers_RegisterRandomId",
                table: "MenuUsers",
                column: "RegisterRandomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Information");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "MenuUsers");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
