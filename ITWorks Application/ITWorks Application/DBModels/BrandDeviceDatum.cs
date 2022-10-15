using System;
using System.Collections.Generic;

#nullable disable

namespace ITWorks_Application.DBModels
{
    public partial class BrandDeviceDatum
    {
        public int BrandDeviceId { get; set; }
        public int BrandId { get; set; }
        public int FaqdeviceCategoryId { get; set; }
    }
}
