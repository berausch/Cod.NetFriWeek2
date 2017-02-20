using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cod.Models;
using Xunit;

namespace Cod.Tests
{
    public class NewsletterTest
    {
        [Fact]
        public void GetNameTest()
        {
            //Arrange
            var newsletter = new Newsletter();
            newsletter.Name = "Gary";

            //Act
            var result = newsletter.Name;

            //Assert
            Assert.Equal("Gary", result);
        }
    }
}
