using ITWorks_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.ViewModels
{
    public class PostQuestionViewModel
    {
        public List<ForumDeviceCategoryData> deviceCategoryDatas = new List<ForumDeviceCategoryData>();
        public List<ForumBrandData> brandDatas = new List<ForumBrandData>();
        public List<ForumIssueData> issueDatas = new List<ForumIssueData>();
        public List<ForumSubIssueData> subIssueDatas = new List<ForumSubIssueData>();

        public ForumQuestionData questionModel = new ForumQuestionData();

    }
}
