using ITWorks_Application.Models;
using ITWorks_Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.Controllers
{
    public class ForumQuestionController : Controller
    {
        public static ForumQuestionViewModel forumQuestionViewModel { get; set; }
        [Route("ForumQuestion/ForumQuestionIndex/{QuestionID}")]
        public IActionResult ForumQuestionIndex(int QuestionID)
        {
            forumQuestionViewModel = new ForumQuestionViewModel();

            ForumQuestionData forumQuestionData = FakeDataController.list_of_forumQuestions.FirstOrDefault(x => x.QuestionID == QuestionID);

            if (forumQuestionData == null)
                return View(forumQuestionViewModel);

            forumQuestionViewModel.forumQuestionModel = new ForumQuestionModel()
            {
                Question = forumQuestionData,
                UserAccount = FakeDataController.list_of_account.FirstOrDefault(x => x.AccountID == forumQuestionData.AccountID).AccountName,
                DeviceCategory = FakeDataController.list_of_forumDeviceCategories.FirstOrDefault(y => y.DeviceCategoryID == forumQuestionData.DeviceCategoryID),
                Brand = FakeDataController.list_of_forumBrands.FirstOrDefault(x => x.ForumBrandID == forumQuestionData.BrandID),
                Issue = FakeDataController.list_of_forumIssues.FirstOrDefault(x => x.IssueID == forumQuestionData.IssueID),
                SubIssue = FakeDataController.list_of_subforumIssues.FirstOrDefault(x => x.SubIssueID == forumQuestionData.SubIssueID),
                questionVotes = FakeDataController.list_of_forumVotes.FirstOrDefault(x => x.QuestionID == forumQuestionData.QuestionID),
            };

            forumQuestionViewModel.questionAnswers = FakeDataController.list_of_forumAnswer.Where( x => x.QuestionID == QuestionID)
                                                        .Select(x => new ForumAnswerModel() 
                                                        { 
                                                            forumAnswer = x,
                                                            AccountName = FakeDataController.list_of_account.FirstOrDefault(y => y.AccountID == x.AccountID).AccountName,
                                                            answerComments = FakeDataController.list_of_forumComment.Where(y => y.AnswerID == x.AnswerID).Select( z => new ForumCommentModel()
                                                            {
                                                                AccountName = FakeDataController.list_of_account.FirstOrDefault(y => y.AccountID == z.AccountID).AccountName,
                                                                CommentContent = z.CommentContent,
                                                                UploadDateTIme = z.UploadDateTIme
                                                            }).ToList()
                                                        }).ToList();

            return View(forumQuestionViewModel);
        }

        public IActionResult PostAnswer(string QuestionID, string AnswerContent)
        {
            return View(forumQuestionViewModel);
        }
        public IActionResult PostComment(string AnswerID, string CommentContent)
        {
            return View(forumQuestionViewModel);
        }
    }
}
