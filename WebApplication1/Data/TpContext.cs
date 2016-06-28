using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Data.Mappings;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class TpContext : DbContext
    {
        public TpContext()
            : base("name=TpContext")
        {
            Database.SetInitializer(new TpDatabaseInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ParticipantsMappings());
        }

        public DbSet<Participant> Participants { get; set; }
    }

    public class TpDatabaseInitializer : DropCreateDatabaseAlways<TpContext>
    {
        protected override void Seed(TpContext context)
        {
            context.Participants.Add(new Participant(1, "David", "Tielke", "mail@david-tielke.de", "http://www.David-Tielke.de", "www.David-Tielke.de"));
            context.Participants.Add(new Participant(2, "Golo", "Roden", "webmaster@goloroden.de", "http://www.thenativeweb.de", "theNativeWeb"));
            context.Participants.Add(new Participant(3, "Laurin", "Stoll", "l.stoll@yooapps.ch", "http://www.yooapps.ch", "youuapps AG"));
            context.Participants.Add(new Participant(4, "Christian", "Giesswein", "info@giessweinweb.at", "http://www.giessweinweb.at", "Giesswein Apps"));
        }
    }
}