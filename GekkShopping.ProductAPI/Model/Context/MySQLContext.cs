using Microsoft.EntityFrameworkCore;

namespace GekkShopping.ProductAPI.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Product>().HasData(new Product 
            {
                Id = 3,
                Name = "Camiseta Preta",
                Price = new decimal(56.9),
                Description = "Lorem impsum",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/tree/main/ShoppingImages",
                CategoryName = "t-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Camiseta Branca",
                Price = new decimal(56.9),
                Description = "Lorem impsum",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/tree/main/ShoppingImages",
                CategoryName = "t-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Camiseta Verde",
                Price = new decimal(56.9),
                Description = "Lorem impsum",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/tree/main/ShoppingImages",
                CategoryName = "t-Shirt"
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Camiseta Star Wars",
                Price = new decimal(56.9),
                Description = "Lorem impsum",
                ImageUrl = "https://github.com/leandrocgsi/erudio-microservices-dotnet6/tree/main/ShoppingImages",
                CategoryName = "t-Shirt"
            });
        }
    }
}
