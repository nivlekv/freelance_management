using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelLiveDAL.Migrations
{
    public partial class AlterMeemberRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MemberRole",
                table: "member",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MemberRole",
                table: "member");
        }
    }
}
