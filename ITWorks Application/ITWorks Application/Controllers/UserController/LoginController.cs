using ITWorks_Application.Controllers.api;
using ITWorks_Application.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITWorks_Application.Controllers
{
    public class LoginController : Controller
    {
        public static AccountData sessionAccount = new AccountData();
        private readonly AccountRepo repo;
        public LoginController()
        {
            repo = new AccountRepo();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult PerformLogin(string UserName, string Password)
        {
            bool isExist = repo.isLoginCredentialExist(UserName, Password);
            if(!isExist)
                return View("Login");
            sessionAccount = repo.GetLoginCredential(UserName, Password);
            return RedirectToAction("Index", "HomePage");
        }
    }
}
