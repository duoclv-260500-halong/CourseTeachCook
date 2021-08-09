using System;
using System.Collections.Generic;
using System.Linq;
#nullable disable

namespace CourseTeachCook.Models
{
    public partial class Teacher
    {
        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherDescription { get; set; }
        public string TeacherImage { get; set; }
        public List<Teacher> GetListTeacher()
        {
            using (var connect = new CourseTeachCookContext())
            {
                List<Teacher> danhsachgiangvien = new List<Teacher>();
                danhsachgiangvien = connect.Teachers.Take(12).ToList();
                return danhsachgiangvien;
            }
        }
    }
}
