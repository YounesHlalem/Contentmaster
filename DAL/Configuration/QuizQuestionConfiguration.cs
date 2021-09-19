using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    class QuizQuestionConfiguration : BaseEntityTypeConfiguration<QuizQuestion>
    {
        public QuizQuestionConfiguration() : base("tbl") { }

        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<QuizQuestion> e)
        {
            e.HasKey(c => new { c.QuestionId, c.QuizId });
            e.Property(c => c.Sortorder).IsRequired().HasColumnType("INT(11)");
            e.HasIndex(c => c.Sortorder).IsUnique();

            e.HasOne(c => c.Quiz).WithMany().HasForeignKey(k => k.QuizId);
            e.HasIndex(c => c.QuizId).IsUnique();
            e.Property(c => c.QuizId).IsRequired();
            e.HasOne(c => c.Question).WithMany().HasForeignKey(k => k.QuestionId);
            e.Property(c => c.QuestionId).IsRequired();

            base.Configure(e);
        }
    }
}
