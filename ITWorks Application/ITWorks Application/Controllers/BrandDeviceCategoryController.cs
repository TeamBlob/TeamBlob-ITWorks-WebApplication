using ITWorks_Application.Models;
using ITWorks_Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.Controllers
{
    public class BrandCategoryController : Controller
    {
        BrandCategoryViewModel brandCategoryViewModel { get; set; }

        [Route("BrandCategory/BrandCategory/{DeviceID}")]
        public IActionResult BrandCategory(int DeviceID)
        {
            brandCategoryViewModel = new BrandCategoryViewModel() { FAQDeviceCategoryID = DeviceID };
            List<BrandDeviceModel> list_of_deviceBrands = FakeDataController.list_of_deviceBrands.Where(x => x.FAQDeviceCategoryID == DeviceID).ToList();
            brandCategoryViewModel.BrandsModels = new List<BrandModel>();
            var varModel = (from deviceBrands in list_of_deviceBrands
                                            join brands in FakeDataController.list_of_brands
                                            on deviceBrands.BrandID equals brands.BrandID
                                            select new { brands }).ToList();
            System.Collections.IList list = varModel;
            for (int i = 0; i < list.Count; i++)
            {
                BrandModel brand = (BrandModel)list[i];
                brandCategoryViewModel.BrandsModels.Add(brand);
            }

            return View();
        }
    }
}
