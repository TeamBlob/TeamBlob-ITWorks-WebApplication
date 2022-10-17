using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class BrandModelDatum
    {
        [Key]
        [Column("BrandID")]
        public int BrandId { get; set; }
        [Required]
        [StringLength(50)]
        public string BrandName { get; set; }
        [StringLength(50)]
        public string BrandImage { get; set; }
    }
}
