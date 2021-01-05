using System.Collections.Generic;
using System.Threading.Tasks;
using Homework06.Application.Models;

namespace Homework06.Repositories
{
    public interface IRepository<TEntity>
    {
        Task<List<TEntity>> GetEntitiesAsync();
        Task<TEntity> GetEntityByIdAsync(long id);
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}