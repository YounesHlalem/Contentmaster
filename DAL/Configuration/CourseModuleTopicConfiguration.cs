using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class CourseModuleTopicConfiguration : BaseEntityTypeConfiguration<CourseModuleTopic>
    {
        public CourseModuleTopicConfiguration() : base("tbl") { }

        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CourseModuleTopic> e)
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Id).ValueGeneratedOnAdd();

            e.Property(c => c.Title).IsRequired().HasColumnType("VARCHAR(255)");
            e.HasIndex(c => c.Title).IsUnique();
            e.Property(c => c.Sortorder).IsRequired().HasColumnType("INT(11)");
            e.HasIndex(c => c.Sortorder).IsUnique();

            e.HasOne(c => c.CourseModule).WithMany().HasForeignKey(k => k.CourseModuleId);
            e.HasIndex(c => c.CourseModuleId).IsUnique();
            e.Property(c => c.CourseModuleId).IsRequired();

            base.Configure(e);
        }
    }
}
