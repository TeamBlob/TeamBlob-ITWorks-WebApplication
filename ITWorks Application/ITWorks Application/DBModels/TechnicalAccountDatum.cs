using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class TechnicalAccountDatum
    {
        [Key]
        [Column("AccountID")]
        public int AccountId { get; set; }
        [Required]
        [StringLength(12)]
        public string AccountName { get; set; }
        [Required]
        [StringLength(12)]
        public string AccountPassword { get; set; }
        [Column("AccountTypeID")]
        public int AccountTypeId { get; set; }
    }
}
