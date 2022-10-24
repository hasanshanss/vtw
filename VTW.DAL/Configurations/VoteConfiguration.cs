using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VTW.DAL.Entities;

namespace VTW.DAL.Configurations
{
    class VoteConfiguration : BaseEntityConfiguration<Vote, long>
    {
        public override void Configure(EntityTypeBuilder<Vote> builder)
        {
            base.Configure(builder);

            builder.HasOne(d => d.Team1Navigation)
                .WithMany(p => p.VoteTeam1Navigations)
                .HasForeignKey(d => d.Team1)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Votes_Team_1");

            builder.HasOne(d => d.Team2Navigation)
                .WithMany(p => p.VoteTeam2Navigations)
                .HasForeignKey(d => d.Team2)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Votes_Team_2");
          
            builder.ToTable("Votes");
        }
    }
}
