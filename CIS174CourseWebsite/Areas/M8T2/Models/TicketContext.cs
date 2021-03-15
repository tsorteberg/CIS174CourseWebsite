using CIS174CourseWebsite.Areas.M8T2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174CourseWebsite.Areas.M8T2.Models
{
    public class TicketContext : DbContext
    {
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
