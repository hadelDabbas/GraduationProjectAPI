using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GraduationProjectAPI.Migrations
{
    /// <inheritdoc />
    public partial class seeds3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BookLibraries",
                columns: new[] { "Id", "BookId", "IdBook", "IdLibrary", "IsDeleted", "LibraryId" },
                values: new object[,]
                {
                    { 1, null, 1, 1, false, null },
                    { 2, null, 2, 1, false, null },
                    { 3, null, 3, 1, false, null },
                    { 4, null, 4, 1, false, null },
                    { 5, null, 5, 1, false, null },
                    { 6, null, 6, 1, false, null },
                    { 7, null, 7, 1, false, null },
                    { 8, null, 8, 1, false, null },
                    { 9, null, 9, 1, false, null },
                    { 10, null, 10, 1, false, null },
                    { 11, null, 11, 1, false, null },
                    { 12, null, 12, 1, false, null },
                    { 13, null, 13, 1, false, null },
                    { 14, null, 14, 1, false, null },
                    { 15, null, 15, 1, false, null },
                    { 16, null, 16, 1, false, null },
                    { 17, null, 17, 1, false, null },
                    { 18, null, 18, 1, false, null },
                    { 19, null, 19, 1, false, null },
                    { 20, null, 20, 1, false, null },
                    { 21, null, 21, 1, false, null },
                    { 22, null, 22, 1, false, null },
                    { 23, null, 23, 1, false, null },
                    { 24, null, 24, 1, false, null },
                    { 25, null, 25, 1, false, null },
                    { 26, null, 26, 1, false, null },
                    { 27, null, 27, 1, false, null },
                    { 28, null, 28, 1, false, null },
                    { 29, null, 29, 1, false, null },
                    { 30, null, 30, 1, false, null },
                    { 31, null, 31, 1, false, null },
                    { 32, null, 32, 1, false, null },
                    { 33, null, 33, 1, false, null },
                    { 34, null, 34, 1, false, null },
                    { 35, null, 35, 1, false, null },
                    { 36, null, 36, 1, false, null },
                    { 37, null, 37, 1, false, null },
                    { 38, null, 38, 1, false, null },
                    { 39, null, 39, 1, false, null },
                    { 40, null, 40, 1, false, null },
                    { 41, null, 1, 2, false, null },
                    { 42, null, 2, 2, false, null },
                    { 43, null, 3, 2, false, null },
                    { 44, null, 4, 2, false, null },
                    { 45, null, 5, 2, false, null },
                    { 46, null, 6, 2, false, null },
                    { 47, null, 7, 2, false, null },
                    { 48, null, 8, 2, false, null },
                    { 49, null, 9, 2, false, null },
                    { 50, null, 10, 2, false, null },
                    { 51, null, 11, 2, false, null },
                    { 52, null, 12, 2, false, null },
                    { 53, null, 13, 2, false, null },
                    { 54, null, 14, 2, false, null },
                    { 55, null, 15, 2, false, null },
                    { 56, null, 16, 2, false, null },
                    { 57, null, 17, 2, false, null },
                    { 58, null, 18, 2, false, null },
                    { 59, null, 19, 2, false, null },
                    { 60, null, 20, 2, false, null },
                    { 61, null, 21, 2, false, null },
                    { 62, null, 22, 2, false, null },
                    { 63, null, 23, 2, false, null },
                    { 64, null, 24, 2, false, null },
                    { 65, null, 25, 2, false, null },
                    { 66, null, 26, 2, false, null },
                    { 67, null, 27, 2, false, null },
                    { 68, null, 28, 2, false, null },
                    { 69, null, 29, 2, false, null },
                    { 70, null, 30, 2, false, null },
                    { 71, null, 31, 2, false, null },
                    { 72, null, 32, 2, false, null },
                    { 73, null, 33, 2, false, null },
                    { 74, null, 34, 2, false, null },
                    { 75, null, 35, 2, false, null },
                    { 76, null, 36, 2, false, null },
                    { 77, null, 37, 2, false, null },
                    { 78, null, 38, 2, false, null },
                    { 79, null, 39, 2, false, null },
                    { 80, null, 40, 2, false, null },
                    { 81, null, 1, 3, false, null },
                    { 82, null, 2, 3, false, null },
                    { 83, null, 3, 3, false, null },
                    { 84, null, 4, 3, false, null },
                    { 85, null, 5, 3, false, null },
                    { 86, null, 6, 3, false, null },
                    { 87, null, 7, 3, false, null },
                    { 88, null, 8, 3, false, null },
                    { 89, null, 9, 3, false, null },
                    { 90, null, 10, 3, false, null },
                    { 91, null, 11, 3, false, null },
                    { 92, null, 12, 3, false, null },
                    { 93, null, 13, 3, false, null },
                    { 94, null, 14, 3, false, null },
                    { 95, null, 15, 3, false, null },
                    { 96, null, 16, 3, false, null },
                    { 97, null, 17, 3, false, null },
                    { 98, null, 18, 3, false, null },
                    { 99, null, 19, 3, false, null },
                    { 100, null, 20, 3, false, null },
                    { 101, null, 21, 3, false, null },
                    { 102, null, 22, 3, false, null },
                    { 103, null, 23, 3, false, null },
                    { 104, null, 24, 3, false, null },
                    { 105, null, 25, 3, false, null },
                    { 106, null, 26, 3, false, null },
                    { 107, null, 27, 3, false, null },
                    { 108, null, 28, 3, false, null },
                    { 109, null, 29, 3, false, null },
                    { 110, null, 30, 3, false, null },
                    { 111, null, 31, 3, false, null },
                    { 112, null, 32, 3, false, null },
                    { 113, null, 33, 3, false, null },
                    { 114, null, 34, 3, false, null },
                    { 115, null, 35, 3, false, null },
                    { 116, null, 36, 3, false, null },
                    { 117, null, 37, 3, false, null },
                    { 118, null, 38, 3, false, null },
                    { 119, null, 39, 3, false, null },
                    { 120, null, 40, 3, false, null },
                    { 121, null, 1, 4, false, null },
                    { 122, null, 2, 4, false, null },
                    { 123, null, 3, 4, false, null },
                    { 124, null, 4, 4, false, null },
                    { 125, null, 5, 4, false, null },
                    { 126, null, 6, 4, false, null },
                    { 127, null, 7, 4, false, null },
                    { 128, null, 8, 4, false, null },
                    { 129, null, 9, 4, false, null },
                    { 130, null, 10, 4, false, null },
                    { 131, null, 11, 4, false, null },
                    { 132, null, 12, 4, false, null },
                    { 133, null, 13, 4, false, null },
                    { 134, null, 14, 4, false, null },
                    { 135, null, 15, 4, false, null },
                    { 136, null, 16, 4, false, null },
                    { 137, null, 17, 4, false, null },
                    { 138, null, 18, 4, false, null },
                    { 139, null, 19, 4, false, null },
                    { 140, null, 20, 4, false, null },
                    { 141, null, 21, 4, false, null },
                    { 142, null, 22, 4, false, null },
                    { 143, null, 23, 4, false, null },
                    { 144, null, 24, 4, false, null },
                    { 145, null, 25, 4, false, null },
                    { 146, null, 26, 4, false, null },
                    { 147, null, 27, 4, false, null },
                    { 148, null, 28, 4, false, null },
                    { 149, null, 29, 4, false, null },
                    { 150, null, 30, 4, false, null },
                    { 151, null, 31, 4, false, null },
                    { 152, null, 32, 4, false, null },
                    { 153, null, 33, 4, false, null },
                    { 154, null, 34, 4, false, null },
                    { 155, null, 35, 4, false, null },
                    { 156, null, 36, 4, false, null },
                    { 157, null, 37, 4, false, null },
                    { 158, null, 38, 4, false, null },
                    { 159, null, 39, 4, false, null },
                    { 160, null, 40, 4, false, null }
                });

            migrationBuilder.InsertData(
                table: "BookTypes",
                columns: new[] { "Id", "IsDeleted", "bookType" },
                values: new object[,]
                {
                    { 1, false, "Self Development" },
                    { 2, false, "Police Novels" },
                    { 3, false, "Psychology" },
                    { 4, false, "Marketing" },
                    { 5, false, "History" },
                    { 6, false, "Sport" }
                });

            migrationBuilder.InsertData(
                table: "BookWriters",
                columns: new[] { "Id", "BookId", "IdBook", "IdWriter", "IsDeleted", "WriterId" },
                values: new object[,]
                {
                    { 1, null, 1, 1, false, null },
                    { 2, null, 2, 2, false, null },
                    { 3, null, 3, 3, false, null },
                    { 4, null, 4, 4, false, null },
                    { 5, null, 5, 5, false, null },
                    { 6, null, 6, 6, false, null },
                    { 7, null, 7, 7, false, null },
                    { 8, null, 8, 8, false, null },
                    { 9, null, 9, 9, false, null },
                    { 10, null, 10, 10, false, null },
                    { 11, null, 11, 11, false, null },
                    { 12, null, 12, 12, false, null },
                    { 13, null, 15, 12, false, null },
                    { 14, null, 13, 13, false, null },
                    { 15, null, 14, 14, false, null },
                    { 16, null, 16, 15, false, null },
                    { 17, null, 17, 15, false, null },
                    { 18, null, 18, 15, false, null },
                    { 19, null, 19, 15, false, null },
                    { 20, null, 20, 15, false, null },
                    { 21, null, 21, 16, false, null },
                    { 22, null, 22, 17, false, null },
                    { 23, null, 23, 18, false, null },
                    { 24, null, 24, 19, false, null },
                    { 25, null, 25, 20, false, null },
                    { 26, null, 26, 21, false, null },
                    { 27, null, 27, 22, false, null },
                    { 28, null, 28, 23, false, null },
                    { 29, null, 29, 24, false, null },
                    { 30, null, 30, 25, false, null },
                    { 31, null, 31, 26, false, null },
                    { 32, null, 32, 27, false, null },
                    { 33, null, 33, 28, false, null },
                    { 34, null, 34, 29, false, null },
                    { 35, null, 35, 30, false, null },
                    { 36, null, 36, 31, false, null },
                    { 37, null, 37, 32, false, null },
                    { 38, null, 38, 33, false, null },
                    { 39, null, 39, 34, false, null },
                    { 40, null, 40, 35, false, null }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookName", "BookPrice", "BookTypeId", "IdBookType", "IsDeleted", "bookImage" },
                values: new object[,]
                {
                    { 1, "Happy Planning", 1000, null, 1, false, null },
                    { 2, "The High 5 Habit", 1000, null, 1, false, null },
                    { 3, "Big Magic", 1000, null, 1, false, null },
                    { 4, "Set Boundaries ,Find Peace", 1000, null, 1, false, null },
                    { 5, "The Power Of Writing It Down", 1000, null, 1, false, null },
                    { 6, "Life Is In The Transitions", 1000, null, 1, false, null },
                    { 7, "Why Social Media is Ruining Your Life", 1000, null, 1, false, null },
                    { 8, "Peak Mind", 1000, null, 1, false, null },
                    { 9, "Working Hard, Hardly Working", 1000, null, 1, false, null },
                    { 10, "The Everyday Hero Manifesto", 1000, null, 1, false, null },
                    { 11, "All Of Us Are Broken", 1000, null, 2, false, null },
                    { 12, "Burial Of Ghosts", 1000, null, 2, false, null },
                    { 13, "The Cat Who Caught A Killer", 1000, null, 2, false, null },
                    { 14, "Dirt Town", 1000, null, 2, false, null },
                    { 15, "The Rising Tide", 1000, null, 2, false, null },
                    { 16, "A Murder is Announced", 1000, null, 2, false, null },
                    { 17, "The Mysterious Affair at Styles", 1000, null, 2, false, null },
                    { 18, "The Murder of Roger Ackroyd", 1000, null, 2, false, null },
                    { 19, "Murder on the Orient Express", 1000, null, 2, false, null },
                    { 20, "Crooked House", 1000, null, 2, false, null },
                    { 21, "Thinking, Fast and Slow", 1000, null, 3, false, null },
                    { 22, "Influence: Science and Practice", 1000, null, 3, false, null },
                    { 23, "The Happiness Hypothesis", 1000, null, 3, false, null },
                    { 24, "Predictably Irrational", 1000, null, 3, false, null },
                    { 25, "Emotional Intelligence", 1000, null, 3, false, null },
                    { 26, "Contagious: Why Things Catch On", 1000, null, 4, false, null },
                    { 27, "This is Marketing: You Can’t Be Seen Until You Learn To See", 1000, null, 4, false, null },
                    { 28, "Building a StoryBrand: Clarify Your Message So Customers Will Listen", 1000, null, 4, false, null },
                    { 29, "Blue Ocean Strategy", 1000, null, 4, false, null },
                    { 30, "Top of Mind (PB)", 1000, null, 4, false, null },
                    { 31, "The Guns of August", 1000, null, 5, false, null },
                    { 32, "Guns, Germs, and Steel", 1000, null, 5, false, null },
                    { 33, "1776", 1000, null, 5, false, null },
                    { 34, "The Devil in the White City", 1000, null, 5, false, null },
                    { 35, "Orientalism", 1000, null, 5, false, null },
                    { 36, "Fever Pitch", 1000, null, 6, false, null },
                    { 37, "Open", 1000, null, 6, false, null },
                    { 38, "The Miracle of Castel di Sangro", 1000, null, 6, false, null },
                    { 39, "the Blind Side: Evolution of a Game", 1000, null, 6, false, null },
                    { 40, "Laughing in the hills", 1000, null, 6, false, null }
                });

            migrationBuilder.InsertData(
                table: "Buybooks",
                columns: new[] { "Id", "Address", "BookLibraryId", "Count", "IdBookLibrary", "IdUser", "Price", "UserId" },
                values: new object[,]
                {
                    { 1, null, null, 3, 1, 1, 3000.0, null },
                    { 2, null, null, 4, 42, 1, 4000.0, null },
                    { 3, null, null, 3, 83, 1, 3000.0, null },
                    { 4, null, null, 3, 124, 1, 3000.0, null },
                    { 5, null, null, 3, 5, 2, 3000.0, null },
                    { 6, null, null, 3, 55, 2, 3000.0, null },
                    { 7, null, null, 3, 56, 2, 3000.0, null },
                    { 8, null, null, 3, 123, 2, 3000.0, null },
                    { 9, null, null, 3, 144, 2, 3000.0, null },
                    { 10, null, null, 3, 7, 3, 3000.0, null },
                    { 11, null, null, 3, 45, 3, 3000.0, null },
                    { 12, null, null, 3, 88, 3, 3000.0, null },
                    { 13, null, null, 3, 102, 3, 3000.0, null },
                    { 14, null, null, 3, 9, 4, 3000.0, null },
                    { 15, null, null, 3, 27, 4, 3000.0, null },
                    { 16, null, null, 3, 89, 4, 3000.0, null },
                    { 17, null, null, 3, 160, 4, 3000.0, null },
                    { 18, null, null, 3, 33, 5, 3000.0, null },
                    { 19, null, null, 3, 44, 5, 3000.0, null },
                    { 20, null, null, 3, 122, 5, 3000.0, null },
                    { 21, null, null, 3, 159, 5, 3000.0, null }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "IdPost", "IdUser", "PostId", "UserId", "comment" },
                values: new object[,]
                {
                    { 1, 1, 2, null, null, "Wow" },
                    { 2, 1, 3, null, null, "i do not Now That Before" },
                    { 3, 1, 4, null, null, "very silly" },
                    { 4, 1, 5, null, null, "nice one!" },
                    { 5, 2, 2, null, null, "Wow" },
                    { 6, 2, 3, null, null, "i do not Now That Before" },
                    { 7, 2, 4, null, null, "very silly" },
                    { 8, 2, 5, null, null, "nice one!" },
                    { 9, 3, 2, null, null, "Wow" },
                    { 10, 3, 3, null, null, "i do not Now That Before" },
                    { 11, 3, 4, null, null, "very silly" },
                    { 12, 3, 5, null, null, "nice one!" },
                    { 13, 4, 2, null, null, "Wow" },
                    { 14, 4, 3, null, null, "i do not Now That Before" },
                    { 15, 4, 4, null, null, "very silly" },
                    { 16, 4, 5, null, null, "nice one!" },
                    { 17, 5, 2, null, null, "Wow" },
                    { 18, 5, 3, null, null, "i do not Now That Before" },
                    { 19, 5, 4, null, null, "very silly" },
                    { 20, 5, 5, null, null, "nice one!" },
                    { 21, 6, 2, null, null, "Wow" },
                    { 22, 6, 3, null, null, "i do not Now That Before" },
                    { 23, 6, 4, null, null, "very silly" },
                    { 24, 6, 5, null, null, "nice one!" },
                    { 25, 7, 2, null, null, "Wow" },
                    { 26, 7, 3, null, null, "i do not Now That Before" },
                    { 27, 7, 4, null, null, "very silly" },
                    { 28, 7, 5, null, null, "nice one!" },
                    { 29, 8, 2, null, null, "Wow" },
                    { 30, 8, 3, null, null, "i do not Now That Before" },
                    { 31, 8, 4, null, null, "very silly" },
                    { 32, 8, 5, null, null, "nice one!" },
                    { 33, 9, 2, null, null, "Wow" },
                    { 34, 9, 3, null, null, "i do not Now That Before" },
                    { 35, 9, 4, null, null, "very silly" },
                    { 36, 9, 5, null, null, "nice one!" },
                    { 37, 10, 2, null, null, "Wow" },
                    { 38, 10, 3, null, null, "i do not Now That Before" },
                    { 39, 10, 4, null, null, "very silly" },
                    { 40, 10, 5, null, null, "nice one!" },
                    { 41, 11, 2, null, null, "Wow" },
                    { 42, 11, 3, null, null, "i do not Now That Before" },
                    { 43, 11, 4, null, null, "very silly" },
                    { 44, 11, 5, null, null, "nice one!" },
                    { 45, 12, 2, null, null, "Wow" },
                    { 46, 12, 3, null, null, "i do not Now That Before" },
                    { 47, 12, 4, null, null, "very silly" },
                    { 48, 12, 5, null, null, "nice one!" },
                    { 49, 13, 2, null, null, "Wow" },
                    { 50, 13, 3, null, null, "i do not Now That Before" },
                    { 51, 13, 4, null, null, "very silly" },
                    { 52, 13, 5, null, null, "nice one!" },
                    { 53, 13, 5, null, null, "good" },
                    { 54, 14, 2, null, null, "Wow" },
                    { 55, 14, 3, null, null, "i do not Now That Before" },
                    { 56, 14, 4, null, null, "very silly" },
                    { 57, 14, 5, null, null, "nice one!" },
                    { 58, 14, 5, null, null, "good" },
                    { 59, 15, 2, null, null, "Wow" },
                    { 60, 15, 3, null, null, "i do not Now That Before" },
                    { 61, 15, 4, null, null, "very silly" },
                    { 62, 15, 5, null, null, "nice one!" },
                    { 63, 15, 5, null, null, "good" },
                    { 64, 16, 2, null, null, "Wow" },
                    { 65, 16, 3, null, null, "i do not Now That Before" },
                    { 66, 16, 4, null, null, "very silly" },
                    { 67, 16, 5, null, null, "nice one!" },
                    { 68, 16, 5, null, null, "good" },
                    { 69, 17, 2, null, null, "Wow" },
                    { 70, 17, 3, null, null, "i do not Now That Before" },
                    { 71, 17, 4, null, null, "very silly" },
                    { 72, 17, 5, null, null, "nice one!" },
                    { 73, 17, 5, null, null, "good" },
                    { 74, 18, 2, null, null, "Wow" },
                    { 75, 18, 3, null, null, "i do not Now That Before" },
                    { 76, 18, 4, null, null, "very silly" },
                    { 77, 18, 5, null, null, "nice one!" },
                    { 78, 18, 5, null, null, "good" },
                    { 79, 19, 2, null, null, "Wow" },
                    { 80, 19, 3, null, null, "i do not Now That Before" },
                    { 81, 19, 4, null, null, "very silly" },
                    { 82, 19, 5, null, null, "nice one!" },
                    { 83, 19, 5, null, null, "good" },
                    { 84, 20, 2, null, null, "Wow" },
                    { 85, 20, 3, null, null, "i do not Now That Before" },
                    { 86, 20, 4, null, null, "very silly" },
                    { 87, 20, 5, null, null, "nice one!" },
                    { 88, 20, 5, null, null, "good" },
                    { 89, 22, 2, null, null, "Wow" },
                    { 90, 22, 3, null, null, "i do not Now That Before" },
                    { 91, 22, 4, null, null, "very silly" },
                    { 92, 22, 5, null, null, "nice one!" },
                    { 93, 22, 5, null, null, "good" },
                    { 94, 23, 2, null, null, "Wow" },
                    { 95, 23, 3, null, null, "i do not Now That Before" },
                    { 96, 23, 4, null, null, "very silly" },
                    { 97, 23, 5, null, null, "nice one!" },
                    { 98, 23, 5, null, null, "good" },
                    { 99, 24, 2, null, null, "Wow" },
                    { 100, 24, 3, null, null, "i do not Now That Before" },
                    { 101, 24, 4, null, null, "very silly" },
                    { 102, 24, 5, null, null, "nice one!" },
                    { 103, 24, 5, null, null, "good" },
                    { 104, 25, 2, null, null, "Wow" },
                    { 105, 25, 3, null, null, "i do not Now That Before" },
                    { 106, 25, 4, null, null, "very silly" },
                    { 107, 25, 5, null, null, "nice one!" },
                    { 108, 25, 5, null, null, "good" },
                    { 109, 26, 2, null, null, "Wow" },
                    { 110, 26, 3, null, null, "i do not Now That Before" },
                    { 111, 26, 4, null, null, "very silly" },
                    { 112, 26, 5, null, null, "nice one!" },
                    { 113, 26, 5, null, null, "good" },
                    { 114, 27, 2, null, null, "Wow" },
                    { 115, 27, 3, null, null, "i do not Now That Before" },
                    { 116, 27, 4, null, null, "very silly" },
                    { 117, 27, 5, null, null, "nice one!" },
                    { 118, 27, 5, null, null, "good" },
                    { 119, 28, 2, null, null, "Wow" },
                    { 120, 28, 3, null, null, "i do not Now That Before" },
                    { 121, 28, 4, null, null, "very silly" },
                    { 122, 28, 5, null, null, "nice one!" },
                    { 123, 28, 5, null, null, "good" },
                    { 124, 29, 2, null, null, "Wow" },
                    { 125, 29, 3, null, null, "i do not Now That Before" },
                    { 126, 29, 4, null, null, "very silly" },
                    { 127, 29, 5, null, null, "nice one!" },
                    { 128, 29, 5, null, null, "good" },
                    { 129, 30, 2, null, null, "Wow" },
                    { 130, 30, 3, null, null, "i do not Now That Before" },
                    { 131, 30, 4, null, null, "very silly" },
                    { 132, 30, 5, null, null, "nice one!" },
                    { 133, 30, 5, null, null, "good!" },
                    { 134, 31, 2, null, null, "Wow" },
                    { 135, 31, 3, null, null, "i do not Now That Before" },
                    { 136, 31, 4, null, null, "very silly" },
                    { 137, 31, 5, null, null, "nice one!" },
                    { 138, 31, 5, null, null, "good" },
                    { 139, 32, 2, null, null, "Wow" },
                    { 140, 32, 3, null, null, "i do not Now That Before" },
                    { 141, 32, 4, null, null, "very silly" },
                    { 142, 32, 5, null, null, "nice one!" },
                    { 143, 32, 5, null, null, "good!" },
                    { 144, 33, 2, null, null, "Wow" },
                    { 145, 33, 3, null, null, "i do not Now That Before" },
                    { 146, 33, 4, null, null, "very silly" },
                    { 147, 33, 5, null, null, "nice one!" },
                    { 148, 33, 5, null, null, "good" },
                    { 149, 34, 2, null, null, "Wow" },
                    { 150, 34, 3, null, null, "i do not Now That Before" },
                    { 151, 34, 4, null, null, "very silly" },
                    { 152, 34, 5, null, null, "nice one!" },
                    { 153, 34, 5, null, null, "good" },
                    { 154, 35, 2, null, null, "Wow" },
                    { 155, 35, 3, null, null, "i do not Now That Before" },
                    { 156, 35, 4, null, null, "very silly" },
                    { 157, 35, 5, null, null, "nice one!" },
                    { 158, 35, 5, null, null, "good" },
                    { 159, 36, 2, null, null, "Wow" },
                    { 160, 36, 3, null, null, "i do not Now That Before" },
                    { 161, 36, 4, null, null, "very silly" },
                    { 162, 36, 5, null, null, "nice one!" },
                    { 163, 36, 5, null, null, "good!" },
                    { 164, 37, 2, null, null, "Wow" },
                    { 165, 37, 3, null, null, "i do not Now That Before" },
                    { 166, 37, 4, null, null, "very silly" },
                    { 167, 37, 5, null, null, "nice one!" },
                    { 168, 37, 5, null, null, "good" },
                    { 169, 38, 2, null, null, "Wow" },
                    { 170, 38, 3, null, null, "i do not Now That Before" },
                    { 171, 38, 4, null, null, "very silly" },
                    { 172, 38, 5, null, null, "nice one!" },
                    { 173, 38, 5, null, null, "good!" },
                    { 174, 39, 2, null, null, "Wow" },
                    { 175, 39, 3, null, null, "i do not Now That Before" },
                    { 176, 39, 4, null, null, "very silly" },
                    { 177, 39, 5, null, null, "nice one!" },
                    { 178, 39, 5, null, null, "good" },
                    { 179, 41, 2, null, null, "Wow" },
                    { 180, 41, 3, null, null, "i do not Now That Before" },
                    { 181, 41, 4, null, null, "very silly" },
                    { 182, 41, 5, null, null, "nice one!" }
                });

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "typeName",
                value: "Physics");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "typeName",
                value: "Earth");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                column: "typeName",
                value: "General Science");

            migrationBuilder.InsertData(
                table: "GameUsers",
                columns: new[] { "Id", "GameId", "IdGame", "IdUser", "Score", "UserId", "userLevel" },
                values: new object[,]
                {
                    { 1, null, 1, 1, 1, null, "1" },
                    { 2, null, 2, 2, 1, null, "1" },
                    { 3, null, 3, 2, 1, null, "1" },
                    { 4, null, 4, 2, 1, null, "1" },
                    { 5, null, 5, 2, 1, null, "1" },
                    { 6, null, 1, 3, 1, null, "1" },
                    { 7, null, 2, 3, 1, null, "1" },
                    { 8, null, 3, 3, 1, null, "1" },
                    { 9, null, 4, 3, 1, null, "1" },
                    { 10, null, 5, 3, 1, null, "1" },
                    { 11, null, 1, 4, 1, null, "1" },
                    { 12, null, 2, 4, 1, null, "1" },
                    { 13, null, 3, 4, 1, null, "1" },
                    { 14, null, 4, 4, 1, null, "1" },
                    { 15, null, 5, 4, 1, null, "1" },
                    { 16, null, 1, 5, 1, null, "1" },
                    { 17, null, 2, 5, 1, null, "1" },
                    { 18, null, 3, 5, 1, null, "1" },
                    { 19, null, 4, 5, 1, null, "1" },
                    { 20, null, 5, 5, 1, null, "1" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "GameLevel", "GameName", "Image" },
                values: new object[,]
                {
                    { 1, null, "Letter Game", null },
                    { 2, null, "Word Game", null },
                    { 3, null, "Math Game", null },
                    { 4, null, "Foucs Game", null },
                    { 5, null, "Packet Game", null }
                });

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "groupName",
                value: "Thee Physicists");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2,
                column: "groupName",
                value: "The Earth");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5,
                column: "groupName",
                value: "The Science ");

            migrationBuilder.InsertData(
                table: "Libraries",
                columns: new[] { "Id", "IsDeleted", "libraryAddress", "libraryName" },
                values: new object[,]
                {
                    { 1, false, "AlSabel Street", "Sham" },
                    { 2, false, "Aljamelia", "Dar AlTurath" },
                    { 3, false, "AlMokambo", "Dar AlRabiea" },
                    { 4, false, "AlShahbaa", "Shahmaa" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ContentId", "Description", "GroupId", "IdContent", "IdGroup", "IdUser", "Image", "UserId", "dateTime" },
                values: new object[,]
                {
                    { 1, null, "Physics is a science that studies the general properties of matter and the laws that seek to modify its state or motion without changing its nature.", null, 1, 0, 2, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9522) },
                    { 2, null, "Astrophysics is a branch of astronomy that studies the properties and physical phenomena of celestial bodies. It depends primarily on the spectrometer that analyzes starlight and shows the materials that make up it and the physical conditions prevailing on its surface and in its atmosphere.", null, 1, 0, 3, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9579) },
                    { 3, null, "Radiation is the process by which energy such as subatomic particles is emitted and transmitted. This process is characterized by the transmission of energy in straight lines in a source through a known medium such as air, water or vacuum.", null, 1, 0, 4, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9590) },
                    { 4, null, "Heat is a physical measure of the feeling of hotness or coldness resulting from contact with an object", null, 1, 0, 5, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9600) },
                    { 5, null, "Gravity is the mutual attraction between two bodies and its strength depends on the masses of the two bodies and the distance between them", null, 1, 1, 2, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9611) },
                    { 6, null, "X-rays are similar to light rays, but they are more frequent. The most recent of them are objects under the influence of cathode rays. They were discovered by the scientist Roentgen and are sometimes called by his name. They are electromagnetic waves.", null, 1, 1, 3, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9621) },
                    { 7, null, "Frequency is the number of waves or cycles that leave a known point or reach it per second. This word or convention is most often used in alternating electric current, light and sound waves.", null, 1, 1, 4, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9631) },
                    { 8, null, "Gamma rays are special electromagnetic rays emitted by radium and some other radioactive materials", null, 1, 1, 5, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9640) },
                    { 10, null, "The hurricane is a region of low atmospheric pressure in which the winds move in a spiral movement towards the center, and the spiral movement is counterclockwise in the northern hemisphere and agrees with it in the southern hemisphere", null, 2, 0, 2, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9650) },
                    { 11, null, "What is the definition of land shake?It is a tremor in the earth's crust caused either by volcanic activity underground or by the movement of rocks below the surface", null, 2, 0, 3, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9660) },
                    { 12, null, "Soil in stratigraphy is the part of the Earth's surface that contains a mixture of rock particles, minerals and organic matter that helps plant growth", null, 2, 0, 4, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9670) },
                    { 13, null, "The South Pole is the southernmost point on the Earth's surface, and it is one of two points that border the imaginary line that represents the axis of rotation of the earth around itself", null, 2, 0, 5, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9720) },
                    { 14, null, "The continent is a wide area of   land surrounded by seas and continents are Asia, Africa, America, Oceania, and occupies less than a third of the surface of the globe", null, 2, 2, 2, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9733) },
                    { 15, null, "cumulus :  It is a group of pieces of rock that descended to a steep slope", null, 2, 2, 3, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9742) },
                    { 16, null, "marble : A metamorphic rock consisting of calcite, which is a variable limestone that can be polished beautifully", null, 2, 2, 4, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9752) },
                    { 17, null, "The North Pole is the point located in the far north of the Earth's surface, and it is one of the two points through which the imaginary line passes, which is the axis of the Earth's rotation around itself.", null, 2, 2, 5, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9761) },
                    { 18, null, "Kidney is not  the only excretory organ ,but it is the most imporatnt", null, 3, 0, 2, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9771) },
                    { 19, null, "The Femur is the longest bone in the human body", null, 3, 0, 3, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9783) },
                    { 20, null, "There are 4 loose ribs in the human body", null, 3, 0, 4, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9793) },
                    { 21, null, "When inhaling, the diaphragm muscle contracts", null, 3, 0, 5, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9803) },
                    { 22, null, "Most food is absorbed in the intestines", null, 3, 3, 2, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9814) },
                    { 23, null, "The tricuspid valve is located between the right atrium and the right ventricle", null, 3, 3, 3, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9823) },
                    { 24, null, "There are 7 cervical vertebrae, 12 thoracic vertebrae, 5 lumbar vertebrae, 5 sacral vertebrae, and 4 coccygeal vertebrae.", null, 3, 3, 4, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9832) },
                    { 25, null, "The eye lives within a cavity called the pilgrims", null, 3, 3, 5, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9842) },
                    { 26, null, "The most used application is Facebook, with 1.3 billion users, while the second most used application is WeChat, with 1.26 billion users.", null, 4, 0, 2, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9851) },
                    { 27, null, "PAN, LAN, MAN, GAN, WAN and VPN are a kind of networking technology", null, 4, 0, 3, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9860) },
                    { 28, null, "SD-WAN is one of the fastest emerging segments in network technologies over the past two years", null, 4, 0, 4, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9869) },
                    { 29, null, "Artificial intelligence  - Artificial Intelligence - is a simulation and tradition of human intelligence in the machines programmed to think such as humans and images their actions such as electronic devices and robots, this term can also indicate any machine that displays attributes related to the human mind such as learning and solving problems", null, 4, 0, 5, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9877) },
                    { 30, null, "A GPU is a processor similar to the one on a computer's motherboard.  The job that the graphics card processor performs is to keep the graphics card connected to the computer system.  It is considered the most important component of the graphics card that processes graphics, and the graphics card processor is not separable, that is, it cannot be updated to a higher category.", null, 4, 4, 2, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9886) },
                    { 31, null, "CPU is a machine or an electrical circuit that operates other machines or electronic circuits by giving them orders to perform operations or algorithms;  Most of these operations are data processing.", null, 4, 4, 3, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9896) },
                    { 32, null, "Deepfake or deep falsification is a technique used to fake video clips in a way that makes it difficult for humans to distinguish between what is real and what is fake", null, 4, 4, 4, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9904) },
                    { 33, null, "Bots download, Spam bots, Ticket Bots, Distributed Denial of Service (DDoS) bots, Fraudulent bots, File sharing bots and Social media bots are kind of Malicious bots", null, 4, 4, 5, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9913) },
                    { 34, null, "Snow is a type of deposition in which water droplets are frozen in the form of ice crystals with various hexagonal shapes", null, 5, 0, 2, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9922) },
                    { 35, null, "A cold front is the dividing line between two masses of air, one warm and the other cold, heading towards the warm and pushing under it", null, 5, 0, 3, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9933) },
                    { 36, null, "Did you know that the duration of each cycle of the sun around itself is 24 days and three quarters", null, 5, 0, 4, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9983) },
                    { 37, null, "Absolute zero is the temperature of (162, 273 °) Celsius at which molecular motion vanishes and the body loses its thermal energy", null, 5, 0, 5, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 331, DateTimeKind.Local).AddTicks(9994) },
                    { 38, null, "Giraffe neck The length of the giraffe's neck can reach more than 13.2 meters and contains the same number of vertebrae as the human neck, i.e. there are seven vertebrae in the giraffe's neck, and the length of each vertebra can exceed more than 25 cm", null, 5, 5, 2, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(3) },
                    { 39, null, "The duration of the land of round about itself : The land that spirves around the same (1000) miles per hour along the tropical surroundings, in every 23 hours, and (56) minutes.", null, 5, 5, 3, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(12) },
                    { 40, null, "The duration of the land of the ground around the sun : The duration of the land of the ground around the sun is only one time, [1/4 365] days.", null, 5, 5, 4, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(21) },
                    { 41, null, "The oldest woman in the world is Maria Branyas Moreira, who is 115 years and 329 days old", null, 5, 5, 5, null, null, new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(31) }
                });

            migrationBuilder.InsertData(
                table: "References",
                columns: new[] { "Id", "ContentId", "IdAdmin", "IdContent", "Link", "dateTime", "referenceName" },
                values: new object[,]
                {
                    { 1, null, 0, 3, "https://accessmedicine.mhmedical.com/book.aspx?bookid=3095#259856986", new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4345), "dont now" },
                    { 2, null, 0, 3, "https://accessmedicine.mhmedical.com/book.aspx?bookid=3212#269128176", new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4368), "dont now" },
                    { 3, null, 0, 3, "https://accessmedicine.mhmedical.com/book.aspx?bookid=1477", new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4378), "dont now" },
                    { 4, null, 0, 3, "https://accessmedicine.mhmedical.com/book.aspx?bookid=2969", new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4387), "dont now" },
                    { 5, null, 0, 1, "https://openstax.org/books/college-physics-2e/pages/1-introduction-to-science-and-the-realm-of-physics-physical-quantities-and-units", new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4396), "dont now" },
                    { 6, null, 0, 1, "https://openstax.org/books/college-physics-2e/pages/1-1-physics-an-introduction", new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4406), "dont now" },
                    { 7, null, 0, 1, "https://openstax.org/books/college-physics-2e/pages/1-2-physical-quantities-and-units", new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4416), "dont now" },
                    { 8, null, 0, 1, "https://openstax.org/books/college-physics-2e/pages/1-4-approximation", new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4468), "dont now" },
                    { 9, null, 0, 2, "https://www.amazon.com/Alfred-Wegener-Creator-Continental-Science/dp/0816061742", new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4478), "Alfred Wegener: Creator of the Continental Drift Theory (Makers of Modern Science)" },
                    { 10, null, 0, 2, "https://www.amazon.com/Earth-Very-Short-Introduction/dp/0192803077/ref=sr_1_9?dchild=1&keywords=earth+very+short&qid=1628980604&s=books&sr=1-9", new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4489), "The Earth: A Very Short Introduction" },
                    { 11, null, 0, 2, "https://www.amazon.com/Essentials-Geology-12th-Frederick-Lutgens/dp/0321947738/ref=sr_1_2?dchild=1&keywords=essential+geology+fredrick&qid=1628980672&s=books&sr=1-2-spell", new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4499), "Essentials of Geology (12th Edition)" },
                    { 12, null, 0, 2, "https://www.amazon.com/Plate-Tectonics-Short-Introduction-Introductions/dp/0198728263/ref=sr_1_3?dchild=1&keywords=earth+science+vsi&qid=1628980553&s=books&sr=1-3", new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4508), "Plate Tectonics: A Very Short Introduction (Very Short Introductions): Molnar, Peter" },
                    { 13, null, 0, 4, "https://www.free-ebooks.net/internet-technology/R-Programming-in-Statistics", new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4518), "R Programming in Statistics by Balasubramanian Thiagarajan" },
                    { 14, null, 0, 4, "https://www.free-ebooks.net/internet-technology/DISCOVER-YOUR-SPECIALTY", new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4528), "DISCOVER YOUR SPECIALTY by DISCOVER YOUR SPECIALTY" },
                    { 15, null, 0, 4, "https://www.free-ebooks.net/internet-technology/10-Ways-to-Create-The-Perfect-Online-Video", new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4537), "Become A Pro Designer Overnight. by Clickdesigns" },
                    { 16, null, 0, 4, "https://www.amazon.com/Plate-Tectonics-Short-Introduction-Introductions/dp/0198728263/ref=sr_1_3?dchild=1&keywords=earth+science+vsi&qid=1628980553&s=books&sr=1-3", new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4547), "10 Ways to Create The Perfect Online Video by Mathew" },
                    { 17, null, 0, 4, "https://www.free-ebooks.net/internet-technology/Deep-Analytics-Technologies-for-Humanity-AI-Security", new DateTime(2023, 8, 12, 1, 34, 20, 332, DateTimeKind.Local).AddTicks(4556), "Deep Analytics: Technologies for Humanity, AI & Security" }
                });

            migrationBuilder.InsertData(
                table: "UserAccessibilities",
                columns: new[] { "Id", "AccessibilityId", "AdminOn", "GroupId", "IdAccessibility", "IdGroup", "IdLibrary", "IdReference", "IdTest", "IdUser", "LibraryId", "ReferenceId", "TestId", "UserId" },
                values: new object[,]
                {
                    { 1, null, "Null", null, 1, 1, 1, 1, null, 2, null, null, null, null },
                    { 2, null, "Null", null, 1, 2, 2, 1, null, 3, null, null, null, null },
                    { 3, null, "Null", null, 1, 3, 3, 2, null, 4, null, null, null, null },
                    { 4, null, "null", null, 1, 5, 5, 3, null, 5, null, null, null, null },
                    { 5, null, "null", null, 2, 2, 2, 1, null, 2, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "UserGroups",
                columns: new[] { "Id", "GroupId", "IdGroup", "IdUser", "UserId" },
                values: new object[,]
                {
                    { 1, null, 1, 2, null },
                    { 2, null, 2, 2, null },
                    { 3, null, 3, 2, null },
                    { 4, null, 4, 2, null },
                    { 5, null, 5, 2, null },
                    { 6, null, 1, 3, null },
                    { 7, null, 2, 3, null },
                    { 8, null, 3, 3, null },
                    { 9, null, 4, 3, null },
                    { 10, null, 5, 3, null },
                    { 11, null, 1, 4, null },
                    { 12, null, 2, 4, null },
                    { 13, null, 3, 4, null },
                    { 14, null, 4, 4, null },
                    { 15, null, 5, 4, null },
                    { 16, null, 1, 5, null },
                    { 17, null, 2, 5, null },
                    { 18, null, 3, 5, null },
                    { 19, null, 4, 5, null },
                    { 20, null, 5, 5, null }
                });

            migrationBuilder.InsertData(
                table: "UserReferences",
                columns: new[] { "Id", "IdReference", "IdUser", "ReferenceId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 2, null, null },
                    { 2, 2, 3, null, null },
                    { 3, 3, 4, null, null },
                    { 4, 4, 5, null, null },
                    { 5, 5, 2, null, null },
                    { 6, 6, 3, null, null },
                    { 7, 7, 4, null, null },
                    { 8, 8, 5, null, null },
                    { 9, 9, 2, null, null },
                    { 10, 10, 3, null, null },
                    { 11, 11, 4, null, null },
                    { 12, 12, 5, null, null },
                    { 13, 13, 2, null, null },
                    { 14, 14, 3, null, null },
                    { 15, 15, 4, null, null },
                    { 16, 16, 5, null, null },
                    { 17, 17, 5, null, null }
                });

            migrationBuilder.InsertData(
                table: "Writers",
                columns: new[] { "Id", "IsDeleted", "writerName" },
                values: new object[,]
                {
                    { 1, false, "Charlotte Blaine" },
                    { 2, false, "Mel Robbins" },
                    { 3, false, "Elizabeth Gilbert" },
                    { 4, false, "Nedra Glover Tawab" },
                    { 5, false, "Allison Fallon" },
                    { 6, false, "Bruce Feiler" },
                    { 7, false, "Catherine Ormerod" },
                    { 8, false, "Amish Jha" },
                    { 9, false, "Grace Beverly" },
                    { 10, false, "Robin Sharma" },
                    { 11, false, "Fiona Cummins" },
                    { 12, false, "Ann Cleeves" },
                    { 13, false, "L T Shearer" },
                    { 14, false, "Hayley Scrivenor" },
                    { 15, false, "Agatha Christie" },
                    { 16, false, "Daniel Kahneman" },
                    { 17, false, "Robert Cialdini" },
                    { 18, false, "Jonathan Haidt" },
                    { 19, false, "Dan Ariely" },
                    { 20, false, "Daniel Goleman" },
                    { 21, false, "Jonah Berger" },
                    { 22, false, "Seth Godin" },
                    { 23, false, "Donald Miller" },
                    { 24, false, "W. Chan Kim" },
                    { 25, false, "John Hall" },
                    { 26, false, "Barbara W. Tuchman" },
                    { 27, false, "Jared Diamond" },
                    { 28, false, "David McCullough" },
                    { 29, false, "Erik Larson" },
                    { 30, false, "Edward Said" },
                    { 31, false, "Nick Hornby" },
                    { 32, false, "Andre Agassi" },
                    { 33, false, "Joe McGinniss" },
                    { 34, false, "Michael Lewis" },
                    { 35, false, "Bill Barich" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "BookLibraries",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "BookTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BookTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "BookWriters",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Buybooks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Buybooks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Buybooks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Buybooks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Buybooks",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Buybooks",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Buybooks",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Buybooks",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Buybooks",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Buybooks",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Buybooks",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Buybooks",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Buybooks",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Buybooks",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Buybooks",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Buybooks",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Buybooks",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Buybooks",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Buybooks",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Buybooks",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Buybooks",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "GameUsers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Libraries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "References",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UserAccessibilities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserAccessibilities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserAccessibilities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserAccessibilities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserAccessibilities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "UserGroups",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "UserReferences",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserReferences",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserReferences",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserReferences",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserReferences",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "UserReferences",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserReferences",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UserReferences",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UserReferences",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UserReferences",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UserReferences",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserReferences",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "UserReferences",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UserReferences",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UserReferences",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "UserReferences",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "UserReferences",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Writers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 1,
                column: "typeName",
                value: "History");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 2,
                column: "typeName",
                value: "Geography");

            migrationBuilder.UpdateData(
                table: "Contents",
                keyColumn: "Id",
                keyValue: 5,
                column: "typeName",
                value: "Literature");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1,
                column: "groupName",
                value: "The Histoicals");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2,
                column: "groupName",
                value: "The Geographiest");

            migrationBuilder.UpdateData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 5,
                column: "groupName",
                value: "The Literature ");
        }
    }
}
