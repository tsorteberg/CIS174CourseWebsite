/***************************************************************
* Name        : M6T3/CountryViewModel.cs
* Author      : Tom Sorteberg
* Created     : 03/01/2021
* Course      : CIS 174
* Version     : 1.0
* OS          : Windows 10 Pro, Visual Studio Community 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Module 6 Topic 3
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access 
* to my program.         
****************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174CourseWebsite.Areas.M6T3.Models
{
    public class CountryViewModel
    {
        public Country Country { get; set; }
        public string ActiveGame { get; set; } = "all";
        public string ActiveCategory { get; set; } = "all";

    }
}