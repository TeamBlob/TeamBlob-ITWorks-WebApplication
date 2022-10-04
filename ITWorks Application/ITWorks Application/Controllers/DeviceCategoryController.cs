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
        public IActionResult DeviceCategory()
        {
            return View();
        }
    }
}
