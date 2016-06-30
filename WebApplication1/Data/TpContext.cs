using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Data.Mappings;
using WebApplication1.Migrations;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class TpContext : DbContext
    {
        public TpContext()
            : base("name=TpContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<TpContext, Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ParticipantsMappings());
            modelBuilder.Configurations.Add(new LinkMappings());
        }

        public DbSet<Participant> Participants { get; set; }
        public DbSet<Link> Links { get; set; }
    }
}