using System.Collections.Generic;
using System.Threading.Tasks;
using Homework06.Application.Models;
using Homework06.Data;
using Microsoft.EntityFrameworkCore;

namespace Homework06.Repositories
{
    public class FacultyRepository:IRepository<Faculty>
    {
        private readonly MyContext _context;

        public FacultyRepository(MyContext context)
        {
            _context = context;
        }
        public async Task<List<Faculty>> GetEntitiesAsync()
        {
            return await _context.Faculties.ToListAsync();
        }

        public async Task<Faculty> GetEntityByIdAsync(long id)
        {
            return await _context.Faculties.FirstOrDefaultAsync(x => x.Id == id);
        }

        public void Add(Faculty entity)
        {
            _context.Faculties.Add(entity);
        }

        public void Delete(Faculty entity)
        {
            _context.Faculties.Remove(entity);
        }

        public void Update(Faculty entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}