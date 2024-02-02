using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelLiveDAL.Migrations
{
    public partial class InitialPackageColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Color",
                table: "package",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "package");
        }
    }
}
