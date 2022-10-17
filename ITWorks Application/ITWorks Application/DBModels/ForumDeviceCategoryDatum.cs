using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class ForumDeviceCategoryDatum
    {
        [Key]
        [Column("DeviceCategoryID")]
        public int DeviceCategoryId { get; set; }
        [Required]
        [StringLength(50)]
        public string DeviceCategoryName { get; set; }
    }
}
