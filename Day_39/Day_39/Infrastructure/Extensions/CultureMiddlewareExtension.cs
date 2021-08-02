using Microsoft.AspNetCore.Builder;
using Day_39.Infrastructure.Middlewares;

namespace Day_39.Infrastructure.Extensions
{
    public static class CultureMiddlewareExtension
    {
        public static IApplicationBuilder UseRequestCulture(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<CultureMiddleware>();
        }
    }
}
