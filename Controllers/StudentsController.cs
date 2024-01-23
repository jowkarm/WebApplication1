using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        private List<Student> students = new List<Student>{
            new Student(0, "William", "Taylor", "william.taylor@example.com", "333-444-5555"),
            new Student(1, "John", "Doe", "john.doe@example.com", "123-456-7890"),
            new Student(2, "Jane", "Smith", "jane.smith@example.com", "987-654-3210"),
            new Student(3, "Alice", "Johnson", "alice.johnson@example.com", "555-123-4567"),
            new Student(4, "Bob", "Williams", "bob.williams@example.com", "444-789-0123"),
            new Student(5, "Eva", "Brown", "eva.brown@example.com", "789-012-3456"),
            new Student(6, "Michael", "Lee", "michael.lee@example.com", "111-222-3333"),
            new Student(7, "Olivia", "Miller", "olivia.miller@example.com", "777-888-9999"),
            new Student(8, "Daniel", "Davis", "daniel.davis@example.com", "222-333-4444"),
            new Student(9, "Sophia", "Moore", "sophia.moore@example.com", "666-777-8888")
        };




        [HttpGet]
        public List<Student> GetStudents()
        {
            return students;
        }


        [HttpGet("{id}")]
        public Student GetOneStudent(int id)
        {
            Student student = students[id];
            return student;
        }

        [HttpPost("add-student")]
        public List<Student> AddStudent([FromBody] Student newStudent)
        {
            students.Add(newStudent);

            return students;

        }

        
    }
}
