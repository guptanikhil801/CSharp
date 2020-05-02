using BusinessManager.InterfaceManager;
using FundooApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace FundooNotesXUnitTesting
{
   public class LabelControllerTesting
    {
        [Fact]
        public void AddLabel_Returns_OkResult()
        {
            //// Arrange
            var service = new Mock<ILabelManager>();
            var controller = new LabelController(service.Object);

            //// Act
            var result = controller.AddLabel("new label");
            //// Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void DeleteLabel_Returns_OkResult()
        {
            //// Arrange
            var service = new Mock<ILabelManager>();
            var controller = new LabelController(service.Object);

            //// Act
            var result = controller.DeleteLabel(01);
            //// Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetAllLabels_Returns_OkResult()
        {
            //// Arrange
            var service = new Mock<ILabelManager>();
            var controller = new LabelController(service.Object);

            //// Act
            var result = controller.GetAllLabels();
            //// Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void UpdateLabel_Returns_OkResult()
        {
            //// Arrange
            var service = new Mock<ILabelManager>();
            var controller = new LabelController(service.Object);

            //// Act
            var result = controller.UpdateLabel("updated label",01);
            //// Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
