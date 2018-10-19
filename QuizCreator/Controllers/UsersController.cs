using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using QuizCreator.Models;

namespace QuizCreator.Controllers
{
    public class UsersController : Controller
    {

        private ApplicationDbContext _context;

        public UsersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool Disposing)
        {
            _context.Dispose();
        }

        // GET: OwnerUsers
        public ActionResult Index()
        {

            var user = _context.Users.ToList();
            
            return View(user);
        }

        public ActionResult Details(int id)
        {
            var user = _context.Users.SingleOrDefault(c => c.Id == id);
            if (user == null)
                return HttpNotFound();
            return View(user);
        }

        //No need for this after we create db access via _context 
        //private IEnumerable<OwnerUser> GetOwnerUsers()
        //{
        //    return new List<OwnerUser>
        //    {
        //        new OwnerUser { Id = 1, Name = "John Deere" },
        //        new OwnerUser { Id = 2, Name = "Mary Poppins" }
        //    };
        //}
    }
}