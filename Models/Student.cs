using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Homework06.Application.Models
{
    public class Student:Entity<long>
    {
        public Student()
        {
            Enrollments = new List<Enrollment>();
        }
        [Display(Name = "FirstName"), Required(ErrorMessage = "学生的FirstName是必需的")]
        public string FirstName { get; set; }
        [Display(Name = "LastName"), Required(ErrorMessage = "学生的LastName是必需的")]
        public string LastName { get; set; }
        [Display(Name = "城市"), Required(ErrorMessage = "城市是必需的")]
        public string City { get; set; }
        [Display(Name = "国家"), Required(ErrorMessage = "国家是必需的")]
        //国家
        public string State { get; set; }
        [Display(Name = "专业"), Required(ErrorMessage = "专业是必需的")]
        public string Major { get; set; }
        [Display(Name = "班级"), Required(ErrorMessage = "班级是必需的")]
        public string Class { get; set; }
        [Display(Name = "GPA"), Required(ErrorMessage = "GPA是必需的")]
        //平均成绩点
        public double GPA { get; set; }
        [Display(Name = "ZipCode"), Required(ErrorMessage = "ZipCode是必需的")]
        public string ZipCode { get; set; }
        //导航属性，
        public List<Enrollment> Enrollments { get; set; }
    }
}