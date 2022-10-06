using ITWorks_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.ViewModels
{
    public class ForumQuestionViewModel
    {
        public ForumQuestionModel forumQuestionModel { get; set; }
        public List<ForumAnswerModel> questionAnswers { get; set; }
        public ForumAnswerModel UserAnswers { get; set; }
    }
}
