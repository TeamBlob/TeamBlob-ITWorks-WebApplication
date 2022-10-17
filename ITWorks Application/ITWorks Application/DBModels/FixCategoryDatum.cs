using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class FixCategoryDatum
    {
        [Key]
        [Column("FixCateogryID")]
        public int FixCateogryId { get; set; }
        [StringLength(50)]
        public string FixCategoryName { get; set; }
    }
}
