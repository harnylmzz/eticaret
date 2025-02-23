using eticaret.Entities;
using Microsoft.EntityFrameworkCore;

namespace eticaret.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Cart> Carts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Iphone 12",
                    Description = "Apple Iphone 12 64 GB",
                    Price = 7999.99m,
                    IsActive = true,
                    ImageUrl = "https://m.media-amazon.com/images/I/71ZOtNdaZCL._AC_SL1500_.jpg",
                    Stock = 100
                },
                new Product
                {
                    Id = 2,
                    Name = "Samsung Galaxy S21",
                    Description = "Samsung Galaxy S21 128 GB",
                    Price = 6999.99m,
                    IsActive = true,
                    ImageUrl = "https://m.media-amazon.com/images/I/71L2iBSyyOL._AC_SL1500_.jpg",
                    Stock = 100
                },
                new Product
                {
                    Id = 3,
                    Name = "Xiaomi Mi 11",
                    Description = "Xiaomi Mi 11 128 GB",
                    Price = 5999.99m,
                    IsActive = true,
                    ImageUrl = "https://m.media-amazon.com/images/I/71j2Zd3f3SL._AC_SL1500_.jpg",
                    Stock = 100
                }
            );
        }
    }
}
