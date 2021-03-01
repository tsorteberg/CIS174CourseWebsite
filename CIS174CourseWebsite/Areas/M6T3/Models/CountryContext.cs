/***************************************************************
* Name        : M6T3/CountryContext.cs
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
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174CourseWebsite.Areas.M6T3.Models
{
    public class CountryContext : DbContext
    {

        public CountryContext(DbContextOptions<CountryContext> options)
            : base(options)
        { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Game>().HasData(
                new Game { GameID = "winter", Name = "Winter Olympics" },
                new Game { GameID = "summer", Name = "Summer Olympics" },
                new Game { GameID = "para", Name = "Paraympics" },
                new Game { GameID = "youth", Name = "Youth Olympic Games" }
            );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = "indoor", Name = "Indoor" },
                new Category { CategoryID = "outdoor", Name = "Outdoor" }
            );
            modelBuilder.Entity<Country>().HasData(
                new { CountryID = "canada", Name = "Canada", GameID = "winter", CategoryID = "indoor", LogoImage = "M6T3/canada.png" },
                new { CountryID = "sweden", Name = "Sweden", GameID = "winter", CategoryID = "indoor", LogoImage = "M6T3/sweden.png" },
                new { CountryID = "greatbritain", Name = "Great Britain", GameID = "winter", CategoryID = "indoor", LogoImage = "M6T3/greatbritain.png" },
                new { CountryID = "jamaica", Name = "Jamaica", GameID = "winter", CategoryID = "outdoor", LogoImage = "M6T3/jamaica.png" },
                new { CountryID = "italy", Name = "Italy", GameID = "winter", CategoryID = "outdoor", LogoImage = "M6T3/italy.png" },
                new { CountryID = "japan", Name = "Japan", GameID = "winter", CategoryID = "outdoor", LogoImage = "M6T3/japan.png" },
                new { CountryID = "germany", Name = "Germany", GameID = "summer", CategoryID = "indoor", LogoImage = "M6T3/germany.png" },
                new { CountryID = "china", Name = "China", GameID = "summer", CategoryID = "indoor", LogoImage = "M6T3/china.png" },
                new { CountryID = "mexico", Name = "Mexico", GameID = "summer", CategoryID = "indoor", LogoImage = "M6T3/mexico.png" },
                new { CountryID = "brazil", Name = "Brazil", GameID = "summer", CategoryID = "outdoor", LogoImage = "M6T3/brazil.png" },
                new { CountryID = "netherlands", Name = "Netherlands", GameID = "summer", CategoryID = "outdoor", LogoImage = "M6T3/netherlands.png" },
                new { CountryID = "usa", Name = "USA", GameID = "summer", CategoryID = "outdoor", LogoImage = "M6T3/usa.png" },
                new { CountryID = "thailand", Name = "Thailand", GameID = "para", CategoryID = "indoor", LogoImage = "M6T3/thailand.png" },
                new { CountryID = "uruguay", Name = "Uruguay", GameID = "para", CategoryID = "indoor", LogoImage = "M6T3/uruguay.png" },
                new { CountryID = "ukraine", Name = "Ukraine", GameID = "para", CategoryID = "indoor", LogoImage = "M6T3/ukraine.png" },
                new { CountryID = "austria", Name = "Austria", GameID = "para", CategoryID = "outdoor", LogoImage = "M6T3/austria.png" },
                new { CountryID = "pakistan", Name = "Pakistan", GameID = "para", CategoryID = "outdoor", LogoImage = "M6T3/pakistan.png" },
                new { CountryID = "zimbabwe", Name = "Zimbabwe", GameID = "para", CategoryID = "outdoor", LogoImage = "M6T3/zimbabwe.png" },
                new { CountryID = "france", Name = "France", GameID = "youth", CategoryID = "indoor", LogoImage = "M6T3/france.png" },
                new { CountryID = "cyprus", Name = "Cyprus", GameID = "youth", CategoryID = "indoor", LogoImage = "M6T3/cyprus.png" },
                new { CountryID = "russia", Name = "Russia", GameID = "youth", CategoryID = "indoor", LogoImage = "M6T3/russia.png" },
                new { CountryID = "finland", Name = "Finland", GameID = "youth", CategoryID = "outdoor", LogoImage = "M6T3/finland.png" },
                new { CountryID = "slovakia", Name = "Slovakia", GameID = "youth", CategoryID = "outdoor", LogoImage = "M6T3/slovakia.png" },
                new { CountryID = "portugal", Name = "Portugal", GameID = "youth", CategoryID = "outdoor", LogoImage = "M6T3/portugal.png" }
            );
        }
    }
}
