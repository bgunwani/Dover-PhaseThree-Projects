using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreMvcWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace coreMvcWebApplication.Controllers
{
    public class StudentController : Controller
    {
        IList<Student> students = new List<Student>()
        {
            new Student() { Id=101, Name="Kartik", Age=34, Email="kartik@gmail.com" },
            new Student() { Id=102, Name="Gautam", Age=30, Email="gautam@gmail.com" },
            new Student() { Id=103, Name="Sarah", Age=24, Email="sarah@gmail.com" },
            new Student() { Id=104, Name="Smith", Age=32, Email="smith@gmail.com" },
            new Student() { Id=105, Name="Roger", Age=40, Email="roger@gmail.com" }
        };


        public IActionResult Index()
        {
            ViewBag.message = "Student Management System";
            ViewBag.StudentCount = students.Count();
            ViewBag.StudentList = students;
            return View();
        }

        public IActionResult Index1()
        {
            ViewData["message"] = "Student Managment System";
            ViewData["StudentCount"] = students.Count();
            ViewData["StudentList"] = students;
            ViewBag.message = "Student Management";
            return View();
        }
        public IActionResult FirstMethod()
        
        {
            TempData["message"] = "Student Managment System";
            TempData["StudentCount"] = students.Count();
            TempData["StudentList"] = students;
            TempData.Keep("StudentList");
            return View();
        }
        public IActionResult SecondMethod()
        {
            var studentData = TempData["StudentList"];
            return View();
        }

    }
}
