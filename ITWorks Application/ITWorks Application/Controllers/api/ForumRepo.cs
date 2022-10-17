using ITWorks_Application.Data;
using ITWorks_Application.DBModels;
using ITWorks_Application.Models;
using ITWorks_Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace ITWorks_Application.Controllers.api
{

    public class ForumRepo
    {
        private readonly itworkxdevdatabaseContext _context = new itworkxdevdatabaseContext();
        private readonly AccountRepo accountRepo;
        public ForumRepo()
        {
            accountRepo = new AccountRepo();
        }
        public List<ForumQuestionModel> GetAllForumQuestion()
        {
            List<ForumQuestionModel> models = new List<ForumQuestionModel>();

            models = _context.ForumQuestionData.Select(x => new ForumQuestionModel
            {
                // For Each Question Data in DB 
                // 1) Grab Question Data
                Question = new ForumQuestionData()
                {
                    QuestionID = x.QuestionId,
                    AccountID = Convert.ToInt32(x.AccountId),
                    BrandID = Convert.ToInt32(x.BrandId),
                    DeviceCategoryID = Convert.ToInt32(x.DeviceCategoryId),
                    IssueID = Convert.ToInt32(x.IssueId),
                    SubIssueID = Convert.ToInt32(x.SubIssueId),
                    QuestionTitle = x.QuestionTitle,
                    QuestionContent = x.QuestionContent,
                    UploadDateTIme = DateTime.Parse(x.UploadDateTime.ToString())
                },

                UserAccount = _context.AccountData.FirstOrDefault(y => y.AccountId == x.AccountId).AccountName,
                DeviceCategory = new ForumDeviceCategoryData()
                {
                    DeviceCategoryID = Convert.ToInt32(x.DeviceCategoryId),
                    DeviceCategoryName = _context.ForumDeviceCategoryData.FirstOrDefault(y => y.DeviceCategoryId == x.DeviceCategoryId).DeviceCategoryName
                },
                Brand = new ForumBrandData()
                {
                    ForumBrandID = Convert.ToInt32(x.BrandId),
                    ForumBrandName = _context.ForumBrandData.FirstOrDefault(y => y.ForumBrandId == x.BrandId).ForumBrandName
                },
                Issue = new ForumIssueData()
                {
                    IssueID = Convert.ToInt32(x.IssueId),
                    IssueName = _context.ForumIssueData.FirstOrDefault(y => y.IssueId == x.IssueId).IssueName
                },
                SubIssue = new ForumSubIssueData()
                {
                    SubIssueID = Convert.ToInt32(x.SubIssueId),
                    SubIssueName = _context.ForumSubIssueData.FirstOrDefault(y => y.SubIssueId == x.SubIssueId).SubIssueName
                },
                questionVotes = new ForumQuestionVotesData()
                {
                    QuestionID = Convert.ToInt32(x.QuestionId),
                    Votes = Convert.ToInt32(_context.ForumQuestionVotesData.FirstOrDefault(y => y.QuestionId == x.QuestionId).Votes)
                },
            }).ToList();
            return models;
        }
        public ForumQuestionModel GetForumQuestion(int QuestionID)
        {
            ForumQuestionDatum datum = _context.ForumQuestionData.FirstOrDefault(x => x.QuestionId == QuestionID);

            ForumQuestionModel model = new ForumQuestionModel()
            {
                Question = new ForumQuestionData()
                {
                    QuestionID = datum.QuestionId,
                    AccountID = Convert.ToInt32(datum.AccountId),
                    BrandID = Convert.ToInt32(datum.BrandId),
                    DeviceCategoryID = Convert.ToInt32(datum.DeviceCategoryId),
                    IssueID = Convert.ToInt32(datum.IssueId),
                    SubIssueID = Convert.ToInt32(datum.SubIssueId),
                    QuestionTitle = datum.QuestionTitle,
                    QuestionContent = datum.QuestionContent,
                    UploadDateTIme = DateTime.Parse(datum.UploadDateTime.ToString())
                },
                UserAccount = _context.AccountData.FirstOrDefault(y => y.AccountId == datum.AccountId).AccountName,
                DeviceCategory = new ForumDeviceCategoryData()
                {
                    DeviceCategoryID = Convert.ToInt32(datum.DeviceCategoryId),
                    DeviceCategoryName = _context.ForumDeviceCategoryData.FirstOrDefault(y => y.DeviceCategoryId == datum.DeviceCategoryId).DeviceCategoryName
                },
                Brand = new ForumBrandData()
                {
                    ForumBrandID = Convert.ToInt32(datum.BrandId),
                    ForumBrandName = _context.ForumBrandData.FirstOrDefault(y => y.ForumBrandId == datum.BrandId).ForumBrandName
                },
                Issue = new ForumIssueData()
                {
                    IssueID = Convert.ToInt32(datum.IssueId),
                    IssueName = _context.ForumIssueData.FirstOrDefault(y => y.IssueId == datum.IssueId).IssueName
                },
                SubIssue = new ForumSubIssueData()
                {
                    SubIssueID = Convert.ToInt32(datum.SubIssueId),
                    SubIssueName = _context.ForumSubIssueData.FirstOrDefault(y => y.SubIssueId == datum.SubIssueId).SubIssueName
                },
                questionVotes = new ForumQuestionVotesData()
                {
                    QuestionID = Convert.ToInt32(datum.QuestionId),
                    Votes = Convert.ToInt32(_context.ForumQuestionVotesData.FirstOrDefault(y => y.QuestionId == datum.QuestionId).Votes)
                },
            };

            return model;
        }
        public int GetForumQuestionID(ForumQuestionDatum datum)
        {
            int questionID;

            ForumQuestionDatum temp = _context.ForumQuestionData.FirstOrDefault(
                x => x.DeviceCategoryId == datum.DeviceCategoryId &&
                     x.BrandId == datum.BrandId &&
                     x.IssueId == datum.IssueId &&
                     x.SubIssueId == datum.SubIssueId &&
                     x.QuestionTitle == datum.QuestionTitle &&
                     x.QuestionContent == datum.QuestionContent);

            if (temp == null)
                return -1;
            questionID = temp.QuestionId;
            return questionID;


        }
        public ForumQuestionDatum PostNewQuestion(PostQuestionModel model)
        {
            var newQuestion = new ForumQuestionDatum()
            {
                AccountId = model.AccountID,
                DeviceCategoryId = Convert.ToInt32(_context.ForumDeviceCategoryData.FirstOrDefault(x => x.DeviceCategoryName == model.DeviceCategory).DeviceCategoryId),
                BrandId = Convert.ToInt32(_context.ForumBrandData.FirstOrDefault(x => x.ForumBrandName == model.Brand).ForumBrandId),
                IssueId = Convert.ToInt32(_context.ForumIssueData.FirstOrDefault(x => x.IssueName == model.Issue).IssueId),
                SubIssueId = Convert.ToInt32(_context.ForumSubIssueData.FirstOrDefault(x => x.SubIssueName == model.SubIssue).SubIssueId),
                QuestionTitle = model.QuestionTitle,
                QuestionContent = model.QuestionContent,
                UploadDateTime = DateTime.Now
            };

            

            _context.ForumQuestionData.Add(newQuestion);
            _context.SaveChanges();
            return newQuestion;
        }
        public void PostNewQuestionVotes(int questionID)
        {
            ForumQuestionVotesDatum newQuestionVotes = new ForumQuestionVotesDatum()
            {
                QuestionId = questionID,
                Votes = 0
            };
            _context.ForumQuestionVotesData.Add(newQuestionVotes);
            _context.SaveChanges();
            
        }
        public void PostAnswer(ForumAnswerData data)
        {
            var newAnswer = new ForumAnswerDatum()
            {
                AccountId = data.AccountID,
                QuestionId = data.QuestionID,
                AnswerContent = data.AnswerContent,
                UploadDateTime = DateTime.Now,
            };
            _context.ForumAnswerData.Add(newAnswer);
            _context.SaveChanges();
        }
        public void PostComment(ForumCommentData data)
        {
            var newComment = new ForumCommentDatum()
            {
                AccountId = data.AccountID,
                AnswerId = data.AnswerID,
                CommentContent = data.CommentContent,
                UploadDateTime = DateTime.Now,
            };
            _context.ForumCommentData.Add(newComment);
            _context.SaveChanges();
        }
        public List<ForumAnswerModel> GetForumQuestionAnswer(int QuestionID)
        {
            List<ForumAnswerModel> model = _context.ForumAnswerData.Where(x => x.QuestionId == QuestionID)
                .Select(x => new ForumAnswerModel
                {
                    forumAnswer = new ForumAnswerData()
                    {
                        AnswerID = x.AnswerId,
                        QuestionID = Convert.ToInt32(x.QuestionId),
                        AccountID = Convert.ToInt32(x.AccountId),
                        AnswerContent = x.AnswerContent,
                        UploadDateTIme = (DateTime)x.UploadDateTime
                    },
                    answerComments = GetForumAnswerComments(QuestionID)
                }).ToList();



            return model;
        }
        public List<ForumCommentModel> GetForumAnswerComments(int AnswerID)
        {
            List<ForumCommentModel> datas = _context.ForumCommentData.Where(x => x.AnswerId == AnswerID).Select(
                y => new ForumCommentModel()
                {
                    AccountName = accountRepo.GetAccountName(Convert.ToInt32(y.AccountId)),
                    CommentContent = y.CommentContent,
                    UploadDateTIme = (DateTime)y.UploadDateTime
                }).ToList();

            return datas;
        }
    }
}
