using Excercise1_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Excercise1_API.Controllers.StudentControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private List<StudentModel> students= new List<StudentModel>();
        public StudentController()
        {
            students.Add(new StudentModel
            {
                Id = 1,
                Name = "Nguyen Le Nhat Thanh",
                BirthDay = new DateOnly(2002, 01, 01).ToString(),
                Adress = "Tp HCM",
                Gender = "Male",
                Description = "This is description",
            });
            students.Add(new StudentModel
            {
                Id = 2,
                Name = "Do Quoc Bao",
                BirthDay = new DateOnly(2001, 02, 03).ToString(),
                Adress = "Dong Nai",
                Gender = "Male",
                Description = "This is description",
            });
            students.Add(new StudentModel
            {
                Id = 3,
                Name = "Tran Thanh Tuyen",
                BirthDay = new DateOnly(2000, 01, 04).ToString(),
                Adress = "Binh Duong",
                Gender = "Female",
                Description = "This is description",
            });
        }
        [HttpGet]
        public IActionResult GetAllStudent()
        {           
            return Ok(students);
        }
        [HttpGet("id")]
        public IActionResult GetStudentDetail(int id)
        {
            var student = students.FirstOrDefault(student => student.Id == id);
            return Ok(student);
        }
    }
}
