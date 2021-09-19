using Microsoft.EntityFrameworkCore;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Configuration
{
    class UserRoleConfiguration : BaseEntityTypeConfiguration<UserRole>
    {
        public UserRoleConfiguration() : base("tbl") { }
        public override void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<UserRole> e)
        {
            e.HasKey(c => new { c.RoleId, c.UserId });

            e.HasOne(c => c.User).WithMany().HasForeignKey(k => k.UserId);
            e.Property(c => c.UserId).IsRequired();
            e.HasOne(c => c.Role).WithMany().HasForeignKey(k => k.RoleId);
            e.Property(c => c.RoleId).IsRequired();

            base.Configure(e);
        }
    }
}
