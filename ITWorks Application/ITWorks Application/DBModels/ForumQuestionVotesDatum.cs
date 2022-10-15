using System;
using System.Collections.Generic;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class ForumQuestionVotesDatum
    {
        public int QuestionId { get; set; }
        public int? Votes { get; set; }
    }
}
