using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuizCreator.Models
{
    public class Question
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string QuestionText { get; set; }

        public string AnswerOne { get; set; }

        public string AnswerTwo { get; set; }

        public string AnswerThree { get; set; }

        public string ExplanationText { get; set; }
        
        public DateTime CreatedAt { get; set; }

        
    }
}