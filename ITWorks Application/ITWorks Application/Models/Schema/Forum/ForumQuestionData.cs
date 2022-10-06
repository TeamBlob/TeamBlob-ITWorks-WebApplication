using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.Models
{
    public class ForumQuestionData
    {
        public int QuestionID { get; set; }
        public int AccountID { get; set; }
        public int DeviceCategoryID { get; set; }
        public int BrandID { get; set; }
        public int IssueID { get; set; }
        public int SubIssueID { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionContent { get; set; }
        public DateTime UploadDateTIme { get; set; }
        
    }
}
