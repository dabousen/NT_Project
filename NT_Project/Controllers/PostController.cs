using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using NT_Project.Models;
using NT_Project.ViewModels;

namespace NT_Project.Controllers
{
    public class PostController : Controller
    {
        protected ApplicationDbContext _Context { get; set; }
        // GET: Post
        public PostController()
        {
            _Context = new ApplicationDbContext();
        }
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public List<ApplicationUser> GetFriends(string id)
        {
            var currentId = User.Identity.GetUserId();
            var user = _Context.Users.Find(currentId);
            var firstRelations = user.FirstRelationships.ToList();
            var secondRelations = user.SecondRelationships.ToList();
            var relatedUsers = new List<RelationsModel>();

            foreach (var friend in firstRelations)
            {
                if (friend.type == 0)  relatedUsers.Add(new RelationsModel { User = friend.Second, Type = friend.type });
            }
            foreach (var friend in secondRelations)
            {
                if (friend.type == 0) relatedUsers.Add(new RelationsModel { User = friend.First, Type = friend.type * -1 });
            }

            var ret = new List<ApplicationUser>();
            foreach (var item in relatedUsers)
            {
                if (item.Type == 0) ret.Add(item.User);
            }
            return ret;
        }
        public ActionResult GetFriendsPosts()
        {
            var friends = GetFriends(User.Identity.GetUserId());
            var posts = new List<Post>();
            foreach (var item in friends)
            {
                posts.AddRange(item.Posts.ToList());
            }

            var ret = ShuffleList(posts);
            return View(friends);
        }
        private List<E> ShuffleList<E>(List<E> inputList)
        {
            List<E> randomList = new List<E>();

            Random r = new Random();
            int randomIndex = 0;
            while (inputList.Count > 0)
            {
                randomIndex = r.Next(0, inputList.Count); //Choose a random object in the list
                randomList.Add(inputList[randomIndex]); //add it to the new, random list
                inputList.RemoveAt(randomIndex); //remove to avoid duplicates
            }

            return randomList; //return the new random list
        }
    }
}