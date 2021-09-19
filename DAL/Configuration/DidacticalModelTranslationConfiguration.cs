using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class DidacticalModelTranslationConfiguration : BaseEntityTypeConfiguration<DidacticalModelTranslation>
    {
        public DidacticalModelTranslationConfiguration() : base("tbl") { }

        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<DidacticalModelTranslation> e)
        {
            e.HasKey(c => new { c.LanguageId, c.DidacticalModelId });
            e.Property(c => c.Translation).IsRequired().HasColumnType("CHAR(30)");

            e.HasOne(c => c.DidacticalModel).WithMany().HasForeignKey(k => k.DidacticalModelId);
            e.Property(c => c.DidacticalModelId).IsRequired();
            e.HasOne(c => c.Language).WithMany().HasForeignKey(k => k.LanguageId);
            e.Property(c => c.LanguageId).IsRequired();

            base.Configure(e);
        }
    }
}
