using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class QuestionPreKnowledgeSkillConfiguration : BaseEntityTypeConfiguration<QuestionPreKnowledgeSkill>
    {
        public QuestionPreKnowledgeSkillConfiguration() : base("tbl") { }
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<QuestionPreKnowledgeSkill> e)
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Id).ValueGeneratedOnAdd();

            e.Property(c => c.Skill).IsRequired().HasColumnType("TEXT");
            e.Property(c => c.SortOrder).IsRequired().HasColumnType("INT(11)");
            e.HasIndex(c => c.SortOrder).IsUnique();

            e.HasOne(c => c.Question).WithMany().HasForeignKey(k => k.QuestionId);
            e.HasIndex(c => c.QuestionId).IsUnique();
            e.Property(c => c.QuestionId).IsRequired();

            base.Configure(e);
        }
    }
}
