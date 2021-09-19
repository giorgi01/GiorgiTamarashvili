using EduWiki.Domain.POCO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduWiki.Persistence.Configurations
{
    class LecturerConfiguration : IEntityTypeConfiguration<Lecturer>
    {
        public void Configure(EntityTypeBuilder<Lecturer> builder)
        {
            builder.ToTable("Lecturers");
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => new { x.Email }).IsUnique();
            builder.Property(x => x.Email).IsUnicode(false).HasMaxLength(70);
            builder.Property(x => x.Phone).IsUnicode(false).HasMaxLength(25);
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.AboutText).HasMaxLength(300);
        }
    }
}
