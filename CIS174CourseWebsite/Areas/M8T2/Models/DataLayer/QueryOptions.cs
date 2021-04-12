/***************************************************************
* Name        : M8T2/DataLayer/QueryOptions.cs
* Author      : Tom Sorteberg
* Created     : 04/11/2021
* Course      : CIS 174
* Version     : 1.0
* OS          : Windows 10 Pro, Visual Studio Community 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Module 11 Topic 3
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access 
* to my program.         
***************************************************************/
using System;
using System.Linq.Expressions;


namespace CIS174CourseWebsite.Areas.M8T2.Models.DataLayer
{
    public class QueryOptions<T>
    {
        // public properties for sorting and filtering
        public Expression<Func<T, Object>> OrderBy { get; set; }
        public Expression<Func<T, bool>> Where { get; set; }

        // private string array for include statements
        private string[] includes;

        // public write-only property for include statements - converts string to array
        public string Includes
        {
            set => includes = value.Replace(" ", "").Split(',');
        }

        // public get method for include statements - returns private string array or empty string array
        public string[] GetIncludes() => includes ?? new string[0];

        // read-only properties 
        public bool HasWhere => Where != null;
        public bool HasOrderBy => OrderBy != null;
    }
}
