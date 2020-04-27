using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessManager.InterfaceManager;
using Common.UserModel;
using FundooRepository.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FundooApi.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class LabelController : ControllerBase
    {
        private readonly UserManager<User> userManager;
        private readonly UserDBContext dbcontext;
        private readonly ILabelManager manager;

        public LabelController(UserManager<User> userManager, UserDBContext dbcontext, ILabelManager manager)
        {
            this.userManager = userManager;
            this.dbcontext = dbcontext;
            this.manager = manager;
        }
    }
}
