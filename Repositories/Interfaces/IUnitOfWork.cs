using System.Threading.Tasks;
using Homework06.Application.Models;

namespace Homework06.Repositories
{
    public interface IUnitOfWork
    {
        Task<bool> SaveAsync();
    }
}