﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantProject.Data;

#nullable disable

namespace RestaurantProject.Migrations
{
    [DbContext(typeof(DataDbContext))]
    [Migration("20240812173549_removeforignmenu")]
    partial class removeforignmenu
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestaurantProject.Models.Information", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RestaurantId"));

                    b.Property<string>("EndHour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantNear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantStreet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartHour")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RestaurantId");

                    b.ToTable("Information");
                });

            modelBuilder.Entity("RestaurantProject.Models.Menu", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FoodId"));

                    b.Property<string>("FoodImg")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FoodName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("FoodPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("FoodTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FoodId");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            FoodId = 1,
                            FoodImg = "https://images.stockcake.com/public/9/7/8/978e9e40-ddf6-499d-836f-4fee5c06a16f_large/hearty-stacked-burger-stockcake.jpg",
                            FoodName = "Burger",
                            FoodPrice = 9.99m,
                            FoodTime = "Morning"
                        },
                        new
                        {
                            FoodId = 2,
                            FoodImg = "https://images.stockcake.com/public/1/4/d/14d7088c-694a-4715-9a6a-560e203799d2_large/wood-fired-pizza-ready-stockcake.jpg",
                            FoodName = "Pizza",
                            FoodPrice = 12.99m,
                            FoodTime = "Evening"
                        });
                });

            modelBuilder.Entity("RestaurantProject.Models.MenuUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FoodId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("MenuUsers");
                });

            modelBuilder.Entity("RestaurantProject.Models.Register", b =>
                {
                    b.Property<string>("RandomId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RandomId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
