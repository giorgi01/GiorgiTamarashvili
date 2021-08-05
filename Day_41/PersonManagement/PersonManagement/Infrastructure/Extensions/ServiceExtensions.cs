using Microsoft.Extensions.DependencyInjection;
using PersonManagement.Service.Abstractions;
using PersonManagement.Service.Implementations;

namespace PersonManagement.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IPersonService, PersonService>();
        }
    }
}
