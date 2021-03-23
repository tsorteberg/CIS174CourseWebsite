using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace CIS174CourseWebsite.Areas.M9T2.Models
{
    public class ValidEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                try
                {
                    MailAddress m = new MailAddress((String)value);

                    return ValidationResult.Success;
                }
                catch (FormatException)
                {
                    string msg = "Please input a valid email address.";
                    return new ValidationResult(msg);
                }
            }
            else
            {
                string msg = "Please enter an email address.";
                return new ValidationResult(msg);
            }
        }
    }
}
