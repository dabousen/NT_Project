using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NT_Project.Models;

namespace NT_Project.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private ApplicationDbContext _context { get; set; }

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            if (User.Identity.IsAuthenticated) return View("About");
            return View();
        }
        [HttpPost]
        public ActionResult Index(string acc)
        {
            var res = _context.Users
                .Where(user => (user.FirstName.Contains(acc) || user.LastName.Contains(acc)) || user.PhoneNumber.Contains(acc) || user.Email.Contains(acc)).ToList();

            return View("Contact");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}