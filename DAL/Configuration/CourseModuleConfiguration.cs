using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class CourseModuleConfiguration : BaseEntityTypeConfiguration<CourseModule>
    {
        public CourseModuleConfiguration() : base("tbl") { }

        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<CourseModule> e)
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Id).ValueGeneratedOnAdd();

            e.Property(c => c.Title).IsRequired().HasColumnType("VARCHAR(255)");
            e.HasIndex(c => c.Title).IsUnique();
            e.Property(c => c.Sortorder).IsRequired().HasColumnType("INT(11)");
            e.HasIndex(c => c.Sortorder).IsUnique();

            e.HasOne(c => c.Course).WithMany().HasForeignKey(k => k.CourseId);
            e.HasIndex(c => c.CourseId).IsUnique();
            e.Property(c => c.CourseId).IsRequired();

            base.Configure(e);
        }
    }
}
