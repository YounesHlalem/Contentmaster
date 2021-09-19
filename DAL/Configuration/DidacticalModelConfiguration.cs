using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class DidacticalModelConfiguration : BaseDeleteEntityTypeConfiguration<DidacticalModel>
    {
        public DidacticalModelConfiguration() : base("tbl") { }

        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<DidacticalModel> e)
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Id).ValueGeneratedOnAdd();

            e.Property(c => c.Name).IsRequired().HasColumnType("VARCHAR(30)");
            e.HasIndex(c => c.Name).IsUnique();

            e.HasData(
                new DidacticalModel { Id = 1, Name = "BLOOM"},
                new DidacticalModel { Id = 2, Name = "EVA" }
                );

            base.Configure(e);
        }
    }
}
