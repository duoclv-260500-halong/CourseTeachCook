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
    public class StaffController : Controller
    {
        public IActionResult ViewStaffs(int index)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            int pageSize = 10;
            Staff staff = new Staff();

            ViewBag.staffs = staff.GetStaffs(index, pageSize);
            ViewBag.pageSize = pageSize;
            ViewBag.index = index;
            return View();
        }
        public IActionResult SearchStaffs(string type, string key)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Staff staff = new Staff();
            List<Staff> staffs = staff.SearchStaffs(type, key);
            ViewBag.SearchStaffs = staffs;
            ViewBag.NumberOfResult = staffs.Count();
            return View();
        }
        public IActionResult AddStaff()
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            return View();
        }
        [HttpPost]
        public IActionResult AddStaff(string name, string jobPosition, string email, string password, string phoneNumber)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
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
        public IActionResult ChangeStatusStaff(int id)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Staff staff = new Staff();
            staff.ChangeStatus(id);
            return RedirectToAction(controllerName: "Staff", actionName: "ViewStaffs");
        }
        public IActionResult ReissuePassword(int id)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Staff staff = new Staff();
            ViewBag.staff = staff.GetStaff(id);
            return View();
        }
        [HttpPost]
        public IActionResult ReissuePassword(int id, string newPassword)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Staff staff = new Staff();
            ViewBag.staff = staff.GetStaff(id);
            string newPass = EncryptController.EncryptPassword(newPassword);
            ViewBag.result = staff.ReissuePassword(id, newPass);

            return View();
        }

    }
}