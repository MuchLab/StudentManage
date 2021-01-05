using System.Collections.Generic;
using System.Threading.Tasks;
using Homework06.Application.Models;

namespace Homework06.Repositories
{
    public interface IRelationalRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetEntityByRightAsync(long id);
        Task<IEnumerable<TEntity>> GetEntityByLeftAsync(long id);
        Task<bool> EntityExistAsync(long stuId, long offNo);
        Task<TEntity> GetEntityByCrsId(long crsId);
        void Add(TEntity entity);
    }
}