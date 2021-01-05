using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Homework06.Application.Models;
using Homework06.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Homework06.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentApiController:ControllerBase
    {
        private readonly IRepository<Student> _studentRepository;
        private readonly IUnitOfWork _unitOfWork;

        public StudentApiController(IRepository<Student> studentRepository, IUnitOfWork unitOfWork)
        {
            _studentRepository = studentRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetStudentsAsync()
        {
            var students = await _studentRepository.GetEntitiesAsync();
            var data = new
            {
                code=0,
                data=students
            };
            return Ok(data);
        }
        [HttpGet("{studentId}", Name = nameof(GetStudentAsync))]
        public async Task<ActionResult<Student>> GetStudentAsync(long studentId)
        {
            var student = await _studentRepository.GetEntityByIdAsync(studentId);
            if (student==null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _studentRepository.Add(student);
            if (!await _unitOfWork.SaveAsync())
            {
                throw new Exception("Create Student Failed.");
            }

            return NoContent();
        }
        [HttpDelete("{studentId}")]
        public async Task<IActionResult> DeleteStudent(long studentId)
        {
            var student = await _studentRepository.GetEntityByIdAsync(studentId);
            if (student == null)
            {
                return NotFound();
            }

            _studentRepository.Delete(student);
            if (!await _unitOfWork.SaveAsync())
            {
                throw new Exception("Delete Student Failed.");
            }
            return NoContent();
        }
        [HttpPut("{studentId}")]
        public async Task<IActionResult> UpdateStudent(long studentId, Student updateStudent)
        {
            var student = await _studentRepository.GetEntityByIdAsync(studentId);
            if (student == null)
            {
                return NotFound();
            }

            student.City = updateStudent.City;
            student.Class = updateStudent.Class;
            student.FirstName = updateStudent.FirstName;
            student.LastName = updateStudent.LastName;
            student.GPA = updateStudent.GPA;
            student.Major = updateStudent.Major;
            student.State = updateStudent.State;
            student.ZipCode = updateStudent.ZipCode;
            _studentRepository.Update(student);
            if (!await _unitOfWork.SaveAsync())
            {
                throw new Exception("Delete Student Failed.");
            }
            return NoContent();
        }
    }
}