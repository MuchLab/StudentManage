﻿// <auto-generated />
using System;
using Homework06.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Homework06.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20200609153643_AlterEnGradeType")]
    partial class AlterEnGradeType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Homework06.Application.Models.Course", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CrsDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CrsUnits")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CrsDesc = "English",
                            CrsUnits = "Arts"
                        },
                        new
                        {
                            Id = 2L,
                            CrsDesc = "Math",
                            CrsUnits = "Science"
                        },
                        new
                        {
                            Id = 3L,
                            CrsDesc = "Chemistry",
                            CrsUnits = "Science"
                        });
                });

            modelBuilder.Entity("Homework06.Application.Models.Enrollment", b =>
                {
                    b.Property<long>("StuId")
                        .HasColumnType("bigint");

                    b.Property<long>("OfferNo")
                        .HasColumnType("bigint");

                    b.Property<int>("EnGrade")
                        .HasColumnType("int");

                    b.HasKey("StuId", "OfferNo");

                    b.HasIndex("OfferNo");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("Homework06.Application.Models.Faculty", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dept")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,6)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Supervisor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Faculties");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            City = "NewYork",
                            Dept = "English",
                            FirstName = "Angie",
                            HireDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Angel",
                            Rank = 0,
                            Salary = 6000m,
                            State = "United States",
                            Supervisor = "Micheal Jason",
                            ZipCode = "522111"
                        },
                        new
                        {
                            Id = 2L,
                            City = "ShangHai",
                            Dept = "Math",
                            FirstName = "Beth",
                            HireDate = new DateTime(2018, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Elizabeth",
                            Rank = 3,
                            Salary = 10000m,
                            State = "China",
                            Supervisor = "Micheal Jason",
                            ZipCode = "522333"
                        },
                        new
                        {
                            Id = 3L,
                            City = "ShenZhen",
                            Dept = "Chemistry",
                            FirstName = "Connie",
                            HireDate = new DateTime(2015, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastName = "Constance",
                            Rank = 3,
                            Salary = 12000m,
                            State = "China",
                            Supervisor = "Micheal Jason",
                            ZipCode = "522444"
                        });
                });

            modelBuilder.Entity("Homework06.Application.Models.Offer", b =>
                {
                    b.Property<long>("OfferNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("CourseId")
                        .HasColumnType("bigint");

                    b.Property<long>("FacID")
                        .HasColumnType("bigint");

                    b.Property<string>("OffLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OffTerm")
                        .HasColumnType("int");

                    b.Property<DateTime>("OffTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("OffYear")
                        .HasColumnType("int");

                    b.HasKey("OfferNo");

                    b.HasIndex("CourseId");

                    b.HasIndex("FacID");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("Homework06.Application.Models.Student", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Class")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("GPA")
                        .HasColumnType("float");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Major")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            City = "GuangZhou",
                            Class = "17CS1",
                            FirstName = "Axl",
                            GPA = 3.5,
                            LastName = "Rose",
                            Major = "CS",
                            State = "China",
                            ZipCode = "522000"
                        },
                        new
                        {
                            Id = 2L,
                            City = "ShangHai",
                            Class = "17CS2",
                            FirstName = "Kurt",
                            GPA = 3.3999999999999999,
                            LastName = "Cobain",
                            Major = "CS",
                            State = "China",
                            ZipCode = "522000"
                        },
                        new
                        {
                            Id = 3L,
                            City = "London",
                            Class = "17CS1",
                            FirstName = "John",
                            GPA = 4.0,
                            LastName = "Lennon",
                            Major = "CS",
                            State = "England",
                            ZipCode = "522666"
                        });
                });

            modelBuilder.Entity("Homework06.Application.Models.Enrollment", b =>
                {
                    b.HasOne("Homework06.Application.Models.Offer", "Offer")
                        .WithMany("Enrollments")
                        .HasForeignKey("OfferNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Homework06.Application.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Homework06.Application.Models.Offer", b =>
                {
                    b.HasOne("Homework06.Application.Models.Course", "Course")
                        .WithMany("Offers")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Homework06.Application.Models.Faculty", "Faculty")
                        .WithMany("Offers")
                        .HasForeignKey("FacID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
