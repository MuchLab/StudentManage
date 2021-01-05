using System.Threading.Tasks;
using Homework06.Application.Models;
using Homework06.Repositories;
using Homework06.Sevices;
using Microsoft.AspNetCore.Mvc;

namespace Homework06.Controllers
{
    public class CourseController:BaseController<Course>
    {
        private readonly IService _service;
        //private readonly IRepository<Course> _repository;
        //private readonly IUnitOfWork _unitOfWork;

        public CourseController(IRepository<Course> repository,
            IService service,
            IUnitOfWork unitOfWork) 
            : base(repository, unitOfWork)
        {
            _service = service;
            //_repository = repository;
            //_unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> GetFacultiesByCrsId(long crsId)
        {
            var entity = await _repository.GetEntityByIdAsync(crsId);
            if (entity == null)
                return RedirectToAction(nameof(Index));

            ViewBag.Title = $"辅导{entity.CrsDesc}课程的教师";
            var faculties = await _service.GetFacultyByCrsId(crsId);

            return View(faculties);
        }
        public async Task<IActionResult> GetStudentsByCrsId(long crsId)
        {
            var entity = await _repository.GetEntityByIdAsync(crsId);
            if (entity == null)
                return RedirectToAction(nameof(Index));

            ViewBag.Title = $"选择上{entity.CrsDesc}课程的学生";
            var students = await _service.GetStudentByCrsId(crsId);

            return View(students);
        }
    }
}