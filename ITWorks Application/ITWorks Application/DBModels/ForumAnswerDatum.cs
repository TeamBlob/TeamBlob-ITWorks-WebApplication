using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class ForumAnswerDatum
    {
        [Key]
        [Column("AnswerID")]
        public int AnswerId { get; set; }
        [Column("QuestionID")]
        public int? QuestionId { get; set; }
        [Column("AccountID")]
        public int? AccountId { get; set; }
        [StringLength(200)]
        public string AnswerContent { get; set; }
        [Column("UploadDateTIme", TypeName = "smalldatetime")]
        public DateTime? UploadDateTime { get; set; }
    }
}
