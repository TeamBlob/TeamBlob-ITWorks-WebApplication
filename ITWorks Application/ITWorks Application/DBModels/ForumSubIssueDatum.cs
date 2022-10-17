using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class ForumSubIssueDatum
    {
        [Column("IssueID")]
        public int? IssueId { get; set; }
        [Key]
        [Column("SubIssueID")]
        public int SubIssueId { get; set; }
        [Required]
        [StringLength(50)]
        public string SubIssueName { get; set; }
    }
}
