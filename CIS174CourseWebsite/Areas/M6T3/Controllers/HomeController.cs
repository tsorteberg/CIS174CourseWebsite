/***************************************************************
* Name        : M6T3\HomeController.cs
* Author      : Tom Sorteberg
* Created     : 02/28/2021
* Course      : CIS 174
* Version     : 1.0
* OS          : Windows 10 Pro, Visual Studio Community 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Module 6 Topic 3
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access 
* to my program.         
***************************************************************/
using CIS174CourseWebsite.Areas.M6T3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CIS174CourseWebsite.Areas.M6T3.Controllers
{
    [Area("M6T3")]
    public class HomeController : Controller
    {
        private CountryContext context;

        public HomeController(CountryContext ctx)
        {
            context = ctx;
        }
        public ViewResult Index(string activeGame = "all", string activeCategory = "all")
        {
            var data = new CountryListViewModel
            {
                ActiveGame = activeGame,
                ActiveCategory = activeCategory,
                Games = context.Games.ToList(),
                Categories = context.Categories.ToList()
            };
            IQueryable<Country> query = context.Countries;
            if (activeGame != "all")
                query = query.Where(t => t.Game.GameID.ToLower() == activeGame.ToLower());

            if (activeCategory != "all")
                query = query.Where(t => t.Category.CategoryID.ToLower() == activeCategory.ToLower());

            data.Countries = query.ToList();
            return View(data);
        }

        [HttpPost]
        public RedirectToActionResult Details(CountryViewModel model)
        {
            Utility.LogCountryClick(model.Country.CountryID);

            TempData["ActiveGame"] = model.ActiveGame;
            TempData["ActiveCategory"] = model.ActiveCategory;
            return RedirectToAction("Details", new { ID = model.Country.CountryID });
        }

        [HttpGet]
        public IActionResult Details(string id)
        {
            var model = new CountryViewModel
            {
                Country = context.Countries
                    .Include(t => t.Game)
                    .Include(t => t.Category)
                    .FirstOrDefault(t => t.CountryID == id),
                ActiveCategory = TempData?["ActiveCategory"]?.ToString() ?? "all",
                ActiveGame = TempData?["Active"]?.ToString() ?? "all"
            };
            return View(model);
        }
    }
}
