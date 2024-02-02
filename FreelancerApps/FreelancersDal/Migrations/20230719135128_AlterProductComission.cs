using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelLiveDAL.Migrations
{
    public partial class AlterProductComission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Comission",
                table: "product",
                type: "decimal(8,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comission",
                table: "product");
        }
    }
}
