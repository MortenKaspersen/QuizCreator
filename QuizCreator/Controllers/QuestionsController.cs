using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using QuizCreator.Models;
using QuizCreator.ViewModels;

namespace QuizCreator.Controllers
{
    public class QuestionsController : Controller
    {
        private ApplicationDbContext _context;

        public QuestionsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool Disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var question = _context.Questions.ToList();

            return View(question);
        }

        public ActionResult Details(int id)
        {
            var question = _context.Questions.Include(c => c.Tag).SingleOrDefault(c => c.Id == id);

            if (question == null)
                return HttpNotFound();

            return View(question);
        }

        // GET: Questions/Random
        public ActionResult Random()
        {
            var question = new Question()
            {
                Name = "What is Json?"
            };

            var ownerUser = new List<User>
        {
        new User() { Name = "User 1"},
        new User() { Name = "User 2"}
        };

            var viewModel = new RandomQuestionViewModel
            {
                Question = question,
                OwnerUsers = ownerUser
            };

            return View(viewModel);
        }
    }
}