using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DAL.Model.Interface;

namespace DAL.Configuration
{
    public abstract class BaseDeleteEntityTypeConfiguration<TBase> : BaseEntityTypeConfiguration<TBase> where TBase : IIsDeleted
    {
        public BaseDeleteEntityTypeConfiguration(string TableName) : base(TableName) { }

        public override void Configure(EntityTypeBuilder<TBase> builder)
        {
            builder.HasQueryFilter(p => !p.IsDeleted);
            builder.Property(c => c.IsDeleted).HasDefaultValue(false);
            base.Configure(builder);
        }
    }
}
