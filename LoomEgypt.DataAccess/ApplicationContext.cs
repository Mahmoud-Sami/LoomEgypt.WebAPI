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
                new Category { Id = 1, Name = "Category-1", Description = "Description-1", ShippingFees = 5.00M},
                new Category { Id = 2, Name = "Category-2", Description = "Description-2", ShippingFees = 7.80M}
            });

            modelBuilder.Entity<Product>().HasData(new Product[]{
                new Product { Id = 1, Name = "Product-1", Brand = "Nike", Description = "Product Description-1", CategoryID = 1 },
                new Product { Id = 2, Name = "Product-2", Brand = "Canon", Description = "Product Description-2", CategoryID = 2 },
            });

            modelBuilder.Entity<ProductImage>().HasData(new ProductImage[]{
                new ProductImage { Id = 1, Path = "https://picsum.photos/id/1/200/300", productID = 1},
                new ProductImage { Id = 2, Path = "https://picsum.photos/id/10/200/300", productID = 1},

                new ProductImage { Id = 3, Path = "https://picsum.photos/id/100/200/300", productID = 2},
                new ProductImage { Id = 4, Path = "https://picsum.photos/id/1000/200/300", productID = 2},

            });
        }
    }
}
