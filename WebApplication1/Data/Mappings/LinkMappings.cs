using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Data.Mappings
{
    public class LinkMappings : EntityTypeConfiguration<Link>
    {
        public LinkMappings()
        {
            ToTable("Links").HasKey(l => l.Id);

            Property(p => p.Id).HasColumnName("ID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Name).HasColumnName("Name").HasMaxLength(255).IsRequired();
            Property(p => p.Description).HasMaxLength(255);
            Property(p => p.URL).HasMaxLength(4096);
            Property(p => p.CreatedAt).HasColumnName("CreatedAt");

            HasRequired(p => p.CreatedBy).WithMany(part => part.CreatedLinks);
        }
    }
}