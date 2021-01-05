using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Homework06.Application.Models;
using Homework06.Data;
using Homework06.Models;
using Homework06.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Homework06.Controllers
{
    public class StudentController:BaseController<Student>
    {
        private readonly IRepository<Student> _stuRepository;
        private readonly IRepository<Course> _crsRepository;
        private readonly IRelationalRepository<Enrollment> _enrRepository;
        private readonly IRelationalRepository<Offer> _offRepository;

        public StudentController(
            IRepository<Student> stuRepository, 
            IRepository<Course> crsRepository,
            IRelationalRepository<Offer> offRepository,
            IRelationalRepository<Enrollment> enrRepository,
            IUnitOfWork unitOfWork) : base(stuRepository, unitOfWork)
        {
            _stuRepository = stuRepository ?? throw new ArgumentNullException(nameof(stuRepository));
            _crsRepository = crsRepository ?? throw new ArgumentNullException(nameof(crsRepository));
            _enrRepository = enrRepository ?? throw new ArgumentNullException(nameof(enrRepository));
            _offRepository = offRepository ?? throw new ArgumentNullException(nameof(offRepository));
        }
        public async Task<IActionResult> Details(long id)
        {
            var entity = await _stuRepository.GetEntityByIdAsync(id);
            if (entity != null)
                return View(entity);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> CourseList(long id)
        {
            ViewBag.Title = "请选择你上的课程";
            var entities = await _crsRepository.GetEntitiesAsync();

            var stuCrs = new CrsId
            {
                Id = id,
                Courses = entities
            };

            return View(stuCrs);
        }
        public async Task<IActionResult> SelectCourse(long stuId, long crsId)
        {
            bool hasEnrollment = await _enrRepository.EntityExistAsync(stuId, crsId);
            if (!hasEnrollment)
            {
                bool hasOffer = await _offRepository.EntityExistAsync(crsId, 0);
                if (hasOffer)
                {
                    var enrollment = new Enrollment
                    {
                        Student = await _repository.GetEntityByIdAsync(stuId),
                        Offer = await _offRepository.GetEntityByCrsId(crsId),
                        EnGrade = EnGrade.大一
                    };
                    _enrRepository.Add(enrollment);
                    await _unitOfWork.SaveAsync();
                }
            }
            return RedirectToAction(nameof(CourseController.GetStudentsByCrsId), nameof(Course), new { crsId });

        }
    }
}