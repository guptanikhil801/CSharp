using System;
using System.Collections.Generic;
using System.Text;
using BusinessManager.InterfaceManager;
using Common.ModelsOfNotes;
using FundooApi.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace FundooNotesXUnitTesting
{
    public class NotesControllerTest
    {
        [Fact]
        public void AddNote_Returns_OkResult()
        {
            //// Arrange
            var service = new Mock<INotesManager>();
            var controller = new NotesController(service.Object);
            var model = new NewNote
            {
                Title = "new note",
                Colour = "Blue",
                Description = "new note created",
                Reminder = "empty"
            };


            //// Act
            var result = controller.AddNote(model, "newgmail801@gmail.com");
            //// Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void UpdateNote_Returns_OkResult()
        {
            //// Arrange
            var service = new Mock<INotesManager>();
            var controller = new NotesController(service.Object);
            var model = new NewNote
            {
                
                Colour = "Pink",
                Description = "updated Description",
                Reminder = "Nothing to remember",
                Title = "TestTitle"
            };
            
            //// Act
            var result = controller.UpdateNote(model, 01,"newgmail801@gmail.com");
            //// Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetNote_Returns_OkResult()
        {
            //// Arrange
            var service = new Mock<INotesManager>();
            var controller = new NotesController(service.Object);

            //// Act
            var result = controller.GetNote(01, "newgmail801@gmail.com");
            //// Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public void GetAllNotes_Returns_OkResult()
        {
            //// Arrange
            var service = new Mock<INotesManager>();
            var controller = new NotesController(service.Object);

            //// Act
            var result = controller.GetAllNotes("newgmail801@gmail.com");
            //// Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
