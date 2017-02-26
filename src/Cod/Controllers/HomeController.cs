using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Cod.Models;
using Cod.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Cod.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;


        public HomeController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult NsSignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NsSignUp(Newsletter newsletter)
        {
            _db.Newsletters.Add(newsletter);
            _db.SaveChanges();
            return RedirectToAction("NewsletterConfirm", new { id = newsletter.NewsletterId });

        }


        public IActionResult NewsletterConfirm(int id)
        {
            var thisSignUp = _db.Newsletters.FirstOrDefault(n => n.NewsletterId == id);
            return View(thisSignUp);
        }
    }
}
