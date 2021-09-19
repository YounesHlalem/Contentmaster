using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class QuestionFormulationTypeTranslationConfiguration : BaseEntityTypeConfiguration<QuestionFormulationTypeTranslation>
    {
        public QuestionFormulationTypeTranslationConfiguration() : base("tbl") { }
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<QuestionFormulationTypeTranslation> e)
        {
            e.HasKey(c => new { c.LanguageId, c.QuestionFormulationTypeId });
            e.Property(c => c.Translation).IsRequired().HasColumnType("VARCHAR(20)");

            e.HasOne(c => c.QuestionFormulationType).WithMany().HasForeignKey(k => k.QuestionFormulationTypeId);
            e.Property(c => c.QuestionFormulationTypeId).IsRequired();
            e.HasOne(c => c.Language).WithMany().HasForeignKey(k => k.LanguageId);
            e.Property(c => c.LanguageId).IsRequired();

            base.Configure(e);
        }
    }
}
