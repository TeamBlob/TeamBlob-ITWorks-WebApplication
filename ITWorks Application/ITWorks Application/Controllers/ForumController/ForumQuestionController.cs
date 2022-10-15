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
    public class ForumQuestionController : Controller
    {
        private readonly ForumRepo repo;
        public static ForumQuestionViewModel forumQuestionViewModel { get; set; }
        public ForumQuestionController()
        {
            repo = new ForumRepo();
        }
        [Route("ForumQuestion/ForumQuestionIndex/{QuestionID}")]
        public IActionResult ForumQuestionIndex(int QuestionID)
        {
            forumQuestionViewModel = new ForumQuestionViewModel();

            forumQuestionViewModel.forumQuestionModel = repo.GetForumQuestion(QuestionID);

            if (forumQuestionViewModel.forumQuestionModel == null)
                return View(forumQuestionViewModel);

            forumQuestionViewModel.questionAnswers = FakeDataController.list_of_forumAnswer.Where(x => x.QuestionID == QuestionID)
                                                        .Select(x => new ForumAnswerModel()
                                                        {
                                                            forumAnswer = x,
                                                            AccountName = FakeDataController.list_of_account.FirstOrDefault(y => y.AccountID == x.AccountID).AccountName,
                                                            answerComments = FakeDataController.list_of_forumComment.Where(y => y.AnswerID == x.AnswerID).Select(z => new ForumCommentModel()
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
            return RedirectToAction("ForumQuestionIndex", new { QuestionID = Convert.ToInt32(QuestionID) });
        }
        public IActionResult PostComment(string AnswerID, string CommentContent)
        {
            return RedirectToAction("ForumQuestionIndex", new { QuestionID = forumQuestionViewModel.forumQuestionModel.Question.QuestionID });
        }
    }
}
