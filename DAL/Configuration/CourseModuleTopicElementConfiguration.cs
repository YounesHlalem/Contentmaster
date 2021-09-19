using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class CourseModuleTopicElementConfiguration : BaseEntityTypeConfiguration<CourseModuleTopicElement>
    {
        public CourseModuleTopicElementConfiguration() : base("tbl") { }

        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CourseModuleTopicElement> e)
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Id).ValueGeneratedOnAdd();

            e.Property(c => c.ContentElementId).IsRequired().HasColumnType("INT(11)");
            e.HasIndex(c => c.ContentElementId).IsUnique();
            e.Property(c => c.Sortorder).IsRequired().HasColumnType("INT(11)");

            e.HasOne(c => c.ContentElementType).WithMany().HasForeignKey(k => k.ContentElementTypeId);
            e.HasIndex(c => c.ContentElementTypeId).IsUnique();
            e.Property(c => c.ContentElementId).IsRequired();
            e.HasOne(c => c.CourseModuleTopic).WithMany().HasForeignKey(k => k.CourseModuleTopicId);
            e.HasIndex(c => c.CourseModuleTopicId).IsUnique();
            e.Property(c => c.CourseModuleTopicId).IsRequired();
            e.HasOne(c => c.DifficultyLevel).WithMany().HasForeignKey(k => k.DifficultyLevelId);
            e.Property(c => c.DifficultyLevelId).IsRequired();

            base.Configure(e);
        }
    }
}
