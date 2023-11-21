﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyRestaurantApi.Data;

#nullable disable

namespace MyRestaurantApi.Migrations
{
    [DbContext(typeof(MyRestaurantApiContext))]
    [Migration("20230419183141_sqlite_migration_891")]
    partial class sqlite_migration_891
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("MyRestaurantApi.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Contact");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "sayed@example.com",
                            Name = "Sayed Hashimi",
                            Phone = "555-111-2222"
                        },
                        new
                        {
                            Id = 2,
                            Email = "mads@example.com",
                            Name = "Mads Kristensen",
                            Phone = "555-111-3333"
                        },
                        new
                        {
                            Id = 3,
                            Email = "elineb@example.com",
                            Name = "Eline Barstad",
                            Phone = "555-111-4444"
                        },
                        new
                        {
                            Id = 4,
                            Email = "theol@example.com",
                            Name = "Theodore Lamy",
                            Phone = "555-111-5555"
                        },
                        new
                        {
                            Id = 5,
                            Email = "mariaz@example.com",
                            Name = "María Zelaya",
                            Phone = "555-111-6666"
                        },
                        new
                        {
                            Id = 6,
                            Email = "kubans@example.com",
                            Name = "Kubanychbek Sagynbek",
                            Phone = "555-111-7777"
                        },
                        new
                        {
                            Id = 7,
                            Email = "deniseb@example.com",
                            Name = "Denise Bourgeois",
                            Phone = "555-111-8888"
                        },
                        new
                        {
                            Id = 8,
                            Email = "robind@example.com",
                            Name = "Robin Danielsen",
                            Phone = "555-111-9999"
                        });
                });

            modelBuilder.Entity("MyRestaurantApi.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Category")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MenuItem");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = 1,
                            Description = "It's a cheese burger without the cheese",
                            Name = "Hamburger",
                            Price = 3.68m
                        },
                        new
                        {
                            Id = 2,
                            Category = 1,
                            Description = "It's a cheese burger without the cheese, with two beef patties",
                            Name = "Hamburger - double",
                            Price = 5.7m
                        },
                        new
                        {
                            Id = 3,
                            Category = 1,
                            Description = "A hamburger with cheese",
                            Name = "Cheeseburger",
                            Price = 4.09m
                        },
                        new
                        {
                            Id = 4,
                            Category = 1,
                            Description = "A hamburger with cheese, with two beef patties",
                            Name = "Cheeseburger - double",
                            Price = 5.09m
                        },
                        new
                        {
                            Id = 5,
                            Category = 1,
                            Description = "Mushroom & Swiss burger",
                            Name = "Mushroom & Swiss burger",
                            Price = 4.59m
                        },
                        new
                        {
                            Id = 6,
                            Category = 1,
                            Description = "Mushroom & Swiss burger, with two beef patties",
                            Name = "Mushroom & Swiss burger - double",
                            Price = 6.09m
                        });
                });

            modelBuilder.Entity("MyRestaurantApi.MenuItemOrdered", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Category")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MenuItemId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("TogoOrderId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TogoOrderId");

                    b.ToTable("MenuItemOrdered");
                });

            modelBuilder.Entity("MyRestaurantApi.TogoOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("OrderCreated")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PaymentMethod")
                        .HasColumnType("INTEGER");

                    b.Property<decimal?>("Subtotal")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Tax")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("Total")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("TogoOrder");
                });

            modelBuilder.Entity("MyRestaurantApi.MenuItemOrdered", b =>
                {
                    b.HasOne("MyRestaurantApi.TogoOrder", null)
                        .WithMany("ItemsOrdered")
                        .HasForeignKey("TogoOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyRestaurantApi.TogoOrder", b =>
                {
                    b.HasOne("MyRestaurantApi.Contact", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("MyRestaurantApi.TogoOrder", b =>
                {
                    b.Navigation("ItemsOrdered");
                });
#pragma warning restore 612, 618
        }
    }
}
