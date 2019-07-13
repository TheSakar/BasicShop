using Microsoft.EntityFrameworkCore.Migrations;

namespace BasicShop.DataAccess.Migrations
{
    public partial class InserSomeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Products");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Smart phone" },
                    { 2, "Laptop" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ProductName", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, "LG G4", 2500m },
                    { 2, 1, "IPhone 7", 5000m },
                    { 3, 2, "Dell 9570", 13000m },
                    { 4, 2, "Lenovo Yoga 530", 4700m },
                    { 5, 2, "Lenovo X270", 6800m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }
    }
}
