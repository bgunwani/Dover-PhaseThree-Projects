using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace coreDatabaseApproachApplication.Migrations
{
    public partial class InitialMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Brand",
            //    columns: table => new
            //    {
            //        BrandId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        BrandName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
            //        BrandDesc = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
            //        BrandAddedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Brand", x => x.BrandId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Category",
            //    columns: table => new
            //    {
            //        CategoryId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        CategoryName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
            //        CategoryDesc = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
            //        CategoryAddedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Category", x => x.CategoryId);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Product",
            //    columns: table => new
            //    {
            //        ProductId = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        ProductName = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
            //        ProductDesc = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
            //        ProductPrice = table.Column<double>(type: "float", nullable: true),
            //        ProductImage = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
            //        ProductAddedDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
            //        CategoryId = table.Column<int>(type: "int", nullable: true),
            //        BrandId = table.Column<int>(type: "int", nullable: true),
            //        ProductQuantity = table.Column<int>(type: "int", nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Product", x => x.ProductId);
            //        table.ForeignKey(
            //            name: "FK__Product__BrandId__38996AB5",
            //            column: x => x.BrandId,
            //            principalTable: "Brand",
            //            principalColumn: "BrandId",
            //            onDelete: ReferentialAction.Restrict);
            //        table.ForeignKey(
            //            name: "FK__Product__Categor__37A5467C",
            //            column: x => x.CategoryId,
            //            principalTable: "Category",
            //            principalColumn: "CategoryId",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Product_BrandId",
            //    table: "Product",
            //    column: "BrandId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_Product_CategoryId",
            //    table: "Product",
            //    column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable(
            //    name: "Product");

            //migrationBuilder.DropTable(
            //    name: "Brand");

            //migrationBuilder.DropTable(
            //    name: "Category");
        }
    }
}
