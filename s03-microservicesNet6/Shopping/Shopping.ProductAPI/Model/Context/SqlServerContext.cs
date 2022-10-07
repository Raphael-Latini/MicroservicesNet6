using Microsoft.EntityFrameworkCore;

namespace Shopping.ProductAPI.Model.Context
{
    public class SqlServerContext: DbContext
    {
        public SqlServerContext() {}
        public SqlServerContext(DbContextOptions<SqlServerContext>options): base(options) {}

        public DbSet<Product> Products { get; set; }    

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Camisa x",
                Price = new decimal(45.4),
                Description = "LOREM SIAJSID OSDJOAJSD ",
                ImageUrl = "https://www.pexels.com/pt-br/foto/roupas-variadas-996329/",
                CategoryName = "T-SHIRT"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Camisa yx",
                Price = new decimal(48.4),
                Description = "LOREM SIAJSID OSDJOyyyAJSD ",
                ImageUrl = "https://www.pexels.com/pt-br/foto/roupas-variadas-996329/",
                CategoryName = "T-SHIRT"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Camisa bfgx",
                Price = new decimal(49.4),
                Description = "LOREM SIAJSID OSDJeteOAJSD ",
                ImageUrl = "https://www.pexels.com/pt-br/foto/traje-casual-roupas-trajes-espaco-do-texto-9558699/",
                CategoryName = "T-SHIRT"

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Camisa dsfdx",
                Price = new decimal(42.4),
                Description = "LOREM SIAJSID OfgsdfdSDJOAJSD ",
                ImageUrl = "https://www.pexels.com/pt-br/foto/roupas-variadas-996329/",
                CategoryName = "T-SHIRT"

            });
        }



    }
}
