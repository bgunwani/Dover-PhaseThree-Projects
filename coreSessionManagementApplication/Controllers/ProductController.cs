using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreSessionManagementApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreSessionManagementApplication.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDBContext context;
        public ProductController()
        {
            context = new ApplicationDBContext();
        }
        public IActionResult Index()
        {
            var products = context.Products.ToList();
            return View(products);
        }
    }
}
