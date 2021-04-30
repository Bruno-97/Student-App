using System;
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
    public class AdminController : BaseController
    {
        private readonly StudentManagerDbContext _dbContext;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly UserManager<AppUser> userManager;

        public AdminController(StudentManagerDbContext dbContext, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager, UserManager<AppUser> userManager) : base(dbContext, userManager)
        {
            this._dbContext = dbContext;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult UserList(string sortBy)
        {
            var users = userManager.Users;

            ViewBag.SortNameParameter = string.IsNullOrEmpty(sortBy) ? "Name desc" : "";
            ViewBag.SortJMBAGParameter = sortBy == "JMBAG" ? "JMBAG desc" : "JMBAG";
            ViewBag.SortRedovniParameter = sortBy == "REDOVNI" ? "REDOVNI asc" : "REDOVNI";
            ViewBag.SortIzvanredniParameter = sortBy == "IZVANREDNI" ? "IZVANREDNI asc" : "IZVANREDNI";

            switch (sortBy)
            {
                case "Name desc":
                    users = users.OrderByDescending(u => u.Prezime);
                    break;
                case "JMBAG desc":
                    users = users.OrderByDescending(u => u.JMBAG);
                    break;
                case "JMBAG":
                    users = users.OrderBy(u => u.JMBAG);
                    break;
                case "REDOVNI asc":
                    users = users.OrderBy(u => u.Prezime).OrderBy(u => u.Status).Where(u => u.Status == "REDOVNI");
                    break;
                case "REDOVNI":
                    users = users.OrderBy(u => u.JMBAG).Where(u => u.Status == "REDOVNI");
                    break;
                case "IZVANREDNI asc":
                    users = users.OrderBy(u => u.Prezime).OrderBy(u => u.Status).Where(u => u.Status == "IZVANREDNI");
                    break;
                case "IZVANREDNI":
                    users = users.OrderBy(u => u.JMBAG).Where(u => u.Status == "IZVANREDNI");
                    break;
                default:
                    users = users.OrderBy(u => u.Prezime);
                    break;
            }

            return View(users.ToList());
        }

        [Authorize(Roles = "Admin")]
        public IActionResult PregledPoMjestima()
        {
            return View(this._dbContext.Mjesta.Include(m => m.AppUsers).OrderBy(m => m.NazivMjesta).Include(m => m.Fakulteti).Include(z => z.Zupanija).ToList());
        }

        [Authorize(Roles = "Admin")]
        public IActionResult PregledPoFakultetima()
        {
            //.Include(z => z.Mjesto.Zupanija)
            return View(this._dbContext.Fakulteti.Include(m => m.AppUsers).OrderBy(m => m.Naziv).Include(z => z.Mjesto).ToList());
        }

        [Authorize(Roles = "Admin")]
        public IActionResult PregledPojedinogMjesta(int? id)
        {
            var mjesto = this._dbContext.Mjesta.Include(p => p.AppUsers).Where(p => p.ID == id).FirstOrDefault();

            return View(mjesto);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult PregledPojedinogfakulteta(int? id)
        {
            var fakultet = this._dbContext.Fakulteti.Include(f => f.AppUsers).Where(f => f.ID == id).FirstOrDefault();

            return View(fakultet);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult ListaFakulteta()
        {
            var fakulteti = _dbContext.Fakulteti
                .Include(f => f.Mjesto)
                .Include(f => f.Mjesto.Nastavnici)
                .Include(f => f.AppUsers)
                .Include(f => f.Kolegiji)
                .OrderBy(f => f.Naziv).ToList();

            return View(fakulteti);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult ListaFakultetaFilter(UniversityFilterModel filter)
        {
            var fakulteti = _dbContext.Fakulteti.Include(f => f.Mjesto).Include(f => f.Mjesto.Nastavnici).Include(f => f.AppUsers).Include(f => f.Kolegiji).OrderBy(f => f.Naziv).AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter.UniversityName))
            {
                fakulteti = fakulteti.Where(f => (f.Naziv).Contains(filter.UniversityName));
            }

            var model = fakulteti.ToList();
            return PartialView("_TabelaFakulteta", model);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
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

        [Authorize(Roles = "Admin")]
        public IActionResult About()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Delete()
        {
            this.FillDropdownValues();
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult StudentDeleted()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult StudentDodan()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [ActionName(nameof(EditUser))]
        public IActionResult EditUser(string id)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Id == id);

            this.FillDropdownValues();
            return View(user);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ActionName(nameof(EditUser))]
        public async Task<IActionResult> EditUserPost(string id)
        {
            var user = this._dbContext.Users.FirstOrDefault(u => u.Id == id);
            var ok = await this.TryUpdateModelAsync(user);

            if (ok && this.ModelState.IsValid)
            {
                this._dbContext.SaveChanges();
                return RedirectToAction(nameof(UserList));
            }

            this.FillDropdownValues();
            return View();
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            var user = await userManager.FindByIdAsync(id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"Korisnik s id-em -> { id } ne postoji.";
                return View("NepostojeciStudent");
            }
            else
            {
                var result = await userManager.DeleteAsync(user);
                
             
                if (result.Succeeded)
                {
                    return RedirectToAction("StudentDeleted");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }

                return View("UserList");
            }
        }

        private void FillDropdownValues()
        {
            //**************************//
            var selectItems1 = new List<SelectListItem>();

            var listItem1 = new SelectListItem();
            listItem1.Text = "- Korisničko ime -";
            listItem1.Value = "";
            selectItems1.Add(listItem1);

            foreach (var user in this._dbContext.Users.OrderBy(u => u.UserName))
            {
                listItem1 = new SelectListItem(user.UserName, user.Id.ToString());

                if (user.Id != "dc014294-7c49-4e07-bce8-1aa798eb8368")
                {
                    selectItems1.Add(listItem1);
                }
            }

            ViewBag.PossibleUsers = selectItems1;

            //**************************//
            var selectItems4 = new List<SelectListItem>();

            var listItem6 = new SelectListItem();
            listItem6.Text = "- Fakultet -";
            listItem6.Value = "";
            selectItems4.Add(listItem6);

            foreach (var fakultet in this._dbContext.Fakulteti.OrderBy(u => u.Naziv))
            {
                listItem6 = new SelectListItem(fakultet.Naziv, fakultet.ID.ToString());
                selectItems4.Add(listItem6);
            }

            ViewBag.PossibleFakultet = selectItems4;

            //**************************//
            var selectitems2 = new List<SelectListItem>();

            var listItem2 = new SelectListItem();
            listItem2.Text = "- MJESTO -";
            listItem2.Value = "";
            selectitems2.Add(listItem2);

            foreach(var mjesto in this._dbContext.Mjesta.OrderBy(m => m.NazivMjesta))
            {
                listItem2 = new SelectListItem(mjesto.NazivMjesta, mjesto.ID.ToString());
                selectitems2.Add(listItem2);
            }

            ViewBag.PossibleMjesto = selectitems2;

            //**************************//
            var selectitems3 = new List<SelectListItem>();

            var listItem3 = new SelectListItem();
            listItem3.Text = "- STATUS -";
            listItem3.Value = "";
            selectitems3.Add(listItem3);

            var listItem4 = new SelectListItem();
            listItem4.Text = "REDOVNI";
            listItem4.Value = "REDOVNI";
            selectitems3.Add(listItem4);

            var listItem5 = new SelectListItem();
            listItem5.Text = "IZVANREDNI";
            listItem5.Value = "IZVANREDNI";
            selectitems3.Add(listItem5);

            ViewBag.PossibleStatus = selectitems3;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Details(string id = null)
        {
            var student = this._dbContext.Users
                .Include(p => p.Fakultet)
                .Include(p => p.Mjesto)
                .Include(p => p.Ocjenes)
                .Include(p => p.Fakultet.Kolegiji)
                .Where(p => p.Id == id)
                .FirstOrDefault();

            float ukupnoOcjene = 0;
            for(int i = 0; i < student.Ocjenes.Count(); i++)
            {
                ukupnoOcjene = ukupnoOcjene + student.Ocjenes[i].Ocjena; 
            }

            ViewBag.prosjekOcjena = ukupnoOcjene / student.Ocjenes.Count();

            return View(student);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Statistika()
        {
            ViewBag.brojNastavnika = _dbContext.Nastavnici.Count();
            ViewBag.brojKolegija = _dbContext.Kolegiji.Count();
            ViewBag.brojRedovnih = _dbContext.Users.Where(user => user.Status == "REDOVNI").Count();
            ViewBag.brojIzvanrednih = _dbContext.Users.Where(user => user.Status == "IZVANREDNI").Count();
            ViewBag.brojIzvarednih = _dbContext.Zupanije.Count();
            ViewBag.brojZupanija = _dbContext.Zupanije.Count();
            ViewBag.brojMjesta = _dbContext.Mjesta.Count();
            ViewBag.brojFakulteta = _dbContext.Fakulteti.Count();
            ViewBag.brojUsera = _dbContext.Users.Count() - 1;

            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult proba()
        {
            var fakulteti = _dbContext.Fakulteti
                .Include(f => f.Mjesto)
                .Include(f => f.AppUsers)
                .OrderBy(f => f.Naziv)
                .ToList();

            return View(fakulteti);
        }
    }
}