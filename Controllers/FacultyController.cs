using System.Threading.Tasks;
using Homework06.Application.Models;
using Homework06.Models;
using Homework06.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Homework06.Controllers
{
    public class FacultyController:BaseController<Faculty>
    {
        private readonly IRelationalRepository<Offer> _offRepository;
        private readonly IRepository<Course> _crsRepository;

        public FacultyController(IRepository<Faculty> repository, 
            IUnitOfWork unitOfWork,
            IRelationalRepository<Offer> offRepository,
            IRepository<Course> crsRepository) 
            : base(repository, unitOfWork)
        {
            _offRepository = offRepository;
            _crsRepository = crsRepository;
        }

        public async Task<IActionResult> Details(long id)
        {
            var entity = await _repository.GetEntityByIdAsync(id);
            if (entity != null)
                return View(entity);

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> CourseList(long id)
        {
            ViewBag.Title = "请选择你辅导的课程";
            var entities = await _crsRepository.GetEntitiesAsync();

            var facCrs = new CrsId
            {
                Id = id,
                Courses = entities
            };

            return View(facCrs);
        }
        public async Task<IActionResult> SelectCourse(long facId, long crsId)
        {
            if (await _offRepository.EntityExistAsync(facId, crsId)) 
                return RedirectToAction(nameof(Details), routeValues: new {id = facId});
            var offer = new Offer
            {
                Faculty = await _repository.GetEntityByIdAsync(facId),
                Course = await _crsRepository.GetEntityByIdAsync(crsId)
            };
            _offRepository.Add(offer);
            await _unitOfWork.SaveAsync();
            return RedirectToAction(nameof(CourseController.GetFacultiesByCrsId), 
                nameof(Course),
                routeValues: new {crsId});
        }
    }
}