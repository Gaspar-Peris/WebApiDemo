using DataAccess.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApiDemo.Data
{
    public class AplicationDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<User> User { get; set; }
        



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Product>()
                .Property(p => p.Price)
                .HasPrecision(18, 4); // 18 total, 4 decimales

            builder.Entity<User>()//EntityTypeBuilder<User>
                    .Property(u => u.FirstName).HasMaxLength(256);

            builder.Entity<User>()//EntityTypeBuilder<User>
                .Property(u => u.LastName).HasMaxLength(256);

            builder.Entity<IdentityRole<Guid>>()
                .HasData(new List<IdentityRole<Guid>>
            {
                new IdentityRole<Guid>
                {
                    Id = IdentityRoleConstants.AdminRoleGuid,
                    Name = IdentityRoleConstants.Admin,
                    NormalizedName = IdentityRoleConstants.Admin.ToUpper(),
                    ConcurrencyStamp = "9d1d6d3d-8c2f-4f5d-a111-111111111111"


                },
                new IdentityRole<Guid>
                {
                    Id = IdentityRoleConstants.DirectorGuid,
                    Name = IdentityRoleConstants.Director,
                    NormalizedName = IdentityRoleConstants.Director.ToUpper(),
                    ConcurrencyStamp = "9d1d6d3d-8c2f-4f5d-a222-222222222222"
                },
                new IdentityRole<Guid>
                {
                    Id = IdentityRoleConstants.RegularEmployeeGuid,
                    Name = IdentityRoleConstants.Employee,
                    NormalizedName = IdentityRoleConstants.Employee.ToUpper(),
                    ConcurrencyStamp = "9d1d6d3d-8c2f-4f5d-a333-333333333333"
                }
            });
        }
    }
}