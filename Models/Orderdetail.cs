using System;
using System.Collections.Generic;
using System.Linq;
#nullable disable

namespace CourseTeachCook.Models
{
    public partial class Orderdetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CourseId { get; set; }
        public int CoursePrice { get; set; }
        public int MaterialPrice { get; set; }
        public int Quantity { get; set; }

        public virtual Course Course { get; set; }
        public virtual Order Order { get; set; }

        public Orderdetail GetDetails(int id)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Orderdetail orderdetail = system.Orderdetails.Single(o => o.OrderId == id);
                return orderdetail;
            }
        }
        public string ConvertPriceToString(Orderdetail orderdetail)
        {
            int total = (orderdetail.CoursePrice + orderdetail.MaterialPrice) * orderdetail.Quantity;
            //2 230 000
            // x triệu y trăm z mươi ngàn đồng

            int x = total / 1000000;
            // x = 2
            int y = (total - x * 1000000) / 100000;
            // y = 2
            int z = (total - x * 1000000 - y * 100000) / 10000;
            // z = 3
            string converted = "";
            if (x > 0)
            {
                converted += x.ToString() + " triệu ";
            }
            if (y > 0)
            {
                if (z > 0)
                {
                    converted += y.ToString() + " trăm ";
                    converted += z.ToString() + " mươi ngàn";
                }
                else if (z == 0)
                {
                    converted += y.ToString() + " trăm ngàn";
                }
            }

            converted += " đồng";
            return converted;
        }
        public bool InsertOrderdetails(int orderid, Course course, int quantity)
        {
            using (var connect = new CourseTeachingCookContext())
            {
                Orderdetail orderdetail = new Orderdetail();

                orderdetail.OrderId = orderid;
                orderdetail.CourseId = course.CourseId;
                orderdetail.CoursePrice = course.CoursePrice;
                orderdetail.MaterialPrice = course.MaterialPrice;
                orderdetail.Quantity = quantity;

                connect.Orderdetails.Add(orderdetail);

                if (connect.SaveChanges() >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }
    }
}
