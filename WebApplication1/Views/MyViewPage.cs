using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Views
{
    public abstract class MyViewPage : WebViewPage
    {
        public new MyPrincipal User
        {
            get { return (MyPrincipal)base.User; }
        }

        public bool IsInRole(string role)
        {
            return User.IsInRole(role);
        }
    }
    public abstract class MyViewPage<T> : WebViewPage<T>
    {
        public new MyPrincipal User
        {
            get { return (MyPrincipal)base.User; }
        }

        public bool IsInRole(string role)
        {
            return User.IsInRole(role);
        }
    }
}