using System.Collections.Generic;

namespace Homework06.Application.Models
{
    public class Course:Entity<long>
    {
        public Course()
        {
            Offers = new List<Offer>();
        }
        public string CrsDesc { get; set; }
        public string CrsUnits { get; set; }
        //导航属性
        public List<Offer> Offers { get; set; }
    }
}