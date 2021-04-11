using CIS174CourseWebsite.Areas.M8T2.Controllers;
using System;
using Xunit;
using Moq;
using CIS174CourseWebsite.Areas.M8T2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CIS174CourseWebsite.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // ARRANGE

            var ctx = new Mock<TicketContext>();
            var controller = new HomeController(ctx.Object);
            String id = "1";

            // ACT
            var result = controller.Index(id);

            // ASSERT
            Assert.IsType<ViewResult>(result);

        }
    }
}
