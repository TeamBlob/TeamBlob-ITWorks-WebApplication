using ITWorks_Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ITWorks_Application.Controllers
{
    public class FixCategoryController : Controller
    {
        public static FixCategoryViewModel fixCategoryViewModel { get; set; }

        public FixCategoryController()
        {
            fixCategoryViewModel = new FixCategoryViewModel();
            fixCategoryViewModel.brandDeviceFixCategories = new List<Models.BrandDeviceFixCategory>();
        }

        [Route("FixCategory/FixCategoryIndex/{BrandDeviceID}")]
        public IActionResult FixCategoryIndex(int BrandDeviceID)
        {

            fixCategoryViewModel.brandDeviceFixCategories = FakeDataController.list_of_fixdeviceBrands.Where(x => x.BrandDeviceID == BrandDeviceID).ToList();
            fixCategoryViewModel.fixCategoryModels = FakeDataController.list_of_fixCategory.Union(FakeDataController.list_of_fixCategory.Where(k => !fixCategoryViewModel.brandDeviceFixCategories.Any(x => x.FixCateogryID == k.FixCateogryID))).ToList();


            return View(fixCategoryViewModel);
        }

        public ActionResult SearchCategory(string search)
        {
            if (string.IsNullOrEmpty(search))
                return View("FixCategoryIndex");
            else
            {
                search = search.Trim().ToLower();
                TempData["search"] = search;


                return View("FixCategoryIndex");
            }
        }
    }
}
