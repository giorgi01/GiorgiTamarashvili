using EduWiki.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduWiki.DataEF.Extension
{
    public static class RepositoryExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<ILecturerRepository, LecturerRepository>();
            services.AddTransient<ICourseRepository, CourseRepository>();
            services.AddTransient<ILecturerCourseRepository, LecturerCourseRepository>();
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
        }
    }
}
