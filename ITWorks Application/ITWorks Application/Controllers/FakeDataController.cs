using ITWorks_Application.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.Controllers
{
    public class FakeDataController : Controller
    {
        /************************************* START FAQ FAKE DATA ************************************************/
        public static List<FAQDeviceCategoryData> list_of_FAQ_Category = new List<FAQDeviceCategoryData>()
        {
            new FAQDeviceCategoryData { FAQDeviceCategoryID = 1, FAQDeviceCategoryName = "Mobile", FAQDeviceCategoryImage = "/img/mobile.svg", FAQDeviceCategoryTXTCSS = "mobile-text inter-normal-sonic-silver-24px", FAQDeviceCategoryIMGCSS = "mobile-img"},
            new FAQDeviceCategoryData { FAQDeviceCategoryID = 2, FAQDeviceCategoryName = "Laptop", FAQDeviceCategoryImage = "/img/laptop.svg", FAQDeviceCategoryTXTCSS = "laptop-text inter-normal-sonic-silver-24px", FAQDeviceCategoryIMGCSS = "laptop-img"},
            new FAQDeviceCategoryData { FAQDeviceCategoryID = 3, FAQDeviceCategoryName = "Printer", FAQDeviceCategoryImage = "/img/printer.svg", FAQDeviceCategoryTXTCSS = "printer-text inter-normal-sonic-silver-24px", FAQDeviceCategoryIMGCSS = "printer-img"},
            new FAQDeviceCategoryData { FAQDeviceCategoryID = 4, FAQDeviceCategoryName = "Home Appliances", FAQDeviceCategoryImage = "/img/homeappliance.svg", FAQDeviceCategoryTXTCSS = "home-appliances-text inter-normal-sonic-silver-24px", FAQDeviceCategoryIMGCSS = "homeappliance-img"}
        };
        public static List<BrandModelData> list_of_brands = new List<BrandModelData>()
        {
            new BrandModelData { BrandID = 1, BrandName = "Apple", BrandImage = ""},
            new BrandModelData { BrandID = 1, BrandName = "Samsung", BrandImage = "" },
            new BrandModelData { BrandID = 1, BrandName = "Xiaomi", BrandImage = "" },
            new BrandModelData { BrandID = 1, BrandName = "Huawei", BrandImage = "" },
        };
        public static List<BrandDeviceData> list_of_deviceBrands = new List<BrandDeviceData>()
        {
            new BrandDeviceData { BrandDeviceID = 1, BrandID = 1, FAQDeviceCategoryID = 1 },
            new BrandDeviceData { BrandDeviceID = 2, BrandID = 2, FAQDeviceCategoryID = 1 },
            new BrandDeviceData { BrandDeviceID = 3, BrandID = 3, FAQDeviceCategoryID = 1 },
            new BrandDeviceData { BrandDeviceID = 4, BrandID = 4, FAQDeviceCategoryID = 1 },
        };
        public static List<FixCategoryData> list_of_fixCategory = new List<FixCategoryData>()
        {
            new FixCategoryData { FixCateogryID = 1, FixCategoryName = "Display" },
            new FixCategoryData { FixCateogryID = 2, FixCategoryName = "Battery" },
            new FixCategoryData { FixCateogryID = 3, FixCategoryName = "Password" },
            new FixCategoryData { FixCateogryID = 4, FixCategoryName = "Camera" },
        };
        public static List<BrandDeviceFixCategoryData> list_of_fixdeviceBrands = new List<BrandDeviceFixCategoryData>()
        {
            new BrandDeviceFixCategoryData { FixCateogryID = 1, BrandDeviceID = 1 },
            new BrandDeviceFixCategoryData { FixCateogryID = 2, BrandDeviceID = 1 },
            new BrandDeviceFixCategoryData { FixCateogryID = 3, BrandDeviceID = 1 },
            new BrandDeviceFixCategoryData { FixCateogryID = 4, BrandDeviceID = 1 },
            new BrandDeviceFixCategoryData { FixCateogryID = 1, BrandDeviceID = 2 },
            new BrandDeviceFixCategoryData { FixCateogryID = 2, BrandDeviceID = 2 },
            new BrandDeviceFixCategoryData { FixCateogryID = 3, BrandDeviceID = 2 },
            new BrandDeviceFixCategoryData { FixCateogryID = 4, BrandDeviceID = 2 },
            new BrandDeviceFixCategoryData { FixCateogryID = 1, BrandDeviceID = 3 },
            new BrandDeviceFixCategoryData { FixCateogryID = 2, BrandDeviceID = 3 },
            new BrandDeviceFixCategoryData { FixCateogryID = 3, BrandDeviceID = 3 },
            new BrandDeviceFixCategoryData { FixCateogryID = 4, BrandDeviceID = 3 },
            new BrandDeviceFixCategoryData { FixCateogryID = 1, BrandDeviceID = 4 },
            new BrandDeviceFixCategoryData { FixCateogryID = 2, BrandDeviceID = 4 },
            new BrandDeviceFixCategoryData { FixCateogryID = 3, BrandDeviceID = 4 },
            new BrandDeviceFixCategoryData { FixCateogryID = 4, BrandDeviceID = 4 },
        };
        public static List<FixData> list_of_fixModel = new List<FixData>()
        {
            new FixData{ FixID = 1, FixCateogryID = 1, BrandDeviceID = 1, FixTitle = "Cannot Charge Android Phone", FixDescription = "Cannot Charge Android Phone"},
            new FixData{ FixID = 2, FixCateogryID = 1, BrandDeviceID = 2, FixTitle = "Cannot Charge iPhone", FixDescription = "Cannot Charge iPhone"}
        };
        public static List<InstructionData> list_of_instruction = new List<InstructionData>()
        {
            new InstructionData { InstructionID = 1, InstructionTitle = "Make sure you use the correct cable", InstructionContent = "Android Phone only can be charged using a Micro USB Connector"},
            new InstructionData { InstructionID = 2, InstructionTitle = "Make sure you use the correct cable", InstructionContent = "iPhone only can be charged using a Lighting Cable"},
        };
        public static List<FixInstructionData> list_of_fixInstruction = new List<FixInstructionData>()
        {
            new FixInstructionData { FixID = 1, InstructionID = 1, SolutionStep = 1},
            new FixInstructionData { FixID = 1, InstructionID = 2, SolutionStep = 2 },
            new FixInstructionData { FixID = 2, InstructionID = 1, SolutionStep = 1 },
            new FixInstructionData { FixID = 2, InstructionID = 2, SolutionStep = 2 }
        };
        /************************************** END FAQ FAKE DATA *************************************************/

        public static List<AccountTypeData> list_of_accountTypes = new List<AccountTypeData>()
        {
            new AccountTypeData{ TypeID = 1, TypeName = "Normal User" },
            new AccountTypeData{ TypeID = 2, TypeName = "Normal User" },
        };

        public static List<AccountData> list_of_account = new List<AccountData>()
        {
            new AccountData{ AccountID = 101, AccountName = "Account 1", AccountPassword = "Password", AccountTypeID = 1},
            new AccountData{ AccountID = 102, AccountName = "Account 2", AccountPassword = "TadaaPassword", AccountTypeID = 1},
            new AccountData{ AccountID = 103, AccountName = "Account 3", AccountPassword = "PasswordTadaa", AccountTypeID = 1},
            new AccountData{ AccountID = 104, AccountName = "Account 4", AccountPassword = "TadaaTadaaBANGBANG", AccountTypeID = 1},
            new AccountData{ AccountID = 105, AccountName = "Account 4", AccountPassword = "1234", AccountTypeID = 1},
            new TechnicalAccountData{ AccountID = 1, AccountName = "Tech Account", AccountPassword = "SecretPassword", AccountTypeID = 2},

        };

        public static List<ForumBrandData> list_of_forumBrands = new List<ForumBrandData>()
        {
            new ForumBrandData { ForumBrandID = 0, ForumBrandName = "Others" },
            new ForumBrandData { ForumBrandID = 1, ForumBrandName = "Apple"},
            new ForumBrandData { ForumBrandID = 2, ForumBrandName = "Samsung"},
            new ForumBrandData { ForumBrandID = 3, ForumBrandName = "Xiaomi"},
            new ForumBrandData { ForumBrandID = 4, ForumBrandName = "Huawei"},

        };
        public static List<ForumIssueData> list_of_forumIssues = new List<ForumIssueData>()
        {
            new ForumIssueData { IssueID = 0, IssueName = "Others" },
            new ForumIssueData { IssueID = 1, IssueName = "Display" },
            new ForumIssueData { IssueID = 2, IssueName = "Battery" },
            new ForumIssueData { IssueID = 3, IssueName = "Password" },
            new ForumIssueData { IssueID = 4, IssueName = "Camera" },
            new ForumIssueData { IssueID = 4, IssueName = "Others" },
        };
        public static List<ForumSubIssueData> list_of_subforumIssues = new List<ForumSubIssueData>()
        {
            new ForumSubIssueData { SubIssueID = 0, SubIssueName = "Others" },
            new ForumSubIssueData { SubIssueID = 1, IssueID = 2, SubIssueName = "Unable to Power On" },
            new ForumSubIssueData { SubIssueID = 2, IssueID = 2, SubIssueName = "Cable Issue" },
            new ForumSubIssueData { SubIssueID = 3, IssueID = 1, SubIssueName = "Display will not power on" },
            new ForumSubIssueData { SubIssueID = 4, IssueID = 1, SubIssueName = "Display Crack" },
            new ForumSubIssueData { SubIssueID = 5, IssueID = 3, SubIssueName = "Forget Password" },
        };
        public static List<ForumDeviceCategoryData> list_of_forumDeviceCategories = new List<ForumDeviceCategoryData>()
        {
            new ForumDeviceCategoryData { DeviceCategoryID = 1, DeviceCategoryName = "Mobile" },
            new ForumDeviceCategoryData { DeviceCategoryID = 2, DeviceCategoryName = "Laptop" },
            new ForumDeviceCategoryData { DeviceCategoryID = 3, DeviceCategoryName = "Printer" },
            new ForumDeviceCategoryData { DeviceCategoryID = 4, DeviceCategoryName = "Home Appliances" }

        };
        public static List<ForumQuestionData> list_of_forumQuestions = new List<ForumQuestionData>()
        {
            new ForumQuestionData { QuestionID = 1, AccountID = 101, DeviceCategoryID = 1, BrandID = 2, IssueID = 2, SubIssueID = 1, QuestionTitle = "Cannot Power up my phone", QuestionContent = "Help there is something wrong with powering up my phone" },
            new ForumQuestionData { QuestionID = 2, AccountID = 102, DeviceCategoryID = 1, BrandID = 1, IssueID = 1, SubIssueID = 3, QuestionTitle = "Phone power up but display nothing", QuestionContent = "What should I do if my phone cannot power up?" },
            new ForumQuestionData { QuestionID = 3, AccountID = 102, DeviceCategoryID = 1, BrandID = 3, IssueID = 1, SubIssueID = 4, QuestionTitle = "Where can I find the cheapest screen repair shop?", QuestionContent = "A few days ago, my dog ate my homework. Long story short, Need to find the nearest screen repair shop." },
            new ForumQuestionData { QuestionID = 4, AccountID = 103, DeviceCategoryID = 1, BrandID = 4, IssueID = 3, SubIssueID = 5, QuestionTitle = "Accidentally change my phone password", QuestionContent = "Help forgot my password" },
        };
        public static List<ForumAnswerData> list_of_forumAnswer = new List<ForumAnswerData>()
        {
            new ForumAnswerData { QuestionID = 1, AnswerID = 1, AccountID = 1, AnswerContent = "Try swapping cable? See if that helps?" },
        };
        public static List<ForumCommentData> list_of_forumComment = new List<ForumCommentData>()
        {
            new ForumCommentData { CommentID = 1, AnswerID = 1, AccountID = 1, CommentContent = "Try swapping cable? See if that helps?" },
        };
        public static List<ForumQuestionVotesData> list_of_forumVotes = new List<ForumQuestionVotesData>()
        {
            new ForumQuestionVotesData { QuestionID = 1, Votes = 0 },
            new ForumQuestionVotesData { QuestionID = 2, Votes = 3 },
            new ForumQuestionVotesData { QuestionID = 3, Votes = 4 },
            new ForumQuestionVotesData { QuestionID = 4, Votes = 1 },
        };

    }
}
