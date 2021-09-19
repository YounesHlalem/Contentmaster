using Microsoft.EntityFrameworkCore;
using DAL.Model;

namespace DAL.Configuration
{
    public class LanguageConfiguration : BaseDeleteEntityTypeConfiguration<Language>
    {
        public LanguageConfiguration() : base("tbl") { }
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Language> e)
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Id).ValueGeneratedOnAdd();

            e.Property(c => c.NativeName).IsRequired().HasColumnType("VARCHAR(30)");
            e.HasIndex(c => c.NativeName).IsUnique();

            e.Property(c => c.Code).IsRequired().HasColumnType("VARCHAR(3)");
            e.HasIndex(c => c.Code).IsUnique();

            e.HasData(
                new Language { Code = "NL", NativeName = "Nederlands", Id = 1 },
                new Language { Code = "EN", NativeName = "English", Id = 2 },
                new Language { Code = "FR", NativeName = "Français", Id = 3 }
                );

            base.Configure(e);
        }
    }
}
