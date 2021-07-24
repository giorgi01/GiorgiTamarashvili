using DependencyInjectionDemo;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using System.Text;

namespace Day_36.Middlewares
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly IWebHostEnvironment _env;

        public ExceptionHandlerMiddleware(RequestDelegate next, IWebHostEnvironment env)
        {
            _next = next;
            _env = env;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            var error = new ApiError(context, ex);

            context.Response.StatusCode = error.Status.Value;
            context.Response.ContentType = "text/html";
            string errorHtml = _env.IsDevelopment() ? ErrorHtml(error) : ErrorHtml(null);
            await context.Response.WriteAsync(errorHtml);
        }

        private static string ErrorHtml(ApiError error)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<html>");
            sb.Append("<head><link href =\"https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x\" crossorigin=\"anonymous\"></head> <body>\r\n");
            sb.Append("<div class=\"container d-flex justify-content-center vh-100 flex-column\">");
            sb.Append("<h2 className=\"text - info\">Something went wrong :(</h2><hr />");
            sb.Append(error != null ? $"{error.Title} {error.Type} {error.StackTrace}" : "");
            sb.Append("</div></body></html>\r\n");
            return sb.ToString();
        }
    }
}