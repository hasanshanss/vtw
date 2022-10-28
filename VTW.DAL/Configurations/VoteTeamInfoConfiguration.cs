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
    class VoteTeamInfoConfiguration : BaseEntityConfiguration<VoteTeamInfo, long>
    {
        public override void Configure(EntityTypeBuilder<VoteTeamInfo> builder)
        {
            base.Configure(builder);

            builder.HasOne(d => d.VoteNavigation)
             .WithMany(p => p.VoteTeamInfoNavigations)
             .HasForeignKey(d => d.VoteId)
             .OnDelete(DeleteBehavior.ClientSetNull)
             .HasConstraintName("FK_VoteTeamInfos_Vote");

            builder.ToTable("VoteTeamInfos");
        }
    }

}
