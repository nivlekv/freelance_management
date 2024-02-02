using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelLiveDAL.Migrations
{
    public partial class AlterShopID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<short>(
                name: "ShopID",
                table: "system_docnumbering",
                type: "smallint(6)",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "ShopID",
                table: "staff",
                type: "smallint(6)",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "ShopID",
                table: "package",
                type: "smallint(6)",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "ShopID",
                table: "member",
                type: "smallint(6)",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "ShopID",
                table: "admin_log",
                type: "smallint(6)",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "ShopID",
                table: "admin_group",
                type: "smallint(6)",
                nullable: false,
                defaultValue: (short)0);

            migrationBuilder.AddColumn<short>(
                name: "ShopID",
                table: "admin",
                type: "smallint(6)",
                nullable: false,
                defaultValue: (short)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShopID",
                table: "system_docnumbering");

            migrationBuilder.DropColumn(
                name: "ShopID",
                table: "staff");

            migrationBuilder.DropColumn(
                name: "ShopID",
                table: "package");

            migrationBuilder.DropColumn(
                name: "ShopID",
                table: "member");

            migrationBuilder.DropColumn(
                name: "ShopID",
                table: "admin_log");

            migrationBuilder.DropColumn(
                name: "ShopID",
                table: "admin_group");

            migrationBuilder.DropColumn(
                name: "ShopID",
                table: "admin");
        }
    }
}
