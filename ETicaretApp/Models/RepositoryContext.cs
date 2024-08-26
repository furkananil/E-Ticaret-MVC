using Microsoft.EntityFrameworkCore;

namespace ETicaretApp.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

    }
}