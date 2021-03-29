/***************************************************************
* Name        : M9T2/TicketContext.cs
* Author      : Tom Sorteberg
* Created     : 03/29/2021
* Course      : CIS 174
* Version     : 1.0
* OS          : Windows 10 Pro, Visual Studio Community 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Module 10 Topic 2
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access 
* to my program.         
***************************************************************/
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174CourseWebsite.Areas.M9T2.Models
{
    public class RegistrationModelContext : DbContext
    {
        public RegistrationModelContext(DbContextOptions<RegistrationModelContext> options)
            : base(options) { }

        public DbSet<RegistrationModel> Validation { get; set; }
    }
}
