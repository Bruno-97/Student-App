using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Studomat.DAL;
using Studomat.MODEL;
using Studomat.WEB.Models;

namespace Studomat.WEB.Controllers
{
    [Authorize]
    public class StudentController : BaseController
    {
        private readonly StudentManagerDbContext _dbContext;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly UserManager<AppUser> userManager;

        public StudentController(StudentManagerDbContext _dbContext, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager, UserManager<AppUser> userManager) : base(_dbContext, userManager)
        {
            this._dbContext = _dbContext;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        [Authorize (Roles = "Student")]
        public IActionResult Index()
        {
            var currentUserId = userManager.GetUserId(HttpContext.User);
            var user = _dbContext.Users.Include(u => u.Fakultet).FirstOrDefault(u => u.Id == currentUserId);

            return View(user);
        }

        public IActionResult OsnovneInformacije()
        {
            var currentUserId = userManager.GetUserId(HttpContext.User);
            var user = _dbContext.Users.Include(u => u.Fakultet).FirstOrDefault(u => u.Id == currentUserId);

            return PartialView("_OsnovneInformacije", user);
        }

        [Authorize(Roles = "Student")]
        [ActionName(nameof(Details))]
        public IActionResult Details()
        {
            var currentUserId = userManager.GetUserId(HttpContext.User);
            var user = _dbContext.Users.Include(u => u.Mjesto).Include(u => u.Fakultet).FirstOrDefault(u => u.Id == currentUserId);

            this.FillDropdownValues();
            return View(user);
        }

        [HttpPost]
        [Authorize(Roles = "Student")]
        [ActionName(nameof(Details))]
        public async Task<IActionResult> DetailsPost(string id)
        {
            var user = this._dbContext.Users.FirstOrDefault(u => u.Id == id);
            var ok = await this.TryUpdateModelAsync(user);

            if (ok && this.ModelState.IsValid)
            {
                //if (isEmailAlreadyExists)
                //{
                //    ModelState.AddModelError("Email", "User with this email already exists");
                //    this.FillDropdownValues();
                //    return View();
                //}

                this._dbContext.SaveChanges();
                return RedirectToAction(nameof(Details));
            }

            this.FillDropdownValues();
            return View();
        }
            
        [Authorize (Roles = "Student")]
        public IActionResult About()
        {
            var currentUserId = userManager.GetUserId(HttpContext.User);
            var user = _dbContext.Users.Include(u => u.Fakultet).FirstOrDefault(u => u.Id == currentUserId);
            
            return View(user);
        }

        private void FillDropdownValues()
        {
            //**************************//
            var selectitems2 = new List<SelectListItem>();

            var listItem2 = new SelectListItem();
            listItem2.Text = "- MJESTO -";
            listItem2.Value = "";
            selectitems2.Add(listItem2);

            foreach (var mjesto in this._dbContext.Mjesta.OrderBy(m => m.NazivMjesta))
            {
                listItem2 = new SelectListItem(mjesto.NazivMjesta, mjesto.ID.ToString());
                selectitems2.Add(listItem2);
            }

            ViewBag.PossibleMjesto = selectitems2;
        }

        [HttpGet]
        [Authorize(Roles = "Student")]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> ChangePassword(ChangePasswordModel model)
        {         
            if (ModelState.IsValid)
            {
                var user = await userManager.GetUserAsync(User);
                if (user == null)
                {
                    return RedirectToAction("Login");
                }

                var result = await userManager.ChangePasswordAsync(user, model.TrenutnaLozinka, model.NovaLozinka);

                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return View();
                }

                await signInManager.RefreshSignInAsync(user);
                return View("ChangePasswordConfirmation");
            }

            return View(model);
        }

        [Authorize(Roles = "Student")]
        public IActionResult Grades()
        {
            var currentUserId = userManager.GetUserId(HttpContext.User);
            var user = _dbContext.Users.Include(u => u.Mjesto).Include(u => u.Fakultet).Include(u => u.Fakultet.Kolegiji).Include(u => u.Ocjenes).FirstOrDefault(u => u.Id == currentUserId);
            
            var studenti = _dbContext.Users.Include(u => u.Mjesto).Include(u => u.Fakultet).Include(u => u.Fakultet.Kolegiji).Include(u => u.Ocjenes).ToList();

            float ukupnoOcjene = 0;
            int brojNegativnihOcjena = 0;

            float ukupanZbroj = 0;
            float brojOcjena = 0;

            for (int i = 0; i < _dbContext.Users.Count(); i++)
            {
                if (studenti[i].FakultetId == user.FakultetId)
                {
                    var student = studenti[i];
                    brojOcjena = brojOcjena + student.Ocjenes.Count();
                    for (int j = 0; j < student.Ocjenes.Count(); j++)
                    {
                        ukupanZbroj = ukupanZbroj + student.Ocjenes[j].Ocjena;
                    }
                }
            }

            for (int i = 0; i < user.Ocjenes.Count(); i++)
            {
                ukupnoOcjene = ukupnoOcjene + user.Ocjenes[i].Ocjena;

                if (user.Ocjenes[i].Ocjena == 1)
                {
                    brojNegativnihOcjena = brojNegativnihOcjena + 1;
                }
            }

            ViewBag.prosjekOcjena = ukupnoOcjene / user.Ocjenes.Count();
            ViewBag.brojNegativnih = brojNegativnihOcjena;
            ViewBag.prosjekOcjenaGeneracije = ukupanZbroj / brojOcjena;

            return View(user);
        }
    }
}