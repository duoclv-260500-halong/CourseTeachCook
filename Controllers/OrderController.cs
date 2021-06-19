using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CourseTeachCook.Models;

namespace CourseTeachCook.Controllers
{
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        public IActionResult CreateOrder(int id1,int id,int quantity, string requireInformation)
        {
         

            Order order = new Order();

            Course course = new Course();

            course = course.GetCourse(id);

            ViewBag.result = order.CreateOrder(id1,course,quantity, requireInformation);

            Customer customer = new Customer();

            ViewBag.customer = customer.GetCustomer(id1);

            return RedirectToAction("Confirmation","Customer", new {id=id, id1=id1, quantity=quantity});

        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
