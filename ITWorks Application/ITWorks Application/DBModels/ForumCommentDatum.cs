using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class ForumCommentDatum
    {
        [Key]
        [Column("CommentID")]
        public int CommentId { get; set; }
        [Column("AccountID")]
        public int? AccountId { get; set; }
        [Column("AnswerID")]
        public int? AnswerId { get; set; }
        [StringLength(200)]
        public string CommentContent { get; set; }
        [Column("UploadDateTIme", TypeName = "smalldatetime")]
        public DateTime? UploadDateTime { get; set; }
    }
}
