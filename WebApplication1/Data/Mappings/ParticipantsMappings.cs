using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Data.Mappings
{
    public class ParticipantsMappings : EntityTypeConfiguration<Participant>
    {
        public ParticipantsMappings()
        {
            HasKey(p => p.Id)
            .ToTable("Participants");

            Property(p => p.Id).HasColumnName("ID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.Firstname).HasMaxLength(255).HasColumnName("Firstname").HasColumnOrder(1);
            //Property(p => p.Password).HasColumnName("Password").IsRequired();
        }
    }
}