using Excercise1_API.Data;
using Excercise1_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Excercise1_API.Controllers.StudentControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private List<Student> students= new List<Student>();
        public StudentController()
        {
            students.Add(new Student
            {
                Id = 1,
                Name = "Nguyen Le Nhat Thanh",
                BirthDay = new DateOnly(2002, 01, 01).ToString(),
                Adress = "Tp HCM",
                Gender = "Male",
                Description = "This is description",
                Detailinfomation = "This is detail information"
            });
            students.Add(new Student
            {
                Id = 2,
                Name = "Do Quoc Bao",
                BirthDay = new DateOnly(2001, 02, 03).ToString(),
                Adress = "Dong Nai",
                Gender = "Male",
                Description = "This is description",
                Detailinfomation = "This is detail information"
            });
            students.Add(new Student
            {
                Id = 3,
                Name = "Tran Thanh Tuyen",
                BirthDay = new DateOnly(2000, 01, 04).ToString(),
                Adress = "Binh Duong",
                Gender = "Female",
                Description = "This is description",
                    Detailinfomation = "This is detail information"
            });
            students.Add(new Student
            {
                Id = 4,
                Name = "Truong Huy Hoang",
                BirthDay = new DateOnly(1999, 01, 03).ToString(),
                Adress = "Ha Noi",
                Gender = "Female",
                Description = "This is description",
                Detailinfomation = "This is detail information"
            });
            students.Add(new Student
            {
                Id = 5,
                Name = "Nguyen Thi Thu Trang",
                BirthDay = new DateOnly(2003, 10, 06).ToString(),
                Adress = "Can Tho",
                Gender = "Female",
                Description = "This is description",
                Detailinfomation = "This is detail information"
            });
        }
        [HttpGet]
        public IActionResult GetAllStudent()
        {       
            List<StudentModel> studentmodels = new List<StudentModel>();
            foreach(var student in students)
            {
                StudentModel studentmodel = new StudentModel();
                studentmodel.Id = student.Id;
                studentmodel.Name = student.Name;
                studentmodel.BirthDay = student.BirthDay;
                studentmodel.Adress = student.Adress;
                studentmodel.Gender = student.Gender;
                studentmodel.Description = student.Description;
                studentmodels.Add(studentmodel);
            }
            return Ok(studentmodels);
        }
        [HttpGet("id")]
        public IActionResult GetStudentDetail(int id)
        {
            StudentDetailModel studentdetailmodel = new StudentDetailModel();
            var student = students.FirstOrDefault(student => student.Id == id);
            if(student == null)
            {
                return BadRequest("Student Doesn't Exist!");
            }
            studentdetailmodel.Id = student.Id;
            studentdetailmodel.Name = student.Name;
            studentdetailmodel.BirthDay = student.BirthDay;
            studentdetailmodel.Adress = student.Adress;
            studentdetailmodel.Gender = student.Gender;
            studentdetailmodel.Description = student.Description;
            studentdetailmodel.Detailinfomation = student.Detailinfomation;       
            
            return Ok(studentdetailmodel);
        }
    }
}
