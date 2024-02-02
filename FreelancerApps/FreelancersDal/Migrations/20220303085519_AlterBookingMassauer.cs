using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelLiveDAL.Migrations
{
    public partial class AlterBookingMassauer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MemberType",
                table: "member",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "massauer",
                type: "varchar(150)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CheckupDate",
                table: "massauer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ContactNo",
                table: "massauer",
                type: "varchar(30)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateJoin",
                table: "massauer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FinNo",
                table: "massauer",
                type: "varchar(30)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Discount",
                table: "booking",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "GrandTotal",
                table: "booking",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "PaymentType",
                table: "booking",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MemberType",
                table: "member");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "massauer");

            migrationBuilder.DropColumn(
                name: "CheckupDate",
                table: "massauer");

            migrationBuilder.DropColumn(
                name: "ContactNo",
                table: "massauer");

            migrationBuilder.DropColumn(
                name: "DateJoin",
                table: "massauer");

            migrationBuilder.DropColumn(
                name: "FinNo",
                table: "massauer");

            migrationBuilder.DropColumn(
                name: "Discount",
                table: "booking");

            migrationBuilder.DropColumn(
                name: "GrandTotal",
                table: "booking");

            migrationBuilder.DropColumn(
                name: "PaymentType",
                table: "booking");
        }
    }
}
