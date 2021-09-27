using Microsoft.EntityFrameworkCore;
using EduWiki.Domain.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduWiki.Persistence.Context
{
    public class EduWikiContext : DbContext
    {
        private readonly string _connectionString;

        #region Ctor

        public EduWikiContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public EduWikiContext(DbContextOptions<EduWikiContext> options) : base(options)
        {

        }

        #endregion

        #region Configuration
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(EduWikiContext).Assembly);
        }

        #endregion
        
        #region DbSets

        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<LecturerCourse> LecturerCourses { get; set; }

        #endregion
    }
}
