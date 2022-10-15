using System;
using System.Collections.Generic;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class ForumCommentDatum
    {
        public int CommentId { get; set; }
        public int? AccountId { get; set; }
        public int? AnswerId { get; set; }
        public string CommentContent { get; set; }
        public DateTime? UploadDateTime { get; set; }
    }
}
