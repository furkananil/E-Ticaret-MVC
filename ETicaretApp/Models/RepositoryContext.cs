using Microsoft.EntityFrameworkCore;
using Entities.Models;

namespace ETicaretApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
            
        } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product(){ProductId = 1, ProductName = "Gaming Computer" , Price = 17_000},
                new Product(){ProductId = 2, ProductName = "Mechanical Keyboard" , Price = 1_749},
                new Product(){ProductId = 3, ProductName = "Mouse" , Price = 629},
                new Product(){ProductId = 4, ProductName = "Monitor" , Price = 5_449},
                new Product(){ProductId = 5, ProductName = "Deck" , Price = 2300}
            );
        }

    }
}