using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProjectAPI.Migrations
{
    /// <inheritdoc />
    public partial class LastUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdAdmin",
                table: "Libraries");

            migrationBuilder.DropColumn(
                name: "IdAdmin",
                table: "Groups");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "UserAccessibilities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdGroup",
                table: "UserAccessibilities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdLibrary",
                table: "UserAccessibilities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LibraryId",
                table: "UserAccessibilities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LibraryId",
                table: "Libraries",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Groups",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAccessibilities_GroupId",
                table: "UserAccessibilities",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccessibilities_LibraryId",
                table: "UserAccessibilities",
                column: "LibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_Libraries_LibraryId",
                table: "Libraries",
                column: "LibraryId");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_GroupId",
                table: "Groups",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_Groups_GroupId",
                table: "Groups",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Libraries_Libraries_LibraryId",
                table: "Libraries",
                column: "LibraryId",
                principalTable: "Libraries",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAccessibilities_Groups_GroupId",
                table: "UserAccessibilities",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAccessibilities_Libraries_LibraryId",
                table: "UserAccessibilities",
                column: "LibraryId",
                principalTable: "Libraries",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_Groups_GroupId",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_Libraries_Libraries_LibraryId",
                table: "Libraries");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAccessibilities_Groups_GroupId",
                table: "UserAccessibilities");

            migrationBuilder.DropForeignKey(
                name: "FK_UserAccessibilities_Libraries_LibraryId",
                table: "UserAccessibilities");

            migrationBuilder.DropIndex(
                name: "IX_UserAccessibilities_GroupId",
                table: "UserAccessibilities");

            migrationBuilder.DropIndex(
                name: "IX_UserAccessibilities_LibraryId",
                table: "UserAccessibilities");

            migrationBuilder.DropIndex(
                name: "IX_Libraries_LibraryId",
                table: "Libraries");

            migrationBuilder.DropIndex(
                name: "IX_Groups_GroupId",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "UserAccessibilities");

            migrationBuilder.DropColumn(
                name: "IdGroup",
                table: "UserAccessibilities");

            migrationBuilder.DropColumn(
                name: "IdLibrary",
                table: "UserAccessibilities");

            migrationBuilder.DropColumn(
                name: "LibraryId",
                table: "UserAccessibilities");

            migrationBuilder.DropColumn(
                name: "LibraryId",
                table: "Libraries");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Groups");

            migrationBuilder.AddColumn<int>(
                name: "IdAdmin",
                table: "Libraries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdAdmin",
                table: "Groups",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
