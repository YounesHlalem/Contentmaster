using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DAL.Model;

namespace DAL.Configuration
{
    public class QuizQuestionAnswerConfiguration : BaseEntityTypeConfiguration<QuizQuestionAnswer>
    {
        public QuizQuestionAnswerConfiguration() : base("tbl")
        {
        }

        public override void Configure(EntityTypeBuilder<QuizQuestionAnswer> e)
        {
            e.HasKey(c => new { c.QuestionAnswerId, c.QuestionId, c.QuizId });
            e.Property(c => c.Fraction).IsRequired().HasColumnType("DECIMAL(12, 7)");

            e.HasOne(c => c.QuestionAnswer).WithMany(c => c.QuestionList).HasForeignKey(c => c.QuestionAnswerId);
            e.Property(c => c.QuestionAnswerId).IsRequired();
            e.HasOne(c => c.Quiz).WithMany(c => c.QuestionList).HasForeignKey(c => c.QuizId);
            e.Property(c => c.QuizId).IsRequired();
            e.HasOne(c => c.Question).WithMany(c => c.QuestionList).HasForeignKey(c => c.QuestionId);
            e.Property(c => c.QuestionId).IsRequired();

            base.Configure(e);
        }
    }
}
