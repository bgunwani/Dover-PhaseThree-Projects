using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreSessionManagementApplication.Helpers;
using coreSessionManagementApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace coreSessionManagementApplication.Controllers
{
    public class AccountController : Controller
    {
        ApplicationDBContext context;
        public AccountController()
        {
            context = new ApplicationDBContext();
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            var userObj = context.Users.Where(u => u.Username == user.Username 
            && u.Password == user.Password
            && u.UserType == user.UserType).SingleOrDefault();
            if(userObj != null)
            {
                if (user.Username.Equals(userObj.Username) && user.Password.Equals(userObj.Password))
                {
                    SessionHelper.setObjectAsJson(HttpContext.Session, "user", userObj);
                    //HttpContext.Session.SetString("username", "Bhawna Gunwani");
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Error = "Invalid Credentials";
                    return View("Index");
                }
                
            }
            else
            {
                ViewBag.Error = "Please Enter Your Credentials.";
                return View("Index");
            }
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
