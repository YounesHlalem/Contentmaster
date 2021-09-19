using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class DifficultyLevelTranslationConfiguration : BaseEntityTypeConfiguration<DifficultyLevelTranslation>
    {
        public DifficultyLevelTranslationConfiguration() : base("tbl") { }

        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<DifficultyLevelTranslation> e)
        {
            e.HasKey(c => new { c.LanguageId, c.DifficultyLevelId });
            e.Property(c => c.Translation).IsRequired().HasColumnType("VARCHAR(20)");

            e.HasOne(c => c.DifficultyLevel).WithMany().HasForeignKey(k => k.DifficultyLevelId);
            e.Property(c => c.DifficultyLevelId).IsRequired();
            e.HasOne(c => c.Language).WithMany().HasForeignKey(k => k.LanguageId);
            e.Property(c => c.LanguageId).IsRequired();

            base.Configure(e);
        }
    }
}
