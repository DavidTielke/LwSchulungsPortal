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
            context.Participants.AddOrUpdate(new Participant("David", "Tielke", "mail@david-tielke.de", "http://www.David-Tielke.de", "www.David-Tielke.de"));
            context.Participants.AddOrUpdate(new Participant("Golo", "Roden", "webmaster@goloroden.de", "http://www.thenativeweb.de", "theNativeWeb"));
            context.Participants.AddOrUpdate(new Participant("Laurin", "Stoll", "l.stoll@yooapps.ch", "http://www.yooapps.ch", "youuapps AG"));
            context.Participants.AddOrUpdate(new Participant("Christian", "Giesswein", "info@giessweinweb.at", "http://www.giessweinweb.at", "Giesswein Apps"));
        }
    }
}
