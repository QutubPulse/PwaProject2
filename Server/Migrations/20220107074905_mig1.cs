using Microsoft.EntityFrameworkCore.Migrations;

namespace PwaProject2.Server.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    inId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dcPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    stDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    stDiscount = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    inQuantity = table.Column<int>(type: "int", nullable: true),
                    flgOutOfStock = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.inId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
