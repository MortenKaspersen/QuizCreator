using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using QuizCreator.Models;

namespace QuizCreator.ViewModels
{
    public class RandomQuestionViewModel
    {
        public Question Question { get; set; }

        public List<OwnerUser> OwnerUsers { get; set; }

    }
}