using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.Models
{
    public class ForumAnswerData
    {
        public int AnswerID { get; set; }
        public int QuestionID { get; set; }
        public int AccountID { get; set; }
        public string AnswerContent { get; set; }
        public DateTime UploadDateTIme { get; set; }
    }
}
