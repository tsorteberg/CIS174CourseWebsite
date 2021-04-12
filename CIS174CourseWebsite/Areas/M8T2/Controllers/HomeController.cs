/***************************************************************
* Name        : M8T2\HomeController.cs
* Author      : Tom Sorteberg
* Created     : 03/15/2021
* Course      : CIS 174
* Version     : 1.0
* OS          : Windows 10 Pro, Visual Studio Community 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Module 8 Topic 2
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access 
* to my program.         
***************************************************************/
using CIS174CourseWebsite.Areas.M8T2.Models;
using CIS174CourseWebsite.Areas.M8T2.Models.DataLayer;
using CIS174CourseWebsite.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CIS174CourseWebsite.Areas.M8T2.Controllers
{
    [Area("M8T2")]
    public class HomeController : Controller
    {
        private IRepository<Ticket> tickets { get; set; }
        private IRepository<Status> statuses { get; set; }

        public HomeController(IRepository<Ticket> ti, IRepository<Status> st) {
            tickets = ti;
            statuses = st;
        }
        public IActionResult Index(string id)
        {
            var filters = new Filters(id);
            ViewBag.Filters = filters;
            ViewBag.DueFilters = Filters.DueFilterValues;

            var statusOptions = new QueryOptions<Status>
            {
                OrderBy = so => so.Name
            };

            ViewBag.Statuses = statuses.List(statusOptions);

            var ticketOptions = new QueryOptions<Ticket>
            {
                Includes = "Status"
            };

            if (filters.HasStatus && !filters.HasDue)
            {
                ticketOptions.Where = to => to.StatusId == filters.StatusId;
            }
            else if (filters.HasDue && !filters.HasStatus)
            {
                var today = DateTime.Today;
                if (filters.IsPast)
                    ticketOptions.Where = to => to.DueDate < today;
                else if (filters.IsFuture)
                    ticketOptions.Where = to => to.DueDate > today;
                else if (filters.IsToday)
                    ticketOptions.Where = to => to.DueDate == today;
            }
            else if (filters.HasStatus && filters.HasDue)
            {
                var today = DateTime.Today;
                if (filters.IsPast)
                    ticketOptions.Where = to => to.DueDate < today && to.StatusId == filters.StatusId;
                else if (filters.IsFuture)
                    ticketOptions.Where = to => to.DueDate > today && to.StatusId == filters.StatusId;
                else if (filters.IsToday)
                    ticketOptions.Where = to => to.DueDate == today && to.StatusId == filters.StatusId;
            }
            ticketOptions.OrderBy = to => to.DueDate;
            var returnValue = tickets.List(ticketOptions);
            return View(returnValue);
        }

        [HttpGet]
        public IActionResult Add()
        {
            var statusOptions = new QueryOptions<Status>
            {
                OrderBy = so => so.Name
            };

            ViewBag.Statuses = statuses.List(statusOptions);

            return View();
        }

        [HttpPost]
        public IActionResult Add(Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                tickets.Insert(ticket);
                tickets.Save();
                return RedirectToAction("Index");
            }
            else
            {
                var statusOptions = new QueryOptions<Status>
                {
                    OrderBy = so => so.Name
                };

                ViewBag.Statuses = statuses.List(statusOptions);
                return View(ticket);
            }
        }

        [HttpPost]
        public IActionResult Filter(string[] filter)
        {
            string id = string.Join('-', filter);
            return RedirectToAction("Index", new { ID = id });
        }

        [HttpPost]
        public IActionResult Edit([FromRoute] string id, Ticket selected)
        {
            if (selected.StatusId == null)
            {
                tickets.Delete(selected);
            }
            else
            {
                string newStatusId = selected.StatusId;
                selected = tickets.Get(selected.Id);
                selected.StatusId = newStatusId;
                tickets.Update(selected);
            }
            tickets.Save();

            return RedirectToAction("Index", new { ID = id });
        }
    }
}
