using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using coreEmptyWebApplication.Models;

namespace coreEmptyWebApplication.Controllers
{
    public class UserController : Controller
    {
        IList<User> userList = new List<User>()
        {
            new User{Id=1001, Name="King Kochhar", Email="king.kochhar@gmail.com"},
            new User{Id=1002, Name="Gautam Bhalla", Email="gautam.bhalla@gmail.com"},
            new User{Id=1003, Name="John Smith", Email="john.smith@gmail.com"}
        };
        public IActionResult Index()
        {
            return View(userList);  // Model Binding or Data Binding
        }
        public IActionResult AddUser()
        {
            return View();
        }
    }
}
