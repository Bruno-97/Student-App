using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Studomat.DAL;
using Studomat.MODEL;

namespace Studomat.WEB.Controllers
{
    public class BaseController : Controller
    {
        private StudentManagerDbContext _dbContext;
        private UserManager<AppUser> _userManager;

        public string UserId { get => this._userManager.GetUserId(base.User); }

        public BaseController(StudentManagerDbContext dbContext, UserManager<AppUser> userManager)
        {
            this._dbContext = dbContext;
            this._userManager = userManager;
        }
    }
}