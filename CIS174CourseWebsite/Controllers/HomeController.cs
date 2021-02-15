/***************************************************************
* Name        : HomeController.cs
* Author      : Tom Sorteberg
* Created     : 02/14/2021
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


namespace CIS174CourseWebsite.Controllers
{
    public class HomeController : Controller
    {
        // Index action.
        public IActionResult Index()
        {
            return View();
        }

    }
}
