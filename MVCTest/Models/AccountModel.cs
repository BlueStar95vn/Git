using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTest.Models
{
    public class AccountModel
    {
        [Key]
        public int ID { set; get; }
        [Required(ErrorMessage ="Bạn chưa nhập Tên")]        
        public String FirstName { set; get; }
        [Required(ErrorMessage = "Bạn chưa nhập Họ")]
        public String LastName { set; get; }
        [Required(ErrorMessage = "Bạn chưa nhập chức vụ")]
        public String Position { set; get; }
        public String Gender { set; get; }
        [Required(ErrorMessage = "Bạn chưa chọn ngày sinh")]
        public DateTime Dob { set; get; }
        [Required(ErrorMessage = "Bạn chưa nhập Email")]
        [EmailAddress(ErrorMessage ="Bạn nhập Email chưa đúng")]
        [Remote(action: "VerifyEmail", controller: "Account")]
        public String Email { set; get; }
        public String Password { set; get; }
        [Required(ErrorMessage = "Bạn chưa nhập số điện thoại")]
        public int PhoneNumber { set; get; }
        public int RemainingDayOff { set; get; }

    }
}
