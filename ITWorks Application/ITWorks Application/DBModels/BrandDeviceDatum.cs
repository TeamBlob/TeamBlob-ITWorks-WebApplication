using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class BrandDeviceDatum
    {
        [Key]
        [Column("BrandDeviceID")]
        public int BrandDeviceId { get; set; }
        [Column("BrandID")]
        public int BrandId { get; set; }
        [Column("FAQDeviceCategoryID")]
        public int FaqdeviceCategoryId { get; set; }
    }
}
