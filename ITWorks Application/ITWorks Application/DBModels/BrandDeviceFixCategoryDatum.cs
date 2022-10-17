using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ITWorks_Application.DBModels
{
    [Keyless]
    public partial class BrandDeviceFixCategoryDatum
    {
        [Column("FixCateogryID")]
        public int? FixCateogryId { get; set; }
        [Column("BrandDeviceID")]
        public int? BrandDeviceId { get; set; }
    }
}
