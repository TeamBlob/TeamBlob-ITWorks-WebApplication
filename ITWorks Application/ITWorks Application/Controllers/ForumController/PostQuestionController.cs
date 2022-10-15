using ITWorks_Application.Controllers.api;
using ITWorks_Application.DBModels;
using ITWorks_Application.Models;
using ITWorks_Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.Controllers.ForumController
{
    public class PostQuestionController : Controller
    {
        private readonly ForumRepo repo;
        public static PostQuestionViewModel postQuestionViewModel;

        public PostQuestionController()
        {
            repo = new ForumRepo();
        }

        [Route("PostQuestion/PostQuestionIndex/{deviceid?}/{brandid?}/{issueid?}/{subissueid?}")]
        public IActionResult PostQuestionIndex(string device, string brand, string issue, string subissue)
        {
            if (postQuestionViewModel == null)
                postQuestionViewModel = new PostQuestionViewModel();

            postQuestionViewModel.deviceCategoryDatas = FakeDataController.list_of_forumDeviceCategories;


            postQuestionViewModel.brandDatas = GetForumBrands(device);
            postQuestionViewModel.issueDatas = GetForumIssue(brand);
            postQuestionViewModel.subIssueDatas = GetSubIssue(issue);
            GetContent(subissue);


            DeviceChoose(device);
            BrandChoose(brand);
            IssueChoose(issue);
            SubIssueChoose(subissue);
            return View(postQuestionViewModel);
        }

        public IActionResult SubmitQuestion(string QuestionTitle, string QuestionContent)
        {
            if (string.IsNullOrEmpty(QuestionContent))
                return View(postQuestionViewModel);
            postQuestionViewModel.questionModel.AccountID = 1;
            postQuestionViewModel.questionModel.QuestionTitle = QuestionTitle;
            postQuestionViewModel.questionModel.QuestionContent = QuestionContent;

            ForumQuestionDatum datum = repo.PostNewQuestion(postQuestionViewModel.questionModel);
            int questionid = repo.GetForumQuestionID(datum);
            repo.PostNewQuestionVotes(questionid);
            return RedirectToAction("ForumQuestionIndex", "ForumQuestion", new { QuestionID = questionid });
        }

        public List<ForumBrandData> GetForumBrands(string device)
        {
            RefreshCache();
            if (!string.IsNullOrEmpty(device))
            {
                postQuestionViewModel.DeviceExpand = "";
                postQuestionViewModel.BrandExpand = "show";
                postQuestionViewModel.IssueExpand = "";
                postQuestionViewModel.SubExpand = "";
                postQuestionViewModel.ContentExpand = "";

                postQuestionViewModel.DeviceBool = false;
                postQuestionViewModel.BrandBool = true;
                postQuestionViewModel.IssueBool = false;
                postQuestionViewModel.SubBool = false;
                postQuestionViewModel.ContentBool = false;

                return FakeDataController.list_of_forumBrands;
            }

            else if (string.IsNullOrEmpty(postQuestionViewModel.questionModel.DeviceCategory))
                return null;

            device = postQuestionViewModel.questionModel.DeviceCategory;

            return FakeDataController.list_of_forumBrands;

        }
        public List<ForumIssueData> GetForumIssue(string brand)
        {
            RefreshCache();
            if (!string.IsNullOrEmpty(brand))
            {
                postQuestionViewModel.DeviceExpand = "";
                postQuestionViewModel.BrandExpand = "";
                postQuestionViewModel.IssueExpand = "show";
                postQuestionViewModel.SubExpand = "";
                postQuestionViewModel.ContentExpand = "";

                postQuestionViewModel.DeviceBool = false;
                postQuestionViewModel.BrandBool = false;
                postQuestionViewModel.IssueBool = true;
                postQuestionViewModel.SubBool = false;
                postQuestionViewModel.ContentBool = false;

                return FakeDataController.list_of_forumIssues;
            }

            else if (string.IsNullOrEmpty(postQuestionViewModel.questionModel.Brand))
                return null;

            brand = postQuestionViewModel.questionModel.DeviceCategory;

            return FakeDataController.list_of_forumIssues;
        }
        public List<ForumSubIssueData> GetSubIssue(string issue)
        {
            RefreshCache();
            if (!string.IsNullOrEmpty(issue))
            {
                postQuestionViewModel.DeviceExpand = "";
                postQuestionViewModel.BrandExpand = "";
                postQuestionViewModel.IssueExpand = "";
                postQuestionViewModel.SubExpand = "show";
                postQuestionViewModel.ContentExpand = "";

                postQuestionViewModel.DeviceBool = false;
                postQuestionViewModel.BrandBool = false;
                postQuestionViewModel.IssueBool = false;
                postQuestionViewModel.SubBool = true;
                postQuestionViewModel.ContentBool = false;

                return FakeDataController.list_of_subforumIssues;
            }

            else if (string.IsNullOrEmpty(postQuestionViewModel.questionModel.Issue))
                return null;

            issue = postQuestionViewModel.questionModel.Issue;
            return FakeDataController.list_of_subforumIssues;
        }
        public void GetContent(string subissue)
        {
            if (!string.IsNullOrEmpty(subissue))
            {
                postQuestionViewModel.DeviceExpand = "";
                postQuestionViewModel.BrandExpand = "";
                postQuestionViewModel.IssueExpand = "";
                postQuestionViewModel.SubExpand = "";
                postQuestionViewModel.ContentExpand = "show";

                postQuestionViewModel.DeviceBool = false;
                postQuestionViewModel.BrandBool = false;
                postQuestionViewModel.IssueBool = false;
                postQuestionViewModel.SubBool = false;
                postQuestionViewModel.ContentBool = true;

                return;
            }
        }
        public void RefreshCache()
        {
            TempData["Device"] = TempData["Device"];
            TempData["Brand"] = TempData["Brand"];
            TempData["Issue"] = TempData["Issue"];
        }
        public void DeviceChoose(string device)
        {
            if (string.IsNullOrEmpty(device)) return;

            int deviceid = FakeDataController.list_of_forumDeviceCategories.FirstOrDefault(x => x.DeviceCategoryName == device).DeviceCategoryID;
            postQuestionViewModel.questionModel.DeviceCategory = device;

        }
        public void BrandChoose(string brand)
        {
            if (string.IsNullOrEmpty(brand)) return;

            int brandid = FakeDataController.list_of_forumBrands.FirstOrDefault(x => x.ForumBrandName == brand).ForumBrandID;
            postQuestionViewModel.questionModel.Brand = brand;
        }
        public void IssueChoose(string issue)
        {
            if (string.IsNullOrEmpty(issue)) return;

            int issueid = FakeDataController.list_of_forumIssues.FirstOrDefault(x => x.IssueName == issue).IssueID;
            postQuestionViewModel.questionModel.Issue = issue;
        }
        public void SubIssueChoose(string subissue)
        {
            if (string.IsNullOrEmpty(subissue)) return;

            int subissueid = FakeDataController.list_of_subforumIssues.FirstOrDefault(x => x.SubIssueName == subissue).SubIssueID;
            postQuestionViewModel.questionModel.SubIssue = subissue;
        }


    }
}
