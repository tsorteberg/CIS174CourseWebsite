/***************************************************************
* Name        : Assignment.cs
* Author      : Tom Sorteberg
* Created     : 02/14/2021
* Course      : CIS 174
* Version     : 1.0
* OS          : Windows 10 Pro, Visual Studio Community 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Module 4 Topic 5
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access 
* to my program.         
***************************************************************/
using System.ComponentModel.DataAnnotations;

namespace CIS174CourseWebsite.Models
{
    public class Assignment
    {
        // Primary Key Attribute.
        public int AssignmentId { get; set; }

        // Required Attributes.
        [Required(ErrorMessage = "Please enter an assignment name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a URL.")]
        public string URL { get; set; }

        public string Note { get; set; }

        // Slug definition and initialization.
        public string Slug => Name?.Replace(' ', '-').ToLower();
    }
}
