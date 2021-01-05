using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Homework06.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CrsDesc = table.Column<string>(nullable: true),
                    CrsUnits = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Dept = table.Column<string>(nullable: true),
                    Rank = table.Column<int>(nullable: false),
                    Salary = table.Column<decimal>(nullable: false),
                    Supervisor = table.Column<string>(nullable: true),
                    HireDate = table.Column<DateTime>(nullable: false),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Major = table.Column<string>(nullable: true),
                    Class = table.Column<string>(nullable: true),
                    GPA = table.Column<double>(nullable: false),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    OfferNo = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OffTerm = table.Column<int>(nullable: false),
                    OffYear = table.Column<int>(nullable: false),
                    OffLocation = table.Column<string>(nullable: true),
                    OffTime = table.Column<DateTime>(nullable: false),
                    CourseId = table.Column<long>(nullable: false),
                    FacID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.OfferNo);
                    table.ForeignKey(
                        name: "FK_Offers_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Offers_Faculties_FacID",
                        column: x => x.FacID,
                        principalTable: "Faculties",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    StuId = table.Column<long>(nullable: false),
                    OfferNo = table.Column<long>(nullable: false),
                    EnGrade = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enrollments", x => new { x.StuId, x.OfferNo });
                    table.ForeignKey(
                        name: "FK_Enrollments_Offers_OfferNo",
                        column: x => x.OfferNo,
                        principalTable: "Offers",
                        principalColumn: "OfferNo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Enrollments_Students_StuId",
                        column: x => x.StuId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_OfferNo",
                table: "Enrollments",
                column: "OfferNo");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_CourseId",
                table: "Offers",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_FacID",
                table: "Offers",
                column: "FacID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Faculties");
        }
    }
}
