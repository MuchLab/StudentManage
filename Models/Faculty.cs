using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Homework06.Models;

namespace Homework06.Application.Models
{
    public class Faculty:Entity<long>
    {
        public Faculty()
        {
            Offers = new List<Offer>();
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
        [Display(Name = "部门"), Required(ErrorMessage = "部门是必需的")]
        //部门
        public string Dept { get; set; }
        [Display(Name = "等级"), Required(ErrorMessage = "等级是必需的")]
        public Rank Rank { get; set; }
        [Display(Name = "工资"), Required(ErrorMessage = "工资是必需的")]
        public decimal Salary { get; set; }
        [Display(Name = "上级")]
        public string Supervisor { get; set; }
        [Display(Name = "雇佣日期"), Required(ErrorMessage = "雇佣日期是必需的")]
        public DateTime HireDate { get; set; }
        [Display(Name = "ZipCode")]
        public string ZipCode { get; set; }
        //导航属性
        public List<Offer> Offers { get; set; }
    }
}