using Microsoft.EntityFrameworkCore;
using Models;

namespace WebApiDemo.Data
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options)
            : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}