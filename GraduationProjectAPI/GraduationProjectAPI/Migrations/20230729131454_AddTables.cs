using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProjectAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Libraries",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Groups",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "type",
                table: "Complaints",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Buybooks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Accessibilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessibilityType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accessibilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    answer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CorrectAnswer = table.Column<bool>(type: "bit", nullable: false),
                    IdTest = table.Column<int>(type: "int", nullable: true),
                    TestId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Tests_TestId",
                        column: x => x.TestId,
                        principalTable: "Tests",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserAccessibilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminOn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdAccessibility = table.Column<int>(type: "int", nullable: true),
                    AccessibilityId = table.Column<int>(type: "int", nullable: true),
                    IdUser = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccessibilities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAccessibilities_Accessibilities_AccessibilityId",
                        column: x => x.AccessibilityId,
                        principalTable: "Accessibilities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserAccessibilities_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_TestId",
                table: "Answers",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccessibilities_AccessibilityId",
                table: "UserAccessibilities",
                column: "AccessibilityId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccessibilities_UserId",
                table: "UserAccessibilities",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "UserAccessibilities");

            migrationBuilder.DropTable(
                name: "Accessibilities");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Libraries");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "type",
                table: "Complaints");

            migrationBuilder.DropColumn(
                name: "Count",
                table: "Buybooks");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Books");
        }
    }
}
