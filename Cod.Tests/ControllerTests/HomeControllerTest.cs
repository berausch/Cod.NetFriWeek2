using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Cod.Controllers;
using Cod.Models;
using Xunit;

namespace Cod.Tests.ControllerTests
{
    public class HomeControllerTest
    {
        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_NsSignup_Test()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            var result = controller.NsSignUp();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Get_ViewResult_NewsletterConfirm_Test()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            var result = controller.NewsletterConfirm();

            //Assert
            Assert.IsType<ViewResult>(result);
        }

    }
}
