using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAPI.Models
{
    public static class CollegeRepository
    {
        public static List<Student> Students {  get; set; } = new List<Student>(){
                new Student
                {
                    ID = 1,
                    StudentName = "John",
                    Email = "JohnSnow@gmail.com",
                    Address = "US"

                },
                new Student
                {
                    ID = 2,
                    StudentName = "Max",
                    Email = "MaxWell@gmail.com",
                    Address = "US"

                }
            };
    }
}
