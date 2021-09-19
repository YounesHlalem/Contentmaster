using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class CourseConfiguration : BaseEntityTypeConfiguration<Course>
    {
        public CourseConfiguration() : base("tbl") { }

        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Course> e)
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Id).ValueGeneratedOnAdd();

            e.Property(c => c.Name).IsRequired().HasColumnType("VARCHAR(255)");
            e.Property(c => c.Icon).HasColumnType("VARCHAR(255)");
            e.Property(c => c.CreatedOn).IsRequired().HasColumnType("DATE");
            e.Property(c => c.Replicationkey).IsRequired().HasColumnType("VARCHAR(36)");
            e.HasIndex(c => c.Replicationkey).IsUnique();

            e.HasOne(c => c.InstructionsLanguage).WithMany().HasForeignKey(k => k.InstructionsLanguageId);
            e.Property(c => c.InstructionsLanguageId).IsRequired();
            e.HasOne(c => c.UserinterfaceLanguage).WithMany().HasForeignKey(k => k.UserinterfaceLanguageId);
            e.Property(c => c.UserinterfaceLanguageId).IsRequired();
            e.HasOne(c => c.OfficeApplication).WithMany().HasForeignKey(k => k.OfficeApplicationId);
            e.Property(c => c.OfficeApplicationId).IsRequired();
            e.HasOne(c => c.User).WithMany().HasForeignKey(k => k.CreatedBy);
            e.Property(c => c.CreatedBy).IsRequired();

            base.Configure(e);
        }
    }
}
