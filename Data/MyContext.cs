using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework06.Application.Models;
using Homework06.Models;
using Homework06.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Homework06.Data
{
    public class MyContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //设置主键
            modelBuilder.Entity<Student>().HasKey(x => x.Id);
            modelBuilder.Entity<Course>().HasKey(x => x.Id);
            modelBuilder.Entity<Faculty>().HasKey(x => x.Id);
            modelBuilder.Entity<Offer>().HasKey(x => x.OfferNo);

            //联合主键
            modelBuilder.Entity<Enrollment>().HasKey(x => new {x.StuId, x.OfferNo});

            //设置Salary属性
            modelBuilder.Entity<Faculty>().Property(x => x.Salary).HasColumnType("decimal(18,6)");
            modelBuilder.Entity<Enrollment>().Property(x => x.EnGrade).HasColumnType("int");

            //设置Enrollment和Student的一对多关系
            modelBuilder.Entity<Enrollment>()
                .HasOne(x => x.Student)
                .WithMany(x => x.Enrollments)
                .HasForeignKey(x => x.StuId);

            //设置Enrollment和Offer的多对一关系
            modelBuilder.Entity<Enrollment>()
                .HasOne(x => x.Offer)
                .WithMany(x => x.Enrollments)
                .HasForeignKey(x => x.OfferNo);

            //设置Offer和Course的一对多关系
            modelBuilder.Entity<Offer>()
                .HasOne(x => x.Course)
                .WithMany(x => x.Offers)
                .HasForeignKey(x => x.CourseId);

            //设置Offer和Faculty的一对多关系
            modelBuilder.Entity<Offer>()
                .HasOne(x => x.Faculty)
                .WithMany(x => x.Offers)
                .HasForeignKey(x => x.FacID);

            //添加种子数据
            AddSeedData(modelBuilder);
        }

        private void AddSeedData(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Faculty>().HasData(new List<Faculty>
            {
                new Faculty
                {
                    Id = 1,
                    FirstName = "Angie",
                    LastName = "Angel",
                    City = "NewYork",
                    Dept = "English",
                    HireDate = new DateTime(2020, 1, 1),
                    Rank = Rank.三级,
                    Salary = 6_000m,
                    State = "United States",
                    Supervisor = "Micheal Jason",
                    ZipCode = "522111"
                },
                new Faculty
                {
                    Id = 2,
                    FirstName = "Beth",
                    LastName = "Elizabeth",
                    City = "ShangHai",
                    Dept = "Math",
                    HireDate = new DateTime(2018, 1, 19),
                    Rank = Rank.高级,
                    Salary = 10_000m,
                    State = "China",
                    Supervisor = "Micheal Jason",
                    ZipCode = "522333"
                },
                new Faculty
                {
                    Id = 3,
                    FirstName = "Connie",
                    LastName = "Constance",
                    City = "ShenZhen",
                    Dept = "Chemistry",
                    HireDate = new DateTime(2015, 6, 4),
                    Rank = Rank.高级,
                    Salary = 12_000m,
                    State = "China",
                    Supervisor = "Micheal Jason",
                    ZipCode = "522444",
                    Offers = new List<Offer>
                    {
                        
                    }
                }
            });
            modelBuilder.Entity<Course>().HasData(new List<Course>
            {
                new Course
                {
                    Id = 1,
                    CrsDesc = "English",
                    CrsUnits = "Arts"
                },
                new Course
                {
                    Id = 2,
                    CrsDesc = "Math",
                    CrsUnits = "Science"
                },
                new Course
                {
                    Id = 3,
                    CrsDesc = "Chemistry",
                    CrsUnits = "Science"
                }
            });
            modelBuilder.Entity<Student>().HasData(new List<Student>
            {
                new Student
                {
                    Id = 1,
                    FirstName = "Axl",
                    LastName = "Rose",
                    City = "GuangZhou",
                    Class = "17CS1",
                    GPA = 3.5,
                    Major = "CS",
                    ZipCode = "522000",
                    State = "China"
                },
                new Student
                {
                    Id = 2,
                    FirstName = "Kurt",
                    LastName = "Cobain",
                    City = "ShangHai",
                    Class = "17CS2",
                    GPA = 3.4,
                    Major = "CS",
                    ZipCode = "522000",
                    State = "China"
                },
                new Student
                {
                    Id = 3,
                    FirstName = "John",
                    LastName = "Lennon",
                    City = "London",
                    Class = "17CS1",
                    GPA = 4.0,
                    Major = "CS",
                    ZipCode = "522666",
                    State = "England"
                }
            });
            //modelBuilder.Entity<Offer>().HasData(new List<Offer>
            //{
            //    new Offer
            //    {
            //        OfferNo = 2,
            //        Course = Courses.FirstOrDefault(x=> x.Id == 2),
            //        OffTerm = OffTerm.大一下学期,
            //        OffTime = new DateTime(2018, 1, 19),
            //        OffYear = 2018,
            //        OffLocation = "GuangZhou"
            //    },
            //    new Offer
            //    {
            //        OfferNo = 3,
            //        Course = Courses.FirstOrDefault(x=> x.Id == 5),
            //        OffTerm = OffTerm.大三上学期,
            //        OffTime = new DateTime(2018, 1, 19),
            //        OffYear = 2018,
            //        OffLocation = "GuangZhou"
            //    },
            //    new Offer
            //    {
            //        OfferNo = 4,
            //        Course = Courses.FirstOrDefault(x => x.Id == 1),
            //        OffTerm = OffTerm.大一下学期,
            //        OffTime = new DateTime(2015, 6, 4),
            //        OffYear = 2015,
            //        OffLocation = "GuangZhou"
            //    },
            //    new Offer
            //    {
            //        OfferNo = 5,
            //        Course = Courses.FirstOrDefault(x => x.Id == 5),
            //        OffTerm = OffTerm.大三上学期,
            //        OffTime = new DateTime(2015, 6, 4),
            //        OffYear = 2015,
            //        OffLocation = "GuangZhou"
            //    }
            //});
        }
    }
}