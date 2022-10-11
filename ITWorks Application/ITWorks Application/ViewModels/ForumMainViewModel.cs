using ITWorks_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.ViewModels
{
    public class ForumMainViewModel
    {
        public List<ForumQuestionModel> forumQuestions { get; set; }
        public List<ForumBrandData> forumBrand { get; set; }
        public List<ForumDeviceCategoryData> forumDevice { get; set; }
        public List<ForumIssueData> forumIssues { get; set; }
    }
}
