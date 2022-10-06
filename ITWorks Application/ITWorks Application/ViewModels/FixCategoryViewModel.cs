using ITWorks_Application.Models;
using System.Collections.Generic;

namespace ITWorks_Application.ViewModels
{
    public class FixCategoryViewModel
    {
        public int BrandDeviceID { get; set; }
        public List<BrandDeviceFixCategoryData> brandDeviceFixCategories { get; set; }
        public List<FixCategoryData> fixCategoryModels { get; set; }
        public List<FixData> searchResults { get; set; }
    }
}
