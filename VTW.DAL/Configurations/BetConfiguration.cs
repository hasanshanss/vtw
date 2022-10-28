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
    class BetConfiguration : BaseEntityConfiguration<Bet, long>
    {
        public override void Configure(EntityTypeBuilder<Bet> builder)
        {
            base.Configure(builder);

            builder.HasOne(d => d.VoteTeamInfoNavigation)
              .WithMany(p => p.BetNavigations)
              .HasForeignKey(d=>d.VoteTeamInfoId)
              .OnDelete(DeleteBehavior.ClientSetNull)
              .HasConstraintName("FK_Bets_VoteTeamInfo");

            builder.HasOne(d => d.VoterNavigation)
              .WithMany(p => p.BetNavigations)
              .HasForeignKey(d => d.VoterId)
              .OnDelete(DeleteBehavior.ClientSetNull)
              .HasConstraintName("FK_Bets_Voter");

            builder.ToTable("Bets");
        }
    }

}
