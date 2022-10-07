using ITWorks_Application.Models;
using ITWorks_Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.Controllers
{
    public class PostQuestionController : Controller
    {
        public static PostQuestionViewModel postQuestionViewModel;
        [Route("PostQuestion/PostQuestionIndex/{deviceid?}/{brandid?}/{issueid?}/{subissueid?}")]

        public IActionResult PostQuestionIndex(string deviceid, string brandid, string issueid, string subissueid)
        {
            if(postQuestionViewModel  == null)
                postQuestionViewModel = new PostQuestionViewModel();

            postQuestionViewModel.deviceCategoryDatas = FakeDataController.list_of_forumDeviceCategories;

            if (!String.IsNullOrEmpty(deviceid))
                postQuestionViewModel.brandDatas = GetForumBrands(Convert.ToInt32(deviceid));

            if (!String.IsNullOrEmpty(brandid))
                postQuestionViewModel.issueDatas = GetForumIssue(Convert.ToInt32(brandid));

            if (!String.IsNullOrEmpty(issueid))
                postQuestionViewModel.subIssueDatas = GetSubIssue(Convert.ToInt32(issueid));

            return View(postQuestionViewModel);
        }

        public IActionResult PostQuestion()
        {
            return View(postQuestionViewModel);
        }


        public List<ForumBrandData> GetForumBrands(int deviceid)
        {
            return FakeDataController.list_of_forumBrands;
        }
        public List<ForumIssueData> GetForumIssue(int brandid)
        {
            return FakeDataController.list_of_forumIssues;
        }
        public List<ForumSubIssueData> GetSubIssue(int issueid)
        {
            return FakeDataController.list_of_subforumIssues;
        }
    }
}
