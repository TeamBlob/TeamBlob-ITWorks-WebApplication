using ITWorks_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.ViewModels
{
    public class BrandCategoryViewModel
    {
        public int FAQDeviceCategoryID { get; set; }
        public List<BrandModel> BrandsModels { get; set; }
        public List<BrandModel> DoYouMeanList { get; set; }
    }
}
