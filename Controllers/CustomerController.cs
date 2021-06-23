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
            Course khoahoc = new Course();

            List<Course> listhot = khoahoc.GetListKhoahochot();
            ViewBag.listhot = listhot;

            List<Course> danhsachkh = khoahoc.GetListNghebep();
            ViewBag.danhsachkhoahoc = danhsachkh;

            List<Course> danhsachgd = khoahoc.GetListGiadinh();
            ViewBag.danhsachgiadinh = danhsachgd;

            List<Course> danhsachchild = khoahoc.GetListTrevaobep();
            ViewBag.danhsachtre = danhsachchild;

            List<Course> danhsachcake = khoahoc.GetListCake();
            ViewBag.danhsachcake = danhsachcake;

            List<Course> danhsachban = khoahoc.GetListBartender();
            ViewBag.danhsachban = danhsachban;

            List<Course> danhsacharts = khoahoc.GetListvisual_arts();
            ViewBag.danhsacharts = danhsacharts;

            List<Course> danhsachworld = khoahoc.GetListworld_cuisine();
            ViewBag.danhsachworld = danhsachworld;

            Teacher giangvien = new Teacher();

            List<Teacher> danhsachgiangvien = giangvien.GetListTeacher();
            ViewBag.danhsachgiangvien = danhsachgiangvien;



            return View();
        }


        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Productdetails()
        {



            return View();
        }
        public IActionResult Newdetails()
        {


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

        public IActionResult Infor(int id)
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
        public IActionResult ViewOrders(int id)
        {
            Customer customer = new Customer();
            ViewBag.customer = customer.GetCustomer(id);
            return View();
        }
        public IActionResult ViewOrderDetails(int id, int id1)
        {
            Customer customer = new Customer();
            ViewBag.customer = customer.GetCustomer(id1);
            Order order = new Order();
            ViewBag.order = order.GetOrder(id);
            return View();
        }
        public IActionResult CancelOrder(int id, int status)
        {

            Customer customer = new Customer();
            ViewBag.customer = customer.GetCustomer(Int32.Parse(HttpContext.Session.GetString("CustomerId")));
            Order order = new Order();
            ViewBag.order = order.GetOrder(id);
            if (status == 1)
            {
                ViewBag.result = "Hủy khóa học thành công";
            }
            else if (status == -1)
            {
                ViewBag.result = "Hủy khóa học thất bại, vui lòng thử lại sau";
            }

            return View();
        }
        [HttpPost]
        public IActionResult SubmitReason(int id, string reasonCancel)
        {
            Order order = new Order();
            if (order.CancelOrder(-1, id, reasonCancel))
            {
                ViewBag.result = "Hủy khóa học thành công";
                return RedirectToAction("CancelOrder", new { id = id, status = 1 });
            }
            else
            {
                ViewBag.result = "Hủy khóa học thất bại, vui lòng thử lại sau";
                return RedirectToAction("CancelOrder", new { id = id, status = -1 });
            }

        }

        public IActionResult Introduce()
        {


            Teacher giangvien = new Teacher();

            List<Teacher> danhsachgiangvien = giangvien.GetListTeacher();
            ViewBag.danhsachgiangvien = danhsachgiangvien;

            return View();
        }

        public IActionResult Contactsinformation()
        {

            Contactsinformation lienhe = new Contactsinformation();

            ViewBag.contact = lienhe.GetContactAll();



            return View();
        }

        public IActionResult ViewNews()
        {
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
            bool result = cus.Register(email, AdminController.EncryptPassword(password), name, phone, address);
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
        [HttpPost]
        public IActionResult SearchCourse(string key)
        {
            Course course = new Course();
            ViewBag.courses = course.SearchCourse(key);
            ViewBag.number = course.SearchCourse(key).Count();
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

            cus = cus.Login(email, AdminController.EncryptPassword(password));

            if (cus != null)
            {
                if (AdminController.EncryptPassword(password) == cus.Password)
                {
                    if (cus.Status == 0)
                    {
                        ViewBag.resultLogin = "Tài khoản của bạn đã bị khóa";
                        return View();
                    }
                    HttpContext.Session.SetString("CustomerName", cus.CustomerName);
                    HttpContext.Session.SetString("CustomerId", cus.CustomerId.ToString());
                    // return Content(HttpContext.Session.GetString("CustomerId"));
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

            return RedirectToAction("Login");
        }

        public IActionResult GetCourseDetails(int id, string CourseImage)
        {


            Customer cus = new Customer();

            if (HttpContext.Session.GetString("CustomerName") == null)
            {

            }
            else
            {
                Customer customers = cus.GetCustomer(Int32.Parse(HttpContext.Session.GetString("CustomerId")));
                // return Content(HttpContext.Session.GetString("CustomerId"));
                ViewBag.customers = customers;
            }


            Course chitiet = new Course();

            Course chitietkhoahoc = chitiet.GetCourseCus(id);
            ViewBag.chitietkhoahoc = chitietkhoahoc;


            Contactsinformation contact = new Contactsinformation();
            ViewBag.contact = contact.GetContact();


            Bank bank = new Bank();

            List<Bank> banks = bank.GetBanks();
            ViewBag.banks = banks;


            Imagescourse image = new Imagescourse();

            List<Imagescourse> imagescourses = image.GetImagescourses(id);
            ViewBag.imagescourses = imagescourses;



            return View();
        }

        public IActionResult Buy(int id, int id1)
        {
            Customer cus = new Customer();
            if (id1 == 0)
            {
                HttpContext.Session.SetString("Coursebuy", id.ToString());
                return RedirectToAction(controllerName: "Customer", actionName: "Login");
            }
            else
            {
                Customer customers = cus.GetCustomer(id1);
                // return Content(id1.ToString());
                ViewBag.customers = customers;
            }

            Course chitiet = new Course();

            Course chitietkhoahoc = chitiet.GetCourse(id);
            ViewBag.chitietkhoahoc = chitietkhoahoc;


            

            if (HttpContext.Session.GetString("CustomerName") == null)
            {
                HttpContext.Session.SetString("Coursebuy", id.ToString());
                return RedirectToAction(controllerName: "Customer", actionName: "Login");
            }
            else
            {
                Customer customers = cus.GetCustomer(id1);
                // return Content(id1.ToString());
                ViewBag.customers = customers;
            }

            return View();
        }

        public IActionResult Confirmation(int id, int id1, int quantity)
        {


            Contactsinformation contact = new Contactsinformation();
            ViewBag.contact = contact.GetContact();

            Customer customer = new Customer();

            ViewBag.customer = customer.GetCustomer(id1);
            Course course = new Course();
            ViewBag.course = course.GetCourse(id);
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
            ViewBag.result = customer.ChangePassword(id, AdminController.EncryptPassword(oldPassword), AdminController.EncryptPassword(newPassword));
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
