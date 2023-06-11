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
    class GameTeamInfoConfiguration : BaseEntityConfiguration<GameTeamInfo, int>
    {
        public override void Configure(EntityTypeBuilder<GameTeamInfo> builder)
        {
            base.Configure(builder);

            builder.HasOne(d => d.GameNavigation)
             .WithMany(p => p.GameTeamInfoNavigations)
             .HasForeignKey(d => d.GameId)
             .OnDelete(DeleteBehavior.ClientSetNull)
             .HasConstraintName("FK_GameTeamInfos_Game");
            
            builder.Property(m => m.TotalAmount)
                .HasPrecision(12);

            builder.ToTable("GameTeamInfos");
        }
    }

}
