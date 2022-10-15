using ITWorks_Application.ViewModels;
using ITWorks_Application.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ITWorks_Application.Controllers.api;

namespace ITWorks_Application.Controllers.ForumController
{
    public class ForumMainController : Controller
    {
        private readonly ForumRepo repo;
        public static ForumMainViewModel forumMainViewModel { get; set; }
        public ForumMainController()
        {
            repo = new ForumRepo();
        }
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
            return RedirectToAction("ForumQuestionIndex", "ForumQuestion", new { QuestionID });
        }

        public void GetAllForum()
        {
            forumMainViewModel.forumQuestions = repo.GetAllForumQuestion();

            forumMainViewModel.forumBrand = FakeDataController.list_of_forumBrands;
            forumMainViewModel.forumDevice = FakeDataController.list_of_forumDeviceCategories;
            forumMainViewModel.forumIssues = FakeDataController.list_of_forumIssues;
        }

        public ActionResult Filter(string filterBrand, string filterDevice, string filterIssue)
        {

            GetAllForum();
            if (filterBrand == "all" && filterDevice == "all" && filterIssue == "all") //No filter
                return View("ForumMainIndex", forumMainViewModel);

            if (!string.IsNullOrEmpty(filterBrand) && filterBrand != "all")
                FilterByBrand(filterBrand);
            if (!string.IsNullOrEmpty(filterDevice) && filterDevice != "all")
                FilterByDevice(filterDevice);
            if (!string.IsNullOrEmpty(filterIssue) && filterIssue != "all")
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
