using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using QuizCreator.Models;

namespace QuizCreator.ViewModels
{
    public class QuestionFormViewModel
    {
        public IEnumerable<Tag> Tags { get; set; }

        public IEnumerable<User> Users { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "User")]
        public int UserId { get; set; }

        public string QuestionText { get; set; }

        public string AnswerOne { get; set; }

        public string AnswerTwo { get; set; }

        public string AnswerThree { get; set; }

        public string CorrectAnswer { get; set; }

        [Display(Name = "Question Tag")]
        public int TagId { get; set; }

        public string ExplanationText { get; set; }

        public DateTime CreatedAt { get; set; }

        public string title
        {
            get { return Id != 0 ? "Edit Question" : "New Question"; }
        }

        public QuestionFormViewModel()
        {
            Id = 0;
        }

        public QuestionFormViewModel(Question question)
        {
            Id = question.Id;
            Name = question.Name;
            QuestionText = question.QuestionText;
            AnswerOne = question.AnswerOne;
            AnswerTwo = question.AnswerTwo;
            AnswerThree = question.AnswerThree;
            CorrectAnswer = question.CorrectAnswer;
            TagId = question.TagId;
            ExplanationText = question.ExplanationText;
            CreatedAt = question.CreatedAt;
            UserId = question.UserId;
        }
    }
}