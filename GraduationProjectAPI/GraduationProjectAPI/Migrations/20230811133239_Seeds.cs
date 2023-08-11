using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GraduationProjectAPI.Migrations
{
    /// <inheritdoc />
    public partial class Seeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Address", "Age", "Description", "Email", "Image", "Name", "Password", "Paypal", "Phone", "Study", "UserName" },
                values: new object[,]
                {
                    { 1, "Null", "100", "Null", "Admin@gmail.com", null, "Admin", "Admin", "Null", "Null", "Null", "Admin" },
                    { 2, "ALfurkan next to SeriaTell", "22", "Love Life", "AsiaBadenjki@gmail.com", null, "Asia Badenjki", "0000", "123451", "0911223344", "Information Technology", "Asia21" },
                    { 3, "Halab Aljadeda", "23", "Enjoy ALL Day", "HayaYousfi@gmail.com", null, "Haya Yousfi", "1111", "123452", "0922113344", "Information Technology", "Haya22" },
                    { 4, "ALfourkan", "18", "Be Happy", "Hamzi18@gmail.com", null, "Hamze Badenjki", "2222", "123453", "0922553344", "HighSchool", "Hamze18" },
                    { 5, "ALShahba Aljadeda", "35", "null", "JawadMohammad@gmail.com", null, "Jawad Mohammad", "3333", "123454", "0922553377", "Null", "Jawad35" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
