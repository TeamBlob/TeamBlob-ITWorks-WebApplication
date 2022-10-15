using System;
using System.Collections.Generic;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class ForumQuestionDatum
    {
        public int QuestionId { get; set; }
        public int? AccountId { get; set; }
        public int? DeviceCategoryId { get; set; }
        public int? BrandId { get; set; }
        public int? IssueId { get; set; }
        public int? SubIssueId { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionContent { get; set; }
        public DateTime? UploadDateTime { get; set; }
    }
}
