using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class DidacticalModelLevelConfiguration : BaseEntityTypeConfiguration<DidacticalModelLevel>
    {
        public DidacticalModelLevelConfiguration() : base("tbl") { }

        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<DidacticalModelLevel> e)
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Id).ValueGeneratedOnAdd();

            e.Property(c => c.Name).IsRequired().HasColumnType("VARCHAR(30)");
            e.HasIndex(c => c.Name).IsUnique();
            e.Property(c => c.SortOrder).IsRequired().HasColumnType("INT(10)");
            e.HasIndex(c => c.SortOrder).IsUnique();

            e.HasOne(c => c.DidacticalModel).WithMany().HasForeignKey(k => k.DidacticalModelId);
            e.HasIndex(c => c.DidacticalModelId).IsUnique();
            e.Property(c => c.DidacticalModelId).IsRequired();

            e.HasData(
                new DidacticalModelLevel { Id = 1, Name = "Remember", DidacticalModelId = 1, SortOrder = 1 },
                new DidacticalModelLevel { Id = 2, Name = "Understand", DidacticalModelId = 1, SortOrder = 2 },
                new DidacticalModelLevel { Id = 3, Name = "Apply", DidacticalModelId = 1, SortOrder = 3 },
                new DidacticalModelLevel { Id = 4, Name = "Analyze", DidacticalModelId = 1, SortOrder = 4 },
                new DidacticalModelLevel { Id = 5, Name = "Evaluate", DidacticalModelId = 1, SortOrder = 5 },
                new DidacticalModelLevel { Id = 6, Name = "Create", DidacticalModelId = 1, SortOrder = 6 },
                new DidacticalModelLevel { Id = 7, Name = "Low", DidacticalModelId = 2, SortOrder = 1 },
                new DidacticalModelLevel { Id = 8, Name = "Average", DidacticalModelId = 2, SortOrder = 2 },
                new DidacticalModelLevel { Id = 9, Name = "High", DidacticalModelId = 2, SortOrder = 3 }
            );

            base.Configure(e);
        }
    }
}
