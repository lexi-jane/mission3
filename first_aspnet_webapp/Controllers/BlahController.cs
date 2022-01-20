using Microsoft.AspNetCore.Mvc;
using first_aspnet_webapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace first_aspnet_webapp.Controllers
{
    public class BlahController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Calculator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculator(GradeModel model)
        {
            if (!ModelState.IsValid)
                return View();
            string letter_grade = "";
            int grade = model.assignments + model.group_project + model.quizzes + model.intex;
            if (grade >= 94)
            {
                letter_grade = "A";

            }
            else if (grade >= 90)
            {
                letter_grade = "A-";

            }
            else if (grade >= 87)
            {
                letter_grade = "B+";


            }
            else if (grade >= 84)
            {
                letter_grade = "B";

            }
            else if (grade >= 80)
            {
                letter_grade = "B-";

            }
            else if (grade >= 77)
            {
                letter_grade = "C+";

            }
            else if (grade >= 74)
            {
                letter_grade = "C";

            }
            else if (grade >= 70)
            {
                letter_grade = "C-";

            }
            else if (grade >= 67)
            {
                letter_grade = "D+";

            }
            else if (grade >= 64)
            {
                letter_grade = "D";

            }
            else if (grade >= 60)
            {
                letter_grade = "D-";

            }
            else if (grade < 60)
            {
                letter_grade = "E";

            }

            string output = "You scored a(n) " + grade + "%. You got a(n) " + letter_grade + " in the class.";
            ViewBag.Output = output;
            return View();
        }

    }
}
