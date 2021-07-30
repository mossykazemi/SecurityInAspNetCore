using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SecurityInAspNet.Models.Student;
using SecurityInAspNet.DataServices;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SecurityInAspNet.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        private readonly StudentDataContext _db;

        public StudentController(StudentDataContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(new List<CourseGrade>());
        }

        [HttpGet]
        [Authorize(Policy = "FacultyOnly")]
        public IActionResult AddGrade()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Policy = "FacultyOnly")]
        public IActionResult AddGrade(CourseGrade model)
        {
            if (!ModelState.IsValid)
                return View();

            model.CreatedDate = DateTime.Now;

            _db.Grades.Add(model);
            _db.SaveChanges();

            return RedirectToAction(nameof(StudentController.Index), "Student");
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Classifications()
        {
            var classifications = new List<string>()
            {
                "Freshman",
                "Sophomore",
                "Junior",
                "Senior"
            };

            return View(classifications);
        }

    }
}
