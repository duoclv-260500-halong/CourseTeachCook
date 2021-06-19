using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CourseTeachCook.Models;
using Microsoft.AspNetCore.Http;


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


            Course chitiet = new Course();

            Course chitietkhoahoc = chitiet.GetCourse(id);
            ViewBag.chitietkhoahoc = chitietkhoahoc;


            Customer cus = new Customer();

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
        public IActionResult ChangeInfor(int id, string name, string phoneNumber, string address)
        {



            Customer customer = new Customer();
            ViewBag.customer = customer.ChangeInfor(id, name, phoneNumber, address);
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
