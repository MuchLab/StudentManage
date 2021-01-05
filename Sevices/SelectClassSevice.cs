using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework06.Application.Models;
using Homework06.Data;
using Microsoft.EntityFrameworkCore;

namespace Homework06.Sevices
{
    public class SelectClassSevice:IService
    {
        private readonly MyContext _context;

        public SelectClassSevice(MyContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Faculty>> GetFacultyByCrsId(long id)
        {
            return await _context.Faculties.Where(x =>
                    x.Offers.Any(y =>
                        y.CourseId == id))
                .ToListAsync();
            //listAsync.Where(x => x.Offers.Any(y => y.CourseId == id)).ToList();
        }
        public async Task<IEnumerable<Student>> GetStudentByCrsId(long id)
        {
            return await _context.Students.Where(x =>
                    x.Enrollments.Any(y =>
                        y.Offer.CourseId == id))
                .ToListAsync();
        }
    }
}