using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class FixDatum
    {
        [Key]
        [Column("FixID")]
        public int FixId { get; set; }
        [Column("FixCateogryID")]
        public int? FixCateogryId { get; set; }
        [Column("BrandDeviceID")]
        public int? BrandDeviceId { get; set; }
        [StringLength(50)]
        public string FixTitle { get; set; }
        [StringLength(50)]
        public string FixDescription { get; set; }
    }
}
