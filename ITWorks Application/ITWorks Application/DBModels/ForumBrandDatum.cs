using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class ForumBrandDatum
    {
        [Key]
        [Column("ForumBrandID")]
        public int ForumBrandId { get; set; }
        [StringLength(50)]
        public string ForumBrandName { get; set; }
    }
}
