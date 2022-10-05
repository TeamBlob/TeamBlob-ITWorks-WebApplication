using ITWorks_Application.Models;
using System.Collections.Generic;

namespace ITWorks_Application.ViewModels
{
    public class FixCategoryViewModel
    {
        public int BrandDeviceID { get; set; }
        public List<BrandDeviceFixCategory> brandDeviceFixCategories { get; set; }
        public List<FixCategoryModel> fixCategoryModels { get; set; }
        public List<FixModel> searchResults { get; set; }
    }
}
