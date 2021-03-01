/***************************************************************
* Name        : Admin/AssignmentController.cs
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
using Microsoft.AspNetCore.Mvc;
using CIS174CourseWebsite.Models;
using System.Linq;

namespace CIS174CourseWebsite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AssignmentController : Controller
    {
        // Context class private attribute.
        private AssignmentContext context { get; set; }

        // Primary constructor.
        public AssignmentController(AssignmentContext ctx)
        {
            context = ctx;
        }

        // Add get action.
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Assignments = context.Assignments.OrderBy(m => m.Name).ToList();
            return View("Edit", new Assignment());
        }

        // Edit get action.
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Assignments = context.Assignments.OrderBy(m => m.Name).ToList();
            var assignment = context.Assignments.Find(id);
            return View(assignment);
        }

        // Edit post action.
        [HttpPost]
        public IActionResult Edit(Assignment assignment)
        {
            if (ModelState.IsValid)
            {
                if (assignment.AssignmentId == 0)
                    context.Assignments.Add(assignment);
                else
                    context.Assignments.Update(assignment);
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (assignment.AssignmentId == 0) ? "Add" : "Edit";
                ViewBag.Assignments = context.Assignments.OrderBy(m => m.Name).ToList();
                return View(assignment);
            }
        }

        // Delete get action.
        [HttpGet]
        public IActionResult Delete(int id)
        {
            ViewBag.Assignments = context.Assignments.OrderBy(m => m.Name).ToList();
            var contact = context.Assignments.Find(id);
            return View(contact);
        }

        // Action method to post confirmation of object deletion.
        [HttpPost]
        public IActionResult Delete(Assignment assignment)
        {
            context.Assignments.Remove(assignment);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}