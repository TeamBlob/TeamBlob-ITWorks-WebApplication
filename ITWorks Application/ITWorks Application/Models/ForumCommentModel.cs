using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.Models
{
    public class ForumCommentModel
    {
        public string AccountName { get; set; }
        public string CommentContent { get; set; }
        public DateTime UploadDateTIme { get; set; }
    }
}
