using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelLiveDAL.Migrations
{
    public partial class AlterMassuerBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_staff",
                table: "staff");

            migrationBuilder.RenameTable(
                name: "staff",
                newName: "massauer");

            migrationBuilder.AddColumn<decimal>(
                name: "ComissionRate",
                table: "massauer",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddPrimaryKey(
                name: "PK_massauer",
                table: "massauer",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_massauer",
                table: "massauer");

            migrationBuilder.DropColumn(
                name: "ComissionRate",
                table: "massauer");

            migrationBuilder.RenameTable(
                name: "massauer",
                newName: "staff");

            migrationBuilder.AddPrimaryKey(
                name: "PK_staff",
                table: "staff",
                column: "ID");
        }
    }
}
