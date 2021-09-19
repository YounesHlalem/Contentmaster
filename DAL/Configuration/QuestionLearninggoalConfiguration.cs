using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class QuestionLearninggoalConfiguration : BaseEntityTypeConfiguration<QuestionLearninggoal>
    {
        public QuestionLearninggoalConfiguration() : base("tbl") { }
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<QuestionLearninggoal> e)
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Id).ValueGeneratedOnAdd();

            e.Property(c => c.Learninggoal).IsRequired().HasColumnType("TEXT");
            e.Property(c => c.IsMeasurable).IsRequired().HasColumnType("BIT(1)");
            e.Property(c => c.Notes).HasColumnType("TEXT");
            e.Property(c => c.SortOrder).IsRequired().HasColumnType("INT(11)");
            e.HasIndex(c => c.SortOrder).IsUnique();

            e.HasOne(c => c.Question).WithMany().HasForeignKey(k => k.QuestionId);
            e.HasIndex(c => c.QuestionId).IsUnique();
            e.Property(c => c.QuestionId).IsRequired();
            e.HasOne(c => c.DidacticalModelLevel).WithMany().HasForeignKey(k => k.DidacticalModelLevelId);
            e.Property(c => c.DidacticalModelLevelId).IsRequired();

            base.Configure(e);
        }
    }
}
