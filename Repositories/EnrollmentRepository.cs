using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Homework06.Application.Models;
using Homework06.Data;
using Microsoft.EntityFrameworkCore;

namespace Homework06.Repositories
{
    public class EnrollmentRepository:IRelationalRepository<Enrollment>
    {
        private readonly MyContext _myContext;

        public EnrollmentRepository(MyContext myContext)
        {
            _myContext = myContext;
        }
        public async Task<IEnumerable<Enrollment>> GetEntityByLeftAsync(long id)
        {
                
            return await _myContext.Enrollments.Where(x => x.StuId == id).ToListAsync();

        }
        public async Task<IEnumerable<Enrollment>> GetEntityByRightAsync(long id)
        {
            return await _myContext.Enrollments.Where(x => x.OfferNo == id).ToListAsync();
        }

        public async Task<bool> EntityExistAsync(long stuId, long crsId)
        {
            var offers = await _myContext.Offers
                .Where(x => x.CourseId == crsId)
                .ToListAsync();
            var enrollments = await _myContext.Enrollments
                .Where(x => x.StuId == stuId)
                .ToListAsync();
            return enrollments.Any(x => offers.Any(y => y.OfferNo == x.OfferNo));
        }
        public void Add(Enrollment entity)
        {
            _myContext.Enrollments.Add(entity);
        }

        public Task<Enrollment> GetEntityByCrsId(long crsId)
        {
            throw new System.NotImplementedException();
        }
    }
}