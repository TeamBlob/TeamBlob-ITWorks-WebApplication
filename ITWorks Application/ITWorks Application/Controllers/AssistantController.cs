using ITWorks_Application.Models;
using ITWorks_Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.Controllers
{
    public class AssistantController : Controller
    {
        public static AssistantViewModel postQuestionViewModel;
        [Route("Assistant/AssistantIndex/{deviceid?}/{brandid?}/{issueid?}/{subissueid?}")]
        public IActionResult AssistantIndex(string device, string brand, string issue, string subissue)
        {
            if (postQuestionViewModel == null)
                postQuestionViewModel = new AssistantViewModel();

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
        public IActionResult CreateLink(string MeetingTime, string QuestionTitle, string QuestionContent)
        {
            if (String.IsNullOrEmpty(QuestionContent))
                return View(postQuestionViewModel);
            postQuestionViewModel.chat.QuestionTitle = QuestionTitle;
            postQuestionViewModel.chat.QuestionContent = QuestionContent;
            postQuestionViewModel.chat.MeetingSession = DateTime.Parse(MeetingTime);
            ZoomController.CreateZoomStatic(postQuestionViewModel.chat);
            return View("AssistantIndex", postQuestionViewModel);
        }

        public List<ForumBrandData> GetForumBrands(string device)
        {
            RefreshCache();
            if (!String.IsNullOrEmpty(device))
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

            else if (String.IsNullOrEmpty(postQuestionViewModel.chat.DeviceCategory))
                return null;

            device = postQuestionViewModel.chat.DeviceCategory;

            return FakeDataController.list_of_forumBrands;

        }
        public List<ForumIssueData> GetForumIssue(string brand)
        {
            RefreshCache();
            if (!String.IsNullOrEmpty(brand))
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

            else if (String.IsNullOrEmpty(postQuestionViewModel.chat.Brand))
                return null;

            brand = postQuestionViewModel.chat.DeviceCategory;

            return FakeDataController.list_of_forumIssues;
        }
        public List<ForumSubIssueData> GetSubIssue(string issue)
        {
            RefreshCache();
            if (!String.IsNullOrEmpty(issue))
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

            else if (String.IsNullOrEmpty(postQuestionViewModel.chat.Issue))
                return null;

            issue = postQuestionViewModel.chat.Issue;
            return FakeDataController.list_of_subforumIssues;
        }
        public void GetContent(string subissue)
        {
            if (!String.IsNullOrEmpty(subissue))
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
            if (String.IsNullOrEmpty(device)) return;

            int deviceid = FakeDataController.list_of_forumDeviceCategories.FirstOrDefault(x => x.DeviceCategoryName == device).DeviceCategoryID;
            postQuestionViewModel.chat.DeviceCategory = device;

        }
        public void BrandChoose(string brand)
        {
            if (String.IsNullOrEmpty(brand)) return;

            int brandid = FakeDataController.list_of_forumBrands.FirstOrDefault(x => x.ForumBrandName == brand).ForumBrandID;
            postQuestionViewModel.chat.Brand = brand;
        }
        public void IssueChoose(string issue)
        {
            if (String.IsNullOrEmpty(issue)) return;

            int issueid = FakeDataController.list_of_forumIssues.FirstOrDefault(x => x.IssueName == issue).IssueID;
            postQuestionViewModel.chat.Issue = issue;
        }
        public void SubIssueChoose(string subissue)
        {
            if (String.IsNullOrEmpty(subissue)) return;

            int subissueid = FakeDataController.list_of_subforumIssues.FirstOrDefault(x => x.SubIssueName == subissue).SubIssueID;
            postQuestionViewModel.chat.SubIssue = subissue;
        }
    }
}
