using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelLiveDAL.Migrations
{
    public partial class AlterShopItemDisplay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "ItemDisplay",
                table: "shop",
                type: "smallint(6)",
                nullable: false,
                defaultValue: (short)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemDisplay",
                table: "shop");
        }
    }
}
