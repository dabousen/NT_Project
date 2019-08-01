using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NT_Project.Models;

namespace NT_Project.Controllers
{
    public class InteractionsController : Controller
    {

        //public ActionResult Index()
        //{
        //    return View();
        //}
        protected ApplicationDbContext _Context { get; set; }

        public InteractionsController()
        {
            _Context = new ApplicationDbContext();
        }
        public ActionResult GetInteractions(string id)
        {
            var currPost = _Context.Posts.Find(id);
            List<Interaction> res = new List<Interaction>();
            if (currPost != null)
            {
                res =  currPost.Interactions.ToList();
            }
            return View(res);
        }
    }
}