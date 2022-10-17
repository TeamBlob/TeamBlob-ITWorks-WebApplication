using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class ForumQuestionVotesDatum
    {
        [Key]
        [Column("QuestionID")]
        public int QuestionId { get; set; }
        public int? Votes { get; set; }
    }
}
