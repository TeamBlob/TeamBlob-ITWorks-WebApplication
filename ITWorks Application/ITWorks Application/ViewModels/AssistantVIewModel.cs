using ITWorks_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.ViewModels
{
    public class AssistantViewModel
    {
        public List<ForumDeviceCategoryData> deviceCategoryDatas = new List<ForumDeviceCategoryData>();
        public List<ForumBrandData> brandDatas = new List<ForumBrandData>();
        public List<ForumIssueData> issueDatas = new List<ForumIssueData>();
        public List<ForumSubIssueData> subIssueDatas = new List<ForumSubIssueData>();

        public ChatModel chat = new ChatModel();

        public string DeviceExpand { get; set; } = "show";
        public string BrandExpand { get; set; } = "";
        public string IssueExpand { get; set; } = "";
        public string SubExpand { get; set; } = "";
        public string ContentExpand { get; set; } = "";
        public bool DeviceBool { get; set; } = true;
        public bool BrandBool { get; set; } = false;
        public bool IssueBool { get; set; } = false;
        public bool SubBool { get; set; } = false;
        public bool ContentBool { get; set; } = false;

    }
}
