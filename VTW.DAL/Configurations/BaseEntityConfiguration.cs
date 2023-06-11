using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VTW.DAL.Entities;

namespace VTW.DAL.Configurations
{
    class BaseEntityConfiguration<TEntity, TId> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity<TId>
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.Property<TId>("Id").HasColumnName(typeof(TEntity).Name + "Id");
            builder.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            builder.HasQueryFilter(m => !EF.Property<bool>(m, "IsDeleted"));
        }
    }
}
