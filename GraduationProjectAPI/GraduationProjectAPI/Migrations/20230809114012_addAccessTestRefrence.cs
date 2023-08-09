using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProjectAPI.Migrations
{
    /// <inheritdoc />
    public partial class addAccessTestRefrence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdReference",
                table: "UserAccessibilities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdTest",
                table: "UserAccessibilities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReferenceId",
                table: "UserAccessibilities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TestId",
                table: "UserAccessibilities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAccessibilities_ReferenceId",
                table: "UserAccessibilities",
                column: "ReferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccessibilities_TestId",
                table: "UserAccessibilities",
                column: "TestId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAccessibilities_References_ReferenceId",
                table: "UserAccessibilities",
                column: "ReferenceId",
                principalTable: "References",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAccessibilities_Tests_TestId",
                table: "UserAccessibilities",
                column: "TestId",
                principalTable: "Tests",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAccessibilities_References_ReferenceId",
                table: "UserAccessibilities");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAccessibilities_Tests_TestId",
                table: "UserAccessibilities");

            migrationBuilder.DropIndex(
                name: "IX_UserAccessibilities_ReferenceId",
                table: "UserAccessibilities");

            migrationBuilder.DropIndex(
                name: "IX_UserAccessibilities_TestId",
                table: "UserAccessibilities");

            migrationBuilder.DropColumn(
                name: "IdReference",
                table: "UserAccessibilities");

            migrationBuilder.DropColumn(
                name: "IdTest",
                table: "UserAccessibilities");

            migrationBuilder.DropColumn(
                name: "ReferenceId",
                table: "UserAccessibilities");

            migrationBuilder.DropColumn(
                name: "TestId",
                table: "UserAccessibilities");
        }
    }
}
