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
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        public IActionResult CreateOrder(int id1, int id, int quantity, string requireInformation)
        {


            Order order = new Order();

            Course course = new Course();

            course = course.GetCourseDetails(id);

            ViewBag.result = order.CreateOrder(id1, course, quantity, requireInformation);

            Customer customer = new Customer();

            ViewBag.customer = customer.GetCustomer(id1);

            return RedirectToAction("Confirmation", "Customer", new { id = id, id1 = id1, quantity = quantity });

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
        public IActionResult ViewOrdersProcessing(int index)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            int pageSize = 10;
            Order order = new Order();
            ViewBag.orders = order.GetOrdersProcessing(index, pageSize);
            ViewBag.pageSize = pageSize;
            ViewBag.index = index;
            return View();
        }

        public IActionResult ViewOrdersDone(int index)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            int pageSize = 10;
            Order order = new Order();
            ViewBag.orders = order.GetOrdersDone(index, pageSize);
            ViewBag.pageSize = pageSize;
            ViewBag.index = index;
            return View();
        }
        public IActionResult ViewOrdersCanceled(int index)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            int pageSize = 10;
            Order order = new Order();
            ViewBag.orders = order.GetOrdersCanceled(index, pageSize);
            ViewBag.pageSize = pageSize;
            ViewBag.index = index;
            return View();
        }

        public IActionResult ViewOrderDetails(int id)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            ViewBag.id = id;
            return View();
        }
        public IActionResult ViewOrderDetailsCustomer(int id, int id1)
        {
            using (var connect = new CourseTeachCookContext())
            {
                int customerId = Int32.Parse(HttpContext.Session.GetString("CustomerId"));
                List<Order> orders = connect.Orders.Where(o => o.CustomerId == customerId).ToList();
                bool result = false;
                foreach (Order order1 in orders)
                {
                    if (id == order1.OrderId)
                    {
                        result = true;
                    }
                }
                if(id1 != customerId){
                    result = false;
                }
                if (result == false)
                {
                    return RedirectToAction(controllerName: "Customer", actionName: "Logout");
                }
                
            }

            Customer customer = new Customer();
            ViewBag.customer = customer.GetCustomer(id1);
            Order order = new Order();
            ViewBag.order = order.GetOrder(id);
            return View();
        }
        public IActionResult AcceptOrder(int id)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Order order = new Order();
            ViewBag.result = order.AcceptOrder(id); 
            return RedirectToAction("ViewOrderDetails", "Order", new { @id = id });
        }
        public IActionResult CancelOrder(int id)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Order order = new Order();
            ViewBag.order = order.GetOrder(id);
            return View("EnterReasonCancel");
        }

        [HttpPost]
        public IActionResult CancelOrder(int id, string reason)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Order order = new Order();
            ViewBag.result = order.CancelOrder(1, id, reason);
            return RedirectToAction("ViewOrderDetails", "Order", new { @id = id });
        }
        public IActionResult CancelOrderCustomer(int id, int id1)
        {
            if (HttpContext.Session.GetString("CustomerName") == null)
            {
                HttpContext.Session.SetString("Coursebuy", id.ToString());
                return RedirectToAction(controllerName: "Customer", actionName: "Login");
            }
            ViewBag.id = id;
            ViewBag.id1 = id1;
            return View("EnterReasonCancelCustomer");
        }

        [HttpPost]
        public IActionResult CancelOrderCustomer(int id, string reasonCancel)
        {
            if (HttpContext.Session.GetString("CustomerName") == null)
            {
                HttpContext.Session.SetString("Coursebuy", id.ToString());
                return RedirectToAction(controllerName: "Customer", actionName: "Login");
            }
            int id1 = Int32.Parse(HttpContext.Session.GetString("CustomerId"));
            Order order = new Order();
            ViewBag.result = order.CancelOrder(0, id, reasonCancel);
            return RedirectToAction("ViewOrderDetailsCustomer", "Order", new { id = id, id1 = id1 });
        }
        public IActionResult Payment(int id)
        {
            if (HttpContext.Session.GetString("adminName") == null)
            {
                return RedirectToAction(controllerName: "Admin", actionName: "LoginAdmin");
            }
            Order order = new Order();
            ViewBag.result = order.Payment(id);
            return RedirectToAction("ViewOrderDetails", "Order", new { @id = id });
        }
        public IActionResult ViewOrders(int id)
        {
            Customer customer = new Customer();
            ViewBag.customer = customer.GetCustomer(id);
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
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
