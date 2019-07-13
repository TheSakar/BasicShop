using BasicShop.Entity;
using Microsoft.EntityFrameworkCore;

namespace BasicShop.DataAccess.Concrete.EntityFramework
{
    public class BasicShopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Order> Orders { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=6906c7f90397;Database=BasicShop;User Id=SA;Password=123123123qq;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(k => k.Id);

            modelBuilder.Entity<Product>().HasKey(k => k.Id);
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products).IsRequired();

            modelBuilder.Entity<Category>().HasKey(c => c.Id);

            modelBuilder.Entity<Order>().HasKey(o => o.Id);
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders);

            modelBuilder.Entity<OrderProduct>().HasKey(k => new {k.OrderId, k.ProductId});

            modelBuilder.Entity<OrderProduct>()
                .HasOne(op => op.Product)
                .WithMany(p => p.OrderProducts)
                .HasForeignKey(k => k.ProductId);

            modelBuilder.Entity<OrderProduct>()
                .HasOne(op => op.Order)
                .WithMany(o => o.OrderProducts)
                .HasForeignKey(k => k.OrderId);


            modelBuilder.Entity<Product>().HasData(
                new Product {Id = 1, CategoryId = 1, ProductName = "LG G4", UnitPrice = 2500},
                new Product {Id = 2, CategoryId = 1, ProductName = "IPhone 7", UnitPrice = 5000},
                new Product {Id = 3, CategoryId = 2, ProductName = "Dell 9570", UnitPrice = 13000},
                new Product {Id = 4, CategoryId = 2, ProductName = "Lenovo Yoga 530", UnitPrice = 4700},
                new Product {Id = 5, CategoryId = 2, ProductName = "Lenovo X270", UnitPrice = 6800}
            );

            modelBuilder.Entity<User>().HasData(
                new User {Id = 1, FirstName = "Orhan", LastName = "Sakar"},
                new User {Id = 2, FirstName = "Mustafa", LastName = "Bilici"}
            );

            modelBuilder.Entity(typeof(Category)).HasData(
                new Category {Id = 1, CategoryName = "Smart phone"},
                new Category {Id = 2, CategoryName = "Laptop"}
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}