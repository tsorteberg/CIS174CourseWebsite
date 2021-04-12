/***************************************************************
* Name        : M8T2/TicketContext.cs
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
using Microsoft.EntityFrameworkCore;

namespace CIS174CourseWebsite.Areas.M8T2.Models
{
    public class TicketContext : DbContext
    {
        public TicketContext() { }
        public TicketContext(DbContextOptions<TicketContext> options)
            : base(options) { }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = "todo", Name = "To Do"},
                new Status { StatusId = "inprogress", Name = "In Progress" },
                new Status { StatusId = "qualityassurance", Name = "Quality Assurance" },
                new Status { StatusId = "done", Name = "Done" }
                );
        }
    }
}
