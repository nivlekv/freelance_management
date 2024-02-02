using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelLiveDAL.Migrations
{
    public partial class InitialDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "access_rights",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "varchar(100)", nullable: true),
                    Controller = table.Column<string>(type: "varchar(20)", nullable: true),
                    Action = table.Column<string>(type: "varchar(20)", nullable: true),
                    Area = table.Column<string>(type: "varchar(20)", nullable: true),
                    Locale = table.Column<string>(type: "varchar(30)", nullable: true),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_access_rights", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "admin_group",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GroupName = table.Column<string>(type: "varchar(100)", nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin_group", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "admin_log",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "varchar(20)", nullable: true),
                    Action = table.Column<short>(type: "smallint(6)", nullable: false),
                    ModelString = table.Column<string>(type: "text", nullable: true),
                    IpAddress = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin_log", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "config",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_config", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "member",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200)", nullable: true),
                    ICNo = table.Column<string>(type: "varchar(30)", nullable: true),
                    PhoneNo = table.Column<string>(type: "varchar(30)", nullable: true),
                    Email = table.Column<string>(type: "varchar(200)", nullable: true),
                    Nationality = table.Column<string>(type: "varchar(255)", nullable: true),
                    Status = table.Column<int>(nullable: false),
                    LastCheckInDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_member", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "member_log",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "varchar(20)", nullable: true),
                    Action = table.Column<short>(type: "smallint(6)", nullable: false),
                    ModelString = table.Column<string>(type: "text", nullable: true),
                    IpAddress = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_member_log", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "package",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PackageName = table.Column<string>(type: "varchar(100)", nullable: true),
                    Duration = table.Column<short>(type: "smallint(6)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Remark = table.Column<string>(type: "varchar(255)", nullable: true),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_package", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "staff",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MassauerName = table.Column<string>(type: "varchar(100)", nullable: true),
                    MassauerCode = table.Column<string>(type: "varchar(10)", nullable: true),
                    Remark = table.Column<string>(type: "varchar(255)", nullable: true),
                    Priority = table.Column<short>(type: "smallint(6)", nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staff", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "system_docnumbering",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DocCode = table.Column<string>(type: "varchar(5)", nullable: true),
                    Prefix = table.Column<string>(type: "varchar(10)", nullable: true),
                    RunningNumber = table.Column<int>(type: "int(11)", nullable: false),
                    LeadingZero = table.Column<int>(type: "int(11)", nullable: false),
                    LeadZero = table.Column<bool>(nullable: false),
                    TableName = table.Column<string>(type: "varchar(25)", nullable: true),
                    FieldName = table.Column<string>(type: "varchar(25)", nullable: true),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_system_docnumbering", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "admin",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "varchar(20)", nullable: true),
                    Password = table.Column<string>(type: "varchar(50)", nullable: true),
                    Name = table.Column<string>(type: "varchar(150)", nullable: true),
                    Email = table.Column<string>(type: "varchar(200)", nullable: true),
                    ContactNo = table.Column<string>(type: "varchar(20)", nullable: true),
                    Picture = table.Column<string>(type: "varchar(20)", nullable: true),
                    Status = table.Column<bool>(nullable: false),
                    Remark = table.Column<string>(type: "varchar(255)", nullable: true),
                    DefaultLanguage = table.Column<string>(type: "varchar(5)", nullable: true),
                    LastLoginDate = table.Column<DateTime>(nullable: false),
                    LastLoginIP = table.Column<string>(type: "varchar(20)", nullable: true),
                    GroupId = table.Column<long>(nullable: false),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin", x => x.ID);
                    table.ForeignKey(
                        name: "FK_admin_admin_group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "admin_group",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "admin_access_rights",
                columns: table => new
                {
                    ID = table.Column<long>(type: "BIGINT(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AdminGroupID = table.Column<long>(nullable: false),
                    AccessRightsID = table.Column<long>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    CreateBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "DateTime", nullable: false),
                    ModifiedBy = table.Column<string>(type: "varchar(20)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "DateTime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admin_access_rights", x => x.ID);
                    table.ForeignKey(
                        name: "FK_admin_access_rights_access_rights_AccessRightsID",
                        column: x => x.AccessRightsID,
                        principalTable: "access_rights",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_admin_access_rights_admin_group_AdminGroupID",
                        column: x => x.AdminGroupID,
                        principalTable: "admin_group",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_admin_GroupId",
                table: "admin",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_admin_access_rights_AccessRightsID",
                table: "admin_access_rights",
                column: "AccessRightsID");

            migrationBuilder.CreateIndex(
                name: "IX_admin_access_rights_AdminGroupID",
                table: "admin_access_rights",
                column: "AdminGroupID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admin");

            migrationBuilder.DropTable(
                name: "admin_access_rights");

            migrationBuilder.DropTable(
                name: "admin_log");

            migrationBuilder.DropTable(
                name: "config");

            migrationBuilder.DropTable(
                name: "member");

            migrationBuilder.DropTable(
                name: "member_log");

            migrationBuilder.DropTable(
                name: "package");

            migrationBuilder.DropTable(
                name: "staff");

            migrationBuilder.DropTable(
                name: "system_docnumbering");

            migrationBuilder.DropTable(
                name: "access_rights");

            migrationBuilder.DropTable(
                name: "admin_group");
        }
    }
}
