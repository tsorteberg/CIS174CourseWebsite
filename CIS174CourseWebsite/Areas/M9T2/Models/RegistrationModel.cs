/***************************************************************
* Name        : M9T2\RegistrationModel.cs
* Author      : Tom Sorteberg
* Created     : 03/22/2021
* Course      : CIS 174
* Version     : 1.0
* OS          : Windows 10 Pro, Visual Studio Community 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Module 9 Topic 2
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access 
* to my program.         
***************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174CourseWebsite.Areas.M9T2.Models
{
    public class RegistrationModel
    {
        // Instance variable declaration.
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name.")]
        [RegularExpression("(?i)^[a-zA-z .]+$", ErrorMessage ="Name contains invalid characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter an address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        [RegularExpression(@"^?([0-9]{3})[-]([0-9]{3})[-]([0-9]{4})$", ErrorMessage = "Phone number must be entered in XXX-XXX-XXXX format.")]
        public string Phone { get; set; }

        [ValidEmail]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please enter a contact preference.")]
        public string Preference { get; set; }
        
    }
}
