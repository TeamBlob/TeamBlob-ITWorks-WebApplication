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

            return View(forumMainViewModel);
        }
        [Route("ForumMain/RedirectToQuestion/{QuestionID}")]
        public IActionResult RedirectToQuestion(int QuestionID)
        {
            return RedirectToAction("ForumQuestionIndex", "ForumQuestion", new { QuestionID = QuestionID });
        }
    }
}
