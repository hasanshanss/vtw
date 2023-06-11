using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VTW.DAL.Entities;

namespace VTW.DAL.Configurations
{
    class VoterConfiguration : IEntityTypeConfiguration<Voter>
    {
        public void Configure(EntityTypeBuilder<Voter> builder)
        {
            builder.Property(m => m.Balance)
                .HasPrecision(12);

            builder.ToTable("Voters");
        }
       
    }
}
