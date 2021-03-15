/***************************************************************
* Name        : M8T2/Ticket.cs
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
****************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174CourseWebsite.Areas.M8T2.Models
{
    public class Ticket
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a description.")]
        public string description { get; set; }

        [Required(ErrorMessage = "Please enter a sprint number.")]
        public string sprintNumber { get; set; }

        [Required(ErrorMessage = "Please enter a point value.")]
        public string pointValue { get; set; }

        [RequiredAttribute(ErrorMessage = "Please select a status.")]
        public string StatusId { get; set; }
        public Status status { get; set; }
    }
}
