using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class QuestionContentThemeConfiguration : BaseEntityTypeConfiguration<QuestionContentTheme>
    {
        public QuestionContentThemeConfiguration() : base("tbl") { }
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<QuestionContentTheme> e)
        {
            e.HasKey(c => new { c.ContentThemeId, c.QuestionId });
            e.HasOne(c => c.Question).WithMany().HasForeignKey(k => k.QuestionId);
            e.Property(c => c.QuestionId).IsRequired();
            e.HasOne(c => c.ContentTheme).WithMany().HasForeignKey(k => k.ContentThemeId);
            e.Property(c => c.ContentThemeId).IsRequired();

            base.Configure(e);
        }
    }
}
