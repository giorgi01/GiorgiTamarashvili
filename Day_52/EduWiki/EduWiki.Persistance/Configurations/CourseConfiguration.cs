using EduWiki.Domain.POCO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduWiki.Persistence.Configurations
{
    class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("Courses");
            builder.Property(x => x.Name).IsUnicode(false).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Faculty).IsUnicode(false).IsRequired().HasMaxLength(50);
            builder.Property(x => x.ECTS).IsRequired().HasColumnType("int");
        }
    }
}
