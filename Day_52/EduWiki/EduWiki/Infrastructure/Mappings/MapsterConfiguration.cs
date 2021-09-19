using Mapster;
using Microsoft.Extensions.DependencyInjection;
using EduWiki.Domain.POCO;
using EduWiki.Services.Models;
using System.Linq;
using EduWiki.ViewModels;

namespace EduWiki.Infrastructure.Mappings
{
    public static class MapsterConfiguration
    {
        public static void RegisterMaps(this IServiceCollection services)
        {
            TypeAdapterConfig<Lecturer, LecturerServiceModel>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<Course, CourseServiceModel>
            .NewConfig()
            .TwoWays();

            TypeAdapterConfig<CourseServiceModel, CourseViewModel>
            .NewConfig()
            .TwoWays();


            TypeAdapterConfig<Lecturer, LecturerServiceModel>
            .NewConfig()
            .Map(dest => dest.Courses,
            src => src.LecturerCourses.Select(x => x.Course));

            TypeAdapterConfig<LecturerServiceModel, Lecturer>
            .NewConfig()
            .Map(dest => dest.LecturerCourses,
            src => src.Courses.Select(x => new LecturerCourse { Course = x.Adapt<Course>(), LecturerId = src.Id, CourseId = x.Id }));

            TypeAdapterConfig<LecturerViewModel, LecturerServiceModel>
            .NewConfig()
            .TwoWays();
        }
    }
}