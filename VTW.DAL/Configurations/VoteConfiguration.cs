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
          
            builder.ToTable("Votes");
        }
    }
}
