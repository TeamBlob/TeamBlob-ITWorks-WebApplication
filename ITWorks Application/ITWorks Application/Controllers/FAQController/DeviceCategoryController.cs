using ITWorks_Application.Controllers.api;
using ITWorks_Application.Models;
using ITWorks_Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ITWorks_Application.Controllers
{
    public class DeviceCategoryController : Controller
    {
        private readonly FAQRepo repo;
        public DeviceCategoryController()
        {
            repo = new FAQRepo();
        }
        public IActionResult DeviceCategory()
        {
            FAQDeviceCategoryViewModel viewModel = new FAQDeviceCategoryViewModel()
            {
                DeviceCategoryModels = repo.GetAllFAQDeviceCategory()
            };
            return View(viewModel);
        }
    }
}
