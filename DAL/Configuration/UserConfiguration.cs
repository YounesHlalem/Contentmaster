using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DAL.Model;
using System;

namespace DAL.Configuration
{
    public class UserConfiguration : BaseEntityTypeConfiguration<User>
    {
        public UserConfiguration() : base("tbl") { }

        public override void Configure(EntityTypeBuilder<User> e)
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Id).ValueGeneratedOnAdd();

            e.Property(c => c.Firstname).HasColumnType("VARCHAR(70)");
            e.Property(c => c.Lastname).HasColumnType("VARCHAR(70)");
            e.Property(c => c.Password).HasColumnType("VARCHAR(60)");
            e.Property(c => c.Email).IsRequired().HasColumnType("VARCHAR(100)");
            e.HasIndex(c => c.Email).IsUnique();

            e.HasOne(c => c.PreferredLanguage).WithMany().HasForeignKey(c => c.PreferredLanguageId);
            e.Property(c => c.PreferredLanguageId).IsRequired();

#if DEBUG
            Console.WriteLine("Creating default admin");
            // Default password = 123456789
            e.HasData(
                new User { Id = 1, Email = "admin@local.host", Firstname = "Admin", Lastname = "Admin", PreferredLanguageId = 1, Password= "$2a$11$DM380SovMqqQpFqCGTPL3uAL64fG7.MRSlzb/gLrRSvJOmwhQw/Ze" });
#endif

            base.Configure(e);
        }
    }
}
