using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class QuestionFormulationTypeConfiguration : BaseEntityTypeConfiguration<QuestionFormulationType>
    {
        public QuestionFormulationTypeConfiguration() : base("tbl") { }
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<QuestionFormulationType> e)
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Id).ValueGeneratedOnAdd();

            e.Property(c => c.Name).HasColumnType("VARCHAR(20)");

            e.HasData(
                new QuestionFormulationType { Name = "Open", Id = 1 },
                new QuestionFormulationType { Name = "Semi-open", Id = 2 },
                new QuestionFormulationType { Name = "Closed", Id = 3 }
            );

            base.Configure(e);
        }
    }
}
