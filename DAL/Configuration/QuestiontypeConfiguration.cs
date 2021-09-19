using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DAL.Model;

namespace DAL.Configuration
{
    public class QuestiontypeConfiguration : BaseEntityTypeConfiguration<Questiontype>
    {
        public QuestiontypeConfiguration() : base("tbl")
        {

        }

        public override void Configure(EntityTypeBuilder<Questiontype> e)
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Id).ValueGeneratedOnAdd();

            e.Property(c => c.Name).IsRequired().HasColumnType("VARCHAR(40)");
            e.HasIndex(c => c.Name).IsUnique();

            e.HasData(
                new Questiontype { Name = "True/false question", Id = 1 }
            );

            base.Configure(e);
        }
    }
}
