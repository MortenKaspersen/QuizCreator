using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using QuizCreator.Models;

namespace QuizCreator.Models
{
    public class Question
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //public User User { get; set; }

        //[Display(Name = "User")]
        //public int UserId { get; set; }
        
        public string QuestionText { get; set; }

        public string AnswerOne { get; set; }

        public string AnswerTwo { get; set; }

        public string AnswerThree { get; set; }

        public string CorrectAnswer { get; set; }

        //public Tag Tag { get; set; }

        //[Display(Name = "Question Tag")]
        //public int TagId { get; set; }
        
        public string ExplanationText { get; set; }
        
        //public DateTime CreatedAt { get; set; }
        
        
    }
}