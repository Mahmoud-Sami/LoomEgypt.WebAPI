using Microsoft.EntityFrameworkCore.Migrations;

namespace LoomEgypt.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippingFees = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAttributes_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    productID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_productID",
                        column: x => x.productID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductsInventory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsInventory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductsInventory_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductAttributeItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtraFees = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductAttributeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAttributeItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductAttributeItems_ProductAttributes_ProductAttributeId",
                        column: x => x.ProductAttributeId,
                        principalTable: "ProductAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "ShippingFees" },
                values: new object[] { 1, "Smart Phones & Tablets", "Mobiles", 5.00m });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "ShippingFees" },
                values: new object[] { 2, "Men's shoe store", "Shoes", 2.80m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryID", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Apple", 1, "6.7-inch Super Retina XDR display with ProMotion for a faster, more responsive feel", "iPhone 13 Pro Max", 23500m },
                    { 2, "Apple", 1, "Cinematic mode adds shallow depth of field and shifts focus automatically in your videos", "iPhone 13 Pro", 20100m },
                    { 3, "Apple", 1, "A15 Bionic chip for lightning-fast performance", "iPhone 13", 17200m },
                    { 4, "Apple", 1, "Super Retina XDR display", "iPhone 13 Mini", 15000m },
                    { 5, "Nike", 2, "NIKE WEARALLDAY MENS WHITE/BLACK", "Nike WearAllday Men's Sneakers", 750m },
                    { 6, "Skechers", 2, "MEMORY FOAM", "Skechers GO WALK 6 Men's Shoes", 970m }
                });

            migrationBuilder.InsertData(
                table: "ProductAttributes",
                columns: new[] { "Id", "Name", "ProductId" },
                values: new object[,]
                {
                    { 1, "Color", 1 },
                    { 11, "Color", 6 },
                    { 10, "Size", 5 },
                    { 9, "Color", 5 },
                    { 8, "Size", 4 },
                    { 7, "Color", 4 },
                    { 6, "Size", 3 },
                    { 12, "Size", 6 },
                    { 5, "Color", 3 },
                    { 4, "Size", 2 },
                    { 3, "Color", 2 },
                    { 2, "Size", 1 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ImageDescription", "ImagePath", "productID" },
                values: new object[,]
                {
                    { 3, null, "https://picsum.photos/id/100/200/300", 2 },
                    { 2, null, "https://picsum.photos/id/10/200/300", 1 },
                    { 1, "iPhone 13 Pro Max", "https://picsum.photos/id/1/200/300", 1 },
                    { 4, null, "https://picsum.photos/id/1000/200/300", 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductsInventory",
                columns: new[] { "Id", "ProductID", "Quantity" },
                values: new object[,]
                {
                    { 2, 2, 6 },
                    { 3, 3, 2 },
                    { 1, 1, 4 },
                    { 4, 4, 0 },
                    { 5, 5, 26 },
                    { 6, 6, 43 }
                });

            migrationBuilder.InsertData(
                table: "ProductAttributeItems",
                columns: new[] { "Id", "DisplayValue", "ExtraFees", "ProductAttributeId", "Value" },
                values: new object[,]
                {
                    { 1, "Sierra Blue", 200m, 1, "#ABBCD3" },
                    { 28, "40 EU", 0m, 12, "40" },
                    { 27, "Cyan", 70m, 11, "#25c6cc" },
                    { 26, "Deep Blue", 0m, 11, "#2541cc" },
                    { 25, "42 EU", 100m, 10, "42" },
                    { 24, "41 EU", 50m, 10, "41" },
                    { 23, "40 EU", 0m, 10, "40" },
                    { 22, "Gray", 60m, 9, "#eeeeee" },
                    { 21, "Black", 0m, 9, "#000000" },
                    { 20, "256 GB", 3000m, 8, "256" },
                    { 19, "128 GB", 0m, 8, "128" },
                    { 18, "Silver", 70m, 7, "#F8F9F4" },
                    { 17, "Gold", 120m, 7, "#FDEFDA" },
                    { 16, "Sierra Blue", 200m, 7, "#ABBCD3" },
                    { 15, "256 GB", 3000m, 6, "256" },
                    { 14, "128 GB", 0m, 6, "128" },
                    { 13, "Silver", 70m, 5, "#F8F9F4" },
                    { 12, "Gold", 120m, 5, "#FDEFDA" },
                    { 11, "Sierra Blue", 200m, 5, "#ABBCD3" },
                    { 10, "256 GB", 3000m, 4, "256" },
                    { 9, "128 GB", 0m, 4, "128" },
                    { 8, "Silver", 70m, 3, "#F8F9F4" },
                    { 7, "Gold", 120m, 3, "#FDEFDA" },
                    { 6, "Sierra Blue", 200m, 3, "#ABBCD3" },
                    { 5, "256 GB", 3000m, 2, "256" },
                    { 4, "128 GB", 0m, 2, "128" },
                    { 3, "Silver", 70m, 1, "#F8F9F4" },
                    { 2, "Gold", 120m, 1, "#FDEFDA" },
                    { 29, "41 EU", 50m, 12, "41" },
                    { 30, "42 EU", 100m, 12, "42" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributeItems_ProductAttributeId",
                table: "ProductAttributeItems",
                column: "ProductAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductAttributes_ProductId",
                table: "ProductAttributes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_productID",
                table: "ProductImages",
                column: "productID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductsInventory_ProductID",
                table: "ProductsInventory",
                column: "ProductID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductAttributeItems");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "ProductsInventory");

            migrationBuilder.DropTable(
                name: "ProductAttributes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
