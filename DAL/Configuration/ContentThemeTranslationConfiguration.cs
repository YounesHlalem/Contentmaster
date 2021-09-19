using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class ContentThemeTranslationConfiguration : BaseEntityTypeConfiguration<ContentThemeTranslation>
    {
        public ContentThemeTranslationConfiguration() : base("tbl") { }

        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ContentThemeTranslation> e)
        {
            e.HasKey(c => new { c.ContentThemeId, c.LanguageId });
            e.Property(c => c.Translation).IsRequired().HasColumnType("VARCHAR(40)");

            e.HasOne(c => c.ContentTheme).WithMany().HasForeignKey(k => k.ContentThemeId);
            e.Property(c => c.ContentThemeId).IsRequired();
            e.HasOne(c => c.Language).WithMany().HasForeignKey(k => k.LanguageId);
            e.Property(c => c.LanguageId).IsRequired();

            base.Configure(e);
        }
    }
}
