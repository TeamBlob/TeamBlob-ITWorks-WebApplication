using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class ForumIssueDatum
    {
        [Key]
        [Column("IssueID")]
        public int IssueId { get; set; }
        [StringLength(50)]
        public string IssueName { get; set; }
    }
}
