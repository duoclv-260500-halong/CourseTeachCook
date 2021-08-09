using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CourseTeachCook.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace CourseTeachCook.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ILogger<CustomerController> _logger;


        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Register()
        {
            return View();
        }

        public IActionResult ViewInfor(int id)
        {
            Customer cus = new Customer();

            if (HttpContext.Session.GetString("CustomerName") == null)
            {
            }
            else
            {
                Customer customers = cus.GetCustomer(id);
                // return Content(HttpContext.Session.GetString("CustomerId"));
                ViewBag.customers = customers;
            }

            return View();
        }


        [HttpPost]
        public IActionResult Register(string email, string password, string name, string phone, string address)
        {
            Customer cus = new Customer();
            if (cus.CheckEmail(email) == false)
            {
                ViewBag.result = "Email đã được đăng kí";
                return View();
            }
            if (cus.CheckPhone(phone) == false)
            {
                ViewBag.result = "Số điện thoại đã được đăng kí";
                return View();
            }
            bool result = cus.Register(email, EncryptController.EncryptPassword(password), name, phone, address);
            if (result == true)
            {
                ViewBag.result = "Đăng ký thành Công";
            }
            else
            {
                ViewBag.result = "Đăng ký thất bại";
            }
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            Customer cus = new Customer();

            cus = cus.Login(email, EncryptController.EncryptPassword(password));

            if (cus != null)
            {
                if (EncryptController.EncryptPassword(password) == cus.Password)
                {
                    if (cus.Status == 0)
                    {
                        ViewBag.resultLogin = "Tài khoản của bạn đã bị khóa";
                        return View();
                    }
                    HttpContext.Session.SetString("CustomerName", cus.CustomerName);
                    HttpContext.Session.SetString("CustomerId", cus.CustomerId.ToString());
                    if (HttpContext.Session.GetString("Coursebuy") != null)
                    {
                        return RedirectToAction(actionName: "Buy", controllerName: "Customer", new { id = HttpContext.Session.GetString("Coursebuy"), id1 = cus.CustomerId });
                    }
                    return RedirectToAction(actionName: "Index", controllerName: "Customer");
                }
                else
                {
                    ViewBag.resultLogin = "Mật khẩu không đúng";
                }
            }
            else
            {
                ViewBag.resultLogin = "Email không tồn tại";
            }
            return View();

        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("CustomerName");

            HttpContext.Session.Remove("CustomerId");
            HttpContext.Session.Remove("Coursebuy");
            return RedirectToAction("Login");
        }
        public IActionResult ViewCustomers(int index)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            int pageSize = 10;
            Customer customer = new Customer();

            ViewBag.customers = customer.GetCustomers(index, pageSize);
            ViewBag.pageSize = pageSize;
            ViewBag.index = index;
            return View();
        }

        public IActionResult Buy(int id)
        {
            Customer cus = new Customer();

            if (HttpContext.Session.GetString("CustomerName") == null)
            {
                HttpContext.Session.SetString("Coursebuy", id.ToString());
                return RedirectToAction(controllerName: "Customer", actionName: "Login");
            }
            else
            {
                int id1 = Int32.Parse(HttpContext.Session.GetString("CustomerId"));
                ViewBag.id1 = id1;
            }

            Course chitiet = new Course();

            Course chitietkhoahoc = chitiet.GetCourseDetails(id);
            ViewBag.chitietkhoahoc = chitietkhoahoc;
            return View();
        }
        public IActionResult GetCourseCus(int id){
            ViewBag.courseId = id;
            return View();
        }
        public IActionResult GetCourseDetails(int id)
        {
            ViewBag.courseId = id;
            return View();
        }
        public IActionResult ViewOrders(int id)
        {
            Customer customer = new Customer();
            ViewBag.customer = customer.GetCustomer(id);
            return View();
        }
        public IActionResult Confirmation(int id, int id1, int quantity)
        {
            Contactsinformation contact = new Contactsinformation();
            ViewBag.contact = contact.GetContact();

            Customer customer = new Customer();

            ViewBag.customer = customer.GetCustomer(id1);
            Course course = new Course();
            ViewBag.course = course.GetCourseDetails(id);
            ViewBag.quantity = quantity;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ChangeInfor(int id, string name, string phoneNumber, string address, IFormFile imageUser)
        {
            Customer customer = new Customer();
            if (imageUser != null)
            {
                string[] typeAllow = { ".jpg", ".png", ".jpeg" };
                if (!typeAllow.Contains(Path.GetExtension(imageUser.FileName).ToLower()))
                {
                    ViewBag.errorImage = "Bạn phải chọn đúng kiểu ảnh (jpg, png, jpeg)";
                    return View();
                }

                //return Content(Path.GetExtension(file.FileName).ToLower());
                string filePath = "wwwroot/Image/ImageDesign/UserImage";
                string fileName = imageUser.FileName.Replace(Path.GetExtension(imageUser.FileName), "") + ".png";
                var fileNameWithPath = string.Concat(filePath, "\\", fileName);

                using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                {
                    await imageUser.CopyToAsync(stream);
                }
                ViewBag.customer = customer.ChangeInfor(id, name, phoneNumber, address, fileName);
            }
            ViewBag.customer = customer.ChangeInfor(id, name, phoneNumber, address, null);
            HttpContext.Session.SetString("CustomerName", name);
            return RedirectToAction("Infor", "Customer", new { id = id });
        }
        public IActionResult ChangePassword(int id)
        {

            Customer customer = new Customer();
            ViewBag.customer = customer.GetCustomer(id);
            return View();
        }
        [HttpPost]
        public IActionResult ChangePassword(int id, string oldPassword, string newPassword)
        {

            Customer customer = new Customer();
            ViewBag.customer = customer.GetCustomer(id);
            ViewBag.result = customer.ChangePassword(id, EncryptController.EncryptPassword(oldPassword), EncryptController.EncryptPassword(newPassword));
            return View();
        }
        public IActionResult ChangeStatusCustomer(int id)
        {
            Customer customer = new Customer();
            customer.ChangeStatus(id);
            return RedirectToAction("ViewCustomers", "Customer");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
