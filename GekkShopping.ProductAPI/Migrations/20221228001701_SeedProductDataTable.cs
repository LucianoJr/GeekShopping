using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GekkShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 3L, "t-Shirt", "Lorem impsum", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/tree/main/ShoppingImages", "Camiseta Preta", 56.9m },
                    { 4L, "t-Shirt", "Lorem impsum", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/tree/main/ShoppingImages", "Camiseta Branca", 56.9m },
                    { 5L, "t-Shirt", "Lorem impsum", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/tree/main/ShoppingImages", "Camiseta Verde", 56.9m },
                    { 6L, "t-Shirt", "Lorem impsum", "https://github.com/leandrocgsi/erudio-microservices-dotnet6/tree/main/ShoppingImages", "Camiseta Star Wars", 56.9m }
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
