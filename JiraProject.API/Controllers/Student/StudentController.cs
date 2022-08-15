using JiraProject.Services.MenuServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JiraProject.API.Controllers.Student
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService _studentService)
        {
            studentService = _studentService;
        }
        [HttpGet]
        [Route("/[controller]/GetAllStudents")]
        [Produces("application/json")]
        public async Task<IActionResult> GetAllStudents()
        {
            return Ok();
        }
    }
}
