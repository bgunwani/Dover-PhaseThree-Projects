using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreCodeFirstApproachApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreCodeFirstApproachApplication.Controllers
{
    public class AuthorController : Controller
    {
        ApplicationDBContext context;
        public AuthorController()
        {
             context = new ApplicationDBContext();
        }
        public IActionResult Index()
        {
            var authors = context.Authors.ToList();
            return View(authors);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Author author)
        {
            context.Authors.Add(author);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var author = context.Authors.Where(a => a.AuthorId == id).FirstOrDefault();
            return View(author);
        }
        public IActionResult Delete(int id)
        {
            var author = context.Authors.Where(a => a.AuthorId == id).FirstOrDefault();
            context.Authors.Remove(author);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var author = context.Authors.Where(a => a.AuthorId == id).FirstOrDefault();
            return View(author);
        }
        [HttpPost]
        public IActionResult Edit(Author author)
        {
            /*var authorObj = context.Authors.Where(a => a.AuthorId == author.AuthorId).FirstOrDefault();
            authorObj.FirstName = author.FirstName;
            authorObj.LastName = author.LastName;
            authorObj.AuthorAddedDate = author.AuthorAddedDate;
            context.SaveChanges();*/
            context.Authors.Update(author);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
