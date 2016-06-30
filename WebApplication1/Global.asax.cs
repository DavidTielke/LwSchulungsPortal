using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        protected void Application_PostAuthenticateRequest(Object sender, EventArgs e)
        {
            var isUserAuthenticated = User != null && User.Identity.IsAuthenticated;
            if (isUserAuthenticated)
            {
                var repo = new Repository<Participant>();
                var user = repo.Query.Single(p => p.Email == User.Identity.Name);
                HttpContext.Current.User = new MyPrincipal(User.Identity.Name)
                {
                    Firstname = user.Firstname,
                    Lastname = user.Lastname,
                    Id = user.Id
                };
            }
        }
    }

    public class MyPrincipal : IPrincipal
    {
        public bool IsInRole(string role)
        {
            return false;
        }

        public IIdentity Identity { get; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Id { get; set; }

        public MyPrincipal(string email)
        {
            Identity = new GenericIdentity(email, "forms");
        }
    }
}
