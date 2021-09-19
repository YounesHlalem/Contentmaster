using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class ContentElementTypeConfiguration : BaseEntityTypeConfiguration<ContentElementType>
    {
        public ContentElementTypeConfiguration() : base("tbl") { }

        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ContentElementType> e)
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Id).ValueGeneratedOnAdd();

            e.Property(c => c.Name).IsRequired().HasColumnType("VARCHAR(30)");
            e.HasIndex(c => c.Name).IsUnique();

            e.HasData(
                new ContentElementType { Name = "Quiz", Id = 1 },
                new ContentElementType { Name = "Test yourself", Id = 2 },
                new ContentElementType { Name = "Exam business", Id = 3 },
                new ContentElementType { Name = "Exam school", Id = 4 },
                new ContentElementType { Name = "Lesson fiche", Id = 5 }
            );

            base.Configure(e);
        }
    }
}
