using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.Models
{
    public class ForumCommentData
    {
        public int CommentID { get; set; }
        public int AccountID { get; set; }
        public int AnswerID { get; set; }
        public string CommentContent { get; set; }
        public DateTime UploadDateTIme { get; set; }
    }
}
