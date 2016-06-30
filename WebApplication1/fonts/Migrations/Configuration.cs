using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Data.TpContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "WebApplication1.Data.TpContext";
        }

        protected override void Seed(WebApplication1.Data.TpContext context)
        {
        }
    }
}
