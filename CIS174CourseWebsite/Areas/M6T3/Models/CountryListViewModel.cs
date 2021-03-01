/***************************************************************
* Name        : M6T3/Country.cs
* Author      : Tom Sorteberg
* Created     : 02/29/2021
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
    public class CountryListViewModel
    {
        public List<Country> Countries { get; set; }
        public string ActiveGame { get; set; }
        public string ActiveCategory { get; set; }

        private List<Game> games;
        public List<Game> Games
        {
            get => games;
            set
            {
                games = value;
                games.Insert(0, new Game { GameID = "all", Name = "All" });
            }
        }

        private List<Category> categories;
        public List<Category> Categories
        {
            get => categories;
            set
            {
                categories = value;
                categories.Insert(0, new Category { CategoryID = "all", Name = "All" });
            }
        }

        // Methods to help view determine the active link.
        public string CheckActiveGame(string c) => c.ToLower() == ActiveGame.ToLower() ? "active" : "";

        public string CheckActiveCategory(string d) => d.ToLower() == ActiveCategory.ToLower() ? "active" : "";

    }
}