using System;
using System.Collections.Generic;
using CourseTeachCook.Controllers;
using System.Linq;
#nullable disable

namespace CourseTeachCook.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public DateTime TimeRegister { get; set; }
        public int NumberOfPurchases { get; set; }
        public string Image { get; set; }
        public int Status { get; set; }
        public DateTime LastLoggedTime { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public bool CheckEmail(string email)
        {
            using (var system = new CourseTeachCookContext())
            {
                try
                {
                    Customer customer = system.Customers.Single(c => c.Email == email);
                    if (customer != null)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (System.Exception)
                {
                    return true;
                    throw;
                }

            }
        }
        public bool CheckPhone(string phone)
        {
            using (var system = new CourseTeachCookContext())
            {
                try
                {
                    Customer customer = system.Customers.Single(c => c.PhoneNumber == phone);
                    if (customer != null)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (System.Exception)
                {
                    return true;
                    throw;
                }

            }
        }
        public bool Register(string email, string password, string name, string phone, string address)
        {
            using (var connect = new CourseTeachCookContext())
            {
                Customer cus = new Customer();
                cus.CustomerName = name;
                cus.Email = email;
                cus.Password = password;
                cus.Address = address;
                cus.PhoneNumber = phone;
                cus.Image = "defaultImage.jpg";
                cus.NumberOfPurchases = 2;
                cus.Status = 1;
                cus.TimeRegister = DateTime.Now;
                connect.Customers.AddAsync(cus);
                try
                {
                    if (connect.SaveChanges() >= 1)
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

        public Customer Login(string email, string password)
        {
            using (var connect = new CourseTeachCookContext())
            {

                try
                {
                    Customer cus = new Customer();
                    cus = connect.Customers.Single(c => c.Email == email);
                    if (cus.Email != null)
                    {
                        if (password == cus.Password)
                        {
                            cus.LastLoggedTime = DateTime.Now;
                            connect.Customers.Update(cus);
                            connect.SaveChanges();
                        }
                        return cus;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (System.Exception)
                {

                    return null;
                }


            }
        }
        public List<Customer> GetCustomers(int index, int pageSize)
        {
            using (var system = new CourseTeachCookContext())
            {
                List<Customer> customers = system.Customers.Skip(index * pageSize).Take(pageSize).ToList();
                return customers;
            }
        }
        public int GetNumberOfNewCustomer(DateTime firstDate, DateTime secondDate)
        {
            using (var system = new CourseTeachCookContext())
            {
                int result = system.Customers.Where(c => c.TimeRegister >= firstDate)
                                                .Where(c => c.TimeRegister <= secondDate)
                                                .ToList().Count();
                return result;
            }
        }
        public Customer GetCustomer(int id)
        {
            using (var system = new CourseTeachCookContext())
            {
                Customer customer = system.Customers.Find(id);
                return customer;
            }
        }
        public Customer ChangeInfor(int id, string name, string phoneNumber, string address, string fileName)
        {
            using (var connect = new CourseTeachCookContext())
            {
                Customer customer = connect.Customers.Find(id);
                if(fileName != null){
                    customer.Image = fileName;
                }
                customer.CustomerName = name;
                customer.PhoneNumber = phoneNumber;
                customer.Address = address;
                connect.Customers.Update(customer);
                if (connect.SaveChanges() >= 1)
                {
                    return customer;
                }
                else
                {
                    customer = connect.Customers.Find(id);
                    return customer;
                }
            }
        }
        public bool ChangePassword(int id, string oldPassword, string newPassword)
        {
            using (var connect = new CourseTeachCookContext())
            {
                if (id == 0 || oldPassword == null || newPassword == null)
                {
                    return false;
                }
                Customer customer = connect.Customers.Find(id);
                if (oldPassword == customer.Password)
                {
                    customer.Password = newPassword;
                    connect.Customers.Update(customer);
                    if (connect.SaveChanges() >= 1)
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
        public List<Customer> GetCustomers()
        {
            using (var system = new CourseTeachCookContext())
            {
                List<Customer> customers = system.Customers.ToList();

                return customers;
            }
        }
        public bool ChangeStatus(int id)
        {
            using (var system = new CourseTeachCookContext())
            {
                Customer customer = system.Customers.Find(id);
                if (customer.Status == 0)
                {
                    customer.Status = 1;
                }
                else
                {
                    customer.Status = 0;
                }
                system.Customers.Update(customer);
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
                    return false;
                    throw;
                }
            }
        }
    }
}
