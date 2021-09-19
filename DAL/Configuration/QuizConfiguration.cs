using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DAL.Model;

namespace DAL.Configuration
{
    public class QuizConfiguration : BaseEntityTypeConfiguration<Quiz>
    {
        public QuizConfiguration() : base("tbl") { }

        public override void Configure(EntityTypeBuilder<Quiz> e)
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Id).ValueGeneratedOnAdd();

            e.Property(c => c.Title).IsRequired().HasColumnType("varchar(255)");
            e.Property(c => c.ShortIntro).HasColumnType("text").HasColumnName("short_intro");
            e.Property(c => c.Intro).HasColumnType("text");
            e.Property(c => c.DefaultTimeLimit).IsRequired().HasColumnType("time").HasColumnName("default_time_limit");
            e.Property(c => c.DefaultMinimumScore).IsRequired().HasColumnType("decimal(12,7)").HasColumnName("default_minimum_score");
            e.Property(c => c.IdentificationCode).IsRequired().HasColumnType("varchar(100)").HasColumnName("Identification_code");
            e.HasIndex(c => c.IdentificationCode).IsUnique();
            e.Property(c => c.Replicationkey).IsRequired().HasColumnType("VARchar(36)");
            e.HasIndex(c => c.Replicationkey).IsUnique();

            e.HasOne(c => c.OfficeApplications).WithMany().HasForeignKey(c => c.OfficeApplicationId);
            e.HasIndex(c => c.OfficeApplicationId).IsUnique();
            e.Property(c => c.OfficeApplicationId).IsRequired();
            e.HasOne(c => c.InstructionsLanguage).WithMany().HasForeignKey(c => c.InstructionsLanguageId);
            e.Property(c => c.InstructionsLanguageId).IsRequired();
            e.HasOne(c => c.UserinterfaceLanguage).WithMany().HasForeignKey(c => c.UserinterfaceLanguageId);

            base.Configure(e);
        }
    }
}
