using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GraduationProjectAPI.Migrations
{
    /// <inheritdoc />
    public partial class MoreSeeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserGroups_Posts_PostId",
                table: "UserGroups");

            migrationBuilder.DropIndex(
                name: "IX_UserGroups_PostId",
                table: "UserGroups");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "UserGroups");

            migrationBuilder.InsertData(
                table: "Accessibilities",
                columns: new[] { "Id", "AccessibilityType" },
                values: new object[,]
                {
                    { 1, "All" },
                    { 2, "Add" },
                    { 3, "Update" },
                    { 4, "Delete" }
                });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "typeName" },
                values: new object[,]
                {
                    { 1, "History" },
                    { 2, "Geography" },
                    { 3, "Medicine" },
                    { 4, "Technology" },
                    { 5, "Literature" }
                });

            migrationBuilder.InsertData(
                table: "Follows",
                columns: new[] { "Id", "followId", "followedId" },
                values: new object[,]
                {
                    { 1, 2, 3 },
                    { 2, 2, 4 },
                    { 3, 2, 5 },
                    { 4, 3, 2 },
                    { 5, 3, 4 },
                    { 6, 3, 5 },
                    { 7, 4, 2 },
                    { 8, 4, 3 },
                    { 9, 4, 5 },
                    { 10, 5, 2 },
                    { 11, 5, 3 },
                    { 12, 5, 4 }
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "ContentId", "Description", "IdContent", "Image", "IsDeleted", "groupName" },
                values: new object[,]
                {
                    { 1, null, "A Group Of People Interested in History", 1, null, false, "The Histoicals" },
                    { 2, null, "A Group Of People Interested in Geography", 2, null, false, "The Geographiest" },
                    { 3, null, "A Group Of People Interested in Medicine", 3, null, false, "Medicine Informations" },
                    { 4, null, "A Group Of People Interested in Technology", 4, null, false, "Technology" },
                    { 5, null, "A Group Of People Interested in Literature", 5, null, false, "The Literature " }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accessibilities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Accessibilities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Accessibilities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Accessibilities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Follows",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "UserGroups",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserGroups_PostId",
                table: "UserGroups",
                column: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserGroups_Posts_PostId",
                table: "UserGroups",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");
        }
    }
}
