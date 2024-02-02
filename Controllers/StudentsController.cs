using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly StudentContext _context;

        public StudentsController(StudentContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();

        }




        [HttpGet]
        public List<Student> GetStudents()
        {
            return _context.Students.ToList();
        }


        [HttpGet("{id}")]
        public Student GetOneStudent(int id)
        {
            Student? student = _context.Students
                .FirstOrDefault(student => student.Id == id);

            if (student != null)
            {
                return student;
            }
            else
            {
                throw new Exception("Invalid Id!");
            }
            
        }

      

        
    }
}
