using System;
using System.Collections.Generic;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class ForumAnswerDatum
    {
        public int AnswerId { get; set; }
        public int? QuestionId { get; set; }
        public int? AccountId { get; set; }
        public string AnswerContent { get; set; }
        public DateTime? UploadDateTime { get; set; }
    }
}
