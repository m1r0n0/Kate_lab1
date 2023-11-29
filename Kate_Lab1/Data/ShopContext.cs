using Kate_Lab1.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace SP.Identity.DataAccessLayer.Data
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public new DbSet<Staff> Staff { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Staff>().HasData(
                new Staff { Id = 1, Name = "Bob", Position = "Manager" },
                new Staff { Id = 2, Name = "Jack", Position = "Assistant" },
                new Staff { Id = 3, Name = "Patrick", Position = "Assistant" }
            );
        }
    }
}