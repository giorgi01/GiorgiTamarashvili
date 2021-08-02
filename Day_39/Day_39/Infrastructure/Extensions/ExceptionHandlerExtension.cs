using Microsoft.AspNetCore.Builder;
using Day_39.Infrastructure.Middlewares;

namespace Day_39.Infrastructure.Extensions
{
    public static class ExceptionHandlerExtension
    {
        public static IApplicationBuilder UseCustomExceptionHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandlerMiddleware>();
        }
    }
}
