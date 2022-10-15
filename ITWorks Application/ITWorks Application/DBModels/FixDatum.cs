using System;
using System.Collections.Generic;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class FixDatum
    {
        public int FixId { get; set; }
        public int? FixCateogryId { get; set; }
        public int? BrandDeviceId { get; set; }
        public string FixTitle { get; set; }
        public string FixDescription { get; set; }
    }
}
