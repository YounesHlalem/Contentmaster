using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class ContentThemeConfiguration : BaseEntityTypeConfiguration<ContentTheme>
    {
        public ContentThemeConfiguration() : base("tbl") { }
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<ContentTheme> e)
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Id).ValueGeneratedOnAdd();

            e.Property(c => c.Name).IsRequired().HasColumnType("VARCHAR(40)");
            e.HasIndex(c => c.Name).IsUnique();

            base.Configure(e);
        }
    }
}
