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


                HttpContext.Current.User = new MyPrincipal(User.Identity.Name, user.Groups.Select(g => g.Name).ToArray())
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
        public string[] Roles { get; set; }

        public bool IsInRole(string role)
        {
            var isInRole = Roles.Contains(role);
            return isInRole;
        }

        public IIdentity Identity { get; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Id { get; set; }

        public MyPrincipal(string email, string[] roles)
        {
            Roles = roles;
            Identity = new GenericIdentity(email, "forms");
        }
    }
}
