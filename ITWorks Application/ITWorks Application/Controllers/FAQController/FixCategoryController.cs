using ITWorks_Application.Models;
using ITWorks_Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ITWorks_Application.Controllers
{
    public class FixCategoryController : Controller
    {
        public static FixCategoryViewModel fixCategoryViewModel { get; set; }

        [Route("FixCategory/FixCategoryIndex/{BrandDeviceID}")]
        public IActionResult FixCategoryIndex(int BrandDeviceID)
        {
            if(fixCategoryViewModel == null)
                fixCategoryViewModel = new FixCategoryViewModel();
            if(BrandDeviceID > 0)
            {
                if(BrandDeviceID >= 1)
                    fixCategoryViewModel.BrandDeviceID = BrandDeviceID;

                fixCategoryViewModel.brandDeviceFixCategories = FakeDataController.list_of_fixdeviceBrands.Where(x => x.BrandDeviceID == fixCategoryViewModel.BrandDeviceID).ToList();
                fixCategoryViewModel.fixCategoryModels = FakeDataController.list_of_fixCategory.Intersect(FakeDataController.list_of_fixCategory.Where(k => fixCategoryViewModel.brandDeviceFixCategories.Any(x => x.FixCategoryID == k.FixCategoryID))).ToList();
            }

            return View(fixCategoryViewModel);
        }
        public ActionResult SelectCategory(string BrandDeviceID, string FixCategoryID)
        {

            if (fixCategoryViewModel.searchResults == null)
                fixCategoryViewModel.searchResults = new List<FixData>();

            if (fixCategoryViewModel.searchResults != null)
                fixCategoryViewModel.searchResults.Clear();


            fixCategoryViewModel.searchResults.AddRange(FakeDataController.list_of_fixModel.Where(x => x.BrandDeviceID == Convert.ToInt32(BrandDeviceID) && x.FixCategoryID == Convert.ToInt32(FixCategoryID)));

            return View("FixCategoryIndex", fixCategoryViewModel);
        }

        public ActionResult SearchCategory(string search)
        {
            if (string.IsNullOrEmpty(search))
                return View("FixCategoryIndex", fixCategoryViewModel);
            else
            {
                search = search.Trim().ToLower();
                TempData["search"] = search;

                if (fixCategoryViewModel.searchResults == null)
                    fixCategoryViewModel.searchResults = new List<FixData>();

                if (fixCategoryViewModel.searchResults != null)
                    fixCategoryViewModel.searchResults.Clear();

                fixCategoryViewModel.searchResults.AddRange(FakeDataController.list_of_fixModel.Where(x => x.BrandDeviceID == fixCategoryViewModel.BrandDeviceID && (x.FixTitle.ToLower().Contains(search) || x.FixDescription.ToLower().Contains(search))).ToList());

                return View("FixCategoryIndex", fixCategoryViewModel);
            }
        }
    }
}
