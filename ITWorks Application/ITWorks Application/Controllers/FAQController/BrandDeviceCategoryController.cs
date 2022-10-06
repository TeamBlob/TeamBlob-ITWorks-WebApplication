using ITWorks_Application.Models;
using ITWorks_Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ITWorks_Application.Controllers
{
    public class BrandCategoryController : Controller
    {
        public static BrandCategoryViewModel brandCategoryViewModel { get; set; } // Make into a session

        [Route("BrandCategory/BrandCategory/{DeviceID}")]
        public IActionResult BrandCategory(int DeviceID)
        {
            if(brandCategoryViewModel == null)
                brandCategoryViewModel = new BrandCategoryViewModel() { FAQDeviceCategoryID = DeviceID };

            if (brandCategoryViewModel.FAQDeviceCategoryID != DeviceID)
                brandCategoryViewModel.FAQDeviceCategoryID = DeviceID;

            List<BrandDeviceData> list_of_deviceBrands = FakeDataController.list_of_deviceBrands.Where(x => x.FAQDeviceCategoryID == DeviceID).ToList();
            brandCategoryViewModel.BrandsModels = FakeDataController.list_of_brands.Intersect(FakeDataController.list_of_brands.Where(k => list_of_deviceBrands.Any(x => x.BrandID == k.BrandID))).ToList();

            return View(brandCategoryViewModel);
        }

        public ActionResult SearchBrand(string search)
        {
            if (string.IsNullOrEmpty(search))
                return View("BrandCategory", brandCategoryViewModel);
            else
            {
                search = search.Trim().ToLower();
                TempData["search"] = search;

                brandCategoryViewModel.DoYouMeanList = brandCategoryViewModel.BrandsModels.
                    Where(x => x.BrandName.ToLower().Contains(search)).ToList();

                return View("BrandCategory", brandCategoryViewModel);
            }
        }
        [Route("BrandCategory/RedirectToFixCategory/{BrandID}/{FAQDeviceCategoryID}")]
        public ActionResult RedirectToFixCategory(int BrandID, int FAQDeviceCategoryID)
        {
            int BrandDeviceID = FakeDataController.list_of_deviceBrands.FirstOrDefault(x => x.BrandID == BrandID && x.FAQDeviceCategoryID == FAQDeviceCategoryID).BrandDeviceID;

            return RedirectToAction("FixCategoryIndex", "FixCategory", new { BrandDeviceID = BrandDeviceID });
        }
    }
}
