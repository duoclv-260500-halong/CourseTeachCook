using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using CourseTeachCook.Models;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace CourseTeachCook.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult ViewCourses(int index)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            int pageSize = 10;
            Course course = new Course();
            ViewBag.courses = course.GetCourses(index, pageSize);
            ViewBag.pageSize = pageSize;
            ViewBag.index = index;
            return View();
        }
        public IActionResult ChangeNameCourse(int id)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeNameCourse(int id, string newName)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            bool result = course.ChangeName(id, newName);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeCategoryCourse(int id)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Course course = new Course();
            Category category = new Category();
            ViewBag.listCategories = category.GetCategories();
            ViewBag.course = course.GetCourseDetails(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeCategoryCourse(int id, int categoryID)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Course course = new Course();
            bool result = course.ChangeCategory(id, categoryID);
            Category category = new Category();
            ViewBag.listCategories = category.GetCategories();
            ViewBag.course = course.GetCourseDetails(id);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeDescriptionCourse(int id)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeDescriptionCourse(int id, string description)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            bool result = course.ChangeDescription(id, description);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeRate(int id)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeRate(int id, string rate)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            int rate1 = Int32.Parse(rate);
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            bool result = course.ChangeRate(id, rate1);
            ViewBag.result = result;
            return View();
        }

        public IActionResult ChangeCoursePrice(int id)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeCoursePrice(int id, int newPrice)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            bool result = course.ChangeCoursePrice(id, newPrice);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeNumberOfLessions(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeNumberOfLessions(int id, int numberOfLessions)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            bool result = course.ChangeNumberOfLessions(id, numberOfLessions);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeNumberOfDishs(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeNumberOfDishs(int id, int numberOfDishs)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            bool result = course.ChangeNumberOfDishs(id, numberOfDishs);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeNumberOfHours(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeNumberOfHours(int id, int numberOfHours)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            bool result = course.ChangeNumberOfHours(id, numberOfHours);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeMaterialPrice(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeMaterialPrice(int id, int newPrice)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            bool result = course.ChangeMaterialPrice(id, newPrice);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeNumberOfStudent(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeNumberOfStudent(int id, string numberOfStudent)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            bool result = course.ChangeNumberOfStudent(id, numberOfStudent);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeAddressLearn(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeAddressLearn(int id, string addressLearn)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            bool result = course.ChangeAddressLearn(id, addressLearn);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeDateOfOpening(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeDateOfOpening(int id, DateTime dateOfOpening)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            bool result = course.ChangeDateOfOpening(id, dateOfOpening);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeStatusCourse(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeStatusCourse(int id, int status)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            ViewBag.result = course.ChangeStatus(id, status);
            return View();
        }
        public IActionResult ChangeImageCourse(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangeImageCourse(int id, IFormFile imageCourse)
        {
            Course course = new Course();
            course = course.GetCourseDetails(id);
            ViewBag.course = course.GetCourseDetails(id);

            if (imageCourse == null)
            {
                ViewBag.resultImage = "Bạn phải chọn ảnh để cập nhật";
                return View();
            }
            string[] typeAllow = { ".jpg", ".png", ".jpeg" };
            if (!typeAllow.Contains(Path.GetExtension(imageCourse.FileName).ToLower()))
            {
                ViewBag.resultImage = "Vui lòng chọn đúng kiểu file ảnh (jpg, png, jpeg)";
                return View();
            }
            string filePath = "wwwroot/Image/ImageDesign/CourseImage";
            string fileName = imageCourse.FileName.Replace(Path.GetExtension(imageCourse.FileName), "") + ".png";
            var fileNameWithPath = string.Concat(filePath, "\\", fileName);

            var fileNameWithPath1 = string.Concat(filePath, "\\", course.FeatureImage);
            System.IO.File.Delete(fileNameWithPath1);
            bool result = course.ChangeImage(id, fileName);
            if (result)
            {
                using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                {
                    await imageCourse.CopyToAsync(stream);
                }

            }
            ViewBag.result = result;
            return View();
        }
        public IActionResult ViewCourseDetails(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            return View();
        }
        public IActionResult AddCourse()
        {
            // if (HttpContext.Session.GetString("adminName") == null)
            // {
            //     return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            // }
            Category category = new Category();
            ViewBag.listCategories = category.GetCategories();
            return View();
        }
        [HttpPost]
        public IActionResult AddCourse(int categoryID, string courseName, string courseDescription,
                                        IFormFile imageCourse, int coursePrice, int materialPrice,
                                        int numberOfSessions, int numberOfDishs, int numberOfHours,
                                        string numberOfStudent, string addressLearn, DateTime dateOfOpening)
        {
            // if (HttpContext.Session.GetString("adminName") == null)
            // {
            //     return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            // }
            Category category = new Category();
            ViewBag.listCategories = category.GetCategories();
            if (courseName == null)
            {
                ViewBag.errorName = "Tên không được bỏ trống";
                return View();
            }

            if (imageCourse == null)
            {
                ViewBag.errorImage = "Bạn phải chọn ảnh để tạo khóa học";
                return View();
            }


            string[] typeAllow = { ".jpg", ".png", ".jpeg" };
            if (!typeAllow.Contains(Path.GetExtension(imageCourse.FileName).ToLower()))
            {
                ViewBag.errorImage = "Bạn phải chọn đúng kiểu ảnh (jpg, png, jpeg)";
                return View();
            }
            if (dateOfOpening < DateTime.Now)
            {
                return Content("quá sớm");
            }
            //return Content(Path.GetExtension(file.FileName).ToLower());
            string filePath = "wwwroot/Image/ImageDesign/CourseImage";
            string fileName = imageCourse.FileName.Replace(Path.GetExtension(imageCourse.FileName), "") + ".png";
            var fileNameWithPath = string.Concat(filePath, "\\", fileName);

            using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
            {
                imageCourse.CopyToAsync(stream);
            }
            //System.IO.File.Delete(fileNameWithPath);

            Course course = new Course();
            string imageSource = fileName;
            bool result = course.AddCourse(categoryID, courseName, courseDescription, imageSource, coursePrice, materialPrice, numberOfStudent, numberOfSessions, numberOfDishs, numberOfHours, addressLearn, dateOfOpening);
            ViewBag.addCourseResult = result;
            return View();
        }
        [HttpPost]
        public IActionResult SearchCourse(string type, string price, string key)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            int price1 = Int32.Parse(price);
            ViewBag.type = type;
            ViewBag.price = price1;
            ViewBag.key = key;
            return View();
        }
        public IActionResult ViewAllCourse(int id)
        {
            Course khoahoc = new Course();

            Category danhmuc = new Category();

            ViewBag.danhmuc = danhmuc.ViewCategory(id);
            List<Course> xemtatca = khoahoc.GetAllCourse(id);
            ViewBag.ViewAllCourse = xemtatca;

            return View();
        }
        
        [HttpPost]
        public IActionResult SearchCourseCustomer(string key)
        {
            Course course = new Course();
            ViewBag.courses = course.SearchCourse(key);
            ViewBag.number = course.SearchCourse(key).Count();
            return View();
        }

    }
}