/***************************************************************
* Name        : M12T2/FormatBodyTagHelper.cs
* Author      : Tom Sorteberg
* Created     : 04/26/2021
* Course      : CIS 174
* Version     : 1.0
* OS          : Windows 10 Pro, Visual Studio Community 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Module 12 Topic 2
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access 
* to my program.         
***************************************************************/
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CIS174CourseWebsite.Areas.M12T2.TagHelpers
{
    public class BodyTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output) { 
           output.Attributes.SetAttribute("style", "background-image: url('images / M12T2 / 4851219536_0a6a485c9d_o.jpg')");
        }
    }
}
