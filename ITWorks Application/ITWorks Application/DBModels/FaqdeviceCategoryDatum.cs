using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ITWorks_Application.DBModels
{
    [Table("FAQDeviceCategoryData")]
    public partial class FaqdeviceCategoryDatum
    {
        [Key]
        [Column("FAQDeviceCategoryID")]
        public int FaqdeviceCategoryId { get; set; }
        [Required]
        [Column("FAQDeviceCategoryName")]
        [StringLength(50)]
        public string FaqdeviceCategoryName { get; set; }
        [Column("FAQDeviceCategoryImage")]
        [StringLength(50)]
        public string FaqdeviceCategoryImage { get; set; }
        [Column("FAQDeviceCategoryTXTCSS")]
        [StringLength(100)]
        public string FaqdeviceCategoryTxtcss { get; set; }
        [Column("FAQDeviceCategoryIMGCSS")]
        [StringLength(100)]
        public string FaqdeviceCategoryImgcss { get; set; }
        [Column("FAQDeviceCategoryIMGALT")]
        [StringLength(100)]
        public string FaqdeviceCategoryImgalt { get; set; }
    }
}
