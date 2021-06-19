using System;
using System.Collections.Generic;
using System.Linq;
#nullable disable

namespace CourseTeachCook.Models
{
    public partial class Staff
    {
        public Staff()
        {
            Orders = new HashSet<Order>();
        }

        public int StaffId { get; set; }
        public string StaffName { get; set; }
        public string JobPosition { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public int Status { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public Staff GetStaff(int id){
            using (var system = new CourseTeachingCookContext()){
                Staff staff = system.Staffs.Find(id);
                return staff;
            }
        }
        public bool CheckEmail(string email){
            using(var system = new CourseTeachingCookContext()){
                try
                {
                    Staff staff = system.Staffs.Single(s=>s.Email == email);
                        return false;
                }
                catch (System.Exception)
                {
                    return true;
                    throw;
                }
            }
        }
        public bool CheckPhone(string phoneNumber){
            using(var system = new CourseTeachingCookContext()){
                try
                {
                    Staff staff = system.Staffs.Single(s=>s.PhoneNumber == phoneNumber);
                        return false;
                }
                catch (System.Exception)
                {
                    return true;
                    throw;
                }
            }
        }
        public List<Staff> GetStaffs(int index, int pageSize){
            using(var system = new CourseTeachingCookContext()){
                List<Staff> staffs = system.Staffs.Skip(index*pageSize).Take(pageSize).ToList();
                return staffs;
            }
        }
        public bool AddStaff(string name, string jobPosition, string email, string password, string phoneNumber)
        {
            using (var system = new CourseTeachingCookContext())
            {
                Staff staff = new Staff();
                staff.StaffName = name;
                staff.JobPosition = jobPosition;
                staff.Email = email;
                staff.Password = password;
                staff.PhoneNumber = phoneNumber;
                staff.Status = 1;
                staff.Image = "defaultImage.jpg";
                system.Staffs.Add(staff);
                try
                {
                    if(system.SaveChanges() >= 1){
                        return true;
                }
                else{
                    return false;
                }
                }
                catch (System.Exception)
                {
                    return false;
                }
                
            }
        }
        public List<Staff> ViewStaffs(){
            using (var system = new CourseTeachingCookContext()){
                List<Staff> staffs = system.Staffs.ToList();
                return staffs;
            }
        }

        public bool ChangeStatus(int id){
            using (var system = new CourseTeachingCookContext()){
                Staff staff = system.Staffs.Find(id);
                if(staff.Status == 0){
                    staff.Status = 1;
                }
                else{
                    staff.Status = 0;
                }
                system.Staffs.Update(staff);
                try
                {
                    if(system.SaveChanges() >= 1){
                        return true;
                    }
                    else{
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

        public bool ReissuePassword(int id, string newPassword){
            using (var system = new CourseTeachingCookContext()){
                Staff staff = system.Staffs.Find(id);
                staff.Password = newPassword;
                system.Staffs.Update(staff);
                try
                {
                    if(system.SaveChanges() >= 1){
                        return true;
                    }
                    else{
                        return false;
                    }
                }
                catch (System.Exception)
                {
                    
                    throw;
                }
            }
        }
    }
}
