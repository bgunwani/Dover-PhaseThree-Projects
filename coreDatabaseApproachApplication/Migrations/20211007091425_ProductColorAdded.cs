using Microsoft.EntityFrameworkCore.Migrations;

namespace coreDatabaseApproachApplication.Migrations
{
    public partial class ProductColorAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProductColor",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductColor",
                table: "Product");
        }
    }
}
