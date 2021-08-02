using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PersonManagement.Service.Abstractions;
using PersonManagement.Service.Implementations;
using NLog.Extensions.Logging;

namespace Day_39.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {

        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IPersonService, PersonService>().AddLogging(builder => { builder.ClearProviders(); builder.AddNLog(); });
        }
    }
}
