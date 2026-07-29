using Microsoft.AspNetCore.Mvc; // Fixes the .Mcs typo
using StudentManagementApi.Models;

namespace StudentManagementApi.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase // Defines the actual class
    {
        // Static in-memory storage for runtime data persistence
        private static readonly List<Student> _students = new List<Student>
        {
            new Student { 
                Id = 1, Name = "Alice Smith", Email = "alice@example.com", 
                Subjects = new List<Subject> { new Subject { Id = 101, Name = "Mathematics", Code = "MATH101" } } 
            },
            new Student { 
                Id = 2, Name = "Bob Jones", Email = "bob@example.com", 
                Subjects = new List<Subject> { new Subject { Id = 102, Name = "Computer Science", Code = "CS102" } } 
            },
            new Student { 
                Id = 3, Name = "Charlie Brown", Email = "charlie@example.com", 
                Subjects = new List<Subject> { new Subject { Id = 101, Name = "Mathematics", Code = "MATH101" }, new Subject { Id = 103, Name = "Physics", Code = "PHYS103" } } 
            },
            new Student { 
                Id = 4, Name = "Diana Prince", Email = "diana@example.com", 
                Subjects = new List<Subject> { new Subject { Id = 104, Name = "Chemistry", Code = "CHEM104" } } 
            },
            new Student { 
                Id = 5, Name = "Evan Wright", Email = "evan@example.com", 
                Subjects = new List<Subject> { new Subject { Id = 102, Name = "Computer Science", Code = "CS102" } } 
            }
        };

        // GET: api/students
        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetAllStudents()
        {
            return Ok(_students);
        }

        // GET: api/students/{id}
        [HttpGet("{id}")]
        public ActionResult<Student> GetStudentById(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound($"Student with ID {id} not found.");
            }
            return Ok(student);
        }

        // GET: api/students/{id}/subjects
        [HttpGet("{id}/subjects")]
        public ActionResult<IEnumerable<Subject>> GetStudentSubjects(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound($"Student with ID {id} not found.");
            }
            return Ok(student.Subjects);
        }

        // POST: api/students
        [HttpPost]
        public ActionResult<Student> CreateStudent([FromBody] Student newStudent)
        {
            newStudent.Id = _students.Count > 0 ? _students.Max(s => s.Id) + 1 : 1;
            _students.Add(newStudent);
            return CreatedAtAction(nameof(GetStudentById), new { id = newStudent.Id }, newStudent);
        }

        // PUT: api/students/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, [FromBody] Student updatedStudent)
        {
            var existingStudent = _students.FirstOrDefault(s => s.Id == id);
            if (existingStudent == null)
            {
                return NotFound($"Student with ID {id} not found.");
            }

            existingStudent.Name = updatedStudent.Name;
            existingStudent.Email = updatedStudent.Email;
            existingStudent.Subjects = updatedStudent.Subjects;

            return NoContent(); 
        }

        // DELETE: api/students/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = _students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound($"Student with ID {id} not found.");
            }

            _students.Remove(student);
            return NoContent();
        }
    }
}