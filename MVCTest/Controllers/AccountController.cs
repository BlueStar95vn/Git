using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MVCTest.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCTest.Controllers
{
    public class AccountController : Controller
    {
        private MVCTestContext db;
       
        public AccountController(MVCTestContext context )
        {
            db = context;
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SubmitLogin([Bind("email,password")] AccountModel model)
        {
            var email = Request.Form["email"];
            var password = Request.Form["password"];
                          
                var result = db.Employee.Count(x => email == x.Email && password == x.Password );
                if (result > 0)
                {
                    return RedirectToAction("Index", "Home");
                }
           return View("Login");
        }
        [HttpPost]
        public async Task<IActionResult> SubmitSignUp([Bind("ID, FirstName, LastName, Position, Gender, Dob, PhoneNumber, Email, Password, RemainingDayOff")] Employee employee)
        {
            employee.Password = "ABC123";
            employee.RemainingDayOff = 48;
            if (ModelState.IsValid)
            {
                db.Add(employee);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Login));
            }
            return View(employee);
        }

        [AcceptVerbs("Get", "Post")]//
        public IActionResult VerifyEmail([Bind("Email")] AccountModel model)
        {
            var result = db.Employee.Count(x => model.Email == x.Email);
            if (result>0)
            {
                return Json(data: $"Email này đã được sử dụng");
            }
            return Json(data:true);
        }



    }
}
