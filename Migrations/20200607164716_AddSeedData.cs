using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Homework06.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CrsDesc", "CrsUnits" },
                values: new object[,]
                {
                    { 1L, "English", "Arts" },
                    { 2L, "Math", "Science" },
                    { 3L, "Chemistry", "Science" }
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "City", "Dept", "FirstName", "HireDate", "LastName", "Rank", "Salary", "State", "Supervisor", "ZipCode" },
                values: new object[,]
                {
                    { 1L, "NewYork", "English", "Angie", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angel", 0, 6000m, "United States", null, null },
                    { 2L, "ShangHai", "Math", "Beth", new DateTime(2018, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elizabeth", 3, 10000m, "China", null, null },
                    { 3L, "ShenZhen", "Chemistry", "Connie", new DateTime(2015, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Constance", 3, 12000m, "China", null, null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "City", "Class", "FirstName", "GPA", "LastName", "Major", "State", "ZipCode" },
                values: new object[,]
                {
                    { 1L, "GuangZhou", "17CS1", "Axl", 3.5, "Rose", "CS", "China", "522000" },
                    { 2L, "ShangHai", "17CS2", "Kurt", 3.3999999999999999, "Cobain", "CS", "China", "522000" },
                    { 3L, "London", "17CS1", "John", 4.0, "Lennon", "CS", "England", "522666" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3L);
        }
    }
}
