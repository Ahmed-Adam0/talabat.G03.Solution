using Microsoft.EntityFrameworkCore.Migrations;

namespace talabat.DAL.Data.migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "productBrand",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productBrand", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "producttypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_producttypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    pictureurl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    productBrandId = table.Column<int>(type: "int", nullable: false),
                    producttypeid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_products_productBrand_productBrandId",
                        column: x => x.productBrandId,
                        principalTable: "productBrand",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_products_producttypes_producttypeid",
                        column: x => x.producttypeid,
                        principalTable: "producttypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_productBrandId",
                table: "products",
                column: "productBrandId");

            migrationBuilder.CreateIndex(
                name: "IX_products_producttypeid",
                table: "products",
                column: "producttypeid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "productBrand");

            migrationBuilder.DropTable(
                name: "producttypes");
        }
    }
}
