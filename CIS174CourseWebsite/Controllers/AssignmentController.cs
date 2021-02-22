/***************************************************************
* Name        : AssignmentController.cs
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
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using CIS174CourseWebsite.Models;
using System.Collections.Generic;

namespace MultiPageWebApp.Controllers
{
    public class AssignmentController : Controller
    {
        // Context class private attribute.
        private AssignmentContext context { get; set; }

        // Primary contructor.
        public AssignmentController(AssignmentContext ctx)
        {
            context = ctx;
        }

        // Index action.
        public IActionResult List()
        {
            var assignments = context.Assignments.OrderBy(m => m.Name).ToList();
            ViewBag.Assignments = new List<Assignment>(assignments);
            return View(assignments);
        }
    }
}
