using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class LanguageTranslationConfiguration : BaseEntityTypeConfiguration<LanguageTranslation>
    {
        public LanguageTranslationConfiguration() : base("tbl") { }

        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<LanguageTranslation> e)
        {
            e.HasKey(c => new { c.LanguageId, c.TranslationLanguageId });
            e.Property(c => c.Translation).IsRequired().HasColumnType("VARCHAR(30)");

            e.HasOne(c => c.TranslationLanguage).WithMany().HasForeignKey(k => k.TranslationLanguageId);
            e.Property(c => c.TranslationLanguageId).IsRequired();
            e.HasOne(c => c.Language).WithMany().HasForeignKey(k => k.LanguageId);
            e.Property(c => c.LanguageId).IsRequired();

            base.Configure(e);
        }
    }
}
