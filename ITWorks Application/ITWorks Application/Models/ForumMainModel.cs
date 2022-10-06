using ITWorks_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.Models
{
    public class ForumQuestionModel
    {
        public ForumQuestionData Question { get; set; }
        public string UserAccount { get; set; }
        public ForumDeviceCategoryData DeviceCategory { get; set; }
        public ForumBrandData Brand { get; set; }
        public ForumIssueData Issue { get; set; }
        public ForumSubIssueData SubIssue { get; set; }
        public ForumQuestionVotesData questionVotes { get; set; }
    }
}
