
using HelloMVC.Controllers;
using Microsoft.AspNetCore.Mvc;
namespace HelloMVC.Tests
{
    public class HomeControllerTest
    {
        [Fact]
        public void Index_Returns_ViewResult()
        {
            var controller = new HomeController();
            var result = controller.Index();
            Assert.IsType<ViewResult>(result);
        }
    }
}