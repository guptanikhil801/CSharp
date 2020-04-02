using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagementSystem.Manager;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IEmployeeManager loginmanager;
        public LoginController(IEmployeeManager loginmanager)
        {
            this.loginmanager = loginmanager;
        }
        public bool Login(string email,string password)
        {
           return this.loginmanager.Login(email, password);
        }
    }
}
