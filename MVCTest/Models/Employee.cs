using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTest.Models
{
    public class Employee
    {
        [Key]
        public int ID { set; get; }

        public String FirstName { set; get; }
        public String LastName { set; get; }
        public String Position { set; get; }
        public String Gender { set; get; }
        public DateTime Dob { set; get; }
        public String Email { set; get; }
        public String Password { set; get; }
        public int PhoneNumber { set; get; }
        public int RemainingDayOff { set; get; }
    }
}
