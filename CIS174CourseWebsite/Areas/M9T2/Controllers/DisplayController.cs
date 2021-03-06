﻿/***************************************************************
* Name        : M9T2\DisplayController.cs
* Author      : Tom Sorteberg
* Created     : 03/22/2021
* Course      : CIS 174
* Version     : 1.0
* OS          : Windows 10 Pro, Visual Studio Community 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Module 9 Topic 2
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access 
* to my program.         
***************************************************************/
using CIS174CourseWebsite.Areas.M9T2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174CourseWebsite.Areas.M9T2.Controllers
{
    [Area("M9T2")]
    public class DisplayController : Controller
    {
        private RegistrationModelContext context;
        public DisplayController(RegistrationModelContext ctx) => context = ctx;

        [HttpGet]
        public IActionResult ViewFormData()
        {
            var registrations = context.Validation.OrderBy(m => m.Name).ToList();
            return View(registrations);
        }
    }
}
