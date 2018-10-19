using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuizCreator.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Member Since")]
        public DateTime? MemberSince { get; set; }   

        
    }
}