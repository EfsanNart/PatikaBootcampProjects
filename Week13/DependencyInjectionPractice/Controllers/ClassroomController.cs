using DependencyInjectionPractice.Interfaces;
using DependencyInjectionPractice.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassroomController : ControllerBase
    {
        private readonly ITeacher _teacher;

        public ClassroomController(ITeacher teacher)
        {
            _teacher = teacher;
        }

        [HttpGet("teacher")]
        public IActionResult GetTeacherInfo()
        {
            var classroom = new Classroom(_teacher);
            return Ok(classroom.GetTeacherInfo());
        }
    }
}
