using EduWiki.Domain.POCO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduWiki.Persistence.Configurations
{
    class LecturerCourseConfiguration : IEntityTypeConfiguration<LecturerCourse>
    {
        public void Configure(EntityTypeBuilder<LecturerCourse> builder)
        {
            builder.ToTable("LecturerCourses");

            builder.HasKey(lc => new { lc.LecturerId, lc.CourseId });

            builder.HasOne(lc => lc.Lecturer)
            .WithMany(l => l.LecturerCourses)
            .HasForeignKey(l => l.LecturerId);

            builder.HasOne(lc => lc.Course)
            .WithMany(c => c.LecturerCourses)
            .HasForeignKey(c => c.CourseId);
        }
    }
}
