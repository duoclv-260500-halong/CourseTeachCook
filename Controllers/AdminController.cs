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
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            DateTime firstDate1 = new DateTime();
            DateTime secondDate1 = new DateTime();

            if (firstDate == null && secondDate != null)
            {
                DateTime date = DateTime.Now;
                firstDate1 = new DateTime(date.Year, date.Month, 1) + new TimeSpan(0, 0, 0);
                secondDate1 = DateTime.Parse(secondDate);
            }
            else if (secondDate == null && firstDate != null)
            {
                firstDate1 = DateTime.Parse(firstDate);
                secondDate1 = DateTime.Today + new TimeSpan(23, 59, 0);
            }
            else if (firstDate == null && secondDate == null)
            {
                DateTime date = DateTime.Now;
                firstDate1 = new DateTime(date.Year, date.Month, 1) + new TimeSpan(01, 00, 00);
                secondDate1 = DateTime.Today + new TimeSpan(23, 59, 59);
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

        public IActionResult PrintOrder(int id)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
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
            course = course.GetCourseDetails(orderdetail.CourseId);
            ViewBag.course = course;
            ViewBag.quantity = orderdetail.Quantity;
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
            admin = admin.LoginAdmin(email, EncryptController.EncryptPassword(password));

            if (admin != null)
            {
                if (EncryptController.EncryptPassword(password) == admin.Password)
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
            string oldPassword1 = EncryptController.EncryptPassword(oldPassword);
            string newPassword1 = EncryptController.EncryptPassword(newPassword);
            bool result = admin.ChangePassword(id, oldPassword1, newPassword1);
            ViewData["result"] = result;
            return View();
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

      
        
        
        
       
        
    }
}