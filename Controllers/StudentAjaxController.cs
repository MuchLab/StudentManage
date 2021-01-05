using System.Threading.Tasks;
using Homework06.Application.Models;
using Homework06.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Homework06.Controllers
{
    public class StudentAjaxController:Controller
    {
        private readonly IRepository<Student> _repository;

        public StudentAjaxController(IRepository<Student> repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public async Task<IActionResult> Update(long id)
        {
            var student = await _repository.GetEntityByIdAsync(id);
            if (student == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
    }
}