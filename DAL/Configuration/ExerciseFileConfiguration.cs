using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class ExerciseFileConfiguration : BaseEntityTypeConfiguration<Exercisefile>
    {
        public ExerciseFileConfiguration() : base("tbl") { }

        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Exercisefile> e)
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Id).ValueGeneratedOnAdd();

            e.Property(c => c.Filename).IsRequired().HasColumnType("VARCHAR(255)");
            e.HasIndex(c => c.Filename).IsUnique();

            e.Property(c => c.ContainsCurrency).IsRequired().HasColumnType("BIT");
            e.Property(c => c.ContainsDate).IsRequired().HasColumnType("BIT");
            e.Property(c => c.ContainsTime).IsRequired().HasColumnType("BIT");
            e.Property(c => c.ContainsGeographical).IsRequired().HasColumnType("BIT");
            e.Property(c => c.ContainsNamesToTranslate).IsRequired().HasColumnType("BIT");

            base.Configure(e);
        }
    }
}
