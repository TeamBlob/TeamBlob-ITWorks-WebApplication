using System;

namespace ITWorks_Application.Models
{
    public class PostQuestionModel
    {
        public int AccountID { get; set; }
        public string DeviceCategory { get; set; }
        public string Brand { get; set; }
        public string Issue { get; set; }
        public string SubIssue { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionContent { get; set; }
        public DateTime UploadDateTIme { get; set; }

    }
}
