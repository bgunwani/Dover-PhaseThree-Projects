using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace coreEmptyWebApplication.Controllers
{
    public class DemoController : Controller
    {
        // Request Method or Action Method 
        public string Index()
        {
            return "Demo Controller - Index Action Method";
        }
        public ViewResult About()
        {
            return View();
        }
        public ViewResult Contact()
        {
            return View("ContactPage");
        }
        public ViewResult Policy()
        {
            return View();
        }
    }
}
