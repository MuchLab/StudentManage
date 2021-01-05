using System.Collections.Generic;
using Homework06.Application.Models;

namespace Homework06.Models
{
    public class CrsId
    {
        public long Id { get; set; }
        public List<Course> Courses { get; set; }
    }
}