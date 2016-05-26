using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JsonPost.Models
{
    public class Question
    {
        public string Title { get; set; }
        public List<QuestionAnswer> QuestionAnswers { get; set; }
    }
}