/***************************************************************
* Name        : CIS174CourseWebsite.Tests/M8T2HomeControllerTests.cs
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
using CIS174CourseWebsite.Areas.M8T2.Controllers;
using System;
using Xunit;
using Moq;
using CIS174CourseWebsite.Areas.M8T2.Models;
using Microsoft.AspNetCore.Mvc;
using CIS174CourseWebsite.Areas.M8T2.Models.DataLayer;

namespace CIS174CourseWebsite.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void IndexActionMethod_ReturnsAViewResult()
        {
            // ARRANGE
            var ti = new Mock<IRepository<Ticket>>();
            var st = new Mock<IRepository<Status>>();
            var controller = new HomeController(ti.Object, st.Object);
            String id = "all-all";

            // ACT
            var result = controller.Index(id);

            // ASSERT
            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public void AddHttpGetAction_ReturnsAViewResult()
        {
            // ARRANGE
            var ti = new Mock<IRepository<Ticket>>();
            var st = new Mock<IRepository<Status>>();
            var controller = new HomeController(ti.Object, st.Object);

            // ACT
            var result = controller.Add();

            // ASSERT
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void AddHttpPostAction_ReturnsToActionResult()
        {
            // ARRANGE
            var ti = new Mock<IRepository<Ticket>>();
            var st = new Mock<IRepository<Status>>();
            var controller = new HomeController(ti.Object, st.Object);

            // ACT
            var result = controller.Add(new Ticket());

            // ASSERT
            Assert.IsType<RedirectToActionResult>(result);
        }

        [Fact]
        public void AddHttpPostAction_RedirectToActionResult()
        {
            // ARRANGE
            var ti = new Mock<IRepository<Ticket>>();
            var st = new Mock<IRepository<Status>>();
            var controller = new HomeController(ti.Object, st.Object);
            Ticket ticket = new Ticket();

            // ACT
            var result = controller.Add(ticket);

            // ASSERT
            Assert.IsType<RedirectToActionResult>(result);
        }

        [Fact]
        public void AddHttpPostAction_ReturnToViewResult()
        {
            // ARRANGE
            var ti = new Mock<IRepository<Ticket>>();
            var st = new Mock<IRepository<Status>>();
            var controller = new HomeController(ti.Object, st.Object);

            // ACT
            var result = controller.Add();

            // ASSERT
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void EditPostActionMethod_ReturnsToActionResult()
        {
            // ARRANGE
            var ti = new Mock<IRepository<Ticket>>();
            var st = new Mock<IRepository<Status>>();
            var controller = new HomeController(ti.Object, st.Object);
            String id = "all-all";

            // ACT
            var result = controller.Edit(id, new Ticket());

            // ASSERT
            Assert.IsType<RedirectToActionResult>(result);
        }
    }
}
