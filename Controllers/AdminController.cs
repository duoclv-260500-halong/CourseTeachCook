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
    public class AdminController : Controller
    {
        public IActionResult Index(string firstDate, string secondDate)
        {
            DateTime firstDate1 = new DateTime();
            DateTime secondDate1 = new DateTime();
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            if (firstDate == null && secondDate != null)
            {
                DateTime date = DateTime.Now;
                firstDate1 = new DateTime(date.Year, date.Month, 1);
                secondDate1 = DateTime.Parse(secondDate);
            }
            else if (secondDate == null && firstDate != null)
            {
                firstDate1 = DateTime.Parse(firstDate);
                secondDate1 = DateTime.Today;
            }
            else if (firstDate == null && secondDate == null)
            {
                DateTime date = DateTime.Now;
                firstDate1 = new DateTime(date.Year, date.Month, 1);
                secondDate1 = DateTime.Today;
            }
            else
            {
                firstDate1 = DateTime.Parse(firstDate);
                secondDate1 = DateTime.Parse(secondDate);
            }
            ViewBag.firstDate = firstDate1.ToString("dd/MM/yyyy");
            ViewBag.secondDate = secondDate1.ToString("dd/MM/yyyy");
            Order order = new Order();
            if (firstDate1 > secondDate1)
            {
                ViewBag.orders = order.GetOrderByTimeRange(secondDate1, firstDate1);
            }
            else
            {
                ViewBag.orders = order.GetOrderByTimeRange(firstDate1, secondDate1);
            }
            Customer customer = new Customer();
            if (firstDate1 > secondDate1)
            {
                ViewBag.NumberOfNewCustomer = customer.GetNumberOfNewCustomer(secondDate1, firstDate1);
            }
            else
            {
                ViewBag.NumberOfNewCustomer = customer.GetNumberOfNewCustomer(firstDate1, secondDate1);
            }

            return View();
        }
        public IActionResult ViewStaffs(int index)
        {
            // if (HttpContext.Session.GetString("adminName") == null)
            // {
            //     return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            // }
            int pageSize = 10;
            Staff staff = new Staff();

            ViewBag.staffs = staff.GetStaffs(index, pageSize);
            ViewBag.pageSize = pageSize;
            ViewBag.index = index;
            return View();
        }
        public IActionResult PrintOrder(int id)
        {
            Contactsinformation hotline = new Contactsinformation();
            ViewBag.hotline = hotline.GetHotLine();
            Order order = new Order();
            order = order.GetOrder(id);
            Customer customer = new Customer();
            customer = customer.GetCustomer(order.CustomerId);
            ViewBag.customer = customer;
            Orderdetail orderdetail = new Orderdetail();
            orderdetail = orderdetail.GetDetails(id);
            ViewBag.orderdetail = orderdetail;
            ViewBag.ConvertPriceToString = orderdetail.ConvertPriceToString(orderdetail);
            Course course = new Course();
            course = course.GetCourse(orderdetail.CourseId);
            ViewBag.course = course;
            ViewBag.quantity = orderdetail.Quantity;
            return View();
        }
        public IActionResult AddStaff()
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            return View();
        }
        [HttpPost]
        public IActionResult AddStaff(string name, string jobPosition, string email, string password, string phoneNumber)
        {
            // if (HttpContext.Session.GetString("adminName") == null)
            // {
            //     return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            // }
            Staff staff = new Staff();
            bool checkEmail = staff.CheckEmail(email);
            if (staff.CheckEmail(email) == false)
            {
                ViewBag.resultCheck = "Email đã tồn tại";
                return View();
            }
            if (staff.CheckPhone(phoneNumber) == false)
            {
                ViewBag.resultCheck = "Số điện thoại đã tồn tại";
                return View();
            }
            bool result = staff.AddStaff(name, jobPosition, email, password, phoneNumber);
            if (result == true)
            {
                ViewBag.result = result;
            }
            else
            {
                ViewBag.result = result;
            }
            return View();
        }

        public IActionResult ViewCategories()
        {
            Category category = new Category();
            ViewBag.categories = category.GetCategories();
            ViewBag.number = category.GetCategories().Count();
            return View();
        }

        public IActionResult ChangeCategory(int id)
        {
            Category category = new Category();
            ViewBag.category = category.GetCategory(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeCategory(int id, string categoryName)
        {
            Category category = new Category();
            ViewBag.category = category.GetCategory(id);
            ViewBag.result = category.ChangeCategory(id, categoryName);
            return View();
        }

        public IActionResult LoginAdmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginAdmin(string email, string password)
        {
            if (password == null)
            {
                password = "";
            }
            Admin admin = new Admin();
            admin = admin.LoginAdmin(email, EncryptPassword(password));

            if (admin != null)
            {
                if (EncryptPassword(password) == admin.Password)
                {
                    HttpContext.Session.SetString("adminName", admin.AdminName);
                    HttpContext.Session.SetString("adminImage", admin.Image);
                    return RedirectToAction(controllerName: "Admin", actionName: "Index");
                }
                else
                {
                    ViewData["LoginFailed"] = "Mật khẩu không đúng";
                    return View();
                }
            }
            else
            {
                ViewData["LoginFailed"] = "Email không đúng";
                return View();
            }

        }


        public IActionResult Logout()
        {

            HttpContext.Session.Remove("adminName");
            return RedirectToAction("LoginAdmin");
        }
        public IActionResult ViewCustomers(int index)
        {
            int pageSize = 10;
            Customer customer = new Customer();

            ViewBag.customers = customer.GetCustomers(index, pageSize);
            ViewBag.pageSize = pageSize;
            ViewBag.index = index;
            return View();
        }



        public IActionResult ViewPersonalInformation()
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            return View();
        }

        public IActionResult ChangePassword()
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            return View();
        }
        [HttpPost]
        public IActionResult ChangePassword(int id, string oldPassword, string newPassword)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Admin admin = new Admin();
            string oldPassword1 = EncryptPassword(oldPassword);
            string newPassword1 = EncryptPassword(newPassword);
            bool result = admin.ChangePassword(id, oldPassword1, newPassword1);
            ViewData["result"] = result;
            return View();
        }
        public static string EncryptPassword(string password)
        {
            MD5 mD5 = MD5.Create();
            var passwordByte = Encoding.UTF8.GetBytes(password);
            var hash = mD5.ComputeHash(passwordByte);
            var stringhash = BitConverter.ToString(hash).Replace("-", string.Empty);
            return stringhash;
        }

        public IActionResult ChangeName()
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            return View();
        }

        [HttpPost]
        public IActionResult ChangeName(int id, string name)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Admin admin = new Admin();
            bool result = admin.ChangeName(id, name);
            if (result == true)
            {
                HttpContext.Session.SetString("adminName", name);
            }
            ViewData["result"] = result;
            return View();
        }
        public IActionResult ChangePhoneNumber()
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            return View();
        }
        [HttpPost]
        public IActionResult ChangePhoneNumber(int id, string phoneNumber)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Admin admin = new Admin();
            bool result = admin.ChangePhoneNumber(id, phoneNumber);
            ViewData["result"] = result;
            return View();
        }
        public IActionResult ViewCourses(int index)
        {

            int pageSize = 10;
            Course course = new Course();
            ViewBag.courses = course.GetCourses(index, pageSize);
            ViewBag.pageSize = pageSize;
            ViewBag.index = index;
            // if (HttpContext.Session.GetString("adminName") == null)
            // {
            //     return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            // }
            return View();
        }
        public IActionResult ChangeNameCourse(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeNameCourse(int id, string newName)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            bool result = course.ChangeName(id, newName);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeCategoryCourse(int id)
        {
            Course course = new Course();
            Category category = new Category();
            ViewBag.listCategories = category.GetCategories();
            ViewBag.course = course.GetCourse(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeCategoryCourse(int id, int categoryID)
        {
            Course course = new Course();
            bool result = course.ChangeCategory(id, categoryID);
            Category category = new Category();
            ViewBag.listCategories = category.GetCategories();
            ViewBag.course = course.GetCourse(id);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeDescriptionCourse(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeDescriptionCourse(int id, string description)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            bool result = course.ChangeDescription(id, description);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeCoursePrice(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeCoursePrice(int id, int newPrice)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            bool result = course.ChangeCoursePrice(id, newPrice);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeNumberOfLessions(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeNumberOfLessions(int id, int numberOfLessions)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            bool result = course.ChangeNumberOfLessions(id, numberOfLessions);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeNumberOfDishs(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeNumberOfDishs(int id, int numberOfDishs)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            bool result = course.ChangeNumberOfDishs(id, numberOfDishs);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeNumberOfHours(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeNumberOfHours(int id, int numberOfHours)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            bool result = course.ChangeNumberOfHours(id, numberOfHours);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeMaterialPrice(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeMaterialPrice(int id, int newPrice)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            bool result = course.ChangeMaterialPrice(id, newPrice);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeNumberOfStudent(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeNumberOfStudent(int id, string numberOfStudent)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            bool result = course.ChangeNumberOfStudent(id, numberOfStudent);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeAddressLearn(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeAddressLearn(int id, string addressLearn)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            bool result = course.ChangeAddressLearn(id, addressLearn);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeDateOfOpening(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeDateOfOpening(int id, DateTime dateOfOpening)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            bool result = course.ChangeDateOfOpening(id, dateOfOpening);
            ViewBag.result = result;
            return View();
        }
        public IActionResult ChangeStatusCourse(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangeStatusCourse(int id, int status)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            ViewBag.result = course.ChangeStatus(id, status);
            return View();
        }
        public IActionResult ChangeStatusCustomer(int id)
        {
            Customer customer = new Customer();
            customer.ChangeStatus(id);
            return RedirectToAction("ViewCustomers", "Admin");
        }
        public IActionResult ChangeImageCourse(int id)
        {
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangeImageCourse(int id, IFormFile imageCourse)
        {
            Course course = new Course();
            course = course.GetCourse(id);
            ViewBag.course = course.GetCourse(id);

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
            if (System.IO.File.Exists(fileNameWithPath))
            {
                ViewBag.resultImage = "Ảnh đã tồn tại, vui lòng chọn ảnh khác";
                return View();
            }
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
            ViewBag.course = course.GetCourse(id);
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
            if (System.IO.File.Exists(fileNameWithPath))
            {
                ViewBag.errorImage = "Ảnh này đã là ảnh của sản phẩm khác";
                return View();
            }
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
        public IActionResult ViewOrdersProcessing(int index)
        {
            // if (HttpContext.Session.GetString("adminName") == null)
            // {
            //     return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            // }
            int pageSize = 10;
            Order order = new Order();
            ViewBag.orders = order.GetOrdersProcessing(index, pageSize);
            ViewBag.pageSize = pageSize;
            ViewBag.index = index;
            return View();
        }

        public IActionResult ViewOrdersDone(int index)
        {
            // if (HttpContext.Session.GetString("adminName") == null)
            // {
            //     return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            // }
            int pageSize = 10;
            Order order = new Order();
            ViewBag.orders = order.GetOrdersDone(index, pageSize);
            ViewBag.pageSize = pageSize;
            ViewBag.index = index;
            return View();
        }
        public IActionResult ViewOrdersCanceled(int index)
        {
            // if (HttpContext.Session.GetString("adminName") == null)
            // {
            //     return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            // }
            int pageSize = 10;
            Order order = new Order();
            ViewBag.orders = order.GetOrdersCanceled(index, pageSize);
            ViewBag.pageSize = pageSize;
            ViewBag.index = index;
            return View();
        }

        public IActionResult ViewOrderDetails(int id)
        {
            ViewBag.id = id;
            return View();
        }
        public IActionResult AcceptOrder(int id)
        {
            Order order = new Order();
            ViewBag.result = order.AcceptOrder(id);
            return RedirectToAction("ViewOrderDetails", "Admin", new { @id = id });
        }
        public IActionResult CancelOrder(int id)
        {
            Order order = new Order();
            ViewBag.order = order.GetOrder(id);
            return View("EnterReasonCancel");
        }

        [HttpPost]
        public IActionResult CancelOrder(int id, string reason)
        {
            Order order = new Order();
            ViewBag.result = order.CancelOrder(id, reason);
            return RedirectToAction("ViewOrderDetails", "Admin", new { @id = id });
        }
        public IActionResult Payment(int id)
        {
            Order order = new Order();
            ViewBag.result = order.Payment(id);
            return RedirectToAction("ViewOrderDetails", "Admin", new { @id = id });
        }
        public IActionResult SearchStaffs(string type, string key)
        {
            // if (HttpContext.Session.GetString("adminName") == null)
            // {
            //     return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            // }
            Admin admin = new Admin();
            List<Staff> staffs = admin.SearchStaffs(type, key);
            ViewBag.SearchStaffs = staffs;
            ViewBag.NumberOfResult = staffs.Count();
            return View();
        }
        public IActionResult SearchCourse(string type, string price, string key)
        {
            int price1 = Int32.Parse(price);
            ViewBag.type = type;
            ViewBag.price = price1;
            ViewBag.key = key;
            return View();
        }
        public IActionResult ChangeStatusStaff(int id)
        {
            Staff staff = new Staff();
            staff.ChangeStatus(id);
            return RedirectToAction(controllerName: "Admin", actionName: "ViewStaffs");
        }
        public IActionResult ReissuePassword(int id)
        {
            Staff staff = new Staff();
            ViewBag.staff = staff.GetStaff(id);
            return View();
        }
        [HttpPost]
        public IActionResult ReissuePassword(int id, string newPassword)
        {
            Staff staff = new Staff();
            ViewBag.staff = staff.GetStaff(id);
            string newPass = EncryptPassword(newPassword);
            ViewBag.result = staff.ReissuePassword(id, newPass);

            return View();
        }
    }
}