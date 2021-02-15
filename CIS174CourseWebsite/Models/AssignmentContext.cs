/***************************************************************
* Name        : AssignmentContext.cs
* Author      : Tom Sorteberg
* Created     : 02/14/2021
* Course      : CIS 174
* Version     : 1.0
* OS          : Windows 10 Pro, Visual Studio Community 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Module 4 Topic 4
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access 
* to my program.         
***************************************************************/
using Microsoft.EntityFrameworkCore;

namespace CIS174CourseWebsite.Models
{
    public class AssignmentContext : DbContext
    {
        // Default constructor.
        public AssignmentContext(DbContextOptions<AssignmentContext> options) : base(options)
        { }

        // Create Contacts Table using Assignment.cs model.
        public DbSet<Assignment> Assignments { get; set; }

        // Initial seed.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Assignment>().HasData(
                new Assignment
                {
                    AssignmentId = 1,
                    Name = "Week 3 Module 3 - MultiPageWebApp",
                    URL = "https://multipagewebapp20210208221145.azurewebsites.net/"
                }
            );
        }
    }
}
