using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 3L, "T-SHIRT", "LOREM SIAJSID OSDJOAJSD ", "https://www.pexels.com/pt-br/foto/roupas-variadas-996329/", "Camisa x", 45.4m },
                    { 4L, "T-SHIRT", "LOREM SIAJSID OSDJOyyyAJSD ", "https://www.pexels.com/pt-br/foto/roupas-variadas-996329/", "Camisa yx", 48.4m },
                    { 5L, "T-SHIRT", "LOREM SIAJSID OSDJeteOAJSD ", "https://www.pexels.com/pt-br/foto/traje-casual-roupas-trajes-espaco-do-texto-9558699/", "Camisa bfgx", 49.4m },
                    { 6L, "T-SHIRT", "LOREM SIAJSID OfgsdfdSDJOAJSD ", "https://www.pexels.com/pt-br/foto/roupas-variadas-996329/", "Camisa dsfdx", 42.4m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);
        }
    }
}
