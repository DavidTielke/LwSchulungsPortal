using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Data.Mappings
{
    public class GroupMappings : EntityTypeConfiguration<Group>
    {
        public GroupMappings()
        {
            ToTable("Groups").HasKey(g => g.Id);
            Property(g => g.Id).HasColumnName("ID").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(g => g.Name).HasMaxLength(255).IsRequired();

            HasMany(g => g.Participants).WithMany(p => p.Groups).Map(c =>
            {
                c.MapLeftKey("Fk_GroupId");
                c.MapRightKey("FK_ParticipantId");
            });
        }
    }
}