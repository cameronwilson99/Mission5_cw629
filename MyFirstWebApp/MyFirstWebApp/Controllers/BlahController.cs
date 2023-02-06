using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstWebApp.Controllers
{
    public class BlahController : Controller
    {
        //when the index page is called, it returns the index view.
        public IActionResult Index()
        {
            return View();
        }

        //get request to display the Grade Calculator page
        [HttpGet]
        public IActionResult GradeCalc ()
        {
            return View();
        }

        //post request to post the Grade Calculator input to the attached model.
        [HttpPost]
        public IActionResult GradeCalc (GradeCalcModel model)
        {
            return View();
        }
    }
}
