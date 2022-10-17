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

            forumQuestionViewModel.questionAnswers = repo.GetForumQuestionAnswer(QuestionID);

            return View(forumQuestionViewModel);
        }

        public IActionResult PostAnswer(string QuestionID, string AnswerContent)
        {
            ForumAnswerData data = new ForumAnswerData()
            {
                AccountID = LoginController.sessionAccount.AccountID,
                QuestionID = Convert.ToInt32(QuestionID),
                AnswerContent = AnswerContent,
                UploadDateTIme = DateTime.Now
            };
            repo.PostAnswer(data);
            return RedirectToAction("ForumQuestionIndex", new { QuestionID = Convert.ToInt32(QuestionID) });
        }
        public IActionResult PostComment(string AnswerID, string CommentContent)
        {
            ForumCommentData data = new ForumCommentData()
            {
                AccountID = LoginController.sessionAccount.AccountID,
                AnswerID = Convert.ToInt32(AnswerID),
                CommentContent = CommentContent,
                UploadDateTIme = DateTime.Now,
            };
            repo.PostComment(data);

            return RedirectToAction("ForumQuestionIndex", new { QuestionID = forumQuestionViewModel.forumQuestionModel.Question.QuestionID });
        }
    }
}
