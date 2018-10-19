using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuizCreator.Models;

namespace QuizCreator.Controllers
{
    public class OwnerUsersController : Controller
    {
        // GET: OwnerUsers
        public ActionResult Index()
        {

            var ownerUser = GetOwnerUsers();

            return View(ownerUser);
        }

        public ActionResult Details(int id)
        {
            var ownerUser = GetOwnerUsers().SingleOrDefault(c => c.Id == id);
            if (ownerUser == null)
                return HttpNotFound();
            return View(ownerUser);
        }
        private IEnumerable<OwnerUser> GetOwnerUsers()
        {
            return new List<OwnerUser>
            {
                new OwnerUser { Id = 1, Name = "John Deere" },
                new OwnerUser { Id = 2, Name = "Mary Poppins" }
            };
        }
    }
}