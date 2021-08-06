using Microsoft.AspNetCore.Builder;
using Day_39.Infrastructure.Middlewares;

namespace Day_39.Infrastructure.Extensions
{
    public static class LoggerMiddlewareExtension
    {
        public static IApplicationBuilder UseLoggerMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoggerMiddleware>();
        }
    }
}
