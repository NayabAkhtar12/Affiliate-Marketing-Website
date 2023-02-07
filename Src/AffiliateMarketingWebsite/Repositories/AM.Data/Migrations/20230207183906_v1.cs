using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Data.Migrations
{
    /// <inheritdoc />
    public partial class v1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Products_Products_ProductId",
                table: "Categories_Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Products_categories_CategoryId",
                table: "Categories_Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories_Products",
                table: "Categories_Products");

            migrationBuilder.RenameTable(
                name: "Categories_Products",
                newName: "Category_Product");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_Products_ProductId",
                table: "Category_Product",
                newName: "IX_Category_Product_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_Products_CategoryId",
                table: "Category_Product",
                newName: "IX_Category_Product_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category_Product",
                table: "Category_Product",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Product_Products_ProductId",
                table: "Category_Product",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Product_categories_CategoryId",
                table: "Category_Product",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Product_Products_ProductId",
                table: "Category_Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_Product_categories_CategoryId",
                table: "Category_Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category_Product",
                table: "Category_Product");

            migrationBuilder.RenameTable(
                name: "Category_Product",
                newName: "Categories_Products");

            migrationBuilder.RenameIndex(
                name: "IX_Category_Product_ProductId",
                table: "Categories_Products",
                newName: "IX_Categories_Products_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Category_Product_CategoryId",
                table: "Categories_Products",
                newName: "IX_Categories_Products_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories_Products",
                table: "Categories_Products",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Products_Products_ProductId",
                table: "Categories_Products",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Products_categories_CategoryId",
                table: "Categories_Products",
                column: "CategoryId",
                principalTable: "categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
