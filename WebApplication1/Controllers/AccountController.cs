using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Utils;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly Repository<Participant> _repository;
        private readonly Sha1Hasher _sha1Hasher;

        public AccountController()
        {
            _repository = new Repository<Participant>();
            _sha1Hasher = new Sha1Hasher();
        }

       [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(AccountLoginViewModel viewModel)
        {
            var isValid = ModelState.IsValid;
            if (isValid)
            {
                var isValidUser = Membership.ValidateUser(viewModel.Email, viewModel.Password);
                if (isValidUser)
                {
                    FormsAuthentication.SetAuthCookie(viewModel.Email, viewModel.RememberMe);
                    return RedirectToAction("Index", "Participants");
                }
            }
            return View(viewModel);
        }

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Register(AccountRegisterViewModel viewModel)
        {

            var doPasswordsMatch = viewModel.Participant.Password == viewModel.PasswordRepeat;
            if (!doPasswordsMatch)
            {
                ModelState.AddModelError("PasswordRepeat","Passwörter stimmen nicht überein");
            }

            var isValid = ModelState.IsValid;
            if (isValid)
            {
                var hashedPassword = _sha1Hasher.ComputeHash(viewModel.Participant.Password);

                viewModel.Participant.Password = hashedPassword;

                _repository.Insert(viewModel.Participant);
                return RedirectToAction("Login");
            }
            return View(viewModel);
        }
    }
}