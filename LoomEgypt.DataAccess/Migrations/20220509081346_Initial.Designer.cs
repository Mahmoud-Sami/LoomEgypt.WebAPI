﻿// <auto-generated />
using LoomEgypt.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoomEgypt.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220509081346_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("LoomEgypt.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<decimal>("ShippingFees")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Smart Phones & Tablets",
                            Name = "Mobiles",
                            ShippingFees = 5.00m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Men's shoe store",
                            Name = "Shoes",
                            ShippingFees = 2.80m
                        });
                });

            modelBuilder.Entity("LoomEgypt.Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryID");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Apple",
                            CategoryID = 1,
                            Description = "6.7-inch Super Retina XDR display with ProMotion for a faster, more responsive feel",
                            Name = "iPhone 13 Pro Max",
                            Price = 23500m
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Apple",
                            CategoryID = 1,
                            Description = "Cinematic mode adds shallow depth of field and shifts focus automatically in your videos",
                            Name = "iPhone 13 Pro",
                            Price = 20100m
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Apple",
                            CategoryID = 1,
                            Description = "A15 Bionic chip for lightning-fast performance",
                            Name = "iPhone 13",
                            Price = 17200m
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Apple",
                            CategoryID = 1,
                            Description = "Super Retina XDR display",
                            Name = "iPhone 13 Mini",
                            Price = 15000m
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Nike",
                            CategoryID = 2,
                            Description = "NIKE WEARALLDAY MENS WHITE/BLACK",
                            Name = "Nike WearAllday Men's Sneakers",
                            Price = 750m
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Skechers",
                            CategoryID = 2,
                            Description = "MEMORY FOAM",
                            Name = "Skechers GO WALK 6 Men's Shoes",
                            Price = 970m
                        });
                });

            modelBuilder.Entity("LoomEgypt.Domain.Entities.ProductAttribute", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductAttributes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Color",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Size",
                            ProductId = 1
                        },
                        new
                        {
                            Id = 3,
                            Name = "Color",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 4,
                            Name = "Size",
                            ProductId = 2
                        },
                        new
                        {
                            Id = 5,
                            Name = "Color",
                            ProductId = 3
                        },
                        new
                        {
                            Id = 6,
                            Name = "Size",
                            ProductId = 3
                        },
                        new
                        {
                            Id = 7,
                            Name = "Color",
                            ProductId = 4
                        },
                        new
                        {
                            Id = 8,
                            Name = "Size",
                            ProductId = 4
                        },
                        new
                        {
                            Id = 9,
                            Name = "Color",
                            ProductId = 5
                        },
                        new
                        {
                            Id = 10,
                            Name = "Size",
                            ProductId = 5
                        },
                        new
                        {
                            Id = 11,
                            Name = "Color",
                            ProductId = 6
                        },
                        new
                        {
                            Id = 12,
                            Name = "Size",
                            ProductId = 6
                        });
                });

            modelBuilder.Entity("LoomEgypt.Domain.Entities.ProductAttributeItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DisplayValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ExtraFees")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ProductAttributeId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductAttributeId");

                    b.ToTable("ProductAttributeItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayValue = "Sierra Blue",
                            ExtraFees = 200m,
                            ProductAttributeId = 1,
                            Value = "#ABBCD3"
                        },
                        new
                        {
                            Id = 2,
                            DisplayValue = "Gold",
                            ExtraFees = 120m,
                            ProductAttributeId = 1,
                            Value = "#FDEFDA"
                        },
                        new
                        {
                            Id = 3,
                            DisplayValue = "Silver",
                            ExtraFees = 70m,
                            ProductAttributeId = 1,
                            Value = "#F8F9F4"
                        },
                        new
                        {
                            Id = 4,
                            DisplayValue = "128 GB",
                            ExtraFees = 0m,
                            ProductAttributeId = 2,
                            Value = "128"
                        },
                        new
                        {
                            Id = 5,
                            DisplayValue = "256 GB",
                            ExtraFees = 3000m,
                            ProductAttributeId = 2,
                            Value = "256"
                        },
                        new
                        {
                            Id = 6,
                            DisplayValue = "Sierra Blue",
                            ExtraFees = 200m,
                            ProductAttributeId = 3,
                            Value = "#ABBCD3"
                        },
                        new
                        {
                            Id = 7,
                            DisplayValue = "Gold",
                            ExtraFees = 120m,
                            ProductAttributeId = 3,
                            Value = "#FDEFDA"
                        },
                        new
                        {
                            Id = 8,
                            DisplayValue = "Silver",
                            ExtraFees = 70m,
                            ProductAttributeId = 3,
                            Value = "#F8F9F4"
                        },
                        new
                        {
                            Id = 9,
                            DisplayValue = "128 GB",
                            ExtraFees = 0m,
                            ProductAttributeId = 4,
                            Value = "128"
                        },
                        new
                        {
                            Id = 10,
                            DisplayValue = "256 GB",
                            ExtraFees = 3000m,
                            ProductAttributeId = 4,
                            Value = "256"
                        },
                        new
                        {
                            Id = 11,
                            DisplayValue = "Sierra Blue",
                            ExtraFees = 200m,
                            ProductAttributeId = 5,
                            Value = "#ABBCD3"
                        },
                        new
                        {
                            Id = 12,
                            DisplayValue = "Gold",
                            ExtraFees = 120m,
                            ProductAttributeId = 5,
                            Value = "#FDEFDA"
                        },
                        new
                        {
                            Id = 13,
                            DisplayValue = "Silver",
                            ExtraFees = 70m,
                            ProductAttributeId = 5,
                            Value = "#F8F9F4"
                        },
                        new
                        {
                            Id = 14,
                            DisplayValue = "128 GB",
                            ExtraFees = 0m,
                            ProductAttributeId = 6,
                            Value = "128"
                        },
                        new
                        {
                            Id = 15,
                            DisplayValue = "256 GB",
                            ExtraFees = 3000m,
                            ProductAttributeId = 6,
                            Value = "256"
                        },
                        new
                        {
                            Id = 16,
                            DisplayValue = "Sierra Blue",
                            ExtraFees = 200m,
                            ProductAttributeId = 7,
                            Value = "#ABBCD3"
                        },
                        new
                        {
                            Id = 17,
                            DisplayValue = "Gold",
                            ExtraFees = 120m,
                            ProductAttributeId = 7,
                            Value = "#FDEFDA"
                        },
                        new
                        {
                            Id = 18,
                            DisplayValue = "Silver",
                            ExtraFees = 70m,
                            ProductAttributeId = 7,
                            Value = "#F8F9F4"
                        },
                        new
                        {
                            Id = 19,
                            DisplayValue = "128 GB",
                            ExtraFees = 0m,
                            ProductAttributeId = 8,
                            Value = "128"
                        },
                        new
                        {
                            Id = 20,
                            DisplayValue = "256 GB",
                            ExtraFees = 3000m,
                            ProductAttributeId = 8,
                            Value = "256"
                        },
                        new
                        {
                            Id = 21,
                            DisplayValue = "Black",
                            ExtraFees = 0m,
                            ProductAttributeId = 9,
                            Value = "#000000"
                        },
                        new
                        {
                            Id = 22,
                            DisplayValue = "Gray",
                            ExtraFees = 60m,
                            ProductAttributeId = 9,
                            Value = "#eeeeee"
                        },
                        new
                        {
                            Id = 23,
                            DisplayValue = "40 EU",
                            ExtraFees = 0m,
                            ProductAttributeId = 10,
                            Value = "40"
                        },
                        new
                        {
                            Id = 24,
                            DisplayValue = "41 EU",
                            ExtraFees = 50m,
                            ProductAttributeId = 10,
                            Value = "41"
                        },
                        new
                        {
                            Id = 25,
                            DisplayValue = "42 EU",
                            ExtraFees = 100m,
                            ProductAttributeId = 10,
                            Value = "42"
                        },
                        new
                        {
                            Id = 26,
                            DisplayValue = "Deep Blue",
                            ExtraFees = 0m,
                            ProductAttributeId = 11,
                            Value = "#2541cc"
                        },
                        new
                        {
                            Id = 27,
                            DisplayValue = "Cyan",
                            ExtraFees = 70m,
                            ProductAttributeId = 11,
                            Value = "#25c6cc"
                        },
                        new
                        {
                            Id = 28,
                            DisplayValue = "40 EU",
                            ExtraFees = 0m,
                            ProductAttributeId = 12,
                            Value = "40"
                        },
                        new
                        {
                            Id = 29,
                            DisplayValue = "41 EU",
                            ExtraFees = 50m,
                            ProductAttributeId = 12,
                            Value = "41"
                        },
                        new
                        {
                            Id = 30,
                            DisplayValue = "42 EU",
                            ExtraFees = 100m,
                            ProductAttributeId = 12,
                            Value = "42"
                        });
                });

            modelBuilder.Entity("LoomEgypt.Domain.Entities.ProductImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ImageDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("productID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("productID");

                    b.ToTable("ProductImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageDescription = "iPhone 13 Pro Max",
                            ImagePath = "https://picsum.photos/id/1/200/300",
                            productID = 1
                        },
                        new
                        {
                            Id = 2,
                            ImagePath = "https://picsum.photos/id/10/200/300",
                            productID = 1
                        },
                        new
                        {
                            Id = 3,
                            ImagePath = "https://picsum.photos/id/100/200/300",
                            productID = 2
                        },
                        new
                        {
                            Id = 4,
                            ImagePath = "https://picsum.photos/id/1000/200/300",
                            productID = 2
                        });
                });

            modelBuilder.Entity("LoomEgypt.Domain.Entities.ProductInventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductID")
                        .IsUnique();

                    b.ToTable("ProductsInventory");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProductID = 1,
                            Quantity = 4
                        },
                        new
                        {
                            Id = 2,
                            ProductID = 2,
                            Quantity = 6
                        },
                        new
                        {
                            Id = 3,
                            ProductID = 3,
                            Quantity = 2
                        },
                        new
                        {
                            Id = 4,
                            ProductID = 4,
                            Quantity = 0
                        },
                        new
                        {
                            Id = 5,
                            ProductID = 5,
                            Quantity = 26
                        },
                        new
                        {
                            Id = 6,
                            ProductID = 6,
                            Quantity = 43
                        });
                });

            modelBuilder.Entity("LoomEgypt.Domain.Entities.Product", b =>
                {
                    b.HasOne("LoomEgypt.Domain.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("LoomEgypt.Domain.Entities.ProductAttribute", b =>
                {
                    b.HasOne("LoomEgypt.Domain.Entities.Product", null)
                        .WithMany("Attributes")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LoomEgypt.Domain.Entities.ProductAttributeItem", b =>
                {
                    b.HasOne("LoomEgypt.Domain.Entities.ProductAttribute", null)
                        .WithMany("Items")
                        .HasForeignKey("ProductAttributeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LoomEgypt.Domain.Entities.ProductImage", b =>
                {
                    b.HasOne("LoomEgypt.Domain.Entities.Product", null)
                        .WithMany("Gallery")
                        .HasForeignKey("productID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LoomEgypt.Domain.Entities.ProductInventory", b =>
                {
                    b.HasOne("LoomEgypt.Domain.Entities.Product", "Product")
                        .WithOne("ProductInventory")
                        .HasForeignKey("LoomEgypt.Domain.Entities.ProductInventory", "ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("LoomEgypt.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("LoomEgypt.Domain.Entities.Product", b =>
                {
                    b.Navigation("Attributes");

                    b.Navigation("Gallery");

                    b.Navigation("ProductInventory");
                });

            modelBuilder.Entity("LoomEgypt.Domain.Entities.ProductAttribute", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
