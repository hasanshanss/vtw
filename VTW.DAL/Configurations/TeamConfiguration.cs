using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTW.DAL.Entities;

namespace VTW.DAL.Configurations
{

    class TeamConfiguration : BaseEntityConfiguration<Team, int>
    {
        public override void Configure(EntityTypeBuilder<Team> builder)
        {
            base.Configure(builder);

            builder.Property(e => e.TeamName).HasMaxLength(150);

            builder.HasOne(d => d.TeamCategoryNavigation)
              .WithMany(p => p.TeamNavigations)
              .HasForeignKey(d => d.TeamCategoryId)
              .OnDelete(DeleteBehavior.ClientSetNull)
              .HasConstraintName("FK_Teams_TeamCategory");

            builder.ToTable("Teams");
        }
    }
    
}
