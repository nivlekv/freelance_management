using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelLiveDAL.Migrations
{
    public partial class AlterBookingPackage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_booking_package_package_TblPackagesID",
                table: "booking_package");

            migrationBuilder.DropIndex(
                name: "IX_booking_package_TblPackagesID",
                table: "booking_package");

            migrationBuilder.DropColumn(
                name: "TblPackagesID",
                table: "booking_package");

            migrationBuilder.AlterColumn<long>(
                name: "PackageID",
                table: "booking_package",
                type: "bigint(20)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "PackageID",
                table: "booking_package",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint(20)");

            migrationBuilder.AddColumn<long>(
                name: "TblPackagesID",
                table: "booking_package",
                type: "BIGINT(20)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_booking_package_TblPackagesID",
                table: "booking_package",
                column: "TblPackagesID");

            migrationBuilder.AddForeignKey(
                name: "FK_booking_package_package_TblPackagesID",
                table: "booking_package",
                column: "TblPackagesID",
                principalTable: "package",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
