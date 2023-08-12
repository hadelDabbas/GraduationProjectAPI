using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GraduationProjectAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedsComplaint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminOn",
                table: "UserAccessibilities");

            migrationBuilder.DropColumn(
                name: "IdAdmin",
                table: "Tests");

            migrationBuilder.DropColumn(
                name: "IdAdmin",
                table: "References");

            migrationBuilder.DropColumn(
                name: "dateTime",
                table: "References");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Libraries");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Groups");

            migrationBuilder.InsertData(
                table: "Complaints",
                columns: new[] { "Id", "IdUser", "UserId", "complaint", "type" },
                values: new object[,]
                {
                    { 1, 2, null, "Please accept my request to join the group", 0 },
                    { 2, 2, null, "I want to have admin authority", 1 },
                    { 3, 2, null, "Please allow me to add new content", 2 },
                    { 4, 3, null, "Please accept my request to join the group", 0 },
                    { 5, 3, null, "I want to have admin authority", 1 },
                    { 6, 3, null, "Please allow me to add new content", 2 },
                    { 7, 4, null, "Please accept my request to join the group", 0 },
                    { 8, 4, null, "I want to have admin authority", 1 },
                    { 9, 4, null, "Please allow me to add new content", 2 },
                    { 10, 5, null, "Please accept my request to join the group", 0 },
                    { 11, 5, null, "I want to have admin authority", 1 },
                    { 12, 5, null, "Please allow me to add new content", 2 }
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5130));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5171));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5332));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5354));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5462));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5487));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5509));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5551));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5595));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5616));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5892));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5919));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5940));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5961));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(5982));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(6003));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 21, 40, 33, 980, DateTimeKind.Local).AddTicks(6050));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Complaints",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Complaints",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Complaints",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Complaints",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Complaints",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Complaints",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Complaints",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Complaints",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Complaints",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Complaints",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Complaints",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Complaints",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.AddColumn<string>(
                name: "AdminOn",
                table: "UserAccessibilities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.AddColumn<DateTime>(
                name: "dateTime",
                table: "References",
                type: "datetime2",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9611));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9631));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9660));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9720));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9742));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9851));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9913));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9922));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41,
                column: "dateTime",
                value: new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(31));

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IdAdmin", "dateTime" },
                values: new object[] { 0, new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4345) });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IdAdmin", "dateTime" },
                values: new object[] { 0, new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4368) });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IdAdmin", "dateTime" },
                values: new object[] { 0, new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4378) });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IdAdmin", "dateTime" },
                values: new object[] { 0, new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IdAdmin", "dateTime" },
                values: new object[] { 0, new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4396) });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IdAdmin", "dateTime" },
                values: new object[] { 0, new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4406) });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IdAdmin", "dateTime" },
                values: new object[] { 0, new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4416) });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IdAdmin", "dateTime" },
                values: new object[] { 0, new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IdAdmin", "dateTime" },
                values: new object[] { 0, new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IdAdmin", "dateTime" },
                values: new object[] { 0, new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4489) });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IdAdmin", "dateTime" },
                values: new object[] { 0, new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4499) });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IdAdmin", "dateTime" },
                values: new object[] { 0, new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4508) });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IdAdmin", "dateTime" },
                values: new object[] { 0, new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4518) });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IdAdmin", "dateTime" },
                values: new object[] { 0, new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4528) });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IdAdmin", "dateTime" },
                values: new object[] { 0, new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4537) });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IdAdmin", "dateTime" },
                values: new object[] { 0, new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "References",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IdAdmin", "dateTime" },
                values: new object[] { 0, new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "UserAccessibilities",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdminOn",
                value: "Null");

            migrationBuilder.UpdateData(
                table: "UserAccessibilities",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdminOn",
                value: "Null");

            migrationBuilder.UpdateData(
                table: "UserAccessibilities",
                keyColumn: "Id",
                keyValue: 3,
                column: "AdminOn",
                value: "Null");

            migrationBuilder.UpdateData(
                table: "UserAccessibilities",
                keyColumn: "Id",
                keyValue: 4,
                column: "AdminOn",
                value: "null");

            migrationBuilder.UpdateData(
                table: "UserAccessibilities",
                keyColumn: "Id",
                keyValue: 5,
                column: "AdminOn",
                value: "null");
        }
    }
}
