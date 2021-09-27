using EduWiki.DataEF.Extension;
using EduWiki.Services.Abstractions;
using EduWiki.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace EduWiki.Services.Extentions
{
    public static class ServiceExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<ILecturerService, LecturerService>();
            services.AddTransient<IFileService, ImageService>();

            #region Repositories

            services.AddRepositories();

            #endregion
        }
    }
}
