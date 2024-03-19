using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationAPI.Models;

namespace WebApplicationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [Route("All", Name ="GetAllStudents")]
        public IEnumerable<Student> GetStudents()
        {

            return CollegeRepository.Students;
        }

        [HttpGet]
        [Route("{id:int}", Name = "GetAllStudentByID")]
        public Student GetStudentById(int id)
        {
            return CollegeRepository.Students.Where(t=>t.ID==id).FirstOrDefault();
        }

        [HttpGet]
        [Route("{name:alpha}", Name = "GetAllStudentByName")]
        public Student GetStudentByName(string name)
        {
            return CollegeRepository.Students.Where(t => t.StudentName == name).FirstOrDefault();
        }

        [HttpDelete("{id}",Name = "DeleteStudentByID")]
        public bool DeleteStudent(int id)
        {
            var details = CollegeRepository.Students.Where(t => t.ID == id).FirstOrDefault();
            CollegeRepository.Students.Remove(details);
            return true;
        }

    }
}
