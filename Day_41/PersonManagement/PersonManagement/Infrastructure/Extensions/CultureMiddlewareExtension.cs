using Microsoft.AspNetCore.Builder;
using PersonManagement.Infrastructure.Middlewares;

namespace PersonManagement.Infrastructure.Extensions
{
    public static class CultureMiddlewareExtension
    {
        public static IApplicationBuilder UseRequestCulture(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CultureMiddleware>();
        }
    }
}
