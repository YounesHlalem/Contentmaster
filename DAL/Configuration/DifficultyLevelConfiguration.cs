using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class DifficultyLevelConfiguration : BaseDeleteEntityTypeConfiguration<DifficultyLevel>
    {
        public DifficultyLevelConfiguration() : base("tbl") { }

        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<DifficultyLevel> e)
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Id).ValueGeneratedOnAdd();

            e.Property(c => c.Number).IsRequired().HasColumnType("INT(11)");
            e.Property(c => c.Name).IsRequired().HasColumnType("VARCHAR(30)");
            e.HasIndex(c => c.Name).IsUnique();

            e.HasData(
                new DifficultyLevel { Number = 1, Name = "Explorer", Id = 1 },
                new DifficultyLevel { Number = 2, Name = "Adventurer", Id = 2 },
                new DifficultyLevel { Number = 3, Name = "Expert", Id = 3 },
                new DifficultyLevel { Number = 4, Name = "Master", Id = 4 }
            );

            base.Configure(e);
        }
    }
}
