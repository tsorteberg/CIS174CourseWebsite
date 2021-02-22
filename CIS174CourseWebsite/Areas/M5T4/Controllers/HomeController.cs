/***************************************************************
* Name        : M5T4\HomeController.cs
* Author      : Tom Sorteberg
* Created     : 02/22/2021
* Course      : CIS 174
* Version     : 1.0
* OS          : Windows 10 Pro, Visual Studio Community 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Module 5 Topic 4
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access 
* to my program.         
***************************************************************/
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174CourseWebsite.Areas.M5T4.Controllers
{
    [Area("M5T4")]
    public class HomeController : Controller
    {
        // Context class private attribute.
        private Models.StudentContext scontext { get; set; }

        // Primary constructor.
        public HomeController(Models.StudentContext ctx)
        {
            scontext = ctx;
        }
        [Route("M5T4/{id?}")]
        public IActionResult Index(int id)
        {
            var students = scontext.Students.OrderBy(m => m.StudentId).ToList();
            ViewBag.ID = id;
            return View(students);
        }
    }
}
