using System;
using System.Collections.Generic;
using System.Linq;
#nullable disable

namespace CourseTeachCook.Models
{
    public partial class Admin
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Image { get; set; }

        public Admin LoginAdmin(string email, string password)
        {
            using (var system = new CourseTeachCookContext())
            {
                Admin admin = new Admin();
                try
                {
                    admin = system.Admins.Single(a => a.Email.Equals(email));
                    return admin;
                }
                catch (System.Exception)
                {
                    return null;
                    throw;
                }

            }
        }
        
        public bool ChangeName(int id, string name)
        {
            if (name == null)
            {
                return false;
            }
            using (var system = new CourseTeachCookContext())
            {
                Admin admin = system.Admins.Find(id);
                admin.AdminName = name;
                system.Admins.Update(admin);
                if (system.SaveChanges() >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public bool ChangePhoneNumber(int id, string phoneNumber)
        {
            if (phoneNumber == null)
            {
                return false;
            }
            using (var system = new CourseTeachCookContext())
            {
                Admin admin = system.Admins.Find(id);
                admin.PhoneNumber = phoneNumber;
                system.Admins.Update(admin);
                if (system.SaveChanges() >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool ChangePassword(int id, string oldPassword, string newPassword)
        {
            using (var system = new CourseTeachCookContext())
            {
                Admin admin = system.Admins.Find(id);
                if (admin.Password == oldPassword)
                {
                    admin.Password = newPassword;
                    system.Admins.Update(admin);
                    if (system.SaveChanges() >= 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
