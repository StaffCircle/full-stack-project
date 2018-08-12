using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using api.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace api.tests.Controllers
{
    public class SmsControllerTests
    {
        [Fact]
        public void Get_ReturnsActionResult_WithCollectionOfStrings()
        {
            var smsController = new SmsController();
            var result = smsController.Get();

            // Assert
            var viewResult = Assert.IsType<OkObjectResult>(result);
            var model = Assert.IsAssignableFrom<IEnumerable<string>>(
                viewResult.Value);
            Assert.Equal(2, model.Count());
        }

        [Fact]
        public void Post_ReturnsActionResult_With200Status()
        {
            var smsController = new SmsController();
            var result = smsController.Post("");

            // Assert
            var viewResult = Assert.IsType<OkResult>(result);
            Assert.Equal(200, viewResult.StatusCode);
        }
    }
}
