using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPage5.Models
{
    public class Employee
    {
        public String firstName { set; get; }
        public String lastName { set; get; }
        public String position { set; get; }
        public String gender { set; get; }
        public DateTime dob { set; get; }
        [Key]
        public String email { set; get; }
        public String password { set; get; }
        public int timeleft { set; get; }


    }
}
