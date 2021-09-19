using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DAL.Model;

namespace DAL.Configuration
{
    public class RoleTranslationConfiguration : BaseEntityTypeConfiguration<RoleTranslation>
    {
        public RoleTranslationConfiguration() : base("tbl") { }

        public override void Configure(EntityTypeBuilder<RoleTranslation> e)
        {
            e.HasKey(c => new { c.LanguageId, c.RoleId });
            e.Property(c => c.Translation).IsRequired().HasColumnType("VARCHAR(30)");

            e.HasOne(c => c.Languages).WithMany().HasForeignKey(c => c.LanguageId);
            e.Property(c => c.LanguageId).IsRequired();
            e.HasOne(c => c.Role).WithMany().HasForeignKey(c => c.RoleId);
            e.Property(c => c.RoleId).IsRequired();

            base.Configure(e);
        }
    }
}
