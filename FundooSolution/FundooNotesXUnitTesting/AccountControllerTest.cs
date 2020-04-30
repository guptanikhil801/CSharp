using BusinessManager.InterfaceManager;
using Common.UserModel;
using FundooApi.Controllers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
namespace FundooNotesXUnitTesting
{
    public class AccountControllerTest
    {

        [Fact]
        public async Task Register_Should_Return_Ok_Resultasync()
        {
            var model = new RegistrationModel
            {
                FirstName = "new",
                LastName = "user",
                Email = "user@gmail.com",
                Password = "bridge@123",
                ConfirmPassword = "bridge@123",
                PhoneNumber = null
            };

            var userManager = new Mock<UserManager<User>>();
            var signInManager = new Mock<SignInManager<User>>();
            var manager = new Mock<IAccountManager>();
            var controller = new AccountController(manager.Object, userManager.Object, signInManager.Object);
            ////Act
            var result = await controller.Register(model);
            ////Assert
            Assert.IsAssignableFrom<IActionResult>(result);
        }

        [Fact]
        public  void Login_ReturnsOkResult()
        {

            var model = new LoginModel
            {
                Email = "guptanikhil801@gmail.com",
                Password = "Bridge@12345"
            };
            // Arrange
            var signInManager = new Mock<SignInManager<User>>();
            var manager = new Mock<IAccountManager>();
            var userManager = new Mock<UserManager<User>>();
            manager.Setup(repo => repo.DoLogin(model));
            var controller = new AccountController(manager.Object, userManager.Object, signInManager.Object);

            // Act
            var result =  controller.Login(model);
           

            Assert.Equal(200, result.Status);
        }
    }
}
