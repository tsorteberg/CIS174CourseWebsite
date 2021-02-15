/***************************************************************
* Name        : M45\M45HomeController.cs
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
using Microsoft.AspNetCore.Mvc;

namespace CIS174CourseWebsite.Areas.M45.Controllers
{
    public class M45HomeController : Controller
    {
        public IActionResult M45Index()
        {
            return View();
        }

        public IActionResult M45Default(string id = "All")
        {
            if (id == "All")
            {
                return Content("M45Home controller, M45Default action.");
            }
            else
            {
                return Content("M45Home controller, M45Default action, id: " + id);
            }
        }

        public IActionResult M45Custom(string id, int page)
        {
            return Content("M45Home controller, M45Custom action, id: " + id + " Page: " + page);
        }

        [Route("M45Attribute/{cat?}")]
        public IActionResult M45Attribute(string cat = "All")
        {
            return Content("M45Home controller, M45Attribute action, Category: " + cat);
        }
    }
}
