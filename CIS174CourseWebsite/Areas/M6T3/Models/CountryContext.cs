/***************************************************************
* Name        : CountryContext.cs
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

        public DbSet<Country> Teams { get; set; }
        public DbSet<Game> Conferences { get; set; }
        public DbSet<Sport> Divisions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Game>().HasData(
                new Game { GameID = "winter", Name = "Winter Olympics" },
                new Game { GameID = "summmer", Name = "Summer Olympics" },
                new Game { GameID = "para", Name = "Paraympics" },
                new Game { GameID = "youth", Name = "Youth Olympic Games" }
            );
            modelBuilder.Entity<Sport>().HasData(
                new Sport { SportID = "curling", Name = "Curling/Indoor" },
                new Sport { SportID = "bobsleigh", Name = "Bobsleigh/Outdoor" },
                new Sport { SportID = "diving", Name = "Diving/Indoor" },
                new Sport { SportID = "cycling", Name = "Road Cycling/Outdoor" },
                new Sport { SportID = "archery", Name = "Archery/Indoor" },
                new Sport { SportID = "canoeing", Name = "Canoe Spring/Outdoor" },
                new Sport { SportID = "breakdancing", Name = "Breakdancing/Indoor" },
                new Sport { SportID = "skateboarding", Name = "Skateboarding/Outdoor" }
            );
            modelBuilder.Entity<Country>().HasData(
                new { CountryID = "canada", Name = "Canada", GameID = "winter", SportID = "curling", LogoImage = "canada.png" },
                new { CountryID = "sweden", Name = "Sweden", GameID = "winter", SportID = "curling", LogoImage = "sweden.png" },
                new { CountryID = "greatbritain", Name = "Great Britain", GameID = "winter", SportID = "curling", LogoImage = "greatbritain.png" },
                new { CountryID = "jamaica", Name = "Jamaica", GameID = "winter", SportID = "bobsleigh", LogoImage = "jamaica.png" },
                new { CountryID = "italy", Name = "Italy", GameID = "winter", SportID = "bobsleigh", LogoImage = "italy.png" },
                new { CountryID = "japan", Name = "Japan", GameID = "winter", SportID = "bobsleigh", LogoImage = "japan.png" },
                new { CountryID = "germany", Name = "Germany", GameID = "summer", SportID = "diving", LogoImage = "germany.png" },
                new { CountryID = "china", Name = "China", GameID = "summer", SportID = "diving", LogoImage = "china.png" },
                new { CountryID = "mexico", Name = "Mexico", GameID = "summer", SportID = "diving", LogoImage = "mexico.png" },
                new { CountryID = "brazil", Name = "Brazil", GameID = "summer", SportID = "cycling", LogoImage = "brazil.png" },
                new { CountryID = "netherlands", Name = "Netherlands", GameID = "summer", SportID = "cycling", LogoImage = "netherlands.png" },
                new { CountryID = "usa", Name = "USA", GameID = "summer", SportID = "cycling", LogoImage = "usa.png" },
                new { CountryID = "thailand", Name = "Thailand", GameID = "para", SportID = "archery", LogoImage = "thailand.png" },
                new { CountryID = "uruguay", Name = "Uruguay", GameID = "para", SportID = "archery", LogoImage = "uraguay.png" },
                new { CountryID = "ukraine", Name = "Ukraine", GameID = "para", SportID = "archery", LogoImage = "ukraine.png" },
                new { CountryID = "austria", Name = "Austria", GameID = "para", SportID = "canoeing", LogoImage = "austria.png" },
                new { CountryID = "pakistan", Name = "Pakistan", GameID = "para", SportID = "canoeing", LogoImage = "pakistan.png" },
                new { CountryID = "zimbabwe", Name = "Zimbabwe", GameID = "para", SportID = "canoeing", LogoImage = "pakistan.png" },
                new { CountryID = "france", Name = "France", GameID = "youth", SportID = "breakdancing", LogoImage = "france.png" },
                new { CountryID = "cyprus", Name = "Cyprus", GameID = "youth", SportID = "breakdancing", LogoImage = "cyprus.png" },
                new { CountryID = "russia", Name = "Russia", GameID = "youth", SportID = "breakdancing", LogoImage = "russia.png" },
                new { CountryID = "finland", Name = "Finland", GameID = "youth", SportID = "skateboarding", LogoImage = "finland.png" },
                new { CountryID = "slovakia", Name = "Slovakia", GameID = "youth", SportID = "skateboarding", LogoImage = "slovakia.png" },
                new { CountryID = "portugal", Name = "Portugal", GameID = "youth", SportID = "skateboarding", LogoImage = "portugal.png" }
            );
        }
    }
}
