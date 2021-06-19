using System;
using System.Collections.Generic;
using System.Linq;
#nullable disable

namespace CourseTeachCook.Models
{
    public partial class Bank
    {
        public int BankId { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string NameOwner { get; set; }
        public List<Bank> GetBanks(){
            using (var system = new CourseTeachingCookContext()){
                List<Bank> banks = system.Banks.ToList();
                return banks;
            }
        }
    }
}
