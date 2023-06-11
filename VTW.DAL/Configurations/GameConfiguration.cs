using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VTW.DAL.Entities;

namespace VTW.DAL.Configurations
{
    class GameConfiguration : BaseEntityConfiguration<Game, int>
    {
        public override void Configure(EntityTypeBuilder<Game> builder)
        {
            base.Configure(builder);

            builder.ToTable("Games");
        }
    }
}
