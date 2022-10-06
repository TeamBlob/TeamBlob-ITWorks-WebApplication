using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.Models
{
    public class ForumAnswerModel
    {
        public string AccountName { get; set; }
        public ForumAnswerData forumAnswer { get; set; }
        public List<ForumCommentModel> answerComments { get; set; }
    }
}
