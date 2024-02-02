using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelLiveDAL.Migrations
{
    public partial class AlterMassuaerComission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_massauer_comission_massauer_TblMassauerID",
                table: "massauer_comission");

            migrationBuilder.DropIndex(
                name: "IX_massauer_comission_TblMassauerID",
                table: "massauer_comission");

            migrationBuilder.DropColumn(
                name: "TblMassauerID",
                table: "massauer_comission");

            migrationBuilder.AlterColumn<long>(
                name: "MassauerID",
                table: "massauer_comission",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_massauer_comission_MassauerID",
                table: "massauer_comission",
                column: "MassauerID");

            migrationBuilder.AddForeignKey(
                name: "FK_massauer_comission_massauer_MassauerID",
                table: "massauer_comission",
                column: "MassauerID",
                principalTable: "massauer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_massauer_comission_massauer_MassauerID",
                table: "massauer_comission");

            migrationBuilder.DropIndex(
                name: "IX_massauer_comission_MassauerID",
                table: "massauer_comission");

            migrationBuilder.AlterColumn<long>(
                name: "MassauerID",
                table: "massauer_comission",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AddColumn<long>(
                name: "TblMassauerID",
                table: "massauer_comission",
                type: "BIGINT(20)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_massauer_comission_TblMassauerID",
                table: "massauer_comission",
                column: "TblMassauerID");

            migrationBuilder.AddForeignKey(
                name: "FK_massauer_comission_massauer_TblMassauerID",
                table: "massauer_comission",
                column: "TblMassauerID",
                principalTable: "massauer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
