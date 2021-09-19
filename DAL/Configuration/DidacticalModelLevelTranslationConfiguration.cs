using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class DidacticalModelLevelTranslationConfiguration : BaseEntityTypeConfiguration<DidacticalModelLevelTranslation>
    {
        public DidacticalModelLevelTranslationConfiguration() : base("tbl") { }

        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<DidacticalModelLevelTranslation> e)
        {
            e.HasKey(c => new { c.LanguageId, c.DidacticalModelLevelId });
            e.Property(c => c.Translation).HasColumnType("VARCHAR(30)");

            e.HasOne(c => c.DidacticalModelLevel).WithMany().HasForeignKey(k => k.DidacticalModelLevelId);
            e.Property(c => c.DidacticalModelLevelId).IsRequired();
            e.HasOne(c => c.Language).WithMany().HasForeignKey(k => k.LanguageId);
            e.Property(c => c.LanguageId).IsRequired();

            base.Configure(e);
        }
    }
}
