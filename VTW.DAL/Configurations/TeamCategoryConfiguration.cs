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
    class TeamCategoryConfiguration : BaseEntityConfiguration<TeamCategory, int>
    {
        public override void Configure(EntityTypeBuilder<TeamCategory> builder)
        {
            base.Configure(builder);

            
            builder.ToTable("TeamCategories");
        }
    }

}
