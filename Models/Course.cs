using System;
using System.Collections.Generic;
using System.Linq;
#nullable disable

namespace CourseTeachCook.Models
{
    public partial class Course
    {
        public Course()
        {
            Imagescourses = new HashSet<Imagescourse>();
        }

        public int CourseId { get; set; }
        public int? CategoryId { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public int CourseRates { get; set; }
        public int CoursePrice { get; set; }
        public int MaterialPrice { get; set; }
        public int NumberOfSession { get; set; }
        public int NumberOfDishs { get; set; }
        public int NumberOfHours { get; set; }
        public string FeatureImage { get; set; }
        public string NumberOfStudent { get; set; }
        public string AddressLearn { get; set; }
        public DateTime DateOfOpening { get; set; }
        public int Status { get; set; }
        public int Views { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<Imagescourse> Imagescourses { get; set; }
        public List<Course> ViewListCourses()
        {
            using (var system = new CourseTeachingCookContext())
            {
                List<Course> courses = new List<Course>();
                courses = system.Courses.OrderByDescending(c => c.CourseId).ToList();
                return courses;
            }
        }

        public bool AddCourse(int categoryID, string courseName, string courseDescription, string imageSource,
                            int coursePrice, int materialPrice, string numberOfStudent,
                            int numberOfSessions, int numberOfDishs, int numberOfHours,
                            string addressLearn, DateTime dateOfOpening)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Course course = new Course();
                course.CategoryId = categoryID;
                course.CourseName = courseName;
                course.CourseDescription = courseDescription;
                course.CourseRates = 1;
                course.CoursePrice = coursePrice;
                course.MaterialPrice = materialPrice;
                course.NumberOfSession = numberOfSessions;
                course.NumberOfDishs = numberOfDishs;
                course.NumberOfHours = numberOfHours;
                course.FeatureImage = imageSource;
                course.NumberOfStudent = numberOfStudent;
                course.AddressLearn = addressLearn;
                course.DateOfOpening = dateOfOpening;
                course.Status = 1;
                course.Views = 0;
                system.Courses.Add(course);
                try
                {
                    if (system.SaveChanges() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {
                    throw;
                }

            }
        }

        public List<Course> GetAllCourse(int id)
        {
            using (var connect = new CourseTeachingCookContext())
            {

                List<Course> ViewAllCourse = new List<Course>();

                ViewAllCourse = connect.Courses.Where(C => C.CategoryId == id).ToList();

                return ViewAllCourse;
            }
        }
        public List<Course> GetListKhoahochot()
        {
            using (var connect = new CourseTeachingCookContext())
            {
                List<Course> danhsachkhoahochot = new List<Course>();
                danhsachkhoahochot = connect.Courses.OrderByDescending(C => C.CourseRates).Take(12).ToList();

                return danhsachkhoahochot;
            }
        }

        public List<Course> GetListNghebep()
        {
            using (var connect = new CourseTeachingCookContext())
            {
                List<Course> danhsachkhoahoc = new List<Course>();

                danhsachkhoahoc = connect.Courses.Where(C => C.CategoryId == 1).Take(6).ToList();

                return danhsachkhoahoc;


            }
        }


        public List<Course> GetListGiadinh()
        {
            using (var connect = new CourseTeachingCookContext())
            {
                List<Course> danhsachgiadinh = new List<Course>();

                danhsachgiadinh = connect.Courses.Where(C => C.CategoryId == 2).Take(6).ToList();

                return danhsachgiadinh;


            }
        }

        public List<Course> GetListTrevaobep()
        {
            using (var connect = new CourseTeachingCookContext())
            {
                List<Course> danhsachtre = new List<Course>();

                danhsachtre = connect.Courses.Where(C => C.CategoryId == 3).Take(6).ToList();

                return danhsachtre;


            }
        }
        public List<Course> GetListCake()
        {
            using (var connect = new CourseTeachingCookContext())
            {
                List<Course> danhsachcake = new List<Course>();

                danhsachcake = connect.Courses.Where(C => C.CategoryId == 4).Take(6).ToList();

                return danhsachcake;


            }
        }

        public List<Course> GetListBartender()
        {
            using (var connect = new CourseTeachingCookContext())
            {
                List<Course> danhsachban = new List<Course>();

                danhsachban = connect.Courses.Where(C => C.CategoryId == 5).Take(6).ToList();

                return danhsachban;


            }
        }

        public List<Course> GetListvisual_arts()
        {
            using (var connect = new CourseTeachingCookContext())
            {
                List<Course> danhsacharts = new List<Course>();

                danhsacharts = connect.Courses.Where(C => C.CategoryId == 6).Take(6).ToList();

                return danhsacharts;


            }
        }

        public List<Course> GetListworld_cuisine()
        {
            using (var connect = new CourseTeachingCookContext())
            {
                List<Course> danhsachworld = new List<Course>();

                danhsachworld = connect.Courses.Where(C => C.CategoryId == 7).Take(6).ToList();

                return danhsachworld;


            }
        }
        public Course GetCourse(int id)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Course course = system.Courses.Find(id);
                
                return course;
            }
        }
        public List<Course> SearchCourse(string key){
            using(var system = new CourseTeachingCookContext()){
                List<Course> courses = system.Courses.Where(c=>c.CourseName.Contains(key)).ToList();
                return courses;
            }
        }
         public Course GetCourseCus(int id)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Course course = system.Courses.Find(id);
                course.Views += 1;
                system.Update(course);
                system.SaveChanges();
                return course;
            }
        }
        public List<Course> GetCourses(int index, int pageSize){
            using(var system = new CourseTeachingCookContext()){
                List<Course> courses = system.Courses.OrderByDescending(c=>c.CourseId).Skip(index*pageSize).Take(pageSize).ToList();
                return courses;
            }
        }
        public List<Course> SearchCourse(string type, int price, string key)
        {
            using (var system = new CourseTeachingCookContext())
            {
                List<Course> courses = new List<Course>();
                if (key == "" || key == null)
                {
                    switch (price)
                    {
                        case 0:
                            courses = system.Courses.ToList();
                            break;
                        case 1:
                            courses = system.Courses.Where(c => c.CoursePrice <= 5000000).ToList();
                            break;
                        case 2:
                            courses = system.Courses.Where(c => c.CoursePrice >= 5000000)
                                                    .Where(c => c.CoursePrice <= 10000000).ToList();

                            break;
                        case 3:
                            courses = system.Courses.Where(c => c.CoursePrice >= 10000000).ToList();

                            break;
                    }
                    return courses;
                }
                if (type.Equals("name"))
                {
                    switch (price)
                    {
                        case 0:
                            courses = system.Courses.Where(c => c.CourseName.Contains(key)).ToList();
                            break;
                        case 1:
                            courses = system.Courses.Where(c => c.CourseName.Contains(key))
                                                    .Where(c => c.CoursePrice <= 5000000).ToList();
                            break;
                        case 2:
                            courses = system.Courses.Where(c => c.CourseName.Contains(key))
                                                    .Where(c => c.CoursePrice >= 5000000)
                                                    .Where(c => c.CoursePrice <= 10000000).ToList();
                            break;
                        case 3:
                            courses = system.Courses.Where(c => c.CourseName.Equals(key))
                                                    .Where(c => c.CoursePrice >= 10000000)
                                                    .Where(c => c.CoursePrice <= 15000000).ToList();
                            break;
                    }
                }
                else if (type.Equals("category"))
                {
                    List<Category> categories = system.Categories.Where(c => c.CategoryName.Contains(key)).ToList();
                    foreach (Category category in categories)
                    {
                        switch (price)
                        {
                            case 0:
                                List<Course> courses1 = system.Courses.Where(c => c.CategoryId.Equals(category.CategoryId)).ToList();
                                foreach (Course course in courses1)
                                {
                                    //courses.Append(course);
                                    courses.Add(course);
                                }
                                break;
                            case 1:
                                List<Course> courses2 = system.Courses.Where(c => c.CategoryId.Equals(category.CategoryId))
                                                        .Where(c => c.CoursePrice <= 5000000).ToList();
                                foreach (Course course in courses2)
                                {
                                    //courses.Append(course);
                                    courses.Add(course);
                                }

                                break;
                            case 2:
                                List<Course> courses3 = system.Courses.Where(c => c.CategoryId.Equals(category.CategoryId))
                                                        .Where(c => c.CoursePrice >= 5000000)
                                                        .Where(c => c.CoursePrice <= 10000000).ToList();
                                foreach (Course course in courses3)
                                {
                                    //courses.Append(course);
                                    courses.Add(course);
                                }

                                break;
                            case 3:
                                List<Course> courses4 = system.Courses.Where(c => c.CategoryId.Equals(category.CategoryId))
                                                        .Where(c => c.CoursePrice >= 10000000).ToList();
                                foreach (Course course in courses4)
                                {
                                    //courses.Append(course);
                                    courses.Add(course);
                                }

                                break;
                        }


                    }

                }
                else if (type.Equals("dateOfOpening"))
                {
                    DateTime date = Convert.ToDateTime(key);

                    switch (price)
                    {
                        case 0:
                            courses = system.Courses.Where(c => c.DateOfOpening <= date).ToList();
                            break;
                        case 1:
                            courses = system.Courses.Where(c => c.DateOfOpening <= date)
                                                    .Where(c => c.CoursePrice <= 5000000).ToList();

                            break;
                        case 2:
                            courses = system.Courses.Where(c => c.DateOfOpening <= date)
                                                    .Where(c => c.CoursePrice >= 5000000)
                                                    .Where(c => c.CoursePrice <= 10000000).ToList();

                            break;
                        case 3:
                            courses = system.Courses.Where(c => c.DateOfOpening <= date)
                                                    .Where(c => c.CoursePrice >= 10000000).ToList();

                            break;
                    }
                }
                return courses;
            }
        }
        public bool ChangeName(int id, string newName)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Course course = system.Courses.Find(id);
                course.CourseName = newName;
                system.Courses.Update(course);
                try
                {
                    if (system.SaveChanges() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {
                    return false;
                    throw;
                }
            }
        }
        public bool ChangeRate(int id, int rate)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Course course = system.Courses.Find(id);
                course.CourseRates = rate;
                system.Courses.Update(course);
                try
                {
                    if (system.SaveChanges() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {
                    return false;
                    throw;
                }
            }
        }
        public bool ChangeStatus(int id, int status)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Course course = system.Courses.Find(id);
                course.Status = status;
                system.Courses.Update(course);
                try
                {
                    if (system.SaveChanges() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {

                    throw;
                }
            }
        }
        public bool ChangeCategory(int id, int categoryID)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Course course = system.Courses.Find(id);
                course.CategoryId = categoryID;
                system.Courses.Update(course);
                try
                {
                    if (system.SaveChanges() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {
                    return false;
                    throw;
                }

            }
        }
        public bool ChangeDescription(int id, string description)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Course course = system.Courses.Find(id);
                course.CourseDescription = description;
                system.Courses.Update(course);
                try
                {
                    if (system.SaveChanges() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {
                    return false;
                    throw;
                }
            }
        }

        public bool ChangeCoursePrice(int id, int newPrice)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Course course = system.Courses.Find(id);
                course.CoursePrice = newPrice;
                system.Courses.Update(course);
                try
                {
                    if (system.SaveChanges() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {
                    return false;

                    throw;
                }
            }

        }
        public bool ChangeNumberOfLessions(int id, int numberOfLessions)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Course course = system.Courses.Find(id);
                course.NumberOfSession = numberOfLessions;
                system.Courses.Update(course);
                try
                {
                    if (system.SaveChanges() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {
                    return false;

                    throw;
                }
            }

        }
        public bool ChangeNumberOfDishs(int id, int numberOfDishs)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Course course = system.Courses.Find(id);
                course.NumberOfDishs = numberOfDishs;
                system.Courses.Update(course);
                try
                {
                    if (system.SaveChanges() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {
                    return false;

                    throw;
                }
            }

        }
        public bool ChangeNumberOfHours(int id, int numberOfHours)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Course course = system.Courses.Find(id);
                course.NumberOfHours = numberOfHours;
                system.Courses.Update(course);
                try
                {
                    if (system.SaveChanges() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {
                    return false;

                    throw;
                }
            }

        }
        public bool ChangeMaterialPrice(int id, int newPrice)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Course course = system.Courses.Find(id);
                course.MaterialPrice = newPrice;
                system.Courses.Update(course);
                try
                {
                    if (system.SaveChanges() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {
                    return false;
                    throw;
                }
            }

        }
        public bool ChangeNumberOfStudent(int id, string numberOfStudent)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Course course = system.Courses.Find(id);
                course.NumberOfStudent = numberOfStudent;
                system.Courses.Update(course);
                try
                {
                    if (system.SaveChanges() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {
                    return false;
                    throw;
                }
            }

        }
        public bool ChangeAddressLearn(int id, string addressLearn)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Course course = system.Courses.Find(id);
                course.AddressLearn = addressLearn;
                system.Courses.Update(course);
                try
                {
                    if (system.SaveChanges() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {
                    return false;
                    throw;
                }
            }
        }
        public bool ChangeDateOfOpening(int id, DateTime dateOfOpening)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Course course = system.Courses.Find(id);
                course.DateOfOpening = dateOfOpening;
                system.Courses.Update(course);
                try
                {
                    if (system.SaveChanges() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {
                    return false;
                    throw;
                }
            }
        }
        public bool ChangeImage(int id, string imageSource)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Course course = system.Courses.Find(id);
                course.FeatureImage = imageSource;
                system.Courses.Update(course);
                try
                {
                    if (system.SaveChanges() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {
                    return false;
                    throw;
                }
            }
        }
    }
}
