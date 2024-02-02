using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FreelancersDal.Migrations
{
    /// <inheritdoc />
    public partial class AlterDatabaseUserID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_hobbies_user_TblusersID",
                table: "user_hobbies");

            migrationBuilder.DropForeignKey(
                name: "FK_user_skillsets_user_TblusersID",
                table: "user_skillsets");

            migrationBuilder.DropIndex(
                name: "IX_user_skillsets_TblusersID",
                table: "user_skillsets");

            migrationBuilder.DropIndex(
                name: "IX_user_hobbies_TblusersID",
                table: "user_hobbies");

            migrationBuilder.DropColumn(
                name: "TblusersID",
                table: "user_skillsets");

            migrationBuilder.DropColumn(
                name: "TblusersID",
                table: "user_hobbies");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "user_skillsets",
                type: "BIGINT(20)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "user_hobbies",
                type: "BIGINT(20)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_user_skillsets_UserId",
                table: "user_skillsets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_user_hobbies_UserId",
                table: "user_hobbies",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_user_hobbies_user_UserId",
                table: "user_hobbies",
                column: "UserId",
                principalTable: "user",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_skillsets_user_UserId",
                table: "user_skillsets",
                column: "UserId",
                principalTable: "user",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_hobbies_user_UserId",
                table: "user_hobbies");

            migrationBuilder.DropForeignKey(
                name: "FK_user_skillsets_user_UserId",
                table: "user_skillsets");

            migrationBuilder.DropIndex(
                name: "IX_user_skillsets_UserId",
                table: "user_skillsets");

            migrationBuilder.DropIndex(
                name: "IX_user_hobbies_UserId",
                table: "user_hobbies");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "user_skillsets",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "BIGINT(20)");

            migrationBuilder.AddColumn<long>(
                name: "TblusersID",
                table: "user_skillsets",
                type: "BIGINT(20)",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "user_hobbies",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "BIGINT(20)");

            migrationBuilder.AddColumn<long>(
                name: "TblusersID",
                table: "user_hobbies",
                type: "BIGINT(20)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_user_skillsets_TblusersID",
                table: "user_skillsets",
                column: "TblusersID");

            migrationBuilder.CreateIndex(
                name: "IX_user_hobbies_TblusersID",
                table: "user_hobbies",
                column: "TblusersID");

            migrationBuilder.AddForeignKey(
                name: "FK_user_hobbies_user_TblusersID",
                table: "user_hobbies",
                column: "TblusersID",
                principalTable: "user",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_user_skillsets_user_TblusersID",
                table: "user_skillsets",
                column: "TblusersID",
                principalTable: "user",
                principalColumn: "ID");
        }
    }
}
