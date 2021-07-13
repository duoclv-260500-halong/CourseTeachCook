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
    public class IntroductionController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}