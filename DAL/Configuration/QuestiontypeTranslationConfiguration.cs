using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DAL.Model;

namespace DAL.Configuration
{
    public class QuestiontypeTranslationConfiguration : BaseEntityTypeConfiguration<QuestiontypeTranslation>
    {
        public QuestiontypeTranslationConfiguration() : base("tbl"){}

        public override void Configure(EntityTypeBuilder<QuestiontypeTranslation> e)
        {
            e.HasKey(c => new { c.LanguageId, c.QuestiontypeId });
            e.Property(c => c.Translation).IsRequired().HasColumnType("VARCHAR(40)");

            e.HasOne(c => c.Questiontype).WithMany().HasForeignKey(c => c.QuestiontypeId);
            e.Property(c => c.QuestiontypeId).IsRequired();
            e.HasOne(c => c.Language).WithMany().HasForeignKey(c => c.LanguageId);
            e.Property(c => c.LanguageId).IsRequired();

            base.Configure(e);
        }
    }
}
