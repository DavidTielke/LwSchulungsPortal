using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Logon
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(AccountLoginViewModel viewModel)
        {
            var isValid = ModelState.IsValid;
            if (isValid)
            {
                
            }
            return View(viewModel);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(AccountRegisterViewModel viewModel)
        {
            var isValid = ModelState.IsValid;
            if (isValid)
            {
                
            }
            return View(viewModel);
        }
    }
}