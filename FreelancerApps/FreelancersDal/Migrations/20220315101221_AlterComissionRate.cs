using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelLiveDAL.Migrations
{
    public partial class AlterComissionRate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PackageType",
                table: "package",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BonusType",
                table: "massauer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "ComissionRateOther",
                table: "massauer",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ComissionRateOtherBooked",
                table: "massauer",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "ComissionType",
                table: "massauer",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PackageType",
                table: "package");

            migrationBuilder.DropColumn(
                name: "BonusType",
                table: "massauer");

            migrationBuilder.DropColumn(
                name: "ComissionRateOther",
                table: "massauer");

            migrationBuilder.DropColumn(
                name: "ComissionRateOtherBooked",
                table: "massauer");

            migrationBuilder.DropColumn(
                name: "ComissionType",
                table: "massauer");
        }
    }
}
