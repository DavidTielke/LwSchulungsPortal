using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        public new MyPrincipal User
        {
            get { return (MyPrincipal) base.User; }
        }

        public bool IsInRole(string role)
        {
            return User.IsInRole(role);
        }
    }
}