using Homework06.Models;

namespace Homework06.Application.Models
{
    public class Enrollment
    {
        //Student外键
        public long StuId { get; set; }
        //导航属性，和Student是多对一的关系
        public Student Student { get; set; }
        //Offer外键
        public long OfferNo { get; set; }
        //导航属性，和Offer是多对一的关系
        public Offer Offer { get; set; }
        public EnGrade EnGrade { get; set; }
    }
}