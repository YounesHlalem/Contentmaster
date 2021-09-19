using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class OfficeApplicationConfiguration : BaseDeleteEntityTypeConfiguration<OfficeApplication>
    {
        public OfficeApplicationConfiguration() : base("tbl") { }
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<OfficeApplication> e)
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Id).ValueGeneratedOnAdd();

            e.Property(c => c.Name).IsRequired().HasColumnType("VARCHAR(30)");
            e.HasIndex(c => c.Name).IsUnique();

            e.HasData(
                new OfficeApplication { Name = "Word", Id=1 },
                new OfficeApplication { Name = "Excel", Id = 2 },
                new OfficeApplication { Name = "Powerpoint", Id = 3 },
                new OfficeApplication { Name = "Access", Id = 4 },
                new OfficeApplication { Name = "OneNote", Id = 5 },
                new OfficeApplication { Name = "Outlook", Id = 6 }
                
            );

            base.Configure(e);
        }
    }
}
