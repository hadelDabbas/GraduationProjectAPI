using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProjectAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminAttribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Admin",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "IdAdmin",
                table: "Tests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdAdmin",
                table: "References",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdAdmin",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "IdAdmin",
                table: "References");

            migrationBuilder.DropColumn(
                name: "IdAdmin",
                table: "Libraries");

            migrationBuilder.DropColumn(
                name: "IdAdmin",
                table: "Groups");

            migrationBuilder.AddColumn<string>(
                name: "Admin",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
