using ITWorks_Application.ViewModels;
using ITWorks_Application.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.Controllers
{
    public class ForumMainController : Controller
    {
        public static ForumMainViewModel forumMainViewModel { get; set; }
        public IActionResult ForumMainIndex()
        {
            if (forumMainViewModel == null)
                forumMainViewModel = new ForumMainViewModel();
            if (forumMainViewModel.forumQuestions == null)
                forumMainViewModel.forumQuestions = new List<ForumQuestionModel>();

            GetAllForum();

            return View(forumMainViewModel);
        }
        [Route("ForumMain/RedirectToQuestion/{QuestionID}")]
        public IActionResult RedirectToQuestion(int QuestionID)
        {
            return RedirectToAction("ForumQuestionIndex", "ForumQuestion", new { QuestionID = QuestionID });
        }

        public void GetAllForum()
        {
            forumMainViewModel.forumQuestions = FakeDataController.list_of_forumQuestions.Select(x => new ForumQuestionModel
            {
                Question = x,
                UserAccount = FakeDataController.list_of_account.FirstOrDefault(y => y.AccountID == x.AccountID).AccountName,
                DeviceCategory = FakeDataController.list_of_forumDeviceCategories.FirstOrDefault(y => y.DeviceCategoryID == x.DeviceCategoryID),
                Brand = FakeDataController.list_of_forumBrands.FirstOrDefault(y => y.ForumBrandID == x.BrandID),
                Issue = FakeDataController.list_of_forumIssues.FirstOrDefault(y => y.IssueID == x.IssueID),
                SubIssue = FakeDataController.list_of_subforumIssues.FirstOrDefault(y => y.SubIssueID == x.SubIssueID),
                questionVotes = FakeDataController.list_of_forumVotes.FirstOrDefault(y => y.QuestionID == x.QuestionID),
            }).ToList();

            forumMainViewModel.forumBrand = FakeDataController.list_of_forumBrands;
            forumMainViewModel.forumDevice = FakeDataController.list_of_forumDeviceCategories;
            forumMainViewModel.forumIssues = FakeDataController.list_of_forumIssues;
        }

        public ActionResult Filter(string filterBrand, string filterDevice, string filterIssue)
        {

            GetAllForum();
            if (filterBrand == "all" && filterDevice == "all" && filterIssue == "all") //No filter
                return View("ForumMainIndex", forumMainViewModel);

            if (!String.IsNullOrEmpty(filterBrand) && filterBrand != "all")
                FilterByBrand(filterBrand);
            if (!String.IsNullOrEmpty(filterDevice) && filterDevice != "all")
                FilterByDevice(filterDevice);
            if (!String.IsNullOrEmpty(filterIssue) && filterIssue != "all")
                FilterByIssue(filterIssue);

            return View("ForumMainIndex", forumMainViewModel);

        }
        public void FilterByBrand(string filterBrand)
        {
            filterBrand = filterBrand.Trim().ToLower();
            forumMainViewModel.forumQuestions = forumMainViewModel.forumQuestions.
                    Where(x => x.Brand.ForumBrandName.ToLower() == filterBrand).ToList();
        }
        public void FilterByDevice(string filterDevice)
        {
            filterDevice = filterDevice.Trim().ToLower();
            forumMainViewModel.forumQuestions = forumMainViewModel.forumQuestions.
                    Where(x => x.DeviceCategory.DeviceCategoryName.ToLower() == filterDevice).ToList();
        }
        public void FilterByIssue(string filterIssue)
        {
            filterIssue = filterIssue.Trim().ToLower();
            forumMainViewModel.forumQuestions = forumMainViewModel.forumQuestions.
                    Where(x => x.DeviceCategory.DeviceCategoryName.ToLower() == filterIssue).ToList();
        }
    }
}
