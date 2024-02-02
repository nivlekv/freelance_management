using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelLiveDAL.Migrations
{
    public partial class CreateProductBookingProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ShopID = table.Column<short>(type: "smallint(6)", nullable: false),
                    ProductName = table.Column<string>(type: "varchar(100)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Remark = table.Column<string>(type: "varchar(255)", nullable: true),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "booking_product",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BookingID = table.Column<long>(nullable: false),
                    ProductID = table.Column<long>(nullable: false),
                    ProductName = table.Column<string>(type: "varchar(100)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booking_product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_booking_product_booking_BookingID",
                        column: x => x.BookingID,
                        principalTable: "booking",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_booking_product_product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_booking_product_BookingID",
                table: "booking_product",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_booking_product_ProductID",
                table: "booking_product",
                column: "ProductID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "booking_product");

            migrationBuilder.DropTable(
                name: "product");
        }
    }
}
