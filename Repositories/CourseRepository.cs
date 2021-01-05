using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework06.Application.Models;
using Homework06.Data;
using Microsoft.EntityFrameworkCore;

namespace Homework06.Repositories
{
    public class CourseRepository:IRepository<Course>
    {
        private readonly MyContext _context;

        public CourseRepository(MyContext context)
        {
            _context = context;
        }

        public async Task<List<Course>> GetEntitiesAsync()
        {
            return await _context.Courses.ToListAsync();
        }

        public async Task<Course> GetEntityByIdAsync(long id)
        {
            return await _context.Courses.FirstOrDefaultAsync(x => x.Id == id);
        }

        public void Add(Course entity)
        {
            _context.Courses.Add(entity);
        }

        public void Delete(Course entity)
        {
            _context.Courses.Remove(entity);
        }

        public void Update(Course entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
        
    }
}