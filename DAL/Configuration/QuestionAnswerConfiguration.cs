using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class QuestionAnswerConfiguration : BaseEntityTypeConfiguration<QuestionAnswer>
    {
        public QuestionAnswerConfiguration() : base("tbl") { }
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<QuestionAnswer> e)
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Id).ValueGeneratedOnAdd();

            e.Property(c => c.Answer).IsRequired().HasColumnType("TEXT");

            e.HasOne(c => c.Question).WithMany().HasForeignKey(k => k.Questionid);
            e.Property(c => c.Questionid).IsRequired();

            base.Configure(e);
        }
    }
}
