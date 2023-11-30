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
        public new DbSet<Item> Items{ get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Staff>().HasData(
                new Staff { Id = 1, Name = "Bob", Position = "Manager" },
                new Staff { Id = 2, Name = "Jack", Position = "Assistant" },
                new Staff { Id = 3, Name = "Patrick", Position = "Assistant" }
            );

            modelBuilder.Entity<Item>().HasOne(typeof(Staff)).WithMany().HasForeignKey("LastChangeStaffId");

            modelBuilder.Entity<Item>().HasData(
                 new Item
                 {
                     Id = 1,
                     Name = "Laptop",
                     Description = "Powerful laptop with high-performance specifications.",
                     Status = "Active",
                     CreateTime = DateTime.Now.AddDays(-5),
                     DeactivateTime = DateTime.Now.AddDays(10),
                     LastChange = DateTime.Now.AddDays(-1),
                     LastChangeStaffId = 2
                 },
            new Item
            {
                Id = 2,
                Name = "Smartphone",
                Description = "Latest smartphone model with advanced features.",
                Status = "Inactive",
                CreateTime = DateTime.Now.AddDays(-10),
                DeactivateTime = DateTime.Now.AddDays(-1),
                LastChange = DateTime.Now.AddDays(-2),
                LastChangeStaffId = 2
            },
            new Item
            {
                Id = 3,
                Name = "Coffee Maker",
                Description = "Automatic coffee maker with multiple brewing options.",
                Status = "Active",
                CreateTime = DateTime.Now.AddDays(-15),
                DeactivateTime = DateTime.Now.AddDays(5),
                LastChange = DateTime.Now.AddDays(-3),
                LastChangeStaffId = 2
            },
            new Item
            {
                Id = 4,
                Name = "Desk Chair",
                Description = "Ergonomic office chair for maximum comfort during work hours.",
                Status = "Active",
                CreateTime = DateTime.Now.AddDays(-8),
                DeactivateTime = DateTime.Now.AddDays(12),
                LastChange = DateTime.Now.AddDays(-4),
                LastChangeStaffId = 3
            },
            new Item
            {
                Id = 5,
                Name = "Fitness Tracker",
                Description = "Track your daily activity and health with this advanced fitness tracker.",
                Status = "Inactive",
                CreateTime = DateTime.Now.AddDays(-12),
                DeactivateTime = DateTime.Now.AddDays(3),
                LastChange = DateTime.Now.AddDays(-5),
                LastChangeStaffId = 2
            },
            new Item
            {
                Id = 6,
                Name = "Bookshelf",
                Description = "Stylish wooden bookshelf for organizing your book collection.",
                Status = "Active",
                CreateTime = DateTime.Now.AddDays(-18),
                DeactivateTime = DateTime.Now.AddDays(8),
                LastChange = DateTime.Now.AddDays(-6),
                LastChangeStaffId = 106
            },
            new Item
            {
                Id = 7,
                Name = "Digital Camera",
                Description = "High-resolution digital camera for capturing moments in clarity.",
                Status = "Active",
                CreateTime = DateTime.Now.AddDays(-25),
                DeactivateTime = DateTime.Now.AddDays(15),
                LastChange = DateTime.Now.AddDays(-7),
                LastChangeStaffId = 3
            },
            new Item
            {
                Id = 8,
                Name = "Gaming Console",
                Description = "Next-gen gaming console for an immersive gaming experience.",
                Status = "Active",
                CreateTime = DateTime.Now.AddDays(-30),
                DeactivateTime = DateTime.Now.AddDays(20),
                LastChange = DateTime.Now.AddDays(-8),
                LastChangeStaffId = 3
            },
            new Item
            {
                Id = 9,
                Name = "Cookware Set",
                Description = "Premium cookware set for all your culinary needs.",
                Status = "Inactive",
                CreateTime = DateTime.Now.AddDays(-22),
                DeactivateTime = DateTime.Now.AddDays(5),
                LastChange = DateTime.Now.AddDays(-9),
                LastChangeStaffId = 2
            },
            new Item
            {
                Id = 10,
                Name = "Wireless Router",
                Description = "High-speed wireless router for seamless internet connectivity.",
                Status = "Active",
                CreateTime = DateTime.Now.AddDays(-28),
                DeactivateTime = DateTime.Now.AddDays(10),
                LastChange = DateTime.Now.AddDays(-10),
                LastChangeStaffId = 3
            },
            new Item
            {
                Id = 11,
                Name = "Graphic Design Software",
                Description = "Professional graphic design software for creative projects.",
                Status = "Active",
                CreateTime = DateTime.Now.AddDays(-35),
                DeactivateTime = DateTime.Now.AddDays(25),
                LastChange = DateTime.Now.AddDays(-11),
                LastChangeStaffId = 2
            },
            new Item
            {
                Id = 12,
                Name = "Hiking Backpack",
                Description = "Durable hiking backpack with multiple compartments.",
                Status = "Active",
                CreateTime = DateTime.Now.AddDays(-40),
                DeactivateTime = DateTime.Now.AddDays(30),
                LastChange = DateTime.Now.AddDays(-12),
                LastChangeStaffId = 3
            },
            new Item
            {
                Id = 13,
                Name = "Bluetooth Speakers",
                Description = "Portable Bluetooth speakers for on-the-go music.",
                Status = "Inactive",
                CreateTime = DateTime.Now.AddDays(-32),
                DeactivateTime = DateTime.Now.AddDays(8),
                LastChange = DateTime.Now.AddDays(-13),
                LastChangeStaffId = 2
            },
            new Item
            {
                Id = 14,
                Name = "Home Security Camera",
                Description = "Smart home security camera for monitoring your living space.",
                Status = "Active",
                CreateTime = DateTime.Now.AddDays(-38),
                DeactivateTime = DateTime.Now.AddDays(18),
                LastChange = DateTime.Now.AddDays(-14),
                LastChangeStaffId = 3
            },
            new Item
            {
                Id = 15,
                Name = "Headphones",
                Description = "Wireless noise-canceling headphones for an immersive audio experience.",
                Status = "Active",
                CreateTime = DateTime.Now.AddDays(-20),
                DeactivateTime = DateTime.Now.AddDays(2),
                LastChange = DateTime.Now.AddDays(-5),
                LastChangeStaffId = 2
            }
            );
        }
    }
}