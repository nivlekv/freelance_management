using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelLiveDAL.Migrations
{
    public partial class AlterTopupPaymentBookingPayment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentType",
                table: "topup",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "booking_package",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BookingID = table.Column<long>(nullable: false),
                    PackageID = table.Column<long>(nullable: false),
                    MassauerID = table.Column<long>(nullable: false),
                    PackageName = table.Column<string>(type: "varchar(100)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Duration = table.Column<int>(type: "int(11)", nullable: false),
                    ComissionRate = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Comission = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Bonus = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    TblPackagesID = table.Column<long>(nullable: true),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booking_package", x => x.ID);
                    table.ForeignKey(
                        name: "FK_booking_package_booking_BookingID",
                        column: x => x.BookingID,
                        principalTable: "booking",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_booking_package_massauer_MassauerID",
                        column: x => x.MassauerID,
                        principalTable: "massauer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_booking_package_package_TblPackagesID",
                        column: x => x.TblPackagesID,
                        principalTable: "package",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "booking_payment",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    BookingID = table.Column<long>(nullable: false),
                    PaymentType = table.Column<int>(nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    PaymentBy = table.Column<string>(nullable: true),
                    PaymentAmount = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booking_payment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_booking_payment_booking_BookingID",
                        column: x => x.BookingID,
                        principalTable: "booking",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_booking_package_BookingID",
                table: "booking_package",
                column: "BookingID");

            migrationBuilder.CreateIndex(
                name: "IX_booking_package_MassauerID",
                table: "booking_package",
                column: "MassauerID");

            migrationBuilder.CreateIndex(
                name: "IX_booking_package_TblPackagesID",
                table: "booking_package",
                column: "TblPackagesID");

            migrationBuilder.CreateIndex(
                name: "IX_booking_payment_BookingID",
                table: "booking_payment",
                column: "BookingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "booking_package");

            migrationBuilder.DropTable(
                name: "booking_payment");

            migrationBuilder.DropColumn(
                name: "PaymentType",
                table: "topup");
        }
    }
}
