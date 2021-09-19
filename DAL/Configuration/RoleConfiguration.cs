using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    public class RoleConfiguration : BaseDeleteEntityTypeConfiguration<Role>
    {
        public RoleConfiguration() : base("tbl") { }
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Role> e)
        {
            e.HasKey(c => c.Id);
            e.Property(c => c.Id).ValueGeneratedOnAdd();

            e.Property(c => c.Name).IsRequired().HasColumnType("VARCHAR(30)");
            e.HasIndex(c => c.Name).IsUnique();

            e.Property(c => c.DisplayName).IsRequired().HasColumnType("VARCHAR(30)");

            e.HasData(
                new Role { Name = "User", DisplayName = "User", Id = 1 },
                new Role { Name = "Admin", DisplayName = "Administrator", Id = 2 },
                new Role { Name = "Content creator", DisplayName = "Content creator", Id = 3 },
                new Role { Name = "Teacher", DisplayName = "Teacher", Id = 4 },
                new Role { Name = "Manager", DisplayName = "Manager", Id = 5 },
                new Role { Name = "Site administrator", DisplayName = "Site administrator", Id = 6 }
            );

            base.Configure(e);
        }
    }
}
