/***************************************************************
* Name        : M6T3/OlympicSession.cs
* Author      : Tom Sorteberg
* Created     : 03/07/2021
* Course      : CIS 174
* Version     : 1.0
* OS          : Windows 10 Pro, Visual Studio Community 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : Module 7 Topic 3
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access 
* to my program.         
****************************************************************/
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174CourseWebsite.Areas.M6T3.Models
{
    public class OlympicSession
    {
        private const string CountryKey = "mycountries";
        private const string CountKey = "countrycount";
        private const string GameKey = "game";
        private const string CategoryKey = "category";

        private ISession session { get; set; }
        public OlympicSession(ISession session)
        {
            this.session = session;
        }

        public void SetMyCountries(List<Country> countries)
        {
            session.SetObject(CountryKey, countries);
            session.SetInt32(CountKey, countries.Count);
        }
        public List<Country> GetMyCountries() =>
            session.GetObject<List<Country>>(CountryKey) ?? new List<Country>();
        public int GetMyCountryCount() => session.GetInt32(CountKey) ?? 0;

        public void SetActiveGame(string activeGame) =>
            session.SetString(GameKey, activeGame);
        public string GetActiveGame() => session.GetString(GameKey);

        public void SetActiveCategory(string activeCategory) =>
            session.SetString(CategoryKey, activeCategory);
        public string GetActiveCategory() => session.GetString(CategoryKey);

        public void RemoveMyCountries()
        {
            session.Remove(CountryKey);
            session.Remove(CountKey);
        }
    }
}
