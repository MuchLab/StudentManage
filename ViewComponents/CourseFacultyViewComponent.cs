using System.Threading.Tasks;
using Homework06.Sevices;
using Microsoft.AspNetCore.Mvc;

namespace Homework06.ViewComponents
{
    public class CourseFacultyViewComponent:ViewComponent
    {
        private readonly IService _service;

        public CourseFacultyViewComponent(IService service)
        {
            _service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync(long crsId)
        {
            var faculties = await _service.GetFacultyByCrsId(crsId);
            return View(faculties);
        }
        
    }
}