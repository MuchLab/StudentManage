using System;
using System.Threading.Tasks;
using Homework06.Application.Models;
using Homework06.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Homework06.Controllers
{
    public abstract class BaseController<TEntity> : Controller where TEntity : Entity<long>
    {
        protected IRepository<TEntity> _repository;
        protected IUnitOfWork _unitOfWork;

        protected BaseController(IRepository<TEntity> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _unitOfWork = unitOfWork ?? throw new ArgumentNullException(nameof(unitOfWork));
        }
        public async Task<ActionResult> Index()
        {
            var entities = await _repository.GetEntitiesAsync();
            return View(entities);
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(TEntity model)
        {
            if (ModelState.IsValid)
            {
                _repository.Add(model);
                await _unitOfWork.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        public async Task<IActionResult> Update(long id)
        {
            var entity = await _repository.GetEntityByIdAsync(id);
            if (entity == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(entity);
        }
        [HttpPost]
        public async Task<IActionResult> Update(TEntity model)
        {
            if (ModelState.IsValid)
            {
                _repository.Update(model);
                await _unitOfWork.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        public async Task<IActionResult> Delete(long id)
        {
            var entity = await _repository.GetEntityByIdAsync(id);
            if (entity != null)
            {
                _repository.Delete(entity);
                await _unitOfWork.SaveAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}