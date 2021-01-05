using System;
using System.Collections.Generic;

namespace Homework06.Application.Models
{
    public class Offer
    {
        public Offer()
        {
            Enrollments = new List<Enrollment>();
        }
        public long OfferNo { get; set; }
        public OffTerm OffTerm { get; set; }
        public int OffYear { get; set; }
        public string OffLocation { get; set; }
        public DateTime OffTime { get; set; }
        //Course外键
        public long CourseId { get; set; }
        //导航属性，和course是多对一的关系
        public Course Course { get; set; }
        //Fac外键
        public long FacID { get; set; }
        //导航属性，和faculty是多对一的关系
        public Faculty Faculty { get; set; }
        //导航属性
        public List<Enrollment> Enrollments { get; set; }
    }
}