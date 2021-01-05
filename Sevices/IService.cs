using System.Collections.Generic;
using System.Threading.Tasks;
using Homework06.Application.Models;

namespace Homework06.Sevices
{
    public interface IService
    {
        Task<IEnumerable<Faculty>> GetFacultyByCrsId(long id);
        Task<IEnumerable<Student>> GetStudentByCrsId(long id);
    }
}