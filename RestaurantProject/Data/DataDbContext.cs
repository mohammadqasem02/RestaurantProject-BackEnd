using Microsoft.EntityFrameworkCore;
using RestaurantProject.Models;

namespace RestaurantProject.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext (DbContextOptions<DataDbContext> options)
            : base(options)
        {
        }

        public DbSet<Register> Users
        {
            get; set;
        }
        public DbSet<Information> Information
        {
            get; set;
        }
        public DbSet<Menu> Menus
        {
            get; set;
        }
        public DbSet<MenuUser> MenuUsers
        {
            get; set;
        }
        public DbSet<Maintenance> Maintenances
        {
            get; set;
        }
        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);


            // Seed data for Menu
            modelBuilder.Entity<Menu>().HasData(
                new Menu
                {

                    FoodId = 1,
                    FoodName = "Burger",
                    FoodPrice = 9.99m,
                    FoodTime = "Morning",
                    FoodImg = "https://images.stockcake.com/public/9/7/8/978e9e40-ddf6-499d-836f-4fee5c06a16f_large/hearty-stacked-burger-stockcake.jpg",
                },
                new Menu
                {
                    FoodId = 2,
                    FoodName = "Pizza",
                    FoodPrice = 12.99m,
                    FoodTime = "Evening",
                    FoodImg = "https://images.stockcake.com/public/1/4/d/14d7088c-694a-4715-9a6a-560e203799d2_large/wood-fired-pizza-ready-stockcake.jpg",
                },
                 new Menu
                 {
                     FoodId = 3,
                     FoodName = "Bur2",
                     FoodPrice = 13.99m,
                     FoodTime = "Evening",
                     FoodImg = "https://images.stockcake.com/public/1/4/d/14d7088c-694a-4715-9a6a-560e203799d2_large/wood-fired-pizza-ready-stockcake.jpg",
                 }
            );
        }
    }
}
