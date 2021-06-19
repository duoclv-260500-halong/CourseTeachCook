using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable

namespace CourseTeachCook.Models
{
    public partial class Contactsinformation
    {
        public int ContactId { get; set; }
        public string JobPosition { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string PhoneNumber { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string GetHotLine(){
            using (var system = new CourseTeachingCookContext()){
                Contactsinformation contactsinformation = system.Contactsinformations.Single(c => c.JobPosition == "Giáo vụ");
                return contactsinformation.PhoneNumber;
            }
        }
         public List<Contactsinformation> GetContactAll()
        {
            using (var system = new CourseTeachingCookContext())
            {
                List<Contactsinformation> contacts = new List<Contactsinformation>();
                contacts = system.Contactsinformations.ToList();
                
                return contacts;

            }

        }
          public Contactsinformation GetContact()
        {
            using (var system = new CourseTeachingCookContext())
            {
                Contactsinformation contact = new Contactsinformation();
                contact = system.Contactsinformations.Single(C => C.JobPosition == "Tuyển Sinh");
                
                return contact;

            }

        }
    }
}
