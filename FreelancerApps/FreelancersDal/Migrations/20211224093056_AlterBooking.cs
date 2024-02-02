using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelLiveDAL.Migrations
{
    public partial class AlterBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "booking",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ShopID = table.Column<short>(type: "smallint(6)", nullable: false),
                    MemberID = table.Column<long>(nullable: false),
                    PackageID = table.Column<long>(nullable: false),
                    MassauersID = table.Column<long>(nullable: false),
                    Duration = table.Column<int>(type: "int(11)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ComissionRate = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Comission = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CheckOutDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<int>(nullable: false),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_booking", x => x.ID);
                    table.ForeignKey(
                        name: "FK_booking_massauer_MassauersID",
                        column: x => x.MassauersID,
                        principalTable: "massauer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_booking_member_MemberID",
                        column: x => x.MemberID,
                        principalTable: "member",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_booking_package_PackageID",
                        column: x => x.PackageID,
                        principalTable: "package",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_booking_MassauersID",
                table: "booking",
                column: "MassauersID");

            migrationBuilder.CreateIndex(
                name: "IX_booking_MemberID",
                table: "booking",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_booking_PackageID",
                table: "booking",
                column: "PackageID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "booking");
        }
    }
}
