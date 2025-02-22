using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace eticaret.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "IsActive", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, "Apple Iphone 12 64 GB", "https://m.media-amazon.com/images/I/71ZOtNdaZCL._AC_SL1500_.jpg", true, "Iphone 12", 7999.99m, 100 },
                    { 2, "Samsung Galaxy S21 128 GB", "https://m.media-amazon.com/images/I/71L2iBSyyOL._AC_SL1500_.jpg", true, "Samsung Galaxy S21", 6999.99m, 100 },
                    { 3, "Xiaomi Mi 11 128 GB", "https://m.media-amazon.com/images/I/71j2Zd3f3SL._AC_SL1500_.jpg", true, "Xiaomi Mi 11", 5999.99m, 100 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
