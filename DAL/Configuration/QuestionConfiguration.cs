using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DAL.Model;

namespace DAL.Configuration
{
    public class QuestionConfiguration : BaseEntityTypeConfiguration<Question>
    {
        public QuestionConfiguration() : base("tbl") { }

        public override void Configure(EntityTypeBuilder<Question> e)
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Id).ValueGeneratedOnAdd();

            e.Property(c => c.IsMasterQuestion).HasColumnType("BIT").IsRequired();
            e.Property(c => c.Title).HasColumnType("VARCHAR(100)").IsRequired();
            e.Property(c => c.Questiontext).HasColumnType("TEXT").IsRequired();
            e.Property(c => c.Notes).HasColumnType("TEXT");
            e.Property(c => c.VersionNumber).HasColumnType("INT(11)").IsRequired();
            e.Property(c => c.Replicationkey).HasColumnType("VARCHAR(36)").IsRequired();
            e.HasIndex(c => c.Replicationkey).IsUnique();
            

            e.HasOne(c => c.Questiontype).WithMany().HasForeignKey(c => c.QuestionTypeId);
            e.Property(c => c.QuestionTypeId).IsRequired();

            e.HasOne(c => c.MasterQuestion).WithMany().HasForeignKey(c => c.MasterQuestionId);
            e.Property(c => c.MasterQuestionId).IsRequired();

            e.HasOne(c => c.InstructionsLanguage).WithMany().HasForeignKey(c => c.InstructionsLanguageId);
            e.Property(c => c.InstructionsLanguageId).IsRequired();
            e.HasOne(c => c.UserinterfaceLanguage).WithMany().HasForeignKey(c => c.UserinterfaceLanguageId);
            e.HasOne(c => c.QuestionFormulationType).WithMany().HasForeignKey(c => c.QuestionFormulationTypeId);
            e.Property(c => c.QuestionFormulationTypeId).IsRequired();
            e.HasOne(c => c.OfficeApplication).WithMany().HasForeignKey(c => c.OfficeApplicationId);
            e.Property(c => c.OfficeApplicationId).IsRequired();

            base.Configure(e);
        }
    }
}
