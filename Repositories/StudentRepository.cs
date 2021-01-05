using System.Collections.Generic;
using System.Threading.Tasks;
using Homework06.Application.Models;
using Homework06.Data;
using Microsoft.EntityFrameworkCore;

namespace Homework06.Repositories
{
    public class StudentRepository:IRepository<Student>
    {
        private readonly MyContext _context;

        public StudentRepository(MyContext context)
        {
            _context = context;
        }
        public async Task<List<Student>> GetEntitiesAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<Student> GetEntityByIdAsync(long id)
        {
            return await _context.Students.FirstOrDefaultAsync(x => x.Id == id);
        }

        public void Add(Student entity)
        {
            _context.Students.Add(entity);
        }

        public void Delete(Student entity)
        {
            _context.Remove(entity);
        }

        public void Update(Student entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}