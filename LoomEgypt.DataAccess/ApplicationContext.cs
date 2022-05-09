using LoomEgypt.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LoomEgypt.DataAccess
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {}

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(new Category[]{
                new Category { Id = 1, Name = "Mobiles", Description = "Smart Phones & Tablets", ShippingFees = 5.00M},
                new Category { Id = 2, Name = "Shoes", Description = "Men's shoe store", ShippingFees = 2.80M}
            });

            modelBuilder.Entity<Product>().HasData(new Product[]{
                new Product { Id = 1, Name = "iPhone 13 Pro Max", Brand = "Apple", Description = "6.7-inch Super Retina XDR display with ProMotion for a faster, more responsive feel", Price = 23500M,  CategoryID = 1 },
                new Product { Id = 2, Name = "iPhone 13 Pro", Brand = "Apple", Description = "Cinematic mode adds shallow depth of field and shifts focus automatically in your videos", Price = 20100M,  CategoryID = 1 },
                new Product { Id = 3, Name = "iPhone 13", Brand = "Apple", Description = "A15 Bionic chip for lightning-fast performance", Price = 17200M,  CategoryID = 1 },
                new Product { Id = 4, Name = "iPhone 13 Mini", Brand = "Apple", Description = "Super Retina XDR display", Price = 15000M,  CategoryID = 1 },

                new Product { Id = 5, Name = "Nike WearAllday Men's Sneakers", Brand = "Nike", Description = "NIKE WEARALLDAY MENS WHITE/BLACK", Price = 750M,  CategoryID = 2 },
                new Product { Id = 6, Name = "Skechers GO WALK 6 Men's Shoes", Brand = "Skechers", Description = "MEMORY FOAM", Price = 970M,  CategoryID = 2 },
            });

            modelBuilder.Entity<ProductInventory>().HasData(new ProductInventory[]{
                new ProductInventory { Id = 1, ProductID = 1 , Quantity = 4},
                new ProductInventory { Id = 2, ProductID = 2 , Quantity = 6},
                new ProductInventory { Id = 3, ProductID = 3 , Quantity = 2},
                new ProductInventory { Id = 4, ProductID = 4 , Quantity = 0},
                new ProductInventory { Id = 5, ProductID = 5 , Quantity = 26},
                new ProductInventory { Id = 6, ProductID = 6 , Quantity = 43}
            });

            modelBuilder.Entity<ProductImage>().HasData(new ProductImage[]{
                new ProductImage { Id = 1, ImagePath = "https://picsum.photos/id/1/200/300", ImageDescription="iPhone 13 Pro Max", productID = 1},
                new ProductImage { Id = 2, ImagePath = "https://picsum.photos/id/10/200/300", productID = 1},

                new ProductImage { Id = 3, ImagePath = "https://picsum.photos/id/100/200/300", productID = 2},
                new ProductImage { Id = 4, ImagePath = "https://picsum.photos/id/1000/200/300", productID = 2},

            });

            modelBuilder.Entity<ProductAttribute>().HasData(new ProductAttribute[]{
                new ProductAttribute { Id = 1, Name = "Color", ProductId = 1},
                new ProductAttribute { Id = 2, Name = "Size", ProductId = 1},

                new ProductAttribute { Id = 3, Name = "Color", ProductId = 2},
                new ProductAttribute { Id = 4, Name = "Size", ProductId = 2},

                new ProductAttribute { Id = 5, Name = "Color", ProductId = 3},
                new ProductAttribute { Id = 6, Name = "Size", ProductId = 3},

                new ProductAttribute { Id = 7, Name = "Color", ProductId = 4},
                new ProductAttribute { Id = 8, Name = "Size", ProductId = 4},

                new ProductAttribute { Id = 9, Name = "Color", ProductId = 5},
                new ProductAttribute { Id = 10, Name = "Size", ProductId = 5},

                new ProductAttribute { Id = 11, Name = "Color", ProductId = 6},
                new ProductAttribute { Id = 12, Name = "Size", ProductId = 6},
            });

            modelBuilder.Entity<ProductAttributeItem>().HasData(new ProductAttributeItem[]{
                new ProductAttributeItem { Id = 1, Value="#ABBCD3", DisplayValue = "Sierra Blue", ExtraFees = 200M, ProductAttributeId = 1},
                new ProductAttributeItem { Id = 2, Value="#FDEFDA", DisplayValue = "Gold", ExtraFees = 120M, ProductAttributeId = 1},
                new ProductAttributeItem { Id = 3, Value="#F8F9F4", DisplayValue = "Silver", ExtraFees = 70M, ProductAttributeId = 1},
                new ProductAttributeItem { Id = 4, Value="128", DisplayValue = "128 GB", ExtraFees = 0M, ProductAttributeId = 2},
                new ProductAttributeItem { Id = 5, Value="256", DisplayValue = "256 GB", ExtraFees = 3000M, ProductAttributeId = 2},

                new ProductAttributeItem { Id = 6, Value="#ABBCD3", DisplayValue = "Sierra Blue", ExtraFees = 200M, ProductAttributeId = 3},
                new ProductAttributeItem { Id = 7, Value="#FDEFDA", DisplayValue = "Gold", ExtraFees = 120M, ProductAttributeId = 3},
                new ProductAttributeItem { Id = 8, Value="#F8F9F4", DisplayValue = "Silver", ExtraFees = 70M, ProductAttributeId = 3},
                new ProductAttributeItem { Id = 9, Value="128", DisplayValue = "128 GB", ExtraFees = 0M, ProductAttributeId = 4},
                new ProductAttributeItem { Id = 10, Value="256", DisplayValue = "256 GB", ExtraFees = 3000M, ProductAttributeId = 4},

                new ProductAttributeItem { Id = 11, Value="#ABBCD3", DisplayValue = "Sierra Blue", ExtraFees = 200M, ProductAttributeId = 5},
                new ProductAttributeItem { Id = 12, Value="#FDEFDA", DisplayValue = "Gold", ExtraFees = 120M, ProductAttributeId = 5},
                new ProductAttributeItem { Id = 13, Value="#F8F9F4", DisplayValue = "Silver", ExtraFees = 70M, ProductAttributeId = 5},
                new ProductAttributeItem { Id = 14, Value="128", DisplayValue = "128 GB", ExtraFees = 0M, ProductAttributeId = 6},
                new ProductAttributeItem { Id = 15, Value="256", DisplayValue = "256 GB", ExtraFees = 3000M, ProductAttributeId = 6},

                new ProductAttributeItem { Id = 16, Value="#ABBCD3", DisplayValue = "Sierra Blue", ExtraFees = 200M, ProductAttributeId = 7},
                new ProductAttributeItem { Id = 17, Value="#FDEFDA", DisplayValue = "Gold", ExtraFees = 120M, ProductAttributeId = 7},
                new ProductAttributeItem { Id = 18, Value="#F8F9F4", DisplayValue = "Silver", ExtraFees = 70M, ProductAttributeId = 7},
                new ProductAttributeItem { Id = 19, Value="128", DisplayValue = "128 GB", ExtraFees = 0M, ProductAttributeId = 8},
                new ProductAttributeItem { Id = 20, Value="256", DisplayValue = "256 GB", ExtraFees = 3000M, ProductAttributeId = 8},

                new ProductAttributeItem { Id = 21, Value="#000000", DisplayValue = "Black", ExtraFees = 0M, ProductAttributeId = 9},
                new ProductAttributeItem { Id = 22, Value="#eeeeee", DisplayValue = "Gray", ExtraFees = 60M, ProductAttributeId = 9},
                new ProductAttributeItem { Id = 23, Value="40", DisplayValue = "40 EU", ExtraFees = 0M, ProductAttributeId = 10},
                new ProductAttributeItem { Id = 24, Value="41", DisplayValue = "41 EU", ExtraFees = 50M, ProductAttributeId = 10},
                new ProductAttributeItem { Id = 25, Value="42", DisplayValue = "42 EU", ExtraFees = 100M, ProductAttributeId = 10},

                new ProductAttributeItem { Id = 26, Value="#2541cc", DisplayValue = "Deep Blue", ExtraFees = 0M, ProductAttributeId = 11},
                new ProductAttributeItem { Id = 27, Value="#25c6cc", DisplayValue = "Cyan", ExtraFees = 70M, ProductAttributeId = 11},
                new ProductAttributeItem { Id = 28, Value="40", DisplayValue = "40 EU", ExtraFees = 0M, ProductAttributeId = 12},
                new ProductAttributeItem { Id = 29, Value="41", DisplayValue = "41 EU", ExtraFees = 50M, ProductAttributeId = 12},
                new ProductAttributeItem { Id = 30, Value="42", DisplayValue = "42 EU", ExtraFees = 100M, ProductAttributeId = 12},
            });

            
        }
    }
}
