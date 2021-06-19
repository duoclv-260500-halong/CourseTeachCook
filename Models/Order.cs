using System;
using System.Collections.Generic;
using System.Linq;
#nullable disable

namespace CourseTeachCook.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int? StaffId { get; set; }
        public int CustomerId { get; set; }
        public int OrderStatus { get; set; }
        public string ReasonCancel { get; set; }
        public string RequireInformation { get; set; }
        public int? Canceler { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Staff Staff { get; set; }
        public List<Order> GetListOrdersProcessing()
        {
            using (var system = new CourseTeachingCookContext())
            {
                List<Order> orders = system.Orders.Where(o => (o.OrderStatus == -1) || (o.OrderStatus == 0)).ToList();
                return orders;
            }
        }

        public List<Order> GetListOrdersDone()
        {
            using (var system = new CourseTeachingCookContext())
            {
                List<Order> orders = system.Orders.Where(o => o.OrderStatus == 1).ToList();
                return orders;
            }
        }
        public List<Order> GetListOrdersCanceled()
        {
            using (var system = new CourseTeachingCookContext())
            {
                List<Order> orders = system.Orders.Where(o => o.OrderStatus == -2).ToList();
                return orders;
            }
        }

        public Order GetOrder(int id)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Order order = system.Orders.Find(id);
                return order;
            }
        }

        public List<Orderdetail> GetOrderDetails(int orderID)
        {
            using (var system = new CourseTeachingCookContext())
            {
                List<Orderdetail> orderdetails = new List<Orderdetail>();
                orderdetails = system.Orderdetails.Where(o => o.OrderId == orderID).ToList();
                return orderdetails;
            }
        }
        public bool AcceptOrder(int id)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Order order = system.Orders.Find(id);
                order.OrderStatus = 0;
                order.Canceler = 0;
                order.StaffId = 8;
                system.Orders.Update(order);
                try
                {
                    if (system.SaveChanges() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {

                    throw;
                }
            }
        }
        public bool CancelOrder(int id, string reason)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Order order = system.Orders.Find(id);
                order.OrderStatus = -2;
                order.Canceler = 1;
                order.ReasonCancel = reason;
                system.Orders.Update(order);
                try
                {
                    if (system.SaveChanges() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {

                    throw;
                }
            }
        }
        public bool Payment(int id)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Order order = system.Orders.Find(id);
                order.OrderStatus = 1;
                Customer customer = system.Customers.Find(order.CustomerId);
                customer.NumberOfPurchases += 1;
                system.Orders.Update(order);
                try
                {
                    if (system.SaveChanges() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (System.Exception)
                {

                    throw;
                }
            }
        }
        public bool CreateOrder(int Cus_id, Course course, int quantity, string requireInformation)
        {
            using (var connect = new CourseTeachingCookContext())
            {

                Order order = new Order();
                order.OrderStatus = -1;
                order.OrderDate = DateTime.Now;
                order.StaffId = 7;
                order.CustomerId = 1;
                order.RequireInformation = requireInformation;
                connect.Orders.Add(order);

                if (connect.SaveChanges() >= 1)
                {
                    Order order1 = new Order();
                    order1 = connect.Orders.OrderByDescending(o => o.OrderId).FirstOrDefault();

                    Orderdetail orderdetails1 = new Orderdetail();

                    if (orderdetails1.InsertOrderdetails(order1.OrderId, course, quantity) == true)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
        }
        public List<Order> GetOrderByTimeRange(DateTime firstDate, DateTime secondDate){
            using(var system = new CourseTeachingCookContext()){
                List<Order> orders = system.Orders.Where(o=>o.OrderDate >= firstDate)
                                                    .Where(o=>o.OrderDate <= secondDate)
                                                    .Where(o=>o.OrderStatus == 1).ToList();
                return orders;
            }

        }
        public List<Order> GetOrdersProcessing(int index, int pageSize){
            using(var system = new CourseTeachingCookContext()){
                List<Order> orders = system.Orders.Where(o=>o.OrderStatus == -1 || o.OrderStatus == 0)
                                                    .Skip(index*pageSize).Take(pageSize).ToList();
                return orders;
            }

        }
        public List<Order> GetOrdersDone(int index, int pageSize){
            using(var system = new CourseTeachingCookContext()){
                List<Order> orders = system.Orders.Where(o=>o.OrderStatus == 1).Skip(index*pageSize).Take(pageSize).ToList();
                return orders;
            }

        }
        public List<Order> GetOrdersCanceled(int index, int pageSize){
            using(var system = new CourseTeachingCookContext()){
                List<Order> orders = system.Orders.Where(o=>o.OrderStatus == -2).Skip(index*pageSize).Take(pageSize).ToList();
                return orders;
            }

        }
    }
}
