using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuizCreator.Models;
using QuizCreator.ViewModels;

namespace QuizCreator.Controllers
{
    public class QuestionsController : Controller
    {
        public ViewResult Index()
        {
            var questions = GetQuestions();

            return View(questions);
        }

        public IEnumerable<Question> GetQuestions()
        {
            return new List<Question>
        {
        new Question {Id = 1, Name = "Who is Json?"},
        new Question {Id = 2, Name = "Are you Linus?"}
        };
        }

        // GET: Questions
        public ActionResult Random()
        {
            var question = new Question()
            {
                Name = "What is Json?"
            };

            var ownerUser = new List<OwnerUser>
        {
        new OwnerUser() { Name = "User 1"},
        new OwnerUser() { Name = "User 2"}
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