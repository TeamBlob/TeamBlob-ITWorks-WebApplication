using System;
using System.Collections.Generic;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class ForumSubIssueDatum
    {
        public int? IssueId { get; set; }
        public int SubIssueId { get; set; }
        public string SubIssueName { get; set; }
    }
}
