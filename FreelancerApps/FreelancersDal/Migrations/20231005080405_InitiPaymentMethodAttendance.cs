using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelLiveDAL.Migrations
{
    public partial class InitiPaymentMethodAttendance : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "massauer_attendance",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ShopID = table.Column<short>(type: "smallint(6)", nullable: false),
                    AttendanceDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    MassauerID = table.Column<long>(nullable: false),
                    Priority = table.Column<short>(type: "smallint(6)", nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_massauer_attendance", x => x.ID);
                    table.ForeignKey(
                        name: "FK_massauer_attendance_massauer_MassauerID",
                        column: x => x.MassauerID,
                        principalTable: "massauer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "payment_method",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ShopID = table.Column<short>(type: "smallint(6)", nullable: false),
                    PaymentMethod = table.Column<int>(nullable: false),
                    Description = table.Column<string>(type: "varchar(50)", nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payment_method", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_massauer_attendance_MassauerID",
                table: "massauer_attendance",
                column: "MassauerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "massauer_attendance");

            migrationBuilder.DropTable(
                name: "payment_method");
        }
    }
}
