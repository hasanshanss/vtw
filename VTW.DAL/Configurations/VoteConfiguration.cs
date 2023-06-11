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
    class VoteConfiguration : BaseEntityConfiguration<Vote, long>
    {
        public override void Configure(EntityTypeBuilder<Vote> builder)
        {
            base.Configure(builder);

            builder.HasOne(d => d.GameTeamInfoNavigation)
              .WithMany(p => p.VoteNavigations)
              .HasForeignKey(d=>d.GameTeamInfoId)
              .OnDelete(DeleteBehavior.ClientSetNull)
              .HasConstraintName("FK_Votes_GameTeamInfo");

            builder.HasOne(d => d.VoterNavigation)
              .WithMany(p => p.VoteNavigations)
              .HasForeignKey(d => d.VoterId)
              .OnDelete(DeleteBehavior.ClientSetNull)
              .HasConstraintName("FK_Votes_Voter");

            builder.Property(m => m.VoteAmount)
                .HasPrecision(12);

            builder.Property(m => m.VotedDate)
                .HasDefaultValueSql("(getdate())");

            builder.ToTable("Votes");
        }
    }

}
