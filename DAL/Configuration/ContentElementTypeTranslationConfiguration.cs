using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class ContentElementTypeTranslationConfiguration : BaseEntityTypeConfiguration<ContentElementTypeTranslation>
    {
        public ContentElementTypeTranslationConfiguration() : base("tbl") { }

        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ContentElementTypeTranslation> e)
        {
            e.Property(c => c.Translation).IsRequired().HasColumnType("VARCHAR(40)");
            
            e.HasOne(c => c.Language).WithMany().HasForeignKey(k => k.LanguageId);
            e.Property(c => c.LanguageId).IsRequired();
            e.HasOne(c => c.ContentElementType).WithMany().HasForeignKey(k => k.ContentElementTypeId);
            e.Property(c => c.ContentElementTypeId).IsRequired();

            e.HasKey(c => new { c.LanguageId, c.ContentElementTypeId }).HasName("PrimaryKey_ContentElementTypeTranslation");

            base.Configure(e);
        }
    }
}
