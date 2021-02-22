/***************************************************************
* Name        : M4T5/HomeController.cs
* Author      : Tom Sorteberg
* Created     : 02/15/2021
* Course      : CIS 174
* Version     : 1.0
* OS          : Windows 10 Pro, Visual Studio Community 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Module 4 Topic 5
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access 
* to my program.         
***************************************************************/
using CIS174CourseWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CIS174CourseWebsite.Areas.M4T5.Controllers
{
    [Area("M4T5")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Default(string id = "All")
        {
            if (id == "All")
            {
                return Content("Home controller, Default action.");
            }
            else
            {
                return Content("Home controller, Default action, id: " + id);
            }
        }

        public IActionResult Custom(string id, int page)
        {
            return Content("Home controller, Custom action, id: " + id + " Page: " + page);
        }

        [Route("Attribute/{cat?}")]
        public IActionResult Attribute(string cat = "All")
        {
            return Content("Home controller, Attribute action, Category: " + cat);
        }
    }
}
