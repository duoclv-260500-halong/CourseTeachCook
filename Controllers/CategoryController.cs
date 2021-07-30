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
    public class CategoryController : Controller
    {
        public IActionResult ViewCategories()
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            return View();
        }
        public IActionResult ChangeCategory(int id)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
          
            ViewBag.id = id;
            return View();
        }
         [HttpPost]
        public IActionResult ChangeCategory(int id, string categoryName)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Category category = new Category();
            ViewBag.category = category.GetCategory(id);
            ViewBag.result = category.ChangeCategory(id, categoryName);
            ViewBag.id = id;
            return View();
        }
    }
}
