using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SP.Identity.DataAccessLayer.Models;

namespace SP.Identity.DataAccessLayer.Data
{
    public class ShopContext : DbContext
    {
        public IdentityContext(DbContextOptions<IdentityContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }

        public new DbSet<User> Users { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().Property(p => p.Id).HasColumnName("UserId");
        }
    }
}