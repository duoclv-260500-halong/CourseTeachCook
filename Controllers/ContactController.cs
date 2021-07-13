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
    public class ContactController : Controller
    {
        public IActionResult Index()
        {

            Contactsinformation lienhe = new Contactsinformation();

            ViewBag.contact = lienhe.GetContactAll();



            return View();
        }
    }
}