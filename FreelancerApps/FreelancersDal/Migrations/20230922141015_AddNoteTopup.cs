using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelLiveDAL.Migrations
{
    public partial class AddNoteTopup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Credit",
                table: "member",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateTable(
                name: "member_credit_movement",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ShopID = table.Column<short>(type: "smallint(6)", nullable: false),
                    MemberID = table.Column<long>(nullable: false),
                    Description = table.Column<string>(type: "varchar(150)", nullable: true),
                    BeforeBalance = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Debit = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Credit = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    AfterBalance = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_member_credit_movement", x => x.ID);
                    table.ForeignKey(
                        name: "FK_member_credit_movement_member_MemberID",
                        column: x => x.MemberID,
                        principalTable: "member",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "note",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ShopID = table.Column<short>(type: "smallint(6)", nullable: false),
                    Note = table.Column<string>(type: "text", nullable: true),
                    NoteDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_note", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "topup_plan",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ShopID = table.Column<short>(type: "smallint(6)", nullable: false),
                    PlanName = table.Column<string>(type: "varchar(100)", nullable: true),
                    Point = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    BonusPoint = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_topup_plan", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "topup",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ShopID = table.Column<short>(type: "smallint(6)", nullable: false),
                    MemberID = table.Column<long>(nullable: false),
                    TopupPlanID = table.Column<long>(nullable: false),
                    Point = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    BonusPoint = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_topup", x => x.ID);
                    table.ForeignKey(
                        name: "FK_topup_member_MemberID",
                        column: x => x.MemberID,
                        principalTable: "member",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_topup_topup_plan_TopupPlanID",
                        column: x => x.TopupPlanID,
                        principalTable: "topup_plan",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_member_credit_movement_MemberID",
                table: "member_credit_movement",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_topup_MemberID",
                table: "topup",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_topup_TopupPlanID",
                table: "topup",
                column: "TopupPlanID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "member_credit_movement");

            migrationBuilder.DropTable(
                name: "note");

            migrationBuilder.DropTable(
                name: "topup");

            migrationBuilder.DropTable(
                name: "topup_plan");

            migrationBuilder.DropColumn(
                name: "Credit",
                table: "member");
        }
    }
}
