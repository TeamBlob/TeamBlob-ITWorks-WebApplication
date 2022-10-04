using ITWorks_Application.Models;
using ITWorks_Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ITWorks_Application.Controllers
{
    public class FAQDeviceCategoryController : Controller
    {

        public IActionResult FAQDeviceCategory()
        {
            FAQDeviceCategoryViewModel viewModel = new FAQDeviceCategoryViewModel
            {
                DeviceCategoryModels = FakeDataController.list_of_FAQ_Category
            };

            return View(viewModel);
        }
    }
}
