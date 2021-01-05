using System.Threading.Tasks;
using Homework06.Data;

namespace Homework06.Repositories
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly MyContext _context;

        public UnitOfWork(MyContext context)
        {
            _context = context;
        }
        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}