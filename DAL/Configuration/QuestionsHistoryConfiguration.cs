using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DAL.Model;

namespace DAL.Configuration
{
    public class QuestionsHistoryConfiguration : BaseEntityTypeConfiguration<QuestionsHistory>
    {
        public QuestionsHistoryConfiguration() : base("tbl")
        {

        }

        public override void Configure(EntityTypeBuilder<QuestionsHistory> e)
        {
            e.HasNoKey();
            e.Property(c => c.QuestionReplicationkey).IsRequired().HasColumnType("VARCHAR(36)");
            e.Property(c => c.Action).IsRequired().HasColumnType("CHAR(1)");
            e.Property(c => c.ActionTimestamp).IsRequired().HasColumnType("DATETIME");
            e.Property(c => c.QuestionTypeId).IsRequired().HasColumnType("INT(11)");
            e.Property(c => c.IsMasterQuestion).HasColumnType("BIT");
            e.Property(c => c.MasterQuestionId).HasColumnType("INT(11)");
            e.Property(c => c.InstructionsLanguageId).HasColumnType("INT(11)");
            e.Property(c => c.UserinterfaceLanguageId).HasColumnType("INT(11)");
            e.Property(c => c.QuestionFormulationTypeId).HasColumnType("INT(11)");
            e.Property(c => c.OfficeApplicationId).HasColumnType("INT(11)");
            e.Property(c => c.title).HasColumnType("VARCHAR(100)");
            e.Property(c => c.Questiontext).HasColumnType("TEXT");
            e.Property(c => c.Notes).HasColumnType("TEXT");
            e.Property(c => c.VersionNumber).HasColumnType("INT(11)");

            e.HasOne(c => c.ActionDoneByUser).WithMany().HasForeignKey(c => c.ActionDoneByUserId);
            e.Property(c => c.ActionDoneByUserId).IsRequired();

            base.Configure(e);
        }
    }
}
