using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            builder.Property(p => p.ProductName).IsRequired();
            builder.Property(p => p.Price).IsRequired();

            builder.HasData(
                new Product() { ProductId = 1, CategoryId= 2, ImageUrl="/images/1.jpg", ProductName = "Gaming Computer", Price = 17_000, ShowCase = false },
                new Product() { ProductId = 2, CategoryId= 2, ImageUrl="/images/2.jpg", ProductName = "Mechanical Keyboard", Price = 1_749, ShowCase = false },
                new Product() { ProductId = 3, CategoryId= 2, ImageUrl="/images/3.jpg", ProductName = "Mouse", Price = 629, ShowCase = false },
                new Product() { ProductId = 4, CategoryId= 2, ImageUrl="/images/4.jpg", ProductName = "Monitor", Price = 5_449, ShowCase = false },
                new Product() { ProductId = 5, CategoryId= 2, ImageUrl="/images/5.jpg", ProductName = "Deck", Price = 2300, ShowCase = false },
                new Product() { ProductId = 6, CategoryId= 1, ImageUrl="/images/6.jpg", ProductName = "History", Price = 85, ShowCase = false },
                new Product() { ProductId = 7, CategoryId= 1, ImageUrl="/images/7.jpg", ProductName = "Hamlet", Price = 75, ShowCase = false },
                new Product() { ProductId = 8, CategoryId= 1, ImageUrl="/images/8.jpg", ProductName = "Xp-pen", Price = 775, ShowCase = true },
                new Product() { ProductId = 9, CategoryId= 2, ImageUrl="/images/9.jpg", ProductName = "Galaxy FE", Price = 24500, ShowCase = true },
                new Product() { ProductId = 10, CategoryId= 1, ImageUrl="/images/10.jpg", ProductName = "Hp Mouse", Price = 545, ShowCase = true }
            );
        }
    }
}