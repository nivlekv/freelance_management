using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelLiveDAL.Migrations
{
    public partial class AlterComissionRateMassauers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "massauer_comission",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MassauerID = table.Column<long>(nullable: false),
                    ComissionType = table.Column<int>(nullable: false),
                    MinValue = table.Column<int>(type: "int(11)", nullable: false),
                    MaxValue = table.Column<int>(type: "int(11)", nullable: false),
                    ComissionRate = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ComissionRateBooked = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ComissionRateOther = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ComissionRateOtherBooked = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    TblMassauerID = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_massauer_comission", x => x.ID);
                    table.ForeignKey(
                        name: "FK_massauer_comission_massauer_TblMassauerID",
                        column: x => x.TblMassauerID,
                        principalTable: "massauer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_massauer_comission_TblMassauerID",
                table: "massauer_comission",
                column: "TblMassauerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "massauer_comission");
        }
    }
}
