using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraduationProjectAPI.Migrations
{
    /// <inheritdoc />
    public partial class fixErrorBuyBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buybooks_Libraries_LibraryId",
                table: "Buybooks");

            migrationBuilder.RenameColumn(
                name: "LibraryId",
                table: "Buybooks",
                newName: "BookLibraryId");

            migrationBuilder.RenameColumn(
                name: "IdLibrary",
                table: "Buybooks",
                newName: "IdBookLibrary");

            migrationBuilder.RenameIndex(
                name: "IX_Buybooks_LibraryId",
                table: "Buybooks",
                newName: "IX_Buybooks_BookLibraryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Buybooks_BookLibraries_BookLibraryId",
                table: "Buybooks",
                column: "BookLibraryId",
                principalTable: "BookLibraries",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buybooks_BookLibraries_BookLibraryId",
                table: "Buybooks");

            migrationBuilder.RenameColumn(
                name: "IdBookLibrary",
                table: "Buybooks",
                newName: "IdLibrary");

            migrationBuilder.RenameColumn(
                name: "BookLibraryId",
                table: "Buybooks",
                newName: "LibraryId");

            migrationBuilder.RenameIndex(
                name: "IX_Buybooks_BookLibraryId",
                table: "Buybooks",
                newName: "IX_Buybooks_LibraryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Buybooks_Libraries_LibraryId",
                table: "Buybooks",
                column: "LibraryId",
                principalTable: "Libraries",
                principalColumn: "Id");
        }
    }
}
