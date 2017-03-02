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
        private ApplicationDbContext db = new ApplicationDbContext();

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
            db.Newsletters.Add(newsletter);
            db.SaveChanges();
            return RedirectToAction("NewsletterConfirm", new { id = newsletter.NewsletterId });

        }

        public IActionResult NewsletterConfirm(int id)
        {
            var thisSignUp = db.Newsletters.FirstOrDefault(n => n.NewsletterId == id);
            return View(thisSignUp);
        }
    }
}
