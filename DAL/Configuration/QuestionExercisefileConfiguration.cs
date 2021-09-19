using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class QuestionExercisefileConfiguration : BaseEntityTypeConfiguration<QuestionExercisefile>
    {
        public QuestionExercisefileConfiguration() : base("tbl") { }
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<QuestionExercisefile> e)
        {
            e.HasKey(c => new { c.QuestionId, c.ExercisefileId });
            e.HasOne(c => c.Question).WithMany().HasForeignKey(k => k.QuestionId);
            e.Property(c => c.QuestionId).IsRequired();
            e.HasOne(c => c.Exercisefile).WithMany().HasForeignKey(k => k.ExercisefileId);
            e.Property(c => c.ExercisefileId).IsRequired();

            base.Configure(e);
        }
    }
}
