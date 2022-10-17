using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class ForumQuestionDatum
    {
        [Key]
        [Column("QuestionID")]
        public int QuestionId { get; set; }
        [Column("AccountID")]
        public int? AccountId { get; set; }
        [Column("DeviceCategoryID")]
        public int? DeviceCategoryId { get; set; }
        [Column("BrandID")]
        public int? BrandId { get; set; }
        [Column("IssueID")]
        public int? IssueId { get; set; }
        [Column("SubIssueID")]
        public int? SubIssueId { get; set; }
        [StringLength(200)]
        public string QuestionTitle { get; set; }
        [StringLength(200)]
        public string QuestionContent { get; set; }
        [Column("UploadDateTIme", TypeName = "datetime")]
        public DateTime? UploadDateTime { get; set; }
    }
}
