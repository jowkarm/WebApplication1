using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public string GetStudents()
        {
            return "100 students";
        }


        [HttpGet("{id}")]
        public string GetOneStudent(int id)
        {
            return "Student Number: " + id;
        }

        [HttpGet("mehdi")]
        public string GetMehdi()
        {
            return "Mehdi Jokar";
        }
    }
}
