using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework06.Application.Models;
using Homework06.Data;
using Microsoft.EntityFrameworkCore;

namespace Homework06.Repositories
{
    public class OfferRepository:IRelationalRepository<Offer>
    {
        private readonly MyContext _myContext;

        public OfferRepository(MyContext myContext)
        {
            _myContext = myContext;
        }
        public async Task<IEnumerable<Offer>> GetEntityByRightAsync(long id)
        {
            return await _myContext.Offers.Where(x => x.FacID == id).ToListAsync();
        }
        public async Task<IEnumerable<Offer>> GetEntityByLeftAsync(long id)
        {
            return await _myContext.Offers.Where(x => x.CourseId == id).ToListAsync();
        }
        public async Task<bool> EntityExistAsync(long crsId, long facId)
        {
            if (facId == 0)
            {
                return await _myContext.Offers.Where(x => x.CourseId == crsId).AnyAsync();
            }
            return await _myContext.Offers.Where(x => x.CourseId == crsId && x.FacID == facId).AnyAsync();
        }
        public async Task<Offer> GetEntityByCrsId(long crsId)
        {
            return await _myContext.Offers.FirstOrDefaultAsync(x => x.CourseId == crsId);
        }
        public void Add(Offer entity)
        {
            _myContext.Offers.Add(entity);
        }
    }
}