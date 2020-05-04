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
            var result = controller.AddCollabrator("guptanikhil801@gmail.com", 01);
            //// Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetAllCollabrators_Returns_OkResult()
        {
            //// Arrange
            var service = new Mock<ICollabratorManager>();
            var controller = new CollabratorController(service.Object);

            //// Act
            var result = controller.GetAllCollabrators();
            //// Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void RemoveCollabrator_Returns_OkResult()
        {
            //// Arrange
            var service = new Mock<ICollabratorManager>();
            var controller = new CollabratorController(service.Object);

            //// Act
            var result = controller.RemoveCollabrator(01);
            //// Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
