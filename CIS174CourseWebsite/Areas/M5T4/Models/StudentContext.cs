/***************************************************************
* Name        : StudentContext.cs
* Author      : Tom Sorteberg
* Created     : 02/22/2021
* Course      : CIS 174
* Version     : 1.0
* OS          : Windows 10 Pro, Visual Studio Community 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Module 5 Topic 4
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access 
* to my program.         
***************************************************************/
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174CourseWebsite.Areas.M5T4.Models
{
    public class StudentContext : DbContext
    {
        // Default constructor.
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        { }

        // Create Students Table using Assignment.cs model.
        public DbSet<Student> Students { get; set; }

        // Initial seed.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    FirstName = "Albert",
                    LastName = "Einstein",
                    Grade = "A"
                },
                new Student
                {
                    StudentId = 2,
                    FirstName = "Dwayne",
                    LastName = "Dibbley",
                    Grade = "C-"
                },
                new Student
                {
                    StudentId = 3,
                    FirstName = "Alfred E.",
                    LastName = "Neuman",
                    Grade = "F"
                },
                new Student
                {
                    StudentId = 4,
                    FirstName = "Rubin",
                    LastName = "Farr",
                    Grade = "B"
                }
            );
        }
    }
}
