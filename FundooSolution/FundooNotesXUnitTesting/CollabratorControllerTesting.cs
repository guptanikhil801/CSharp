namespace FundooNotesXUnitTesting
{
    using BusinessManager.InterfaceManager;
    using FundooApi.Controllers;
    using Microsoft.AspNetCore.Mvc;
    using Moq;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Xunit;

    public class CollabratorControllerTesting
    {
        [Fact]
        public void AddCollabrator_Returns_OkResult()
        {
            //// Arrange
            var service = new Mock<ICollabratorManager>();
            var controller = new CollabratorController(service.Object);

            //// Act
            var result = controller.AddCollabrator("newgmail801@gmail.com", "guptanikhil801@gmail.com", 01);
            //// Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
