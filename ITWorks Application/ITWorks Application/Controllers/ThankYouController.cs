using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.Controllers
{
    public class ThankYouController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
